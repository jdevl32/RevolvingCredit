using JDevl32.Entity.Interface;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add (EF-required) setters.
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
		[Required(AllowEmptyStrings = false)]
		short SafeAccountNumber { get; set; }

#endregion

	}

}
