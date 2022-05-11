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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emploeeButton_Click(object sender, EventArgs e)
        {
            FormWorker worker = new FormWorker();
            worker.Show();
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            FormManager manager = new FormManager();
            manager.Show();
        }
    }
}