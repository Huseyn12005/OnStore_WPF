using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OnStore_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public ObservableCollection<Product> Products {  get; set; }
        public ObservableCollection<Product> Basket { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Products = new ObservableCollection<Product>()
            {
                new(){Id = 1,Name = "Cola",Price = 1.00},
                new(){Id = 2,Name = "Fanta",Price = 1.20},
                new(){Id = 3,Name = "Corek",Price = 0.60},
                new(){Id = 4,Name = "Cips",Price = 2.40},
                new(){Id = 5,Name = "Bizon",Price = 1.30},
                new(){Id = 6,Name = "M&M",Price = 1.70},
                new(){Id = 7,Name = "Shaurma",Price = 2.40},
                new(){Id = 8,Name = "Sprite",Price = 0.80},
                new(){Id = 9,Name = "Hosbes",Price = 0.70},
                new(){Id = 10,Name = "Saqqiz",Price = 0.60}
            };

            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var basket = new Basket(Basket);
            basket.DataContext = new Basket(Basket);
            basket.ShowDialog();
        }
    }
}
