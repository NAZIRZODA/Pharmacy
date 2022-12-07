using Heal_Pharmacy.Models;

namespace Heal_Pharmacy.DataBases;

public static class Medicines
{
    public static List<Medicine> MedicinesTabletka { get; } = new List<Medicine>()
    {
        new Medicine() { Id = 1, Name = "Paratsetamol", Price = 2 },
        new Medicine() { Id = 2, Name = "Cermion", Price = 3 },
        new Medicine() { Id = 3, Name = "Tablet1", Price = 14 },
        new Medicine() { Id = 4, Name = "Tablet2", Price = 5 },
        new Medicine() { Id = 5, Name = "Tablets3", Price = 14 }
    };

    public static List<Medicine> MedicinesSyrop { get; } = new List<Medicine>()
    {
        new Medicine() { Id = 6, Name = "Syrop1", Price = 8 },
        new Medicine() { Id = 7, Name = "Syrop2", Price = 9 },
        new Medicine() { Id = 8, Name = "Syrop3", Price = 14 },
        new Medicine() { Id = 9, Name = "Syrop4", Price = 11 },
        new Medicine() { Id = 10, Name = "Syrop5", Price = 14 }
    };

    public static List<Medicine> MedicinesCapsule { get; } = new List<Medicine>()
    {
        new Medicine() { Id = 11, Name = "Capsule1", Price = 13 },
        new Medicine() { Id = 12, Name = "Capsule2", Price = 14 },
        new Medicine() { Id = 13, Name = "Capsule3", Price = 15 },
        new Medicine() { Id = 14, Name = "Capsule4", Price = 14 },
        new Medicine() { Id = 15, Name = "Capsule5", Price = 17 },
    };

    public static List<Medicine> MedicinesInjections { get; } = new List<Medicine>()
    {
        new Medicine() { Id = 16, Name = "Injection1", Price = 20 },
        new Medicine() { Id = 17, Name = "Injection2", Price = 30 },
        new Medicine() { Id = 18, Name = "Injection3", Price = 40 },
        new Medicine() { Id = 19, Name = "Injection4", Price = 50 },
        new Medicine() { Id = 20, Name = "Injection5", Price = 14 },
    };
}