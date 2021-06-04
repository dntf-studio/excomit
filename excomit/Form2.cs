using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace excomit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            load_json();
            add_components();
        }
        Form1 f1 = new Form1();

        List<Data> datas = new List<Data>();

        private void load_json()
        {
            var txt = File.ReadAllText(@".\data.json");
            var list = JsonConvert.DeserializeObject<List<Data>>(txt);
            datas = list;
        }

        private void add_components()
        {
            foreach(var i in datas)
            {
                comboBox1.Items.Add(i.school);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = null;
            comboBox2.Items.Clear();
            foreach(var i in datas)
            {
                if(comboBox1.SelectedItem.ToString() == i.school)
                {
                    comboBox2.Items.AddRange(i.names.ToArray());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                var i = comboBox1.SelectedItem.ToString();
                var j = comboBox2.SelectedItem.ToString();
                MessageBox.Show("登録されました\n高校:"+i+"\n氏名:"+j);
                comboBox2.Items.Remove(j);
                if(comboBox1.Items.Count <= 0)
                {
                    comboBox1.Items.Remove(i);
                }
                datas = RemoveData(i, j, datas);
                f1.write_csv(datas,"note.txt");
            }
            else
            {
                MessageBox.Show("学校または名前が選択されていません", "例外処理", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        public List<Data> RemoveData(string sch,string name,List<Data> list)
        {
            var data = new List<Data>();
            for(var i = 0; i < list.Count; i++)
            {
                if(list[i].school == sch)
                {
                    var b = list[i].names.Count <= 0;
                    if (!b)
                    {
                        Data d = new Data();
                        d.school = list[i].school;
                        var l = new List<string>();
                        foreach (var j in list[i].names)
                        {
                            if (j != name)
                            {
                                l.Add(j);
                            }
                        }
                        d.names = l;
                        data.Add(d);
                    }
                }
                else
                {
                    Data d = new Data();
                    d.school = list[i].school;
                    d.names = list[i].names;
                    data.Add(d);
                }
            }
            return data;
        }
    }
}
