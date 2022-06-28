using MVVM.Command;
using System.Windows;

namespace MVVM.Views;

public partial class ExampleView : Window
{
    public RelayCommand SaveCommand { get; set; }
    public RelayCommand EditCommand { get; set; }

    public ExampleView()
    {
        InitializeComponent();

        DataContext = this;


        SaveCommand = new RelayCommand(
            _ =>
            {
                MessageBox.Show($"Save {txt.Text}");
            },
            _ =>
            {
                return txt.Text.Length > 2;
            }
        );


        EditCommand = new RelayCommand(
            _ =>
            {
                MessageBox.Show($"Edit {txt.Text}");
            },
            _ =>
            {
                return txt.Text.Length > 7;
            }
        );

    }


    // Command

    // Single use
    // Relay command


    // CanExecute
    // Executed





    //private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
    //{
    //    e.CanExecute = txt?.Text.Length > 2;
    //}

    //private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
    //{
    //    MessageBox.Show(txt.Text);
    //}
}
