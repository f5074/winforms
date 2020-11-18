using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using F5074.Common.Controls;
using F5074.Common.Helper;
using System.IO;

namespace F5074.UI.View.QueryExecutor
{
    public partial class QueryExecutor : UserControl
    {
        public QueryExecutor()
        {
            InitializeComponent();
            this.baseButton1.Click += baseButton1_Click;
            ContextMenuStrip cms = new ContextMenuStrip();
            ToolStripItem tsi = new ToolStripMenuItem() {Text = "Close All" };
            tsi.Click += tsi_Click;
            cms.Items.Add(tsi);
            baseTextBox1.Multiline = true;
        }

        void tsi_Click(object sender, EventArgs e)
        {
            if (((ToolStripItem)sender).Text == "Close All")
            {
                baseTabControl1.TabPages.Clear();
            }
        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.baseTextBox1.Text)) return;
            string[] mQuery = Regex.Split(baseTextBox1.Text, ";");
            int nullCnt = 0;
            for (int x = 0; x < mQuery.Length; x++)
            {
                if(string.IsNullOrWhiteSpace(mQuery[x]))
                {
                    nullCnt += 1;
                }
            }
            for (int numOfTab = 0; numOfTab < mQuery.Length; numOfTab++)
            {
                Control tabControl = new Control();
                BaseDataGridView grid = new BaseDataGridView();
                grid.Dock = DockStyle.Fill;
                grid.DataSource = DataTableHelper.InitPivotData();
                tabControl.Controls.Add(grid);
                tabControl.Dock = DockStyle.Fill;
                string tabName = string.Format("Result {0}", baseTabControl1.TabPages.Count + 1);
                TabPage tp = new TabPage() { Name = tabName, Text = tabName };
                tp.Controls.Add(tabControl);
                baseTabControl1.TabPages.Add(tp);
                baseTabControl1.SelectedIndex = baseTabControl1.TabPages.Count - 1;
            }
        }

        public enum SqlStatement
        {
            SELECT,
            UPDATE,
            DELETE,
            WHERE,
            ERROR
        }

        public int CheckSentences(string _tbQuery)
        {
            string originSentence = _tbQuery.ToUpper();
            string changeSentence = string.Empty;

            int result = -1;
            string firstLine = string.Empty;
            TextReader read = new StringReader(originSentence);
            string[] lines = Regex.Split(originSentence, "\r\n");
            for (int line = 0; line < lines.Length; line++)
            {
                string value = read.ReadLine();
                MatchCollection matchVal = Regex.Matches(value, @"^(\s+|\t|\r|\n)?(--)", RegexOptions.IgnoreCase);
                if (!string.IsNullOrWhiteSpace(value) && matchVal.Count == 0)
                {
                    firstLine = value;
                    break;
                }
            }
            MatchCollection matchSelect = Regex.Matches(firstLine, @"^(\s+|\t|\r|\n)?(SELECT|WITH)", RegexOptions.IgnoreCase);
            MatchCollection matchUpdate = Regex.Matches(firstLine, @"^(\s+|\t|\r|\n)?(UPDATE|MERGE)", RegexOptions.IgnoreCase);
            MatchCollection matchDelete = Regex.Matches(firstLine, @"^(\s+|\t|\r|\n)?(DELETE)", RegexOptions.IgnoreCase);

            read = new StringReader(originSentence);
            for (int line = 0; line < lines.Length; line++)
            {
                string value = read.ReadLine();
                MatchCollection matchVal = Regex.Matches(value, @"^(\s+|\t|\r|\n)?(--)", RegexOptions.IgnoreCase);
                if (!string.IsNullOrWhiteSpace(value))
                {
                    changeSentence = value;
                }
            }
            if (matchSelect.Count > 0)
            {
                result = (int)SqlStatement.SELECT;
            }
            else if (matchUpdate.Count > 0)
            {
                if (Regex.Matches(changeSentence, @"(WHERE)(\s+|\t|\r|\n)[a-zA-Z0-9](\s+)?=(\s+)?[a-zA-Z0-9]", RegexOptions.IgnoreCase).Count > 0)
                {
                    if (Regex.Matches(changeSentence, @"(WHERE)(\s+|\t|\r|\n)[a-zA-Z0-9](\s+)?=(\s+)?[a-zA-Z0-9](\s+)?(\s+|\t|\r|\n)(AND)", RegexOptions.IgnoreCase).Count > 0)
                    {
                        result = (int)SqlStatement.UPDATE;
                    }
                    else
                    {
                        result = (int)SqlStatement.WHERE;
                    }

                }
                else
                {
                    if (Regex.Matches(changeSentence, @"(WHERE)", RegexOptions.IgnoreCase).Count > 0)
                    {
                        result = (int)SqlStatement.UPDATE;
                    }
                    else
                    {
                        result = (int)SqlStatement.WHERE;
                    }
                }
            }
            else if (matchDelete.Count > 0)
            {
                if (Regex.Matches(changeSentence, @"(WHERE)(\s+|\t|\r|\n)[a-zA-Z0-9](\s+)?=(\s+)?[a-zA-Z0-9]", RegexOptions.IgnoreCase).Count > 0)
                {
                    if (Regex.Matches(changeSentence, @"(WHERE)(\s+|\t|\r|\n)[a-zA-Z0-9](\s+)?=(\s+)?[a-zA-Z0-9](\s+)?(\s+|\t|\r|\n)(AND)", RegexOptions.IgnoreCase).Count > 0)
                    {
                        result = (int)SqlStatement.DELETE;
                    }
                    else
                    {
                        result = (int)SqlStatement.WHERE;
                    }

                }
                else
                {
                    if (Regex.Matches(changeSentence, @"(WHERE)", RegexOptions.IgnoreCase).Count > 0)
                    {
                        result = (int)SqlStatement.DELETE;
                    }
                    else
                    {
                        result = (int)SqlStatement.WHERE;
                    }
                }
            }
            else
            {
                result = (int)SqlStatement.ERROR;
            }
            return result;
        }
    }
}
