using System.Net.Mime;
using Heal_Pharmacy.Abstracts;
using Heal_Pharmacy.DataProvider;
using Heal_Pharmacy.Models;

namespace Heal_Pharmacy.Services;

public abstract class BaseService<T> : IBaseService<T> where T : EntityBase
{
    private readonly IDataProvider<T> _dataProvider;
    public BaseService(IDataProvider<T> dataProvider)
    {
        _dataProvider = dataProvider;
    }
    
    public void Add(T entity)
    {
        _dataProvider.Add(entity);
    }

    public void Delete(T entity)
    {
        _dataProvider.Delete(entity);
    }

    public void Update(T entity)
    {
        _dataProvider.Update(entity);
    }

    public T GetById(int item)
    {
       var Get=_dataProvider.GetById(item);
       return Get;
    }
}