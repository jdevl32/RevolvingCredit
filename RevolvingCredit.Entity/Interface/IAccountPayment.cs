using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A payment record for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Re-implement account statement (not as EF navigation property).
	/// </remarks>
	public interface IAccountPayment
	{

#region Property

#region EF - Primary Key

#region EF - Foreign Key

		/// <summary>
		/// The id of the account the payment applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("Account")]
		[Required]
		Guid AccountId { get; set; }

		/// <summary>
		/// The id of the payment (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("Type")]
		[Required]
		int TypeId { get; set; }

#endregion

		/// <summary>
		/// The due timestamp of the payment.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		DateTime Due { get; set; }

#endregion

		/// <summary>
		/// The payment amount.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		double Amount { get; set; }

#region EF - Navigation

		/// <summary>
		/// The account the payment applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAccount Account { get; set; }

		/// <summary>
		/// The payment (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IPayment Type { get; set; }

#endregion

		/// <summary>
		/// The account statement the payment applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add not-mapped annotation.
		/// </remarks>
		[NotMapped]
		IAccountStatement Statement { get; set; }

#endregion

	}
}