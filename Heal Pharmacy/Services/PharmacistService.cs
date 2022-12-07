using Heal_Pharmacy.DataProvider;
using Heal_Pharmacy.Models;

namespace Heal_Pharmacy.Services;

public class PharmacistService:BaseService<Pharmacist>
{
    public PharmacistService(IDataProvider<Pharmacist> dataProvider) : base(dataProvider)
    {
    }
}