using Heal_Pharmacy.DataProvider;
using Heal_Pharmacy.Models;

namespace Heal_Pharmacy.Services;

public class MedicineService:BaseService<Medicine>
{
    public MedicineService(IDataProvider<Medicine> dataProvider) : base(dataProvider)
    {
        
    }
}