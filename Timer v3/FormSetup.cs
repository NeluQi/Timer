using MetroFramework.Forms;
using System;
namespace Timer_v3
{
    #region CoreLoad
    public partial class FormSetup : MetroForm
    {
        public FormSetup()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Sound == true) { metroCheckBox1.Checked = false; SoundMuc.Checked = true; }
            if (Properties.Settings.Default.Sound == false) { metroCheckBox1.Checked = true; SoundMuc.Checked = false; }
        }
        public bool SoundTemp = true;
        private void Savebtn_Click(object sender, EventArgs e)
        {
            Form1.MainSecond = (Convert.ToInt32(SecNumeric.Value)) + (Convert.ToInt32(MinNumeric.Value) * 60) + (Convert.ToInt32(HourNumeric.Value) * 3600);
            Form1.ConsSecond = Form1.MainSecond;
            Form1.Global = TimeSpan.FromSeconds(Form1.ConsSecond);
            Properties.Settings.Default.Sound = SoundTemp;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void SoundMuc_CheckedChanged(object sender, EventArgs e)
        {
            if (SoundMuc.Checked == true) { metroCheckBox1.Checked = false; SoundTemp = true; }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true) { SoundMuc.Checked = false; SoundTemp = false; }
        }

        private void ScrolSec_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            SecNumeric.Value = ScrolSec.Value;
        }

        private void ScrolMin_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            MinNumeric.Value = ScrolMin.Value;
        }

        private void Exitent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    #endregion
}
