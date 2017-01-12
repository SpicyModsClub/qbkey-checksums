namespace GH3_Checksums
{
    partial class frmChecksumUtility
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Label lblResult;
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCalculateChecksum = new System.Windows.Forms.Button();
            this.btnLookUpName = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnLookUpSwapped = new System.Windows.Forms.Button();
            lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new System.Drawing.Point(12, 69);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(40, 13);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result:";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(441, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnCalculateChecksum
            // 
            this.btnCalculateChecksum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalculateChecksum.Location = new System.Drawing.Point(47, 38);
            this.btnCalculateChecksum.Name = "btnCalculateChecksum";
            this.btnCalculateChecksum.Size = new System.Drawing.Size(120, 23);
            this.btnCalculateChecksum.TabIndex = 1;
            this.btnCalculateChecksum.Text = "Calculate Checksum";
            this.btnCalculateChecksum.UseVisualStyleBackColor = true;
            this.btnCalculateChecksum.Click += new System.EventHandler(this.btnCalculateChecksum_Click);
            // 
            // btnLookUpName
            // 
            this.btnLookUpName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLookUpName.Location = new System.Drawing.Point(173, 38);
            this.btnLookUpName.Name = "btnLookUpName";
            this.btnLookUpName.Size = new System.Drawing.Size(119, 23);
            this.btnLookUpName.TabIndex = 3;
            this.btnLookUpName.Text = "Look Up Name";
            this.btnLookUpName.UseVisualStyleBackColor = true;
            this.btnLookUpName.Click += new System.EventHandler(this.btnLookUpName_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(15, 85);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(438, 166);
            this.txtResult.TabIndex = 5;
            // 
            // btnLookUpSwapped
            // 
            this.btnLookUpSwapped.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLookUpSwapped.Location = new System.Drawing.Point(298, 38);
            this.btnLookUpSwapped.Name = "btnLookUpSwapped";
            this.btnLookUpSwapped.Size = new System.Drawing.Size(119, 23);
            this.btnLookUpSwapped.TabIndex = 6;
            this.btnLookUpSwapped.Text = "Look Up Swapped";
            this.btnLookUpSwapped.UseVisualStyleBackColor = true;
            this.btnLookUpSwapped.Click += new System.EventHandler(this.btnLookUpSwapped_Click);
            // 
            // frmChecksumUtility
            // 
            this.AcceptButton = this.btnLookUpSwapped;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 263);
            this.Controls.Add(this.btnLookUpSwapped);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(lblResult);
            this.Controls.Add(this.btnLookUpName);
            this.Controls.Add(this.btnCalculateChecksum);
            this.Controls.Add(this.txtInput);
            this.Name = "frmChecksumUtility";
            this.Text = "GH3 Checksum Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCalculateChecksum;
        private System.Windows.Forms.Button btnLookUpName;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnLookUpSwapped;
    }
}

