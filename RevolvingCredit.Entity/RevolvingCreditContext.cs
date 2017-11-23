using JDevl32.Entity.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RevolvingCredit.Entity.Interface;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.Entity
{

	/// <summary>
	/// The revolving credit database context.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class RevolvingCreditContext
		:
		EntityContextBase
		,
		IRevolvingCreditContext
	{

#region Property

//#region IEntityContext

//		/// <inheritdoc />
//		public IConfigurationRoot ConfigurationRoot { get; }

//		/// <inheritdoc />
//		public string ConnectionStringKey { get; }

//		/// <inheritdoc />
//		public IHostingEnvironment HostingEnvironment { get; }

//#endregion

#region IRevolvingCreditContext

		// todo|jdevl32: implement auto-mapper...

		/// <inheritdoc />
		DbSet<IAccount> IRevolvingCreditContext.Account { get; set; }

		/// <inheritdoc />
		DbSet<IAccountAPR> IRevolvingCreditContext.AccountAPR { get; set; }

		/// <inheritdoc />
		DbSet<IAccountIssuer> IRevolvingCreditContext.AccountIssuer { get; set; }

		/// <inheritdoc />
		DbSet<IAccountLabel> IRevolvingCreditContext.AccountLabel { get; set; }

		/// <inheritdoc />
		DbSet<IAccountLine> IRevolvingCreditContext.AccountLine { get; set; }

		/// <inheritdoc />
		DbSet<IAccountNote> IRevolvingCreditContext.AccountNote { get; set; }

		/// <inheritdoc />
		DbSet<IAccountPayment> IRevolvingCreditContext.AccountPayment { get; set; }

		/// <inheritdoc />
		DbSet<IAccountPromotion> IRevolvingCreditContext.AccountPromotion { get; set; }

		/// <inheritdoc />
		DbSet<IAccountStatement> IRevolvingCreditContext.AccountStatement { get; set; }

		/// <inheritdoc />
		DbSet<IAPR> IRevolvingCreditContext.APR { get; set; }

		/// <inheritdoc />
		DbSet<IIssuer> IRevolvingCreditContext.Issuer { get; set; }

		/// <inheritdoc />
		DbSet<ILabel> IRevolvingCreditContext.Label { get; set; }

		/// <inheritdoc />
		DbSet<ILine> IRevolvingCreditContext.Line { get; set; }

		/// <inheritdoc />
		DbSet<IPayment> IRevolvingCreditContext.Payment { get; set; }

#endregion

		/// <summary>
		/// The account table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<Account> Account { get; set; }

		/// <summary>
		/// The account APR table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<AccountAPR> AccountAPR { get; set; }

		/// <summary>
		/// The account issuer table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<AccountIssuer> AccountIssuer { get; set; }

		/// <summary>
		/// The account table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<AccountLabel> AccountLabel { get; set; }

		/// <summary>
		/// The account line table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<AccountLine> AccountLine { get; set; }

		/// <summary>
		/// The account note table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<AccountNote> AccountNote { get; set; }

		/// <summary>
		/// The account payment table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<AccountPayment> AccountPayment { get; set; }

		/// <summary>
		/// The account promotion table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<AccountPromotion> AccountPromotion { get; set; }

		/// <summary>
		/// The account statement table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<AccountStatement> AccountStatement { get; set; }

		/// <summary>
		/// The APR (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<APR> APR { get; set; }

		/// <summary>
		/// The issuer (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<Issuer> Issuer { get; set; }

		/// <summary>
		/// The label (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<Label> Label { get; set; }

		/// <summary>
		/// The line (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<Line> Line { get; set; }

		/// <summary>
		/// The payment (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public DbSet<Payment> Payment { get; set; }

#endregion

#region Instance Initialization

		/// <inheritdoc />
		public RevolvingCreditContext(DbContextOptions dbContextOptions, IConfigurationRoot configurationRoot, IHostingEnvironment hostingEnvironment)
			:
			base(dbContextOptions, configurationRoot, hostingEnvironment)
		{
		}

		/// <inheritdoc />
		public RevolvingCreditContext(DbContextOptions dbContextOptions, IConfigurationRoot configurationRoot, IHostingEnvironment hostingEnvironment, string connectionStringKey)
			:
			base(dbContextOptions, configurationRoot, hostingEnvironment, connectionStringKey)
		{
		}

		// todo|jdevl32: implement ctors...

#endregion

#region DbContext

		/// <inheritdoc />
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			// todo|jdevl32: add composite key(s)...
		}

#endregion

	}

}
