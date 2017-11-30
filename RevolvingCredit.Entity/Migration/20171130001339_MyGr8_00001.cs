using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RevolvingCredit.Entity.Migration
{
	public partial class MyGr8_00001 : Microsoft.EntityFrameworkCore.Migrations.Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Account",
				columns: table => new
				{
					Id = table.Column<Guid>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Account", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "AccountAPR",
				columns: table => new
				{
					AccountId = table.Column<int>(nullable: false),
					TypeId = table.Column<int>(nullable: false),
					UpdateTimestamp = table.Column<DateTime>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountAPR", x => new { x.AccountId, x.TypeId, x.UpdateTimestamp });
				});

			migrationBuilder.CreateTable(
				name: "AccountIssuer",
				columns: table => new
				{
					AccountId = table.Column<int>(nullable: false),
					IssuerId = table.Column<int>(nullable: false),
					UpdateTimestamp = table.Column<DateTime>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountIssuer", x => new { x.AccountId, x.IssuerId, x.UpdateTimestamp });
				});

			migrationBuilder.CreateTable(
				name: "AccountLabel",
				columns: table => new
				{
					AccountId = table.Column<int>(nullable: false),
					LabelId = table.Column<int>(nullable: false),
					UpdateTimestamp = table.Column<DateTime>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountLabel", x => new { x.AccountId, x.LabelId, x.UpdateTimestamp });
				});

			migrationBuilder.CreateTable(
				name: "AccountLine",
				columns: table => new
				{
					AccountId = table.Column<int>(nullable: false),
					LineId = table.Column<int>(nullable: false),
					UpdateTimestamp = table.Column<DateTime>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountLine", x => new { x.AccountId, x.LineId, x.UpdateTimestamp });
				});

			migrationBuilder.CreateTable(
				name: "AccountNote",
				columns: table => new
				{
					AccountId = table.Column<int>(nullable: false),
					UpdateTimestamp = table.Column<DateTime>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountNote", x => new { x.AccountId, x.UpdateTimestamp });
				});

			migrationBuilder.CreateTable(
				name: "AccountPayment",
				columns: table => new
				{
					AccountId = table.Column<int>(nullable: false),
					Due = table.Column<DateTime>(nullable: false),
					TypeId = table.Column<int>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountPayment", x => new { x.AccountId, x.Due });
				});

			migrationBuilder.CreateTable(
				name: "AccountPromotion",
				columns: table => new
				{
					AccountId = table.Column<int>(nullable: false),
					TypeId = table.Column<int>(nullable: false),
					Start = table.Column<DateTime>(nullable: false),
					End = table.Column<DateTime>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountPromotion", x => new { x.AccountId, x.TypeId, x.Start, x.End });
				});

			migrationBuilder.CreateTable(
				name: "AccountStatement",
				columns: table => new
				{
					AccountId = table.Column<int>(nullable: false),
					End = table.Column<DateTime>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_AccountStatement", x => new { x.AccountId, x.End });
				});

			migrationBuilder.CreateTable(
				name: "APR",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_APR", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Issuer",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Issuer", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Label",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Label", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Line",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Line", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Payment",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Payment", x => x.Id);
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Account");

			migrationBuilder.DropTable(
				name: "AccountAPR");

			migrationBuilder.DropTable(
				name: "AccountIssuer");

			migrationBuilder.DropTable(
				name: "AccountLabel");

			migrationBuilder.DropTable(
				name: "AccountLine");

			migrationBuilder.DropTable(
				name: "AccountNote");

			migrationBuilder.DropTable(
				name: "AccountPayment");

			migrationBuilder.DropTable(
				name: "AccountPromotion");

			migrationBuilder.DropTable(
				name: "AccountStatement");

			migrationBuilder.DropTable(
				name: "APR");

			migrationBuilder.DropTable(
				name: "Issuer");

			migrationBuilder.DropTable(
				name: "Label");

			migrationBuilder.DropTable(
				name: "Line");

			migrationBuilder.DropTable(
				name: "Payment");
		}
	}
}
