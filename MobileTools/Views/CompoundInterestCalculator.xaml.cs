using MobileTools.ViewModels;

namespace MobileTools.Views;

public partial class CompoundInterestCalculator : ContentPage
{
	public CompoundInterestCalculator(CompoundInterestCalculatorViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
