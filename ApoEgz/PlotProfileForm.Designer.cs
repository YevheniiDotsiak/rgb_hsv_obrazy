
namespace ApoEgz
{
    partial class PlotProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlotProfileForm));
            this.pictureBoxPlotImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlotImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlotImage
            // 
            this.pictureBoxPlotImage.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxPlotImage.Name = "pictureBoxPlotImage";
            this.pictureBoxPlotImage.Size = new System.Drawing.Size(797, 446);
            this.pictureBoxPlotImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPlotImage.TabIndex = 0;
            this.pictureBoxPlotImage.TabStop = false;
            this.pictureBoxPlotImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPlotImage_MouseDown);
            // 
            // PlotProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxPlotImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlotProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlotProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlotImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlotImage;
    }
}