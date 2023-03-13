using shutdown.frontend.Controls;
using shutdown_pc;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace shutdown.frontend
{
    public class Tray
    {
        public NotifyIcon NotifyIcon { get; set; } = new NotifyIcon();
        private FrmMain frm { get; set; }

        public Tray(FrmMain frm) => this.frm = frm;

        public void Run()
        {
            ContextMenuStrip contexMenuStrip = new ContextMenuStrip();
            NotifyIcon = new NotifyIcon();

            contexMenuStrip.Items.AddRange(GetTsmItem());

            NotifyIcon.Icon = Resource.tray;

            NotifyIcon.ContextMenuStrip = contexMenuStrip;
            NotifyIcon.Text = "shutdown-pc";
            NotifyIcon.Visible = true;

            NotifyIcon.DoubleClick += new EventHandler(Tray_DoubleClick);
        }

        public void SetRunBallonNotification(string msg = default)
        {
            NotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            NotifyIcon.BalloonTipText = "Aplicação sendo executada em segundo plano.";
            NotifyIcon.ShowBalloonTip(5000);
        }

        private ToolStripItem[] GetTsmItem()
        {
            List<string> names = new List<string>()
            {
                "Sair"
            };

            ToolStripMenuItem[] arrTsm = new ToolStripMenuItem[names.Count];
            for (int i = 0; i < names.Count; i++)
            {
                var tsm = new ToolStripMenuItem();
                tsm.Tag = i;
                tsm.Text = names[i];
                tsm.Click += new EventHandler(MenuItem_Click);

                arrTsm[i] = tsm;
            }

            return arrTsm;
        }

        private void Close()
        {
            Program.Close = true;
            CtrMain.CancelTask();
            Environment.Exit(0);
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Tag)
            {
                case 0:
                    Close();
                    break;

                default:
                    break;
            }
        }

        private void Tray_DoubleClick(object sender, EventArgs e)
        {
            frm.Show();
            frm.TopMost = true;
        }
    }
}