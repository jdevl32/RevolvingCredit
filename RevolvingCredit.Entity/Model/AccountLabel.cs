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
	/// Re-engineer using EF navigation properties.
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
		IAccount IAccountLabel.Account => Mapper.Map<IAccount>(Account);

		/// <inheritdoc />
		ILabel IAccountLabel.Label => Mapper.Map<ILabel>(Label);

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the label applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; }

		/// <summary>
		/// The label for the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Label Label { get; }

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
