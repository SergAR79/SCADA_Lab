namespace SCADA_Lab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            l_key = new Label();
            p_tank = new PictureBox();
            p_waste = new PictureBox();
            c_sensorAlarm1 = new CheckBox();
            panel1 = new Panel();
            b_pump = new Button();
            l_pump = new Label();
            l_valve = new Label();
            l_over = new Label();
            l_notempty = new Label();
            l_empty = new Label();
            c_mainPower = new CheckBox();
            c_intakeValve1 = new CheckBox();
            c_intakeValve2 = new CheckBox();
            p_pump = new PictureBox();
            c_sensorThreshold = new CheckBox();
            c_sensorAlarm2 = new CheckBox();
            p_pipeH = new PictureBox();
            panel_sink = new Panel();
            c_faucet = new CheckBox();
            p_sink = new PictureBox();
            l_level = new Label();
            t_tank = new System.Windows.Forms.Timer(components);
            t_events = new TextBox();
            c_sensorHighlevel = new CheckBox();
            t_hmi = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)p_tank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_waste).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)p_pump).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_pipeH).BeginInit();
            panel_sink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)p_sink).BeginInit();
            SuspendLayout();
            // 
            // l_key
            // 
            l_key.AutoSize = true;
            l_key.Location = new Point(347, 9);
            l_key.Name = "l_key";
            l_key.Size = new Size(110, 15);
            l_key.TabIndex = 1;
            l_key.Text = "Press <Esc> for exit";
            // 
            // p_tank
            // 
            p_tank.BackColor = Color.Transparent;
            p_tank.Image = Properties.Resources.tank250lt;
            p_tank.Location = new Point(281, 213);
            p_tank.Name = "p_tank";
            p_tank.Size = new Size(315, 193);
            p_tank.SizeMode = PictureBoxSizeMode.StretchImage;
            p_tank.TabIndex = 3;
            p_tank.TabStop = false;
            // 
            // p_waste
            // 
            p_waste.Image = Properties.Resources.water_surface;
            p_waste.Location = new Point(334, 381);
            p_waste.Name = "p_waste";
            p_waste.Size = new Size(202, 25);
            p_waste.SizeMode = PictureBoxSizeMode.StretchImage;
            p_waste.TabIndex = 4;
            p_waste.TabStop = false;
            // 
            // c_sensorAlarm1
            // 
            c_sensorAlarm1.BackgroundImage = Properties.Resources.Side_Magnetic_PP_Float_Water_Liquid_Level_Sensor;
            c_sensorAlarm1.BackgroundImageLayout = ImageLayout.Stretch;
            c_sensorAlarm1.CheckAlign = ContentAlignment.BottomRight;
            c_sensorAlarm1.Cursor = Cursors.Hand;
            c_sensorAlarm1.Image = Properties.Resources.Side_Magnetic_PP_Float_Water_Liquid_Level_Sensor;
            c_sensorAlarm1.Location = new Point(589, 233);
            c_sensorAlarm1.Name = "c_sensorAlarm1";
            c_sensorAlarm1.Size = new Size(46, 29);
            c_sensorAlarm1.TabIndex = 6;
            c_sensorAlarm1.TabStop = false;
            c_sensorAlarm1.Text = "checkBox1";
            c_sensorAlarm1.TextImageRelation = TextImageRelation.TextAboveImage;
            c_sensorAlarm1.UseVisualStyleBackColor = true;
            c_sensorAlarm1.CheckedChanged += c_sensorAlarm1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(b_pump);
            panel1.Controls.Add(l_pump);
            panel1.Controls.Add(l_valve);
            panel1.Controls.Add(l_over);
            panel1.Controls.Add(l_notempty);
            panel1.Controls.Add(l_empty);
            panel1.Location = new Point(588, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 75);
            panel1.TabIndex = 8;
            // 
            // b_pump
            // 
            b_pump.BackgroundImage = Properties.Resources.ButtonOFF;
            b_pump.BackgroundImageLayout = ImageLayout.Stretch;
            b_pump.FlatStyle = FlatStyle.Popup;
            b_pump.Location = new Point(0, 0);
            b_pump.Name = "b_pump";
            b_pump.Size = new Size(37, 27);
            b_pump.TabIndex = 8;
            b_pump.TabStop = false;
            b_pump.UseVisualStyleBackColor = true;
            // 
            // l_pump
            // 
            l_pump.BackColor = Color.Black;
            l_pump.Dock = DockStyle.Bottom;
            l_pump.Font = new Font("Morphin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            l_pump.ForeColor = Color.Yellow;
            l_pump.Location = new Point(0, 0);
            l_pump.Name = "l_pump";
            l_pump.Size = new Size(200, 15);
            l_pump.TabIndex = 4;
            l_pump.Text = "ОТБОР";
            l_pump.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_valve
            // 
            l_valve.BackColor = Color.Black;
            l_valve.Dock = DockStyle.Bottom;
            l_valve.Font = new Font("Morphin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            l_valve.ForeColor = Color.Orange;
            l_valve.Location = new Point(0, 15);
            l_valve.Name = "l_valve";
            l_valve.Size = new Size(200, 15);
            l_valve.TabIndex = 3;
            l_valve.Text = "КЛАПАН";
            l_valve.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_over
            // 
            l_over.BackColor = Color.Black;
            l_over.Dock = DockStyle.Bottom;
            l_over.Font = new Font("Morphin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            l_over.ForeColor = Color.Red;
            l_over.Location = new Point(0, 30);
            l_over.Name = "l_over";
            l_over.Size = new Size(200, 15);
            l_over.TabIndex = 2;
            l_over.Text = "ПЕРЕПОЛНЕНИЕ";
            l_over.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_notempty
            // 
            l_notempty.BackColor = Color.Black;
            l_notempty.Dock = DockStyle.Bottom;
            l_notempty.Font = new Font("Morphin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            l_notempty.ForeColor = Color.GreenYellow;
            l_notempty.Location = new Point(0, 45);
            l_notempty.Name = "l_notempty";
            l_notempty.Size = new Size(200, 15);
            l_notempty.TabIndex = 1;
            l_notempty.Text = "НЕ";
            l_notempty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_empty
            // 
            l_empty.BackColor = Color.Black;
            l_empty.Dock = DockStyle.Bottom;
            l_empty.Font = new Font("Morphin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            l_empty.ForeColor = Color.DeepSkyBlue;
            l_empty.Location = new Point(0, 60);
            l_empty.Name = "l_empty";
            l_empty.Size = new Size(200, 15);
            l_empty.TabIndex = 0;
            l_empty.Text = "ПУСТО";
            l_empty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // c_mainPower
            // 
            c_mainPower.AutoSize = true;
            c_mainPower.BackColor = Color.DarkRed;
            c_mainPower.Checked = true;
            c_mainPower.CheckState = CheckState.Checked;
            c_mainPower.ForeColor = Color.Coral;
            c_mainPower.Location = new Point(12, 12);
            c_mainPower.Name = "c_mainPower";
            c_mainPower.Size = new Size(89, 34);
            c_mainPower.TabIndex = 0;
            c_mainPower.TabStop = false;
            c_mainPower.Text = "Main Power\n Switch";
            c_mainPower.UseVisualStyleBackColor = false;
            c_mainPower.CheckedChanged += c_power_CheckedChanged;
            // 
            // c_intakeValve1
            // 
            c_intakeValve1.AutoCheck = false;
            c_intakeValve1.BackColor = Color.DarkRed;
            c_intakeValve1.BackgroundImage = Properties.Resources.intake;
            c_intakeValve1.BackgroundImageLayout = ImageLayout.Stretch;
            c_intakeValve1.CheckAlign = ContentAlignment.TopRight;
            c_intakeValve1.Checked = true;
            c_intakeValve1.CheckState = CheckState.Checked;
            c_intakeValve1.ForeColor = Color.Coral;
            c_intakeValve1.Location = new Point(0, 213);
            c_intakeValve1.Name = "c_intakeValve1";
            c_intakeValve1.Size = new Size(71, 49);
            c_intakeValve1.TabIndex = 9;
            c_intakeValve1.TabStop = false;
            c_intakeValve1.UseVisualStyleBackColor = false;
            // 
            // c_intakeValve2
            // 
            c_intakeValve2.AutoCheck = false;
            c_intakeValve2.BackColor = Color.DarkRed;
            c_intakeValve2.BackgroundImage = Properties.Resources.intake;
            c_intakeValve2.BackgroundImageLayout = ImageLayout.Stretch;
            c_intakeValve2.CheckAlign = ContentAlignment.TopRight;
            c_intakeValve2.Checked = true;
            c_intakeValve2.CheckState = CheckState.Checked;
            c_intakeValve2.ForeColor = Color.Coral;
            c_intakeValve2.Location = new Point(0, 268);
            c_intakeValve2.Name = "c_intakeValve2";
            c_intakeValve2.Size = new Size(71, 49);
            c_intakeValve2.TabIndex = 9;
            c_intakeValve2.TabStop = false;
            c_intakeValve2.UseVisualStyleBackColor = false;
            // 
            // p_pump
            // 
            p_pump.BackgroundImage = Properties.Resources.pumpRstopped;
            p_pump.BackgroundImageLayout = ImageLayout.Stretch;
            p_pump.Location = new Point(696, 302);
            p_pump.Name = "p_pump";
            p_pump.Size = new Size(107, 106);
            p_pump.SizeMode = PictureBoxSizeMode.StretchImage;
            p_pump.TabIndex = 10;
            p_pump.TabStop = false;
            // 
            // c_sensorThreshold
            // 
            c_sensorThreshold.BackgroundImage = Properties.Resources.Side_Magnetic_PP_Float_Water_Liquid_Level_Sensor;
            c_sensorThreshold.BackgroundImageLayout = ImageLayout.Stretch;
            c_sensorThreshold.CheckAlign = ContentAlignment.BottomRight;
            c_sensorThreshold.Cursor = Cursors.Hand;
            c_sensorThreshold.Image = Properties.Resources.Side_Magnetic_PP_Float_Water_Liquid_Level_Sensor;
            c_sensorThreshold.Location = new Point(589, 355);
            c_sensorThreshold.Name = "c_sensorThreshold";
            c_sensorThreshold.Size = new Size(46, 29);
            c_sensorThreshold.TabIndex = 6;
            c_sensorThreshold.TabStop = false;
            c_sensorThreshold.Text = "checkBox1";
            c_sensorThreshold.TextImageRelation = TextImageRelation.TextAboveImage;
            c_sensorThreshold.UseVisualStyleBackColor = true;
            c_sensorThreshold.CheckedChanged += c_sensorThreshold_CheckedChanged;
            // 
            // c_sensorAlarm2
            // 
            c_sensorAlarm2.BackgroundImage = Properties.Resources.Side_Magnetic_PP_Float_Water_Liquid_Level_Sensor;
            c_sensorAlarm2.BackgroundImageLayout = ImageLayout.Stretch;
            c_sensorAlarm2.CheckAlign = ContentAlignment.BottomRight;
            c_sensorAlarm2.Cursor = Cursors.Hand;
            c_sensorAlarm2.Image = Properties.Resources.Side_Magnetic_PP_Float_Water_Liquid_Level_Sensor;
            c_sensorAlarm2.Location = new Point(632, 233);
            c_sensorAlarm2.Name = "c_sensorAlarm2";
            c_sensorAlarm2.Size = new Size(46, 29);
            c_sensorAlarm2.TabIndex = 6;
            c_sensorAlarm2.TabStop = false;
            c_sensorAlarm2.Text = "checkBox1";
            c_sensorAlarm2.TextImageRelation = TextImageRelation.TextAboveImage;
            c_sensorAlarm2.UseVisualStyleBackColor = true;
            c_sensorAlarm2.CheckedChanged += c_sensorAlarm1_CheckedChanged;
            // 
            // p_pipeH
            // 
            p_pipeH.BackgroundImage = Properties.Resources.pipeH;
            p_pipeH.BackgroundImageLayout = ImageLayout.Stretch;
            p_pipeH.Location = new Point(580, 388);
            p_pipeH.Name = "p_pipeH";
            p_pipeH.Size = new Size(128, 18);
            p_pipeH.TabIndex = 11;
            p_pipeH.TabStop = false;
            // 
            // panel_sink
            // 
            panel_sink.AutoSize = true;
            panel_sink.Controls.Add(c_faucet);
            panel_sink.Controls.Add(p_sink);
            panel_sink.Location = new Point(77, 85);
            panel_sink.Name = "panel_sink";
            panel_sink.Size = new Size(210, 323);
            panel_sink.TabIndex = 12;
            // 
            // c_faucet
            // 
            c_faucet.AutoSize = true;
            c_faucet.Checked = true;
            c_faucet.CheckState = CheckState.Checked;
            c_faucet.Location = new Point(3, 3);
            c_faucet.Name = "c_faucet";
            c_faucet.Size = new Size(53, 19);
            c_faucet.TabIndex = 5;
            c_faucet.TabStop = false;
            c_faucet.Text = "Кран";
            c_faucet.UseVisualStyleBackColor = true;
            // 
            // p_sink
            // 
            p_sink.BackColor = Color.Transparent;
            p_sink.BackgroundImage = Properties.Resources.sink;
            p_sink.BackgroundImageLayout = ImageLayout.Stretch;
            p_sink.Location = new Point(0, 0);
            p_sink.Name = "p_sink";
            p_sink.Size = new Size(207, 320);
            p_sink.SizeMode = PictureBoxSizeMode.StretchImage;
            p_sink.TabIndex = 4;
            p_sink.TabStop = false;
            // 
            // l_level
            // 
            l_level.AutoSize = true;
            l_level.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            l_level.Location = new Point(602, 302);
            l_level.Name = "l_level";
            l_level.Size = new Size(55, 36);
            l_level.TabIndex = 1;
            l_level.Text = "10L";
            // 
            // t_tank
            // 
            t_tank.Enabled = true;
            t_tank.Interval = 111;
            t_tank.Tick += t_tank_Tick;
            // 
            // t_events
            // 
            t_events.BackColor = Color.Black;
            t_events.Dock = DockStyle.Bottom;
            t_events.ForeColor = Color.Green;
            t_events.Location = new Point(0, 414);
            t_events.Multiline = true;
            t_events.Name = "t_events";
            t_events.ReadOnly = true;
            t_events.ScrollBars = ScrollBars.Vertical;
            t_events.Size = new Size(800, 102);
            t_events.TabIndex = 13;
            t_events.TabStop = false;
            t_events.Text = "Events log";
            t_events.WordWrap = false;
            // 
            // c_sensorHighlevel
            // 
            c_sensorHighlevel.BackgroundImage = Properties.Resources.Side_Magnetic_PP_Float_Water_Liquid_Level_Sensor;
            c_sensorHighlevel.BackgroundImageLayout = ImageLayout.Stretch;
            c_sensorHighlevel.CheckAlign = ContentAlignment.BottomRight;
            c_sensorHighlevel.Cursor = Cursors.Hand;
            c_sensorHighlevel.Image = Properties.Resources.Side_Magnetic_PP_Float_Water_Liquid_Level_Sensor;
            c_sensorHighlevel.Location = new Point(589, 268);
            c_sensorHighlevel.Name = "c_sensorHighlevel";
            c_sensorHighlevel.Size = new Size(46, 29);
            c_sensorHighlevel.TabIndex = 6;
            c_sensorHighlevel.TabStop = false;
            c_sensorHighlevel.Text = "checkBox1";
            c_sensorHighlevel.TextImageRelation = TextImageRelation.TextAboveImage;
            c_sensorHighlevel.UseVisualStyleBackColor = true;
            c_sensorHighlevel.CheckedChanged += c_sensorHighlevel_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(t_events);
            Controls.Add(panel_sink);
            Controls.Add(p_pipeH);
            Controls.Add(c_intakeValve2);
            Controls.Add(c_intakeValve1);
            Controls.Add(c_mainPower);
            Controls.Add(panel1);
            Controls.Add(c_sensorHighlevel);
            Controls.Add(c_sensorThreshold);
            Controls.Add(c_sensorAlarm2);
            Controls.Add(c_sensorAlarm1);
            Controls.Add(p_waste);
            Controls.Add(p_tank);
            Controls.Add(l_level);
            Controls.Add(l_key);
            Controls.Add(p_pump);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)p_tank).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_waste).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)p_pump).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_pipeH).EndInit();
            panel_sink.ResumeLayout(false);
            panel_sink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)p_sink).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_key;
        private PictureBox p_tank;
        private PictureBox p_waste;
        private CheckBox c_sensorAlarm1;
        private Panel panel1;
        private Label l_notempty;
        private Label l_empty;
        private Label l_pump;
        private Label l_valve;
        private Label l_over;
        private CheckBox c_mainPower;
        private CheckBox c_intakeValve1;
        private CheckBox c_intakeValve2;
        private PictureBox p_pump;
        private CheckBox c_sensorThreshold;
        private CheckBox c_sensorAlarm2;
        private PictureBox p_pipeH;
        private Panel panel_sink;
        private PictureBox p_sink;
        private CheckBox c_faucet;
        private Label l_level;
        private System.Windows.Forms.Timer t_tank;
        private CheckBox c_sensorHighlevel;
        private Button b_pump;
        private System.Windows.Forms.Timer t_hmi;
        public TextBox t_events;
    }
}
