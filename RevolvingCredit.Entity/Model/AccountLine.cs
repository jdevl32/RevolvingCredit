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
	/// Add (EF-required) setters.
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
		public Guid AccountId { get; set; }

		/// <inheritdoc />
		public int LineId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; set; }

#endregion

		/// <inheritdoc />
		public double Limit { get; set; }

#region EF - Navigation

		/// <inheritdoc />
		IAccount IAccountLine.Account
		{
			get => Mapper.Map<IAccount>(Account);
			set => Mapper.Map<Account>(value);
		}

		/// <inheritdoc />
		ILine IAccountLine.Line
		{
			get => Mapper.Map<ILine>(Line);
			set => Mapper.Map<Line>(value);
		}

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the line applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; set; }

		/// <summary>
		/// The line (type) on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Line Line { get; set; }

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
