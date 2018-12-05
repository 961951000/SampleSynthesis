namespace SampleSynthesis
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cboVoice = new System.Windows.Forms.ComboBox();
            this.rdoOrder = new System.Windows.Forms.RadioButton();
            this.rdoRandom = new System.Windows.Forms.RadioButton();
            this.btnVoice = new System.Windows.Forms.Button();
            this.txtVoice = new System.Windows.Forms.TextBox();
            this.cboRate = new System.Windows.Forms.ComboBox();
            this.cboVolume = new System.Windows.Forms.ComboBox();
            this.cboInterval = new System.Windows.Forms.ComboBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.chkContinuous = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(9, 10);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(302, 307);
            this.treeView1.TabIndex = 0;
            // 
            // cboVoice
            // 
            this.cboVoice.Location = new System.Drawing.Point(316, 11);
            this.cboVoice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboVoice.Name = "cboVoice";
            this.cboVoice.Size = new System.Drawing.Size(92, 21);
            this.cboVoice.TabIndex = 1;
            this.cboVoice.Text = "语音引擎";
            // 
            // rdoOrder
            // 
            this.rdoOrder.AutoSize = true;
            this.rdoOrder.Location = new System.Drawing.Point(468, 53);
            this.rdoOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoOrder.Name = "rdoOrder";
            this.rdoOrder.Size = new System.Drawing.Size(49, 17);
            this.rdoOrder.TabIndex = 2;
            this.rdoOrder.Text = "顺序";
            this.rdoOrder.UseVisualStyleBackColor = true;
            // 
            // rdoRandom
            // 
            this.rdoRandom.AutoSize = true;
            this.rdoRandom.Checked = true;
            this.rdoRandom.Location = new System.Drawing.Point(515, 53);
            this.rdoRandom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdoRandom.Name = "rdoRandom";
            this.rdoRandom.Size = new System.Drawing.Size(49, 17);
            this.rdoRandom.TabIndex = 3;
            this.rdoRandom.TabStop = true;
            this.rdoRandom.Text = "随机";
            this.rdoRandom.UseVisualStyleBackColor = true;
            // 
            // btnVoice
            // 
            this.btnVoice.Location = new System.Drawing.Point(316, 88);
            this.btnVoice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoice.Name = "btnVoice";
            this.btnVoice.Size = new System.Drawing.Size(76, 29);
            this.btnVoice.TabIndex = 5;
            this.btnVoice.Text = "语音";
            this.btnVoice.UseVisualStyleBackColor = true;
            this.btnVoice.Click += new System.EventHandler(this.btnVoice_Click);
            // 
            // txtVoice
            // 
            this.txtVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoice.Location = new System.Drawing.Point(316, 130);
            this.txtVoice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVoice.Multiline = true;
            this.txtVoice.Name = "txtVoice";
            this.txtVoice.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtVoice.Size = new System.Drawing.Size(276, 188);
            this.txtVoice.TabIndex = 6;
            // 
            // cboRate
            // 
            this.cboRate.FormattingEnabled = true;
            this.cboRate.Items.AddRange(new object[] {
            "-10",
            "-9",
            "-8",
            "-7",
            "-6",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboRate.Location = new System.Drawing.Point(668, 31);
            this.cboRate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboRate.Name = "cboRate";
            this.cboRate.Size = new System.Drawing.Size(92, 21);
            this.cboRate.TabIndex = 7;
            this.cboRate.Text = "语速";
            // 
            // cboVolume
            // 
            this.cboVolume.FormattingEnabled = true;
            this.cboVolume.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cboVolume.Location = new System.Drawing.Point(668, 6);
            this.cboVolume.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboVolume.Name = "cboVolume";
            this.cboVolume.Size = new System.Drawing.Size(92, 21);
            this.cboVolume.TabIndex = 8;
            this.cboVolume.Text = "音量";
            // 
            // cboInterval
            // 
            this.cboInterval.FormattingEnabled = true;
            this.cboInterval.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10",
            "15",
            "30",
            "60"});
            this.cboInterval.Location = new System.Drawing.Point(373, 49);
            this.cboInterval.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboInterval.Name = "cboInterval";
            this.cboInterval.Size = new System.Drawing.Size(92, 21);
            this.cboInterval.TabIndex = 9;
            this.cboInterval.Text = "间隔（秒）";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(418, 88);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(76, 29);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(515, 88);
            this.btnResume.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(76, 29);
            this.btnResume.TabIndex = 11;
            this.btnResume.Text = "恢复";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // chkContinuous
            // 
            this.chkContinuous.AutoSize = true;
            this.chkContinuous.Location = new System.Drawing.Point(316, 51);
            this.chkContinuous.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkContinuous.Name = "chkContinuous";
            this.chkContinuous.Size = new System.Drawing.Size(50, 17);
            this.chkContinuous.TabIndex = 12;
            this.chkContinuous.Text = "连续";
            this.chkContinuous.UseVisualStyleBackColor = true;
            this.chkContinuous.CheckedChanged += new System.EventHandler(this.chkContinuous_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 474);
            this.Controls.Add(this.chkContinuous);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.cboInterval);
            this.Controls.Add(this.cboVolume);
            this.Controls.Add(this.cboRate);
            this.Controls.Add(this.txtVoice);
            this.Controls.Add(this.btnVoice);
            this.Controls.Add(this.rdoRandom);
            this.Controls.Add(this.rdoOrder);
            this.Controls.Add(this.cboVoice);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox cboVoice;
        private System.Windows.Forms.RadioButton rdoOrder;
        private System.Windows.Forms.RadioButton rdoRandom;
        private System.Windows.Forms.Button btnVoice;
        private System.Windows.Forms.TextBox txtVoice;
        private System.Windows.Forms.ComboBox cboRate;
        private System.Windows.Forms.ComboBox cboVolume;
        private System.Windows.Forms.ComboBox cboInterval;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.CheckBox chkContinuous;
    }
}

