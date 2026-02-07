namespace stm_interface_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LED_ON = new System.Windows.Forms.Button();
            this.LED_OFF = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonPort = new System.Windows.Forms.Button();
            this.button_conn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LED_ON
            // 
            this.LED_ON.Location = new System.Drawing.Point(206, 333);
            this.LED_ON.Name = "LED_ON";
            this.LED_ON.Size = new System.Drawing.Size(153, 51);
            this.LED_ON.TabIndex = 0;
            this.LED_ON.Text = "LED_ON";
            this.LED_ON.UseVisualStyleBackColor = true;
            this.LED_ON.Click += new System.EventHandler(this.button1_Click);
            // 
            // LED_OFF
            // 
            this.LED_OFF.Location = new System.Drawing.Point(489, 333);
            this.LED_OFF.Name = "LED_OFF";
            this.LED_OFF.Size = new System.Drawing.Size(148, 51);
            this.LED_OFF.TabIndex = 1;
            this.LED_OFF.Text = "LED_OFF";
            this.LED_OFF.UseVisualStyleBackColor = true;
            this.LED_OFF.Click += new System.EventHandler(this.button2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPort1_PinChanged);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonPort
            // 
            this.buttonPort.Location = new System.Drawing.Point(211, 195);
            this.buttonPort.Name = "buttonPort";
            this.buttonPort.Size = new System.Drawing.Size(148, 46);
            this.buttonPort.TabIndex = 3;
            this.buttonPort.Text = "Получить порты";
            this.buttonPort.UseVisualStyleBackColor = true;
            this.buttonPort.Click += new System.EventHandler(this.buttonPort_Click);
            // 
            // button_conn
            // 
            this.button_conn.Location = new System.Drawing.Point(492, 195);
            this.button_conn.Name = "button_conn";
            this.button_conn.Size = new System.Drawing.Size(145, 51);
            this.button_conn.TabIndex = 4;
            this.button_conn.Text = "подключить";
            this.button_conn.UseVisualStyleBackColor = true;
            this.button_conn.Click += new System.EventHandler(this.button_conn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_conn);
            this.Controls.Add(this.buttonPort);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LED_OFF);
            this.Controls.Add(this.LED_ON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LED_ON;
        private System.Windows.Forms.Button LED_OFF;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonPort;
        private System.Windows.Forms.Button button_conn;
        private System.Windows.Forms.Label label1;
    }
}

