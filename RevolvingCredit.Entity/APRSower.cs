using JDevl32.Entity.Generic;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity.Model;
using System.Linq;
using System.Threading.Tasks;

namespace RevolvingCredit.Entity
{

	/// <summary>
	/// An APR (type) sower (seeder).
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// (Re-)implement as (generic) informable entity context sower (base class).
	/// </remarks>
	public class APRSower
		:
		InformableEntityContextSowerBase<RevolvingCreditContext>
	{

#region Constant

		/// <summary>
		/// The (default) display name.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public const string DefaultDisplayName = "APR (type)";

#endregion

#region Property

#endregion

#region Instance Initialization

#region InformableEntityContextSowerBase<RevolvingCreditContext>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Refactor loggable logger category name.
		/// </remarks>
		public APRSower(RevolvingCreditContext revolvingCreditContext, ILoggerFactory loggerFactory)
			:
			this(revolvingCreditContext, loggerFactory, DefaultDisplayName)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		protected APRSower(RevolvingCreditContext revolvingCreditContext, ILoggerFactory loggerFactory, string displayName)
			:
			base(revolvingCreditContext, loggerFactory, displayName)
		{
		}

#endregion

#endregion

#region EntityContextSowerBase<RevolvingCreditContext>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// (Re-)implement as (generic) informable entity context sower (base class).
		/// </remarks>
		public override async Task Seed()
		{
			Logger.LogInformation($"Seed {DisplayName}...");

			var @new = string.Empty;

			if (EntityContext.APR.Any())
			{
				Logger.LogInformation($"...{DisplayName} already seeded.");
			} // if
			else
			{
				@new = "New ";

				await EntityContext.APR.AddRangeAsync
					(
						new APR
						{
							Description = $"{DisplayName} that applies to the line of cash for a revolving credit account."
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
							Description = $"{DisplayName} that applies to the line of credit for a revolving credit account."
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

			Logger.LogInformation($"{@new}{DisplayName} count = {EntityContext.APR.Count()}.");
		}

#endregion

	}

}
