namespace SendPicture
{
    partial class UploadClient
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
            this.UploadButton = new System.Windows.Forms.Button();
            this.UploadPictureBox = new System.Windows.Forms.PictureBox();
            this.ClientToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadButton.Location = new System.Drawing.Point(303, 265);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(120, 23);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "Upload picture";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // UploadPictureBox
            // 
            this.UploadPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UploadPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UploadPictureBox.Location = new System.Drawing.Point(12, 12);
            this.UploadPictureBox.Name = "UploadPictureBox";
            this.UploadPictureBox.Size = new System.Drawing.Size(279, 276);
            this.UploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UploadPictureBox.TabIndex = 1;
            this.UploadPictureBox.TabStop = false;
            this.ClientToolTip.SetToolTip(this.UploadPictureBox, "When picture will be upload to the server. You will see picture here.");
            // 
            // UploadClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 295);
            this.Controls.Add(this.UploadPictureBox);
            this.Controls.Add(this.UploadButton);
            this.MaximumSize = new System.Drawing.Size(451, 333);
            this.MinimumSize = new System.Drawing.Size(451, 333);
            this.Name = "UploadClient";
            this.Text = "UpLoadClient";
            this.Load += new System.EventHandler(this.UploadClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UploadPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.PictureBox UploadPictureBox;
        private System.Windows.Forms.ToolTip ClientToolTip;
    }
}

