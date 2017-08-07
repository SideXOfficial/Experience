namespace ReceivePicture
{
    partial class DownloadServer
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
            this.ServerPictureBox = new System.Windows.Forms.PictureBox();
            this.NotificationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ServerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerPictureBox
            // 
            this.ServerPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerPictureBox.Location = new System.Drawing.Point(46, 49);
            this.ServerPictureBox.Name = "ServerPictureBox";
            this.ServerPictureBox.Size = new System.Drawing.Size(251, 245);
            this.ServerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ServerPictureBox.TabIndex = 0;
            this.ServerPictureBox.TabStop = false;
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Location = new System.Drawing.Point(59, 24);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(223, 13);
            this.NotificationLabel.TabIndex = 1;
            this.NotificationLabel.Text = "Picture which was downloaded from the client";
            // 
            // DownloadServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 307);
            this.Controls.Add(this.NotificationLabel);
            this.Controls.Add(this.ServerPictureBox);
            this.MaximumSize = new System.Drawing.Size(365, 345);
            this.MinimumSize = new System.Drawing.Size(365, 345);
            this.Name = "DownloadServer";
            this.Text = "DownLoadServer";
            this.Load += new System.EventHandler(this.DownloadServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ServerPictureBox;
        private System.Windows.Forms.Label NotificationLabel;
    }
}

