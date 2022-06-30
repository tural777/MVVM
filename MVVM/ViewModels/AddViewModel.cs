using MVVM.Command;
using MVVM.Models;
using MVVM.Repository.Abstract;
using MVVM.Repository.Concrete;
using System.Windows;

namespace MVVM.ViewModels;


public class AddViewModel : ViewModelBase
{
    public Car? NewCar { get; set; }

    public RelayCommand AddCommand { get; set; }
    public RelayCommand BackCommand { get; set; }


    private ICarRepository _carRepository; // Dependency injection

    public AddViewModel()
    {
        AddCommand = new(Add, CanAdd);
        BackCommand = new(Back);

        _carRepository = new CarRepository();


        NewCar = new();
    }


    private void Add(object? parameter)
    {
        var view = (parameter as Window);

        if (view is not null)
        {
            view.DialogResult = true;
            view.Close();

            _carRepository.Add(NewCar);
            MessageBox.Show("Successfully added");
        }

    }


    private bool CanAdd(object? parametr)
    {
        if (NewCar == null) return false;


        return NewCar.Make?.Length > 0 &&
            NewCar.Model?.Length > 0 &&
            NewCar.Year.ToString().Length > 0;
    }




    private void Back(object? parameter)
    {
        var view = (parameter as Window);

        if (view is not null)
        {
            view.DialogResult = false;
            view.Close();
        }
    }
}
