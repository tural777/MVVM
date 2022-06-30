using MVVM.Models;
using MVVM.Repository.Abstract;
using MVVM.Repository.Context;
using System.Collections.Generic;

namespace MVVM.Repository.Concrete;

public class CarRepository : ICarRepository
{
    public void Add(Car? entity)
        => FakeDbContext.Cars.Add(entity);

    public void Delete(Car entity)
        => FakeDbContext.Cars.Remove(entity);

    public List<Car?>? GetAll()
        => FakeDbContext.Cars;

    public Car? GetById(int id)
        => FakeDbContext.Cars.Find(c => c?.Id == id);

    public void Update(Car entity)
        => new System.NotImplementedException();
}
