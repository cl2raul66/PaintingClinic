using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingClinic.App.ViewModels;

public partial class NotificationCenterViewModel : ObservableRecipient
{
    [ObservableProperty]
    string texto = "by RandA Media Lab, Group";

    [RelayCommand]
    async Task ButonClose()
    {
        await Shell.Current.GoToAsync(nameof(ButonView));
    }
    
    [RelayCommand]
    async Task ButonView()
    {
        await Shell.Current.GoToAsync(nameof(ButonView));
    }
}
