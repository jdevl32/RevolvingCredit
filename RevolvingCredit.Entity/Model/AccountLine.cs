using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A line on a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Re-engineer using EF navigation properties.
	/// </remarks>
	public class AccountLine
		:
		InstanceMapperBase
		,
		IAccountLine
	{

#region Property

#region IAccountLine

#region EF - Primary Key

#region EF - Foreign Key

		/// <inheritdoc />
		public int AccountId { get; set; }

		/// <inheritdoc />
		public int LineId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; set; }

#endregion

		/// <inheritdoc />
		public double Limit { get; }

#region EF - Navigation

		/// <inheritdoc />
		IAccount IAccountLine.Account => Mapper.Map<IAccount>(Account);

		/// <inheritdoc />
		ILine IAccountLine.Line => Mapper.Map<ILine>(Line);

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the line applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; }

		/// <summary>
		/// The line (type) on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Line Line { get; }

#endregion

#endregion

#region Instance Initialization

#region InstanceMapperBase

		/// <inheritdoc />
		public AccountLine(IMapper mapper)
			:
			base(mapper)
		{
		}

#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
