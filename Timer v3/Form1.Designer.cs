namespace Timer_v3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tablo = new CircularProgressBar.CircularProgressBar();
            this.Start = new FlatUI.FlatButton();
            this.Stop = new FlatUI.FlatButton();
            this.Pause = new FlatUI.FlatButton();
            this.flatGroupBox1 = new FlatUI.FlatGroupBox();
            this.flatButton1 = new FlatUI.FlatButton();
            this.InputLabel = new MetroFramework.Controls.MetroLabel();
            this.flatGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tablo
            // 
            this.Tablo.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("Tablo.AnimationFunction")));
            this.Tablo.AnimationSpeed = 1000;
            this.Tablo.BackColor = System.Drawing.Color.White;
            this.Tablo.Font = new System.Drawing.Font("Segoe UI Light", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tablo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Tablo.InnerColor = System.Drawing.Color.DarkSlateGray;
            this.Tablo.InnerMargin = -1;
            this.Tablo.InnerWidth = -1;
            this.Tablo.Location = new System.Drawing.Point(11, 54);
            this.Tablo.MarqueeAnimationSpeed = 1000;
            this.Tablo.Name = "Tablo";
            this.Tablo.OuterColor = System.Drawing.Color.White;
            this.Tablo.OuterMargin = -1;
            this.Tablo.OuterWidth = -1;
            this.Tablo.ProgressColor = System.Drawing.Color.Teal;
            this.Tablo.ProgressWidth = 35;
            this.Tablo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tablo.SecondaryFont = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tablo.Size = new System.Drawing.Size(450, 450);
            this.Tablo.StartAngle = 270;
            this.Tablo.Step = 1;
            this.Tablo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Tablo.SubscriptColor = System.Drawing.Color.White;
            this.Tablo.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.Tablo.SubscriptText = "";
            this.Tablo.SuperscriptColor = System.Drawing.Color.White;
            this.Tablo.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.Tablo.SuperscriptText = "";
            this.Tablo.TabIndex = 0;
            this.Tablo.Text = "00:00:00";
            this.Tablo.TextMargin = new System.Windows.Forms.Padding(0);
            this.Tablo.Value = 100;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Enabled = false;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Start.Location = new System.Drawing.Point(21, 24);
            this.Start.Name = "Start";
            this.Start.Rounded = false;
            this.Start.Size = new System.Drawing.Size(106, 32);
            this.Start.TabIndex = 1;
            this.Start.Text = "Старт";
            this.Start.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.Enabled = false;
            this.Stop.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Stop.Location = new System.Drawing.Point(304, 24);
            this.Stop.Name = "Stop";
            this.Stop.Rounded = false;
            this.Stop.Size = new System.Drawing.Size(106, 32);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Сборс";
            this.Stop.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pause.Enabled = false;
            this.Pause.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Pause.Location = new System.Drawing.Point(160, 24);
            this.Pause.Name = "Pause";
            this.Pause.Rounded = false;
            this.Pause.Size = new System.Drawing.Size(106, 32);
            this.Pause.TabIndex = 3;
            this.Pause.Text = "Пауза\\Пуск";
            this.Pause.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // flatGroupBox1
            // 
            this.flatGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox1.Controls.Add(this.Start);
            this.flatGroupBox1.Controls.Add(this.Pause);
            this.flatGroupBox1.Controls.Add(this.Stop);
            this.flatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox1.Location = new System.Drawing.Point(19, 510);
            this.flatGroupBox1.Name = "flatGroupBox1";
            this.flatGroupBox1.ShowText = false;
            this.flatGroupBox1.Size = new System.Drawing.Size(442, 79);
            this.flatGroupBox1.TabIndex = 4;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(331, 592);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(106, 32);
            this.flatButton1.TabIndex = 5;
            this.flatButton1.Text = "Настройки";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(31, 592);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(0, 0);
            this.InputLabel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 631);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.flatGroupBox1);
            this.Controls.Add(this.Tablo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Resizable = false;
            this.Text = "Таймер";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flatGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlatUI.FlatButton Start;
        private FlatUI.FlatButton Stop;
        private FlatUI.FlatButton Pause;
        private FlatUI.FlatGroupBox flatGroupBox1;
        private FlatUI.FlatButton flatButton1;
        public CircularProgressBar.CircularProgressBar Tablo;
        private MetroFramework.Controls.MetroLabel InputLabel;
    }
}

