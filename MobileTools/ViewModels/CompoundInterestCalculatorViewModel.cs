using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MobileTools.ViewModels;

public partial class CompoundInterestCalculatorViewModel : ObservableObject
{
	[ObservableProperty]
	int initialInvestment;

	[ObservableProperty]
	int monthlyContribution;

	[ObservableProperty]
	int lengthOfTimeInYears;

	[ObservableProperty]
	int interestRate;

	[ObservableProperty]
	int interestRateVariance;

    [ObservableProperty]
    double lowVarianceInvestmentTotal;

    [ObservableProperty]
    double highVarianceInvestmentTotal;

    [ObservableProperty]
    double investmentTotal;

    public CompoundInterestCalculatorViewModel()
	{}

    [RelayCommand]
    public void CalculateCompoundInterest()
	{
		double totalInvestment = InitialInvestment;
        double lowVarianceInvestment = InitialInvestment;
        double highVarianceInvestment = InitialInvestment;

        for (var year = 0; year < LengthOfTimeInYears; year++)
		{
			totalInvestment = (totalInvestment + (12 * MonthlyContribution)) * (1 + (InterestRate * .01));
            lowVarianceInvestment = (lowVarianceInvestment + (12 * MonthlyContribution)) * (1 + (InterestRate * .01) - (InterestRateVariance * .01));
            highVarianceInvestment = (highVarianceInvestment + (12 * MonthlyContribution)) * (1 + (InterestRate * .01) + (InterestRateVariance * .01));
        }

		LowVarianceInvestmentTotal = Math.Round(lowVarianceInvestment);
		HighVarianceInvestmentTotal = Math.Round(highVarianceInvestment);
		InvestmentTotal = Math.Round(totalInvestment);
    }
}

