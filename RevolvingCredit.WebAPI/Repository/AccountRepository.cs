using JDevl32.Web.Repository.Generic;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.WebAPI.Repository
{

	/// <summary>
	/// A revolvling credit account repository.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AccountRepository
		:
		InformableUniqueGuidEntityContextRepositoryBase<RevolvingCreditContext, Account>
	{

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public AccountRepository(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory)
			:
			base(entityContext, loggerFactory, entityContext.Account)
		{
		}

#endregion

	}

}
