using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudy3.ViewModel
{
    public class AnimalViewModel : ViewModelBase
    {
        private string species;
        public string Species
        {
            get
            {
                return this.species;
            }
            set
            {
                if (this.species != value)
                {
                    this.species = value;
                    OnPropertyChanged("Species");
                }
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        private int popularity;
        public int Popularity
        {
            get
            {
                return this.popularity;
            }
            set
            {
                if (this.popularity != value)
                {
                    this.popularity = value;
                    OnPropertyChanged("Popularity");
                }
            }
        }
    }
}
