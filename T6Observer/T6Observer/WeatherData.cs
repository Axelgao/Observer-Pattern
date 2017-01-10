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
    public partial class WeatherData : Form, ISubject
    {
        private float _temp;
        private float _humidity;
        private int _pressure;

        private List<IObserver> _observers = new List<IObserver>();

        public WeatherData()
        {
            InitializeComponent();

            CurrentConditionsDisplay ccd = new CurrentConditionsDisplay(this);
            ccd.Show();
            ForecastDisplay fd = new ForecastDisplay(this);
            fd.Show();
            StatisticsDisplay sd = new StatisticsDisplay(this);
            sd.Show();
        }

        public float Temp
        {
            get
            {
                return _temp;
            }

            set
            {
                _temp = value;
            }
        }

        public float Humidity
        {
            get
            {
                return _humidity;
            }

            set
            {
                _humidity = value;
            }
        }

        public int Pressure
        {
            get
            {
                return _pressure;
            }

            set
            {
                _pressure = value;
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in _observers)
            {
                o.Update(Temp, Humidity, Pressure);
            }
                
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void MeasurementChanged()
        {
            float.TryParse(txtTemp.Text, out _temp);
            float.TryParse(txtHumidity.Text, out _humidity);
            int.TryParse(txtPressure.Text, out _pressure);

            NotifyObservers();
        }

        private void txtTemp_Leave(object sender, EventArgs e)
        {
            MeasurementChanged();
        }

        private void txtHumidity_Leave(object sender, EventArgs e)
        {
            MeasurementChanged();
        }

        private void txtPressure_Leave(object sender, EventArgs e)
        {
            MeasurementChanged();
        }
    }
}
