namespace PracticeApp
{
    public partial class Names : Form
    {
        public Names()
        {
            InitializeComponent();
        }

        private void EmployerButton_Click(object sender, EventArgs e)
        {
            FormEmployer employer = new FormEmployer();
            employer.Show();
            this.Hide();
        }
    }
}