using FirstMvvm.Stores;
using FirstMvvm.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace FirstMvvm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly SelectedYouTubeViewerStore _selecetdYouTubeViewerStore;

        public App()
        {
            _selecetdYouTubeViewerStore = new SelectedYouTubeViewerStore();

        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new YouTubeViewersViewModel(_selecetdYouTubeViewerStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
