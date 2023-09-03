using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hamburger.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToppingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Statuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Statuses",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateTable(
                name: "MenuProducts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MenuProducts_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductToppings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ToppingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductToppings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductToppings_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductToppings_Toppings_ToppingID",
                        column: x => x.ToppingID,
                        principalTable: "Toppings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFavorites",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavorites", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserFavorites_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFavorites_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFavorites_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    MessageOfUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    MenuID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "SizeID");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:Hamburger/Hamburger/Migrations/20230903064456_init.cs
                    { 1, "042bdeac-0439-4853-87a7-bb420a4de5af", "Admin", "ADMIN" },
                    { 2, "8b6aced7-620e-4196-8850-9ce45053f948", "Standard", "STANDARD" }
========
                    { 1, "529fab61-2513-46e4-a2dd-bf7d02927dfe", "Admin", "ADMIN" },
                    { 2, "ea1e082c-cee2-4e1f-acb3-846cbf67da20", "Standard", "STANDARD" }
>>>>>>>> 621cd44459feb588912b411c30d8adc12bf4c888:Hamburger/Hamburger/Migrations/20230903090141_initialdb.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
<<<<<<<< HEAD:Hamburger/Hamburger/Migrations/20230903064456_init.cs
                values: new object[] { 1, 0, "Kadikoy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cdb3659c-1333-446f-98e4-86d6fc5065ff", "overthinkerst@gmail.com", true, "overthinkers", "team", false, null, "OVERTHINKERST@GMAIL.COM", "OVERTHINKERS", "AQAAAAEAACcQAAAAEJdKjtR0gjuSddSY2cG/eVz0kJ92ENEJArksNb6N4x8YfyH0WDjqtI5LliWs7NAiRQ==", null, false, "b95c8253-2873-49c6-a517-2caf05e481f7", false, "overthinkers" });
========
                values: new object[] { 1, 0, "Kadikoy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8c40a14d-92b6-40ba-ae22-7532229abfa8", "overthinkerst@gmail.com", true, "overthinkers", "team", false, null, "OVERTHINKERST@GMAIL.COM", "OVERTHINKERS", "AQAAAAEAACcQAAAAEFFnjS/7bETI4ViP1kQz9WUM30rDz5FLBIhDDwEcF1uW6Xj6N9qYFnj08Mt8hO1Cnw==", null, false, "9e04ef55-ec7d-4fb5-9d37-387fc6236753", false, "overthinkers" });
>>>>>>>> 621cd44459feb588912b411c30d8adc12bf4c888:Hamburger/Hamburger/Migrations/20230903090141_initialdb.cs

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreateDate", "UpdateDate", "isActive" },
                values: new object[,]
                {
<<<<<<<< HEAD:Hamburger/Hamburger/Migrations/20230903064456_init.cs
                    { 1, "Hamburgers", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2457), new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2458), true },
                    { 2, "Sides", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2459), new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2459), true },
                    { 3, "Beverages", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2460), new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2460), true },
                    { 4, "Deserts", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2461), new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2461), true },
                    { 5, "Sauces", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2462), new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2462), true }
========
                    { 1, "Hamburgers", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1800), new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1809), true },
                    { 2, "Sides", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1813), new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1813), true },
                    { 3, "Beverages", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1814), new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1815), true },
                    { 4, "Deserts", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1815), new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1816), true },
                    { 5, "Sauces", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1816), new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1817), true }
