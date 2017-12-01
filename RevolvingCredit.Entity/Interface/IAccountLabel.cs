using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A (major) label for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add foreign key annotations.
	/// Add (EF-required) setters.
	/// </remarks>
	public interface IAccountLabel
	{

#region Property

#region EF - Primary Key

#region EF - Foreign Key

		/// <summary>
		/// The id of the account the label applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("Account")]
		[Required]
		Guid AccountId { get; set; }

		/// <summary>
		/// The id of the label for the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("Label")]
		[Required]
		int LabelId { get; set; }

#endregion

		/// <summary>
		/// The update timestamp of the label for the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		DateTime UpdateTimestamp { get; set; }

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the label applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAccount Account { get; set; }

		/// <summary>
		/// The label for the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		ILabel Label { get; set; }

#endregion

#endregion

	}

}
