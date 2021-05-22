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
    }
}
