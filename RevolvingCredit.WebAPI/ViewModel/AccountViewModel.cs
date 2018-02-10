using JDevl32.Web.ViewModel;
using RevolvingCredit.WebAPI.ViewModel.Interface;

namespace RevolvingCredit.WebAPI.ViewModel
{

	/// <summary>
	/// A view model for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// (Re-)implement as (GUID) identifier unique entity item view model (base class).
	/// </remarks>
	public class AccountViewModel
		:
		UniqueGuidEntityViewModel
		,
		IAccountViewModel
	{

#region Property

#region IAccountViewModel

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Implement setter.
		/// </remarks>
		public short SafeAccountNumber { get; set; }

#endregion

#endregion

	}

}
