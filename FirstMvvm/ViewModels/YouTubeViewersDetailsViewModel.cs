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

        public string Username => SelectedYouTubeViewer?.Username;


        public string IsSubscribedDisplay => (SelectedYouTubeViewer?.IsSubscribed ?? false) ? "Yes" : "No";

        public string IsMemberDispaly => (SelectedYouTubeViewer?.IsMember ?? false) ? "Yes" : "No";

        public YouTubeViewersDetailsViewModel(SelectedYouTubeViewerStore selecetdYouTubeViewerStore)
        {
            _selecetdYouTubeViewerStore = selecetdYouTubeViewerStore;
        }

    }
}
