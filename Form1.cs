using SCADA_Lab.Entities;
using System.Windows.Forms;

namespace SCADA_Lab
{
    public partial class Form1 : Form
    {
        Tank tank1;
        public Form1()
        {
            InitializeComponent();
            tank1 = new Tank(16, 230, 20, 7.89, 200, 250, false, false, 11.87, 3.13,
                c_sensorAlarm1, c_sensorAlarm2, c_sensorThreshold, c_sensorHighlevel,
                t_tank, p_waste, p_pump, p_tank, l_level, b_pump, t_events);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            l_key.Text = "Pressed: <" + e.KeyChar.ToString() + "> (" + ((byte)e.KeyChar).ToString() + ")";
            if (e.KeyChar == 27)
            { this.Close(); }
        }

        private void c_power_CheckedChanged(object sender, EventArgs e)
        {
            c_intakeValve1.Checked = c_mainPower.Checked;
            c_intakeValve2.Checked = c_mainPower.Checked;
            //b_pump.Enabled = c_mainPower.Checked;
            c_faucet.Enabled = c_mainPower.Checked;
            if (c_mainPower.Checked)
            {
                c_mainPower.BackColor = Color.Yellow;
                if (!c_intakeValve1.Enabled) c_intakeValve1.Enabled = true;
                if (!c_intakeValve2.Enabled) c_intakeValve2.Enabled = true;
            }
            else
            {
                c_mainPower.BackColor = Color.DarkRed;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tank1.echo("Logging started");
        }

        private void t_tank_Tick(object sender, EventArgs e)
        {
            tank1.Filling = c_faucet.Enabled && c_faucet.Checked;
            tank1.updateLevel();
        }

        private void c_sensorThreshold_CheckedChanged(object sender, EventArgs e)
        {
            tank1.echo("Treshold " + (c_sensorThreshold.Checked ? "Enabled" : "Disabled"));
            //tank1.updateLevel();
        }

        private void c_sensorHighlevel_CheckedChanged(object sender, EventArgs e)
        {
            tank1.echo("HighLevel " + (c_sensorHighlevel.Checked ? "Reached" : "Disabled"));
            //tank1.updateLevel();
        }

        private void c_sensorAlarm1_CheckedChanged(object sender, EventArgs e)
        {
            if (c_sensorAlarm1.Checked || c_sensorAlarm2.Checked)
            {
                if (c_intakeValve1.Checked||c_intakeValve2.Checked)
                {
                    tank1.echo("!!!WARNING!!!  Alarm Level Reached");
                    c_faucet.Enabled = c_faucet.Checked = false;
                    c_intakeValve1.Checked = c_intakeValve1.Enabled = false;
                    tank1.echo("Valve1 Closed. Coil OFF");
                    c_intakeValve2.Checked = c_intakeValve2.Enabled = false;
                    tank1.echo("Valve2 Closed. Coil OFF");
                }
                if (!c_sensorThreshold.Checked) c_sensorThreshold.Checked = true;
                if (!c_sensorHighlevel.Checked) c_sensorHighlevel.Checked = true;
            }
        }
    }
}
