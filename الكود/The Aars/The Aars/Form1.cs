using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace The_Aars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ///The Time Now
            DateTime TimeNow = DateTime.Now;
            time.Text = DateTime.Now.ToString("hh:mm:ss tt"); //result 11:11:45 PM
            int num = TimeNow.Minute;
            ///Calculate the Pray Time
            PrayTime praytime = new PrayTime();
            double lo = 31.17;
            double la = 30.97;
            int tz = 2;
            int _year = TimeNow.Year;
            int _month = TimeNow.Month;
            int _day = TimeNow.Day;
            ////the calculate
            tz = TimeZone.CurrentTimeZone.GetUtcOffset(new DateTime(_year, _month, _day)).Hours;
            String[] s;

            praytime.setCalcMethod(5);
            praytime.setAsrMethod(0);
            s = praytime.getDatePrayerTimes(_year, _month, _day, lo, la, tz);
            for (int i = 0; i < s.Length; ++i)
            {
                Console.WriteLine(s[i]);
            }
            ///The Time of Pray :Fajr.
            //fajr.Text = s[0]+" AM";
            string fhours = s[0][0] + "" + s[0][1];
            int thefhours = Convert.ToInt32(fhours);
            string fminutes = s[0][3] + "" + s[0][4];
            int thefminutes = Convert.ToInt32(fminutes);
            DateTime tof = DateTime.Now;
            tof = new DateTime(tof.Year, tof.Month, tof.Day, thefhours, thefminutes, 00, 00);
            fajr.Text = tof.ToString(" hh:mm tt");//result 3:33:45 AM
            ///fajr.Text = s[0] + " AM";
            ///The Time of Pray :Dhohr.       
            //dhohr.Text = s[2]+ " AM";//result 11:25:45 PM
            string dhours = s[2][0] + "" + s[2][1];
            int thedhours = Convert.ToInt32(dhours);
            string dminutes = s[2][3] + "" + s[2][4];
            int thedminutes = Convert.ToInt32(dminutes);
            DateTime tod = DateTime.Now;
            tod = new DateTime(tod.Year, tod.Month, tod.Day, thedhours, thedminutes, 00, 00);
            dhohr.Text = tod.ToString("hh:mm tt");//result 11:25:45 PM
            ///The Time of Pray :Asr.
            string ahours = s[3][0] + "" + s[3][1];
            int theahours = Convert.ToInt32(ahours);
            string aminutes = s[3][3] + "" + s[3][4];
            int theaminutes = Convert.ToInt32(aminutes);
            DateTime toa = DateTime.Now;
            toa = new DateTime(toa.Year, toa.Month, toa.Day, theahours, theaminutes, 00, 00);
            asr.Text = toa.ToString(" hh:mm tt");//result 15:31:45 PM
            ///The Time of Pray :Maghreb.
            string mhours = s[5][0] + "" + s[5][1];
            int themhours = Convert.ToInt32(mhours);
            string mminutes = s[5][3] + "" + s[5][4];
            int themminutes = Convert.ToInt32(mminutes);
            DateTime tom = DateTime.Now;
            tom = new DateTime(tom.Year, tom.Month, tom.Day, themhours, themminutes, 00, 00);
            maghreb.Text = tom.ToString("hh:mm tt");//result 18:35:45 PM
            ///The Time of Pray :Isha.
            string ihours = s[6][0] + "" + s[6][1];
            int theihours = Convert.ToInt32(ihours);
            string iminutes = s[6][3] + "" + s[6][4];
            int theiminutes = Convert.ToInt32(iminutes);
            DateTime toi = DateTime.Now;
            toi = new DateTime(toi.Year, toi.Month, toi.Day, theihours, theiminutes, 00, 00);
            isha.Text = toi.ToString(" hh:mm tt");//result 20:13:45 PM
            ////////
            //// trun between الهجرى والميلادى
            if (num % 2 == 0)
            {
                /////The Date & Month الميلادى
                month.Text = DateTime.Now.ToString("MMM", new System.Globalization.CultureInfo("ar-EG"));
                date.Text = DateTime.Now.ToString("yyyy/MM/dd"+" "+"dddd", new System.Globalization.CultureInfo("ar-EG"));
            } 
            else 
            {
                /////The Date & Month الهجرى
                month.Text = DateTime.Now.ToString("MMMM ", new System.Globalization.CultureInfo("ar-SA"));
                date.Text = DateTime.Now.ToString("yyyy/MM/dd" + " " + "dddd", new System.Globalization.CultureInfo("ar-SA"));
            }
            //////Check Time of Pray
            /////Fajr
            bool cf = Convert.ToBoolean(tof.Minute.CompareTo(TimeNow.Minute));
            bool cf2 = Convert.ToBoolean(tof.Hour.CompareTo(TimeNow.Hour));
            /////Dhohr
            bool cd = Convert.ToBoolean(tod.Minute.CompareTo(TimeNow.Minute));
            bool cd2 = Convert.ToBoolean(tod.Hour.CompareTo(TimeNow.Hour));
            /////Asr
            bool ca = Convert.ToBoolean(toa.Minute.CompareTo(TimeNow.Minute));
            bool ca2 = Convert.ToBoolean(toa.Hour.CompareTo(TimeNow.Hour));
            /////Maghreb
            bool cm = Convert.ToBoolean(tom.Minute.CompareTo(TimeNow.Minute));
            bool cm2 = Convert.ToBoolean(tom.Hour.CompareTo(TimeNow.Hour));
            /////Isha
            bool ci = Convert.ToBoolean(toi.Minute.CompareTo(TimeNow.Minute));
            bool ci2 = Convert.ToBoolean(toi.Hour.CompareTo(TimeNow.Hour));


            ////////////commmet temporaryt
            if (((cf != true && cf2 != true) && TimeNow.Second == tof.Second) || ((cd != true && cd2 != true) && TimeNow.Second == tod.Second) || ((ca != true && ca2 != true) && TimeNow.Second == toa.Second) || ((cm != true && cm2 != true) && TimeNow.Second == tom.Second) || ((ci != true && ci2 != true) && TimeNow.Second == toa.Second))
            {
                System.Threading.Thread.Sleep(1000);
                if (cf != true && cf2 != true)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\sound.wav");
                    player.Play();
                    notifyIcon1.ShowBalloonTip(2000,"مواقيت الصلاة", "الان موعد أذان الفجر", ToolTipIcon.Info);
                    MessageBox.Show(DateTime.Now.ToString("hh:mm tt") + "\n" + "حان الان موعد أذان الفجر");
                    player.Stop();
                }
                else if (cd != true && cd2 != true)
                { 
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\sound.wav");
                    player.Play();
                    notifyIcon1.ShowBalloonTip(2000, "مواقيت الصلاة", " الان موعد أذان الظهر", ToolTipIcon.Info);
                    MessageBox.Show(DateTime.Now.ToString("hh:mm tt") + "\n" + "حان الان موعد أذان الظهر");
                    player.Stop();
                }
                else if (ca != true && ca2 != true)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\sound.wav");
                    player.Play();
                    notifyIcon1.ShowBalloonTip(2000, "مواقيت الصلاة", "الان موعد أذان العصر", ToolTipIcon.Info);
                    MessageBox.Show(DateTime.Now.ToString("hh:mm tt") + "\n" + "حان الان موعد أذان العصر");
                    player.Stop();
                }
                else if (cm != true && cm2 != true)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\sound.wav");
                    player.Play();
                    notifyIcon1.ShowBalloonTip(2000, "مواقيت الصلاة", "الان موعد أذان المغرب", ToolTipIcon.Info);
                    MessageBox.Show(DateTime.Now.ToString("hh:mm: tt") + "\n" + "حان الان موعد أذان المغرب");
                    player.Stop();
                }
                else if (ci != true && ci2 != true)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\sound.wav");
                    player.Play();
                    notifyIcon1.ShowBalloonTip(2000, "مواقيت الصلاة", "الان موعد أذان العشاء", ToolTipIcon.Info);
                    MessageBox.Show(DateTime.Now.ToString("hh:mm tt") + "\n" + "حان الان موعد أذان العشاء");
                    player.Stop();
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void show_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
