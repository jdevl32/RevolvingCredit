using RevolvingCredit.Entity.Interface;
using System;

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
		//UniqueBase
		//,
		IAccountAPR
	{

#region Property

#region IAccountAPR

		/// <inheritdoc />
		public int AccountId { get; }

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; }

		// todo|jdevl32: implement auto-mapper...
		/// <inheritdoc />
		IAPR IAccountAPR.Type { get; }

		/// <inheritdoc />
		public double APR { get; }

#endregion

		/// <summary>
		/// The APR (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
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
