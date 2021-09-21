namespace URL2IP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_ChangeUrl = new System.Windows.Forms.Button();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lb_IP = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_ChangeUrl
            // 
            this.btn_ChangeUrl.Location = new System.Drawing.Point(24, 47);
            this.btn_ChangeUrl.Name = "btn_ChangeUrl";
            this.btn_ChangeUrl.Size = new System.Drawing.Size(326, 29);
            this.btn_ChangeUrl.TabIndex = 0;
            this.btn_ChangeUrl.Text = "URL 2 IP";
            this.btn_ChangeUrl.UseVisualStyleBackColor = true;
            this.btn_ChangeUrl.Click += new System.EventHandler(this.btn_ChangeUrl_Click);
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(24, 21);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(326, 20);
            this.txt_Url.TabIndex = 1;
            this.txt_Url.Text = "www.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(26, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resulte :";
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(24, 298);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(326, 25);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Close";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lb_IP
            // 
            this.lb_IP.FormattingEnabled = true;
            this.lb_IP.Location = new System.Drawing.Point(24, 116);
            this.lb_IP.Name = "lb_IP";
            this.lb_IP.Size = new System.Drawing.Size(326, 173);
            this.lb_IP.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_ChangeUrl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(373, 344);
            this.Controls.Add(this.lb_IP);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.btn_ChangeUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URL2IP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangeUrl;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListBox lb_IP;
    }
}

