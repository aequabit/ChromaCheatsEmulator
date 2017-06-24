namespace ChromaCheatsEmulator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtPayload = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.chkDecrypt = new System.Windows.Forms.CheckBox();
            this.grpEncryption = new System.Windows.Forms.GroupBox();
            this.grpNetworking = new System.Windows.Forms.GroupBox();
            this.ttpUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkAutosend = new System.Windows.Forms.CheckBox();
            this.grpEncryption.SuspendLayout();
            this.grpNetworking.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPayload
            // 
            this.txtPayload.Location = new System.Drawing.Point(14, 22);
            this.txtPayload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.Size = new System.Drawing.Size(776, 25);
            this.txtPayload.TabIndex = 0;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(870, 22);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(66, 26);
            this.btnRequest.TabIndex = 1;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(16, 55);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.Size = new System.Drawing.Size(920, 196);
            this.txtResponse.TabIndex = 2;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(870, 24);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(66, 26);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(796, 24);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(68, 26);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(14, 25);
            this.txtIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(688, 25);
            this.txtIn.TabIndex = 5;
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(16, 58);
            this.txtOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(920, 163);
            this.txtOut.TabIndex = 4;
            // 
            // chkDecrypt
            // 
            this.chkDecrypt.AutoSize = true;
            this.chkDecrypt.Location = new System.Drawing.Point(796, 25);
            this.chkDecrypt.Name = "chkDecrypt";
            this.chkDecrypt.Size = new System.Drawing.Size(72, 21);
            this.chkDecrypt.TabIndex = 13;
            this.chkDecrypt.Text = "Decrypt";
            this.chkDecrypt.UseVisualStyleBackColor = true;
            this.chkDecrypt.CheckedChanged += new System.EventHandler(this.chkDecrypt_CheckedChanged);
            // 
            // grpEncryption
            // 
            this.grpEncryption.Controls.Add(this.chkAutosend);
            this.grpEncryption.Controls.Add(this.txtIn);
            this.grpEncryption.Controls.Add(this.btnEncrypt);
            this.grpEncryption.Controls.Add(this.btnDecrypt);
            this.grpEncryption.Controls.Add(this.txtOut);
            this.grpEncryption.Location = new System.Drawing.Point(12, 31);
            this.grpEncryption.Name = "grpEncryption";
            this.grpEncryption.Size = new System.Drawing.Size(954, 236);
            this.grpEncryption.TabIndex = 15;
            this.grpEncryption.TabStop = false;
            this.grpEncryption.Text = "Encryption";
            // 
            // grpNetworking
            // 
            this.grpNetworking.Controls.Add(this.txtPayload);
            this.grpNetworking.Controls.Add(this.btnRequest);
            this.grpNetworking.Controls.Add(this.chkDecrypt);
            this.grpNetworking.Controls.Add(this.txtResponse);
            this.grpNetworking.Location = new System.Drawing.Point(12, 273);
            this.grpNetworking.Name = "grpNetworking";
            this.grpNetworking.Size = new System.Drawing.Size(954, 270);
            this.grpNetworking.TabIndex = 16;
            this.grpNetworking.TabStop = false;
            this.grpNetworking.Text = "Networking";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // chkAutosend
            // 
            this.chkAutosend.AutoSize = true;
            this.chkAutosend.Location = new System.Drawing.Point(708, 27);
            this.chkAutosend.Name = "chkAutosend";
            this.chkAutosend.Size = new System.Drawing.Size(82, 21);
            this.chkAutosend.TabIndex = 8;
            this.chkAutosend.Text = "Autosend";
            this.ttpUpdate.SetToolTip(this.chkAutosend, "Should requests automatically be sent after encrypting them? Also if this is chec" +
        "ked, %TIME% gets replaced by the current UNIX timestamp.");
            this.chkAutosend.UseVisualStyleBackColor = true;
            this.chkAutosend.CheckedChanged += new System.EventHandler(this.chkAutosend_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 553);
            this.Controls.Add(this.grpNetworking);
            this.Controls.Add(this.grpEncryption);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "ChromaCheats Emulator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpEncryption.ResumeLayout(false);
            this.grpEncryption.PerformLayout();
            this.grpNetworking.ResumeLayout(false);
            this.grpNetworking.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPayload;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.CheckBox chkDecrypt;
        private System.Windows.Forms.GroupBox grpEncryption;
        private System.Windows.Forms.GroupBox grpNetworking;
        private System.Windows.Forms.ToolTip ttpUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkAutosend;
    }
}

