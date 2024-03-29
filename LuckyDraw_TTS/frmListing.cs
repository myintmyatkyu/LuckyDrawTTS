﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LuckyDraw_TTS
{
    public partial class frmListing : Form
    {
        public frmListing()
        {
            InitializeComponent();
            LoadWinningNos();
        }

        public void LoadWinningNos()
        {
            dgvApache200.Text = "Apache RTR 200 CC";
            dgvApache200.Tag = "Apache RTR 200 CC";

            dgvApache160.Text = "Apache RTR 160 CC";
            dgvApache160.Tag = "Apache RTR 160 CC";

            dgvRockz.Text = "Rockz Refresh CW 125 CC";
            dgvRockz.Tag = "Rockz Refresh CW 125 CC";

            dgvNeoCW.Text = "Neo CW 110 CC";
            dgvNeoCW.Tag = "Neo CW 110 CC";

            dgvSSGA7.Text = "Samsung Galaxy A7";
            dgvSSGA7.Tag = "Samsung Galaxy A7";

            dgvSSGJ2Prime.Text = "Samsung Galaxy J2 Prime";
            dgvSSGJ2Prime.Tag = "Samsung Galaxy J2 Prime";

            dgvSSGJ2Prime2.Text = "Samsung Galaxy J2 Prime";
            dgvSSGJ2Prime2.Tag = "Samsung Galaxy J2 PrimeGrid2";

            dgvSSGJ5Pro.Text = "Samsung Galaxy J5 Pro";
            dgvSSGJ5Pro.Tag = "Samsung Galaxy J5 Pro";

            dgvSSGXCover.Text = "Samsung Galaxy Xcover 4";
            dgvSSGXCover.Tag = "Samsung Galaxy Xcover 4";

            dgvSSGXCover2.Text = "Samsung Galaxy Xcover 4";
            dgvSSGXCover2.Tag = "Samsung Galaxy Xcover 4Grid2";

            //dgvApache200.IRefresh(1);
            //dgvApache160.IRefresh(1);
            //dgvRockz.IRefresh(7);
            //dgvNeoCW.IRefresh(6);
            //dgvSSGA7.IRefresh(5);
            //dgvSSGJ5Pro.IRefresh(20);
            //dgvSSGJ2Prime.IRefresh(20);
            //dgvSSGXCover.IRefresh(20);
            //dgvSSGXCover2.IRefresh(20);

            dgvApache200.IRefresh();
            dgvApache160.IRefresh();
            dgvRockz.IRefresh();
            dgvNeoCW.IRefresh();
            dgvSSGA7.IRefresh();
            dgvSSGJ5Pro.IRefresh();
            dgvSSGJ2Prime2.IRefresh();
            dgvSSGJ2Prime.IRefresh();
            dgvSSGXCover.IRefresh();
            dgvSSGXCover2.IRefresh();
        }

        private void frmListing_Load(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length > 0)
            {
                Screen secondScreen = Screen.AllScreens.Where(i => i.Primary != true).ToList()[0];
                Rectangle bounds = secondScreen.Bounds;
                this.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                this.StartPosition = FormStartPosition.Manual;
            }
        }
    }
}
