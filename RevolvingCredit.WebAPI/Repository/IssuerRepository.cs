using JDevl32.Web.Repository.Generic;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.WebAPI.Repository
{

	/// <inheritdoc />
	/// <summary>
	/// An issuer repository.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class IssuerRepository
		:
		InformableUniqueIntEntityContextRepositoryBase<RevolvingCreditContext, Issuer>
	{

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public IssuerRepository(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory)
			:
			base(entityContext, loggerFactory, entityContext.Issuer)
		{
		}

#endregion

	}

}
