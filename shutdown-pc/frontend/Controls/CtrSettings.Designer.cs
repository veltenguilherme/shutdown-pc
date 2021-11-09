
namespace shutdown.frontend.Controls
{
    partial class CtrSettings
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
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeTextColor = new System.Windows.Forms.Button();
            this.LblColors = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.CkbCloseWithoutTray = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChangeColor.FlatAppearance.BorderSize = 0;
            this.btnChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeColor.Location = new System.Drawing.Point(65, 0);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(75, 31);
            this.btnChangeColor.TabIndex = 3;
            this.btnChangeColor.Text = "Primária";
            this.toolTip1.SetToolTip(this.btnChangeColor, "Clique para alterar a cor primária");
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.BtnChangeColor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangeTextColor);
            this.panel1.Controls.Add(this.btnChangeColor);
            this.panel1.Controls.Add(this.LblColors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 31);
            this.panel1.TabIndex = 3;
            // 
            // btnChangeTextColor
            // 
            this.btnChangeTextColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChangeTextColor.FlatAppearance.BorderSize = 0;
            this.btnChangeTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTextColor.Location = new System.Drawing.Point(140, 0);
            this.btnChangeTextColor.Name = "btnChangeTextColor";
            this.btnChangeTextColor.Size = new System.Drawing.Size(75, 31);
            this.btnChangeTextColor.TabIndex = 6;
            this.btnChangeTextColor.Text = "Secundária";
            this.toolTip1.SetToolTip(this.btnChangeTextColor, "Clique para alterar a cor secundária");
            this.btnChangeTextColor.UseVisualStyleBackColor = true;
            this.btnChangeTextColor.Click += new System.EventHandler(this.BtnChangeTextColor_Click);
            // 
            // LblColors
            // 
            this.LblColors.AutoSize = true;
            this.LblColors.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblColors.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblColors.Location = new System.Drawing.Point(0, 0);
            this.LblColors.Name = "LblColors";
            this.LblColors.Size = new System.Drawing.Size(65, 28);
            this.LblColors.TabIndex = 5;
            this.LblColors.Text = "Cores:";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.CkbCloseWithoutTray);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 34);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.pnlTop.Size = new System.Drawing.Size(541, 31);
            this.pnlTop.TabIndex = 4;
            // 
            // CkbCloseWithoutTray
            // 
            this.CkbCloseWithoutTray.AutoSize = true;
            this.CkbCloseWithoutTray.Dock = System.Windows.Forms.DockStyle.Left;
            this.CkbCloseWithoutTray.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CkbCloseWithoutTray.Location = new System.Drawing.Point(6, 0);
            this.CkbCloseWithoutTray.Name = "CkbCloseWithoutTray";
            this.CkbCloseWithoutTray.Size = new System.Drawing.Size(345, 31);
            this.CkbCloseWithoutTray.TabIndex = 1;
            this.CkbCloseWithoutTray.Text = "Botão de fechar minimiza na bandeja";
            this.CkbCloseWithoutTray.UseVisualStyleBackColor = true;
            this.CkbCloseWithoutTray.CheckedChanged += new System.EventHandler(this.CkbCloseWithoutTray_CheckedChanged);
            // 
            // CtrSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel1);
            this.Name = "CtrSettings";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(547, 127);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblColors;
        private System.Windows.Forms.Button btnChangeTextColor;
        private System.Windows.Forms.Panel pnlTop;
        public System.Windows.Forms.CheckBox CkbCloseWithoutTray;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
