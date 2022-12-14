using Avalonia.Controls;
using Avalonia.Interactivity;

namespace concert.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OpenMenu(object? sender, RoutedEventArgs e)
    {
        MenuItem_One.Open();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        SortDateOne.Open();
    }

    private void SortGorodOne(object? sender, RoutedEventArgs e)
    {
        SortGorod.Open();
    }
}