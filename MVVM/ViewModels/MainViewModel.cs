using MVVM.Command;
using MVVM.Models;
using System.Windows;

namespace MVVM.ViewModels;

public class MainViewModel : ViewModelBase
{
    public Car? Car { get; set; }
    public RelayCommand ShowCommand { get; set; }

    public MainViewModel()
    {
        Car = new Car
        {
            Id = 1,
            Make = "Kia",
            Model = "Cerato",
            Year = 2013
        };


        ShowCommand = new(Show, CanShow);
    }


    private void Show(object? parametr)
        => MessageBox.Show(Car?.Model);

    private bool CanShow(object? parametr)
        => Car?.Model?.Length > 0;
}
