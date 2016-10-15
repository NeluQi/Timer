namespace Timer_v3
{
    partial class FormSetup
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
            this.SecNumeric = new FlatUI.FlatNumeric();
            this.MinNumeric = new FlatUI.FlatNumeric();
            this.HourNumeric = new FlatUI.FlatNumeric();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SoundMuc = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.Savebtn = new FlatUI.FlatButton();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ScrolSec = new MetroFramework.Controls.MetroTrackBar();
            this.ScrolMin = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Exitent = new FlatUI.FlatButton();
            this.SuspendLayout();
            // 
            // SecNumeric
            // 
            this.SecNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.SecNumeric.BaseColor = System.Drawing.Color.Teal;
            this.SecNumeric.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.SecNumeric.Cursor = System.Windows.Forms.Cursors.Default;
            this.SecNumeric.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SecNumeric.ForeColor = System.Drawing.Color.White;
            this.SecNumeric.Location = new System.Drawing.Point(95, 60);
            this.SecNumeric.Maximum = ((long)(999999));
            this.SecNumeric.Minimum = ((long)(0));
            this.SecNumeric.Name = "SecNumeric";
            this.SecNumeric.Size = new System.Drawing.Size(75, 30);
            this.SecNumeric.TabIndex = 5;
            this.SecNumeric.Text = "flatNumeric1";
            this.SecNumeric.Value = ((long)(0));
            // 
            // MinNumeric
            // 
            this.MinNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.MinNumeric.BaseColor = System.Drawing.Color.Teal;
            this.MinNumeric.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.MinNumeric.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinNumeric.ForeColor = System.Drawing.Color.White;
            this.MinNumeric.Location = new System.Drawing.Point(95, 96);
            this.MinNumeric.Maximum = ((long)(999));
            this.MinNumeric.Minimum = ((long)(0));
            this.MinNumeric.Name = "MinNumeric";
            this.MinNumeric.Size = new System.Drawing.Size(75, 30);
            this.MinNumeric.TabIndex = 1;
            this.MinNumeric.Text = "flatNumeric2";
            this.MinNumeric.Value = ((long)(0));
            // 
            // HourNumeric
            // 
            this.HourNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.HourNumeric.BaseColor = System.Drawing.Color.Teal;
            this.HourNumeric.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.HourNumeric.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HourNumeric.ForeColor = System.Drawing.Color.White;
            this.HourNumeric.Location = new System.Drawing.Point(95, 132);
            this.HourNumeric.Maximum = ((long)(99));
            this.HourNumeric.Minimum = ((long)(0));
            this.HourNumeric.Name = "HourNumeric";
            this.HourNumeric.Size = new System.Drawing.Size(75, 30);
            this.HourNumeric.TabIndex = 2;
            this.HourNumeric.Text = "flatNumeric3";
            this.HourNumeric.Value = ((long)(0));
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(8, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Секунды:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(8, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 25);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Минуты:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(8, 137);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 25);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Часы:";
            // 
            // SoundMuc
            // 
            this.SoundMuc.AutoSize = true;
            this.SoundMuc.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.SoundMuc.Location = new System.Drawing.Point(176, 60);
            this.SoundMuc.Name = "SoundMuc";
            this.SoundMuc.Size = new System.Drawing.Size(254, 25);
            this.SoundMuc.TabIndex = 9;
            this.SoundMuc.Text = "Музыкальное уведомление";
            this.SoundMuc.UseSelectable = true;
            this.SoundMuc.CheckedChanged += new System.EventHandler(this.SoundMuc_CheckedChanged);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBox1.Location = new System.Drawing.Point(176, 96);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(221, 25);
            this.metroCheckBox1.TabIndex = 10;
            this.metroCheckBox1.Text = "Звуковое уведомление";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.Transparent;
            this.Savebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Savebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Savebtn.Location = new System.Drawing.Point(81, 324);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Rounded = false;
            this.Savebtn.Size = new System.Drawing.Size(271, 32);
            this.Savebtn.TabIndex = 11;
            this.Savebtn.Text = "Сохранить";
            this.Savebtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.flatLabel1.Location = new System.Drawing.Point(162, 22);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(224, 21);
            this.flatLabel1.TabIndex = 12;
            this.flatLabel1.Text = "Можно вводить с клавиатуры";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(8, 177);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 25);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Секунды:";
            // 
            // ScrolSec
            // 
            this.ScrolSec.BackColor = System.Drawing.Color.Transparent;
            this.ScrolSec.Location = new System.Drawing.Point(13, 205);
            this.ScrolSec.Name = "ScrolSec";
            this.ScrolSec.Size = new System.Drawing.Size(407, 23);
            this.ScrolSec.TabIndex = 14;
            this.ScrolSec.Text = "metroTrackBar1";
            this.ScrolSec.Value = 0;
            this.ScrolSec.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrolSec_Scroll);
            // 
            // ScrolMin
            // 
            this.ScrolMin.BackColor = System.Drawing.Color.Transparent;
            this.ScrolMin.Location = new System.Drawing.Point(13, 271);
            this.ScrolMin.Name = "ScrolMin";
            this.ScrolMin.Size = new System.Drawing.Size(407, 23);
            this.ScrolMin.TabIndex = 16;
            this.ScrolMin.Text = "metroTrackBar2";
            this.ScrolMin.Value = 0;
            this.ScrolMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrolMin_Scroll);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(8, 243);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 25);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Минуты:";
            // 
            // Exitent
            // 
            this.Exitent.BackColor = System.Drawing.Color.Transparent;
            this.Exitent.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.Exitent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Exitent.Location = new System.Drawing.Point(81, 362);
            this.Exitent.Name = "Exitent";
            this.Exitent.Rounded = false;
            this.Exitent.Size = new System.Drawing.Size(271, 32);
            this.Exitent.TabIndex = 17;
            this.Exitent.Text = "Закрыть";
            this.Exitent.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Exitent.Click += new System.EventHandler(this.Exitent_Click);
            // 
            // FormSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 402);
            this.ControlBox = false;
            this.Controls.Add(this.Exitent);
            this.Controls.Add(this.ScrolMin);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.ScrolSec);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.flatLabel1);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.SoundMuc);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.HourNumeric);
            this.Controls.Add(this.MinNumeric);
            this.Controls.Add(this.SecNumeric);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetup";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatNumeric SecNumeric;
        private FlatUI.FlatNumeric MinNumeric;
        private FlatUI.FlatNumeric HourNumeric;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox SoundMuc;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private FlatUI.FlatButton Savebtn;
        private FlatUI.FlatLabel flatLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTrackBar ScrolSec;
        private MetroFramework.Controls.MetroTrackBar ScrolMin;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private FlatUI.FlatButton Exitent;
    }
}