using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Diagnostics;

namespace excomit
{
    /// <summary>
    /// Made by dntf-studio @2021
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new System.Drawing.Icon(@".\images\icon.ico");
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
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "学校名";
            dataGridView1.Columns[1].HeaderText = "生徒名";
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
                        for(var i = 0; i < student.Count; i++)
                        {
                            note_json(school[i],student[i]);
                        }
                        write_json();
                        checkout_form();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "例外処理", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        List<Data> datas = new List<Data>();
        private void note_json(string str,List<string> list)
        {
            var data = new Data();
            data.school = str;
            data.names = list;
            datas.Add(data); 
        }

        private void write_json()
        {
            string output = JsonConvert.SerializeObject(datas);
            var path = @".\data.json";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(output);
            }
        }

        private void ファイルToolStripMenuItem_Click(object sender, EventArgs e){}

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
        }

        private void プレビューToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("生徒のデータまたは学校のデータが欠如しています。","例外処理", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.FileName = "新しいデータ.json";
            sv.InitialDirectory = @"C:\";
            sv.Filter = "JSONファイル(*.json)|*.json";
            sv.Title = "名前を付けて保存する";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                string output = JsonConvert.SerializeObject(datas,Formatting.Indented);
                using (StreamWriter sw = new StreamWriter(sv.FileName))
                {
                    if(output != "[]")
                    {
                        sw.Write(output);
                    }
                    else
                    {
                        MessageBox.Show("データが内部に存在しません。", "保存できませんでした", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void csv表形式で保存するToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog_write_csv();
        }

        private void dialog_write_csv()
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.FileName = "新しいデータ.csv";
            sv.InitialDirectory = @"C:\";
            sv.Filter = "CSVファイル(*.csv)|*.csv";
            sv.Title = "名前を付けて保存する";

            if (sv.ShowDialog() == DialogResult.OK)
            {
                var st = string.Empty;
                using (StreamWriter sw = new StreamWriter(sv.FileName))
                {
                    if (datas != null)
                    {
                        foreach (var i in datas)
                        {
                            foreach (var j in i.names)
                            {
                                sw.WriteLine(i.school + "," + j);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("データが内部に存在しません。", "保存できませんでした", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void write_csv(List<Data> d,string name)
        {
            var ps = @".\"+name;
            using (StreamWriter sw = new StreamWriter(ps))
            {
                if (d != null)
                {
                    foreach (var i in d)
                    {
                        foreach (var j in i.names)
                        {
                            sw.WriteLine(i.school + "," + j);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("データが内部に存在しません。", "保存できませんでした", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void リサルトログToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if(datas != null)
                {
                    write_csv(datas,".txt");
                    var p = new Process();
                    p.StartInfo.FileName = "gophine.exe";
                    p.Start();

                }
                else { MessageBox.Show("生徒のデータまたは学校のデータが欠如しています。", "例外処理", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("生徒のデータまたは学校のデータが欠如しています。", "例外処理", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void databasepyをコンパイルするToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pyinstaller --onefile -w database.py
            var p = new Process();
            p.StartInfo.FileName = "setgo.bat";
            p.StartInfo.Arguments = "-d";
            p.Start();
;        }

        private void バージョンToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("v.0.9.1.a\nGit: https://github.com/dntf-studio/excomit", "バージョン情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class Data
    {
        public string school { get; set; }
        public List<string> names { get; set; }
    }
}
