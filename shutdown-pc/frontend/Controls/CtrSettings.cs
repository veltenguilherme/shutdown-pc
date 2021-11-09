using System;
using System.Windows.Forms;

namespace shutdown.frontend.Controls
{
    public partial class CtrSettings : UserControl
    {
        public EventHandler BtnChangeColor
        {
            get;
            set;
        }

        public EventHandler BtnChangeTextColor
        {
            get;
            set;
        }

        public CtrSettings()
        {
            InitializeComponent();

            CkbCloseWithoutTray.Checked = app.Default.closeToTray;
            CkbCloseWithoutTray.ForeColor = app.Default.textColor;

            LblColors.ForeColor = app.Default.textColor;

            btnChangeColor.ForeColor = app.Default.textColor;
            btnChangeColor.BackColor = app.Default.color;

            btnChangeTextColor.ForeColor = app.Default.color;
            btnChangeTextColor.BackColor = app.Default.textColor;
        }

        private ColorDialog GetColorDialog()
        {
            return new ColorDialog()
            {
                AllowFullOpen = false,
                ShowHelp = true
            };
        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            var dialog = GetColorDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            sender = dialog.Color;
            BtnChangeColor(sender, e);
            btnChangeColor.BackColor = dialog.Color;
            btnChangeTextColor.ForeColor = dialog.Color;

            app.Default.color = dialog.Color;
            app.Default.Save();
        }

        private void BtnChangeTextColor_Click(object sender, EventArgs e)
        {
            var dialog = GetColorDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            sender = dialog.Color;
            CkbCloseWithoutTray.ForeColor = dialog.Color;
            LblColors.ForeColor = dialog.Color;
            btnChangeTextColor.BackColor = dialog.Color;
            btnChangeColor.ForeColor = dialog.Color;
            BtnChangeTextColor(sender, e);

            app.Default.textColor = dialog.Color;
            app.Default.Save();
        }

        private void CkbCloseWithoutTray_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                app.Default.closeToTray = CkbCloseWithoutTray.Checked;
                app.Default.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}