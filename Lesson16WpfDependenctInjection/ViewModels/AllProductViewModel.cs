using Lesson16WpfDependenctInjection.Commands;
using Lesson16WpfDependenctInjection.Data;
using Lesson16WpfDependenctInjection.Models;
using Lesson16WpfDependenctInjection.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16WpfDependenctInjection.ViewModels
{
    public class AllProductViewModel 
    {
        public AppDbContext DbContext { get; set; }
        public RelayCommand EditCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        public AllProductViewModel(AppDbContext dbContext)
        {
            DbContext = dbContext;
            DeleteCommand = new RelayCommand(Delete);
            EditCommand = new RelayCommand(EditExecute);
        }

        private void EditExecute(object? obj)
        {
            EditProductView editProductView = new EditProductView ();
            editProductView.DataContext = new EditProductViewModel();
            
        }


        private void Delete(object? obj)
        {
            DbContext.RemoveProduct(obj!.ToString()!);
        }
    }
}
