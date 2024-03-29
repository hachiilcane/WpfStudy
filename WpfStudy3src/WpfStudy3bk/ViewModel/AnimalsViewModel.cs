﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfStudy3bk.Common;

namespace WpfStudy3bk.ViewModel
{
    
    public class AnimalsViewModel : ViewModelBase
    {
        public ObservableCollection<string> SimplyList { get; set; }

        public ObservableCollection<AnimalViewModel> Animals { get; set; }

        public RelayCommand AddAnimalCommand { get; }

        public AnimalsViewModel()
        {
            SimplyList = new ObservableCollection<string>()
            {
                "Rabit",
                "Dog",
                "Lamb",
                "Panda",
                "Pony"
            };

            Animals = new ObservableCollection<AnimalViewModel>()
            {
                new AnimalViewModel() { Species = "Rabit", Name = "うさぎさん", Popularity = 5 },
                new AnimalViewModel() { Species = "Dog", Name = "いぬさん", Popularity = 2 },
                new AnimalViewModel() { Species = "Lamb", Name = "ひつじさん", Popularity = 4 },
                new AnimalViewModel() { Species = "Panda", Name = "ぱんださん", Popularity = 3 },
                new AnimalViewModel() { Species = "Pony", Name = "うまさん", Popularity = 2 },

            };

            AddAnimalCommand = new RelayCommand(obj =>
            {
                Animals.Add(new AnimalViewModel() { Species = "Bear", Name = "くまさん", Popularity = 3 });
            });
        }
    }
}
