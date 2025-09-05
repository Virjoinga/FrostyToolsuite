using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Frosty.Sdk;
using Frosty.Sdk.Sdk;

namespace FrostyEditor.ViewModels;

public partial class ProfileLoadingViewModel : WindowViewModel
{
    public ProfileLoadingViewModel()
    {
        Title = "ProfileLoadingWindow";
        //Height = Width = 500;
        Height = 250;
        Width = 598;
    }
}