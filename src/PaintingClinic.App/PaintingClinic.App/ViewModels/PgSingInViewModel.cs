using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingClinic.App.ViewModels;

public partial class PgSignInViewModel : ObservableValidator
{
    [ObservableProperty]
    string? username;

    [ObservableProperty]
    string? password;

    //[RelayCommand]
    //async Task Signin()
    //{

    //}

    //[RelayCommand]
    //async Task Signup()
    //{

    //}
}
