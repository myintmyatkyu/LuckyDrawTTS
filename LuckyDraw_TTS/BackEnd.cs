using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Configuration;

namespace LuckyDraw_TTS
{
    public class BackEnd
    {

        public static void Save(string winningNo, string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    FileStream fs = File.Create(fileName);
                    fs.Close();
                }

                if (File.Exists(fileName))
                {
                    StreamWriter sw = File.AppendText(fileName);
                    sw.WriteLine(winningNo);
                    sw.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SaveAll(string winningNo, string fileName, string prize)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    FileStream fs = File.Create(fileName);
                    fs.Close();
                }

                if (File.Exists(fileName))
                {
                    StreamWriter sw = File.AppendText(fileName);
                    sw.WriteLine(winningNo+","+prize);
                    sw.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
