using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast("Stratford");
            ExtractCurrent("Stratford, CA");

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast(string place)
        {
            //clears the days list
            days.Clear();

            //gets information from api
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=" + place +
                ",CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");
            while (reader.Read())
            {
                // create a day object
                Day newDay = new Day();
                // fill day object with required data
                reader.ReadToFollowing("time");
                newDay.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                newDay.icons = reader.GetAttribute("number");

                reader.ReadToFollowing("temperature");
                newDay.tempLow = reader.GetAttribute("min");
                newDay.tempHigh = reader.GetAttribute("max");

                // if day object not null add to the days list
                if (newDay.date != null)
                {
                    days.Add(newDay);
                }
            }
        }

        public static void ExtractCurrent(string place)
        {
            // allows you to search a certain city. You will be able to see accurate weather information at that certain place
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=" + place +
                 ",CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");
            //finds the city and current conditions and temperature and adds to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].icons = reader.GetAttribute("number");
            days[0].condition = reader.GetAttribute("value");
        }
    }
}
