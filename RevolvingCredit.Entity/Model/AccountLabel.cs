using AutoMapper;
using RevolvingCredit.Entity.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A (major) label for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AccountLabel
		:
		IAccountLabel
	{

#region Property

#region IAccountLabel

		/// <inheritdoc />
		public int AccountId { get; }

		/// <inheritdoc />
		ILabel IAccountLabel.Label => Mapper.Map<ILabel>(Label);

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; }

#endregion

		/// <summary>
		/// The label for the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		public Label Label { get; }

#endregion

#region Instance Initialization

//#region UniqueBase

//		/// <inheritdoc />
//		public AccountLabel(int id)
//			:
//			base(id)
//		{
//		}

//		/// <inheritdoc />
//		public AccountLabel(int id, string shortName, string fullName, string description)
//			:
//			base(id, shortName, fullName, description)
//		{
//		}

//		/// <inheritdoc />
//		public AccountLabel(string shortName, string fullName, string description)
//			:
//			base(shortName, fullName, description)
//		{
//		}

//#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