>>>>>>>> 621cd44459feb588912b411c30d8adc12bf4c888:Hamburger/Hamburger/Migrations/20230903090141_initialdb.cs
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "ID", "CreateDate", "Description", "MenuImage", "MenuName", "Price", "UpdateDate", "isActive" },
                values: new object[,]
                {
<<<<<<<< HEAD:Hamburger/Hamburger/Migrations/20230903064456_init.cs
                    { 1, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2900), "Whopper eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan bir Burger klasiği. Enfes patates kızartması ve içeceğiyle birlikte Whopper® Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/whopper-menu.png?v=285", "Whopper Menü", 189.99m, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2901), true },
                    { 2, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2903), "Whopper® eti, büyük boy susamlı sandviç ekmeği, mayonez, doğranmış marul, soğan halkaları, nefis barbekü sosu ve cheddar peynirinden oluşan Whopper lezzeti. Enfes patates kızartması ve içeceğiyle birlikte Rodeo Whopper® Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/rodeo-whopper-menu.png?v=285", "Rodeo Whopper Menü", 189.99m, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2903), true },
                    { 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2904), "Hamburger eti, küçük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan, Whopper lezzetinden vazgeçemeyenlere nefis bir seçim. Enfes patates kızartması ve içeceğiyle birlikte Whopper Jr. Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/whopper-jr-menu.png?v=285", "Whopper Jr. Menü", 159.99m, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2904), true },
                    { 4, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2905), "Fish Royale® eti, küçük boy susamlı sandviç ekmeği, doğranmış marul ve Burger klasiğine lezzetini veren tartar sosun birleşimi olan Fish Royale®, balık eti sevenlerin tercihi olacak. Enfes patates kızartması ve içeceği ile istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/fish-royale-menu.png?v=285", "Fish Royale Menü", 169.99m, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2905), true },
                    { 5, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2906), "King Chicken eti, susamlı sandviç ekmeği, mayonez ve doğranmış maruldan oluşan bu son derece sade alternatifi, enfes patates kızartması ve içeceğiyle birlikte istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/king-chicken-menu.png?v=285", "King Chicken Menü", 169.99m, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2906), true },
                    { 6, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2907), "Kocaman Steakhouse eti, özel sosu, cheddar peyniri, domatesi, mayonezi, marulu ve çıtır kaplamalı soğanlarıyla sabrınızı zorlayacak bir lezzet. Enfes patates kızartması ve içeceğiyle birlikte BK Steakhouse Burger® Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/bk-steakhouse-burger-menu.png?v=285", "Steakhouse Menü", 209.99m, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2907), true },
                    { 7, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2908), "4 adet Hamburger eti, 3 katlı özel ekmeği, cheddar peyniri, salatalık turşusu, doğranmış marul ve soğana eşlik eden özel Big King sosun birleşimi. Enfes patates kızartması ve içeceğiyle birlikte Double Menü keyfini istediğin gibi yaşa", "https://www.burgerking.com.tr/cmsfiles/products/double-big-king-menu.png?v=285", "Double King Menü", 219.99m, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2909), true },
                    { 8, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2909), "İki adet Whopper eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğanla, klasik Whopper® lezzetini ikiye katlamak için ideal. Enfes patates kızartması ve içeceğiyle birlikte Double Whopper Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/double-whopper-menu.png?v=285", "Double Whopper Menü", 210.99m, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2910), true },
                    { 9, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2910), "Özel kaplamasıyla tavuk göğüs fileto, mısır irmiği ile süslemeli özel ekmeği, spicy sosu, domatesi ve doğranmış maruldan oluşan yeni bir lezzet. Enfes patates kızartması ve içeceğiyle birlikte Spicy Gurme Tavuk Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/spicy-gurme-tavuk-menu.png?v=285", "Spicy Gurme Tavuk Menü", 170.99m, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2911), true },
                    { 10, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2911), "2 adet Whopper eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, cheddar peyniri, hardal ve ketçaptan oluşan oluşan lezzet. Enfes patates kızartması ve içeceğiyle birlikte Mega Double Cheeseburger Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/mega-double-cheeseburger-menu.png?v=285", "Mega Double Cheeseburger Menü", 170.99m, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2912), true },
                    { 11, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2913), "Enfes patates kızartması ve içeceğiyle birlikte 6'lı Nuggets Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/6li-bk-king-nuggets-menu.png?v=285", "6 lı Nuggets Menü", 100.99m, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2913), true },
                    { 12, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2915), "Enfes patates kızartması ve içeceğiyle birlikte 6'lı Tenders Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/6li-chicken-tenders-menu-1.png?v=285", "6 lı Tenders Menü", 130.99m, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2915), true }
