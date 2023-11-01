using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnStore_WPF
{
    public class Product:INotifyPropertyChanged
    {
        private string? name;
        private double price;
        private int id;

        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public string Name 
        { get => name!;
          set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public double Price 
        { get => price;
          set
            {
                price = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
