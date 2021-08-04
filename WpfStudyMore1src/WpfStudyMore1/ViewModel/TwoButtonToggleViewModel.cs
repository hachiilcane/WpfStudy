using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfStudyMore1.Common;

namespace WpfStudyMore1.ViewModel
{
    public class TwoButtonToggleViewModel : ViewModelBase
    {
        private bool _isRunning = false;

        private RelayCommand _startServiceCommand;

        public RelayCommand StartServiceCommand
        {
            get
            {
                if (_startServiceCommand == null)
                {
                    _startServiceCommand = new RelayCommand(StartService, CanStartService);
                }
                return _startServiceCommand;
            }
        }

        private RelayCommand _stopServiceCommand;

        public RelayCommand StopServiceCommand
        {
            get
            {
                if (_stopServiceCommand == null)
                {
                    _stopServiceCommand = new RelayCommand(StopService, CanStopService);
                }
                return _stopServiceCommand;
            }
        }

        private void StartService(object o)
        {
            _isRunning = true;
            System.Windows.MessageBox.Show("がんばります！");
        }

        private bool CanStartService(object o)
        {
            return !_isRunning;
        }

        private void StopService(object o)
        {
            _isRunning = false;
            System.Windows.MessageBox.Show("がんばりました！");
        }

        private bool CanStopService(object o)
        {
            return _isRunning;
        }
    }
}
