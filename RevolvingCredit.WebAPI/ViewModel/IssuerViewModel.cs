using JDevl32.Web.ViewModel;
using RevolvingCredit.WebAPI.ViewModel.Interface;

namespace RevolvingCredit.WebAPI.ViewModel
{

	/// <summary>
	/// A view model for an issuer for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class IssuerViewModel
		:
		UniqueIntEntityViewModel
		,
		IIssuerViewModel
	{
	}

}
