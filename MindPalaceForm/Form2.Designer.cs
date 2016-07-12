namespace MindPalaceForm
{
    partial class Form2
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
            this.gridDataProfiles = new System.Windows.Forms.DataGridView();
            this.headingGridLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDataProfiles
            // 
            this.gridDataProfiles.AllowUserToDeleteRows = false;
            this.gridDataProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDataProfiles.ColumnHeadersHeight = 30;
            this.gridDataProfiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridDataProfiles.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridDataProfiles.Location = new System.Drawing.Point(106, 154);
            this.gridDataProfiles.Name = "gridDataProfiles";
            this.gridDataProfiles.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridDataProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridDataProfiles.Size = new System.Drawing.Size(1071, 195);
            this.gridDataProfiles.TabIndex = 0;
            this.gridDataProfiles.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDataProfiles_CellValueChanged);
            // 
            // headingGridLbl
            // 
            this.headingGridLbl.AutoSize = true;
            this.headingGridLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headingGridLbl.Font = new System.Drawing.Font("Calibri", 24F);
            this.headingGridLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.headingGridLbl.Location = new System.Drawing.Point(554, 52);
            this.headingGridLbl.Name = "headingGridLbl";
            this.headingGridLbl.Size = new System.Drawing.Size(165, 41);
            this.headingGridLbl.TabIndex = 1;
            this.headingGridLbl.Text = "Profile Grid";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1262, 548);
            this.Controls.Add(this.headingGridLbl);
            this.Controls.Add(this.gridDataProfiles);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gridDataProfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDataProfiles;
        private System.Windows.Forms.Label headingGridLbl;
    }
}