namespace WinAppMdiExample
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
            btnShow = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnShow
            // 
          btnShow.Location = new System.Drawing.Point(0, 0);
          btnShow.Name = "btnShow";
          btnShow.Size = new System.Drawing.Size(75, 23);
          btnShow.TabIndex = 0;
          btnShow.Text = "Show";
          btnShow.UseVisualStyleBackColor = true;
          btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            panelAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelAdmin.Location = new System.Drawing.Point(0, 285);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new System.Drawing.Size(665, 88);
            panelAdmin.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 185);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(665, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 373);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(panelAdmin);
            this.Controls.Add(btnShow);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }


        #endregion

       
      
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}