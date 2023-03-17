using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace THA_W3_JESSICA_TH
{
    public partial class MainForm : Form
    {
        public static MainForm formInstance;
        public TextBox tbx;

        SecondForm f2 = new SecondForm();
        int cekk = 0;

        public MainForm()
        {
            InitializeComponent();
            formInstance = this;
            tbx = TB_Name;
        }

        private void Btn_NextForm_Click(object sender, EventArgs e)
        {
            f2.Show();
            cekk = 1;
            if (CB_True1.Checked && cekk > 0)
            {
                Btn_Submit1.Enabled = true;
            }
            else
            {
                Btn_Submit1.Enabled = false;
            }
        }

        private void Btn_Submit1_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(TB_Name.Text) || string.IsNullOrEmpty(TB_FavArtist.Text))
                {
                    MessageBox.Show("Please don't leave the textbox empty!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    f2.LabelHi = "Hi my name is " + TB_Name.Text + ", and my favorite artist is " + TB_FavArtist.Text + ".";
                }
            
            
        }
            

        private void TB_FavArtist_TextChanged(object sender, EventArgs e)
        {

        }

        private void CB_True1_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_True1.Checked && cekk > 0)
            {
                Btn_Submit1.Enabled = true;
            }
            else
            {
                Btn_Submit1.Enabled = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
