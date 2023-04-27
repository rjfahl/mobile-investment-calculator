using MobileTools.ViewModels;

namespace MobileTools.Views;

public partial class MortgageCalculator : ContentPage
{
	public MortgageCalculator(MortgageCalculatorViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
