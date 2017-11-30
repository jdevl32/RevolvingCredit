using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A note on a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Extend instance mapper base class.
	/// Re-engineer using EF navigation properties.
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
		public int AccountId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; set; }

#endregion

		/// <inheritdoc />
		public string Note { get; }

#region EF - Navigation

		/// <inheritdoc />
		IAccount IAccountNote.Account => Mapper.Map<IAccount>(Account);

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the note applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; }

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
