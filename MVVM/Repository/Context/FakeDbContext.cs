using MVVM.Models;
using System.Collections.Generic;

namespace MVVM.Repository.Context;

class FakeDbContext
{
    public static List<Car?> Cars { get; set; } = new()
    {
        new Car{Id = 1, Make = "Kia", Model = "Cerato", Year = 2013 },
        new Car{Id = 2, Make = "Kia", Model = "Optima", Year = 2012 },
        new Car{Id = 3, Make = "Bmw", Model = "X6", Year = 2021 }
    };
}
