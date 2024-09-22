using System.Windows.Forms;

namespace SCADA_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = e.KeyChar.ToString() + "(" + ((byte)e.KeyChar).ToString() + ")";
            //bar.Value = e.KeyChar;
            //progressBar2.Value = bar.Value;
            if (e.KeyChar == 27)
            { this.Close(); }
            //pictureBox1.Image = Properties.Resources.water_surface;
            //pictureBox1.Show();

        }
    }
}
