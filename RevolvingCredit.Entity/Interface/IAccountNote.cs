using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A note on a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Invert foreign key annotations.
	/// </remarks>
	public interface IAccountNote
	{

#region Property

#region EF - Primary Key

#region EF - Foreign Key

		/// <summary>
		/// The id of the account the note applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		Guid AccountId { get; set; }

#endregion

		/// <summary>
		/// The update timestamp of the note on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		DateTime UpdateTimestamp { get; set; }

#endregion

		/// <summary>
		/// The note (contents) on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		string Contents { get; set; }

#region EF - Navigation

#region EF - Foreign Key

		/// <summary>
		/// The account the note applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("AccountId")]
		IAccount Account { get; set; }

#endregion

#endregion

#endregion

	}

}
