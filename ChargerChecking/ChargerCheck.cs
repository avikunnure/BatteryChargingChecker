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
            if(DefaultLevel<=0 || DefaultLevel >= 99)
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
            SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
            Visible = IsVisible;
            checkPlugin();
            //this.ShowInTaskbar = false;
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
                if (a >= DefaultLevel)
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    MessageBox.Show($"Please remove your battery charger. Battery charging reached at {a}%", "Warning");
                }
            }
        }
    }
}