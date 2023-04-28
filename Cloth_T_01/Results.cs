using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloth_T_01
{
    public partial class Results : Form
    {
        public Jacket j1 = new Jacket();
        public ScanData s = new ScanData();
        DetailResults d1 = new DetailResults();
        public Results()
        {
            InitializeComponent();
        }
        private void arkaPlan(TextBox textBox,double valueC, PictureBox pictureBox, Label label)
        {
           
            if (double.TryParse(textBox.Text, out double value))
            {
                //Console.WriteLine("tex:" + value + " değer: " + valueC);
                if (value == valueC)
                {
                    textBox.BackColor = Color.Green;
                    pictureBox.Image = ımageList1.Images[0];
                    label.Text = "";
                }
                else if(value>valueC)
                {
                    textBox.BackColor = Color.Orange;
                    pictureBox.Image = ımageList1.Images[1];
                    label.Text = "Too Large";
                }
                else
                {
                    textBox.BackColor = Color.Orange;
                    pictureBox.Image = ımageList1.Images[1];
                    label.Text = "Too Short";
                }
            }
            else
            {
                textBox.BackColor = SystemColors.Window;
                pictureBox.Image = null;
                label.Text = "";
            }
        }

        private void Results_Load(object sender, EventArgs e)
        {
           
            textBox33.Text = j1.BodyHeight.ToString();

            textBox32.Text = j1.HipCircumferences.ToString();
            arkaPlan(textBox32, s.HipCircumference, pictureBox2, label55);
            textBox31.Text = j1.BackWidth.ToString();
            arkaPlan(textBox31, s.BackWith, pictureBox3, label54);
            textBox30.Text = j1.ChestCircumferences.ToString();
            arkaPlan(textBox30, s.ChestCircumferences, pictureBox4, label53);
            textBox29.Text = j1.WaistGirth.ToString();
            arkaPlan(textBox29, s.WaistGirth, pictureBox6, label52);
            textBox28.Text = j1.BackHeight.ToString();
            arkaPlan(textBox28, s.BackHeight, pictureBox7, label51);
            textBox27.Text = j1.SleeveLength.ToString();
            arkaPlan(textBox27, s.ArmLengthLeft, pictureBox8, label50);

            textBox26.Text = j1.BustPointToNeckLeft.ToString();
            arkaPlan(textBox26, s.BustPointAbuseNeckLeft, pictureBox9, label49);

            textBox25.Text = j1.BustPointToNeckRight.ToString();
            arkaPlan(textBox25, s.AbusePointsToNeckRight, pictureBox10, label48);

            textBox24.Text = j1.ArmholeDiameter.ToString();
            arkaPlan(textBox24, s.ArmpitCircumference, pictureBox1, label47);

            textBox23.Text = j1.ShoulderWidthRight.ToString();
            arkaPlan(textBox23, s.ShoulderWidthRight, pictureBox11, label46);

            textBox22.Text = j1.ShoulderWidthLeft.ToString();
            arkaPlan(textBox22, s.ShoulderWidthLeft, pictureBox12, label45);

            textBox21.Text = j1.UpperArmLengthLeft.ToString();
            arkaPlan(textBox21, s.UpperArmLengthLeft, pictureBox13, label44);

            textBox20.Text = j1.UpperArmLengthRight.ToString();
            arkaPlan(textBox20, s.UpperArmLengthRight, pictureBox15, label43);

            textBox19.Text = j1.NeckToWaistCenter.ToString();
            arkaPlan(textBox19, s.NeckToWaistCenter, pictureBox16, label42);

            textBox18.Text = j1.BustChestGirthHorizontal.ToString();
            arkaPlan(textBox18, s.BustChestGirthHorizontal, pictureBox17, label41);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DetailResults d1 = new DetailResults();
            d1.j1 = j1;
            d1.s = s;
            d1.Show();
            
        }
    }
}
