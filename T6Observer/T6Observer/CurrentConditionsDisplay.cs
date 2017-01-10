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
    public partial class CurrentConditionsDisplay : Form, IObserver, IDisplayElement
    {
        private float _temp;
        private float _humidity;
        private int _pressure;
        private ISubject _subject;

        public CurrentConditionsDisplay(ISubject s)
        {
            InitializeComponent();

            _subject = s;
        }

        public void Display()
        {
            lblTemp.Text = _temp.ToString();
            lblHumidity.Text = _humidity.ToString();
            lblPressure.Text = _pressure.ToString();
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

        public void UpdatePull(WeatherData w)
        {
            w.MeasurementChanged();
            _temp = w.Temp;
            _humidity = w.Humidity;
            _pressure = w.Pressure;
            Display();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            UpdatePull((WeatherData)_subject);
        }
    }
}
