using Heal_Pharmacy.Abstracts;
using Heal_Pharmacy.Models;

namespace Heal_Pharmacy.Services;

public interface IBaseService<T> where T: EntityBase
{
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    T GetById(int item);
}