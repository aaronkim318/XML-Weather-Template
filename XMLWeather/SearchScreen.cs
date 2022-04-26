using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class SearchScreen : UserControl
    {
        public SearchScreen()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen fs = new CurrentScreen();
            f.Controls.Add(fs);
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.ExtractForecast(textBox1.Text);
                Form1.ExtractCurrent(textBox1.Text);

                Form f = this.FindForm();
                f.Controls.Remove(this);

                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);

            }
            catch
            {
                label5.Text = "ENTER AGAIN";
            }
        
        }
    }
}
