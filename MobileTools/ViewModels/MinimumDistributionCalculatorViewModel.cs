using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MobileTools.ViewModels;

public partial class MinimumDistributionCalculatorViewModel : ObservableObject
{
	[ObservableProperty]
	int age;

    [ObservableProperty]
    double minimumDistribution;

    [ObservableProperty]
    double accountBalance;

    public MinimumDistributionCalculatorViewModel()
	{}

    [RelayCommand]
    public void CalculateMinimumDistribution()
	{
        // TODO - IRS Guidelines https://www.irs.gov/publications/p590b
        MinimumDistribution = 999;
    }
}

