﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        string temp1;
        double temp;
        int icons;
        int converted;
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //ges the date of the first day
            currentDate.Text = Form1.days[0].date;
            //converts days icons strong into an int for reading the conditions of the weather
            converted = Convert.ToInt32(Form1.days[0].icons);
            icons = converted;

            cityOutput.Text = Form1.days[0].location;
            //gets the values of the min , max , and average temp and rounds them to the whole number
            temp1 = Form1.days[0].currentTemp;
            temp = Convert.ToDouble(temp1);
            tempLabel.Text = Math.Round(temp) + " C";

            temp1 = Form1.days[0].tempLow;
            temp = Convert.ToDouble(temp1);
            minLabel.Text = Math.Round(temp) + " C";

            temp1 = Form1.days[0].tempHigh;
            temp = Convert.ToDouble(temp1);
            maxLabel.Text = Math.Round(temp) + " C";

            //if the icons value is a certain conditon, change the picture to the desired one
            if (icons == 800)
            {
                pictureBox6.Image = Properties.Resources.sun;
                BackColor = Color.LightBlue;
            }
            if (icons >= 801 && icons <= 804)
            {
                pictureBox6.Image = Properties.Resources.scatteredcloudsss;
                BackColor = Color.LightGray;
            }
            if (icons >= 701 && icons <= 781)
            {
                pictureBox6.Image = Properties.Resources.mist;
                BackColor = Color.Khaki;
            }
            if (icons >= 600 && icons <= 622)
            {
                pictureBox6.Image = Properties.Resources.snow;
                BackColor = Color.White;
            }
            if (icons >= 300 && icons <= 531)
            {
                pictureBox6.Image = Properties.Resources.rain;
                BackColor = Color.RoyalBlue;
            }
            if (icons >= 200 && icons <= 232)
            {
                pictureBox6.Image = Properties.Resources.thunder;
                BackColor = Color.DarkBlue;
            }
            //displays the condition of the day
            conditionLabel.Text = Form1.days[0].condition;
        }
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen fs = new SearchScreen();
            f.Controls.Add(fs);
        }

        private void tempLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}