========
                    { 1, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2394), "Whopper eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan bir Burger klasiği. Enfes patates kızartması ve içeceğiyle birlikte Whopper® Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/whopper-menu.png?v=285", "Whopper Menü", 189.99m, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2394), true },
                    { 2, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2396), "Whopper® eti, büyük boy susamlı sandviç ekmeği, mayonez, doğranmış marul, soğan halkaları, nefis barbekü sosu ve cheddar peynirinden oluşan Whopper lezzeti. Enfes patates kızartması ve içeceğiyle birlikte Rodeo Whopper® Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/rodeo-whopper-menu.png?v=285", "Rodeo Whopper Menü", 189.99m, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2397), true },
                    { 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2398), "Hamburger eti, küçük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan, Whopper lezzetinden vazgeçemeyenlere nefis bir seçim. Enfes patates kızartması ve içeceğiyle birlikte Whopper Jr. Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/whopper-jr-menu.png?v=285", "Whopper Jr. Menü", 159.99m, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2398), true },
                    { 4, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2399), "Fish Royale® eti, küçük boy susamlı sandviç ekmeği, doğranmış marul ve Burger klasiğine lezzetini veren tartar sosun birleşimi olan Fish Royale®, balık eti sevenlerin tercihi olacak. Enfes patates kızartması ve içeceği ile istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/fish-royale-menu.png?v=285", "Fish Royale Menü", 169.99m, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2399), true },
                    { 5, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2400), "King Chicken eti, susamlı sandviç ekmeği, mayonez ve doğranmış maruldan oluşan bu son derece sade alternatifi, enfes patates kızartması ve içeceğiyle birlikte istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/king-chicken-menu.png?v=285", "King Chicken Menü", 169.99m, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2401), true },
                    { 6, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2401), "Kocaman Steakhouse eti, özel sosu, cheddar peyniri, domatesi, mayonezi, marulu ve çıtır kaplamalı soğanlarıyla sabrınızı zorlayacak bir lezzet. Enfes patates kızartması ve içeceğiyle birlikte BK Steakhouse Burger® Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/bk-steakhouse-burger-menu.png?v=285", "Steakhouse Menü", 209.99m, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2402), true },
                    { 7, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2403), "4 adet Hamburger eti, 3 katlı özel ekmeği, cheddar peyniri, salatalık turşusu, doğranmış marul ve soğana eşlik eden özel Big King sosun birleşimi. Enfes patates kızartması ve içeceğiyle birlikte Double Menü keyfini istediğin gibi yaşa", "https://www.burgerking.com.tr/cmsfiles/products/double-big-king-menu.png?v=285", "Double King Menü", 219.99m, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2403), true },
                    { 8, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2404), "İki adet Whopper eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğanla, klasik Whopper® lezzetini ikiye katlamak için ideal. Enfes patates kızartması ve içeceğiyle birlikte Double Whopper Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/double-whopper-menu.png?v=285", "Double Whopper Menü", 210.99m, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2404), true },
                    { 9, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2405), "Özel kaplamasıyla tavuk göğüs fileto, mısır irmiği ile süslemeli özel ekmeği, spicy sosu, domatesi ve doğranmış maruldan oluşan yeni bir lezzet. Enfes patates kızartması ve içeceğiyle birlikte Spicy Gurme Tavuk Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/spicy-gurme-tavuk-menu.png?v=285", "Spicy Gurme Tavuk Menü", 170.99m, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2405), true },
                    { 10, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2406), "2 adet Whopper eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, cheddar peyniri, hardal ve ketçaptan oluşan oluşan lezzet. Enfes patates kızartması ve içeceğiyle birlikte Mega Double Cheeseburger Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/mega-double-cheeseburger-menu.png?v=285", "Mega Double Cheeseburger Menü", 170.99m, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2407), true },
                    { 11, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2407), "Enfes patates kızartması ve içeceğiyle birlikte 6'lı Nuggets Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/6li-bk-king-nuggets-menu.png?v=285", "6 lı Nuggets Menü", 100.99m, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2408), true },
                    { 12, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2409), "Enfes patates kızartması ve içeceğiyle birlikte 6'lı Tenders Menü keyfini istediğin gibi yaşa!", "https://www.burgerking.com.tr/cmsfiles/products/6li-chicken-tenders-menu-1.png?v=285", "6 lı Tenders Menü", 130.99m, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2409), true }
