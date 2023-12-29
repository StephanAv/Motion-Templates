
namespace Motion_Templates_UI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start_btn = new System.Windows.Forms.Button();
            this.select_folder_btn = new System.Windows.Forms.Button();
            this.folder_box = new System.Windows.Forms.TextBox();
            this.tc_name_box = new System.Windows.Forms.TextBox();
            this.plc_name_box = new System.Windows.Forms.TextBox();
            this.tc_project_name_lbl = new System.Windows.Forms.Label();
            this.plc_project_name_lbl = new System.Windows.Forms.Label();
            this.template_box = new System.Windows.Forms.ListBox();
            this.template_lbl = new System.Windows.Forms.Label();
            this.n_axis_lbl = new System.Windows.Forms.Label();
            this.n_axis = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.n_axis)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(6, 231);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(508, 23);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // select_folder_btn
            // 
            this.select_folder_btn.Location = new System.Drawing.Point(6, 186);
            this.select_folder_btn.Name = "select_folder_btn";
            this.select_folder_btn.Size = new System.Drawing.Size(96, 23);
            this.select_folder_btn.TabIndex = 1;
            this.select_folder_btn.Text = "Select folder";
            this.select_folder_btn.UseVisualStyleBackColor = true;
            this.select_folder_btn.Click += new System.EventHandler(this.select_folder_btn_Click);
            // 
            // folder_box
            // 
            this.folder_box.Location = new System.Drawing.Point(114, 188);
            this.folder_box.Name = "folder_box";
            this.folder_box.Size = new System.Drawing.Size(400, 20);
            this.folder_box.TabIndex = 2;
            // 
            // tc_name_box
            // 
            this.tc_name_box.Location = new System.Drawing.Point(114, 114);
            this.tc_name_box.Name = "tc_name_box";
            this.tc_name_box.Size = new System.Drawing.Size(270, 20);
            this.tc_name_box.TabIndex = 3;
            this.tc_name_box.Text = "MC2 Base";
            // 
            // plc_name_box
            // 
            this.plc_name_box.Location = new System.Drawing.Point(114, 152);
            this.plc_name_box.Name = "plc_name_box";
            this.plc_name_box.Size = new System.Drawing.Size(270, 20);
            this.plc_name_box.TabIndex = 4;
            // 
            // tc_project_name_lbl
            // 
            this.tc_project_name_lbl.AutoSize = true;
            this.tc_project_name_lbl.Location = new System.Drawing.Point(11, 117);
            this.tc_project_name_lbl.Name = "tc_project_name_lbl";
            this.tc_project_name_lbl.Size = new System.Drawing.Size(86, 13);
            this.tc_project_name_lbl.TabIndex = 5;
            this.tc_project_name_lbl.Text = "TC Project name";
            // 
            // plc_project_name_lbl
            // 
            this.plc_project_name_lbl.AutoSize = true;
            this.plc_project_name_lbl.Location = new System.Drawing.Point(11, 155);
            this.plc_project_name_lbl.Name = "plc_project_name_lbl";
            this.plc_project_name_lbl.Size = new System.Drawing.Size(91, 13);
            this.plc_project_name_lbl.TabIndex = 6;
            this.plc_project_name_lbl.Text = "PLC project name";
            // 
            // template_box
            // 
            this.template_box.FormattingEnabled = true;
            this.template_box.Location = new System.Drawing.Point(114, 34);
            this.template_box.Name = "template_box";
            this.template_box.Size = new System.Drawing.Size(270, 69);
            this.template_box.TabIndex = 7;
            this.template_box.SelectedIndexChanged += new System.EventHandler(this.selected_template_changed);
            // 
            // template_lbl
            // 
            this.template_lbl.AutoSize = true;
            this.template_lbl.Location = new System.Drawing.Point(11, 34);
            this.template_lbl.Name = "template_lbl";
            this.template_lbl.Size = new System.Drawing.Size(66, 26);
            this.template_lbl.TabIndex = 8;
            this.template_lbl.Text = "Choose PLC\r\ntemplate";
            // 
            // n_axis_lbl
            // 
            this.n_axis_lbl.AutoSize = true;
            this.n_axis_lbl.Location = new System.Drawing.Point(406, 34);
            this.n_axis_lbl.Name = "n_axis_lbl";
            this.n_axis_lbl.Size = new System.Drawing.Size(108, 13);
            this.n_axis_lbl.TabIndex = 9;
            this.n_axis_lbl.Text = "Select number of axis";
            // 
            // n_axis
            // 
            this.n_axis.Location = new System.Drawing.Point(409, 59);
            this.n_axis.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.n_axis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_axis.Name = "n_axis";
            this.n_axis.Size = new System.Drawing.Size(105, 20);
            this.n_axis.TabIndex = 10;
            this.n_axis.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 271);
            this.Controls.Add(this.n_axis);
            this.Controls.Add(this.n_axis_lbl);
            this.Controls.Add(this.template_lbl);
            this.Controls.Add(this.template_box);
            this.Controls.Add(this.plc_project_name_lbl);
            this.Controls.Add(this.tc_project_name_lbl);
            this.Controls.Add(this.plc_name_box);
            this.Controls.Add(this.tc_name_box);
            this.Controls.Add(this.folder_box);
            this.Controls.Add(this.select_folder_btn);
            this.Controls.Add(this.Start_btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motion Templates";
            ((System.ComponentModel.ISupportInitialize)(this.n_axis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button select_folder_btn;
        private System.Windows.Forms.TextBox folder_box;
        private System.Windows.Forms.TextBox tc_name_box;
        private System.Windows.Forms.TextBox plc_name_box;
        private System.Windows.Forms.Label tc_project_name_lbl;
        private System.Windows.Forms.Label plc_project_name_lbl;
        private System.Windows.Forms.ListBox template_box;
        private System.Windows.Forms.Label template_lbl;
        private System.Windows.Forms.Label n_axis_lbl;
        private System.Windows.Forms.NumericUpDown n_axis;
    }
}

