using shutdown.frontend.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace shutdown
{
    public partial class FrmMain : FrmBase
    {
        public static CtrSettings CtrSettings { get; set; } = new CtrSettings();
        public static CtrMain CtrMain { get; set; } = new CtrMain();

        public FrmMain()
        {
            InitializeComponent();

            CtrSettings.Dock = DockStyle.Fill;
            CtrSettings.BtnChangeColor += this.SetColor;

            CtrBase.Dock = DockStyle.Top;
            CtrBase.BtnSettingsClick += this.SetCtrSettings;
            CtrBase.BtnBackClick += this.SetCtrBack;
            CtrBase.Show();

            CtrMain.Dock = DockStyle.Fill;
            CtrMain.Show();

            BackColor = app.Default.color == default ? Color.White : app.Default.color;
            Text = "shutdown-pc - PRAZO MÁXIMO DE AGENDAMENTO: 24 HORAS";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            PnlMain.Controls.Add(CtrMain);
            PnlMain.Controls.Add(CtrSettings);
            PnlMain.Controls.Add(CtrBase);
        }

        public override void OnClosing(FormClosingEventArgs e)
        {
            base.OnClosing(e);

            if (!app.Default.closeToTray)
            {
                Program.Close = true;
                CtrMain.CancelTask();
                Environment.Exit(0);
                return;
            }

            if (Program.Close)
                return;

            e.Cancel = true;
            Hide();
            Program.Tray.SetRunBallonNotification();
        }

        private void SetCtrSettings(object sender, EventArgs e)
        {
            try
            {
                CtrSettings.Show();
                CtrMain.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SetCtrBack(object sender, EventArgs e)
        {
            try
            {
                CtrMain.Show();
                CtrSettings.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SetColor(object sender, EventArgs e)
        {
            try
            {
                BackColor = (Color)sender;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                app.Default.closeToTray = CtrSettings.CkbCloseWithoutTray.Checked;
                app.Default.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}