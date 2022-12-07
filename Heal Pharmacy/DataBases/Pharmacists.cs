using Heal_Pharmacy.Models;

namespace Heal_Pharmacy.DataBases;

public class Pharmacists
{
    public static List<Pharmacist> PharmacistList { get; } = new List<Pharmacist>()
    {
        new Pharmacist() { Id = 1, Name = "Name1", Phone = "9883222291", Surname = "Surname1" },
        new Pharmacist() { Id = 2, Name = "Name2", Phone = "9883222292", Surname = "Surname2" },
        new Pharmacist() { Id = 3, Name = "Name3", Phone = "9883222293", Surname = "Surname3" },
        new Pharmacist() { Id = 4, Name = "Name4", Phone = "9883222294", Surname = "Surname4" },
        new Pharmacist() { Id = 5, Name = "Name5", Phone = "9883222295", Surname = "Surname5" },
    };
}