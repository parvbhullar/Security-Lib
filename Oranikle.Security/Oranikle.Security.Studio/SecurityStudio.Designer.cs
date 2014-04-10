namespace Oranikle.Security.Studio
{
    partial class SecurityStudio
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
            this.gbEncryption = new System.Windows.Forms.GroupBox();
            this.lblEncryptionText = new System.Windows.Forms.Label();
            this.txtEncryptionText = new System.Windows.Forms.TextBox();
            this.txtEncryptionResult = new System.Windows.Forms.TextBox();
            this.lblEncryptionResult = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.gbHash = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.txtHashResult = new System.Windows.Forms.TextBox();
            this.lblHashResult = new System.Windows.Forms.Label();
            this.txtHashText = new System.Windows.Forms.TextBox();
            this.lblHashText = new System.Windows.Forms.Label();
            this.gbEncryption.SuspendLayout();
            this.gbHash.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEncryption
            // 
            this.gbEncryption.Controls.Add(this.btnDecrypt);
            this.gbEncryption.Controls.Add(this.btnEncrypt);
            this.gbEncryption.Controls.Add(this.txtEncryptionResult);
            this.gbEncryption.Controls.Add(this.lblEncryptionResult);
            this.gbEncryption.Controls.Add(this.txtEncryptionText);
            this.gbEncryption.Controls.Add(this.lblEncryptionText);
            this.gbEncryption.Location = new System.Drawing.Point(13, 13);
            this.gbEncryption.Name = "gbEncryption";
            this.gbEncryption.Size = new System.Drawing.Size(637, 119);
            this.gbEncryption.TabIndex = 0;
            this.gbEncryption.TabStop = false;
            this.gbEncryption.Text = "Encryption/Decryption";
            // 
            // lblEncryptionText
            // 
            this.lblEncryptionText.AutoSize = true;
            this.lblEncryptionText.Location = new System.Drawing.Point(45, 21);
            this.lblEncryptionText.Name = "lblEncryptionText";
            this.lblEncryptionText.Size = new System.Drawing.Size(28, 13);
            this.lblEncryptionText.TabIndex = 0;
            this.lblEncryptionText.Text = "Text";
            // 
            // txtEncryptionText
            // 
            this.txtEncryptionText.Location = new System.Drawing.Point(79, 18);
            this.txtEncryptionText.Name = "txtEncryptionText";
            this.txtEncryptionText.Size = new System.Drawing.Size(539, 20);
            this.txtEncryptionText.TabIndex = 1;
            // 
            // txtEncryptionResult
            // 
            this.txtEncryptionResult.Location = new System.Drawing.Point(79, 80);
            this.txtEncryptionResult.Name = "txtEncryptionResult";
            this.txtEncryptionResult.ReadOnly = true;
            this.txtEncryptionResult.Size = new System.Drawing.Size(539, 20);
            this.txtEncryptionResult.TabIndex = 3;
            // 
            // lblEncryptionResult
            // 
            this.lblEncryptionResult.AutoSize = true;
            this.lblEncryptionResult.Location = new System.Drawing.Point(36, 83);
            this.lblEncryptionResult.Name = "lblEncryptionResult";
            this.lblEncryptionResult.Size = new System.Drawing.Size(37, 13);
            this.lblEncryptionResult.TabIndex = 2;
            this.lblEncryptionResult.Text = "Result";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(543, 44);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(457, 44);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // gbHash
            // 
            this.gbHash.Controls.Add(this.btnHash);
            this.gbHash.Controls.Add(this.txtHashResult);
            this.gbHash.Controls.Add(this.lblHashResult);
            this.gbHash.Controls.Add(this.txtHashText);
            this.gbHash.Controls.Add(this.lblHashText);
            this.gbHash.Location = new System.Drawing.Point(13, 143);
            this.gbHash.Name = "gbHash";
            this.gbHash.Size = new System.Drawing.Size(637, 119);
            this.gbHash.TabIndex = 1;
            this.gbHash.TabStop = false;
            this.gbHash.Text = "Hashing";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(575, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(543, 44);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(75, 23);
            this.btnHash.TabIndex = 4;
            this.btnHash.Text = "Hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // txtHashResult
            // 
            this.txtHashResult.Location = new System.Drawing.Point(79, 80);
            this.txtHashResult.Name = "txtHashResult";
            this.txtHashResult.ReadOnly = true;
            this.txtHashResult.Size = new System.Drawing.Size(539, 20);
            this.txtHashResult.TabIndex = 3;
            // 
            // lblHashResult
            // 
            this.lblHashResult.AutoSize = true;
            this.lblHashResult.Location = new System.Drawing.Point(36, 83);
            this.lblHashResult.Name = "lblHashResult";
            this.lblHashResult.Size = new System.Drawing.Size(37, 13);
            this.lblHashResult.TabIndex = 2;
            this.lblHashResult.Text = "Result";
            // 
            // txtHashText
            // 
            this.txtHashText.Location = new System.Drawing.Point(79, 18);
            this.txtHashText.Name = "txtHashText";
            this.txtHashText.Size = new System.Drawing.Size(539, 20);
            this.txtHashText.TabIndex = 1;
            // 
            // lblHashText
            // 
            this.lblHashText.AutoSize = true;
            this.lblHashText.Location = new System.Drawing.Point(45, 21);
            this.lblHashText.Name = "lblHashText";
            this.lblHashText.Size = new System.Drawing.Size(28, 13);
            this.lblHashText.TabIndex = 0;
            this.lblHashText.Text = "Text";
            // 
            // SecurityStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 296);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbHash);
            this.Controls.Add(this.gbEncryption);
            this.Name = "SecurityStudio";
            this.Text = "Security Studio";
            this.gbEncryption.ResumeLayout(false);
            this.gbEncryption.PerformLayout();
            this.gbHash.ResumeLayout(false);
            this.gbHash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEncryption;
        private System.Windows.Forms.TextBox txtEncryptionText;
        private System.Windows.Forms.Label lblEncryptionText;
        private System.Windows.Forms.TextBox txtEncryptionResult;
        private System.Windows.Forms.Label lblEncryptionResult;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.GroupBox gbHash;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.TextBox txtHashResult;
        private System.Windows.Forms.Label lblHashResult;
        private System.Windows.Forms.TextBox txtHashText;
        private System.Windows.Forms.Label lblHashText;
        private System.Windows.Forms.Button btnClose;
    }
}

