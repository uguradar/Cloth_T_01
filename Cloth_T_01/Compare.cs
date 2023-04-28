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
    public partial class Compare : Form
    {
        public ScanData scanValues = new ScanData();
        public ScanData designerValues = new ScanData();
        public Jacket j1 = new Jacket();
        public Compare()
        {
            InitializeComponent();
        }

        private void Compare_Load(object sender, EventArgs e)
        {
            
            textBox2.Text = "BS_0010";
            textBox3.Text = "BS_8532";
            textBox4.Text = "BS_8531";
            textBox5.Text = "BS_0035";
            textBox6.Text = "BS_6510";
            textBox7.Text = "BS_0110";
            textBox8.Text = "BS_8030";
            textBox9.Text = "BS_4080";
            textBox10.Text = "BS_4081";
            textBox11.Text = "BS_8534";
            textBox12.Text = "BS_3031";
            textBox13.Text = "BS_3030";
            textBox14.Text = "BS_8040";
            textBox15.Text = "BS_8041";
            textBox16.Text = "BS_0190";
            textBox17.Text = "BS_8533";
            panel2.Enabled = false;
            j1.BodyHeight = 185.5;
            j1.HipCircumferences = 82.5;
            j1.BackWidth = 48.2;
            j1.ChestCircumferences = 163.5;
            j1.WaistGirth = 83.0;
            j1.BackHeight = 82.5;
            j1.SleeveLength = 62.5;
            j1.BustPointToNeckLeft = 27.4;
            j1.BustPointToNeckRight = 27.3;
            j1.ArmholeDiameter = 54.0;
            j1.ShoulderWidthRight = 15.0;
            j1.ShoulderWidthLeft = 14.4;
            j1.UpperArmLengthLeft = 35.0;
            j1.UpperArmLengthRight = 35.3;
            j1.NeckToWaistCenter = 47.4;
            j1.BustChestGirthHorizontal = 101.5;
            textBox33.Text = j1.BodyHeight.ToString();
            textBox32.Text = j1.HipCircumferences.ToString();
            textBox31.Text = j1.BackWidth.ToString();
            textBox30.Text = j1.ChestCircumferences.ToString();
            textBox29.Text = j1.WaistGirth.ToString();
            textBox28.Text = j1.BackHeight.ToString();
            textBox27.Text = j1.SleeveLength.ToString();
            textBox26.Text = j1.BustPointToNeckLeft.ToString();
            textBox25.Text = j1.BustPointToNeckRight.ToString();
            textBox24.Text = j1.ArmholeDiameter.ToString();
            textBox23.Text = j1.ShoulderWidthRight.ToString();
            textBox22.Text = j1.ShoulderWidthLeft.ToString();
            textBox21.Text = j1.UpperArmLengthLeft.ToString();
            textBox20.Text = j1.UpperArmLengthRight.ToString();
            textBox19.Text = j1.NeckToWaistCenter.ToString();
            textBox18.Text = j1.BustChestGirthHorizontal.ToString();



        }
        private double bosmu(TextBox textBox, double data)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                double t = Convert.ToDouble(textBox.Text);
                return t;
            }
            else return data;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaEkran a1 = new AnaEkran();
            a1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            j1.BodyHeight = bosmu(textBox49, j1.BodyHeight);
            j1.HipCircumferences = bosmu(textBox48, j1.HipCircumferences);
            j1.BackWidth= bosmu(textBox47, j1.BackWidth);
            j1.ChestCircumferences= bosmu(textBox46, j1.ChestCircumferences);
            j1.WaistGirth = bosmu(textBox45, j1.WaistGirth);
            j1.BackHeight= bosmu(textBox44, j1.BackHeight);
            j1.SleeveLength= bosmu(textBox43, j1.SleeveLength);
            j1.BustPointToNeckLeft= bosmu(textBox42, j1.BustPointToNeckLeft);
            j1.BustPointToNeckRight= bosmu(textBox41, j1.BustPointToNeckRight);
            j1.ArmholeDiameter= bosmu(textBox40, j1.ArmholeDiameter);
            j1.ShoulderWidthRight= bosmu(textBox39, j1.ShoulderWidthRight);
            j1.ShoulderWidthLeft= bosmu(textBox38, j1.ShoulderWidthLeft);
            j1.UpperArmLengthLeft = bosmu(textBox37, j1.UpperArmLengthLeft);
            j1.UpperArmLengthRight= bosmu(textBox36, j1.UpperArmLengthRight);
            j1.NeckToWaistCenter= bosmu(textBox35, j1.NeckToWaistCenter);
            j1.BustChestGirthHorizontal= bosmu(textBox34, j1.BustChestGirthHorizontal);
            MessageBox.Show("Datas Has Been Saved");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Results r = new Results();
            r.j1 = j1;
            r.s = scanValues;
            r.Show();
            this.Hide();
        }
    }
}
