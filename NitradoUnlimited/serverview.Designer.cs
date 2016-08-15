namespace NitradoUnlimited
{
    partial class serverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverview));
            this.btnreload = new System.Windows.Forms.Button();
            this.serverimage = new System.Windows.Forms.PictureBox();
            this.labelgameservertype = new System.Windows.Forms.Label();
            this.labelgame = new System.Windows.Forms.Label();
            this.labelip = new System.Windows.Forms.Label();
            this.labelstatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelservice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.serverimage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnreload
            // 
            this.btnreload.Image = global::NitradoUnlimited.Properties.Resources.refresh;
            this.btnreload.Location = new System.Drawing.Point(837, 12);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(47, 44);
            this.btnreload.TabIndex = 0;
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // serverimage
            // 
            this.serverimage.Location = new System.Drawing.Point(12, 12);
            this.serverimage.Name = "serverimage";
            this.serverimage.Size = new System.Drawing.Size(120, 120);
            this.serverimage.TabIndex = 1;
            this.serverimage.TabStop = false;
            // 
            // labelgameservertype
            // 
            this.labelgameservertype.AutoSize = true;
            this.labelgameservertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgameservertype.Location = new System.Drawing.Point(139, 13);
            this.labelgameservertype.Name = "labelgameservertype";
            this.labelgameservertype.Size = new System.Drawing.Size(396, 37);
            this.labelgameservertype.TabIndex = 2;
            this.labelgameservertype.Text = "%GAMESERVERTYPE%";
            // 
            // labelgame
            // 
            this.labelgame.AutoSize = true;
            this.labelgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgame.Location = new System.Drawing.Point(140, 50);
            this.labelgame.Name = "labelgame";
            this.labelgame.Size = new System.Drawing.Size(141, 31);
            this.labelgame.TabIndex = 3;
            this.labelgame.Text = "%GAME%";
            // 
            // labelip
            // 
            this.labelip.AutoSize = true;
            this.labelip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelip.Location = new System.Drawing.Point(142, 81);
            this.labelip.Name = "labelip";
            this.labelip.Size = new System.Drawing.Size(52, 20);
            this.labelip.TabIndex = 4;
            this.labelip.Text = "%IP%";
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstatus.Location = new System.Drawing.Point(143, 116);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(75, 16);
            this.labelstatus.TabIndex = 5;
            this.labelstatus.Text = "%status%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Neustarten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(809, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelservice
            // 
            this.labelservice.AutoSize = true;
            this.labelservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelservice.Location = new System.Drawing.Point(725, 81);
            this.labelservice.Name = "labelservice";
            this.labelservice.Size = new System.Drawing.Size(103, 16);
            this.labelservice.TabIndex = 9;
            this.labelservice.Text = "%SERVICEID%";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 354);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "%GAMENAME%";
            // 
            // serverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelservice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.labelip);
            this.Controls.Add(this.labelgame);
            this.Controls.Add(this.labelgameservertype);
            this.Controls.Add(this.serverimage);
            this.Controls.Add(this.btnreload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "serverview";
            this.Text = "%SERVERVIEW%";
            this.Load += new System.EventHandler(this.serverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serverimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.PictureBox serverimage;
        private System.Windows.Forms.Label labelgameservertype;
        private System.Windows.Forms.Label labelgame;
        private System.Windows.Forms.Label labelip;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelservice;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}