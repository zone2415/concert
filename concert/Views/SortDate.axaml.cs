using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace concert.Views;

public partial class SortDate : Window
{
    public SortDate()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}