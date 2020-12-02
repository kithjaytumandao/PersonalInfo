using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfo
{
    public partial class Personal_Information : Form
    {
        public Personal_Information()
        {
            InitializeComponent();
        }
       
       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {}

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
            if (txtDisplay.Text == "")
            {
                Image image = (Image)picboxImage.Image;
                Image image2 = pbDisplay.Image;
                pbDisplay.Image = image;
                String firstname = txtFname.Text;
                String lastname = txtLname.Text;
                String address = txtAddress.Text;
                String bday = dtpBday.Value.Date.ToString();
                String marital;
                marital = cbMarital.Text;
                String hobby = "\t";
                String gender = "";


                if (chkbHobby1.Checked)
                {
                    hobby += "Basketball\t";
                }
                if (chkbHobby2.Checked)
                {
                    hobby += "Swimming\t";
                }
                if (chkbHobby3.Checked)
                {
                    hobby += "\t\t\tHiking";
                }
                if (chkbHobby4.Checked)
                {
                    hobby += "\t\tRunning\t";
                }
                if (chkbHobby5.Checked)
                {
                    hobby += "\r\n\t\tReading\t";
                }
                if (chkbHobby6.Checked)
                {
                    hobby += "\tGaming\t";
                }


                if (rbtnMale.Checked == true)
                {
                    gender += "Male";
                }
                if (rbtnFemale.Checked == true)
                {
                    gender += "Female";
                }

                
                txtDisplay.AppendText("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" + lblFname.Text + ":\t" + firstname + "\r\n");
                txtDisplay.AppendText("" + lblLname.Text + ":\t" + lastname + "\r\n");
                txtDisplay.AppendText("" + lblAddress.Text + ":\t" + address + "\r\n");
                txtDisplay.AppendText("" + lblBday.Text + ":\t" + bday + "\r\n");
                txtDisplay.AppendText("" + lblMaritalStat.Text + ":\t" + marital + "\r\n");
                txtDisplay.AppendText("" + lblHobby.Text + ":\t" + hobby + "\r\n");
                txtDisplay.AppendText("" + lblGender.Text + ":\t" + gender);
            }
            else
            {
             txtDisplay.Clear();
            }
        }
        



        private void chkbHobby1_CheckedChanged(object sender, EventArgs e)
        {}

        private void chkbHobby2_CheckedChanged(object sender, EventArgs e)
        {}

        private void chkbHobby3_CheckedChanged(object sender, EventArgs e)
        {}

        private void chkbHobby6_CheckedChanged(object sender, EventArgs e)
        {}

        private void chkbHobby5_CheckedChanged(object sender, EventArgs e)
        {}

        private void gbGender_Enter(object sender, EventArgs e)
        {}

        private void btneventBrowser(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK) 
                {
                Bitmap bit = new Bitmap(ofd.FileName);
                picboxImage.Image = bit;
                }

        }

        private void pbImage(object sender, EventArgs e)
        {}

        private void btneventSubmit(object sender, EventArgs e)
        {
            Image image = (Image)picboxImage.Image;
            Image image2 = pbDisplay.Image;
            pbDisplay.Image = image;

            String firstname = txtFname.Text;
            String lastname = txtLname.Text;
            String address = txtAddress.Text;
            String marital;
            marital = cbMarital.Text;

            String hobby = "";
            String gender = "";
            

            if (chkbHobby1.Checked) 
            {
                hobby +="Basketball";
            }
            if (chkbHobby2.Checked)
            {
                hobby += "Swimming";
            }
            if (chkbHobby3.Checked)
            {
                hobby += "Hiking";
            }
            if (chkbHobby4.Checked)
            {
                hobby += "Running";
            }
            if (chkbHobby5.Checked)
            {
                hobby += "Reading";
            }
            if (chkbHobby6.Checked)
            {
                hobby += "Gaming";
            }

            if (rbtnMale.Checked==true)
            {
                gender += "Male";
            }
            if (rbtnFemale.Checked==true)
            {
                gender += "Female";
            }
            
           
           DialogResult dialog =MessageBox.Show("Do you Want to Save the Image first?\r\n\r\n\r\nPressing Yes will save the Image only\r\n\r\n\r\nPressing No will save the Text only\r\n\r\n\r\nYou must click the submit button again to save Image or Text", "Image", MessageBoxButtons.YesNo);
            
            if (dialog == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog2 = new SaveFileDialog();
                //saveFileDialog2.Title = "Submit";
                //saveFileDialog1.Filter = "Image|*.jpg";
                //saveFileDialog1.FileName = ".jpeg";
                //String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //pbDisplay.Image.Save(path+"\\"+DateTime.Now.Millisecond.ToString()+".jpg",);
                saveFileDialog2.Filter = "JPG(*.JPG|*jpg)";
                if(saveFileDialog2.ShowDialog()==DialogResult.OK)
                {
                    image2.Save(saveFileDialog2.FileName);

                }
            }

            if(dialog==DialogResult.No)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Submit";
                saveFileDialog1.Filter = "Text|*.txt";
                saveFileDialog1.FileName = ".txt";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, txtDisplay.Text.ToString());
                }
            
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {}

        private void txtFname_Textchange(object sender, EventArgs e)
        {}

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {}

        private void cbMarital_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbMarital.Items.Add("Single");
            cbMarital.Items.Add("Married");
            cbMarital.Items.Add("Widow");
        }

        private void pbDisplay_Click(object sender, EventArgs e)
        {}

        private void Personal_Information_Load(object sender, EventArgs e)
        {}
    }
}
