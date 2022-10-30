namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.ForeColor = Color.Blue;
        }

        private void redToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TextBox.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox.BackColor = Color.Blue;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Font = new Font ("",5);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Font = new Font("", 9);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Font = new Font("", 20);
        }

        private void redToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TextBox.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TextBox.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TextBox.ForeColor = Color.Blue;
        }

        private void redToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TextBox.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TextBox.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TextBox.BackColor = Color.Blue;
        }

        private void smallToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox.Font = new Font("", 5);
        }

        private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox.Font = new Font("", 9);
        }

        private void largeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextBox.Font = new Font("", 20);
        }

        private void menuStrip1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)

        {
            KeyEventArgs e = new KeyEventArgs(keyData);

            if (e.Control && e.KeyCode == Keys.R)

            {

                TextBox.ForeColor = Color.Red;
                return true;

            }

            if (e.Control && e.KeyCode == Keys.G)

            {

                TextBox.ForeColor = Color.Green;
                return true;

            }

            if (e.Control && e.KeyCode == Keys.B)

            {

                TextBox.ForeColor = Color.Blue;
                return true;

            }

            if (e.Control && e.KeyCode == Keys.S)

            {

                TextBox.Font = new Font("", 5);
                return true;

            }

            if (e.Control && e.KeyCode == Keys.N)

            {

                TextBox.Font = new Font("", 9);
                return true;

            }

            if (e.Control && e.KeyCode == Keys.L)

            {

                TextBox.Font = new Font("", 20);
                return true;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        }
}