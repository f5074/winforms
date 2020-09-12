using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Launcher
{
    public partial class Form1 : Form
    {
        private string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private List<MenuVo> menuList;
        private string programPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        Assembly assembly;
        public Form1()
        {
            InitializeComponent();
            menuList =SearchAssembly("F5074.UI");
            menuList.OrderByDescending(o => o.Name).ToList();
            for (int x = 0; x < menuList.Count; x++)
            {
                MenuVo t = menuList[x];
                this.treeView1.Nodes.Add(t.Name, t.Name, 0);
            }
            this.treeView1.DoubleClick += TreeView1_DoubleClick;
        }

        private void TreeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                object mainTab = new object();

                // https://lambdaexp.tistory.com/19
                // https://m.blog.naver.com/delight_gruv/130071915177
                string className = "";

                for (int x = 0; x < menuList.Count; x++)
                {
                    if (menuList[x].FullName.Contains("F5074.UI") && menuList[x].Name.Contains(this.treeView1.SelectedNode.Text))
                    {
                        className = menuList[x].FullName;
                        assembly = Assembly.LoadFrom(programPath + "\\F5074.UI.dll");
                        break;
                    }
                }

                Type t = assembly.GetType(className);
                string classNamespace = t.Namespace;
                Object obj = Activator.CreateInstance(t);
                Control tabControl = obj as Control;
                tabControl.Dock = DockStyle.Fill;
                string tabName = this.treeView1.SelectedNode.Text;
                TabPage tabPage = new TabPage() { Name = tabName, Text = tabName };
                tabPage.Controls.Add(tabControl);
                tabControl1.TabPages.Add(tabPage);
                tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<MenuVo> SearchAssembly(string dllName)
        {
            // https://dotnetcademy.net/Learn/4/Pages/3
            // http://www.hoons.net/Board/qacshap/Content/59151
            List<MenuVo> result = new List<MenuVo>();

            Assembly assembly = Assembly.LoadFrom(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + string.Format("\\{0}.dll",dllName));
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                var typeInfo = type.GetTypeInfo();
                if (typeInfo.BaseType != null)
                {
                    if (typeInfo.FullName.Contains(dllName) && typeInfo.BaseType.Name == "UserControl")
                    {
                        result.Add(new MenuVo() { Name = type.Name, FullName = type.FullName });
                    }
                }

            }
            return result;
        }
        public class MenuVo
        {
            public string MenuFullPath { get; set; }
            public string MenuName { get; set; }
            public string ClassName { get; set; }
            public string AssemblyName { get; set; }
            public string Name { get; set; }
            public string FullName { get; set; }
            public string Folder { get; set; }
        }
    }
}
