using AutoMapper;
using JDevl32.Web.Repository.Generic;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.WebAPI.Repository
{

	/// <summary>
	/// The APR (type) repository.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add unique item type to unique item entity context repository (base class).
	/// </remarks>
	public class APRRepository
		:
		UniqueInformableEntityContextRepositoryBase<APRRepository, RevolvingCreditContext, APR>
	{

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Replace method to get a db-set of (all) the APR type(s) with property.
		/// </remarks>
		public APRRepository(RevolvingCreditContext entityContext, ILogger<APRRepository> logger, IMapper mapper)
			:
			base(entityContext, logger, mapper, entityContext.APR)
		{
		}

#endregion

	}

}
