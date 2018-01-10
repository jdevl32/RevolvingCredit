using JDevl32.Entity.Model;
using RevolvingCredit.WebAPI.ViewModel.Interface;

namespace RevolvingCredit.WebAPI.ViewModel
{

	/// <summary>
	/// A view model for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AccountViewModel
		:
		GlobalUniqueBase
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

#region Instance Initialization

		// todo|jdevl32: implement ctors...

#endregion

	}

}
