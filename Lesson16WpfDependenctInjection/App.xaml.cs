using Lesson16WpfDependenctInjection.Data;
using Lesson16WpfDependenctInjection.ViewModels;
using Lesson16WpfDependenctInjection.Views;
using SimpleInjector;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Lesson16WpfDependenctInjection
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; } = new Container();
        public App()
        {
            Container.RegisterSingleton<AppDbContext>();
            RegisterViews();
            RegisterViewModels();
        }

        private void RegisterViewModels()
        {
            Container.RegisterSingleton<AllProductViewModel>();
            Container.RegisterSingleton<AddProductViewModel>();
            Container.RegisterSingleton<MainViewModel>();
        }

        private void RegisterViews()
        {
            Container.RegisterSingleton<AllProductView>();
            Container.RegisterSingleton<AddProductView>();
            Container.RegisterSingleton<MainView>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var view = Container.GetInstance<MainView>();
            view.DataContext = Container.GetInstance<MainViewModel>();
            view.Show();

            base.OnStartup(e);
        }
    }

}
