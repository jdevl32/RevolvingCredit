using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A line for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AccountLine
		:
		//UniqueBase
		//,
		IAccountLine
	{

#region Property

#region IAccountLine

		/// <inheritdoc />
		public int AccountId { get; }

		// todo|jdevl32: implement auto-mapper...
		/// <inheritdoc />
		ILine IAccountLine.Line { get; }

		/// <inheritdoc />
		public double Limit { get; }

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; }

#endregion

		/// <summary>
		/// The line (type) on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Line Line { get; }

#endregion

#region Instance Initialization

//#region UniqueBase

//		/// <inheritdoc />
//		public AccountLine(int id)
//			:
//			base(id)
//		{
//		}

//		/// <inheritdoc />
//		public AccountLine(int id, string shortName, string fullName, string description)
//			:
//			base(id, shortName, fullName, description)
//		{
//		}

//		/// <inheritdoc />
//		public AccountLine(string shortName, string fullName, string description)
//			:
//			base(shortName, fullName, description)
//		{
//		}

//#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
