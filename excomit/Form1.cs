using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace excomit
{
    public partial class Form1 : Form
    {
        [DllImport("lib.dll",CallingConvention = CallingConvention.Cdecl,CharSet = CharSet.Unicode)]
        static extern int write(string str);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "学校名";
            dataGridView1.Columns[1].HeaderText = "生徒名";
            btn2.Enabled = false;
            checkBox1.Checked = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){    }

        string st_data;
        string sh_data;

        string[] school;
        List<List<string>> student;
        private void btn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fb = new OpenFileDialog();
            fb.InitialDirectory = @"C:\";
            fb.Filter = "csvファイル(*.csv)|*.csv|txtファイル(*.txt)|*.txt";
            fb.Title = "データとなるファイル(.txtまたは.csvを選択してください)";

            if (fb.ShowDialog() == DialogResult.OK)
            {
                var a = fb.OpenFile();
                st_data = string.Empty;
                using (StreamReader sr = new StreamReader(a)) { st_data = sr.ReadToEnd(); }
                var s = fb.FileNames[0];
                textBox1.Text = s;
                var str = SplitString(st_data);
                school = str;
                btn2.Enabled = true;
            }
            else
            {
                MessageBox.Show("ファイルが選択されませんでした。", "例外処理", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fb.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private string[] SplitString(string str)
        {
            var sp = str.Split('\n');
            var list = new List<string>();
            foreach (var i in sp)
            {
                if (i.Contains(','))
                {
                    var j = i.Split(',');
                    list.AddRange(j);
                    continue;
                }
                list.Add(i);
            }
            return list.ToArray();
        }

        private List<List<string>> SplitString2(string str)
        {
            var sp = str.Split('*');
            var list = new List<List<string>>();
            foreach (var i in sp)
            {
                var small = new List<string>();
                var j = i.Split('\n');
                foreach (var k in j)
                {
                    if (k.Contains(','))
                    {
                        var l = k.Split(',');
                        small.AddRange(l);
                        continue;
                    }
                    small.Add(k);
                }
                list.Add(small);
            }
            return list;
        }

        private void init_grid(string[] str, List<List<string>> list)
        {
            var index_a = 0;
            foreach (var i in list)
            {
                var index_b = 0;
                foreach (var j in i)
                {
                    dataGridView1.Rows.Add(str[index_a], j);
                    index_b++;
                }
                index_b = 0;
                index_a++;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fb = new OpenFileDialog();
            fb.InitialDirectory = @"C:\";
            fb.Filter = "csvファイル(*.csv)|*.csv|txtファイル(*.txt)|*.txt";
            fb.Title = "データとなるファイル(.txtまたは.csvを選択してください)";

            if (fb.ShowDialog() == DialogResult.OK)
            {
                var a = fb.OpenFile();
                sh_data = string.Empty;
                using (StreamReader sr = new StreamReader(a)) { sh_data = sr.ReadToEnd(); }
                var s = fb.FileNames[0];
                textBox2.Text = s;
                var str = SplitString2(sh_data);
                student = str;
                if (textBox1.Text != "" || textBox1.Text != null)
                {
                    try
                    {
                        init_grid(school, student);
                        int gg = write(s.ToString());
                        MessageBox.Show(gg.ToString());
                        checkout_form();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "例外処理", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("生徒のデータが選択されていません。", "例外処理", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("ファイルが選択されませんでした。", "例外処理", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fb.Dispose();
        }

        private void checkout_form()
        {
            if (checkBox1.Checked)
            {
                try
                {
                    Form2 frm2 = new Form2();
                    frm2.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "例外処理",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

    }
}
