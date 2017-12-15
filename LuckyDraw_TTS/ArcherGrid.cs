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
    public partial class ArcherGrid : UserControl,IRefreshable
    {
        public ArcherGrid()
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
                this.lblTitle.Text = value;
            }
        }

        public void IRefresh(int rows=0)
        {
            DataTable dt=CreateMockupData(rows);
            dgv.DataSource = dt;
            dgv.Refresh();
        }

        public void IRefresh()
        {
            string FileName = "";
            if(this.Tag.ToString().Contains("Grid2"))
            {
                FileName = this.Tag.ToString().Remove(23,5) + ".csv";
            }
            else
            {
                FileName = this.Tag.ToString() + ".csv";
            }
            
            
            this.dgv.Rows.Clear();
            if (!File.Exists(FileName))
            {
                FileStream fs = File.Create(FileName);
                fs.Close();
            }
            String[] lines = File.ReadAllLines(FileName);
            if(!this.Tag.ToString().Contains("Grid2") && !this.Tag.ToString().Contains("Samsung Galaxy Xcover 4"))
            {
                int i = 1;
                foreach (string s in lines)
                {
                    this.dgv.Rows.Add(new object[] { i, s.ToString(), FileName });
                    i++;
                }
            }
            else if (!this.Tag.ToString().Contains("Grid2") && this.Tag.ToString().Contains("Samsung Galaxy Xcover 4"))
            {
                int i = 1;
                int till=lines.Length>20?20:lines.Length;
                for (i = 1; i <=till ; i++)
                {
                    this.dgv.Rows.Add(new object[] { i, lines[i-1], FileName });
                }
            }
            else
            {
                int i = 21;
                int till = lines.Length;
                for (i=21; i <= till; i++)
                {
                    this.dgv.Rows.Add(new object[] { i, lines[i-1], FileName });
                }
            }
            
        }

        public DataTable CreateMockupData(int rows)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SrNo");
            dt.Columns.Add("TicketNo");

            Random rnd = new Random();
            int i=0;
            if (this.Name == "dgvSSGXCover2")
            {
                i = 20;
                rows = rows + 20;
            }
            while(i<rows)
            {
                DataRow dr=dt.NewRow();
                dr[0]=i+1;
                int num=rnd.Next(1, 9999999);
                dr[1] = num.ToString().PadLeft(7, '0');
                dt.Rows.Add(dr);
                i++;
            }

            return dt;

        }
    }
}
