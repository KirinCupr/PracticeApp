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

            this.listBox1.Items.AddRange(new object[] { "it1", "it2" });

            this.Controls.Add(listBox1);
            listBox1.Show();
        }

    }
}
