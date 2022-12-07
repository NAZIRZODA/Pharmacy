using Heal_Pharmacy.DataBases;
using Heal_Pharmacy.DataProvider;
using Heal_Pharmacy.Models;
using Heal_Pharmacy.Services;

MemoryProvider<Category> _cat = new MemoryProvider<Category>();
Category cat = new Category() { Id = 1, Name = "Tablets" };
CategoryService _catService = new CategoryService(_cat);
_catService.Add(Categories.Type[0]);
_catService.Add(Categories.Type[1]);
_catService.Add(Categories.Type[2]);
_catService.Add(Categories.Type[3]);
_catService.Update(cat);
Console.Write(_cat.GetById(2).Name);