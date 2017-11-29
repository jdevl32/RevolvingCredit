using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A line on a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Extend instance mapper base class.
	/// </remarks>
	public class AccountLine
		:
		InstanceMapperBase
		,
		IAccountLine
	{

#region Property

#region IAccountLine

		/// <inheritdoc />
		public int AccountId { get; }

		/// <inheritdoc />
		ILine IAccountLine.Line => Mapper.Map<ILine>(Line);

		/// <inheritdoc />
		public double Limit { get; }

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; }

#endregion

		/// <summary>
		/// The line (type) on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		public Line Line { get; }

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
