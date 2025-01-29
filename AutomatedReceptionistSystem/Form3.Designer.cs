namespace AutomatedReceptionistSystem
{
    partial class frmServices
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
            this.lblRequierments = new System.Windows.Forms.Label();
            this.checkedListBoxServices = new System.Windows.Forms.CheckedListBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequierments
            // 
            this.lblRequierments.AutoSize = true;
            this.lblRequierments.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblRequierments.Font = new System.Drawing.Font("Baskerville Old Face", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequierments.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblRequierments.Location = new System.Drawing.Point(280, 81);
            this.lblRequierments.Name = "lblRequierments";
            this.lblRequierments.Size = new System.Drawing.Size(460, 48);
            this.lblRequierments.TabIndex = 2;
            this.lblRequierments.Text = "Enter user requierments.";
            // 
            // checkedListBoxServices
            // 
            this.checkedListBoxServices.BackColor = System.Drawing.SystemColors.Desktop;
            this.checkedListBoxServices.CheckOnClick = true;
            this.checkedListBoxServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxServices.ForeColor = System.Drawing.Color.OrangeRed;
            this.checkedListBoxServices.FormattingEnabled = true;
            this.checkedListBoxServices.Items.AddRange(new object[] {
            "Body Wash",
            "Interior Clean",
            "Full Service",
            "Body/Paint Repairs"});
            this.checkedListBoxServices.Location = new System.Drawing.Point(183, 170);
            this.checkedListBoxServices.Name = "checkedListBoxServices";
            this.checkedListBoxServices.Size = new System.Drawing.Size(461, 204);
            this.checkedListBoxServices.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnEnter.Location = new System.Drawing.Point(183, 390);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(461, 71);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::AutomatedReceptionistSystem.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(88, 36);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(186, 128);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutomatedReceptionistSystem.Properties.Resources.Services_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(830, 500);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.checkedListBoxServices);
            this.Controls.Add(this.lblRequierments);
            this.Name = "frmServices";
            this.Text = "Services";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequierments;
        private System.Windows.Forms.CheckedListBox checkedListBoxServices;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}