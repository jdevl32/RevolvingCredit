using AutoMapper;
using JDevl32.Web.Repository;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Interface;
using RevolvingCredit.WebAPI.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace RevolvingCredit.WebAPI.Repository
{

	/// <summary>
	/// The APR repository.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Change references to revolving credit context from interface to implementation.
	/// </remarks>
	public class APRRepository
		:
		EntityContextRepositoryBase<APRRepository, RevolvingCreditContext>
		,
		IAPRRepository
	{

#region Property

#endregion

#region Instance Initialization

		/// <summary>
		/// Create an APR repository.
		/// </summary>
		/// <param name="revolvingCreditContext">
		/// The revolving credit context.
		/// </param>
		/// <param name="logger">
		/// The logger.
		/// </param>
		/// <param name="mapper">
		/// The mapper.
		/// </param>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRRepository(RevolvingCreditContext revolvingCreditContext, ILogger<APRRepository> logger, IMapper mapper)
			:
			base(revolvingCreditContext, logger, mapper)
		{
		}

#endregion

#region IAPRRepository

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public IEnumerable<IAPR> GetAPR() => EntityContext.APR.ToList();

#endregion

	}

}
