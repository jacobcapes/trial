namespace trial
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelGame = new System.Windows.Forms.Panel();
            this.TmrCar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PanelGame
            // 
            this.PanelGame.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelGame.Location = new System.Drawing.Point(12, 28);
            this.PanelGame.Name = "PanelGame";
            this.PanelGame.Size = new System.Drawing.Size(682, 410);
            this.PanelGame.TabIndex = 0;
            this.PanelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGame_Paint);
            // 
            // TmrCar
            // 
            this.TmrCar.Enabled = true;
            this.TmrCar.Interval = 50;
            this.TmrCar.Tick += new System.EventHandler(this.TmrCar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelGame);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelGame;
        private System.Windows.Forms.Timer TmrCar;
    }
}

