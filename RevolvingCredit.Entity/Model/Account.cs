using JDevl32.Entity.Model;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
	/// </remarks>
	public class Account
		:
		UniqueGuidEntity
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

	}

}
