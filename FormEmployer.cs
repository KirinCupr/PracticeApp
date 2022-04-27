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
    public partial class FormEmployer : Form
    {
        public FormEmployer()
        {
            InitializeComponent();
        }

        private void FormEmployer_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Names names = new Names();
            names.Show();
        }
    }
}
