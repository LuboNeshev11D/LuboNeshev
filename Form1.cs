using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinLubo
{
    public partial class frmKnijarnica : Form
    {
        List<Book> books = new List<Book>();
        public frmKnijarnica()
        {
            InitializeComponent();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grbJanr_Enter(object sender, EventArgs e)
        {

        }

        private void lblavtor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Popalnete informaciqta");
        }

        private void frmKnijarnica_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zaglavie = "";
            string avtor = "";
            string janar = "";
            string korica = "";
            string izdatelstvo = "";
            if (string.IsNullOrEmpty(cmbIzdatelstva.Text))
            {
                MessageBox.Show("Ne si izbral izdatel");
                cmbIzdatelstva.Focus();
                return;
                izdatelstvo = cmbIzdatelstva.Text;

            }
            else
            {
                izdatelstvo = cmbIzdatelstva.Text;
            }
            if (rbhud.Checked) janar = rbhud.Text;
            if (rbNauchno.Checked) janar = rbNauchno.Text;
            if (rbSpravochna.Checked) janar = rbSpravochna.Text;

            if (chbTvarda.Checked)
            {
                korica=chbTvarda.Text;
            }
            if (string.IsNullOrEmpty(avtor))
            {
                avtor = textBoxAvtor.Text;
                
            }
            else
            {
                MessageBox.Show("Ne si napisal avtor");
                avtor =textBoxAvtor.Text;    
            }
            if (string.IsNullOrEmpty(zaglavie))
            {
                zaglavie = TextBoxZaglavie.Text;
               
            }
            else
            {
                MessageBox.Show("Ne si vavel zaglavie");
                zaglavie =TextBoxZaglavie.Text; 
            }
            MessageBox.Show($"Vie vavedohte  {zaglavie} s avtor{avtor},{janar}," +
                $"literatura s{korica},korica ot izdatelstvo{izdatelstvo}.Potvarjdavate li!?");



          
        }
    }

    internal class Book
    {
       
    }
}
