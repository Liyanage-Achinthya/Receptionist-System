namespace AutomatedReceptionistSystem
{
    partial class frmCheckout
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
            this.lblThankYou = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThankYou
            // 
            this.lblThankYou.AutoSize = true;
            this.lblThankYou.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblThankYou.Font = new System.Drawing.Font("Baskerville Old Face", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThankYou.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblThankYou.Location = new System.Drawing.Point(206, 52);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(428, 48);
            this.lblThankYou.TabIndex = 3;
            this.lblThankYou.Text = "Thank you for coming.";
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnFinish.Location = new System.Drawing.Point(111, 200);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(431, 93);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::AutomatedReceptionistSystem.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(186, 128);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutomatedReceptionistSystem.Properties.Resources.Checkout_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 371);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblThankYou);
            this.Name = "frmCheckout";
            this.Text = " Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}