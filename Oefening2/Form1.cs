namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 GemiddeldeMDI = new Form2();
            GemiddeldeMDI.MdiParent = this;
            GemiddeldeMDI.Show();
            GemiddeldeMDI.Location = new Point(100, 100);
        }
    }
}