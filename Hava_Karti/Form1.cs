using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hava_Karti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string api = "14ad2aba611dbef9c504b82a127794c5";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument hava = XDocument.Load(connection);
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var ruzgar = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var nem = hava.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            var durum = hava.Descendants("weather").ElementAt(0).Attribute("value").Value;







            label2.Text = DateTime.Now.ToShortDateString();


            label4.Text = sicaklik.ToString();
            label13.Text = sicaklik.ToString();
            label7.Text = ruzgar + " m/s";
            label8.Text = nem + " %";
            label10.Text = durum;
            //durum = "bulutlu";

            if (durum == "açık")
            {
                pictureBox1.ImageLocation = @"C:\Users\14may\Desktop\sun-weather-sunny-rays-sunshine-116041.png";
            }
            if (durum == "bulutlu")
            {
                pictureBox1.ImageLocation = @"C:\Users\14may\Desktop\clouds-cloudy-overcast-weather-101107.png";
            }
        }
    }
}
