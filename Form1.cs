namespace LibraryTrainingApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbGameSelect.SelectedIndex == 0)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else if (cmbGameSelect.SelectedIndex == 1)
            {
                this.Hide();
                Form3 f3= new Form3();
                f3.ShowDialog();
            }
            else if (cmbGameSelect.SelectedIndex == 2)
            {
                this.Hide();
                Form4 f4 = new Form4();
                f4.ShowDialog(); ;
            }
            else
            {
                MessageBox.Show("Please Select a Game to Play");
            }
        }
    }
}