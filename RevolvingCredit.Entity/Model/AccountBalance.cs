using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A balance record for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Invert foreign key annotations.
	/// </remarks>
	public class AccountBalance
		:
		InstanceMapperBase
		,
		IAccountBalance
	{

#region Property

#region IAccountBalance

#region EF - Primary Key

#region EF - Foreign Key

		/// <inheritdoc />
		public Guid AccountId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime Timestamp { get; set; }

#endregion

		/// <inheritdoc />
		public double Amount { get; set; }

#region EF - Navigation

#region EF - Foreign Key

		/// <inheritdoc />
		IAccount IAccountBalance.Account
		{
			get => Mapper.Map<IAccount>(Account);
			set => Mapper.Map<Account>(value);
		}

#endregion

#endregion

		/// <inheritdoc />
		IAccountStatement IAccountBalance.Statement
		{
			get => Mapper.Map<IAccountStatement>(Statement);
			set => Mapper.Map<AccountStatement>(value);
		}

#endregion

#region EF - Navigation

#region EF - Foreign Key

		/// <summary>
		/// The account the balance applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("AccountId")]
		public virtual Account Account { get; set; }

#endregion

#endregion

		/// <summary>
		/// The account statement the balance applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add not-mapped annotation.
		/// </remarks>
		[NotMapped]
		public virtual AccountStatement Statement { get; set; }

#endregion

#region Instance Initialization

		/// <inheritdoc />
		public AccountBalance(IMapper mapper)
			:
			base(mapper)
		{
		}

		// todo|jdevl32: implement ctors...

#endregion

	}

}
