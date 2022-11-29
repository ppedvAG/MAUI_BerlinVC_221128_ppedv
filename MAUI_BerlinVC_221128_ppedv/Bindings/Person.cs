using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_BerlinVC_221128_ppedv.Bindings
{
    class Person : INotifyPropertyChanged
    {

        public string Name { get; set; }

        private int alter;
        public int Alter
        {
            get => alter;
            set
            {
                alter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Alter)));
            }
        }

        public ObservableCollection<DateTime> WichtigeTage { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Person()
        {
            WichtigeTage = new ObservableCollection<DateTime>()
            {
                DateTime.Now,
                new DateTime(2002, 12, 4),
                new DateTime(2013, 2, 14),
            };
        }
    }
}
