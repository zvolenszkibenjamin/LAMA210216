namespace WFA210216
{
    partial class LamaForm
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
            this.lamaSelector = new System.Windows.Forms.ComboBox();
            this.szulEvLabel = new System.Windows.Forms.Label();
            this.ujLamaNev = new System.Windows.Forms.TextBox();
            this.ujLamaSzulEv = new System.Windows.Forms.TextBox();
            this.ujLamaIz = new System.Windows.Forms.TextBox();
            this.ujLamaBtn = new System.Windows.Forms.Button();
            this.ujLamaNevLabel = new System.Windows.Forms.Label();
            this.ujLamaSzulEvLabel = new System.Windows.Forms.Label();
            this.ujLamaIzLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lamaSelector
            // 
            this.lamaSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.lamaSelector.FormattingEnabled = true;
            this.lamaSelector.Location = new System.Drawing.Point(12, 12);
            this.lamaSelector.Name = "lamaSelector";
            this.lamaSelector.Size = new System.Drawing.Size(158, 28);
            this.lamaSelector.TabIndex = 0;
            this.lamaSelector.SelectedIndexChanged += new System.EventHandler(this.lamaSelector_SelectedIndexChanged);
            // 
            // szulEvLabel
            // 
            this.szulEvLabel.AutoSize = true;
            this.szulEvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.szulEvLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.szulEvLabel.Location = new System.Drawing.Point(218, 15);
            this.szulEvLabel.Name = "szulEvLabel";
            this.szulEvLabel.Size = new System.Drawing.Size(87, 20);
            this.szulEvLabel.TabIndex = 5;
            this.szulEvLabel.Text = "# szül. év #";
            this.szulEvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ujLamaNev
            // 
            this.ujLamaNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.ujLamaNev.Location = new System.Drawing.Point(14, 85);
            this.ujLamaNev.Name = "ujLamaNev";
            this.ujLamaNev.Size = new System.Drawing.Size(113, 26);
            this.ujLamaNev.TabIndex = 1;
            this.ujLamaNev.TextChanged += new System.EventHandler(this.ujLamaBtn_canEnable);
            // 
            // ujLamaSzulEv
            // 
            this.ujLamaSzulEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.ujLamaSzulEv.Location = new System.Drawing.Point(133, 85);
            this.ujLamaSzulEv.MaxLength = 4;
            this.ujLamaSzulEv.Name = "ujLamaSzulEv";
            this.ujLamaSzulEv.Size = new System.Drawing.Size(105, 26);
            this.ujLamaSzulEv.TabIndex = 2;
            this.ujLamaSzulEv.TextChanged += new System.EventHandler(this.ujLamaBtn_canEnable);
            // 
            // ujLamaIz
            // 
            this.ujLamaIz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.ujLamaIz.Location = new System.Drawing.Point(244, 85);
            this.ujLamaIz.Name = "ujLamaIz";
            this.ujLamaIz.Size = new System.Drawing.Size(105, 26);
            this.ujLamaIz.TabIndex = 3;
            this.ujLamaIz.TextChanged += new System.EventHandler(this.ujLamaBtn_canEnable);
            // 
            // ujLamaBtn
            // 
            this.ujLamaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.ujLamaBtn.Location = new System.Drawing.Point(12, 117);
            this.ujLamaBtn.Name = "ujLamaBtn";
            this.ujLamaBtn.Size = new System.Drawing.Size(335, 30);
            this.ujLamaBtn.TabIndex = 4;
            this.ujLamaBtn.Text = "Új láma";
            this.ujLamaBtn.UseVisualStyleBackColor = true;
            this.ujLamaBtn.Click += new System.EventHandler(this.ujLamaBtn_Click);
            // 
            // ujLamaNevLabel
            // 
            this.ujLamaNevLabel.AutoSize = true;
            this.ujLamaNevLabel.Location = new System.Drawing.Point(14, 69);
            this.ujLamaNevLabel.Name = "ujLamaNevLabel";
            this.ujLamaNevLabel.Size = new System.Drawing.Size(25, 13);
            this.ujLamaNevLabel.TabIndex = 6;
            this.ujLamaNevLabel.Text = "név";
            // 
            // ujLamaSzulEvLabel
            // 
            this.ujLamaSzulEvLabel.AutoSize = true;
            this.ujLamaSzulEvLabel.Location = new System.Drawing.Point(133, 69);
            this.ujLamaSzulEvLabel.Name = "ujLamaSzulEvLabel";
            this.ujLamaSzulEvLabel.Size = new System.Drawing.Size(43, 13);
            this.ujLamaSzulEvLabel.TabIndex = 7;
            this.ujLamaSzulEvLabel.Text = "szül. év";
            // 
            // ujLamaIzLabel
            // 
            this.ujLamaIzLabel.AutoSize = true;
            this.ujLamaIzLabel.Location = new System.Drawing.Point(244, 69);
            this.ujLamaIzLabel.Name = "ujLamaIzLabel";
            this.ujLamaIzLabel.Size = new System.Drawing.Size(61, 13);
            this.ujLamaIzLabel.TabIndex = 8;
            this.ujLamaIzLabel.Text = "kedvenc íz";
            // 
            // LamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 159);
            this.Controls.Add(this.ujLamaIzLabel);
            this.Controls.Add(this.ujLamaSzulEvLabel);
            this.Controls.Add(this.ujLamaNevLabel);
            this.Controls.Add(this.ujLamaBtn);
            this.Controls.Add(this.ujLamaIz);
            this.Controls.Add(this.ujLamaSzulEv);
            this.Controls.Add(this.ujLamaNev);
            this.Controls.Add(this.szulEvLabel);
            this.Controls.Add(this.lamaSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LamaForm";
            this.Text = "Lámák";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox lamaSelector;

        private System.Windows.Forms.Label szulEvLabel;

        private System.Windows.Forms.Label ujLamaNevLabel;
        private System.Windows.Forms.Label ujLamaSzulEvLabel;
        private System.Windows.Forms.Label ujLamaIzLabel;

        private System.Windows.Forms.TextBox ujLamaNev;
        private System.Windows.Forms.TextBox ujLamaSzulEv;
        private System.Windows.Forms.TextBox ujLamaIz;

        private System.Windows.Forms.Button ujLamaBtn;
        
        #endregion
    }
}