using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Timer_v3
{
    public partial class Form1 : MetroForm
    {
        #region CoreLoad
        public Form1()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += TimerRun;
            Tablo.Value = 0;
            Tablo.ProgressColor = System.Drawing.Color.FromArgb(39, 174, 96);
            Tablo.InnerColor = System.Drawing.Color.FromArgb(44, 62, 80);


        }
        public string IFIN(string s)
        {
            if (s == "") { return "00"; }
            if (Convert.ToInt32(s) < 10) { return 0 + s; }
            else { return s; }
        }
        
        public void TimerRun(object sender, EventArgs e)
        {
            try{
                InputLabel.Text = "Статус: Идет... (Исходное время " + IFIN(Global.Hours.ToString()) + ":" + IFIN(Global.Minutes.ToString()) + ":" + IFIN(Global.Seconds.ToString()) + ")";
                if (Tablo.Value != 0) {
                    Tablo.Value--;
                }
                ConsSecond = ConsSecond - 1;
            var ts = TimeSpan.FromSeconds(ConsSecond);
            Tablo.Text = IFIN(ts.Hours.ToString()) + ":" + IFIN(ts.Minutes.ToString()) + ":" + IFIN(ts.Seconds.ToString());
                if (ConsSecond == 0) {
                    InputLabel.Text = "Статус: Готов (Исходное время " + IFIN(Global.Hours.ToString()) + ":" + IFIN(Global.Minutes.ToString()) + ":" + IFIN(Global.Seconds.ToString()) + ")";
                    Start.Enabled = true;
                    Stop.Enabled = true;
                    Pause.Enabled = false;
                    timer.Stop();
                    this.WindowState = FormWindowState.Normal;
                    Tablo.Text = "00:00:00";
                    if (Properties.Settings.Default.Sound) {
                        System.Media.SoundPlayer sp2 = new System.Media.SoundPlayer();
                        sp2.SoundLocation = "zvuki.wav";
                        sp2.Load();
                        sp2.Play();
                    }
                    MetroMessageBox.Show(this, "Время закончилось", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                if (Tablo.Value < MainSecond * 0.4)
                {
                    Tablo.ProgressColor = System.Drawing.Color.FromArgb(211, 84, 0);
                    One = true;
                }

                if (Tablo.Value < MainSecond * 0.2)
                {
                    Tablo.ProgressColor = System.Drawing.Color.FromArgb(192, 57, 43);
                }
                if (timer.Enabled == true) { flatButton1.Enabled = false; }
                else { flatButton1.Enabled = true; }
            }
            catch { }
        }
        public void TimerRun()
        {
            try
            {
                Tablo.Value--;
                ConsSecond = ConsSecond - 1;
            var ts = TimeSpan.FromSeconds(ConsSecond);
            Tablo.Text = IFIN(ts.Hours.ToString()) + ":" + IFIN(ts.Minutes.ToString()) + ":" + IFIN(ts.Seconds.ToString());
           
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        #endregion

        #region GlobalP
        public static int MainSecond = 0;
        public static int ConsSecond;
        public static bool Sound;
        public static Timer timer = new Timer();
        public bool One = false;
        public static TimeSpan Global;

        #endregion

        private void Start_Click(object sender, EventArgs e)
        {
            InputLabel.Text = "Статус: Старт...";
            ConsSecond = MainSecond;
            Tablo.ProgressColor = System.Drawing.Color.FromArgb(39, 174, 96);
            Tablo.Maximum = ConsSecond;
            Tablo.Minimum = 0;
            Tablo.Step = ConsSecond / 100;
            Tablo.Value = 0;
            Tablo.Value = ConsSecond;
            if (Tablo.Value != 0)
            {
                Tablo.Value--;
            }
            TimerRun();
            timer.Start();
            Start.Enabled = false;
            Stop.Enabled = true;
            Pause.Enabled = true;
            if (timer.Enabled == true) { flatButton1.Enabled = false; }
            else { flatButton1.Enabled = true; }
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            FormSetup FormSetup = new FormSetup();
            FormSetup.Show();
            FormSetup.FormClosed += FormTimeClose;
        }

        private void FormTimeClose(object sender, FormClosedEventArgs e)
        {
            Tablo.ProgressColor = System.Drawing.Color.FromArgb(39, 174, 96);
            var ts = TimeSpan.FromSeconds(MainSecond);
            Tablo.Text = IFIN(ts.Hours.ToString()) + ":" + IFIN(ts.Minutes.ToString()) + ":" + IFIN(ts.Seconds.ToString());
            this.Focus();
            Tablo.Refresh();
            if (MainSecond > 0)
            {
                Start.Enabled = true;
                Stop.Enabled = true;
                Pause.Enabled = true;
            }
            else {
                Start.Enabled = false;
                Stop.Enabled = false;
                Pause.Enabled = false;
            }
            InputLabel.Text = "Статус: Таймер установлен на " + IFIN(ts.Hours.ToString()) + ":" + IFIN(ts.Minutes.ToString()) + ":" + IFIN(ts.Seconds.ToString());
            Tablo.Maximum = ConsSecond;
            Tablo.Minimum = 0;
            Tablo.Step = ConsSecond / 100;
            Tablo.Value = 0;
            Tablo.Value = ConsSecond;
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            InputLabel.Text = "Статус: Пауза (Исходное время " + IFIN(Global.Hours.ToString()) + ":" + IFIN(Global.Minutes.ToString()) + ":" + IFIN(Global.Seconds.ToString()) + ")";
            if (timer.Enabled == false) { TimerRun(); timer.Start(); InputLabel.Text = "Статус: Идет... (Исходное время " + IFIN(Global.Hours.ToString()) + ":" + IFIN(Global.Minutes.ToString()) + ":" + IFIN(Global.Seconds.ToString()) + ")"; }
            else { timer.Stop(); }
            Start.Enabled = true;
            Stop.Enabled = true;
            if (ConsSecond == MainSecond) {
                ConsSecond = MainSecond;
                Tablo.ProgressColor = System.Drawing.Color.FromArgb(39, 174, 96);
                Tablo.Maximum = ConsSecond;
                Tablo.Minimum = 0;
                Tablo.Step = ConsSecond / 100;
                Tablo.Value = 0;
                Tablo.Value = ConsSecond;
                if (Tablo.Value != 0)
                {
                    Tablo.Value--;
                }
                TimerRun();
                timer.Start();
                Start.Enabled = false;
                Stop.Enabled = true;
                Pause.Enabled = true;

            }
            if (timer.Enabled == true) { flatButton1.Enabled = false; }
            else { flatButton1.Enabled = true; }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            InputLabel.Text = "Статус: Сброшен";
            timer.Stop();
            Tablo.Text = "00:00:00";
            Tablo.Value = 0;
            Start.Enabled = true;
            Stop.Enabled = false;
            Pause.Enabled = false;
            if (timer.Enabled == true) { flatButton1.Enabled = false; }
            else { flatButton1.Enabled = true; }
        }
    }
}
