namespace NitradoUnlimited
{
    partial class web
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(web));
            this.panel1 = new System.Windows.Forms.Panel();
            this.webbro = new System.Windows.Forms.WebBrowser();
            this.txturl = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webbro);
            this.panel1.Location = new System.Drawing.Point(-1, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 615);
            this.panel1.TabIndex = 0;
            // 
            // webbro
            // 
            this.webbro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webbro.Location = new System.Drawing.Point(0, 0);
            this.webbro.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbro.Name = "webbro";
            this.webbro.Size = new System.Drawing.Size(919, 615);
            this.webbro.TabIndex = 0;
            // 
            // txturl
            // 
            this.txturl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturl.Location = new System.Drawing.Point(-1, 0);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(919, 26);
            this.txturl.TabIndex = 1;
            // 
            // web
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 636);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "web";
            this.Text = "Webbrowser - Nitrado Unlimited";
            this.Load += new System.EventHandler(this.web_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webbro;
        private System.Windows.Forms.TextBox txturl;
    }
}