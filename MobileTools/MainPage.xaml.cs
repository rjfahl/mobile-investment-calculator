namespace MobileTools;

public partial class MainPage : ContentPage
{
    int initialInvestment = 1000;
    double rateOfReturn = 35;
    double rateOfInflation = 7.5;
    int investmentPeriodInYears = 5;
    int expectedAnnualCompanyEarningsAtEndOfInvestmentPeriod = 20000;
    const double RISK_FACTOR = 0.5;

	public MainPage()
	{
		InitializeComponent();
        InitialInvestment.Text = initialInvestment.ToString();
        RateOfReturn.Text = rateOfReturn.ToString();
        RateOfInflation.Text = rateOfInflation.ToString();
        InvestmentPeriodInYears.Text = investmentPeriodInYears.ToString();
        ExpectedAnnualCompanyEarnings.Text = expectedAnnualCompanyEarningsAtEndOfInvestmentPeriod.ToString();
    }

    void OnInitialInvestmentTextChanged(object sender, TextChangedEventArgs e)
    {
        initialInvestment = string.IsNullOrWhiteSpace(e.NewTextValue) ? 0: Int32.Parse(e.NewTextValue);
    }

    void OnRateOfReturnTextChanged(object sender, TextChangedEventArgs e)
    {
        rateOfReturn = string.IsNullOrWhiteSpace(e.NewTextValue) ? 0 : double.Parse(e.NewTextValue);
    }

    void OnRateOfInflationTextChanged(object sender, TextChangedEventArgs e)
    {
        rateOfInflation = string.IsNullOrWhiteSpace(e.NewTextValue) ? 0 : double.Parse(e.NewTextValue);
    }

    void OnInvestmentPeriodTextChanged(object sender, TextChangedEventArgs e)
    {
        investmentPeriodInYears = string.IsNullOrWhiteSpace(e.NewTextValue) ? 0 : Int32.Parse(e.NewTextValue);
    }

    void OnExpectedCompanyEarningsTextChanged(object sender, TextChangedEventArgs e)
    {
        expectedAnnualCompanyEarningsAtEndOfInvestmentPeriod = string.IsNullOrWhiteSpace(e.NewTextValue) ? 0 : Int32.Parse(e.NewTextValue);
    }

    private void CalculateReturnsAndOwnership(object sender, EventArgs e)
	{
        var returnRate = rateOfReturn * .01 + 1;
        var inflationRate = rateOfInflation * .01 + 1;

        var returns = initialInvestment * 1.0;
        for (var year = 0; year < investmentPeriodInYears; year++)
        {
            returns = returns * returnRate * inflationRate;
        }

        var companyAcquisitionPrice = ((expectedAnnualCompanyEarningsAtEndOfInvestmentPeriod) * 10);
        var riskAdjustedAcquisitionPrice = companyAcquisitionPrice * RISK_FACTOR;

        var ownership = (returns / (IncludeRiskFactor.IsChecked ? riskAdjustedAcquisitionPrice: companyAcquisitionPrice)) * 100;

        ReturnOnInvestment.Text = Math.Round(returns).ToString();
        RequiredOwnership.Text = Math.Round(ownership).ToString();
    }
}


