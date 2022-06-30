using MVVM.Command;
using MVVM.Models;
using MVVM.Repository.Abstract;
using MVVM.Repository.Concrete;
using MVVM.Views;
using System.Collections.ObjectModel;
using System.Windows;

namespace MVVM.ViewModels;

public class MainViewModel : ViewModelBase
{

    private Car? selectedCar;
    public Car? SelectedCar
    {
        get { return selectedCar; }
        set
        {
            selectedCar = value;
            NotifyPropertyChanged();
        }
    }


    public ObservableCollection<Car?>? Cars { get; set; }

    public RelayCommand ShowCommand { get; set; }
    public RelayCommand AddCommand { get; set; }

    private ICarRepository _carRepository;

    public MainViewModel()
    {

        ShowCommand = new(Show, CanShow);
        AddCommand = new(Add);


        _carRepository = new CarRepository();

        Cars = new(_carRepository.GetAll());
    }


    private void Show(object? parametr)
        => MessageBox.Show(SelectedCar?.Model);

    private bool CanShow(object? parametr)
        => SelectedCar?.Model?.Length > 0;


    private void Add(object? parametr)
    {
        var viewModel = new AddViewModel();
        var view = new AddView();

        view.DataContext = viewModel;

        if(view.ShowDialog() ?? false)
            Cars?.Add(viewModel.NewCar);

    }
}
