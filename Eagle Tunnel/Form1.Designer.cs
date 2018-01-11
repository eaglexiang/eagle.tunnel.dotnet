namespace Eagle_Tunnel
{
    partial class Form_Main
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
            this.textBox_ServerIP = new System.Windows.Forms.TextBox();
            this.textBox_ServerPort = new System.Windows.Forms.TextBox();
            this.textBox_LocalIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_LocalPort = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Proxy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ServerIP
            // 
            this.textBox_ServerIP.Location = new System.Drawing.Point(83, 6);
            this.textBox_ServerIP.Name = "textBox_ServerIP";
            this.textBox_ServerIP.Size = new System.Drawing.Size(189, 21);
            this.textBox_ServerIP.TabIndex = 0;
            this.textBox_ServerIP.TextChanged += new System.EventHandler(this.TextBox_ServerIP_TextChanged);
            // 
            // textBox_ServerPort
            // 
            this.textBox_ServerPort.Location = new System.Drawing.Point(83, 39);
            this.textBox_ServerPort.Name = "textBox_ServerPort";
            this.textBox_ServerPort.Size = new System.Drawing.Size(189, 21);
            this.textBox_ServerPort.TabIndex = 1;
            this.textBox_ServerPort.TextChanged += new System.EventHandler(this.TextBox_ServerIP_TextChanged);
            // 
            // textBox_LocalIP
            // 
            this.textBox_LocalIP.Location = new System.Drawing.Point(83, 69);
            this.textBox_LocalIP.Name = "textBox_LocalIP";
            this.textBox_LocalIP.Size = new System.Drawing.Size(189, 21);
            this.textBox_LocalIP.TabIndex = 2;
            this.textBox_LocalIP.TextChanged += new System.EventHandler(this.TextBox_ServerIP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "服务器IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "服务器端口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "本地IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "本地端口";
            // 
            // textBox_LocalPort
            // 
            this.textBox_LocalPort.Location = new System.Drawing.Point(83, 101);
            this.textBox_LocalPort.Name = "textBox_LocalPort";
            this.textBox_LocalPort.Size = new System.Drawing.Size(189, 21);
            this.textBox_LocalPort.TabIndex = 7;
            this.textBox_LocalPort.TextChanged += new System.EventHandler(this.TextBox_ServerIP_TextChanged);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(150, 157);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(122, 23);
            this.button_Start.TabIndex = 8;
            this.button_Start.Text = "启动";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // button_Save
            // 
            this.button_Save.Enabled = false;
            this.button_Save.Location = new System.Drawing.Point(14, 128);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(258, 23);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "保存";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // button_Proxy
            // 
            this.button_Proxy.Location = new System.Drawing.Point(14, 158);
            this.button_Proxy.Name = "button_Proxy";
            this.button_Proxy.Size = new System.Drawing.Size(122, 23);
            this.button_Proxy.TabIndex = 10;
            this.button_Proxy.Text = "当前：直连";
            this.button_Proxy.UseVisualStyleBackColor = true;
            this.button_Proxy.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.button_Proxy);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.textBox_LocalPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_LocalIP);
            this.Controls.Add(this.textBox_ServerPort);
            this.Controls.Add(this.textBox_ServerIP);
            this.MaximumSize = new System.Drawing.Size(300, 232);
            this.MinimumSize = new System.Drawing.Size(300, 232);
            this.Name = "Form_Main";
            this.Text = "Eagle Tunnel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ServerIP;
        private System.Windows.Forms.TextBox textBox_ServerPort;
        private System.Windows.Forms.TextBox textBox_LocalIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_LocalPort;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Proxy;
    }
}

