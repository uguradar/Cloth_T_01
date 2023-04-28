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
    public partial class TdScan : Form
    {
        public TdScan()
        {
            InitializeComponent();
        }

        private void TdScan_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)
            {
                progressBar1.Value += 10;
                if (label2.Text.Length < 3)
                    label2.Text += ".";
                else
                    label2.Text = "";

            }
            else
            {
                timer1.Stop();
                String mesaj = "Scanning Completed.Re-run?";
                DialogResult result = MessageBox.Show(mesaj, "Scanning Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, true);
                if (result == DialogResult.Yes)
                {
                    // Kullanıcı "Hayır" seçeneğini seçti
                    timer1.Start();
                    progressBar1.Value = 0;
                }
                else if (result == DialogResult.No)
                {
                    
                    AnaEkran a1 = new AnaEkran();
                    a1.Show();
                    this.Hide();
                }
            }
        }
    }
}
