using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfStudyMore1.Common;

namespace WpfStudyMore1.ViewModel
{
    public class AnimalPageViewModel : ViewModelBase
    {
        private List<string> _animalTypes = new List<string>()
        {
            "いぬ", "ねこ", "ひつじ", "うま", "とら"
        };

        public List<string> AnimalTypes
        {
            get
            {
                return _animalTypes;
            }
        }

        private string _selectedAnimalType;
        public string SelectedAnimalType
        {
            get
            {
                return _selectedAnimalType;
            }
            set
            {
                _selectedAnimalType = value;
                OnPropertyChanged("SelectedAnimalType");

                System.Windows.MessageBox.Show(_selectedAnimalType + "さんが好きなんですね！");
            }
        }

        private string _meter = string.Empty;
        public string Meter
        {
            get { return _meter; }
            set
            {
                _meter = value;
                OnPropertyChanged("Meter");
                double dblMeter;
                if (double.TryParse(value, out dblMeter))
                {
                    Mile = (dblMeter / 1609.344).ToString("0.000") + " Mile";
                }
                else
                {
                    Mile = "数字入れて！";
                }
            }
        }

        private string _mile = string.Empty;
        public string Mile
        {
            get { return _mile; }
            set
            {
                _mile = value;
                OnPropertyChanged("Mile");
            }
        }
    }
}
