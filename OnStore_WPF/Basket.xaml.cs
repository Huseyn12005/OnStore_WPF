using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OnStore_WPF
{
    /// <summary>
    /// Interaction logic for Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {
        public ObservableCollection<Product> Basket_ { get; set; }
        public Basket(ObservableCollection<Product> basket)
        {
            InitializeComponent();
            Basket_ = basket;
       
        }
    }
}
