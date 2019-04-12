using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MatchBuilder.ViewModels
{
    public class ContributeViewModel : BaseViewModel
    {
        public ContributeViewModel()
        {
            Title = "Contribute";
            
        }

        public ICommand OpenWebCommand { get; }
    }
}
