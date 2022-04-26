using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        int icons1;
        int icons2;
        int icons3;
        int icons4;
        int icons5;
        double tempVal;
        string tempString;
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            label2.Text = Form1.days[0].location;

            icons1 = Convert.ToInt32(Form1.days[0].icons);

            date1.Text = Form1.days[1].date;

            tempString = Form1.days[1].tempLow;
            tempVal = Convert.ToDouble(tempString);
            min1.Text = Math.Round(tempVal) + "C";

            tempString = Form1.days[1].tempHigh;
            tempVal = Convert.ToDouble(tempString);
            max1.Text = Math.Round(tempVal) + "C";

            if (icons1 == 800)
            {
                pictureBox1.Image = Properties.Resources.sun;
            }
            else if (icons1 >= 801 && icons1 <= 804)
            {
                pictureBox1.Image = Properties.Resources.scatteredcloudsss;
            }
            else if (icons1 >= 701 && icons1 <= 781)
            {
                pictureBox1.Image = Properties.Resources.mist;
            }
            else if (icons1 >= 600 && icons1 <= 622)
            {
                pictureBox1.Image = Properties.Resources.snow;
            }
            else if (icons1 >= 300 && icons1 <= 531)
            {
                pictureBox1.Image = Properties.Resources.rain;
            }
            else if (icons1 >= 200 && icons1 <= 232)
            {
                pictureBox1.Image = Properties.Resources.thunder;
            }

            icons2 = Convert.ToInt32(Form1.days[2].icons);

            date2.Text = Form1.days[2].date;

            tempString = Form1.days[2].tempLow;
            tempVal = Convert.ToDouble(tempString);
            min2.Text = Math.Round(tempVal) + "C";

            tempString = Form1.days[2].tempHigh;
            tempVal = Convert.ToDouble(tempString);
            max2.Text = Math.Round(tempVal) + "C";

            if (icons2 == 800)
            {
                pictureBox2.Image = Properties.Resources.sun;
            }
            else if (icons2 >= 801 && icons2 <= 804)
            {
                pictureBox2.Image = Properties.Resources.scatteredcloudsss;
            }
            else if (icons2 >= 701 && icons2 <= 781)
            {
                pictureBox2.Image = Properties.Resources.mist;
            }
            else if (icons2 >= 600 && icons2 <= 622)
            {
                pictureBox2.Image = Properties.Resources.snow;
            }
            else if (icons2 >= 300 && icons2 <= 531)
            {
                pictureBox2.Image = Properties.Resources.rain;
            }
            else if (icons2 >= 200 && icons2 <= 232)
            {
                pictureBox2.Image = Properties.Resources.thunder;
            }
            icons3 = Convert.ToInt32(Form1.days[3].icons);
            date3.Text = Form1.days[3].date;

            tempString = Form1.days[3].tempLow;
            tempVal = Convert.ToDouble(tempString);
            min3.Text = Math.Round(tempVal) + "C";

            tempString = Form1.days[3].tempHigh;
            tempVal = Convert.ToDouble(tempString);
            max3.Text = Math.Round(tempVal) + "C";

            if (icons3 == 800)
            {
                pictureBox3.Image = Properties.Resources.sun;
            }
            else if (icons3 >= 801 && icons3 <= 804)
            {
                pictureBox3.Image = Properties.Resources.scatteredcloudsss;
            }
            else if (icons3 >= 701 && icons3 <= 781)
            {
                pictureBox3.Image = Properties.Resources.mist;
            }
            else if (icons3 >= 600 && icons3 <= 622)
            {
                pictureBox3.Image = Properties.Resources.snow;
            }
            else if (icons3 >= 300 && icons3 <= 531)
            {
                pictureBox3.Image = Properties.Resources.rain;
            }
            else if (icons3 >= 200 && icons3 <= 232)
            {
                pictureBox3.Image = Properties.Resources.thunder;
            }
            icons4 = Convert.ToInt32(Form1.days[4].icons);

            date4.Text = Form1.days[4].date;

            tempString = Form1.days[4].tempLow;
            tempVal = Convert.ToDouble(tempString);
            min4.Text = Math.Round(tempVal) + "C";

            tempString = Form1.days[4].tempHigh;
            tempVal = Convert.ToDouble(tempString);
            max4.Text = Math.Round(tempVal) + "C";

            if (icons4 == 800)
            {
                pictureBox4.Image = Properties.Resources.sun;
            }
            else if (icons4 >= 801 && icons4 <= 804)
            {
                pictureBox4.Image = Properties.Resources.scatteredcloudsss;
            }
            else if (icons4 >= 701 && icons4 <= 781)
            {
                pictureBox4.Image = Properties.Resources.mist;
            }
            else if (icons4 >= 600 && icons4 <= 622)
            {
                pictureBox4.Image = Properties.Resources.snow;
            }
            else if (icons4 >= 300 && icons4 <= 531)
            {
                pictureBox4.Image = Properties.Resources.rain;
            }
            else if (icons4 >= 200 && icons4 <= 232)
            {
                pictureBox4.Image = Properties.Resources.thunder;
            }

            icons5 = Convert.ToInt32(Form1.days[5].icons);

            date5.Text = Form1.days[5].date;

            tempString = Form1.days[5].tempHigh;
            tempVal = Convert.ToDouble(tempString);
            max5.Text = Math.Round(tempVal) + "C";

            tempString = Form1.days[5].tempLow;
            tempVal = Convert.ToDouble(tempString);
            min5.Text = Math.Round(tempVal) + "C";

            if (icons5 == 800)
            {
                pictureBox5.Image = Properties.Resources.sun;
            }
            else if (icons5 >= 801 && icons5 <= 804)
            {
                pictureBox5.Image = Properties.Resources.scatteredcloudsss;
            }
            else if (icons5 >= 701 && icons5 <= 781)
            {
                pictureBox5.Image = Properties.Resources.mist;
            }
            else if (icons5 >= 600 && icons5 <= 622)
            {
                pictureBox5.Image = Properties.Resources.snow;
            }
            else if (icons5 >= 300 && icons5 <= 531)
            {
                pictureBox5.Image = Properties.Resources.rain;
            }
            else if (icons5 >= 200 && icons5 <= 232)
            {
                pictureBox5.Image = Properties.Resources.thunder;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen cs = new SearchScreen();
            f.Controls.Add(cs);
        }
    }
}
