using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A (major) label for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add (EF-required) setters.
	/// </remarks>
	public class AccountLabel
		:
		InstanceMapperBase
		,
		IAccountLabel
	{

#region Property

#region IAccountLabel

#region EF - Primary Key

#region EF - Foreign Key

		/// <inheritdoc />
		public Guid AccountId { get; set; }

		/// <inheritdoc />
		public int LabelId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; set; }

#endregion

#region EF - Navigation

		/// <inheritdoc />
		IAccount IAccountLabel.Account
		{
			get => Mapper.Map<IAccount>(Account);
			set => Mapper.Map<Account>(value);
		}

		/// <inheritdoc />
		ILabel IAccountLabel.Label
		{
			get => Mapper.Map<ILabel>(Label);
			set => Mapper.Map<Label>(value);
		}

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the label applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; set; }

		/// <summary>
		/// The label for the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Label Label { get; set; }

#endregion

#endregion

#region Instance Initialization

#region InstanceMapperBase

		/// <inheritdoc />
		public AccountLabel(IMapper mapper)
			:
			base(mapper)
		{
		}

#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
