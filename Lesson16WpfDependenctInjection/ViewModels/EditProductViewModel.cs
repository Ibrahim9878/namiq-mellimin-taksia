using Lesson16WpfDependenctInjection.Commands;
using Lesson16WpfDependenctInjection.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lesson16WpfDependenctInjection.ViewModels;

public class EditProductViewModel : INotifyPropertyChanged
{
    private Product product = new() ;
    private Product cpyproduct = new();

    public Product Product { get => product; set { product = value; OnPropertyChanged(); } }
    public Product cpyProduct { get => product; set { product = value; OnPropertyChanged(); } }
    public RelayCommand EditCommand { get; set; }
    public EditProductViewModel()
    {
        EditCommand = new(EditExecute, CanEdit);
    }

    private void EditExecute(object? obj)
    {
        product = new();
    }

    private bool CanEdit(object? obj)
    {
        return Product.IsEqual(cpyProduct);
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? paramName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
    }
}
