using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 随机字符生成工具
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if (!File.Exists(Application.StartupPath + @"\IrisSkin4.dll"))
            //{
            //    byte[] Save = Properties.Resources.IrisSkin4;
            //    FileStream fsObj = new FileStream(Application.StartupPath + @"\IrisSkin4.dll", FileMode.CreateNew);
            //    fsObj.Write(Save, 0, Save.Length);
            //    fsObj.Close();
            //}
            //if (!File.Exists(Application.StartupPath + @"\Silver.ssk"))
            //{
            //    byte[] Save = Properties.Resources.Silver;
            //    FileStream fsObj = new FileStream(Application.StartupPath + @"\Silver.ssk", FileMode.CreateNew);
            //    fsObj.Write(Save, 0, Save.Length);
            //    fsObj.Close();
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
