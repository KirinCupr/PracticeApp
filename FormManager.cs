using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        private void listBox1_Load(object sender, EventArgs e)
        {
            ListBox listBox1 = new ListBox();

            listBox1.Items.Add("Hello");
            listBox1.Items.Add("Hello");
            listBox1.Items.Add("Hello");

            this.Controls.Add(listBox1);
            listBox1.Show();
        }

    }
}
