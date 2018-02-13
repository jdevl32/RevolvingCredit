using JDevl32.Entity.Generic;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RevolvingCredit.Entity.Model.Sower
{

	/// <inheritdoc />
	/// <summary>
	/// A line (type) sower (seeder).
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class LineSower
		:
		InformableUniqueIntEntityContextSowerBase<RevolvingCreditContext, Line>
	{

#region Constant

		/// <summary>
		/// The (default) display name.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public const string DefaultDisplayName = "Line (type)";

#endregion

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public LineSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory)
			:
			this(entityContext, loggerFactory, DefaultDisplayName)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public LineSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, string displayName)
			:
			this(entityContext, loggerFactory, displayName, GetDefaultEntity(displayName))
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public LineSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, string displayName, IEnumerable<Line> entity)
			:
			base(entityContext, loggerFactory, displayName, entity)
		{
		}

#endregion

#region Overrides of EntityContextSowerBase<RevolvingCreditContext>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public override async Task Seed()
			=>
			await Seed(EntityContext.Line);

#endregion

		/// <summary>
		/// Get the default (set of) unique entity item(s) to seed.
		/// </summary>
		/// <param name="displayName">
		/// A display name.
		/// </param>
		/// <returns>
		/// The default (set of) unique entity item(s) to seed.
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public static IEnumerable<Line> GetDefaultEntity(string displayName)
			=>
			new []
			{
				new Line
				{
					Description = $"{displayName} that applies to the line of cash for a revolving credit account."
					,
					FullName = "Cash Line"
					,
					ShortName = "Cash"
				}
				,
				new Line
				{
					Description = $"{displayName} that applies to the line of credit for a revolving credit account."
					,
					FullName = "Credit Line"
					,
					ShortName = "Credit"
				}
			}
		;
	}

}
