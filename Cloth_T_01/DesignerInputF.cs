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
    public partial class DesignerInputF : Form
    {
        public ScanData scanId1 { get; set; }
        public ScanData dAdjust = new ScanData();
        public DesignerInputF()
        {
            InitializeComponent();
            this.scanId1 = scanId1;
        }

        private void DesignerInputF_Load(object sender, EventArgs e)
        {
            textBox75.Text = scanId1.BodyHeight.ToString();
            textBox74.Text = scanId1.ChestCircumferences.ToString();
            textBox73.Text = scanId1.WaistHeight.ToString();
            textBox72.Text = scanId1.CrotchHeight.ToString();
            textBox71.Text = scanId1.BackHeight.ToString();
            textBox70.Text = scanId1.BreastHeight.ToString();
            textBox69.Text = scanId1.NeckToWaistCenter.ToString();
            textBox68.Text = scanId1.MidNeckGirth.ToString();
            textBox67.Text = scanId1.ShoulderWidthLeft.ToString();
            textBox66.Text = scanId1.ShoulderWidthRight.ToString();
            textBox65.Text = scanId1.ShoulderAngelLeft.ToString();
            textBox64.Text = scanId1.ShoulderAngelRight.ToString();
            textBox63.Text = scanId1.BustPointsWidth.ToString();
            textBox62.Text = scanId1.NeckRightToWaistOverBust.ToString();
            textBox61.Text = scanId1.BustPointAbuseNeckLeft.ToString();
            textBox60.Text = scanId1.AbusePointsToNeckRight.ToString();
            textBox59.Text = scanId1.BustChestGirthHorizontal.ToString();
            textBox58.Text = scanId1.AcrossBackWith.ToString();
            textBox57.Text = scanId1.NeckToWaistCenterBack.ToString();
            textBox56.Text = scanId1.CrotchLength.ToString();
            textBox55.Text = scanId1.WaistGirth.ToString();
            textBox54.Text = scanId1.WaistToButtockHeightRight.ToString();
            textBox53.Text = scanId1.HighHipGirth.ToString();
            textBox52.Text = scanId1.ButtockGirth.ToString();
            textBox51.Text = scanId1.ArmLengthToNeckBackLeft.ToString();
            textBox50.Text = scanId1.ArmLengthToNeckBackRight.ToString();
            textBox49.Text = scanId1.ArmLengthLeft.ToString();
            textBox48.Text = scanId1.ArmLengthRight.ToString();
            textBox47.Text = scanId1.UpperArmLengthLeft.ToString();
            textBox46.Text = scanId1.UpperArmLengthRight.ToString();
            textBox45.Text = scanId1.UpperArmGirthLeft.ToString();
            textBox44.Text = scanId1.UpperArmGirthRight.ToString();
            textBox43.Text = scanId1.ElbowGirthLeft.ToString();
            textBox42.Text = scanId1.BackWith.ToString();
            textBox41.Text = scanId1.ArmpitCircumference.ToString();
            textBox40.Text = scanId1.HipCircumference.ToString();
            textBox39.Text = scanId1.BustGirth.ToString();
            panel3.Enabled = false;
            textBox2.Text = "BS_0010";
            textBox3.Text = "BS_0035";
            textBox4.Text = "BS_0080";
            textBox5.Text = "BS_0100";
            textBox6.Text = "BS_0110";
            textBox7.Text = "BS_0170";
            textBox8.Text = "BS_0190";
            textBox9.Text = "BS_1510";
            textBox10.Text = "BS_3030";
            textBox11.Text = "BS_3031";
            textBox12.Text = "BS_3910";
            textBox13.Text = "BS_3911";
            textBox14.Text = "BS_4030";
            textBox15.Text = "BS_4040";
            textBox16.Text = "BS_4080";
            textBox17.Text = "BS_4081";
            textBox18.Text = "BS_4510";
            textBox19.Text = "BS_5010";
            textBox20.Text = "BS_5040";
            textBox21.Text = "BS_6010";
            textBox22.Text = "BS_6510";
            textBox23.Text = "BS_7011";
            textBox24.Text = "BS_7510";
            textBox25.Text = "BS_7520";
            textBox26.Text = "BS_8010";
            textBox27.Text = "BS_8011";
            textBox28.Text = "BS_8030";
            textBox29.Text = "BS_8031";
            textBox30.Text = "BS_8040";
            textBox31.Text = "BS_8041";
            textBox32.Text = "BS_8520";
            textBox33.Text = "BS_8521";
            textBox34.Text = "BS_8530";
            textBox35.Text = "BS_8531";
            textBox36.Text = "BS_8534";
            textBox37.Text = "BS_8532";
            textBox38.Text = "BS_8533";
            panel2.Enabled = false;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Compare c1 = new Compare();
            c1.scanValues = scanId1;
            c1.designerValues = dAdjust;
            c1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaEkran a1 = new AnaEkran();
            a1.Show();
            this.Hide();
        }

        private double bosmu(TextBox textBox,double data)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                double t = Convert.ToDouble(textBox.Text);
                return t;
            }
            else return data;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            scanId1.BodyHeight = bosmu(textBox76, scanId1.BodyHeight);
            scanId1.ChestCircumferences = bosmu(textBox77, scanId1.ChestCircumferences);
            scanId1.WaistHeight = bosmu(textBox78, scanId1.WaistHeight);
            scanId1.CrotchHeight = bosmu(textBox79, scanId1.CrotchHeight);
            scanId1.BackHeight = bosmu(textBox80, scanId1.BackHeight);
            scanId1.BreastHeight = bosmu(textBox81, scanId1.BreastHeight);
            scanId1.NeckToWaistCenter = bosmu(textBox82, scanId1.NeckToWaistCenter);
            scanId1.MidNeckGirth = bosmu(textBox83, scanId1.MidNeckGirth);
            scanId1.ShoulderWidthLeft = bosmu(textBox84, scanId1.ShoulderWidthLeft);
            scanId1.ShoulderWidthRight = bosmu(textBox85, scanId1.ShoulderWidthRight);
            scanId1.ShoulderAngelLeft = bosmu(textBox86, scanId1.ShoulderAngelLeft);
            scanId1.ShoulderAngelRight = bosmu(textBox87, scanId1.ShoulderAngelRight);
            scanId1.BustPointsWidth = bosmu(textBox88, scanId1.BustPointsWidth);
            scanId1.NeckRightToWaistOverBust = bosmu(textBox89, scanId1.NeckRightToWaistOverBust);
            scanId1.BustPointAbuseNeckLeft = bosmu(textBox90, scanId1.BustPointAbuseNeckLeft);
            scanId1.AbusePointsToNeckRight = bosmu(textBox91, scanId1.AbusePointsToNeckRight);
            scanId1.BustChestGirthHorizontal = bosmu(textBox92, scanId1.BustChestGirthHorizontal);
            scanId1.AcrossBackWith = bosmu(textBox93, scanId1.AcrossBackWith);
            scanId1.NeckToWaistCenterBack = bosmu(textBox94, scanId1.NeckToWaistCenterBack);
            scanId1.CrotchLength = bosmu(textBox95, scanId1.CrotchLength);
            scanId1.WaistGirth = bosmu(textBox96, scanId1.WaistGirth);
            scanId1.WaistToButtockHeightRight = bosmu(textBox97, scanId1.WaistToButtockHeightRight);
            scanId1.HighHipGirth = bosmu(textBox98, scanId1.HighHipGirth);
            scanId1.ButtockGirth = bosmu(textBox99, scanId1.ButtockGirth);
            scanId1.ArmLengthToNeckBackLeft = bosmu(textBox100, scanId1.ArmLengthToNeckBackLeft);
            scanId1.ArmLengthToNeckBackRight = bosmu(textBox101, scanId1.ArmLengthToNeckBackRight);
            scanId1.ArmLengthLeft = bosmu(textBox102, scanId1.ArmLengthLeft);
            scanId1.ArmLengthRight = bosmu(textBox103, scanId1.ArmLengthRight);
            scanId1.UpperArmLengthLeft = bosmu(textBox104, scanId1.UpperArmLengthLeft);
            scanId1.UpperArmLengthRight = bosmu(textBox105, scanId1.UpperArmLengthRight);
            scanId1.UpperArmGirthLeft = bosmu(textBox106, scanId1.UpperArmGirthLeft);
            scanId1.UpperArmGirthRight = bosmu(textBox107, scanId1.UpperArmGirthRight);
            scanId1.ElbowGirthLeft = bosmu(textBox108, scanId1.ElbowGirthLeft);
            scanId1.BackWith = bosmu(textBox109, scanId1.BackWith);
            scanId1.ArmpitCircumference = bosmu(textBox110, scanId1.ArmpitCircumference);
            scanId1.HipCircumference = bosmu(textBox111, scanId1.HipCircumference);
            scanId1.BustGirth = bosmu(textBox112, scanId1.BustGirth);

            //dAdjust.BodyHeight = Convert.ToDouble(textBox76.Text);
            //dAdjust.ChestCircumferences = Convert.ToDouble(textBox77.Text);
            //dAdjust.WaistHeight = Convert.ToDouble(textBox78.Text);
            //dAdjust.CrotchHeight = Convert.ToDouble(textBox79.Text);
            //dAdjust.BackHeight = Convert.ToDouble(textBox80.Text);
            //dAdjust.BreastHeight = Convert.ToDouble(textBox81.Text);
            //dAdjust.NeckToWaistCenter = Convert.ToDouble(textBox82.Text);
            //dAdjust.MidNeckGirth = Convert.ToDouble(textBox83.Text);
            //dAdjust.ShoulderWidthLeft = Convert.ToDouble(textBox84.Text);
            //dAdjust.ShoulderWidthRight = Convert.ToDouble(textBox85.Text);
            //dAdjust.ShoulderAngelLeft = Convert.ToDouble(textBox86.Text);
            //dAdjust.ShoulderAngelRight = Convert.ToDouble(textBox87.Text);
            //dAdjust.BustPointsWidth = Convert.ToDouble(textBox88.Text);
            //dAdjust.NeckRightToWaistOverBust = Convert.ToDouble(textBox89.Text);
            //dAdjust.BustPointAbuseNeckLeft = Convert.ToDouble(textBox90.Text);
            //dAdjust.AbusePointsToNeckRight = Convert.ToDouble(textBox91.Text);
            //dAdjust.BustChestGirthHorizontal = Convert.ToDouble(textBox92.Text);
            //dAdjust.AcrossBackWith = Convert.ToDouble(textBox93.Text);
            //dAdjust.NeckToWaistCenterBack = Convert.ToDouble(textBox94.Text);
            //dAdjust.CrotchLength = Convert.ToDouble(textBox95.Text);
            //dAdjust.WaistGirth = Convert.ToDouble(textBox96.Text);
            //dAdjust.WaistToButtockHeightRight = Convert.ToDouble(textBox97.Text);
            //dAdjust.HighHipGirth = Convert.ToDouble(textBox98.Text);
            //dAdjust.ButtockGirth = Convert.ToDouble(textBox99.Text);
            //dAdjust.ArmLengthToNeckBackLeft = Convert.ToDouble(textBox100.Text);
            //dAdjust.ArmLengthToNeckBackRight = Convert.ToDouble(textBox101.Text);
            //dAdjust.ArmLengthLeft = Convert.ToDouble(textBox102.Text);
            //dAdjust.ArmLengthRight = Convert.ToDouble(textBox103.Text);
            //dAdjust.UpperArmLengthLeft = Convert.ToDouble(textBox104.Text);
            //dAdjust.UpperArmLengthRight = Convert.ToDouble(textBox105.Text);
            //dAdjust.UpperArmGirthLeft = Convert.ToDouble(textBox106.Text);
            //dAdjust.UpperArmGirthRight = Convert.ToDouble(textBox107.Text);
            //dAdjust.ElbowGirthLeft = Convert.ToDouble(textBox108.Text);
            //dAdjust.BackWith = Convert.ToDouble(textBox109.Text);
            //dAdjust.ArmpitCircumference = Convert.ToDouble(textBox110.Text);
            //dAdjust.HipCircumference = Convert.ToDouble(textBox111.Text);
            //dAdjust.BustGirth = Convert.ToDouble(textBox112.Text);
            MessageBox.Show("Datas Has Been Added!");


        }
    }
}
