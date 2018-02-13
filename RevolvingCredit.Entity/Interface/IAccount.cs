using JDevl32.Entity.Interface.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Interface
{

	/// <inheritdoc />
	/// <summary>
	/// A revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
	/// </remarks>
	public interface IAccount
		:
		IUniqueEntity<Guid>
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
