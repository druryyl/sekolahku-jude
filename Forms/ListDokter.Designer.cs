namespace sekolahku_jude.Forms
{
    partial class ListDokter
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
            this.ListDokterFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.JadwalFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ListDokterFlowPanel
            // 
            this.ListDokterFlowPanel.AutoScroll = true;
            this.ListDokterFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListDokterFlowPanel.Location = new System.Drawing.Point(12, 41);
            this.ListDokterFlowPanel.Name = "ListDokterFlowPanel";
            this.ListDokterFlowPanel.Size = new System.Drawing.Size(296, 157);
            this.ListDokterFlowPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // JadwalFlowPanel
            // 
            this.JadwalFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JadwalFlowPanel.AutoScroll = true;
            this.JadwalFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JadwalFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.JadwalFlowPanel.Location = new System.Drawing.Point(330, 41);
            this.JadwalFlowPanel.Name = "JadwalFlowPanel";
            this.JadwalFlowPanel.Size = new System.Drawing.Size(458, 236);
            this.JadwalFlowPanel.TabIndex = 4;
            // 
            // ListDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JadwalFlowPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListDokterFlowPanel);
            this.Name = "ListDokter";
            this.Text = "ListDokter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ListDokterFlowPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel JadwalFlowPanel;
    }
}