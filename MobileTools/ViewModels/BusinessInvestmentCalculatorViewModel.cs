using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MobileTools.ViewModels;

public partial class BusinessInvestmentCalculatorViewModel : ObservableObject
{
    [ObservableProperty]
    int initialInvestment;

    [ObservableProperty]
    double rateOfReturn;

    [ObservableProperty]
    double rateOfInflation;

    [ObservableProperty]
    int investmentPeriodInYears;

    [ObservableProperty]
    int expectedAnnualCompanyEarningsAtEndOfInvestmentPeriod;

    [ObservableProperty]
    bool includeRiskFactor;

    [ObservableProperty]
    double returnOnInvestment;

    [ObservableProperty]
    double requiredOwnership;

    const double RISK_FACTOR = 0.5;

    public BusinessInvestmentCalculatorViewModel()
	{}

    [RelayCommand]
    public void CalculateReturnsAndOwnership()
    {
        var returnRate = RateOfReturn * .01 + 1;
        var inflationRate = RateOfInflation * .01 + 1;

        var returns = InitialInvestment * 1.0;
        for (var year = 0; year < InvestmentPeriodInYears; year++)
        {
            returns = returns * returnRate * inflationRate;
        }

        var companyAcquisitionPrice = ((ExpectedAnnualCompanyEarningsAtEndOfInvestmentPeriod) * 10);
        var riskAdjustedAcquisitionPrice = companyAcquisitionPrice * RISK_FACTOR;

        var ownership = (returns / (IncludeRiskFactor ? riskAdjustedAcquisitionPrice : companyAcquisitionPrice)) * 100;

        ReturnOnInvestment = Math.Round(returns);
        RequiredOwnership = Math.Round(ownership);
    }
}

