using Heal_Pharmacy.Abstracts;
namespace Heal_Pharmacy.Models;

public class SoldMedicine: EntityBase
{
    public List<SoldMedicineDetail> SoldMedicineDetail { get; set; }
}