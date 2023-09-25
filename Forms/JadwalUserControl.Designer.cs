namespace sekolahku_jude.Forms
{
    partial class JadwalUserControl
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
            this.UmumLabel = new System.Windows.Forms.Label();
            this.TglLabel = new System.Windows.Forms.Label();
            this.PIlihCheckbox = new System.Windows.Forms.CheckBox();
            this.BpjsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UmumLabel
            // 
            this.UmumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UmumLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UmumLabel.Location = new System.Drawing.Point(19, 27);
            this.UmumLabel.Name = "UmumLabel";
            this.UmumLabel.Size = new System.Drawing.Size(217, 20);
            this.UmumLabel.TabIndex = 5;
            this.UmumLabel.Text = "Umum";
            this.UmumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TglLabel
            // 
            this.TglLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TglLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TglLabel.Location = new System.Drawing.Point(15, 6);
            this.TglLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TglLabel.Name = "TglLabel";
            this.TglLabel.Size = new System.Drawing.Size(221, 21);
            this.TglLabel.TabIndex = 4;
            this.TglLabel.Text = "Senin";
            // 
            // PIlihCheckbox
            // 
            this.PIlihCheckbox.AutoSize = true;
            this.PIlihCheckbox.Location = new System.Drawing.Point(0, 9);
            this.PIlihCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.PIlihCheckbox.Name = "PIlihCheckbox";
            this.PIlihCheckbox.Size = new System.Drawing.Size(15, 14);
            this.PIlihCheckbox.TabIndex = 3;
            this.PIlihCheckbox.UseVisualStyleBackColor = true;
            // 
            // BpjsLabel
            // 
            this.BpjsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BpjsLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BpjsLabel.Location = new System.Drawing.Point(19, 47);
            this.BpjsLabel.Name = "BpjsLabel";
            this.BpjsLabel.Size = new System.Drawing.Size(217, 20);
            this.BpjsLabel.TabIndex = 6;
            this.BpjsLabel.Text = "BPJS";
            this.BpjsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JadwalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BpjsLabel);
            this.Controls.Add(this.UmumLabel);
            this.Controls.Add(this.TglLabel);
            this.Controls.Add(this.PIlihCheckbox);
            this.Name = "JadwalUserControl";
            this.Size = new System.Drawing.Size(236, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UmumLabel;
        private System.Windows.Forms.Label TglLabel;
        private System.Windows.Forms.CheckBox PIlihCheckbox;
        private System.Windows.Forms.Label BpjsLabel;
    }
}
