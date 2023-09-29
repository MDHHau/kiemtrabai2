using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiemtrabai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        


        private void btOK_Click(object sender, EventArgs e)
        {
            double giamgia =0, tong=0 ,mic=0, tienphi;
            tienphi = 500 * double.Parse(txtUni.Text);
           

            if (txt10.Checked == true)
            {
                giamgia = tienphi * 0.1;
            }
            else
            {
                if (txt50.Checked == true)
                {
                    giamgia = tienphi * 0.5;
                }
                else
                {
                    if (txt100.Checked == true)
                    {
                        giamgia = tienphi * 1;
                    }
                }
            }
            if(txtyear.Text == "2000")
            {
                mic = 2000;
            }else if(txtyear.Text == "2001")
            {
                mic = 2500;
            }
            else if (txtyear.Text == "2002")
            {
                mic = 3000;
            }
            else if (txtyear.Text == "2003" && txtyear.Text == "2004")
            {
                mic = 3500;
            }
            tong = tienphi + mic - giamgia;



            MessageBox.Show("Student :"+ txtID.Text +" ;name "+ txtName.Text +"\nkhoa hoc: " +txtCou.Text 
            +"\ntong mon:" + txtUni.Text 
            +"\n hoc phi: " + tienphi
            +"\ngiam gia"  + giamgia
            +"\ntong cong" + tong);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtyear.Items.Add("2000");
            txtyear.Items.Add("2001");
            txtyear.Items.Add("2002");
            txtyear.Items.Add("2003");
            txtyear.Items.Add("2004");

        }
    }
}
