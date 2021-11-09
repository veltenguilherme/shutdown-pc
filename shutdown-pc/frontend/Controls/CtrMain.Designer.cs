
namespace shutdown.frontend.Controls
{
    partial class CtrMain
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dtt = new System.Windows.Forms.DateTimePicker();
            this.LblClock = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSchedule
            // 
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Image = global::shutdown_pc.Resource.icons8_clock_30__1_;
            this.btnSchedule.Location = new System.Drawing.Point(0, 0);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnSchedule.Size = new System.Drawing.Size(31, 25);
            this.btnSchedule.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnSchedule, "Agendar desligamento");
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.BtnSchedule_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Dtt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 25);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSchedule);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(125, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 25);
            this.panel2.TabIndex = 9;
            // 
            // Dtt
            // 
            this.Dtt.AllowDrop = true;
            this.Dtt.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.Dtt.Dock = System.Windows.Forms.DockStyle.Left;
            this.Dtt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtt.Location = new System.Drawing.Point(0, 0);
            this.Dtt.Name = "Dtt";
            this.Dtt.ShowUpDown = true;
            this.Dtt.Size = new System.Drawing.Size(125, 23);
            this.Dtt.TabIndex = 5;
            // 
            // LblClock
            // 
            this.LblClock.AutoSize = true;
            this.LblClock.Font = new System.Drawing.Font("Segoe UI", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblClock.Location = new System.Drawing.Point(26, 14);
            this.LblClock.Name = "LblClock";
            this.LblClock.Size = new System.Drawing.Size(484, 159);
            this.LblClock.TabIndex = 8;
            this.LblClock.Text = "lblClock";
            this.LblClock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CtrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblClock);
            this.Name = "CtrMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(582, 185);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Dtt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblClock;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
