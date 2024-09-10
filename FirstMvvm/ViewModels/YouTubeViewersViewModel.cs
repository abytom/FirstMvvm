using FirstMvvm.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FirstMvvm.ViewModels
{
    public class YouTubeViewersViewModel : ViewModelBase
    {
        //since there are data binding from following "Views" on the  YouTubeViewersView XAML
        public YouTubeViewersListingViewModel YouTubeViewersListingViewModel { get; }

        public YouTubeViewersDetailsViewModel YouTubeViewersDetailsViewModel { get; }
        
        public ICommand AddYouTubeViewersCommand { get; }

        public YouTubeViewersViewModel(SelectedYouTubeViewerStore _selecetdYouTubeViewerStore)
        
        {

            // for data binding we create these instanced and also do "DataContext" at the XAML end inside YouTubeViewersView
            YouTubeViewersListingViewModel = new YouTubeViewersListingViewModel(_selecetdYouTubeViewerStore);
            YouTubeViewersDetailsViewModel = new YouTubeViewersDetailsViewModel(_selecetdYouTubeViewerStore);

        }
    }
}
