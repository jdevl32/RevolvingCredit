using AutoMapper;
using JDevl32.Web.Repository;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Interface;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.WebAPI.Repository
{

	/// <summary>
	/// The APR (type) repository.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// (Re-)implement as unique item (APR (type)) entity context repository (base class).
	/// </remarks>
	public class APRRepository
		:
		UniqueEntityContextRepositoryBase<APRRepository, RevolvingCreditContext, IAPR, APR>
		// todo|jdevl32: cleanup...
		//,
		//IAPRRepository
	{

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRRepository(RevolvingCreditContext entityContext, ILogger<APRRepository> logger, IMapper mapper)
			:
			base(entityContext, logger, mapper)
		{
		}

#endregion

		/**
#region Property

		private string UniqueController_DisplayName { get; } = "APR (type)";

#endregion

#region Instance Initialization

		/// <summary>
		/// Create an APR (type) repository.
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
			Logger.LogInformation($"Get the list of (all) the {UniqueController_DisplayName}(s) from the entity context...");

			return GetUniqueEntityDbSet().ToList();
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// (Re-)implement using (list of) APR (type)(s).
		/// </remarks>
		public void Remove()
		{
			Logger.LogInformation($"Remove (all) the {UniqueController_DisplayName}(s) from the entity context...");

			GetUniqueEntityDbSet().RemoveRange(GetUniqueEntityDbSet().ToList());
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public void Remove(IAPR apr)
		{
			Logger.LogInformation($"Remove the {UniqueController_DisplayName} ({apr}) from the entity context...");

			GetUniqueEntityDbSet().Remove(Mapper.Map<APR>(apr));
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public void Update(IAPR apr)
		{
			Logger.LogInformation($"Update the entity context with the {UniqueController_DisplayName} ({apr})...");

			GetUniqueEntityDbSet().Update(Mapper.Map<APR>(apr));
		}

#endregion

		private DbSet<APR> GetUniqueEntityDbSet() => EntityContext.APR;
		/**/

	}

}
