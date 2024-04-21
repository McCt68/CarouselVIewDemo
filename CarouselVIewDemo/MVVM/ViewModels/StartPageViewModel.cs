using CarouselVIewDemo.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarouselVIewDemo.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class StartPageViewModel
    {
        public ObservableCollection<Product> CarouselViewItems { get; set; } = new();

        public Product CurrentItem { get; set; }

    public decimal TotalPrice { get; set; } = new();

        public ICommand CarouselViewItemChanged =>
            new Command(() =>
            {               

                // This will always show the value of index 1 -
                // Instead I want it to show the price of the Product that -
                // Is currently selected in the XAML CarouselView.
                TotalPrice = CarouselViewItems[1].ProductPrice;                                          

            });

        public StartPageViewModel()
        {                       
            CarouselViewItems = new ObservableCollection<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "KaffeBønner",
                    ProductPrice = 35m
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "LakridsKonfekt",
                    ProductPrice = 55m
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Shampoo",
                    ProductPrice = 25m
                },
            };            
        }
    }
}
