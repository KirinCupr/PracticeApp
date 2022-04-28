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
    public partial class ErrorForm : Form
    {
        private string smf;
        public ErrorForm(string textOfError)
        {
            smf = textOfError;
            InitializeComponent();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            label1.Text = smf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            label1.Text = "Вы спускаетесь в тёмный dungeon и пытаетесь НАЩУПАТЬ leather glove.\nНО!!! Абсолютно случайно вы нащупываете кое-что другое. Твёрдое, длинное(но это кому как), склизкое!\nВы осознаёте, что всё это время вы могли включить свет, и включаете его.";

        }
    }
}
