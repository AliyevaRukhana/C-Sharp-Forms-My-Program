namespace MinunOhjelmani
{
    public partial class MinunOhjelmaForm : Form
    {
        public MinunOhjelmaForm()
        {
            InitializeComponent();
        }

        private void AloitaBT_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(); // Luodaan MainForm-olio
            mainForm.Show(); // Näytetään MainForm
            this.Hide(); // Piilotetaan nykyinen tervetuloa-lomake
        }
    }
}
