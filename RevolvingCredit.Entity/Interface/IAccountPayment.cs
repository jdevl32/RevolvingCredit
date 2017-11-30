using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A payment record for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Implement (missing) payment type.
	/// Re-engineer using EF navigation properties.
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
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		Guid AccountId { get; set; }

		/// <summary>
		/// The id of the payment (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		int TypeId { get; set; }

#endregion

		/// <summary>
		/// The due timestamp of the payment.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		DateTime Due { get; set; }

#endregion

		/// <summary>
		/// The payment amount.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
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
		IAccount Account { get; }

		/// <summary>
		/// The payment (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IPayment Type { get; }

#endregion

#endregion

	}
}