using AutoMapper;
using JDevl32.Entity.Interface;
using JDevl32.Entity.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity.Interface;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.Entity
{

	/// <summary>
	/// The revolving credit database context.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Change base class to mapper entity context.
	/// </remarks>
	public class RevolvingCreditContext
		:
		MapperEntityContextBase
		,
		IRevolvingCreditContext
	{

#region Property

#region MapperEntityContextBase

		/// <summary>
		/// The database connection string key.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public override string ConnectionStringKey { get; } = "ConnectionStrings:RevolvingCreditConnection";

		/// <summary>
		/// The logger.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public new ILogger<RevolvingCreditContext> Logger { get; }

#endregion

#region IRevolvingCreditContext

		/// <summary>
		/// The logger.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		ILogger<IRevolvingCreditContext> IEntityContext<IRevolvingCreditContext>.Logger
			=> Mapper.Map<ILogger<IRevolvingCreditContext>>(Logger);

#endregion

		/// <inheritdoc />
		public DbSet<Account> Account { get; set; }

		/// <inheritdoc />
		public DbSet<AccountAPR> AccountAPR { get; set; }

		/// <inheritdoc />
		public DbSet<AccountIssuer> AccountIssuer { get; set; }

		/// <inheritdoc />
		public DbSet<AccountLabel> AccountLabel { get; set; }

		/// <inheritdoc />
		public DbSet<AccountLine> AccountLine { get; set; }

		/// <inheritdoc />
		public DbSet<AccountNote> AccountNote { get; set; }

		/// <inheritdoc />
		public DbSet<AccountPayment> AccountPayment { get; set; }

		/// <inheritdoc />
		public DbSet<AccountPromotion> AccountPromotion { get; set; }

		/// <inheritdoc />
		public DbSet<AccountStatement> AccountStatement { get; set; }

		/// <inheritdoc />
		public DbSet<APR> APR { get; set; }

		/// <inheritdoc />
		public DbSet<Issuer> Issuer { get; set; }

		/// <inheritdoc />
		public DbSet<Label> Label { get; set; }

		/// <inheritdoc />
		public DbSet<Line> Line { get; set; }

		/// <inheritdoc />
		public DbSet<Payment> Payment { get; set; }

#endregion

#region Instance Initialization

		/// <inheritdoc />
		public RevolvingCreditContext(DbContextOptions dbContextOptions, IConfigurationRoot configurationRoot, IHostingEnvironment hostingEnvironment, ILogger<RevolvingCreditContext> logger, IMapper mapper)
			:
			base(dbContextOptions, configurationRoot, hostingEnvironment, logger, mapper)
			=>
			SetLogger(logger);

		/// <inheritdoc />
		public RevolvingCreditContext(DbContextOptions dbContextOptions, IConfigurationRoot configurationRoot, IHostingEnvironment hostingEnvironment, ILogger<RevolvingCreditContext> logger, IMapper mapper, string connectionStringKey)
			:
			base(dbContextOptions, configurationRoot, hostingEnvironment, logger, mapper, connectionStringKey)
			=>
			SetLogger(logger);

		// todo|jdevl32: implement ctors...

#endregion

#region DbContext

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AccountAPR>()
				.HasKey
					(
						accountAPR => new
						{
							accountAPR.AccountId
							,
							accountAPR.TypeId
							,
							accountAPR.UpdateTimestamp
						}
					)
			;
			modelBuilder.Entity<AccountIssuer>()
				.HasKey
					(
						accountIssuer => new
						{
							accountIssuer.AccountId
							,
							accountIssuer.IssuerId
							,
							accountIssuer.UpdateTimestamp
						}
					)
			;
			modelBuilder.Entity<AccountLabel>()
				.HasKey
					(
						accountLabel => new
						{
							accountLabel.AccountId
							,
							accountLabel.LabelId
							,
							accountLabel.UpdateTimestamp
						}
					)
			;
			modelBuilder.Entity<AccountLine>()
				.HasKey
					(
						accountLine => new
						{
							accountLine.AccountId
							,
							accountLine.LineId
							,
							accountLine.UpdateTimestamp
						}
					)
			;
			modelBuilder.Entity<AccountNote>()
				.HasKey
					(
						accountNote => new
						{
							accountNote.AccountId
							,
							accountNote.UpdateTimestamp
						}
					)
			;
			modelBuilder.Entity<AccountPayment>()
				.HasKey
					(
						accountPayment => new
						{
							accountPayment.AccountId
							,
							accountPayment.Due
						}
					)
			;
			modelBuilder.Entity<AccountPromotion>()
				.HasKey
					(
						accountPromotion => new
						{
							accountPromotion.AccountId
							,
							accountPromotion.TypeId
							,
							accountPromotion.Start
							,
							accountPromotion.End
						}
					)
			;
			modelBuilder.Entity<AccountStatement>().HasKey
					(
						accountStatement => (new
						{
							accountStatement.AccountId
							,
							accountStatement.End
						})
					)
			;
			/**
			// Define one-to-one relationship between account statement and minimum payment.
			accountStatementBuilder
				.HasOne
					(
						accountStatement => accountStatement.MinimumPayment
					)
				.WithOne
					(
						accountPayment => accountPayment.Statement
					)
			;
			// Define one-to-many relationship between account statement and payments.
			accountStatementBuilder
				.HasMany
					(
						accountStatement => accountStatement.Payments
					)
				.WithOne
					(
						accountPayment => accountPayment.Statement
					)
			;
			**/
			base.OnModelCreating(modelBuilder);
		}

#endregion

	}

}
