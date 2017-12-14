using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LuckyDraw_TTS
{
    public partial class WinnerBox : UserControl,IRefreshable
    {
        public WinnerBox()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                this.gb.Text = value;
            }
        }

        private string _CurrentNo;
        public string CurrentNo
        {
            get
            {
                return this._CurrentNo;
            }
            set
            {
                _CurrentNo = value;
                lblCurrentNo.Text = value;
            }
        }

        public string FileName
        {
            get;
            set;
        }

        public void IRefresh()
        {
            this.lb.Items.Clear();
            if (!File.Exists(FileName))
            {
                FileStream fs = File.Create(FileName);
                fs.Close();
            }
            String[] lines = File.ReadAllLines(FileName);
            this.CurrentNo = lines.Count().ToString();
            foreach(string s in lines)
            {
                this.lb.Items.Add(s);
            }
        }
    }
}
