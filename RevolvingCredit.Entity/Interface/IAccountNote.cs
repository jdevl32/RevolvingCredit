using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A note on a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Re-engineer using EF navigation properties.
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
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		Guid AccountId { get; set; }

#endregion

		/// <summary>
		/// The update timestamp of the note on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		DateTime UpdateTimestamp { get; set; }

#endregion

		/// <summary>
		/// The note (contents) on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		string Contents { get; set; }

#region EF - Navigation

		/// <summary>
		/// The account the note applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAccount Account { get; }

#endregion

#endregion

	}

}
