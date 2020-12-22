namespace TFG_Clock
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hoursText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.VoidUpdate = new System.Windows.Forms.Timer(this.components);
            this.detailTick = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.detail1 = new System.Windows.Forms.Label();
            this.minutesText = new System.Windows.Forms.Label();
            this.detail2 = new System.Windows.Forms.Label();
            this.AMPM = new System.Windows.Forms.Label();
            this.secondsText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // hoursText
            // 
            this.hoursText.Cursor = System.Windows.Forms.Cursors.Help;
            this.hoursText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoursText.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursText.Location = new System.Drawing.Point(-7, 12);
            this.hoursText.Name = "hoursText";
            this.hoursText.Size = new System.Drawing.Size(59, 48);
            this.hoursText.TabIndex = 0;
            this.hoursText.Text = "00";
            this.hoursText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 21);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 290);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(571, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 280);
            this.panel4.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(559, -1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(22, 22);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(538, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "■";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VoidUpdate
            // 
            this.VoidUpdate.Enabled = true;
            this.VoidUpdate.Interval = 1000;
            this.VoidUpdate.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // detailTick
            // 
            this.detailTick.Enabled = true;
            this.detailTick.Interval = 376;
            this.detailTick.Tick += new System.EventHandler(this.detailTick_Tick);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.secondsText);
            this.panel5.Controls.Add(this.AMPM);
            this.panel5.Controls.Add(this.detail2);
            this.panel5.Controls.Add(this.minutesText);
            this.panel5.Controls.Add(this.detail1);
            this.panel5.Controls.Add(this.hoursText);
            this.panel5.Location = new System.Drawing.Point(16, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 73);
            this.panel5.TabIndex = 3;
            // 
            // detail1
            // 
            this.detail1.Cursor = System.Windows.Forms.Cursors.Help;
            this.detail1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detail1.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail1.Location = new System.Drawing.Point(38, 9);
            this.detail1.Name = "detail1";
            this.detail1.Size = new System.Drawing.Size(23, 48);
            this.detail1.TabIndex = 1;
            this.detail1.Text = ":";
            this.detail1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutesText
            // 
            this.minutesText.Cursor = System.Windows.Forms.Cursors.Help;
            this.minutesText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minutesText.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minutesText.Location = new System.Drawing.Point(52, 12);
            this.minutesText.Name = "minutesText";
            this.minutesText.Size = new System.Drawing.Size(59, 48);
            this.minutesText.TabIndex = 2;
            this.minutesText.Text = "00";
            this.minutesText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // detail2
            // 
            this.detail2.Cursor = System.Windows.Forms.Cursors.Help;
            this.detail2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detail2.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail2.Location = new System.Drawing.Point(93, 9);
            this.detail2.Name = "detail2";
            this.detail2.Size = new System.Drawing.Size(23, 48);
            this.detail2.TabIndex = 3;
            this.detail2.Text = ":";
            this.detail2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AMPM
            // 
            this.AMPM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AMPM.Cursor = System.Windows.Forms.Cursors.Help;
            this.AMPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AMPM.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMPM.Location = new System.Drawing.Point(163, 12);
            this.AMPM.Name = "AMPM";
            this.AMPM.Size = new System.Drawing.Size(59, 48);
            this.AMPM.TabIndex = 6;
            this.AMPM.Text = "XM";
            this.AMPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondsText
            // 
            this.secondsText.Cursor = System.Windows.Forms.Cursors.Help;
            this.secondsText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondsText.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.secondsText.Location = new System.Drawing.Point(107, 12);
            this.secondsText.Name = "secondsText";
            this.secondsText.Size = new System.Drawing.Size(59, 48);
            this.secondsText.TabIndex = 7;
            this.secondsText.Text = "00";
            this.secondsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 311);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reloj";
            this.Load += new System.EventHandler(this.Index_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label hoursText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Timer VoidUpdate;
        public System.Windows.Forms.Timer detailTick;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label AMPM;
        public System.Windows.Forms.Label detail2;
        public System.Windows.Forms.Label minutesText;
        public System.Windows.Forms.Label detail1;
        public System.Windows.Forms.Label secondsText;
    }
}

