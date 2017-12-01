using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A promotion for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add foreign key annotations.
	/// Add (EF-required) setters.
	/// </remarks>
	public interface IAccountPromotion
	{

#region Property

#region EF - Primary Key

#region EF - Foreign Key

		/// <summary>
		/// The id of the account the promotion applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("Account")]
		[Required]
		Guid AccountId { get; set; }

		/// <summary>
		/// The id of the APR (type) for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("Type")]
		[Required]
		int TypeId { get; set; }

#endregion

		/// <summary>
		/// The start timestamp of the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		DateTime Start { get; set; }

		/// <summary>
		/// The end timestamp of the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		DateTime End { get; set; }

#endregion

		/// <summary>
		/// The APR for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		double APR { get; set; }

#region EF - Navigation

		/// <summary>
		/// The account the promotion applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAccount Account { get; set; }

		/// <summary>
		/// The APR (type) for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAPR Type { get; set; }

#endregion

#endregion

	}

}
