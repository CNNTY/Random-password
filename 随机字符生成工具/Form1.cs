//using Sunisoft.IrisSkin;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 随机字符生成工具
{
    public partial class Form1 : Form
    {

        //private SkinEngine s;
        public Form1()
        {
            InitializeComponent();

            //s = new SkinEngine();          

            //s.SkinFile=("Silver.ssk");
            ToolTip tp = new ToolTip();
            tp.AutoPopDelay = 30000;
            tp.IsBalloon = true;
            tp.SetToolTip(cboxcustom, "选择要从第几个字符开始插入自定义字符串。\n默认为第三位开始插入（N=N-1）");
            tp.SetToolTip(txtcustom, "这里输入自定义想要生成的字符串,纯数字不支持自定义字符串");
            tp.SetToolTip(comboBox1, "这里选择字符组合类型");
            tp.SetToolTip(txtstrlrngth, "这里输入想要生成字符串的长度。\n 这里只能输入数字且数值不能大于128");
            tp.SetToolTip(BtnCreate, "单击生成随机密码字符串");
            tp.SetToolTip(BtnCopy, "点击复制已生成的字符串");
            tp.SetToolTip(cboxcustom, "自定义字符串插入的位置,默认为从第三位开始插入");

            this.comboBox1.Items.AddRange(new object[] {
            "==请选择字符组合方式==",
            "纯数字",
            "小写字母",
            "大写字母",
            "数字+字母 (小写)",
            "数字+字母（大写）",
            "数字+字母（小写）+特殊符号",
            "数字+字母（大写）+特殊符号",
            "数字+字母（小写）+字母（大写）+特殊符号"});
            this.comboBox1.SelectedIndex = 0;
            this.cboxcustom.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            this.cboxcustom.SelectedIndex = 2;

        }
        private void fswrite(string strpass)
        {
            FileStream fs = new FileStream("history.db", FileMode.Append);
            File.SetAttributes("history.db", FileAttributes.Hidden);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(DateTime.Now + "   " + strpass);
            sw.Close();
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            TxtStr.Text = null;
            string a = null;
            if (txtstrlrngth.Text.Length > 0)
            {
                int.Parse(txtstrlrngth.Text.Trim());
                if (comboBox1.SelectedIndex == 1) //纯数字
                {
                    TxtStr.Text = GetRandomString(Convert.ToInt32(txtstrlrngth.Text), true, false, false, false, "", 0);
                    TxtStr.Focus();
                }
                else if (comboBox1.SelectedIndex == 2) //字母(小写)
                {
                    a = GetRandomString(Convert.ToInt32(txtstrlrngth.Text), false, true, false, false, txtcustom.Text.Trim(), cboxcustom.SelectedIndex);
                    TxtStr.Text = a.Substring(0, int.Parse(txtstrlrngth.Text));
                    TxtStr.Focus();
                }
                else if (comboBox1.SelectedIndex == 3) //字母(大写)
                {
                    a = GetRandomString(Convert.ToInt32(txtstrlrngth.Text), false, false, true, false, txtcustom.Text.Trim(), cboxcustom.SelectedIndex);
                    TxtStr.Text = a.Substring(0, int.Parse(txtstrlrngth.Text));
                    TxtStr.Focus();
                }
                else if (comboBox1.SelectedIndex == 4) //数字+字母(小写)
                {
                    a = GetRandomString(Convert.ToInt32(txtstrlrngth.Text), true, true, false, false, txtcustom.Text.Trim(), cboxcustom.SelectedIndex);
                    TxtStr.Text = a.Substring(0, int.Parse(txtstrlrngth.Text));
                    TxtStr.Focus();
                }
                else if (comboBox1.SelectedIndex == 5) //数字+字母（大写）
                {
                    a = GetRandomString(Convert.ToInt32(txtstrlrngth.Text), true, false, true, false, txtcustom.Text.Trim(), cboxcustom.SelectedIndex);
                    TxtStr.Text = a.Substring(0, int.Parse(txtstrlrngth.Text));
                    TxtStr.Focus();
                }

                else if (comboBox1.SelectedIndex == 6) //数字+字母（小写）+特殊符号
                {
                    a = GetRandomString(Convert.ToInt32(txtstrlrngth.Text), true, true, false, true, txtcustom.Text.Trim(), cboxcustom.SelectedIndex);
                    TxtStr.Text = a.Substring(0, int.Parse(txtstrlrngth.Text));
                    TxtStr.Focus();
                }

                else if (comboBox1.SelectedIndex == 7) //数字+大写字母+特殊符号
                {
                    a = GetRandomString(Convert.ToInt32(txtstrlrngth.Text), true, false, true, true, txtcustom.Text.Trim(), cboxcustom.SelectedIndex);
                    TxtStr.Text = a.Substring(0, int.Parse(txtstrlrngth.Text));
                    TxtStr.Focus();
                }
                else if (comboBox1.SelectedIndex == 8) //数字+字母（小写）+字母（大写）+特殊符号
                {

                    a = GetRandomString(Convert.ToInt32(txtstrlrngth.Text), true, true, true, true, txtcustom.Text.Trim(), cboxcustom.SelectedIndex);
                    TxtStr.Text = a.Substring(0, int.Parse(txtstrlrngth.Text));
                    TxtStr.Focus();
                }
                else
                {
                    MessageBox.Show("请选择组合方式", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBox1.Focus();
                }
                fswrite(TxtStr.Text);
            }
            else
            {
                MessageBox.Show("好像还没有确定要生成字符的长度,或自定义参数位数错误", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtstrlrngth.Focus();
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (TxtStr.Text.Length > 1)
            {
                Clipboard.SetText(TxtStr.Text);
                MessageBox.Show("复制成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("请生成字符串后再执行复制操作", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #region 控制字符串长度文本框只能输入数字
        /// <summary>
        /// 控制字符串长度文本框只能输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void strLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允许输入:数字、退格键(8)、全选(1)、复制(3)、粘贴(22)
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 &&
            e.KeyChar != 1 && e.KeyChar != 3 && e.KeyChar != 22)
            {
                e.Handled = true;
            }
        }
        #endregion
        ///<summary>
        ///生成随机字符串 
        ///</summary>
        ///<param name="length">目标字符串的长度</param>
        ///<param name="useNum">是否包含数字，1=包含，默认为包含</param>
        ///<param name="useLow">是否包含小写字母，1=包含，默认为包含</param>
        ///<param name="useUpp">是否包含大写字母，1=包含，默认为包含</param>
        ///<param name="useSpe">是否包含特殊字符，1=包含，默认为不包含</param>
        ///<param name="custom">要包含的自定义字符，直接输入要包含的字符列表</param>
        ///<returns>指定长度的随机字符串</returns>
        public static string GetRandomString(int strLength, bool useNum, bool useLow, bool useUpp, bool useSpe, string custom, int num)
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null, str = "";
            if (useNum == true) { str += "0123456789"; }
            if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
            if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            //   if (useSpe == true) { str += "!\"#$%&'()*+,-./<=>?@[\\]_{|}";
            if (useSpe == true) { str += "!#*.@%&"; }
            for (int i = 0; i < strLength; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            s = s.Insert(num, custom);
            return s;
        }

        private void txtstrlrngth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtstrlrngth.Text == "")
                    txtstrlrngth.Text = 0.ToString();
                int number = int.Parse(txtstrlrngth.Text);
                txtstrlrngth.Text = number.ToString();
                if (number <= 128)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("字符长度最大值不能大于128，请检查输入的值范围" + ex.Message, "提示信息");

            }
            txtstrlrngth.Text = txtstrlrngth.Text.Remove(2);
            txtstrlrngth.SelectionStart = txtstrlrngth.Text.Length;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //加载皮肤
            // s.Dispose();

            // Thread.Sleep(3000);

            //// File.Delete(Application.StartupPath + @"\IrisSkin4.dll");
            // File.Delete(Application.StartupPath + @"\Silver.ssk");
        }
    }
}
