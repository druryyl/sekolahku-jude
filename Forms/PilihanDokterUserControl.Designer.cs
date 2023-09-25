namespace sekolahku_jude.Forms
{
    partial class PilihanDokterUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PIlihCheckbox = new System.Windows.Forms.CheckBox();
            this.DokterLabel = new System.Windows.Forms.Label();
            this.SpesialisLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PIlihCheckbox
            // 
            this.PIlihCheckbox.AutoSize = true;
            this.PIlihCheckbox.Location = new System.Drawing.Point(0, 3);
            this.PIlihCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PIlihCheckbox.Name = "PIlihCheckbox";
            this.PIlihCheckbox.Size = new System.Drawing.Size(15, 14);
            this.PIlihCheckbox.TabIndex = 0;
            this.PIlihCheckbox.UseVisualStyleBackColor = true;
            // 
            // DokterLabel
            // 
            this.DokterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DokterLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DokterLabel.Location = new System.Drawing.Point(15, 0);
            this.DokterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DokterLabel.Name = "DokterLabel";
            this.DokterLabel.Size = new System.Drawing.Size(227, 21);
            this.DokterLabel.TabIndex = 1;
            this.DokterLabel.Text = "Agus Budiman, Sp.OG";
            // 
            // SpesialisLabel
            // 
            this.SpesialisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpesialisLabel.Location = new System.Drawing.Point(19, 21);
            this.SpesialisLabel.Name = "SpesialisLabel";
            this.SpesialisLabel.Size = new System.Drawing.Size(223, 20);
            this.SpesialisLabel.TabIndex = 2;
            this.SpesialisLabel.Text = "Spesialis";
            this.SpesialisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PilihanDokterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SpesialisLabel);
            this.Controls.Add(this.DokterLabel);
            this.Controls.Add(this.PIlihCheckbox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PilihanDokterUserControl";
            this.Size = new System.Drawing.Size(242, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PIlihCheckbox;
        private System.Windows.Forms.Label DokterLabel;
        private System.Windows.Forms.Label SpesialisLabel;
    }
}
