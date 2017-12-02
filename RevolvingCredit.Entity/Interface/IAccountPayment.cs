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
	/// Invert foreign key annotations.
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
		[Required]
		Guid AccountId { get; set; }

		/// <summary>
		/// The id of the payment (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
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

#region EF - Foreign Key

		/// <summary>
		/// The account the payment applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("AccountId")]
		IAccount Account { get; set; }

		/// <summary>
		/// The payment (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("TypeId")]
		IPayment Type { get; set; }

#endregion

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