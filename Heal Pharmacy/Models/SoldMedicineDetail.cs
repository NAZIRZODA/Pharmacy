using Heal_Pharmacy.Abstracts;
namespace Heal_Pharmacy.Models;

public class SoldMedicineDetail: EntityBase
{
    public Medicine Medicine { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}