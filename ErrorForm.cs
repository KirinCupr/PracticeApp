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
            const string Filename = "D:/Project_Billy/Dungeon.png";
            button1.Hide();
            button2.Hide();
            this.BackgroundImage = Image.FromFile(Filename);
            label1.Text = "Вы спускаетесь в тёмный dungeon и пытаетесь НАЩУПАТЬ leather glove.\nНО!!! Абсолютно случайно вы нащупываете кое-что другое. Твёрдое, длинное(но это кому как), склизкое!\nВы осознаёте, что всё это время вы могли включить свет, и включаете его.";
            Button cum = new Button();
            Controls.Add(cum);  
            cum.BackColor = Color.White;
            cum.Location = button1.Location;
            cum.Size = button1.Size;
            cum.Text = "Включить свет!";
            cum.Click += cum_Click; 
            cum.Show();

        }

        private void cum_Click(object sender, EventArgs e)
        {
            const string Filename = "D:/Project_Billy/u_342a64e0ec73cb128183c8d8e9a963c6_800.jpg";
            this.BackgroundImage = Image.FromFile(Filename);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = "Внезапно перед вашим лицом возникает некая чёрная фигура.\n'ТОЛЬКО НЕ ОН' - думаете Вы.\nЭто - ЧЁРНЫЙ ВЛАСТЕЛИН, самый страшный из Dungeon Master'ов!!!\nВаш пульс повывшается и в голове у Вас только одна мысль - бежать, и как можно быстрее!";
            
            Button cum2 = new Button();
            Controls.Add(cum2);
            cum2.DoubleClick += cum2_DoubleClick;
            cum2.Text = "Начать бежать!\n(В панике)";
            cum2.Location = new Point(20, 20);
            cum2.Size = new Size(30, 300);
            cum2.Show();

        }

        private void cum2_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
