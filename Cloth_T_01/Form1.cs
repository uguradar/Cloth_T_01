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
    public partial class AnaEkran : Form
    {
       public ScanData scanId1 = new ScanData();
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ThreeDScan_Click(object sender, EventArgs e)
        {
            TdScan td1 = new TdScan();
            td1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DesignerInput_Click(object sender, EventArgs e)
        {
            DesignerInputF di = new DesignerInputF();
            di.scanId1 = scanId1;
            di.Show();
            this.Hide();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            
            scanId1.BodyHeight = 185.3;
            scanId1.ChestCircumferences = 163.5;
            scanId1.WaistHeight = 115.5;
            scanId1.CrotchHeight = 82.5;
            scanId1.BackHeight = 82;
            scanId1.BreastHeight = 134.7;
            scanId1.NeckToWaistCenter = 47;
            scanId1.MidNeckGirth = 41.9;
            scanId1.ShoulderWidthLeft = 15.0;
            scanId1.ShoulderWidthRight = 14.4;
            scanId1.ShoulderAngelLeft = 24.90;
            scanId1.ShoulderAngelRight = 26.60;
            scanId1.BustPointsWidth = 20.7;
            scanId1.NeckRightToWaistOverBust = 46.6;
            scanId1.BustPointAbuseNeckLeft = 27.4;
            scanId1.AbusePointsToNeckRight = 27.3;
            scanId1.BustChestGirthHorizontal = 101.5;
            scanId1.AcrossBackWith = 41.3;
            scanId1.NeckToWaistCenterBack = 47.4;
            scanId1.CrotchLength = 94.3;
            scanId1.WaistGirth = 82.6;
            scanId1.WaistToButtockHeightRight = 20.7;
            scanId1.HighHipGirth = 90.6;
            scanId1.ButtockGirth = 99.1;
            scanId1.ArmLengthToNeckBackLeft = 85.6;
            scanId1.ArmLengthToNeckBackRight = 84.8;
            scanId1.ArmLengthLeft = 63.2;
            scanId1.ArmLengthRight = 62.9;
            scanId1.UpperArmLengthLeft = 35.0;
            scanId1.UpperArmLengthRight = 35.3;
            scanId1.UpperArmGirthLeft = 31.6;
            scanId1.UpperArmGirthRight = 31.7;
            scanId1.ElbowGirthLeft = 28.2;
            scanId1.BackWith = 48.0;
            scanId1.ArmpitCircumference = 55.5;
            scanId1.HipCircumference = 82.5;
            scanId1.BustGirth = 102;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compare c1 = new Compare();
            c1.Show();
            this.Hide();
        }
    }
}
