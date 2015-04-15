using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowershellAddOn1.ViewModel
{
    public class AddOnViewModel
    {
        public ObservableCollection<MasterViewModel> MasterViewModels { get; set; }


        public AddOnViewModel()
        {
            MasterViewModels = new ObservableCollection<MasterViewModel>();
        }

        public void AddNewMasterViewModel()
        {
            var newMasterViewModel = new MasterViewModel();
            newMasterViewModel.Name = "test";
            newMasterViewModel.AddSubViewModel();

            MasterViewModels.Add(newMasterViewModel);
        }
    }
}
