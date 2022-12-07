using Heal_Pharmacy.Abstracts;

namespace Heal_Pharmacy.Models;

public class Category:EntityBase 
{
    public List<Medicine> Medicines { get; set; }
    public string Name { get; set; }
}