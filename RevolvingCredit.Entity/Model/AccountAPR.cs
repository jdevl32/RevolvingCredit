using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// An APR for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Invert foreign key annotations.
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

#region EF - Foreign Key

		/// <inheritdoc />
		IAccount IAccountAPR.Account
		{
			get => Mapper.Map<IAccount>(Account);
			set => Mapper.Map<Account>(value);
		}

		/// <inheritdoc />
		IAPR IAccountAPR.Type
		{
			get => Mapper.Map<IAPR>(Type);
			set => Mapper.Map<APR>(value);
		}

#endregion

#endregion

#endregion

#region EF - Navigation

#region EF - Foreign Key

		/// <summary>
		/// The account the APR applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("AccountId")]
		public virtual Account Account { get; set; }

		/// <summary>
		/// The APR (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("TypeId")]
		public virtual APR Type { get; set; }

#endregion

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
