namespace LuckyDraw_TTS
{
    partial class WinnerBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb = new System.Windows.Forms.GroupBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblCurrentNo = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.lblCurrentNo);
            this.gb.Controls.Add(this.lblCurrent);
            this.gb.Controls.Add(this.lb);
            this.gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(410, 376);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            // 
            // lb
            // 
            this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(6, 32);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(398, 329);
            this.lb.TabIndex = 0;
            // 
            // lblCurrent
            // 
            this.lblCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(338, 16);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(50, 13);
            this.lblCurrent.TabIndex = 1;
            this.lblCurrent.Text = "Current :";
            // 
            // lblCurrentNo
            // 
            this.lblCurrentNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentNo.AutoSize = true;
            this.lblCurrentNo.Location = new System.Drawing.Point(391, 16);
            this.lblCurrentNo.Name = "lblCurrentNo";
            this.lblCurrentNo.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentNo.TabIndex = 2;
            this.lblCurrentNo.Text = "0";
            // 
            // WinnerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb);
            this.Name = "WinnerBox";
            this.Size = new System.Drawing.Size(410, 376);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Label lblCurrentNo;
    }
}
