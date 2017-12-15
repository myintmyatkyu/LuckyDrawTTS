namespace LuckyDraw_TTS
{
    partial class frmControlPanel
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Apache 200 EFI", "MC-Apache200EFI - 1094 x 379.png");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Apache 160", "MC-Apache160 - 1094 x 379.png");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Rockz CW Refresh", "MC-RockzCWRefresh - 1094 x 379.png");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Neo CW", "MC-NeoCW - 1094 x 379.png");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Samsung Galaxy A7", "SS-A72017 - 1094 x 379.png");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Samasung Galaxy Xcover 4", "SS-Xcover4 - 1094 x 379.png");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Samsung Galaxy J5 Pro", "SS-J5Pro - 1094 x 379.png");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Samsung Galaxy J2 Prime", "SS-J2Prime - 1094 x 379.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdShowList = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.iml = new System.Windows.Forms.ImageList(this.components);
            this.cmdClose_Car = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.txtCar_6 = new System.Windows.Forms.TextBox();
            this.txtCar_5 = new System.Windows.Forms.TextBox();
            this.txtCar_4 = new System.Windows.Forms.TextBox();
            this.txtCar_3 = new System.Windows.Forms.TextBox();
            this.txtCar_2 = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtCar_1 = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.wbSSGJ2Prime = new LuckyDraw_TTS.WinnerBox();
            this.wbSSGJ5Pro = new LuckyDraw_TTS.WinnerBox();
            this.wbSSGXCover4 = new LuckyDraw_TTS.WinnerBox();
            this.wbSSGA7 = new LuckyDraw_TTS.WinnerBox();
            this.wbNeo = new LuckyDraw_TTS.WinnerBox();
            this.wbRockz = new LuckyDraw_TTS.WinnerBox();
            this.wbApache160 = new LuckyDraw_TTS.WinnerBox();
            this.wbApache200 = new LuckyDraw_TTS.WinnerBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdClose);
            this.groupBox1.Controls.Add(this.cmdShowList);
            this.groupBox1.Controls.Add(this.lv);
            this.groupBox1.Controls.Add(this.cmdClose_Car);
            this.groupBox1.Controls.Add(this.cmdClear);
            this.groupBox1.Controls.Add(this.txtCar_6);
            this.groupBox1.Controls.Add(this.txtCar_5);
            this.groupBox1.Controls.Add(this.txtCar_4);
            this.groupBox1.Controls.Add(this.txtCar_3);
            this.groupBox1.Controls.Add(this.txtCar_2);
            this.groupBox1.Controls.Add(this.cmdStart);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.txtCar_1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 511);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmdShowList
            // 
            this.cmdShowList.BackColor = System.Drawing.Color.LightGreen;
            this.cmdShowList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdShowList.Location = new System.Drawing.Point(116, 462);
            this.cmdShowList.Name = "cmdShowList";
            this.cmdShowList.Size = new System.Drawing.Size(68, 34);
            this.cmdShowList.TabIndex = 12;
            this.cmdShowList.Text = "Show List";
            this.cmdShowList.UseVisualStyleBackColor = false;
            this.cmdShowList.Click += new System.EventHandler(this.cmdShowList_Click);
            // 
            // lv
            // 
            this.lv.Activation = System.Windows.Forms.ItemActivation.OneClick;
            listViewItem1.Tag = "Apache 200 EFI";
            listViewItem2.Tag = "Apache 160";
            listViewItem3.Tag = "Rockz CW Refresh";
            listViewItem4.Tag = "Neo CW";
            listViewItem5.Tag = "Samsung Galaxy A7";
            listViewItem6.Tag = "Samsung Galaxy Xcover 4";
            listViewItem7.Tag = "Samsung Galaxy J5 Pro";
            listViewItem8.Tag = "Samsung Galaxy J2 Prime";
            this.lv.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lv.LargeImageList = this.iml;
            this.lv.Location = new System.Drawing.Point(16, 93);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(330, 363);
            this.lv.TabIndex = 9;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            // 
            // iml
            // 
            this.iml.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml.ImageStream")));
            this.iml.TransparentColor = System.Drawing.Color.Transparent;
            this.iml.Images.SetKeyName(0, "MC-Apache160 - 1094 x 379.png");
            this.iml.Images.SetKeyName(1, "MC-Apache200EFI - 1094 x 379.png");
            this.iml.Images.SetKeyName(2, "MC-NeoCW - 1094 x 379.png");
            this.iml.Images.SetKeyName(3, "MC-RockzCWRefresh - 1094 x 379.png");
            this.iml.Images.SetKeyName(4, "SS-A72017 - 1094 x 379.png");
            this.iml.Images.SetKeyName(5, "SS-J2Prime - 1094 x 379.png");
            this.iml.Images.SetKeyName(6, "SS-J5Pro - 1094 x 379.png");
            this.iml.Images.SetKeyName(7, "SS-Xcover4 - 1094 x 379.png");
            // 
            // cmdClose_Car
            // 
            this.cmdClose_Car.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdClose_Car.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdClose_Car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose_Car.Location = new System.Drawing.Point(267, 24);
            this.cmdClose_Car.Name = "cmdClose_Car";
            this.cmdClose_Car.Size = new System.Drawing.Size(79, 34);
            this.cmdClose_Car.TabIndex = 1;
            this.cmdClose_Car.Text = "Close";
            this.cmdClose_Car.UseVisualStyleBackColor = false;
            this.cmdClose_Car.Click += new System.EventHandler(this.cmdClose_Car_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.LightGreen;
            this.cmdClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClear.Location = new System.Drawing.Point(267, 462);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(79, 34);
            this.cmdClear.TabIndex = 11;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // txtCar_6
            // 
            this.txtCar_6.Location = new System.Drawing.Point(306, 65);
            this.txtCar_6.MaxLength = 1;
            this.txtCar_6.Name = "txtCar_6";
            this.txtCar_6.Size = new System.Drawing.Size(36, 22);
            this.txtCar_6.TabIndex = 7;
            this.txtCar_6.Tag = "6";
            this.txtCar_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_6.TextChanged += new System.EventHandler(this.txtCar_1_TextChanged);
            this.txtCar_6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_1_KeyDown);
            // 
            // txtCar_5
            // 
            this.txtCar_5.Location = new System.Drawing.Point(248, 65);
            this.txtCar_5.MaxLength = 1;
            this.txtCar_5.Name = "txtCar_5";
            this.txtCar_5.Size = new System.Drawing.Size(36, 22);
            this.txtCar_5.TabIndex = 6;
            this.txtCar_5.Tag = "5";
            this.txtCar_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_5.TextChanged += new System.EventHandler(this.txtCar_1_TextChanged);
            this.txtCar_5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_1_KeyDown);
            // 
            // txtCar_4
            // 
            this.txtCar_4.Location = new System.Drawing.Point(190, 65);
            this.txtCar_4.MaxLength = 1;
            this.txtCar_4.Name = "txtCar_4";
            this.txtCar_4.Size = new System.Drawing.Size(36, 22);
            this.txtCar_4.TabIndex = 5;
            this.txtCar_4.Tag = "4";
            this.txtCar_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_4.TextChanged += new System.EventHandler(this.txtCar_1_TextChanged);
            this.txtCar_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_1_KeyDown);
            // 
            // txtCar_3
            // 
            this.txtCar_3.Location = new System.Drawing.Point(132, 65);
            this.txtCar_3.MaxLength = 1;
            this.txtCar_3.Name = "txtCar_3";
            this.txtCar_3.Size = new System.Drawing.Size(36, 22);
            this.txtCar_3.TabIndex = 4;
            this.txtCar_3.Tag = "3";
            this.txtCar_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_3.TextChanged += new System.EventHandler(this.txtCar_1_TextChanged);
            this.txtCar_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_1_KeyDown);
            // 
            // txtCar_2
            // 
            this.txtCar_2.Location = new System.Drawing.Point(74, 65);
            this.txtCar_2.MaxLength = 1;
            this.txtCar_2.Name = "txtCar_2";
            this.txtCar_2.Size = new System.Drawing.Size(36, 22);
            this.txtCar_2.TabIndex = 3;
            this.txtCar_2.Tag = "2";
            this.txtCar_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_2.TextChanged += new System.EventHandler(this.txtCar_1_TextChanged);
            this.txtCar_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_1_KeyDown);
            // 
            // cmdStart
            // 
            this.cmdStart.BackColor = System.Drawing.Color.LightGreen;
            this.cmdStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStart.Location = new System.Drawing.Point(16, 24);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(94, 34);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "Start/Refresh";
            this.cmdStart.UseVisualStyleBackColor = false;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.LightGreen;
            this.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Location = new System.Drawing.Point(16, 462);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(94, 34);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtCar_1
            // 
            this.txtCar_1.Location = new System.Drawing.Point(16, 65);
            this.txtCar_1.MaxLength = 1;
            this.txtCar_1.Name = "txtCar_1";
            this.txtCar_1.Size = new System.Drawing.Size(36, 22);
            this.txtCar_1.TabIndex = 2;
            this.txtCar_1.Tag = "1";
            this.txtCar_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_1.TextChanged += new System.EventHandler(this.txtCar_1_TextChanged);
            this.txtCar_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_1_KeyDown);
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Location = new System.Drawing.Point(190, 462);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(68, 34);
            this.cmdClose.TabIndex = 13;
            this.cmdClose.Text = "Close List";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // wbSSGJ2Prime
            // 
            this.wbSSGJ2Prime.CurrentNo = null;
            this.wbSSGJ2Prime.FileName = null;
            this.wbSSGJ2Prime.Location = new System.Drawing.Point(714, 358);
            this.wbSSGJ2Prime.Name = "wbSSGJ2Prime";
            this.wbSSGJ2Prime.Size = new System.Drawing.Size(287, 359);
            this.wbSSGJ2Prime.TabIndex = 10;
            // 
            // wbSSGJ5Pro
            // 
            this.wbSSGJ5Pro.CurrentNo = null;
            this.wbSSGJ5Pro.FileName = null;
            this.wbSSGJ5Pro.Location = new System.Drawing.Point(714, 22);
            this.wbSSGJ5Pro.Name = "wbSSGJ5Pro";
            this.wbSSGJ5Pro.Size = new System.Drawing.Size(287, 330);
            this.wbSSGJ5Pro.TabIndex = 9;
            // 
            // wbSSGXCover4
            // 
            this.wbSSGXCover4.CurrentNo = null;
            this.wbSSGXCover4.FileName = null;
            this.wbSSGXCover4.Location = new System.Drawing.Point(1007, 22);
            this.wbSSGXCover4.Name = "wbSSGXCover4";
            this.wbSSGXCover4.Size = new System.Drawing.Size(325, 695);
            this.wbSSGXCover4.TabIndex = 8;
            // 
            // wbSSGA7
            // 
            this.wbSSGA7.CurrentNo = null;
            this.wbSSGA7.FileName = null;
            this.wbSSGA7.Location = new System.Drawing.Point(383, 525);
            this.wbSSGA7.Name = "wbSSGA7";
            this.wbSSGA7.Size = new System.Drawing.Size(325, 192);
            this.wbSSGA7.TabIndex = 7;
            // 
            // wbNeo
            // 
            this.wbNeo.CurrentNo = null;
            this.wbNeo.FileName = null;
            this.wbNeo.Location = new System.Drawing.Point(383, 22);
            this.wbNeo.Name = "wbNeo";
            this.wbNeo.Size = new System.Drawing.Size(325, 181);
            this.wbNeo.TabIndex = 6;
            // 
            // wbRockz
            // 
            this.wbRockz.CurrentNo = null;
            this.wbRockz.FileName = null;
            this.wbRockz.Location = new System.Drawing.Point(383, 209);
            this.wbRockz.Name = "wbRockz";
            this.wbRockz.Size = new System.Drawing.Size(325, 310);
            this.wbRockz.TabIndex = 5;
            // 
            // wbApache160
            // 
            this.wbApache160.CurrentNo = null;
            this.wbApache160.FileName = null;
            this.wbApache160.Location = new System.Drawing.Point(12, 621);
            this.wbApache160.Name = "wbApache160";
            this.wbApache160.Size = new System.Drawing.Size(365, 87);
            this.wbApache160.TabIndex = 4;
            // 
            // wbApache200
            // 
            this.wbApache200.CurrentNo = null;
            this.wbApache200.FileName = null;
            this.wbApache200.Location = new System.Drawing.Point(12, 529);
            this.wbApache200.Name = "wbApache200";
            this.wbApache200.Size = new System.Drawing.Size(365, 86);
            this.wbApache200.TabIndex = 3;
            // 
            // frmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.wbSSGJ2Prime);
            this.Controls.Add(this.wbSSGJ5Pro);
            this.Controls.Add(this.wbSSGXCover4);
            this.Controls.Add(this.wbSSGA7);
            this.Controls.Add(this.wbNeo);
            this.Controls.Add(this.wbRockz);
            this.Controls.Add(this.wbApache160);
            this.Controls.Add(this.wbApache200);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmControlPanel";
            this.Text = "Control Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdClose_Car;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.TextBox txtCar_6;
        private System.Windows.Forms.TextBox txtCar_5;
        private System.Windows.Forms.TextBox txtCar_4;
        private System.Windows.Forms.TextBox txtCar_3;
        private System.Windows.Forms.TextBox txtCar_2;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtCar_1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ImageList iml;
        private WinnerBox wbApache200;
        private WinnerBox wbApache160;
        private WinnerBox wbRockz;
        private WinnerBox wbNeo;
        private WinnerBox wbSSGA7;
        private WinnerBox wbSSGXCover4;
        private WinnerBox wbSSGJ5Pro;
        private WinnerBox wbSSGJ2Prime;
        private System.Windows.Forms.Button cmdShowList;
        private System.Windows.Forms.Button cmdClose;

    }
}