using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// An APR for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add (EF-required) setters.
	/// </remarks>
	public class AccountAPR
		:
		InstanceMapperBase
		,
		IAccountAPR
	{

#region Property

#region IAccountAPR

#region EF - Primary Key

#region EF - Foreign Key

		/// <inheritdoc />
		public Guid AccountId { get; set; }

		/// <inheritdoc />
		public int TypeId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; set; }

#endregion

		/// <inheritdoc />
		public double APR { get; set; }

#region EF - Navigation

		/// <inheritdoc />
		IAccount IAccountAPR.Account => Mapper.Map<IAccount>(Account);

		/// <inheritdoc />
		IAPR IAccountAPR.Type => Mapper.Map<IAPR>(Type);

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the APR applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; }

		/// <summary>
		/// The APR (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual APR Type { get; }

#endregion

#endregion

#region Instance Initialization

#region InstanceMapperBase

		/// <inheritdoc />
		public AccountAPR(IMapper mapper)
			:
			base(mapper)
		{
		}

#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
