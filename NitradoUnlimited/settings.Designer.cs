namespace NitradoUnlimited
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaccesstoken = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbluserid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkshowcredit = new System.Windows.Forms.CheckBox();
            this.checkshowrealname = new System.Windows.Forms.CheckBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtaccesstoken);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbluserid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblusername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gebe niemals dein Access Token oder Passwort weiter !!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Access Token:";
            // 
            // txtaccesstoken
            // 
            this.txtaccesstoken.HideSelection = false;
            this.txtaccesstoken.Location = new System.Drawing.Point(9, 85);
            this.txtaccesstoken.Name = "txtaccesstoken";
            this.txtaccesstoken.ReadOnly = true;
            this.txtaccesstoken.Size = new System.Drawing.Size(300, 20);
            this.txtaccesstoken.TabIndex = 6;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(74, 52);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(55, 13);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "%EMAIL%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email:";
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Location = new System.Drawing.Point(74, 39);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(64, 13);
            this.lbluserid.TabIndex = 3;
            this.lbluserid.Text = "%USERID%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "UserID:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(74, 26);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(84, 13);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "%USERNAME%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Controls.Add(this.checkshowrealname);
            this.groupBox2.Controls.Add(this.checkshowcredit);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Programm";
            // 
            // checkshowcredit
            // 
            this.checkshowcredit.AutoSize = true;
            this.checkshowcredit.Checked = true;
            this.checkshowcredit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkshowcredit.Location = new System.Drawing.Point(9, 20);
            this.checkshowcredit.Name = "checkshowcredit";
            this.checkshowcredit.Size = new System.Drawing.Size(119, 17);
            this.checkshowcredit.TabIndex = 0;
            this.checkshowcredit.Text = "Guthaben anzeigen";
            this.checkshowcredit.UseVisualStyleBackColor = true;
            // 
            // checkshowrealname
            // 
            this.checkshowrealname.AutoSize = true;
            this.checkshowrealname.Checked = true;
            this.checkshowrealname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkshowrealname.Location = new System.Drawing.Point(9, 43);
            this.checkshowrealname.Name = "checkshowrealname";
            this.checkshowrealname.Size = new System.Drawing.Size(134, 17);
            this.checkshowrealname.TabIndex = 1;
            this.checkshowrealname.Text = "Echter Name anzeigen";
            this.checkshowrealname.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(241, 188);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Speichern";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settings";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaccesstoken;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkshowcredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkshowrealname;
        private System.Windows.Forms.Button btnsave;
    }
}