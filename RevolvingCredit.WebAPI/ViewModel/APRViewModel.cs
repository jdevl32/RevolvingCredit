using JDevl32.Web.ViewModel;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.WebAPI.ViewModel
{

	/// <summary>
	/// An APR (type) view model for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
	/// </remarks>
	public class APRViewModel
		:
		IntUniqueEntityViewModel
		,
		IAPR
	{
	}

}
