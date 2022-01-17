using Parser.Core;
using Perser.Core.Habra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perser
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;
        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(new Habraparser());
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;

        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All Works Done");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            parser.ParserSettings = new HabraSettings((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            parser.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
