using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace PowershellAddOn1.ViewModel
{
    public class MasterViewModel
    {
        public ObservableCollection<SubViewModel> SubViewModels { get; set; }

        public string Name { get; set; }

        public MasterViewModel()
        {
            SubViewModels = new ObservableCollection<SubViewModel>();
        }


        internal void AddSubViewModel()
        {
            var newSubViewModel = new SubViewModel();
            newSubViewModel.Name = "sub";
            SubViewModels.Add(newSubViewModel);
        }
    }
}
