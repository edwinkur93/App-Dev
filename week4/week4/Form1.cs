using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void check_qst1_4_CheckedChanged(object sender, EventArgs e)
        {
            if(check_qst1_4.Checked)
            {
                txt_qst1_4.Enabled = true;
                check_qst1_1.Enabled = false;
                check_qst1_2.Enabled = false;
                check_qst1_3.Enabled = false;
            } else
            {
                txt_qst1_4.Enabled = false;
                check_qst1_1.Enabled = true;
                check_qst1_2.Enabled = true;
                check_qst1_3.Enabled = true;
            }
        }

        private void check_agree_CheckedChanged(object sender, EventArgs e)
        {
            if (check_agree.Checked)
            {
                btn_submit_qst1.Enabled = true;
            } else
            {
                btn_submit_qst1.Enabled = false;
            }
}

        private void btn_submit_qst1_Click(object sender, EventArgs e)
        {
            string text = "Saya mengetahui UC dari ";
            if(check_qst1_1.Checked == false && check_qst1_2.Checked == false && check_qst1_3.Checked == false &&
                check_qst1_4.Checked == false)
            {
                MessageBox.Show("Checkbox harus diisi minimal satu", "Message 1", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            } else
            {
                if(check_qst1_1.Checked)
                {
                    text += check_qst1_1.Text + ", ";
                }
                if (check_qst1_2.Checked)
                {
                    text += "Social Media, ";
                }
                if (check_qst1_3.Checked)
                {
                    text += "Sekolah, ";
                }
                if(check_qst1_4.Checked)
                {
                    text += txt_qst1_4.Text;
                }
                MessageBox.Show(text, "Tau UC darimana?", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void check_qst2_1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_qst2_1.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
            Console.WriteLine(count);
        }

        private void check_qst2_1_CheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void radio_red_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_red.Checked)
            {
                panel_color.BackColor = Color.OrangeRed;
            }
        }

        private void radio_green_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_green.Checked)
            {
                panel_color.BackColor = Color.LightGreen;
            }
        }

        private void radio_blue_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_blue.Checked)
            {
                panel_color.BackColor = Color.Aquamarine;
                panel_color.ForeColor = Color.Black;
                
            }
        }

        //private void radio_txt_black_CheckedChanged(object sender, EventArgs e)
        //{
        //    if(radio_txt_black.Checked)
        //    {
        //        panel_color.ForeColor = Color.Black;
        //    }
        //}

        //private void radio_txt_white_CheckedChanged(object sender, EventArgs e)
        //{
        //    if(radio_txt_white.Checked) {
        //        panel_color.ForeColor = Color.White;
        //    }
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            if(radioButton1.Checked) {
                text = "benar";
            } else if(radioButton2.Checked)
            {
                text = "salah";
            }
            MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
