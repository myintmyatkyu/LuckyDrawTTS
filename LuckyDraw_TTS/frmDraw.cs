﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.IO;

namespace LuckyDraw_TTS
{
    public partial class frmDraw : Form
    {
        Image bgImage = global::LuckyDraw_TTS.Properties.Resources.Lubrex_Logo;
        Image bgImage2 = global::LuckyDraw_TTS.Properties.Resources.Tip_Top_Logo;
        
        public static frmDraw _frmDraw;
        public frmDraw()
        {
            InitializeComponent();
            SetLabelBG_Transparent();
            LoadWinningNos();
            ClearText();
            _frmDraw = this;
        }
        public void SetLabelBG_Transparent()
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            foreach(Control c in this.Controls)
            {
                if(c is Label && c.Name.Contains("lbl_Left_SrNo"))
                {
                    c.BackColor = Color.Transparent;
                    c.Text = "";
                    //c.Text = c.Name.Substring(("lbl_Left_SrNo_").Length, c.Name.Length - ("lbl_Left_SrNo_").Length);
                }
                else if (c is Label && c.Name.Contains("lbl_Right_SrNo"))
                {
                    c.BackColor = Color.Transparent;
                    c.Text = "";
                }

                else if (c is Label && (c.Name.Contains("lbl_Left_Winning") || c.Name.Contains("lbl_Right_Winning")))
                {
                    c.BackColor = Color.Transparent;
                    c.Text = "";
                    //c.Text = c.Name.Substring(("lbl_Left_Winning_").Length, c.Name.Length - ("lbl_Left_Winning_").Length);

                    //int num=rnd.Next(1, 9999999);
                    //c.Text = num.ToString().PadLeft(7, '0');
                    
                }
                else if (c is Label && (c.Name.Contains("lbl_Left_Prize") || c.Name.Contains("lbl_Right_Prize")))
                {
                    c.BackColor = Color.Transparent;
                    c.Text = "";
                    //c.Text = c.Name.Substring(("lbl_Left_Prize_").Length, c.Name.Length - ("lbl_Left_Prize_").Length);
                    //string[] prizes = new string[] {"Apache 200","Apache 160","Rockz CW Refresh","Neo CW","Samsung Galaxy A7","Gamsung Galaxy Xcover 4","Samsung Galaxy J5 Pro","Samsung Galaxy J2 Prime" };
                    //int num = rnd2.Next(0, 8);
                    //c.Text = prizes[num];
                }
            }
            lblLeftTitle.BackColor = Color.Transparent;
            lblRightTitle.BackColor = Color.Transparent;
        }

        public void LoadWinningNos()
        {
            string fileName = "AllPrizes.csv";
            if(!File.Exists(fileName))
            {
                FileStream fs = File.Create(fileName);
                fs.Close();
            }
            String[] lines = File.ReadAllLines(fileName);
            if(lines.Length!=0)
            {
                int i = 1;
                while (i <= lines.Length)
                {
                    if(i<=53)
                    {
                        if(lines[i - 1].ToString()!="")
                        {
                            string Number = lines[i - 1].Split(',')[0];
                            string Prize = lines[i - 1].Split(',')[1];
                            Label lblSrNo = (Label)this.Controls.Find("lbl_Left_SrNo_" + i.ToString(), false)[0];
                            Label lblWinningNo = (Label)this.Controls.Find("lbl_Left_Winning_" + i.ToString(), false)[0];
                            Label lblPrize = (Label)this.Controls.Find("lbl_Left_Prize_" + i.ToString(), false)[0];

                            lblSrNo.Text = i.ToString();
                            lblWinningNo.Text = Number;
                            lblPrize.Text = Prize;
                        }
                        
                    }
                    else
                    {
                        if(lines[i - 1].ToString()!="")
                        {
                            string Number = lines[i- 1].Split(',')[0];
                            string Prize = lines[i - 1].Split(',')[1];
                            Label lblSrNo = (Label)this.Controls.Find("lbl_Right_SrNo_" + (i-53).ToString(), false)[0];
                            Label lblWinningNo = (Label)this.Controls.Find("lbl_Right_Winning_" + (i - 53).ToString(), false)[0];
                            Label lblPrize = (Label)this.Controls.Find("lbl_Right_Prize_" + (i - 53).ToString(), false)[0];

                            lblSrNo.Text = i.ToString();
                            lblWinningNo.Text = Number;
                            lblPrize.Text = Prize;
                        }                     
                    }
                    i++;
                }
            }
            
        }

        public void RefreshNumber(int textBoxNumber,string value)
        {
            Control[] cs = this.Controls.Find("lblNo_" + textBoxNumber.ToString(),true);
            Control[] ps = this.Controls.Find("p" + textBoxNumber.ToString(), true);
            if (cs.Count() > 0)
            {
                Control lbl = cs[0];
                lbl.Text = value;
            }
            if (ps.Count() > 0)
            {
                Panel panel = (Panel)ps[0];
                panel.BackgroundImage = null;
                
            }

        }

        public void ShowPrize(string imageKey)
        {
            Image img= Image.FromFile("Prizes\\" + imageKey);
            pbPrize.Image = img;
        }

        public void ClearPrize()
        {
            pbPrize.Image = null;
        }

        private void frmDraw_Load(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length > 0)
            {
                Screen secondScreen = Screen.AllScreens.Where(i => i.Primary != true).ToList()[0];
                Rectangle bounds = secondScreen.Bounds;
                this.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                this.StartPosition = FormStartPosition.Manual;
            }
        }

        public void ClearText()
        {
            lblNo_1.Text = "";
            lblNo_2.Text = "";
            lblNo_3.Text = "";
            lblNo_4.Text = "";
            lblNo_5.Text = "";
            lblNo_6.Text = "";

            p1.BackgroundImage = bgImage;
            p2.BackgroundImage = bgImage2;
            p3.BackgroundImage = bgImage;
            p4.BackgroundImage = bgImage2;
            p5.BackgroundImage = bgImage;
            p6.BackgroundImage = bgImage2;

            pbPrize.Image = null;


        }
    }
}
