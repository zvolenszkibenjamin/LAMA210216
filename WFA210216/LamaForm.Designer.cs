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
            this.SuspendLayout();
            // 
            // lamaSelector
            // 
            this.lamaSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.lamaSelector.FormattingEnabled = true;
            this.lamaSelector.Location = new System.Drawing.Point(12, 12);
            this.lamaSelector.Name = "lamaSelector";
            this.lamaSelector.Size = new System.Drawing.Size(140, 28);
            this.lamaSelector.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 209);
            this.Controls.Add(this.lamaSelector);
            this.Name = "LamaForm";
            this.Text = "Lámák";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox lamaSelector;

        #endregion
    }
}