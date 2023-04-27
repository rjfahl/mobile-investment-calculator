using MobileTools.Views;

namespace MobileTools;

public partial class MainPage : ContentPage
{
    CompoundInterestCalculator _compoundInterestCalculator;
    BusinessInvestmentCalculator _businessInvestmentCalculator;
    MinimumDistributionCalculator _minimumDistributionCalculator;
    MortgageCalculator _mortgageCalculator;

    public MainPage(CompoundInterestCalculator cic, BusinessInvestmentCalculator bic, MinimumDistributionCalculator mdc, MortgageCalculator mc)
	{
		InitializeComponent();
        _compoundInterestCalculator = cic;
        _businessInvestmentCalculator = bic;
        _minimumDistributionCalculator = mdc;
        _mortgageCalculator = mc;
    }

    public async void NavigateToCompoundInterestCalculator(object sender, EventArgs e)
    {
        await Navigation.PushAsync(_compoundInterestCalculator);
    }

    public async void NavigateToBusinessInvestmentCalculator(object sender, EventArgs e)
	{
		await Navigation.PushAsync(_businessInvestmentCalculator);
	}

    public async void NavigateToMinimumDistributionCalculator(object sender, EventArgs e)
    {
        await Navigation.PushAsync(_minimumDistributionCalculator);
    }

    public async void NavigateToMortgageCalculator(object sender, EventArgs e)
    {
        await Navigation.PushAsync(_mortgageCalculator);
    }
}
