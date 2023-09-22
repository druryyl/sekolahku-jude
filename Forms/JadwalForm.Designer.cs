namespace sekolahku_jude.Forms
{
    partial class JadwalForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.KelasNameText = new System.Windows.Forms.TextBox();
            this.KelasIdText = new System.Windows.Forms.TextBox();
            this.HariCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.KelasGrid = new System.Windows.Forms.DataGridView();
            this.JadwalGrid = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KelasGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JadwalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.KelasNameText);
            this.panel1.Controls.Add(this.KelasIdText);
            this.panel1.Controls.Add(this.HariCombo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 117);
            this.panel1.TabIndex = 1;
            // 
            // KelasNameText
            // 
            this.KelasNameText.Location = new System.Drawing.Point(69, 42);
            this.KelasNameText.Name = "KelasNameText";
            this.KelasNameText.ReadOnly = true;
            this.KelasNameText.Size = new System.Drawing.Size(121, 22);
            this.KelasNameText.TabIndex = 5;
            // 
            // KelasIdText
            // 
            this.KelasIdText.Location = new System.Drawing.Point(69, 14);
            this.KelasIdText.Name = "KelasIdText";
            this.KelasIdText.ReadOnly = true;
            this.KelasIdText.Size = new System.Drawing.Size(47, 22);
            this.KelasIdText.TabIndex = 4;
            // 
            // HariCombo
            // 
            this.HariCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HariCombo.FormattingEnabled = true;
            this.HariCombo.Location = new System.Drawing.Point(69, 70);
            this.HariCombo.Name = "HariCombo";
            this.HariCombo.Size = new System.Drawing.Size(121, 21);
            this.HariCombo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelas ID";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.KelasGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.JadwalGrid);
            this.splitContainer1.Panel2.Controls.Add(this.SaveButton);
            this.splitContainer1.Panel2.Controls.Add(this.NewButton);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(699, 336);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 5;
            // 
            // KelasGrid
            // 
            this.KelasGrid.AllowUserToAddRows = false;
            this.KelasGrid.AllowUserToDeleteRows = false;
            this.KelasGrid.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.KelasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KelasGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KelasGrid.Location = new System.Drawing.Point(0, 0);
            this.KelasGrid.Name = "KelasGrid";
            this.KelasGrid.Size = new System.Drawing.Size(232, 336);
            this.KelasGrid.TabIndex = 1;
            // 
            // JadwalGrid
            // 
            this.JadwalGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JadwalGrid.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.JadwalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JadwalGrid.Location = new System.Drawing.Point(2, 121);
            this.JadwalGrid.Name = "JadwalGrid";
            this.JadwalGrid.Size = new System.Drawing.Size(461, 186);
            this.JadwalGrid.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(388, 313);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewButton.Location = new System.Drawing.Point(0, 313);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 5;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // JadwalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(711, 349);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "JadwalForm";
            this.Text = "Jadwal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KelasGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JadwalGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox HariCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView KelasGrid;
        private System.Windows.Forms.DataGridView JadwalGrid;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.TextBox KelasNameText;
        private System.Windows.Forms.TextBox KelasIdText;
    }
}