using shutdown_pc;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace shutdown.frontend.Controls
{
    public partial class CtrMain : UserControl
    {
        public bool Scheduled { get; private set; } = false;

        public CtrMain()
        {
            InitializeComponent();

            FrmMain.CtrSettings.BtnChangeTextColor += this.SetTextColor;
            LblClock.ForeColor = app.Default.textColor;
            LblClock.Text = "00:00:00";
        }

        private void ScheduleTask()
        {
            if (Dtt.Value <= DateTime.Now)
                return;

            int seconds = (int)(Dtt.Value - DateTime.Now).TotalSeconds;
            if (seconds <= 0 || seconds > 86400)
                return;

            string parameters = $"/s /f /t {seconds}";
            Process.Start("shutdown", parameters);
            Scheduled = true;
            toolTip1.SetToolTip(btnSchedule, "Cancelar desligamento");
            btnSchedule.Image = Resource.icons8_clock_30__2_;
            Dtt.Enabled = false;
            SetClock();
        }

        private void SetClock()
        {
            new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        TimeSpan ts = (Dtt.Value - DateTime.Now);
                        var date = Convert.ToDateTime(ts.ToString()).ToLongTimeString();

                        if (LblClock.InvokeRequired)
                            LblClock.Invoke((MethodInvoker)delegate
                            {
                                LblClock.Text = date;
                            });
                        else
                            LblClock.Text = date;

                        Thread.Sleep(1000);
                    }
                    catch
                    {
                        CancelTask();
                        if (LblClock.InvokeRequired)
                            LblClock.Invoke((MethodInvoker)delegate
                            {
                                LblClock.Text = "00:00:00";
                            });
                        else
                            LblClock.Text = "00:00:00";

                        if (Dtt.InvokeRequired)
                            Dtt.Invoke((MethodInvoker)delegate
                            {
                                Dtt.Enabled = true;
                                Dtt.Value = DateTime.Now;
                            });
                        else
                        {
                            Dtt.Enabled = true;
                            Dtt.Value = DateTime.Now;
                        }

                        break;
                    }
                }
            }).Start();
        }

        public static void CancelTask() =>
            Process.Start("shutdown", "/a");

        private void StopTask()
        {
            Process.Start("shutdown", "/a");
            Scheduled = false;
            btnSchedule.Image = Resource.icons8_clock_30__1_;
            LblClock.Text = "00:00:00";
            Dtt.Enabled = true;
            Dtt.Value = DateTime.Now;
        }

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Scheduled)
                    ScheduleTask();
                else
                    StopTask();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
    }
}