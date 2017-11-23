using AutoMapper;
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

		/// <inheritdoc />
		DbSet<IAccount> IRevolvingCreditContext.Account
		{
			get => Mapper.Map<DbSet<IAccount>>(Account);
			set => Account = Mapper.Map<DbSet<Account>>(value);
		}

		/// <inheritdoc />
		DbSet<IAccountAPR> IRevolvingCreditContext.AccountAPR
		{
			get => Mapper.Map<DbSet<IAccountAPR>>(AccountAPR);
			set => AccountAPR = Mapper.Map<DbSet<AccountAPR>>(value);
		}

		/// <inheritdoc />
		DbSet<IAccountIssuer> IRevolvingCreditContext.AccountIssuer
		{
			get => Mapper.Map<DbSet<IAccountIssuer>>(AccountIssuer);
			set => AccountIssuer = Mapper.Map<DbSet<AccountIssuer>>(value);
		}

		/// <inheritdoc />
		DbSet<IAccountLabel> IRevolvingCreditContext.AccountLabel
		{
			get => Mapper.Map<DbSet<IAccountLabel>>(AccountLabel);
			set => AccountLabel = Mapper.Map<DbSet<AccountLabel>>(value);
		}

		/// <inheritdoc />
		DbSet<IAccountLine> IRevolvingCreditContext.AccountLine
		{
			get => Mapper.Map<DbSet<IAccountLine>>(AccountLine);
			set => AccountLine = Mapper.Map<DbSet<AccountLine>>(value);
		}

		/// <inheritdoc />
		DbSet<IAccountNote> IRevolvingCreditContext.AccountNote
		{
			get => Mapper.Map<DbSet<IAccountNote>>(AccountNote);
			set => AccountNote = Mapper.Map<DbSet<AccountNote>>(value);
		}

		/// <inheritdoc />
		DbSet<IAccountPayment> IRevolvingCreditContext.AccountPayment
		{
			get => Mapper.Map<DbSet<IAccountPayment>>(AccountPayment);
			set => AccountPayment = Mapper.Map<DbSet<AccountPayment>>(value);
		}

		/// <inheritdoc />
		DbSet<IAccountPromotion> IRevolvingCreditContext.AccountPromotion
		{
			get => Mapper.Map<DbSet<IAccountPromotion>>(AccountPromotion);
			set => AccountPromotion = Mapper.Map<DbSet<AccountPromotion>>(value);
		}

		/// <inheritdoc />
		DbSet<IAccountStatement> IRevolvingCreditContext.AccountStatement
		{
			get => Mapper.Map<DbSet<IAccountStatement>>(AccountStatement);
			set => AccountStatement = Mapper.Map<DbSet<AccountStatement>>(value);
		}

		/// <inheritdoc />
		DbSet<IAPR> IRevolvingCreditContext.APR
		{
			get => Mapper.Map<DbSet<IAPR>>(APR);
			set => APR = Mapper.Map<DbSet<APR>>(value);
		}

		/// <inheritdoc />
		DbSet<IIssuer> IRevolvingCreditContext.Issuer
		{
			get => Mapper.Map<DbSet<IIssuer>>(Issuer);
			set => Issuer = Mapper.Map<DbSet<Issuer>>(value);
		}

		/// <inheritdoc />
		DbSet<ILabel> IRevolvingCreditContext.Label
		{
			get => Mapper.Map<DbSet<ILabel>>(Label);
			set => Label = Mapper.Map<DbSet<Label>>(value);
		}

		/// <inheritdoc />
		DbSet<ILine> IRevolvingCreditContext.Line
		{
			get => Mapper.Map<DbSet<ILine>>(Line);
			set => Line = Mapper.Map<DbSet<Line>>(value);
		}

		/// <inheritdoc />
		DbSet<IPayment> IRevolvingCreditContext.Payment
		{
			get => Mapper.Map<DbSet<IPayment>>(Payment);
			set => Payment = Mapper.Map<DbSet<Payment>>(value);
		}

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
