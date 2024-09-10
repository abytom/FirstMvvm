using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMvvm.ViewModels
{
    public class YouTubeViewersDetailsViewModel : ViewModelBase
    {
        public string Username { get; }

        public string IsSubscribedDisplay { get; }

        public string IsMemberDispaly { get; }

        public YouTubeViewersDetailsViewModel()
        {
            Username = "Aby";
            IsSubscribedDisplay = "No";
            IsMemberDispaly = "Yes";
        }

    }
}
