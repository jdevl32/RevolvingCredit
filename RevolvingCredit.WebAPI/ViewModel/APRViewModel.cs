using JDevl32.Web.ViewModel;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.WebAPI.ViewModel
{

	/// <summary>
	/// An APR (type) view model for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Remove unique item type from unique item view model (base class).
	/// </remarks>
	public class APRViewModel
		:
		UniqueViewModelBase
		,
		IAPR
	{
	}

}
