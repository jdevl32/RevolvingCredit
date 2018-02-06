using JDevl32.Entity.Generic;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity.Model;
using System.Linq;
using System.Threading.Tasks;

namespace RevolvingCredit.Entity
{

	/// <summary>
	/// An APR sower (seeder).
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor loggable logger category name.
	/// </remarks>
	public class APRSower
		:
		EntityContextSowerBase<RevolvingCreditContext>
	{

#region Property

#endregion

#region Instance Initialization

#region EntityContextSowerBase<RevolvingCreditContext>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Refactor loggable logger category name.
		/// </remarks>
		public APRSower(RevolvingCreditContext revolvingCreditContext, ILoggerFactory loggerFactory)
			:
			base(revolvingCreditContext, loggerFactory)
		{
		}

#endregion

#endregion

#region EntityContextSowerBase<RevolvingCreditContext>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Add database generated identity annotation.
		/// Enhance logging.
		/// </remarks>
		public override async Task Seed()
		{
			Logger.LogInformation("Seed APR...");

			var @new = string.Empty;

			if (EntityContext.APR.Any())
			{
				Logger.LogInformation("...APR already seeded.");
			} // if
			else
			{
				@new = "New ";

				await EntityContext.APR.AddRangeAsync
					(
						new APR
						{
							Description = "APR that applies to the line of cash for a revolving credit account."
							,
							FullName = "Cash APR"
							//,
							//Id = 1
							,
							ShortName = "Cash"
						}
						,
						new APR
						{
							Description = "APR that applies to the line of credit for a revolving credit account."
							,
							FullName = "Credit APR"
							//,
							//Id = 2
							,
							ShortName = "Credit"
						}
					);

				await EntityContext.SaveChangesAsync();
			} // else

			Logger.LogInformation($"{@new}APR count = {EntityContext.APR.Count()}.");
		}

#endregion

	}

}
