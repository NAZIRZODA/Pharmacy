using Heal_Pharmacy.DataProvider;
using Heal_Pharmacy.Models;

namespace Heal_Pharmacy.Services;

public class CategoryService : BaseService<Category>
{
    public CategoryService(IDataProvider<Category> dataProvider) : base(dataProvider)
    {
        
    }
}