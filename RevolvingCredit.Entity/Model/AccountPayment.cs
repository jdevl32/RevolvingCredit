using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A payment record for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Extend instance mapper base class.
	/// Re-engineer using EF navigation properties.
	/// </remarks>
	public class AccountPayment
		:
		InstanceMapperBase
		,
		IAccountPayment
	{

#region Property

#region IAccountPayment

#region EF - Primary Key

#region EF - Foreign Key

		/// <inheritdoc />
		public int AccountId { get; set; }

		/// <inheritdoc />
		public int TypeId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime Due { get; set; }

#endregion

		/// <inheritdoc />
		public double Amount { get; }

#region EF - Navigation

		/// <inheritdoc />
		IAccount IAccountPayment.Account => Mapper.Map<IAccount>(Account);

		/// <inheritdoc />
		IPayment IAccountPayment.Type => Mapper.Map<IPayment>(Type);

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the payment applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; }

		/// <summary>
		/// The payment (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Payment Type { get; }

#endregion

#endregion

#region Instance Initialization

		/// <inheritdoc />
		public AccountPayment(IMapper mapper)
			:
			base(mapper)
		{
		}

		// todo|jdevl32: implement ctors...

#endregion

	}

}
