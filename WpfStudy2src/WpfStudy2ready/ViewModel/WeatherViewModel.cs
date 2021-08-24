using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Threading;

namespace WpfStudy2ready.ViewModel
{
    public class WeatherViewModel : ViewModelBase
    {
        private bool _isFine = false;
        public bool IsFine
        {
            get
            {
                return _isFine;
            }
            set
            {
                if (_isFine != value)
                {
                    _isFine = value;
                    OnPropertyChanged(nameof(IsFine)); // nameof演算子で文字列リテラルを取得できるので使うと便利
                }
            }
        }

        private double _humidity = 50;
        public double Humidity
        {
            get
            {
                return _humidity;
            }
            set
            {
                if (_humidity != value)
                {
                    _humidity = value;
                    OnPropertyChanged(nameof(Humidity));
                }
            }
        }

        private readonly DispatcherTimer _wpfTimer = new DispatcherTimer();

        public WeatherViewModel()
        {
            _wpfTimer.Interval = new TimeSpan(0, 0, 3);
            _wpfTimer.Tick += WpfTimer_Tick;
            _wpfTimer.Start();
        }

        private void WpfTimer_Tick(object sender, EventArgs e)
        {
            // UIスレッドでないのであれば、Application.Current.Dispatcher.Invoke() を使うなどして
            // UIスレッドで実行されるようにする必要がある。

            IsFine = !IsFine;

            Humidity += 10;
            if (Humidity > 100)
                Humidity = 0;
        }
    }
}
