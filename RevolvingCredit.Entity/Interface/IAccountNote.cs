using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A note on a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public interface IAccountNote
	{

#region Property

		/// <summary>
		/// The id of the account the note applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		int AccountId { get; }

		/// <summary>
		/// The note on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		string Note { get; }

		/// <summary>
		/// The update timestamp of the note on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		DateTime UpdateTimestamp { get; }

#endregion

	}

}
