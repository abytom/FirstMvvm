using FirstMvvm.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMvvm.ViewModels
{
    public class YouTubeViewersListingViewModel : ViewModelBase
    {
        private ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModels;
        public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemViewModels => _youTubeViewersListingItemViewModels;

        public YouTubeViewersListingViewModel(SelectedYouTubeViewerStore _selecetdYouTubeViewerStore)
        {
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();

            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("John"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Mia"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Shril"));
        }

    }
}