>>>>>>>> 621cd44459feb588912b411c30d8adc12bf4c888:Hamburger/Hamburger/Migrations/20230903090141_initialdb.cs
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "Price", "SizeName" },
                values: new object[,]
                {
                    { 1, 0m, "Küçük Boy" },
                    { 2, 8m, "Orta Boy" },
                    { 3, 12m, "Büyük Boy" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusID", "StatusDescription" },
                values: new object[,]
                {
                    { 101, "At the cart." },
                    { 102, "Order taken." },
                    { 103, "Order is being prepared." },
                    { 201, "On the way." },
                    { 202, "Delivered." },
                    { 401, "Order cancelled." }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "ID", "CreateDate", "Price", "ToppingName", "UpdateDate", "isActive" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2269), 4.99m, "Domates", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2279), true },
                    { 2, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2282), 5.99m, "Salatalık Turşusu", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2283), true },
                    { 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2284), 3.99m, "Soğan", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2284), true },
                    { 4, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2285), 2.99m, "Marul", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2285), true },
                    { 5, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2286), 6.99m, "Cheddar Peyniri", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2286), true },
                    { 6, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2287), 7.99m, "Trüf Mantarı", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2287), true },
                    { 7, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2288), 5.99m, "Çıtır Soğan", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2288), true },
                    { 8, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2289), 1.99m, "Ketçap", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2289), true },
                    { 9, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2290), 1.99m, "Mayonez", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2290), true },
                    { 10, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2291), 1.99m, "Steakhouse Burger Sos", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2291), true },
                    { 11, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2292), 1.99m, "BigKing Burger Sos", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2292), true },
                    { 12, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2293), 3.99m, "Soğan Halkaları", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2293), true },
                    { 13, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2294), 2.99m, "Barbekü Sos", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2294), true }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "ID", "CreateDate", "Price", "ToppingName", "UpdateDate", "isActive" },
                values: new object[] { 14, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2295), 2.99m, "Spicy Sos", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2295), true });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "ID", "CreateDate", "Price", "ToppingName", "UpdateDate", "isActive" },
                values: new object[] { 15, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2295), 2.99m, "Tartar Sos", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2296), true });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "ID", "CreateDate", "Price", "ToppingName", "UpdateDate", "isActive" },
                values: new object[] { 16, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2296), 2.99m, "Hardal Sos", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2297), true });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreateDate", "Description", "Price", "ProductImage", "ProductName", "UpdateDate", "isActive" },
                values: new object[,]
                {
<<<<<<<< HEAD:Hamburger/Hamburger/Migrations/20230903064456_init.cs
                    { 101, 1, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2516), "Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan bir Burger King® klasiği.", 134.99m, "https://www.burgerking.com.tr/cmsfiles/products/whopper.png?v=285", "Whopper Burger", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2516), true },
                    { 102, 1, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2536), "King Chicken eti, susamlı sandviç ekmeği, mayonez ve doğranmış maruldan oluşan son derece sade bir lezzet alternatifi.", 124.99m, "https://www.burgerking.com.tr/cmsfiles/products/king-chicken-1.png?v=285", "King Chicken Burger", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2537), true },
                    { 103, 1, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2538), "Kocaman Steakhouse eti, özel sosu, cheddar peyniri, domatesi, mayonezi, marulu ve çıtır kaplamalı soğanlarıyla sabrınızı zorlayacak bir lezzet.", 174.99m, "https://www.burgerking.com.tr/cmsfiles/products/bk-steakhouse-burger.png?v=285", "Steakhouse Burger", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2539), true },
                    { 104, 1, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2540), "4 adet Hamburger eti, 3 katlı özel ekmeği, cheddar peyniri, salatalık turşusu, doğranmış marul ve soğana eşlik eden özel Big King® sosun birleşimi", 184.99m, "https://www.burgerking.com.tr/cmsfiles/products/double-big-king.png?v=285", "Double Big King Burger", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2541), true },
                    { 105, 1, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2542), "Whopper® eti, büyük boy susamlı sandviç ekmeği, mayonez, doğranmış marul, soğan halkaları, nefis barbekü sosu ve 2 adet cheddar peynirinden oluşan Whopper® lezzeti.", 159.99m, "https://www.burgerking.com.tr/cmsfiles/products/rodeo-whopper.png?v=285", "Rodeo Whopper Burger", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2543), true },
                    { 106, 1, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2544), "İki adet Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğanla klasik Whopper® lezzetini ikiye katlamak için ideal.", 194.99m, "https://www.burgerking.com.tr/cmsfiles/products/double-whopper-1.png?v=285", "Double Whopper Burger", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2545), true },
                    { 107, 1, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2546), "Hamburger eti, küçük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan, Whopper® lezzetinden vazgeçemeyenlere nefis bir seçim.", 119.99m, "https://www.burgerking.com.tr/cmsfiles/products/whopper-jr.png?v=285", "Whopper Jr. Burger", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2546), true },
                    { 108, 1, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2548), "Özel kaplamasıyla tavuk göğüs fileto, mısır irmiği ile süslemeli özel ekmeği, spicy sosu, domatesi ve doğranmış maruldan oluşan yeni bir lezzet.", 129.99m, "https://www.burgerking.com.tr/cmsfiles/products/spicy-gurme-tavuk.png?v=285", "Spicy Gurme Burger", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2548), true },
                    { 109, 1, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2549), "Fish Royale® eti, küçük boy susamlı sandviç ekmeği, doğranmış marul ile burger klasiğine lezzetini veren tartar sosun birleşimi.", 159.99m, "https://www.burgerking.com.tr/cmsfiles/products/fish-royale-1.png?v=285", "Fish Royale Burger", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2550), true },
                    { 110, 1, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2551), "2 adet Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, 4 adet cheddar peyniri, hardal ve ketçaptan oluşan lezzet.", 159.99m, "https://www.burgerking.com.tr/cmsfiles/products/mega-double-cheeseburger.png?v=285", "Mega Double CheeseBurger", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2551), true },
                    { 201, 2, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2554), "Doğal, soyulmuş, gevrek kızarmış patates", 59.99m, "https://www.burgerking.com.tr/cmsfiles/products/patates.png?v=285", "Patates", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2554), true },
                    { 202, 2, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2555), "Çıtır Mı Çıtır Altın Sarısı Tırtıklı Patates", 69.99m, "https://www.burgerking.com.tr/cmsfiles/products/tirtikli-patates.png?v=285", "Tırtıklı  Patates", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2556), true },
                    { 203, 2, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2557), "Çıtır çıtır 8’li, 12’li ya da 16’lı Soğan Halka lezzeti", 79.99m, "https://www.burgerking.com.tr/cmsfiles/products/sogan-halkasi.png?v=285", "Soğan Halkası", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2557), true },
                    { 204, 2, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2559), "Dışı çıtır çıtır, içi sıcacık peyniriyle Çıtır Peynir!", 75.99m, "https://www.burgerking.com.tr/cmsfiles/products/citir-peynir.png?v=285", "Çıtır Peynir", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2559), true },
                    { 205, 2, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2561), "Dışı çıtır çıtır Nuggets...", 75.99m, "https://www.burgerking.com.tr/cmsfiles/products/bk-king-nuggets-1.png?v=285", "Çıtır Nuggets", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2561), true },
                    { 206, 2, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2563), "Özel harcıyla nar gibi kızarmış  beyaz tavuk eti.", 85.99m, "https://www.burgerking.com.tr/cmsfiles/products/chicken-tenders.png?v=285", "Çıtır Tavuk Tenders", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2563), true },
                    { 301, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2599), "Şeftalili Fuse Tea ve Limonlu Fuse Tea seçenekleri ile", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/fuse-tea.png?v=285", "Fuse Tea", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2600), true },
                    { 302, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2602), "Cola cola ", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/coca-cola.png?v=285", "Coca Cola", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2602), true },
                    { 303, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2604), "Cola cola Zero ", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/coca-cola-zero-sugar.png?v=285", "Coca Cola Zero", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2604), true },
                    { 304, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2605), "Fanta", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/fanta.png?v=285", "Fanta", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2606), true },
                    { 305, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2607), "Sprite", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/sprite.png?v=285", "Sprite", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2607), true },
                    { 306, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2609), "Ayran", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/ayran-300-ml.png?v=285", "Ayran", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2610), true },
                    { 307, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2611), "Elma Suyu", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/elma-suyu.png?v=285", "Cappy Elma Suyu", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2611), true },
                    { 308, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2613), "Atom Suyu", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/cappy-atom-200-ml.png?v=285", "Cappy Atom", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2614), true },
                    { 309, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2616), "Kahve Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/espresso.png?v=285", "Espresso", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2617), true },
                    { 310, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2619), "Kahve Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/nescafe-black.png?v=285", "Filtre Kahve", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2619), true },
                    { 311, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2620), "Karadeniz Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/cay.png?v=285", "Çay", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2621), true },
                    { 312, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2622), "İtalyan Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/vanilyali-cappuccino.png?v=285", "Cappuccino", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2622), true },
                    { 313, 3, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2624), "Çikolata Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/nestle-sicak-cikolata.png?v=285", "Sıcak Çikolata", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2624), true },
                    { 401, 4, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2626), "Çikolata Lezzeti", 45.99m, "https://www.burgerking.com.tr/cmsfiles/products/cikolatali-cookie.png?v=285", "Çikolatalı Cookie", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2626), true },
                    { 402, 4, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2628), "Çikolata Lezzeti", 45.99m, "https://www.burgerking.com.tr/cmsfiles/products/sufle.png?v=285", "Sufle", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2628), true },
                    { 403, 4, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2630), "Vişne Lezzeti", 55.99m, "https://www.burgerking.com.tr/cmsfiles/products/visneli-tatli.png?v=285", "Vişneli Tatlı", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2631), true },
                    { 404, 4, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2632), "Vanilyalı, Çilekli, Çikolatalı, Espressolu, Limonlu çeşitleriyle.", 55.99m, "https://www.burgerking.com.tr/cmsfiles/products/espressolu-milkshake.png?v=285", "Espresso Milkshake", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2632), true },
                    { 405, 4, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2634), "Vanilyalı, Çikolata Soslu, Böğürtlen Soslu, Karamel Soslu, Çilek Soslu, Limonlu", 65.99m, "https://www.burgerking.com.tr/cmsfiles/products/king-sundae.png?v=285", "King Sundae", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2634), true },
                    { 406, 4, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2635), "Çikolata Parçacıklı, Renkli Çikolata Drajeleri, Limonlu", 75.99m, "https://www.burgerking.com.tr/cmsfiles/products/bkool.png?v=285", "Bkool", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2636), true },
                    { 501, 5, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2637), "Acı Sos", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-aci-sos.png?v=285", "Mini Acı Sos", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2637), true },
                    { 502, 5, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2639), "Mayonez", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-mayonez.png?v=285", "Mayonez", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2639), true },
                    { 503, 5, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2641), "Ranch Sos", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-ranch.png?v=285", "Mini Ranch", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2641), true },
                    { 504, 5, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2643), "Sarımsaklı Sos", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-sarimsakli-mayonez-1.png?v=285", "Sarımsaklı Sos", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2643), true },
                    { 505, 5, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2644), "Mini Ketçap", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-ketcap.png?v=285", "Mini Ketçap", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2645), true },
                    { 506, 5, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2647), "Buffalo Sos", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-buffalo-1.png?v=285", "Buffalo Sos", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2647), true }
