namespace eagle.tunnel.dotnet.winform
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Listen = new System.Windows.Forms.TextBox();
            this.textBox_Relayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Relayer = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Listen = new System.Windows.Forms.Label();
            this.label_Key = new System.Windows.Forms.Label();
            this.checkBox_SOCKS = new System.Windows.Forms.CheckBox();
            this.checkBox_HTTP = new System.Windows.Forms.CheckBox();
            this.checkBox_User = new System.Windows.Forms.CheckBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Switch = new System.Windows.Forms.Button();
            this.radio_Direct = new System.Windows.Forms.RadioButton();
            this.radio_Proxy = new System.Windows.Forms.RadioButton();
            this.label_Speed = new System.Windows.Forms.Label();
            this.timer_CheckSpeed = new System.Windows.Forms.Timer(this.components);
            this.timer_CheckWorking = new System.Windows.Forms.Timer(this.components);
            this.timer_CheckStopped = new System.Windows.Forms.Timer(this.components);
            this.radioButton_Smart = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(108, 300);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(116, 23);
            this.textBox_Key.TabIndex = 7;
            this.textBox_Key.TextChanged += new System.EventHandler(this.textBox_Key_TextChanged);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(108, 263);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(116, 23);
            this.textBox_ID.TabIndex = 6;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // textBox_Listen
            // 
            this.textBox_Listen.Location = new System.Drawing.Point(108, 69);
            this.textBox_Listen.Name = "textBox_Listen";
            this.textBox_Listen.Size = new System.Drawing.Size(116, 23);
            this.textBox_Listen.TabIndex = 1;
            this.textBox_Listen.TextChanged += new System.EventHandler(this.textBox_Listen_TextChanged);
            // 
            // textBox_Relayer
            // 
            this.textBox_Relayer.Location = new System.Drawing.Point(108, 36);
            this.textBox_Relayer.Name = "textBox_Relayer";
            this.textBox_Relayer.Size = new System.Drawing.Size(116, 23);
            this.textBox_Relayer.TabIndex = 0;
            this.textBox_Relayer.TextChanged += new System.EventHandler(this.textBox_Relayer_TextChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 193);
            this.label1.TabIndex = 4;
            this.label1.Text = "基本";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 176);
            this.label2.TabIndex = 5;
            this.label2.Text = "高级";
            // 
            // label_Relayer
            // 
            this.label_Relayer.AutoSize = true;
            this.label_Relayer.Location = new System.Drawing.Point(33, 39);
            this.label_Relayer.Name = "label_Relayer";
            this.label_Relayer.Size = new System.Drawing.Size(68, 17);
            this.label_Relayer.TabIndex = 6;
            this.label_Relayer.Text = "远端地址：";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(33, 269);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(56, 17);
            this.label_ID.TabIndex = 7;
            this.label_ID.Text = "用户名：";
            // 
            // label_Listen
            // 
            this.label_Listen.AutoSize = true;
            this.label_Listen.Location = new System.Drawing.Point(33, 74);
            this.label_Listen.Name = "label_Listen";
            this.label_Listen.Size = new System.Drawing.Size(68, 17);
            this.label_Listen.TabIndex = 8;
            this.label_Listen.Text = "本地地址：";
            // 
            // label_Key
            // 
            this.label_Key.AutoSize = true;
            this.label_Key.Location = new System.Drawing.Point(33, 303);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(44, 17);
            this.label_Key.TabIndex = 9;
            this.label_Key.Text = "密码：";
            // 
            // checkBox_SOCKS
            // 
            this.checkBox_SOCKS.AutoSize = true;
            this.checkBox_SOCKS.Location = new System.Drawing.Point(36, 107);
            this.checkBox_SOCKS.Name = "checkBox_SOCKS";
            this.checkBox_SOCKS.Size = new System.Drawing.Size(67, 21);
            this.checkBox_SOCKS.TabIndex = 2;
            this.checkBox_SOCKS.Text = "SOCKS";
            this.checkBox_SOCKS.UseVisualStyleBackColor = true;
            this.checkBox_SOCKS.CheckedChanged += new System.EventHandler(this.checkBox_SOCKS_CheckedChanged);
            // 
            // checkBox_HTTP
            // 
            this.checkBox_HTTP.AutoSize = true;
            this.checkBox_HTTP.Location = new System.Drawing.Point(36, 134);
            this.checkBox_HTTP.Name = "checkBox_HTTP";
            this.checkBox_HTTP.Size = new System.Drawing.Size(72, 21);
            this.checkBox_HTTP.TabIndex = 3;
            this.checkBox_HTTP.Text = "HTTP(S)";
            this.checkBox_HTTP.UseVisualStyleBackColor = true;
            this.checkBox_HTTP.CheckedChanged += new System.EventHandler(this.checkBox_HTTP_CheckedChanged);
            // 
            // checkBox_User
            // 
            this.checkBox_User.AutoSize = true;
            this.checkBox_User.Location = new System.Drawing.Point(36, 236);
            this.checkBox_User.Name = "checkBox_User";
            this.checkBox_User.Size = new System.Drawing.Size(75, 21);
            this.checkBox_User.TabIndex = 5;
            this.checkBox_User.Text = "用户认证";
            this.checkBox_User.UseVisualStyleBackColor = true;
            this.checkBox_User.CheckedChanged += new System.EventHandler(this.checkBox_User_CheckedChanged);
            // 
            // button_Save
            // 
            this.button_Save.Enabled = false;
            this.button_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Save.Location = new System.Drawing.Point(87, 381);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 10;
            this.button_Save.Text = "保存配置";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Switch
            // 
            this.button_Switch.Location = new System.Drawing.Point(168, 381);
            this.button_Switch.Name = "button_Switch";
            this.button_Switch.Size = new System.Drawing.Size(75, 23);
            this.button_Switch.TabIndex = 11;
            this.button_Switch.Text = "开启服务";
            this.button_Switch.UseVisualStyleBackColor = true;
            this.button_Switch.Click += new System.EventHandler(this.button_Switch_Click);
            // 
            // radio_Direct
            // 
            this.radio_Direct.AutoSize = true;
            this.radio_Direct.Location = new System.Drawing.Point(34, 339);
            this.radio_Direct.Name = "radio_Direct";
            this.radio_Direct.Size = new System.Drawing.Size(74, 21);
            this.radio_Direct.TabIndex = 8;
            this.radio_Direct.Text = "直连上网";
            this.radio_Direct.UseVisualStyleBackColor = true;
            this.radio_Direct.CheckedChanged += new System.EventHandler(this.Radio_Direct_CheckedChanged);
            // 
            // radio_Proxy
            // 
            this.radio_Proxy.AutoSize = true;
            this.radio_Proxy.Location = new System.Drawing.Point(108, 339);
            this.radio_Proxy.Name = "radio_Proxy";
            this.radio_Proxy.Size = new System.Drawing.Size(74, 21);
            this.radio_Proxy.TabIndex = 9;
            this.radio_Proxy.Text = "代理上网";
            this.radio_Proxy.UseVisualStyleBackColor = true;
            this.radio_Proxy.CheckedChanged += new System.EventHandler(this.Radio_Proxy_CheckedChanged);
            // 
            // label_Speed
            // 
            this.label_Speed.AutoSize = true;
            this.label_Speed.Location = new System.Drawing.Point(12, 387);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(0, 17);
            this.label_Speed.TabIndex = 12;
            // 
            // timer_CheckSpeed
            // 
            this.timer_CheckSpeed.Enabled = true;
            this.timer_CheckSpeed.Interval = 1000;
            this.timer_CheckSpeed.Tick += new System.EventHandler(this.timer_CheckSpeed_Tick);
            // 
            // timer_CheckWorking
            // 
            this.timer_CheckWorking.Interval = 1000;
            this.timer_CheckWorking.Tick += new System.EventHandler(this.timer_CheckWorking_Tick);
            // 
            // timer_CheckStopped
            // 
            this.timer_CheckStopped.Interval = 1000;
            this.timer_CheckStopped.Tick += new System.EventHandler(this.timer_CheckStopped_Tick);
            // 
            // radioButton_Smart
            // 
            this.radioButton_Smart.AutoSize = true;
            this.radioButton_Smart.Location = new System.Drawing.Point(188, 339);
            this.radioButton_Smart.Name = "radioButton_Smart";
            this.radioButton_Smart.Size = new System.Drawing.Size(50, 21);
            this.radioButton_Smart.TabIndex = 13;
            this.radioButton_Smart.Text = "智能";
            this.radioButton_Smart.UseVisualStyleBackColor = true;
            this.radioButton_Smart.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 421);
            this.Controls.Add(this.radioButton_Smart);
            this.Controls.Add(this.label_Speed);
            this.Controls.Add(this.radio_Proxy);
            this.Controls.Add(this.radio_Direct);
            this.Controls.Add(this.button_Switch);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.checkBox_User);
            this.Controls.Add(this.checkBox_HTTP);
            this.Controls.Add(this.checkBox_SOCKS);
            this.Controls.Add(this.label_Key);
            this.Controls.Add(this.label_Listen);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_Relayer);
            this.Controls.Add(this.textBox_Relayer);
            this.Controls.Add(this.textBox_Listen);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 460);
            this.MinimumSize = new System.Drawing.Size(270, 460);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eagle Tunnel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Listen;
        private System.Windows.Forms.TextBox textBox_Relayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Relayer;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Listen;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.CheckBox checkBox_SOCKS;
        private System.Windows.Forms.CheckBox checkBox_HTTP;
        private System.Windows.Forms.CheckBox checkBox_User;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Switch;
        private System.Windows.Forms.RadioButton radio_Direct;
        private System.Windows.Forms.RadioButton radio_Proxy;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.Timer timer_CheckWorking;
        private System.Windows.Forms.Timer timer_CheckStopped;
        private System.Windows.Forms.RadioButton radioButton_Smart;
        private System.Windows.Forms.Timer timer_CheckSpeed;
    }
}