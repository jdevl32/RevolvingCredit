using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A balance record for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public interface IAccountBalance
	{

#region Property

#region EF - Primary Key

#region EF - Foreign Key

		/// <summary>
		/// The id of the account the balance applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("Account")]
		[Required]
		Guid AccountId { get; set; }

		// todo|jdevl32: probably not needed...
		///// <summary>
		///// The id of the balance (type).
		///// </summary>
		///// <remarks>
		///// Last modification:
		///// </remarks>
		//[ForeignKey("Type")]
		//[Required]
		//int TypeId { get; set; }

#endregion

		/// <summary>
		/// The timestamp of the balance.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		DateTime Timestamp { get; set; }

#endregion

		/// <summary>
		/// The balance amount.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		double Amount { get; set; }

#region EF - Navigation

		/// <summary>
		/// The account the balance applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAccount Account { get; set; }

		// todo|jdevl32: probably not needed...
		///// <summary>
		///// The balance (type).
		///// </summary>
		///// <remarks>
		///// Last modification:
		///// </remarks>
		//IBalance Type { get; set; }

#endregion

		/// <summary>
		/// The account statement the balance applies to.
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