========
                    { 101, 1, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1906), "Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan bir Burger King® klasiği.", 134.99m, "https://www.burgerking.com.tr/cmsfiles/products/whopper.png?v=285", "Whopper Burger", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1907), true },
                    { 102, 1, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1936), "King Chicken eti, susamlı sandviç ekmeği, mayonez ve doğranmış maruldan oluşan son derece sade bir lezzet alternatifi.", 124.99m, "https://www.burgerking.com.tr/cmsfiles/products/king-chicken-1.png?v=285", "King Chicken Burger", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1936), true },
                    { 103, 1, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1939), "Kocaman Steakhouse eti, özel sosu, cheddar peyniri, domatesi, mayonezi, marulu ve çıtır kaplamalı soğanlarıyla sabrınızı zorlayacak bir lezzet.", 174.99m, "https://www.burgerking.com.tr/cmsfiles/products/bk-steakhouse-burger.png?v=285", "Steakhouse Burger", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1939), true },
                    { 104, 1, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1941), "4 adet Hamburger eti, 3 katlı özel ekmeği, cheddar peyniri, salatalık turşusu, doğranmış marul ve soğana eşlik eden özel Big King® sosun birleşimi", 184.99m, "https://www.burgerking.com.tr/cmsfiles/products/double-big-king.png?v=285", "Double Big King Burger", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1941), true },
                    { 105, 1, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1943), "Whopper® eti, büyük boy susamlı sandviç ekmeği, mayonez, doğranmış marul, soğan halkaları, nefis barbekü sosu ve 2 adet cheddar peynirinden oluşan Whopper® lezzeti.", 159.99m, "https://www.burgerking.com.tr/cmsfiles/products/rodeo-whopper.png?v=285", "Rodeo Whopper Burger", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1943), true },
                    { 106, 1, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1945), "İki adet Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğanla klasik Whopper® lezzetini ikiye katlamak için ideal.", 194.99m, "https://www.burgerking.com.tr/cmsfiles/products/double-whopper-1.png?v=285", "Double Whopper Burger", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1946), true },
                    { 107, 1, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1947), "Hamburger eti, küçük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan, Whopper® lezzetinden vazgeçemeyenlere nefis bir seçim.", 119.99m, "https://www.burgerking.com.tr/cmsfiles/products/whopper-jr.png?v=285", "Whopper Jr. Burger", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1948), true },
                    { 108, 1, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1992), "Özel kaplamasıyla tavuk göğüs fileto, mısır irmiği ile süslemeli özel ekmeği, spicy sosu, domatesi ve doğranmış maruldan oluşan yeni bir lezzet.", 129.99m, "https://www.burgerking.com.tr/cmsfiles/products/spicy-gurme-tavuk.png?v=285", "Spicy Gurme Burger", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1993), true },
                    { 109, 1, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1995), "Fish Royale® eti, küçük boy susamlı sandviç ekmeği, doğranmış marul ile burger klasiğine lezzetini veren tartar sosun birleşimi.", 159.99m, "https://www.burgerking.com.tr/cmsfiles/products/fish-royale-1.png?v=285", "Fish Royale Burger", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1996), true },
                    { 110, 1, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1997), "2 adet Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, 4 adet cheddar peyniri, hardal ve ketçaptan oluşan lezzet.", 159.99m, "https://www.burgerking.com.tr/cmsfiles/products/mega-double-cheeseburger.png?v=285", "Mega Double CheeseBurger", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(1998), true },
                    { 201, 2, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2000), "Doğal, soyulmuş, gevrek kızarmış patates", 59.99m, "https://www.burgerking.com.tr/cmsfiles/products/patates.png?v=285", "Patates", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2000), true },
                    { 202, 2, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2002), "Çıtır Mı Çıtır Altın Sarısı Tırtıklı Patates", 69.99m, "https://www.burgerking.com.tr/cmsfiles/products/tirtikli-patates.png?v=285", "Tırtıklı  Patates", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2002), true },
                    { 203, 2, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2004), "Çıtır çıtır 8’li, 12’li ya da 16’lı Soğan Halka lezzeti", 79.99m, "https://www.burgerking.com.tr/cmsfiles/products/sogan-halkasi.png?v=285", "Soğan Halkası", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2004), true },
                    { 204, 2, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2007), "Dışı çıtır çıtır, içi sıcacık peyniriyle Çıtır Peynir!", 75.99m, "https://www.burgerking.com.tr/cmsfiles/products/citir-peynir.png?v=285", "Çıtır Peynir", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2007), true },
                    { 205, 2, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2009), "Dışı çıtır çıtır Nuggets...", 75.99m, "https://www.burgerking.com.tr/cmsfiles/products/bk-king-nuggets-1.png?v=285", "Çıtır Nuggets", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2009), true },
                    { 206, 2, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2012), "Özel harcıyla nar gibi kızarmış  beyaz tavuk eti.", 85.99m, "https://www.burgerking.com.tr/cmsfiles/products/chicken-tenders.png?v=285", "Çıtır Tavuk Tenders", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2012), true },
                    { 301, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2014), "Şeftalili Fuse Tea ve Limonlu Fuse Tea seçenekleri ile", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/fuse-tea.png?v=285", "Fuse Tea", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2015), true },
                    { 302, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2016), "Cola cola ", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/coca-cola.png?v=285", "Coca Cola", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2017), true },
                    { 303, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2018), "Cola cola Zero ", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/coca-cola-zero-sugar.png?v=285", "Coca Cola Zero", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2019), true },
                    { 304, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2020), "Fanta", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/fanta.png?v=285", "Fanta", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2021), true },
                    { 305, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2022), "Sprite", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/sprite.png?v=285", "Sprite", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2023), true },
                    { 306, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2024), "Ayran", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/ayran-300-ml.png?v=285", "Ayran", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2025), true },
                    { 307, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2027), "Elma Suyu", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/elma-suyu.png?v=285", "Cappy Elma Suyu", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2027), true },
                    { 308, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2029), "Atom Suyu", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/cappy-atom-200-ml.png?v=285", "Cappy Atom", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2029), true },
                    { 309, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2031), "Kahve Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/espresso.png?v=285", "Espresso", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2031), true },
                    { 310, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2033), "Kahve Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/nescafe-black.png?v=285", "Filtre Kahve", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2033), true },
                    { 311, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2036), "Karadeniz Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/cay.png?v=285", "Çay", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2036), true },
                    { 312, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2037), "İtalyan Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/vanilyali-cappuccino.png?v=285", "Cappuccino", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2038), true },
                    { 313, 3, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2040), "Çikolata Lezzeti", 35.99m, "https://www.burgerking.com.tr/cmsfiles/products/nestle-sicak-cikolata.png?v=285", "Sıcak Çikolata", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2040), true },
                    { 401, 4, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2042), "Çikolata Lezzeti", 45.99m, "https://www.burgerking.com.tr/cmsfiles/products/cikolatali-cookie.png?v=285", "Çikolatalı Cookie", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2042), true },
                    { 402, 4, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2044), "Çikolata Lezzeti", 45.99m, "https://www.burgerking.com.tr/cmsfiles/products/sufle.png?v=285", "Sufle", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2044), true },
                    { 403, 4, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2047), "Vişne Lezzeti", 55.99m, "https://www.burgerking.com.tr/cmsfiles/products/visneli-tatli.png?v=285", "Vişneli Tatlı", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2047), true },
                    { 404, 4, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2050), "Vanilyalı, Çilekli, Çikolatalı, Espressolu, Limonlu çeşitleriyle.", 55.99m, "https://www.burgerking.com.tr/cmsfiles/products/espressolu-milkshake.png?v=285", "Espresso Milkshake", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2051), true },
                    { 405, 4, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2052), "Vanilyalı, Çikolata Soslu, Böğürtlen Soslu, Karamel Soslu, Çilek Soslu, Limonlu", 65.99m, "https://www.burgerking.com.tr/cmsfiles/products/king-sundae.png?v=285", "King Sundae", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2053), true },
                    { 406, 4, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2055), "Çikolata Parçacıklı, Renkli Çikolata Drajeleri, Limonlu", 75.99m, "https://www.burgerking.com.tr/cmsfiles/products/bkool.png?v=285", "Bkool", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2055), true },
                    { 501, 5, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2057), "Acı Sos", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-aci-sos.png?v=285", "Mini Acı Sos", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2057), true },
                    { 502, 5, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2059), "Mayonez", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-mayonez.png?v=285", "Mayonez", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2059), true },
                    { 503, 5, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2062), "Ranch Sos", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-ranch.png?v=285", "Mini Ranch", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2062), true },
                    { 504, 5, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2064), "Sarımsaklı Sos", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-sarimsakli-mayonez-1.png?v=285", "Sarımsaklı Sos", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2064), true },
                    { 505, 5, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2066), "Mini Ketçap", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-ketcap.png?v=285", "Mini Ketçap", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2066), true },
                    { 506, 5, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2068), "Buffalo Sos", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-buffalo-1.png?v=285", "Buffalo Sos", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2068), true }
