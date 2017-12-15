using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LuckyDraw_TTS
{
    public partial class frmControlPanel : Form
    {
        frmDraw frmDraw;
        frmListing frmListing;
        public frmControlPanel()
        {
            InitializeComponent();
            wbApache200.Text = "Apache 200";
            wbApache200.Tag = "Apache 200 EFI";

            wbApache160.Text = "Apache 160";
            wbApache160.Tag = "Apache 160";

            wbRockz.Text = "Rockz CW Refresh";
            wbRockz.Tag = "Rockz CW Refresh";

            wbNeo.Text = "Neo CW";
            wbNeo.Tag = "Neo CW";

            wbSSGA7.Text = "Samsung Galaxy A7";
            wbSSGA7.Tag = "Samsung Galaxy A7";

            wbSSGJ2Prime.Text = "Samsung Galaxy J2 Prime";
            wbSSGJ2Prime.Tag = "Samsung Galaxy J2 Prime";

            wbSSGJ5Pro.Text = "Samsung Galaxy J5 Pro";
            wbSSGJ5Pro.Tag = "Samsung Galaxy J5 Pro";

            wbSSGXCover4.Text = "Samsung Galaxy Xcover 4";
            wbSSGXCover4.Tag = "Samsung Galaxy Xcover 4";

            LoadWinningNos();
            
        }

        private void txtCar_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if(lv.SelectedItems.Count==0)
            {
                MessageBox.Show("Please Choose the Prize");
                return;
            }
            string fileName= lv.SelectedItems[0].Tag.ToString();
            fileName = fileName + ".csv";

            string currentNo = txtCar_1.Text.Trim() + txtCar_2.Text.Trim() + txtCar_3.Text.Trim() + txtCar_4.Text.Trim()+ txtCar_5.Text.Trim() + txtCar_6.Text.Trim() ;
            BackEnd.SaveAll(currentNo, "AllPrizes.csv", lv.SelectedItems[0].Tag.ToString());//Save for all prizes
            BackEnd.Save(currentNo, fileName);


            foreach (Control c in this.Controls)
            {
                if (c is IRefreshable && c is WinnerBox)
                {
                    WinnerBox wb = (WinnerBox)c;
                    wb.FileName = wb.Tag.ToString()+".csv";
                    IRefreshable iRefresh = (IRefreshable)wb;
                    iRefresh.IRefresh();
                }
            }
            this.frmDraw.LoadWinningNos();
            MessageBox.Show("Saving Successfull");
            Clear();
        }


        private void cmdStart_Click(object sender, EventArgs e)
        {
            if(this.frmDraw==null)
            {
                this.frmDraw = new frmDraw();
            }
            if(this.frmDraw.IsDisposed)
            {
                this.frmDraw = new frmDraw();
            }
            
            frmDraw.Show();
        }

        private void txtCar_1_TextChanged(object sender, EventArgs e)
        {
            if(frmDraw!=null)
            {
                TextBox txt=(TextBox)sender;
                frmDraw.RefreshNumber(Convert.ToInt32(txt.Tag), txt.Text);
            }
        }

        private void cmdShowList_Click(object sender, EventArgs e)
        {
            if(frmListing==null)
            {
                frmListing = new frmListing();
                frmListing.Show();
            }
        }

        private void cmdClose_Car_Click(object sender, EventArgs e)
        {
            if (frmDraw != null)
            {
                frmDraw.Close();
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtCar_1.Clear();
            txtCar_2.Clear();
            txtCar_3.Clear();
            txtCar_4.Clear();
            txtCar_5.Clear();
            txtCar_6.Clear();
            foreach(ListViewItem item in this.lv.SelectedItems)
            {
                item.Selected = false;
                item.Focused = false;
            }
            frmDraw.ClearText();
            frmDraw.ClearPrize();
            txtCar_1.Focus();
            
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv.SelectedItems.Count>0)
            {
                frmDraw.ShowPrize(lv.SelectedItems[0].ImageKey);
            }

        }

        private void LoadWinningNos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is IRefreshable && c is WinnerBox)
                {
                    WinnerBox wb = (WinnerBox)c;
                    wb.FileName = wb.Tag.ToString() + ".csv";
                    IRefreshable iRefresh = (IRefreshable)wb;
                    iRefresh.IRefresh();
                }
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            if(frmListing!=null)
            {
                frmListing.Close();
                frmListing = null;
            }
        }
    }
}
