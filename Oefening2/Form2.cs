using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void VoegToe(double cijfer)
        {
            listBoxWaardes.Items.Add(cijfer);
        }

        private void CalcGemiddelde()
        {
            double tot_gem = 0;

            foreach (double el in listBoxWaardes.Items)
            {
                tot_gem += el;
            }

            gem_textBox.Text = (tot_gem / listBoxWaardes.Items.Count).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 dialogBX = new Form3();
            dialogBX.ShowDialog();
            
            if(dialogBX.DialogResult == DialogResult.OK)
            {
                VoegToe(double.Parse(dialogBX.waarde));
                CalcGemiddelde();
                
            }   

        }

        
private void gem_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