>>>>>>>> 621cd44459feb588912b411c30d8adc12bf4c888:Hamburger/Hamburger/Migrations/20230903090141_initialdb.cs
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreateDate", "Description", "Price", "ProductImage", "ProductName", "UpdateDate", "isActive" },
<<<<<<<< HEAD:Hamburger/Hamburger/Migrations/20230903064456_init.cs
                values: new object[] { 507, 5, new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2649), "Mini BBQ", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-bbq.png?v=285", "Mini BBQ", new DateTime(2023, 9, 3, 9, 44, 56, 605, DateTimeKind.Local).AddTicks(2650), true });
========
                values: new object[] { 507, 5, new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2070), "Mini BBQ", 10.99m, "https://www.burgerking.com.tr/cmsfiles/products/mini-bbq.png?v=285", "Mini BBQ", new DateTime(2023, 9, 3, 12, 1, 40, 749, DateTimeKind.Local).AddTicks(2070), true });
>>>>>>>> 621cd44459feb588912b411c30d8adc12bf4c888:Hamburger/Hamburger/Migrations/20230903090141_initialdb.cs

            migrationBuilder.InsertData(
                table: "MenuProducts",
                columns: new[] { "ID", "MenuID", "ProductID" },
                values: new object[,]
                {
                    { 1, 1, 101 },
                    { 2, 1, 201 },
                    { 3, 1, 302 },
                    { 4, 2, 105 },
                    { 5, 2, 201 },
                    { 6, 2, 302 },
                    { 7, 3, 107 },
                    { 8, 3, 201 },
                    { 9, 3, 302 },
                    { 10, 4, 109 },
                    { 11, 4, 201 },
                    { 12, 4, 302 },
                    { 13, 5, 102 },
                    { 14, 5, 201 },
                    { 15, 5, 302 },
                    { 16, 6, 103 },
                    { 17, 6, 201 },
                    { 18, 6, 302 },
                    { 19, 7, 104 },
                    { 20, 7, 201 },
                    { 21, 7, 302 },
                    { 22, 8, 106 },
                    { 23, 8, 201 },
                    { 24, 8, 302 },
                    { 25, 9, 108 },
                    { 26, 9, 201 },
                    { 27, 9, 302 },
                    { 28, 10, 110 },
                    { 29, 10, 201 },
                    { 30, 10, 302 },
                    { 31, 11, 205 },
                    { 32, 11, 201 },
                    { 33, 11, 302 },
                    { 34, 12, 206 },
                    { 35, 12, 201 },
                    { 36, 12, 302 }
                });

            migrationBuilder.InsertData(
                table: "ProductToppings",
                columns: new[] { "ID", "ProductID", "ToppingID" },
                values: new object[,]
                {
                    { 1, 101, 1 },
                    { 2, 101, 2 },
                    { 3, 101, 3 },
                    { 4, 101, 4 },
                    { 5, 101, 8 },
                    { 6, 101, 9 }
                });

            migrationBuilder.InsertData(
                table: "ProductToppings",
                columns: new[] { "ID", "ProductID", "ToppingID" },
                values: new object[,]
                {
                    { 7, 102, 4 },
                    { 8, 102, 9 },
                    { 9, 103, 1 },
                    { 10, 103, 9 },
                    { 11, 103, 5 },
                    { 12, 103, 4 },
                    { 13, 103, 7 },
                    { 14, 103, 10 },
                    { 15, 104, 5 },
                    { 16, 104, 2 },
                    { 17, 104, 4 },
                    { 18, 104, 3 },
                    { 19, 104, 11 },
                    { 20, 105, 4 },
                    { 21, 105, 9 },
                    { 22, 105, 12 },
                    { 23, 105, 13 },
                    { 24, 105, 5 },
                    { 25, 106, 2 },
                    { 26, 106, 8 },
                    { 27, 106, 9 },
                    { 28, 106, 4 },
                    { 29, 106, 1 },
                    { 30, 106, 3 },
                    { 31, 107, 2 },
                    { 32, 107, 8 },
                    { 33, 107, 9 },
                    { 34, 107, 4 },
                    { 35, 107, 1 },
                    { 36, 107, 3 },
                    { 37, 108, 1 },
                    { 38, 108, 14 },
                    { 39, 108, 4 },
                    { 40, 109, 4 },
                    { 41, 109, 15 },
                    { 42, 110, 2 },
                    { 43, 110, 16 },
                    { 44, 110, 5 },
                    { 45, 110, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MenuProducts_MenuID",
                table: "MenuProducts",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuProducts_ProductID",
                table: "MenuProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_OrderID",
                table: "Messages",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserID",
                table: "Messages",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MenuID",
                table: "OrderDetails",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SizeID",
                table: "OrderDetails",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusID",
                table: "Orders",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductToppings_ProductID",
                table: "ProductToppings",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductToppings_ToppingID",
                table: "ProductToppings",
                column: "ToppingID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_MenuID",
                table: "UserFavorites",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_ProductID",
                table: "UserFavorites",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavorites_UserID",
                table: "UserFavorites",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MenuProducts");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductToppings");

            migrationBuilder.DropTable(
                name: "UserFavorites");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
