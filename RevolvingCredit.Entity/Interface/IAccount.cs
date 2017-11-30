using JDevl32.Entity.Interface;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Reset base as global unique.
	/// </remarks>
	public interface IAccount
		:
		IGlobalUnique
	{

#region Property

		/// <summary>
		/// The (safe) account number.
		/// </summary>
		/// <remarks>
		/// This should only ever contain the last four digits of the actual (full) account number.
		/// Last modification:
		/// </remarks>
		short SafeAccountNumber { get; }

#endregion

	}

}
