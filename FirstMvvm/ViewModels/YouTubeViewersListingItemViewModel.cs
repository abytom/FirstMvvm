using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FirstMvvm.ViewModels
{
    public class YouTubeViewersListingItemViewModel: ViewModelBase
    {
        public string Username { get; }

        public ICommand Edit { get; }

        public ICommand Delete { get; }

        public YouTubeViewersListingItemViewModel(string username)
        {
            Username = username;
        }

    }
}
