using Heal_Pharmacy.Abstracts;
using Heal_Pharmacy.Models;

namespace Heal_Pharmacy.DataProvider;

public interface IDataProvider<T> where T: EntityBase
{
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    T GetById(int id);
}