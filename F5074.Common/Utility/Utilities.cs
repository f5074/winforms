using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using F5074.Common.Controls;
using F5074.Common.Helper;

namespace F5074.Common.Utility
{
    class Utilities
    {
        public void Linq01()
        {
            Test[] list = {
                              new Test(){A= 10, B= "A"},
                              new Test(){A= 10, B= "A"},
                              new Test(){A= 10, B= "A"},
                              new Test(){A= 10, B= "A"},
                              new Test(){A= 10, B= "A"},
                          };

            var wo = from woman in list
                     where woman.A > 20 && woman.B == "C"
                     orderby woman.A
                     select woman;
            List<Test> tempList = wo.ToList<Test>();
            Console.WriteLine(tempList[0].B);


        }

        public class Test
        {
            public int A { get; set; }
            public string B { get; set; }
        }

        public void Regedit01()
        {
            string path = System.Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
            string[] oldPath = path.Split(';');
            StringBuilder newPath = new StringBuilder();
            if (!oldPath.Contains(""))
            {
                newPath.Append("" + ";");
                foreach (string ePath in oldPath)
                    Console.WriteLine(ePath);
            }

        }


        public class F5074Utils<T>
        {
            public void GetMethodList()
            {
                MethodInfo[] methodInfos = typeof(T).GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.SuppressChangeType);
                Array.Sort(methodInfos, delegate(MethodInfo me1, MethodInfo me2)
                {
                    return me1.Name.CompareTo(me2.Name);
                });

                foreach (MethodInfo me in methodInfos)
                {
                    Console.WriteLine(me.Name);
                }
            }


        }
        public void GetMethod()
        {
            F5074Utils<BaseTabControl> list = new F5074Utils<BaseTabControl>();
            list.GetMethodList();
        }

        public void LambdaClickEvnet()
        {
            //this.button1.Click += (seinder, e) =>
            //{
            //    if(/((Button)sender).BackColor !=.Color.Red){
            //    }
            //};

        }

        public void LambdaCalc()
        {
            int[] num = { 2, 3, 4 };
            var numbers = num.Select(x => x * x);
            string.Join(",", numbers);
        }


        public void MethodList()
        {
            List<Type> list = new List<Type>();
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                MethodBase mb = MethodBase.GetCurrentMethod();
                string a = mb.Name + mb.ReflectedType.Name;
            }

        }

        public void Reflection02()
        {
            Console.WriteLine(Assembly.GetEntryAssembly().Location);
            Console.WriteLine(Path.GetFileName(Assembly.GetCallingAssembly().Location));
            Assembly[] asss = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly ass in asss)
            {
                if (ass.ManifestModule.ScopeName == "")
                {
                    Console.WriteLine(ass.FullName);
                }
            }


        }

        private string ToCamelLower(string _value)
        {
            TextInfo ti = new CultureInfo("en-US", false).TextInfo;
            string sR = "";
            string[] spTest = _value.ToLower().Split('_');
            if (!string.IsNullOrWhiteSpace(_value) && _value.Contains("_"))
            {
                for (int x = 0; x < spTest.Length; x++)
                {
                    if (x == 0) sR = sR + spTest[x];
                    else sR = sR + ti.ToTitleCase(spTest[x]);
                }
            }
            else if (!string.IsNullOrWhiteSpace(_value) && !_value.Contains("_"))
            {
                for (int x = 0; x < spTest.Length; x++)
                {
                    if (x == 0) sR = sR + spTest[x];
                    else sR = sR + ti.ToTitleCase(spTest[x]);
                }
            }

            return "";


        }
    }
}
