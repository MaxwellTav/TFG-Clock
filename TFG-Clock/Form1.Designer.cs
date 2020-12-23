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
            this.button1 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.VoidUpdate = new System.Windows.Forms.Timer(this.components);
            this.detailTick = new System.Windows.Forms.Timer(this.components);
            this.secondsText = new System.Windows.Forms.Label();
            this.AMPM = new System.Windows.Forms.Label();
            this.detail2 = new System.Windows.Forms.Label();
            this.minutesText = new System.Windows.Forms.Label();
            this.detail1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hoursText
            // 
            this.hoursText.Cursor = System.Windows.Forms.Cursors.Help;
            this.hoursText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoursText.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursText.Location = new System.Drawing.Point(82, 194);
            this.hoursText.Name = "hoursText";
            this.hoursText.Size = new System.Drawing.Size(59, 48);
            this.hoursText.TabIndex = 0;
            this.hoursText.Tag = "hours";
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
            this.panel1.Size = new System.Drawing.Size(809, 21);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(766, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "■";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(787, -1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(22, 22);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 410);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(799, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 400);
            this.panel4.TabIndex = 2;
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
            this.detailTick.Interval = 271;
            this.detailTick.Tick += new System.EventHandler(this.detailTick_Tick);
            // 
            // secondsText
            // 
            this.secondsText.Cursor = System.Windows.Forms.Cursors.Help;
            this.secondsText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondsText.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.secondsText.Location = new System.Drawing.Point(196, 194);
            this.secondsText.Name = "secondsText";
            this.secondsText.Size = new System.Drawing.Size(59, 48);
            this.secondsText.TabIndex = 7;
            this.secondsText.Tag = "seconds";
            this.secondsText.Text = "00";
            this.secondsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AMPM
            // 
            this.AMPM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AMPM.Cursor = System.Windows.Forms.Cursors.Help;
            this.AMPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AMPM.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMPM.Location = new System.Drawing.Point(252, 194);
            this.AMPM.Name = "AMPM";
            this.AMPM.Size = new System.Drawing.Size(59, 48);
            this.AMPM.TabIndex = 6;
            this.AMPM.Tag = "AMPM";
            this.AMPM.Text = "XM";
            this.AMPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detail2
            // 
            this.detail2.Cursor = System.Windows.Forms.Cursors.Help;
            this.detail2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detail2.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail2.Location = new System.Drawing.Point(182, 191);
            this.detail2.Name = "detail2";
            this.detail2.Size = new System.Drawing.Size(23, 48);
            this.detail2.TabIndex = 3;
            this.detail2.Tag = "details";
            this.detail2.Text = ":";
            this.detail2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutesText
            // 
            this.minutesText.Cursor = System.Windows.Forms.Cursors.Help;
            this.minutesText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minutesText.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minutesText.Location = new System.Drawing.Point(141, 194);
            this.minutesText.Name = "minutesText";
            this.minutesText.Size = new System.Drawing.Size(59, 48);
            this.minutesText.TabIndex = 2;
            this.minutesText.Tag = "minutes";
            this.minutesText.Text = "00";
            this.minutesText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // detail1
            // 
            this.detail1.Cursor = System.Windows.Forms.Cursors.Help;
            this.detail1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detail1.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail1.Location = new System.Drawing.Point(127, 191);
            this.detail1.Name = "detail1";
            this.detail1.Size = new System.Drawing.Size(23, 48);
            this.detail1.TabIndex = 1;
            this.detail1.Tag = "details";
            this.detail1.Text = ":";
            this.detail1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkRed;
            this.panel5.Location = new System.Drawing.Point(79, 178);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 10);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkRed;
            this.panel6.Location = new System.Drawing.Point(79, 245);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 10);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkRed;
            this.panel7.Location = new System.Drawing.Point(329, 178);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 77);
            this.panel7.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkRed;
            this.panel8.Location = new System.Drawing.Point(69, 178);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 77);
            this.panel8.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(19, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 48);
            this.label1.TabIndex = 16;
            this.label1.Tag = "seconds";
            this.label1.Text = "00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 48);
            this.label2.TabIndex = 15;
            this.label2.Tag = "AMPM";
            this.label2.Text = "XM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Help;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(212, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 48);
            this.label4.TabIndex = 13;
            this.label4.Tag = "minutes";
            this.label4.Text = "00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Help;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 48);
            this.label6.TabIndex = 11;
            this.label6.Tag = "hours";
            this.label6.Text = "00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Help;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 48);
            this.label3.TabIndex = 17;
            this.label3.Tag = "hours";
            this.label3.Text = "00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Help;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(302, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 48);
            this.label5.TabIndex = 18;
            this.label5.Tag = "minutes";
            this.label5.Text = "00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.Help;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(164, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 48);
            this.label7.TabIndex = 19;
            this.label7.Tag = "seconds";
            this.label7.Text = "00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Cursor = System.Windows.Forms.Cursors.Help;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 48);
            this.label8.TabIndex = 20;
            this.label8.Tag = "AMPM";
            this.label8.Text = "XM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Cursor = System.Windows.Forms.Cursors.Help;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(28, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 48);
            this.label10.TabIndex = 27;
            this.label10.Tag = "seconds";
            this.label10.Text = "00";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Cursor = System.Windows.Forms.Cursors.Help;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(19, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 48);
            this.label11.TabIndex = 26;
            this.label11.Tag = "minutes";
            this.label11.Text = "00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Cursor = System.Windows.Forms.Cursors.Help;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(287, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 48);
            this.label12.TabIndex = 25;
            this.label12.Tag = "hours";
            this.label12.Text = "00";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Cursor = System.Windows.Forms.Cursors.Help;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(311, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 48);
            this.label13.TabIndex = 24;
            this.label13.Tag = "seconds";
            this.label13.Text = "00";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Cursor = System.Windows.Forms.Cursors.Help;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(243, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 48);
            this.label14.TabIndex = 23;
            this.label14.Tag = "AMPM";
            this.label14.Text = "XM";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Cursor = System.Windows.Forms.Cursors.Help;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(138, 354);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 48);
            this.label16.TabIndex = 21;
            this.label16.Tag = "hours";
            this.label16.Text = "00";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Cursor = System.Windows.Forms.Cursors.Help;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(117, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 48);
            this.label9.TabIndex = 28;
            this.label9.Tag = "minutes";
            this.label9.Text = "00";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Cursor = System.Windows.Forms.Cursors.Help;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(107, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 48);
            this.label15.TabIndex = 29;
            this.label15.Tag = "seconds";
            this.label15.Text = "00";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Cursor = System.Windows.Forms.Cursors.Help;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(163, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 48);
            this.label17.TabIndex = 30;
            this.label17.Tag = "details";
            this.label17.Text = ":";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Cursor = System.Windows.Forms.Cursors.Help;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(98, 271);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 48);
            this.label18.TabIndex = 31;
            this.label18.Tag = "details";
            this.label18.Text = ":";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Cursor = System.Windows.Forms.Cursors.Help;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(273, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 48);
            this.label19.TabIndex = 32;
            this.label19.Tag = "details";
            this.label19.Text = ":";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 431);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondsText);
            this.Controls.Add(this.AMPM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detail2);
            this.Controls.Add(this.minutesText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.detail1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.hoursText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reloj";
            this.Load += new System.EventHandler(this.Index_Load);
            this.panel1.ResumeLayout(false);
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
        public System.Windows.Forms.Label AMPM;
        public System.Windows.Forms.Label detail2;
        public System.Windows.Forms.Label minutesText;
        public System.Windows.Forms.Label detail1;
        public System.Windows.Forms.Label secondsText;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
    }
}

