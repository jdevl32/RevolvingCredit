using AutoMapper;
using RevolvingCredit.Entity.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// An APR for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AccountAPR
		:
		IAccountAPR
	{

#region Property

#region IAccountAPR

		/// <inheritdoc />
		public int AccountId { get; }

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; }

		/// <inheritdoc />
		IAPR IAccountAPR.Type => Mapper.Map<IAPR>(Type);

		/// <inheritdoc />
		public double APR { get; }

#endregion

		/// <summary>
		/// The APR (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		public APR Type { get; }

#endregion

#region Instance Initialization

//#region UniqueBase

//		/// <inheritdoc />
//		public AccountAPR(int id)
//			:
//			base(id)
//		{
//		}

//		/// <inheritdoc />
//		public AccountAPR(int id, string shortName, string fullName, string description)
//			:
//			base(id, shortName, fullName, description)
//		{
//		}

//		/// <inheritdoc />
//		public AccountAPR(string shortName, string fullName, string description)
//			:
//			base(shortName, fullName, description)
//		{
//		}

//#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
