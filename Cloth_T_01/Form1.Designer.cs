
namespace Cloth_T_01
{
    partial class AnaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.DesignerInput = new System.Windows.Forms.Button();
            this.ThreeDScan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DesignerInput
            // 
            this.DesignerInput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DesignerInput.BackgroundImage")));
            this.DesignerInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DesignerInput.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DesignerInput.FlatAppearance.BorderSize = 100;
            this.DesignerInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DesignerInput.Font = new System.Drawing.Font("Fashion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignerInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DesignerInput.Location = new System.Drawing.Point(28, 91);
            this.DesignerInput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.DesignerInput.Name = "DesignerInput";
            this.DesignerInput.Size = new System.Drawing.Size(240, 200);
            this.DesignerInput.TabIndex = 0;
            this.DesignerInput.Text = "Designer Input";
            this.DesignerInput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DesignerInput.UseVisualStyleBackColor = true;
            this.DesignerInput.Click += new System.EventHandler(this.DesignerInput_Click);
            // 
            // ThreeDScan
            // 
            this.ThreeDScan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ThreeDScan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ThreeDScan.BackgroundImage")));
            this.ThreeDScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThreeDScan.FlatAppearance.BorderSize = 100;
            this.ThreeDScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ThreeDScan.Font = new System.Drawing.Font("Fashion", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeDScan.Location = new System.Drawing.Point(311, 91);
            this.ThreeDScan.Name = "ThreeDScan";
            this.ThreeDScan.Size = new System.Drawing.Size(240, 200);
            this.ThreeDScan.TabIndex = 1;
            this.ThreeDScan.Text = "3D Scan Input";
            this.ThreeDScan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ThreeDScan.UseVisualStyleBackColor = true;
            this.ThreeDScan.Click += new System.EventHandler(this.ThreeDScan_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 100;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Fashion", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(28, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 200);
            this.button1.TabIndex = 2;
            this.button1.Text = "Compare";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Font = new System.Drawing.Font("Fashion", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitButton.Location = new System.Drawing.Point(311, 338);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(240, 200);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fashion", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "CLOTH FEAUTRES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThreeDScan);
            this.Controls.Add(this.DesignerInput);
            this.Font = new System.Drawing.Font("Fashion", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.MaximizeBox = false;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DesignerInput;
        private System.Windows.Forms.Button ThreeDScan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

