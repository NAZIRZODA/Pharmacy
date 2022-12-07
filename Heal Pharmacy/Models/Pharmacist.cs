using Heal_Pharmacy.Abstracts;
namespace Heal_Pharmacy.Models;

public class Pharmacist: EntityBase
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
}