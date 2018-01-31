using JDevl32.Entity.Model;
using RevolvingCredit.WebAPI.ViewModel.Interface;

namespace RevolvingCredit.WebAPI.ViewModel
{

	/// <summary>
	/// A view model for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
	/// </remarks>
	public class AccountViewModel
		:
		GuidUniqueEntity
		,
		IAccountViewModel
	{

#region Property

#region IAccountViewModel

		// todo|jdevl32: setter required ???
		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public short SafeAccountNumber { get; }

#endregion

#endregion

	}

}
