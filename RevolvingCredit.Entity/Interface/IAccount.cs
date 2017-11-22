using JDevl32.Entity.Interface;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public interface IAccount
		:
		IUnique
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
