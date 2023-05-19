namespace MediBot.pharma
{
    partial class uc_p_medivaliditycheck
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcheckcombobox_medivaliditycheck = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.validitycheckgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.setlabel = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.validitycheckgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Validity Check";
            // 
            // txtcheckcombobox_medivaliditycheck
            // 
            this.txtcheckcombobox_medivaliditycheck.BackColor = System.Drawing.Color.Transparent;
            this.txtcheckcombobox_medivaliditycheck.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtcheckcombobox_medivaliditycheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcheckcombobox_medivaliditycheck.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcheckcombobox_medivaliditycheck.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcheckcombobox_medivaliditycheck.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcheckcombobox_medivaliditycheck.ForeColor = System.Drawing.Color.Black;
            this.txtcheckcombobox_medivaliditycheck.ItemHeight = 30;
            this.txtcheckcombobox_medivaliditycheck.Items.AddRange(new object[] {
            "Valid Medicines",
            "Expired Medicines",
            "View All Medicines"});
            this.txtcheckcombobox_medivaliditycheck.Location = new System.Drawing.Point(575, 114);
            this.txtcheckcombobox_medivaliditycheck.Name = "txtcheckcombobox_medivaliditycheck";
            this.txtcheckcombobox_medivaliditycheck.Size = new System.Drawing.Size(399, 36);
            this.txtcheckcombobox_medivaliditycheck.TabIndex = 1;
            this.txtcheckcombobox_medivaliditycheck.SelectedIndexChanged += new System.EventHandler(this.txtcheckcombobox_medivaliditycheck_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Check";
            // 
            // validitycheckgridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.validitycheckgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.validitycheckgridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.validitycheckgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.validitycheckgridview.ColumnHeadersHeight = 4;
            this.validitycheckgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.validitycheckgridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.validitycheckgridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.validitycheckgridview.Location = new System.Drawing.Point(26, 245);
            this.validitycheckgridview.Name = "validitycheckgridview";
            this.validitycheckgridview.RowHeadersVisible = false;
            this.validitycheckgridview.RowHeadersWidth = 51;
            this.validitycheckgridview.RowTemplate.Height = 24;
            this.validitycheckgridview.Size = new System.Drawing.Size(1048, 467);
            this.validitycheckgridview.TabIndex = 17;
            this.validitycheckgridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.validitycheckgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.validitycheckgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.validitycheckgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.validitycheckgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.validitycheckgridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.validitycheckgridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.validitycheckgridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.validitycheckgridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.validitycheckgridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validitycheckgridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.validitycheckgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.validitycheckgridview.ThemeStyle.HeaderStyle.Height = 4;
            this.validitycheckgridview.ThemeStyle.ReadOnly = false;
            this.validitycheckgridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.validitycheckgridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.validitycheckgridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validitycheckgridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.validitycheckgridview.ThemeStyle.RowsStyle.Height = 24;
            this.validitycheckgridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.validitycheckgridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // setlabel
            // 
            this.setlabel.AutoSize = true;
            this.setlabel.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setlabel.Location = new System.Drawing.Point(32, 202);
            this.setlabel.Name = "setlabel";
            this.setlabel.Size = new System.Drawing.Size(62, 25);
            this.setlabel.TabIndex = 18;
            this.setlabel.Text = "Check";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // uc_p_medivaliditycheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.setlabel);
            this.Controls.Add(this.validitycheckgridview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcheckcombobox_medivaliditycheck);
            this.Controls.Add(this.label1);
            this.Name = "uc_p_medivaliditycheck";
            this.Size = new System.Drawing.Size(1100, 762);
            ((System.ComponentModel.ISupportInitialize)(this.validitycheckgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox txtcheckcombobox_medivaliditycheck;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView validitycheckgridview;
        private System.Windows.Forms.Label setlabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
