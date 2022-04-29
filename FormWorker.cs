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
    public partial class FormWorker : Form
    {
        public FormWorker()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonEnter_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("test.TXT", true))
            {
                if (textLastname.Text != "" || textName.Text != "" || textPatronymic.Text != ""
                     || textProfession.Text != "" || textQualification.Text != "")
                {
                    MessageBox.Show("Подтвердить корректность данных?");
                    await writer.WriteLineAsync(textLastname.Text);
                    await writer.WriteLineAsync(textName.Text);
                    await writer.WriteLineAsync(textPatronymic.Text);
                    await writer.WriteLineAsync(textProfession.Text);
                    await writer.WriteLineAsync(textQualification.Text);
                    Close();
                }

                else
                {
                    MessageBox.Show("ТЫ что, кретин?!??!?!\nCnh, бля, строки надо заполнять!!!!! ъуъ", "Error :)");
                    ErrorForm gay = new ErrorForm("Ты ведь понимаешь, что в строки, которые, ОЧЕВИДНО, предназначены для ввода информации надо что-то ввести?!\nИ ты, fucking slave, решил пренебречь этим правилом!!!!!!!\nТЫ ВООБЩЕ В СВОЁМ CUM КУПАЕШЬСЯ ИЛИ ПРОСТО РЕШИЛ СОВОКУПИТЬСЯ СО МНОЙ!!!!\nУ тебя два варианта: надеть leather glove и сделать фистинг, или перестать быть геем!!!");
                    gay.Show();
                }

            }
        }
    }
}
