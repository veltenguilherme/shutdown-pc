using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace shutdown.frontend.Controls
{
    public partial class CtrBase : UserControl
    {
        public EventHandler BtnSettingsClick
        {
            get;
            set;
        }

        public EventHandler BtnBackClick
        {
            get;
            set;
        }

        public CtrBase()
        {
            InitializeComponent();

            FrmMain.CtrSettings.BtnChangeTextColor += this.SetTextColor;
            LblClock.ForeColor = app.Default.textColor;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetClock();
        }

        private void BtnSettings_Click(object sender, System.EventArgs e)
        {
            try
            {
                BtnSettingsClick(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SetClock()
        {
            new Thread(() =>
            {
                while (true)
                {
                    if (LblClock.InvokeRequired)
                        LblClock.Invoke((MethodInvoker)delegate
                        {
                            LblClock.Text = DateTime.Now.ToString();
                        });
                    else
                        LblClock.Text = DateTime.Now.ToString();

                    Thread.Sleep(1000);
                }
            }).Start();
        }

        private void SetTextColor(object sender, EventArgs e)
        {
            try
            {
                LblClock.ForeColor = (Color)sender;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            try
            {
                BtnBackClick(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}