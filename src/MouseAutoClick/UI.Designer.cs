namespace MouseAutoClick
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.label1 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSleep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnRightDoubleClick = new System.Windows.Forms.RadioButton();
            this.rbtnRightClick = new System.Windows.Forms.RadioButton();
            this.rbtnLeftDoubleClick = new System.Windows.Forms.RadioButton();
            this.rbtnLeftClick = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IsRecycleRun = new System.Windows.Forms.CheckBox();
            this.lblReset = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X坐标";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(295, 12);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(97, 21);
            this.txtX.TabIndex = 1;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(295, 39);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(97, 21);
            this.txtY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y坐标";
            // 
            // txtSleep
            // 
            this.txtSleep.Location = new System.Drawing.Point(295, 66);
            this.txtSleep.Name = "txtSleep";
            this.txtSleep.Size = new System.Drawing.Size(97, 21);
            this.txtSleep.TabIndex = 5;
            this.txtSleep.Text = "500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "延时(ms)";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 316);
            this.listBox1.TabIndex = 6;
            this.listBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnRightDoubleClick);
            this.groupBox1.Controls.Add(this.rbtnRightClick);
            this.groupBox1.Controls.Add(this.rbtnLeftDoubleClick);
            this.groupBox1.Controls.Add(this.rbtnLeftClick);
            this.groupBox1.Location = new System.Drawing.Point(229, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 64);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // rbtnRightDoubleClick
            // 
            this.rbtnRightDoubleClick.AutoSize = true;
            this.rbtnRightDoubleClick.Location = new System.Drawing.Point(92, 42);
            this.rbtnRightDoubleClick.Name = "rbtnRightDoubleClick";
            this.rbtnRightDoubleClick.Size = new System.Drawing.Size(59, 16);
            this.rbtnRightDoubleClick.TabIndex = 3;
            this.rbtnRightDoubleClick.Text = "右双击";
            this.rbtnRightDoubleClick.UseVisualStyleBackColor = true;
            // 
            // rbtnRightClick
            // 
            this.rbtnRightClick.AutoSize = true;
            this.rbtnRightClick.Location = new System.Drawing.Point(92, 20);
            this.rbtnRightClick.Name = "rbtnRightClick";
            this.rbtnRightClick.Size = new System.Drawing.Size(59, 16);
            this.rbtnRightClick.TabIndex = 2;
            this.rbtnRightClick.Text = "右单击";
            this.rbtnRightClick.UseVisualStyleBackColor = true;
            // 
            // rbtnLeftDoubleClick
            // 
            this.rbtnLeftDoubleClick.AutoSize = true;
            this.rbtnLeftDoubleClick.Location = new System.Drawing.Point(15, 42);
            this.rbtnLeftDoubleClick.Name = "rbtnLeftDoubleClick";
            this.rbtnLeftDoubleClick.Size = new System.Drawing.Size(59, 16);
            this.rbtnLeftDoubleClick.TabIndex = 1;
            this.rbtnLeftDoubleClick.Text = "左双击";
            this.rbtnLeftDoubleClick.UseVisualStyleBackColor = true;
            // 
            // rbtnLeftClick
            // 
            this.rbtnLeftClick.AutoSize = true;
            this.rbtnLeftClick.Checked = true;
            this.rbtnLeftClick.Location = new System.Drawing.Point(15, 20);
            this.rbtnLeftClick.Name = "rbtnLeftClick";
            this.rbtnLeftClick.Size = new System.Drawing.Size(59, 16);
            this.rbtnLeftClick.TabIndex = 0;
            this.rbtnLeftClick.TabStop = true;
            this.rbtnLeftClick.Text = "左单击";
            this.rbtnLeftClick.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(229, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 122);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "说明";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ctrl+S保存文件";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Delete-删除坐标点";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "双击左栏打开文件";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(90, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "F9停止";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(13, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "F8开始";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "F7-设置坐标点";
            // 
            // IsRecycleRun
            // 
            this.IsRecycleRun.AutoSize = true;
            this.IsRecycleRun.Checked = true;
            this.IsRecycleRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsRecycleRun.Location = new System.Drawing.Point(234, 293);
            this.IsRecycleRun.Name = "IsRecycleRun";
            this.IsRecycleRun.Size = new System.Drawing.Size(72, 16);
            this.IsRecycleRun.TabIndex = 9;
            this.IsRecycleRun.Text = "循环执行";
            this.IsRecycleRun.UseVisualStyleBackColor = true;
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.LinkColor = System.Drawing.Color.Black;
            this.lblReset.Location = new System.Drawing.Point(319, 297);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(65, 12);
            this.lblReset.TabIndex = 10;
            this.lblReset.TabStop = true;
            this.lblReset.Text = "重置坐标点";
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 324);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.IsRecycleRun);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtSleep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "鼠标点击助手";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSleep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnLeftClick;
        private System.Windows.Forms.RadioButton rbtnRightDoubleClick;
        private System.Windows.Forms.RadioButton rbtnRightClick;
        private System.Windows.Forms.RadioButton rbtnLeftDoubleClick;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox IsRecycleRun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lblReset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

