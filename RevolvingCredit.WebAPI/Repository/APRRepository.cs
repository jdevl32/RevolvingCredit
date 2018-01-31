using AutoMapper;
using JDevl32.Web.Repository.Generic;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.WebAPI.Repository
{

	/// <summary>
	/// An APR (type) repository.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
	/// Add the type of the unique entity item.
	/// </remarks>
	public class APRRepository
		:
		InformableIntUniqueEntityContextRepositoryBase<APRRepository, RevolvingCreditContext, APR>
	{

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
		/// </remarks>
		public APRRepository(RevolvingCreditContext entityContext, ILogger<APRRepository> logger, IMapper mapper)
			:
			base(entityContext, logger, mapper, entityContext.APR)
		{
		}

#endregion

	}

}
