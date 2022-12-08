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
}