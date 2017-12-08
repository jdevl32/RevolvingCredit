using JDevl32.Entity.Model;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add (EF-required) setters.
	/// </remarks>
	public class Account
		:
		GlobalUniqueBase
		,
		IAccount
	{

#region Property

#region IAccount

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public short SafeAccountNumber { get; set; }

#endregion

#endregion

#region Instance Initialization

		// todo|jdevl32: ???
		/**
		/// <summary>
		/// Create an account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Account()
		{
		}
		**/

		// todo|jdevl32: implement ctors...

#endregion

	}

}
