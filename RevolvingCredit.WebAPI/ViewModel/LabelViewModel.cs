using JDevl32.Web.ViewModel;
using RevolvingCredit.WebAPI.ViewModel.Interface;

namespace RevolvingCredit.WebAPI.ViewModel
{

	/// <summary>
	/// A view model for a (major) label for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// (Re-)implement as extension of view model interface.
	/// </remarks>
	public class LabelViewModel
		:
		UniqueIntEntityViewModel
		,
		ILabelViewModel
	{
	}

}
