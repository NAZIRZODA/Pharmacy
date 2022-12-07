using Heal_Pharmacy.Models;

namespace Heal_Pharmacy.DataBases;

public static class Categories
{
    public static List<Category> Type { get; } = new List<Category>
    {
        new Category() { Id = 1, Name = "Tabletka", Medicines = Medicines.MedicinesTabletka},
        new Category() { Id = 2, Name = "Syrop", Medicines = Medicines.MedicinesSyrop},
        new Category() { Id = 3, Name = "Capsule", Medicines = Medicines.MedicinesCapsule},
        new Category() { Id = 4, Name = "injections-Constructions", Medicines = Medicines.MedicinesInjections}
    };
}