using MVVM.Models;
using System.Collections.Generic;

namespace MVVM.Repository.Abstract;

public interface ICarRepository
{
    public List<Car> GetAll();
    public void Delete(Car entity);
    public void Update(Car entity);
    public void Add(Car entity);
    public Car GetById(int id);
}
