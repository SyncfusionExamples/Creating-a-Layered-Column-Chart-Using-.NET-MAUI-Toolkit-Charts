using System.Collections.ObjectModel;

namespace LayeredColumnChartMAUI
{
    public class ViewModel
    {
        public ObservableCollection<DataModel> DataSource { get; set; }
        
        public ViewModel()
        {
            DataSource = new ObservableCollection<DataModel>
            {
                new DataModel { Country = "Greece", EnergyCost = 93, StaffCost = 65, WorkerShortage = 55, Tax = 75, Geopolitical = 70 },
                new DataModel { Country = "Spain", EnergyCost = 88, StaffCost = 64, WorkerShortage = 69, Tax = 50, Geopolitical = 44 },
                new DataModel { Country = "Germany", EnergyCost = 84, StaffCost = 77, WorkerShortage = 80, Tax = 71, Geopolitical = 57 },
                new DataModel { Country = "France", EnergyCost = 80, StaffCost = 68, WorkerShortage = 63, Tax = 60, Geopolitical = 58 },
                new DataModel { Country = "Netherlands", EnergyCost = 80, StaffCost = 66, WorkerShortage = 59, Tax = 46, Geopolitical = 49 },
                new DataModel { Country = "Italy", EnergyCost = 75, StaffCost = 56, WorkerShortage = 65, Tax = 71, Geopolitical = 55 },
                new DataModel { Country = "Portugal", EnergyCost = 71, StaffCost = 70, WorkerShortage = 50, Tax = 55, Geopolitical = 58 },
                new DataModel { Country = "Austria", EnergyCost = 68, StaffCost = 75, WorkerShortage = 68, Tax = 61, Geopolitical = 43 },
                new DataModel { Country = "Nordics", EnergyCost = 65, StaffCost = 50, WorkerShortage = 56, Tax = 55, Geopolitical = 59 }
            };
        }
    }
}
