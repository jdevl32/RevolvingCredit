using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A payment record for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AccountPayment
		:
		IAccountPayment
	{

#region Property

#region IAccountPayment

		/// <inheritdoc />
		public int AccountId { get; }

		/// <inheritdoc />
		public DateTime Due { get; }

		/// <inheritdoc />
		public double Amount { get; }

#endregion

#endregion

#region Instance Initialization

//#region UniqueBase

//		/// <inheritdoc />
//		public AccountPayment(int id)
//			:
//			base(id)
//		{
//		}

//		/// <inheritdoc />
//		public AccountPayment(int id, string shortName, string fullName, string description)
//			:
//			base(id, shortName, fullName, description)
//		{
//		}

//		/// <inheritdoc />
//		public AccountPayment(string shortName, string fullName, string description)
//			:
//			base(shortName, fullName, description)
//		{
//		}

//#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
