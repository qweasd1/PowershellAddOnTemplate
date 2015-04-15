using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.PowerShell.Host.ISE;
using PowershellAddOn1.ViewModel;

namespace PowershellAddOn1
{
    /// <summary>
    /// PowershellAddOn.xaml 的交互逻辑
    /// </summary>
    public partial class PowershellAddOn : UserControl,IAddOnToolHostObject
    {

        public ObjectModelRoot HostObject { get; set; }

        private AddOnViewModel _addOnViewModel { get; set; }

        public PowershellAddOn()
        {
            InitializeComponent();
            _addOnViewModel = new AddOnViewModel();
            this.DataContext = _addOnViewModel;
        }
    }
}
