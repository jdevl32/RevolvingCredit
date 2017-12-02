using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A note on a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Invert foreign key annotations.
	/// </remarks>
	public class AccountNote
		:
		InstanceMapperBase
		,
		IAccountNote
	{

#region Property

#region IAccountNote

#region EF - Primary Key

#region EF - Foreign Key

		/// <inheritdoc />
		public Guid AccountId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; set; }

#endregion

		/// <inheritdoc />
		public string Contents { get; set; }

#region EF - Navigation

#region EF - Foreign Key

		/// <inheritdoc />
		IAccount IAccountNote.Account
		{
			get => Mapper.Map<IAccount>(Account);
			set => Mapper.Map<Account>(value);
		}

#endregion

#endregion

#endregion

#region EF - Navigation

#region EF - Foreign Key

		/// <summary>
		/// The account the note applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("AccountId")]
		public virtual Account Account { get; set; }

#endregion

#endregion

#endregion

#region Instance Initialization

		/// <inheritdoc />
		public AccountNote(IMapper mapper)
			:
			base(mapper)
		{
		}

		// todo|jdevl32: implement ctors...

#endregion

	}

}
