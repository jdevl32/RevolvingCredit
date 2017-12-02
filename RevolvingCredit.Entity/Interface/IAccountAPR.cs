using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// An APR for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Invert foreign key annotations.
	/// </remarks>
	public interface IAccountAPR
	{

#region Property

#region EF - Primary Key

#region EF - Foreign Key

		/// <summary>
		/// The id of the account the APR applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		Guid AccountId { get; set; }

		/// <summary>
		/// The id of the APR (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		int TypeId { get; set; }

#endregion

		/// <summary>
		/// The update timestamp of the APR for the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		DateTime UpdateTimestamp { get; set; }

#endregion

		/// <summary>
		/// The APR (value).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		double APR { get; set; }

#region EF - Navigation

#region EF - Foreign Key

		/// <summary>
		/// The account the APR applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("AccountId")]
		IAccount Account { get; set; }

		/// <summary>
		/// The APR (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("TypeId")]
		IAPR Type { get; set; }

#endregion

#endregion

#endregion

	}

}
