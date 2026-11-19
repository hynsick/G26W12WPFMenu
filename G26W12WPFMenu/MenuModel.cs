using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Media;

namespace G26W12WPFMenu;

public partial class MenuViewModel(
    MenuModel model
) : ObservableObject
{
    [ObservableProperty]
    private Brush _backgroundBrush = Brushes.White;

    [ObservableProperty]
    private bool _isWhiteSelected = true;

    [RelayCommand]
    private void SetColor(string color)
    {
        model.SelectColor(color);
        BackgroundBrush = model.BackgroundBrush;
        IsWhiteSelected = model.IsWhiteSelected;
    }
}