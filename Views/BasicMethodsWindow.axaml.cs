using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace NQueensCamera.Views;

public partial class BasicMethodsWindow : Window
{
    public BasicMethodsWindow()
    {
        InitializeComponent();
        
        RadioButton? insertParametersRadioButton = this.FindControl<RadioButton>("InsertParameters");
        TextBox? areaSize = this.FindControl<TextBox>("AreaSize");
        TextBox? camerasQuantity = this.FindControl<TextBox>("CamerasQuantity");

        if (insertParametersRadioButton != null && areaSize != null && camerasQuantity != null)
        {
            insertParametersRadioButton.IsChecked = true;
            
            areaSize.IsEnabled = true;
            camerasQuantity.IsEnabled = true;
        }
    }

    private void ParametersOptionChanged(object? sender, RoutedEventArgs e)
    {
        Console.WriteLine("ParametersOptionChanged");

        TextBox? areaSize = this.FindControl<TextBox>("AreaSize");
        TextBox? camerasQuantity = this.FindControl<TextBox>("CamerasQuantity");

        if (areaSize != null && camerasQuantity != null)
        {
            if (InsertParameters.IsChecked ?? true)
            {
                areaSize.IsEnabled = true;
                camerasQuantity.IsEnabled = true;
            }
            else
            {
                areaSize.IsEnabled = false;
                camerasQuantity.IsEnabled = false;
            }
        }
    }
}