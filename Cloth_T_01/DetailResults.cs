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
    public partial class DetailResults : Form
    {
        public Jacket j1 = new Jacket();
        public ScanData s = new ScanData();
        public DetailResults()
        {
            InitializeComponent();
        }

        public void goster(double a, double b,Label l1,Label l2, Label l3, Label l4, Label l5, PictureBox p1,ImageList i, int r0,int r1, int r2)
        {
            double hesap = Math.Abs(a-b);
            if (hesap == 0)
            {
                l1.Text = "m";
                l2.Text = "m";
                l3.Text = "m";
                l4.Text = "m";
                l5.Text = "m";
                p1.Image = i.Images[r0];
            }
            else if(a>b)
            {//short
                l1.Text = (a - hesap).ToString();
                l2.Text = a.ToString();
                l2.BackColor = Color.LightBlue;
                l3.Text = (a + hesap).ToString();
                l4.Text = (b).ToString();
                l4.BackColor = Color.LightGreen;
                l5.Text = (b + hesap).ToString();
                p1.Image = i.Images[r1];
            }
            else
            {
                //long
                l1.Text = (a - hesap).ToString();
                l2.Text = a.ToString();
                l2.BackColor = Color.LightBlue;
                l3.Text = (a + hesap).ToString();
                l4.Text = (b).ToString();
                l4.BackColor = Color.LightGreen;
                l5.Text = (b + hesap).ToString();
                p1.Image = i.Images[r2];
            }
        }
        public void hesapla()
        {
            goster(s.HipCircumference,j1.HipCircumferences, label2, label3, label4, label5, label6,pictureBox2,ımageList1,0,1,2);
            goster( s.BackWith, j1.BackWidth, label10, label12, label11, label9, label8, pictureBox3,ımageList1,3,4,5);
            goster(s.ChestCircumferences, j1.ChestCircumferences, label17, label19, label18, label16, label15, pictureBox5,ımageList1,6,7,8);
            goster(s.WaistGirth, j1.WaistGirth, label23, label41, label40, label22, label21, pictureBox7,ımageList1,9,10,11);
            goster(s.BackHeight, j1.BackHeight, label45, label47, label46, label44, label43, pictureBox9,ımageList1,12,13,14);

            goster(s.ArmLengthLeft, j1.SleeveLength, label51, label53, label52, label50, label49, pictureBox11,ımageList1,15,16,17);

            goster(s.BustPointAbuseNeckLeft, j1.BustPointToNeckLeft, label57, label59, label58, label56, label55, pictureBox13,ımageList1,18,19,20);

            goster(s.AbusePointsToNeckRight, j1.BustPointToNeckRight, label63, label65, label64, label62, label61, pictureBox15,ımageList1,21,22,22);

            goster(s.ArmpitCircumference, j1.ArmholeDiameter, label69, label71, label70, label68, label67, pictureBox17,ımageList1,23,24,25);

            goster(s.ShoulderWidthRight, j1.ShoulderWidthRight, label32, label34, label33, label31, label30, pictureBox19,ımageList1,26,27,27);

            goster(s.ShoulderWidthLeft, j1.ShoulderWidthLeft, label39, label73, label72, label37, label36, pictureBox21,ımageList1,28,29,30);

            goster(s.UpperArmLengthLeft, j1.UpperArmLengthLeft, label77, label79, label78, label76, label75, pictureBox23,ımageList1,28,29,30);

            goster(s.UpperArmLengthRight, j1.UpperArmLengthRight, label83, label85, label84, label82, label81, pictureBox25,ımageList1,28,29,30);

            goster(s.NeckToWaistCenter, j1.NeckToWaistCenter, label89, label91, label90, label88, label87, pictureBox27, ımageList1,28,29,30);

            goster(s.BustChestGirthHorizontal, j1.BustChestGirthHorizontal, label29, label93, label92, label28, label27, pictureBox29,ımageList1,31,32,33);
        }
        private void DetailResults_Load(object sender, EventArgs e)
        {
            hesapla();
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }
    }
}
