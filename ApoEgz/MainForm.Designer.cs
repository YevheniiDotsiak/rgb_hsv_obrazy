
namespace ApoEgz
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonProfileLine = new System.Windows.Forms.Button();
            this.buttonHSV = new System.Windows.Forms.Button();
            this.buttonRGB = new System.Windows.Forms.Button();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProfileLine
            // 
            this.buttonProfileLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProfileLine.FlatAppearance.BorderSize = 0;
            this.buttonProfileLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfileLine.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProfileLine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonProfileLine.Image = global::ApoEgz.Properties.Resources.line;
            this.buttonProfileLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfileLine.Location = new System.Drawing.Point(191, 6);
            this.buttonProfileLine.Name = "buttonProfileLine";
            this.buttonProfileLine.Size = new System.Drawing.Size(171, 56);
            this.buttonProfileLine.TabIndex = 6;
            this.buttonProfileLine.Text = "Profile line";
            this.buttonProfileLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProfileLine.UseVisualStyleBackColor = true;
            this.buttonProfileLine.Click += new System.EventHandler(this.buttonProfileLine_Click);
            // 
            // buttonHSV
            // 
            this.buttonHSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHSV.FlatAppearance.BorderSize = 0;
            this.buttonHSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHSV.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHSV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHSV.Image = global::ApoEgz.Properties.Resources.hsv;
            this.buttonHSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHSV.Location = new System.Drawing.Point(686, 6);
            this.buttonHSV.Name = "buttonHSV";
            this.buttonHSV.Size = new System.Drawing.Size(115, 56);
            this.buttonHSV.TabIndex = 4;
            this.buttonHSV.Text = "HSV";
            this.buttonHSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHSV.UseVisualStyleBackColor = true;
            this.buttonHSV.Click += new System.EventHandler(this.buttonHSV_Click);
            // 
            // buttonRGB
            // 
            this.buttonRGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRGB.Enabled = false;
            this.buttonRGB.FlatAppearance.BorderSize = 0;
            this.buttonRGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRGB.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRGB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRGB.Image = global::ApoEgz.Properties.Resources.rgb_v2_1;
            this.buttonRGB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRGB.Location = new System.Drawing.Point(565, 6);
            this.buttonRGB.Name = "buttonRGB";
            this.buttonRGB.Size = new System.Drawing.Size(115, 56);
            this.buttonRGB.TabIndex = 3;
            this.buttonRGB.Text = "RGB";
            this.buttonRGB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRGB.UseVisualStyleBackColor = true;
            this.buttonRGB.Click += new System.EventHandler(this.buttonRGB_Click);
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.FlatAppearance.BorderSize = 0;
            this.buttonOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenImage.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOpenImage.Image = global::ApoEgz.Properties.Resources.ico_img;
            this.buttonOpenImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenImage.Location = new System.Drawing.Point(12, 6);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(173, 56);
            this.buttonOpenImage.TabIndex = 1;
            this.buttonOpenImage.Text = "Open image";
            this.buttonOpenImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBoxMain.Location = new System.Drawing.Point(12, 68);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(789, 529);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(813, 609);
            this.Controls.Add(this.buttonProfileLine);
            this.Controls.Add(this.buttonHSV);
            this.Controls.Add(this.buttonRGB);
            this.Controls.Add(this.buttonOpenImage);
            this.Controls.Add(this.pictureBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApoEgz";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.Button buttonRGB;
        private System.Windows.Forms.Button buttonHSV;
        public System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button buttonProfileLine;
    }
}

