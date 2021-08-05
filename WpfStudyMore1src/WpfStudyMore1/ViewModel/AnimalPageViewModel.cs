using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfStudyMore1.Common;

namespace WpfStudyMore1.ViewModel
{
    public class AnimalPageViewModel : ViewModelBase
    {
        public List<string> AnimalTypes { get; } = new List<string>() { "いぬ", "ねこ", "ひつじ", "うま", "とら" };

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

                // ViewModelからMessageBoxを直接表示するのは悪い設計です。
                // Messengerパターンを使うか、使用するフレームワークが提供しているダイアログ表示の仕組みを使うべきでしょう。
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
