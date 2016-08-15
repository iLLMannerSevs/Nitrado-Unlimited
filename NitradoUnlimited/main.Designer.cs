namespace NitradoUnlimited
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Gameserver", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Voiceserver", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Musicbot", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Webspace", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Domains", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("CMS", System.Windows.Forms.HorizontalAlignment.Left);
            this.labelusername = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelregistered = new System.Windows.Forms.Label();
            this.labelcredit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.avatarpic = new System.Windows.Forms.PictureBox();
            this.listservices = new System.Windows.Forms.ListView();
            this.imagelist = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarpic)).BeginInit();
            this.SuspendLayout();
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(118, 12);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(229, 34);
            this.labelusername.TabIndex = 1;
            this.labelusername.Text = "%USERNAME%";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(120, 46);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(83, 20);
            this.labelname.TabIndex = 2;
            this.labelname.Text = "%NAME%";
            // 
            // labelregistered
            // 
            this.labelregistered.AutoSize = true;
            this.labelregistered.Location = new System.Drawing.Point(121, 99);
            this.labelregistered.Name = "labelregistered";
            this.labelregistered.Size = new System.Drawing.Size(93, 13);
            this.labelregistered.TabIndex = 3;
            this.labelregistered.Text = "%REGISTERED%";
            // 
            // labelcredit
            // 
            this.labelcredit.AutoSize = true;
            this.labelcredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcredit.Location = new System.Drawing.Point(121, 83);
            this.labelcredit.Name = "labelcredit";
            this.labelcredit.Size = new System.Drawing.Size(108, 16);
            this.labelcredit.TabIndex = 4;
            this.labelcredit.Text = "%GUTHABEN%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listservices);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 460);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // btnsettings
            // 
            this.btnsettings.Location = new System.Drawing.Point(809, 57);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(120, 23);
            this.btnsettings.TabIndex = 7;
            this.btnsettings.Text = "Einstellungen";
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Image = global::NitradoUnlimited.Properties.Resources.refresh;
            this.btnupdate.Location = new System.Drawing.Point(886, 9);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(43, 42);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Image = global::NitradoUnlimited.Properties.Resources.logouticooon;
            this.btnlogout.Location = new System.Drawing.Point(809, 86);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(120, 39);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Logout";
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // avatarpic
            // 
            this.avatarpic.ErrorImage = ((System.Drawing.Image)(resources.GetObject("avatarpic.ErrorImage")));
            this.avatarpic.Location = new System.Drawing.Point(12, 12);
            this.avatarpic.Name = "avatarpic";
            this.avatarpic.Size = new System.Drawing.Size(100, 100);
            this.avatarpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarpic.TabIndex = 0;
            this.avatarpic.TabStop = false;
            // 
            // listservices
            // 
            this.listservices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup1.Header = "Gameserver";
            listViewGroup1.Name = "gameserver";
            listViewGroup2.Header = "Voiceserver";
            listViewGroup2.Name = "voiceserver";
            listViewGroup3.Header = "Musicbot";
            listViewGroup3.Name = "musicbot";
            listViewGroup4.Header = "Webspace";
            listViewGroup4.Name = "webspace";
            listViewGroup5.Header = "Domains";
            listViewGroup5.Name = "domains";
            listViewGroup6.Header = "CMS";
            listViewGroup6.Name = "clanpage";
            this.listservices.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.listservices.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.listservices.Location = new System.Drawing.Point(6, 28);
            this.listservices.MultiSelect = false;
            this.listservices.Name = "listservices";
            this.listservices.Size = new System.Drawing.Size(911, 426);
            this.listservices.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listservices.TabIndex = 0;
            this.listservices.TileSize = new System.Drawing.Size(268, 80);
            this.listservices.UseCompatibleStateImageBehavior = false;
            this.listservices.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listservices_MouseDoubleClick);
            // 
            // imagelist
            // 
            this.imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist.ImageStream")));
            this.imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist.Images.SetKeyName(0, "Backup-IBM-Server-icon.png");
            this.imagelist.Images.SetKeyName(1, "App-voice-support-headset-icon.png");
            this.imagelist.Images.SetKeyName(2, "browser-icon.png");
            this.imagelist.Images.SetKeyName(3, "browser-icon.png");
            this.imagelist.Images.SetKeyName(4, "pages-icon.png");
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 598);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsettings);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelcredit);
            this.Controls.Add(this.labelregistered);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.avatarpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "Nitrado Unlimited";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarpic;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelregistered;
        private System.Windows.Forms.Label labelcredit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ListView listservices;
        private System.Windows.Forms.ImageList imagelist;
    }
}

