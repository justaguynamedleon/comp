using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dict = new Dictionary<string, string[]>()
            {
                { "S", new string[]{ "abcEd", "abcd" },
                { "E", new string[]{ "x" } }
            };
            Compiler c = new Compiler(dict);
            var input = "ab";
            MessageBox.Show(c.f("S", input) == "" ? "YEAH" : "NO");
            richTextBox1.Text = c.Print() + new string('-', 20) + "\nInput: " + input;
        }
    }
}
