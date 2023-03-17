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
    public partial class SecondForm : Form
    {
        public MainForm form1;
        public string LabelHi
        {
            get
            {
                return this.label_Hi.Text;
            }
            set
            {
                this.label_Hi.Text = value;
            }
        }
        public SecondForm()
        {
            InitializeComponent();
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {

        }

        private void CB_ToA_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_ToA.Checked && CB_True2.Checked)
            {
                Btn_Magic.Enabled = true;
            }
            else
            {
                Btn_Magic.Enabled = false;

            }
        }

        private void Btn_Magic_Click(object sender, EventArgs e)
        {

            if (RB_BlackBG.Checked || RB_BlueBG.Checked ||
                RB_PinkBG.Checked || RB_RedBG.Checked || RB_YellowBG.Checked)
            { 
                if (RB_AquaText.Checked || RB_GreenText.Checked || RB_OrangeText.Checked)
                {
                    if (RB_BlackBG.Checked)
                    {
                        MainForm.formInstance.BackColor = Color.Black;
                    }
                    else if (RB_BlueBG.Checked)
                    {
                        MainForm.formInstance.BackColor = Color.DarkBlue;
                    }
                    else if (RB_PinkBG.Checked)
                    {
                        MainForm.formInstance.BackColor = Color.DeepPink;
                    }
                    else if (RB_YellowBG.Checked)
                    {
                        MainForm.formInstance.BackColor = Color.DarkKhaki;
                    }
                    else if (RB_RedBG.Checked)
                    {
                        MainForm.formInstance.BackColor = Color.DarkRed;
                    }
                    if (RB_GreenText.Checked)
                    {
                        MainForm.formInstance.ForeColor = Color.LightGreen;
                    }
                    else if (RB_OrangeText.Checked)
                    {
                        MainForm.formInstance.ForeColor = Color.LightSalmon;
                    }
                    else if (RB_AquaText.Checked)
                    {
                        MainForm.formInstance.ForeColor = Color.Aqua;
                    }
                }
                else
                {
                    MessageBox.Show("Please select color correctly!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please select color correctly!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void label_Hi_Click(object sender, EventArgs e)
        {

        }

        private void CB_True2_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_ToA.Checked && CB_True2.Checked)
            {
                Btn_Magic.Enabled = true;
            }
            else
            {
                Btn_Magic.Enabled = false;
                
            }
        }
    }
}
