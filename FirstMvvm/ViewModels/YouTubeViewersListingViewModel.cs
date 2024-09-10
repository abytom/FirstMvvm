using FirstMvvm.Models;
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

        private YouTubeViewersListingItemViewModel _selectedYouTubeViewersListingItemViewModel;
        private readonly SelectedYouTubeViewerStore selecetdYouTubeViewerStore;

        public YouTubeViewersListingItemViewModel SelectedYouTubeViewersListingItemViewModel
        {
            get
            {
                return _selectedYouTubeViewersListingItemViewModel;

            }
            set
            {
                _selectedYouTubeViewersListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedYouTubeViewersListingItemViewModel));

                selecetdYouTubeViewerStore.SelectedYouTubeViewer = _selectedYouTubeViewersListingItemViewModel.YouTubeViewer;
            }
        }

        public YouTubeViewersListingViewModel(SelectedYouTubeViewerStore _selecetdYouTubeViewerStore)
        {

            selecetdYouTubeViewerStore = _selecetdYouTubeViewerStore;
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();

            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("John", true, true)));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("Mia", true, false)));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("Sony", false, true)));
            
        }

    }
}
