using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudy3.ViewModel
{
    public class AnimalViewModel : ViewModelBase
    {
        private string _species;
        public string Species
        {
            get
            {
                return _species;
            }
            set
            {
                if (_species != value)
                {
                    _species = value;
                    OnPropertyChanged(nameof(Species));
                }
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        private int _popularity;
        public int Popularity
        {
            get
            {
                return _popularity;
            }
            set
            {
                if (_popularity != value)
                {
                    _popularity = value;
                    OnPropertyChanged(nameof(Popularity));
                }
            }
        }
    }
}
