using Heal_Pharmacy.DataProvider;
using Heal_Pharmacy.Models;

namespace Heal_Pharmacy.Services;

public class SoldMedicineService:BaseService<SoldMedicine>
{
    public SoldMedicineService(IDataProvider<SoldMedicine> dataProvider) : base(dataProvider)
    {
        
    }
}