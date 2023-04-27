using MobileTools.ViewModels;

namespace MobileTools.Views;

public partial class MinimumDistributionCalculator : ContentPage
{
	public MinimumDistributionCalculator(MinimumDistributionCalculatorViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
