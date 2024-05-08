using Lesson16WpfDependenctInjection.Commands;
using Lesson16WpfDependenctInjection.Data;
using Lesson16WpfDependenctInjection.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16WpfDependenctInjection.ViewModels
{
    public class AddProductViewModel : INotifyPropertyChanged
    {
        private Product product = new();

        public AppDbContext DbContext { get; set; }
        public RelayCommand AddCommand { get; set; }
        public Product Product { get => product; set { product = value; OnPropertyChanged(); } }
        public AddProductViewModel(AppDbContext dbContext)
        {
            DbContext = dbContext;
            AddCommand = new(obj =>
            {
                DbContext.AddProduct(Product);
                Product = new();    
            });
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? paramName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
        }
    }
}
