namespace WindowsFormsApplication1
{
    partial class frmKeyPress
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKeyPress));
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.IdleTimerTxt = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // IdleTimerTxt
            // 
            this.IdleTimerTxt.Location = new System.Drawing.Point(114, 55);
            this.IdleTimerTxt.Name = "IdleTimerTxt";
            this.IdleTimerTxt.Size = new System.Drawing.Size(120, 20);
            this.IdleTimerTxt.TabIndex = 0;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // frmKeyPress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 142);
            this.Controls.Add(this.IdleTimerTxt);
            this.Name = "frmKeyPress";
            this.Text = "key press";
            this.Load += new System.EventHandler(this.frmKeyPress_Load);
            this.Resize += new System.EventHandler(this.frmKeyPress_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.TextBox IdleTimerTxt;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

