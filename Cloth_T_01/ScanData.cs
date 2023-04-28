using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloth_T_01
{
    public class ScanData
    {
        public double BodyHeight { get; set; }
        public double ChestCircumferences { get; set; }
        public double WaistHeight { get; set; }
        public double CrotchHeight { get; set; }
        public double BackHeight { get; set; }
        public double BreastHeight { get; set; }
        public double NeckToWaistCenter { get; set; }
        public double MidNeckGirth { get; set; }
        public double ShoulderWidthLeft { get; set; }
        public double ShoulderWidthRight { get; set; }
        public double ShoulderAngelLeft { get; set; }
        public double ShoulderAngelRight { get; set; }
        public double BustPointsWidth { get; set; }
        public double NeckRightToWaistOverBust { get; set; }
        public double BustPointAbuseNeckLeft { get; set; }
        public double AbusePointsToNeckRight { get; set; }
        public double BustChestGirthHorizontal { get; set; }
        public double AcrossBackWith { get; set; }
        public double NeckToWaistCenterBack { get; set; }
        public double CrotchLength { get; set; }
        public double WaistGirth { get; set; }
        public double WaistToButtockHeightRight { get; set; }
        public double HighHipGirth { get; set; }
        public double ButtockGirth { get; set; }
        public double ArmLengthToNeckBackLeft { get; set; }
        public double ArmLengthToNeckBackRight { get; set; }
        public double ArmLengthLeft { get; set; }
        public double ArmLengthRight { get; set; }
        public double UpperArmLengthLeft { get; set; }
        public double UpperArmLengthRight { get; set; }
        public double UpperArmGirthLeft { get; set; }
        public double UpperArmGirthRight { get; set; }
        public double ElbowGirthLeft { get; set; }
        public double BackWith { get; set; }
        public double ArmpitCircumference { get; set; }
        public double HipCircumference { get; set; }
        public double BustGirth { get; set; }

        public void FillMeasurementData(double bodyHeight, double chestCircumferences, double waistHeight, double crotchHeight, double backHeight, double breastHeight, double neckToWaistCenter, double midNeckGirth, double shoulderWidthLeft, double shoulderWidthRight, double shoulderAngelLeft, double shoulderAngelRight, double bustPointsWidth, double neckRightToWaistOverBust, double bustPointAbuseNeckLeft, double abusePointsToNeckRight, double bustChestGirthHorizontal, double acrossBackWith, double neckToWaistCenterBack, double crotchLength, double waistGirth, double waistToButtockHeightRight, double highHipGirth, double buttockGirth, double armLengthToNeckBackLeft, double armLengthToNeckBackRight, double armLengthLeft, double armLengthRight, double upperArmLengthLeft, double upperArmLengthRight, double upperArmGirthLeft, double upperArmGirthRight, double elbowGirthLeft, double backWith, double armpitCircumference, double hipCircumference, double bustGirth)
        {
            this.BodyHeight = bodyHeight;
            this.ChestCircumferences = chestCircumferences;
            this.WaistHeight = waistHeight;
            this.CrotchHeight = crotchHeight;
            this.BackHeight = backHeight;
            this.BreastHeight = breastHeight;
            this.NeckToWaistCenter = neckToWaistCenter;
            this.MidNeckGirth = midNeckGirth;
            this.ShoulderWidthLeft = shoulderWidthLeft;
            this.ShoulderWidthRight = shoulderWidthRight;
            this.ShoulderAngelLeft = shoulderAngelLeft;
            this.ShoulderAngelRight = shoulderAngelRight;
            this.BustPointsWidth = bustPointsWidth;
            this.NeckRightToWaistOverBust = neckRightToWaistOverBust;
            this.BustPointAbuseNeckLeft = bustPointAbuseNeckLeft;
            this.AbusePointsToNeckRight = abusePointsToNeckRight;
            this.BustChestGirthHorizontal = bustChestGirthHorizontal;
            this.AcrossBackWith = acrossBackWith;
            this.NeckToWaistCenterBack = neckToWaistCenterBack;
            this.CrotchLength = crotchLength;
            this.WaistGirth = waistGirth;
            this.WaistToButtockHeightRight = waistToButtockHeightRight;
            this.HighHipGirth = highHipGirth;
            this.ButtockGirth = buttockGirth;
            this.ArmLengthToNeckBackLeft = armLengthToNeckBackLeft;
            this.ArmLengthToNeckBackRight = armLengthToNeckBackRight;
            this.ArmLengthLeft = armLengthLeft;
            this.ArmLengthRight = armLengthRight;
            this.UpperArmLengthLeft = upperArmLengthLeft;
            this.UpperArmLengthRight = upperArmLengthRight;
            this.UpperArmGirthLeft = upperArmGirthLeft;
            this.UpperArmGirthRight = upperArmGirthRight;
            this.ElbowGirthLeft = elbowGirthLeft;
            this.BackWith = backWith;
            this.ArmpitCircumference = armpitCircumference;
            this.HipCircumference = hipCircumference;
            this.BustGirth = bustGirth;
        }
    }
}
