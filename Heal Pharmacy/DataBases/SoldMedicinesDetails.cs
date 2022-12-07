using Heal_Pharmacy.Models;

namespace Heal_Pharmacy.DataBases;

public class SoldMedicinesDetails
{
    public static List<SoldMedicineDetail> SoldMedicineList { get; } = new List<SoldMedicineDetail>()
    {
        new SoldMedicineDetail()
        {
            Id = 1, Medicine = Medicines.MedicinesTabletka[0], Price = Medicines.MedicinesTabletka[0].Price,
            Quantity = 2
        },
        new SoldMedicineDetail()
        {
            Id = 2, Medicine = Medicines.MedicinesTabletka[1], Price = Medicines.MedicinesTabletka[1].Price,
            Quantity = 3
        },
        new SoldMedicineDetail()
        {
            Id = 3, Medicine = Medicines.MedicinesTabletka[2], Price = Medicines.MedicinesTabletka[2].Price,
            Quantity = 4
        },
        new SoldMedicineDetail()
        {
            Id = 4, Medicine = Medicines.MedicinesTabletka[3], Price = Medicines.MedicinesTabletka[3].Price,
            Quantity = 5
        },
        new SoldMedicineDetail()
        {
            Id = 5, Medicine = Medicines.MedicinesTabletka[4], Price = Medicines.MedicinesTabletka[4].Price,
            Quantity = 6
        },
    };
}