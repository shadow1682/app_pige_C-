namespace app_pigege
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonYes = new DevComponents.DotNetBar.ButtonX();
            this.buttonNo = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // buttonYes
            // 
            this.buttonYes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonYes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonYes.Location = new System.Drawing.Point(48, 198);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(94, 46);
            this.buttonYes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "是的！";
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            this.buttonYes.MouseEnter += new System.EventHandler(this.buttonYes_MouseEnter);
            // 
            // buttonNo
            // 
            this.buttonNo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonNo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonNo.Location = new System.Drawing.Point(207, 198);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(94, 46);
            this.buttonNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonNo.TabIndex = 0;
            this.buttonNo.Text = "不是~";
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            this.buttonNo.MouseEnter += new System.EventHandler(this.buttonNo_MouseEnter);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("楷体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(96, 31);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(190, 98);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "请问：皮哥是脑残吗？";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(368, 268);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "欢迎你！杜江皮同学！";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonYes;
        private DevComponents.DotNetBar.ButtonX buttonNo;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}

