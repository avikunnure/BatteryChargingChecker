using Microsoft.Extensions.Configuration;
using Microsoft.Win32;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ChargerChecking
{
    public partial class ChargerCheck : Form
    {
        public static IConfiguration Config;
        private NotifyIcon trayIcon;
        private int DefaultLevel;
        private Timer timer;
        private bool IsVisible = false;
        public ChargerCheck()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Config = builder.Build();
            DefaultLevel = Config.GetValue<Int32>("ChargingDefaultLevel");
            if (DefaultLevel <= 0 || DefaultLevel >= 99)
            {
                DefaultLevel = 90;
            }
            InitializeComponent();
            this.FormClosing += ChargerCheck_FormClosing;
            timer = new Timer();
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            trayIcon = new NotifyIcon();
            trayIcon.Icon = new Icon("Logos1.ico");
            trayIcon.Visible = true;
            trayIcon.DoubleClick += TrayIcon_DoubleClick;
            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
            Visible = IsVisible;
            checkPlugin();
            //this.ShowInTaskbar = false;
        }

        private void TrayIcon_DoubleClick(object? sender, EventArgs e)
        {
            PowerStatus p = SystemInformation.PowerStatus;
            int a = (int)(p.BatteryLifePercent * 100);
            lbl_BatteryText.Text = $"{a}%";
            Visible = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false;
            this.ShowInTaskbar = false;
            base.OnLoad(e);
        }

        private void ChargerCheck_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            checkPlugin();
        }
        private void checkPlugin()
        {

            if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online)
            {
                System.Media.SystemSounds.Asterisk.Play();
                timer.Enabled = true;
                timer.Start();
            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                timer.Enabled = false;
                timer.Stop();
            }
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online)
            {
                PowerStatus p = SystemInformation.PowerStatus;
                int a = (int)(p.BatteryLifePercent * 100);
                lbl_BatteryText.Text = $"{a}%";
                if (a >= DefaultLevel)
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show($"Please remove your battery charger. Battery charging reached at {a}%", "Warning");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(0);
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(0);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            this.ShowInTaskbar = false;
        }

        private void chargerStatusbtn_Click(object sender, EventArgs e)
        {
            if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online)
            {
                MessageBox.Show("Charger is connected");
                checkPlugin();
            }
            else
            {
                MessageBox.Show("Charger is disconnected");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"This is Application for checking batter status and notify user when charging is connected/ disconnected by alert sound. \n Also send notification when battery charging reached {DefaultLevel} percent .\n Developed by \t\t:Er. Avinash Kunnure ", "about app");
        }
    }
}