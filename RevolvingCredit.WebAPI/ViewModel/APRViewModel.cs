using JDevl32.Web.ViewModel;
using RevolvingCredit.WebAPI.ViewModel.Interface;

namespace RevolvingCredit.WebAPI.ViewModel
{

	/// <summary>
	/// A view model for an APR (type) for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// (Re-)implement as extension of view model interface.
	/// </remarks>
	public class APRViewModel
		:
		UniqueIntEntityViewModel
		,
		IAPRViewModel
	{
	}

}
