using FirstMvvm.Models;
using FirstMvvm.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMvvm.ViewModels
{
    public class YouTubeViewersDetailsViewModel : ViewModelBase
    {
        private readonly SelectedYouTubeViewerStore _selecetdYouTubeViewerStore;

        private YouTubeViewer SelectedYouTubeViewer => _selecetdYouTubeViewerStore.SelectedYouTubeViewer;


        // If no user is selected use this property to display nothing!
        public bool HasSelectedYouTubeViewer => SelectedYouTubeViewer != null;

        public string Username => SelectedYouTubeViewer?.Username ?? "Unknown";
        

        public string IsSubscribedDisplay => (SelectedYouTubeViewer?.IsSubscribed ?? false) ? "Yes" : "No";

        public string IsMemberDispaly => (SelectedYouTubeViewer?.IsMember ?? false) ? "Yes" : "No";

        public YouTubeViewersDetailsViewModel(SelectedYouTubeViewerStore selecetdYouTubeViewerStore)
        {
            _selecetdYouTubeViewerStore = selecetdYouTubeViewerStore;

            _selecetdYouTubeViewerStore.SelectedYouTubeViewerChanged += SelecetdYouTubeViewerStore_SelectedYouTubeViewerChanged;
        }

        protected override void Dispose()
        {
            _selecetdYouTubeViewerStore.SelectedYouTubeViewerChanged -= SelecetdYouTubeViewerStore_SelectedYouTubeViewerChanged;
            base.Dispose();
        }

        private void SelecetdYouTubeViewerStore_SelectedYouTubeViewerChanged()
        {
            OnPropertyChanged(nameof(HasSelectedYouTubeViewer));
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(IsSubscribedDisplay));
            OnPropertyChanged(nameof(IsMemberDispaly));
        }
    }
}
