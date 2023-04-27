using MobileTools.ViewModels;

namespace MobileTools.Views;

public partial class BusinessInvestmentCalculator : ContentPage
{
    public BusinessInvestmentCalculator(BusinessInvestmentCalculatorViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
