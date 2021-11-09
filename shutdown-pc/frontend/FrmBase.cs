using shutdown.frontend.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace shutdown
{
    public partial class FrmBase : Form
    {
        public CtrBase CtrBase { get; set; } = new CtrBase();

        public FrmBase()
        {
            InitializeComponent();

            CtrBase.Dock = DockStyle.Top;
            CtrBase.Show();
        }

        private void OnShown()
        {
            MinimumSize = new Size(Width, Height);
            MaximumSize = new Size(Width, Height);
        }

        public virtual void OnClosing(FormClosingEventArgs e)
        {
        }

        private void FrmBase_Shown(object sender, System.EventArgs e)
        {
            try
            {
                OnShown();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                OnClosing(e);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}