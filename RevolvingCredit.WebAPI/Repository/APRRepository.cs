using AutoMapper;
using JDevl32.Web.Repository;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Interface;
using RevolvingCredit.Entity.Model;
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
	/// Implement remove APR.
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
		/// Add logging.
		/// </remarks>
		public IEnumerable<IAPR> Get()
		{
			Logger.LogInformation($"Get the list of APRs from the entity context...");

			return EntityContext.APR.ToList();
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public void Remove()
		{
			Logger.LogInformation($"Remove (all) APRs from the entity context...");

			EntityContext.APR.RemoveRange();
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public void Remove(IAPR apr)
		{
			Logger.LogInformation($"Remove APR ({apr}) from the entity context...");

			EntityContext.APR.Remove(Mapper.Map<APR>(apr));
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public void Update(IAPR apr)
		{
			Logger.LogInformation($"Update the entity context with APR ({apr})...");

			EntityContext.APR.Update(Mapper.Map<APR>(apr));
		}

#endregion

	}

}
