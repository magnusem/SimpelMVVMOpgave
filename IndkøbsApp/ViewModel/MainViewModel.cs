using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndkøbsApp.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<MainViewModel> VareListe { get; set; }
        public string VareNavn { get; set; }
        public string VarePris { get; set; }
        public Common.RelayCommand TilføjVare { get; set; }
        public Common.RelayCommand SletVare { get; set; }
        public Common.RelayCommand SletVareListe { get; set; }

        public MainViewModel()
        {

        }





    }
}
