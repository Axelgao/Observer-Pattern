using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T6Observer
{
    public partial class ForecastDisplay : Form, IObserver, IDisplayElement
    {
        private float _temp;
        private float _humidity;
        private int _pressure;
        private ISubject _subject;

        public ForecastDisplay(ISubject s)
        {
            InitializeComponent();

            _subject = s;
        }

        public void Display()
        {
            if(_pressure > 1000)
            {
                lblForecast.Text = "Sunshine";
            }
            else
            {
                lblForecast.Text = "Rain";
            }
        }

        public void Update(float temperature, float humidity, int pressure)
        {
            _temp = temperature;
            _humidity = humidity;
            _pressure = pressure;

            Display();
        }

        private void btnRegisterAsObserver_Click(object sender, EventArgs e)
        {
            _subject.RegisterObserver(this);
        }

        private void btnDeRegisterAsObserver_Click(object sender, EventArgs e)
        {
            _subject.RemoveObserver(this);
        }
    }
}
