using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A line on a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add foreign key annotations.
	/// Add (EF-required) setters.
	/// </remarks>
	public interface IAccountLine
	{

#region Property

#region EF - Primary Key

#region EF - Foreign Key

		/// <summary>
		/// The id of the account the line applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("Account")]
		[Required]
		Guid AccountId { get; set; }

		/// <summary>
		/// The id of the line (type) on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("Line")]
		[Required]
		int LineId { get; set; }

#endregion

		/// <summary>
		/// The update timestamp of the line on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		DateTime UpdateTimestamp { get; set; }

#endregion

		/// <summary>
		/// The limit of the line on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		double Limit { get; set; }

#region EF - Navigation

		/// <summary>
		/// The account the line applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAccount Account { get; set; }

		/// <summary>
		/// The line (type) on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		ILine Line { get; set; }

#endregion

#endregion

	}

}
