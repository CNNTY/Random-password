namespace 随机字符生成工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCreate = new System.Windows.Forms.Button();
            this.Lblength = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.TxtStr = new System.Windows.Forms.TextBox();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtstrlrngth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcustom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxcustom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCreate.Location = new System.Drawing.Point(286, 15);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(82, 25);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "生成字符";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // Lblength
            // 
            this.Lblength.AutoSize = true;
            this.Lblength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lblength.Location = new System.Drawing.Point(12, 18);
            this.Lblength.Name = "Lblength";
            this.Lblength.Size = new System.Drawing.Size(86, 24);
            this.Lblength.TabIndex = 1;
            this.Lblength.Text = "字符长度";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblType.Location = new System.Drawing.Point(12, 54);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(86, 24);
            this.LblType.TabIndex = 1;
            this.LblType.Text = "组合方式";
            // 
            // TxtStr
            // 
            this.TxtStr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtStr.Location = new System.Drawing.Point(12, 115);
            this.TxtStr.Multiline = true;
            this.TxtStr.Name = "TxtStr";
            this.TxtStr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtStr.Size = new System.Drawing.Size(444, 106);
            this.TxtStr.TabIndex = 6;
            // 
            // BtnCopy
            // 
            this.BtnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCopy.Location = new System.Drawing.Point(374, 15);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(82, 25);
            this.BtnCopy.TabIndex = 5;
            this.BtnCopy.Text = "复制文本";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(331, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // txtstrlrngth
            // 
            this.txtstrlrngth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtstrlrngth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtstrlrngth.Location = new System.Drawing.Point(125, 15);
            this.txtstrlrngth.MaxLength = 64;
            this.txtstrlrngth.Name = "txtstrlrngth";
            this.txtstrlrngth.Size = new System.Drawing.Size(155, 26);
            this.txtstrlrngth.TabIndex = 0;
            this.txtstrlrngth.TextChanged += new System.EventHandler(this.txtstrlrngth_TextChanged);
            this.txtstrlrngth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strLength_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "自定义字符";
            // 
            // txtcustom
            // 
            this.txtcustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtcustom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtcustom.Location = new System.Drawing.Point(125, 84);
            this.txtcustom.Name = "txtcustom";
            this.txtcustom.Size = new System.Drawing.Size(155, 26);
            this.txtcustom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(286, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "自定义位置";
            // 
            // cboxcustom
            // 
            this.cboxcustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxcustom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboxcustom.FormattingEnabled = true;
            this.cboxcustom.Location = new System.Drawing.Point(391, 86);
            this.cboxcustom.Name = "cboxcustom";
            this.cboxcustom.Size = new System.Drawing.Size(65, 28);
            this.cboxcustom.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 227);
            this.Controls.Add(this.cboxcustom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcustom);
            this.Controls.Add(this.txtstrlrngth);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TxtStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.Lblength);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.BtnCreate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "随机密码字符串生成工具 By 风吟";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label Lblength;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.TextBox TxtStr;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtstrlrngth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcustom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxcustom;
    }
}

