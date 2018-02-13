using JDevl32.Web.Repository.Generic;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.WebAPI.Repository
{

	/// <inheritdoc />
	/// <summary>
	/// A (major) label repository.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class LabelRepository
		:
		InformableUniqueIntEntityContextRepositoryBase<RevolvingCreditContext, Label>
	{

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public LabelRepository(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory)
			:
			base(entityContext, loggerFactory, entityContext.Label)
		{
		}

#endregion

	}

}
