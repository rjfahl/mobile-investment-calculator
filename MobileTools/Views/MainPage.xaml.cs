namespace MobileTools.Views;

public partial class MainPage : ContentPage
{
    CompoundInterestCalculator _compoundInterestCalculator;
    BusinessInvestmentCalculator _businessInvestmentCalculator;

    public MainPage(CompoundInterestCalculator cic, BusinessInvestmentCalculator bic)
	{
		InitializeComponent();
        _compoundInterestCalculator = cic;
        _businessInvestmentCalculator = bic;
    }

    public async void NavigateToCompoundInterestCalculator(object sender, EventArgs e)
    {
        await Navigation.PushAsync(_compoundInterestCalculator);
    }

    public async void NavigateToBusinessInvestmentCalculator(object sender, EventArgs e)
	{
		await Navigation.PushAsync(_businessInvestmentCalculator);
	}
}
