using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MobileTools.ViewModels;

public partial class MortgageCalculatorViewModel : ObservableObject
{
	[ObservableProperty]
	int homeValue;

    [ObservableProperty]
    int downPayment;

    [ObservableProperty]
    double interestRate;

    [ObservableProperty]
    int loanTerm;

    [ObservableProperty]
    double totalMonthlyPayment;

    public MortgageCalculatorViewModel()
	{}

    [RelayCommand]
    public void CalculateMortgage()
	{
        // TODO - Zillow Calculator https://www.zillow.com/mortgage-calculator/
        TotalMonthlyPayment = 999;
    }
}

