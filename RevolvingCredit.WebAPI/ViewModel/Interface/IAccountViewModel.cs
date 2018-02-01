using JDevl32.Entity.Interface.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.WebAPI.ViewModel.Interface
{

	/// <summary>
	/// A view model for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
	/// </remarks>
	public interface IAccountViewModel
		:
		IUniqueEntity<Guid>
	{

#region Property

		// todo|jdevl32: setter required ???
		/// <summary>
		/// The (safe) account number.
		/// </summary>
		/// <remarks>
		/// This should only ever contain the last four digits of the actual (full) account number.
		/// Last modification:
		/// </remarks>
		[Required(AllowEmptyStrings = false)]
		short SafeAccountNumber { get; }

#endregion

	}

}
