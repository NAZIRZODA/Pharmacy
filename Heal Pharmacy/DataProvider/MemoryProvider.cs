using Heal_Pharmacy.Abstracts;

namespace Heal_Pharmacy.DataProvider;

public class MemoryProvider<T> : IDataProvider<T> where T : EntityBase
{
    public List<T> ListOfEntity = new List<T>();

    public void Add(T entity)
    {
        ListOfEntity.Add(entity);
    }

    public void Delete(T entity)
    {
        ListOfEntity.Remove(entity);
    }

    public void Update(T entity)
    {
        int index = 0;
        foreach (var itemOfEntity in ListOfEntity.Where(item => item.Id == entity.Id))
        {
            index = ListOfEntity.IndexOf(itemOfEntity);
        }
        ListOfEntity[index] = entity;
    }

    public T GetById(int id)
    {
        //return (from itemOfList in ListOfEntity
        //        where itemOfList.Id == id
        //        select itemOfList) as T;
        var s = ListOfEntity.FirstOrDefault(i => i.Id == id);
        return s;
    }
}