using Lesson16WpfDependenctInjection.Commands;
using Lesson16WpfDependenctInjection.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace Lesson16WpfDependenctInjection.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    public RelayCommand AllCommand { get; set; }
    public RelayCommand AddCommand { get; set; }

    private Page currentView;

    public Page CurrentView
    {
        get { return currentView; }
        set { currentView = value; OnPropertyChanged(); }
    }

    public MainViewModel()
    {
        AllCommand = new RelayCommand(All);
        AddCommand = new RelayCommand(Add);

        //CurrentView = new AllProductView();
        //CurrentView.DataContext = new AllProductViewModel(new Data.AppDbContext());

        CurrentView = App.Container.GetInstance<AllProductView>();
        CurrentView.DataContext = App.Container.GetInstance<AllProductViewModel>();
    }

    private void Add(object? obj)
    {
        CurrentView = App.Container.GetInstance<AddProductView>();
        CurrentView.DataContext = App.Container.GetInstance<AddProductViewModel>();
    }

    private void All(object? obj)
    {

        //CurrentView = new AllProductView();
        //CurrentView.DataContext = new AllProductViewModel(new Data.AppDbContext());

        CurrentView = App.Container.GetInstance<AllProductView>();
        CurrentView.DataContext = App.Container.GetInstance<AllProductViewModel>();
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? paramName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
    }
}
