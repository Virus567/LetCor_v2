using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TouristСenterLibrary.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CheckpointRoute",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckpointRoute", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CountableEquipment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountableEquipment", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DriversLicenseNumber = table.Column<string>(type: "text", nullable: false),
                    Categories = table.Column<string>(type: "text", nullable: false),
                    DateDriversLicense = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DriverExperienceD = table.Column<double>(type: "double precision", nullable: false),
                    IsRemoved = table.Column<bool>(type: "boolean", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Middlename = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EventUser",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Middlename = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventUser", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsRemoved = table.Column<bool>(type: "boolean", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Middlename = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PositionName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    IsSchool = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transport",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Brand = table.Column<string>(type: "text", nullable: false),
                    DiagnosticCardNumber = table.Column<string>(type: "text", nullable: false),
                    CarNumber = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    DateDiagnosticCard = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateDiagnosticCardStr = table.Column<string>(type: "text", nullable: false),
                    IsRemoved = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TransportCompany",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportCompany", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypeEvent",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: false),
                    Shablon = table.Column<string>(type: "text", nullable: false),
                    IsRemoved = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeEvent", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    DateOfB = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    NameOfCompany = table.Column<string>(type: "text", nullable: true),
                    AddressOrg = table.Column<string>(type: "text", nullable: true),
                    OgrnIP = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Middlename = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NumberDays = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    FullDescription = table.Column<string>(type: "text", nullable: false),
                    CheckpointStartID = table.Column<int>(type: "integer", nullable: false),
                    CheckpointFinishID = table.Column<int>(type: "integer", nullable: false),
                    River = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Route_CheckpointRoute_CheckpointFinishID",
                        column: x => x.CheckpointFinishID,
                        principalTable: "CheckpointRoute",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Route_CheckpointRoute_CheckpointStartID",
                        column: x => x.CheckpointStartID,
                        principalTable: "CheckpointRoute",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PassportData = table.Column<string>(type: "text", nullable: false),
                    RoleID = table.Column<int>(type: "integer", nullable: false),
                    EmploymentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Middlename = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Charter",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserID = table.Column<int>(type: "integer", nullable: true),
                    Charterer = table.Column<string>(type: "text", nullable: false),
                    ChartererAddress = table.Column<string>(type: "text", nullable: false),
                    IsSchool = table.Column<bool>(type: "boolean", nullable: false),
                    DateStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateFinish = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PeopleAmount = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    TransportID = table.Column<int>(type: "integer", nullable: true),
                    DriverID = table.Column<int>(type: "integer", nullable: true),
                    StartRoutePoint = table.Column<string>(type: "text", nullable: false),
                    FinishRoutePoint = table.Column<string>(type: "text", nullable: false),
                    Inn = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ContractFilePath = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Charter_Driver_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Driver",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Charter_EventUser_UserID",
                        column: x => x.UserID,
                        principalTable: "EventUser",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Charter_Transport_TransportID",
                        column: x => x.TransportID,
                        principalTable: "Transport",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeEventID = table.Column<int>(type: "integer", nullable: true),
                    DateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    BusTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserID = table.Column<int>(type: "integer", nullable: true),
                    SchoolID = table.Column<int>(type: "integer", nullable: true),
                    Class = table.Column<string>(type: "text", nullable: false),
                    PeopleAmount = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    TravelSurcharge = table.Column<double>(type: "double precision", nullable: false),
                    BusSupplement = table.Column<double>(type: "double precision", nullable: false),
                    Discount = table.Column<double>(type: "double precision", nullable: false),
                    IsYourTransport = table.Column<bool>(type: "boolean", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    IsCash = table.Column<bool>(type: "boolean", nullable: false),
                    Prepayment = table.Column<double>(type: "double precision", nullable: false),
                    AccompanyAmount = table.Column<int>(type: "integer", nullable: false),
                    IdType = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ContractFilePath = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Event_EventUser_UserID",
                        column: x => x.UserID,
                        principalTable: "EventUser",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_School_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "School",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_TypeEvent_TypeEventID",
                        column: x => x.TypeEventID,
                        principalTable: "TypeEvent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TouristGroup",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PeopleAmount = table.Column<int>(type: "integer", nullable: false),
                    ChildrenAmount = table.Column<int>(type: "integer", nullable: false),
                    ChildrenAmount5 = table.Column<int>(type: "integer", nullable: false),
                    ChildrenAmount10 = table.Column<int>(type: "integer", nullable: false),
                    ChildrenAmount14 = table.Column<int>(type: "integer", nullable: false),
                    UserID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouristGroup", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TouristGroup_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hike",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RouteID = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hike", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hike_Route_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Route",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoutePoint",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<string>(type: "text", nullable: true),
                    Time = table.Column<string>(type: "text", nullable: false),
                    Point = table.Column<string>(type: "text", nullable: false),
                    CharterID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutePoint", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RoutePoint_Charter_CharterID",
                        column: x => x.CharterID,
                        principalTable: "Charter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventID = table.Column<int>(type: "integer", nullable: true),
                    DateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TypeContract = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contract_Event_EventID",
                        column: x => x.EventID,
                        principalTable: "Event",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Participant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TouristGroupID = table.Column<int>(type: "integer", nullable: false),
                    UserID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participant", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Participant_TouristGroup_TouristGroupID",
                        column: x => x.TouristGroupID,
                        principalTable: "TouristGroup",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participant_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CountableHikeEquipment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountableEquipmentID = table.Column<int>(type: "integer", nullable: true),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    HikeID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountableHikeEquipment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CountableHikeEquipment_CountableEquipment_CountableEquipmen~",
                        column: x => x.CountableEquipmentID,
                        principalTable: "CountableEquipment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CountableHikeEquipment_Hike_HikeID",
                        column: x => x.HikeID,
                        principalTable: "Hike",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentHike",
                columns: table => new
                {
                    EquipmentsListID = table.Column<int>(type: "integer", nullable: false),
                    HikesListID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentHike", x => new { x.EquipmentsListID, x.HikesListID });
                    table.ForeignKey(
                        name: "FK_EquipmentHike_Equipment_EquipmentsListID",
                        column: x => x.EquipmentsListID,
                        principalTable: "Equipment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentHike_Hike_HikesListID",
                        column: x => x.HikesListID,
                        principalTable: "Hike",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstructorGroup",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HikeID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorGroup", x => x.ID);
                    table.ForeignKey(
                        name: "FK_InstructorGroup_Hike_HikeID",
                        column: x => x.HikeID,
                        principalTable: "Hike",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationTypeID = table.Column<int>(type: "integer", nullable: true),
                    RouteID = table.Column<int>(type: "integer", nullable: true),
                    EmployeeID = table.Column<int>(type: "integer", nullable: true),
                    TouristGroupID = table.Column<int>(type: "integer", nullable: true),
                    WayToTravel = table.Column<string>(type: "text", nullable: false),
                    FoodlFeatures = table.Column<string>(type: "text", nullable: true),
                    EquipmentFeatures = table.Column<string>(type: "text", nullable: true),
                    StartTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FinishTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    HikeID = table.Column<int>(type: "integer", nullable: true),
                    IndividualTentAmount = table.Column<int>(type: "integer", nullable: false),
                    IndividualTent = table.Column<int>(type: "integer", nullable: false),
                    IndividualSleepingBag = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    InstructorID = table.Column<int>(type: "integer", nullable: true),
                    IsPhotograph = table.Column<bool>(type: "boolean", nullable: false),
                    Prepayment = table.Column<double>(type: "double precision", nullable: false),
                    ContractFilePath = table.Column<string>(type: "text", nullable: true),
                    IsCash = table.Column<bool>(type: "boolean", nullable: false),
                    BossType = table.Column<string>(type: "text", nullable: true),
                    Insurance = table.Column<double>(type: "double precision", nullable: true),
                    BasedOrganization = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_ApplicationType_ApplicationTypeID",
                        column: x => x.ApplicationTypeID,
                        principalTable: "ApplicationType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Hike_HikeID",
                        column: x => x.HikeID,
                        principalTable: "Hike",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Instructor_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Route_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Route",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_TouristGroup_TouristGroupID",
                        column: x => x.TouristGroupID,
                        principalTable: "TouristGroup",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RouteHike",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RouteID = table.Column<int>(type: "integer", nullable: true),
                    StartBusID = table.Column<int>(type: "integer", nullable: true),
                    FinishBusID = table.Column<int>(type: "integer", nullable: true),
                    StartCargoID = table.Column<int>(type: "integer", nullable: true),
                    FinishCargoID = table.Column<int>(type: "integer", nullable: true),
                    HikeID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteHike", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RouteHike_Hike_HikeID",
                        column: x => x.HikeID,
                        principalTable: "Hike",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RouteHike_Route_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Route",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RouteHike_Transport_FinishBusID",
                        column: x => x.FinishBusID,
                        principalTable: "Transport",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RouteHike_Transport_FinishCargoID",
                        column: x => x.FinishCargoID,
                        principalTable: "Transport",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RouteHike_Transport_StartBusID",
                        column: x => x.StartBusID,
                        principalTable: "Transport",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RouteHike_Transport_StartCargoID",
                        column: x => x.StartCargoID,
                        principalTable: "Transport",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstructorInstructorGroup",
                columns: table => new
                {
                    InstructorGroupsID = table.Column<int>(type: "integer", nullable: false),
                    InstructorsListID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorInstructorGroup", x => new { x.InstructorGroupsID, x.InstructorsListID });
                    table.ForeignKey(
                        name: "FK_InstructorInstructorGroup_Instructor_InstructorsListID",
                        column: x => x.InstructorsListID,
                        principalTable: "Instructor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstructorInstructorGroup_InstructorGroup_InstructorGroupsID",
                        column: x => x.InstructorGroupsID,
                        principalTable: "InstructorGroup",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApplicationType",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Семейная" },
                    { 2, "ИП" },
                    { 3, "ООО" }
                });

            migrationBuilder.InsertData(
                table: "CheckpointRoute",
                columns: new[] { "ID", "Title", "Type" },
                values: new object[,]
                {
                    { 20, "г. Кирово-Чепецк", "Финиш" },
                    { 19, "Слободской р-он, д Бабичи", "Финиш" },
                    { 18, "г. Слободской", "Старт" },
                    { 17, "Оричевский р-он, п Стрижи", "Старт" },
                    { 16, "Слободской р-он, Сидоровка", "Финиш" },
                    { 15, "Слободской-р-он, п. Боровица", "Старт" },
                    { 14, "Юрьянский р-он, п. Мурыгино", "Финиш" },
                    { 13, "г. Киров, Новый мост", "Старт" },
                    { 12, "г. Киров, Заречный парк", "Финиш" },
                    { 11, "г. Нововятск, Набережная", "Старт" },
                    { 9, "Оричевский р-он, д. Решетники", "Старт" },
                    { 8, "Лебяжский р-он, д. Приверх", "Финиш" },
                    { 7, "Советский р-он, п. Петропавловское", "Старт" },
                    { 6, "Орловский р-он, г. Орлов", "Финиш" },
                    { 5, "Юрьянский р-он, устье р. Великая", "Старт" },
                    { 4, "Белохолуницкий р-он, п.Стеклофилины", "Финиш" },
                    { 3, "Нагорский р-он, Летский рейд", "Старт" },
                    { 2, "Советский р-он, д. Долбилово", "Финиш" },
                    { 1, "Советский р-он, д. Фокино", "Старт" },
                    { 10, "Слободской р-он, д. Бошарово", "Финиш" }
                });

            migrationBuilder.InsertData(
                table: "CountableEquipment",
                columns: new[] { "ID", "Name", "Number" },
                values: new object[,]
                {
                    { 7, "Весло", 120 },
                    { 11, "Гермомешок", 142 },
                    { 10, "Костровые стойки", 10 },
                    { 9, "Котелок 8л", 9 },
                    { 6, "Палатка Lair2", 22 },
                    { 8, "Котелок 10л", 10 },
                    { 4, "Палатка Lair4", 40 },
                    { 3, "Канистра", 50 },
                    { 2, "Спальник", 139 },
                    { 1, "Коврик", 150 },
                    { 5, "Палатка Lair3", 15 }
                });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "ID", "Categories", "DateDriversLicense", "DriverExperienceD", "DriversLicenseNumber", "IsRemoved", "Middlename", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 1, "кат. В, С, Д", new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, "9923903185", false, "Иосифович", "Сергей", "+79229398345", "Петрашку" },
                    { 2, "кат. А, В, С, Д", new DateTime(2017, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, "4330587108", false, "Викторович", "Максим", "+79229683026", "Косарев" },
                    { 3, "кат. В, С, Д", new DateTime(2018, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, "6235937363", false, "Викторович", "Александр", "+79513557221", "Овсянников" },
                    { 4, "кат. А, В, С, Д", new DateTime(2015, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0, "4325987190", false, "Сергеевич", "Александр", "+79536783108", "Зайченко" }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "ID", "Name", "PurchaseDate", "Type" },
                values: new object[,]
                {
                    { 37, "Беседка B", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "pavilion" },
                    { 36, "Беседка A", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "pavilion" },
                    { 35, "Байдарка3 P", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak3" },
                    { 34, "Байдарка3 K", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak3" },
                    { 30, "Байдарка2 U", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 32, "Байдарка3 J", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak3" },
                    { 31, "Байдарка3 I", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak3" },
                    { 39, "Беседка D", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "pavilion" },
                    { 29, "Байдарка2 T", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 33, "Байдарка3 Q", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak3" },
                    { 40, "Беседка F", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "pavilion" },
                    { 44, "Складной стол №4", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "table" },
                    { 42, "Складной стол №2", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "table" },
                    { 43, "Складной стол №3", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "table" },
                    { 45, "Складной стол №5", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "table" },
                    { 46, "Складной стол №6", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "table" },
                    { 47, "Топор H", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ax" },
                    { 48, "Топор N", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ax" },
                    { 49, "Топор Q", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ax" },
                    { 50, "Топор T", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ax" },
                    { 56, "Топор Y", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ax" },
                    { 28, "Байдарка2 S", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 41, "Складной стол №1", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "table" },
                    { 27, "Байдарка2 R", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 38, "Беседка C", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "pavilion" },
                    { 25, "Байдарка2 P", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 26, "Байдарка2 Q", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 1, "Рафт A", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "raft" },
                    { 2, "Рафт D", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "raft" },
                    { 3, "Рафт K", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "raft" },
                    { 4, "Рафт L", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "raft" },
                    { 5, "Рафт M", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "raft" },
                    { 8, "Рафт S", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "raft" },
                    { 9, "Рафт X", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "raft" },
                    { 10, "Рафт Q", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "raft" },
                    { 11, "Байдарка2 A", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 12, "Байдарка2 B", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 13, "Байдарка2 C", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 6, "Рафт R", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "raft" },
                    { 21, "Байдарка2 K", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 15, "Байдарка2 E", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 16, "Байдарка2 F", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 17, "Байдарка2 G", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 18, "Байдарка2 H", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 19, "Байдарка2 I", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 20, "Байдарка2 J", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 24, "Байдарка2 O", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 22, "Байдарка2 L", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 23, "Байдарка2 M", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" },
                    { 14, "Байдарка2 D", new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "kayak2" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "ID", "PositionName" },
                values: new object[] { 1, "admin" });

            migrationBuilder.InsertData(
                table: "School",
                columns: new[] { "ID", "Address", "IsSchool", "Name" },
                values: new object[,]
                {
                    { 669, "Киров, Ленинградская улица, 4А", false, "МКДОУ детский сад № 55 г. Кирова" },
                    { 660, "Кировская область, Оричевский район, посёлок Торфяной, Стахановская улица, 11", false, "Детский сад Тополёк" },
                    { 670, "Кировская область, Омутнинский район, посёлок городского типа Песковка, улица Байдарова, 4", false, "МКДОУ детский сад № 5 Родничок пгт. Песковка" },
                    { 668, "Кировская область, Слободской район, посёлок городского типа Вахруши, Школьный переулок, 2", false, "МКДОУ детский сад № 8 пгт. Вахруши" },
                    { 667, "Кировская область, Омутнинск, Западная улица, 12", false, "МКДОУ детский сад № 14 Солнышко г. Омутнинск" },
                    { 661, "Кировская область, посёлок городского типа Юрья, улица Кирова, 25", false, "МКДОУ детский сад Родничок пгт. Юрья" },
                    { 665, "Киров, улица Красина, 56А", false, "Муниципальное казенное дошкольное образовательное учреждение детский сад № 189 г. Кирова" },
                    { 664, "Кировская область, Омутнинск, улица Ленина, 24А", false, "МКДОУ Детский сад № 10 Теремок г. Омутнинск" },
                    { 663, "Киров, улица Ленина, 164к3", false, "МКДОУ детский сад № 196" },
                    { 662, "Киров, микрорайон Лянгасово, Гражданская улица, 25", false, "МКДОУ детский сад № 175 г. Кирова" },
                    { 671, "Кировская область, Уржум, Красная улица, 163", false, "МКДОУ детский сад общеразвивающего вида № 5 г. Уржума" },
                    { 666, "Киров, улица Мира, 32", false, "МКДОУ детский сад № 58" },
                    { 672, "Киров, Октябрьская улица, 25", false, "МКДОУ детский сад № 229 города Кирова" },
                    { 684, "Киров, Нововятский район, улица Ленина, 22А", false, "Детский сад № 231 города Кирова" },
                    { 674, "Кировская область, Кумёнский район, село Вожгалы, Заречная улица, 9А", false, "Родничок" },
                    { 675, "Кировская область, Омутнинск, улица Володарского, 27А", false, "МКДОУ детский сад № 20 Росинка г. Омутнинск" },
                    { 676, "Киров, улица Крутикова, 1А", false, "МКДОУ детский сад № 107 г. Кирова" },
                    { 677, "Киров, Нововятский район, Советская улица, 62", false, "Детский сад № 224 города Кирова" },
                    { 678, "Киров, улица Кольцова, 8А", false, "МКДОУ детский сад № 143 г. Кирова" },
                    { 679, "Кировская область, Уржум, Красная улица, 37", false, "МКДОУ детский сад № 1 г. Уржума" },
                    { 680, "Кировская область, Оричевский район, село Коршик, ул. Почтовая,8", false, "МДОКУ детский сад с. Коршик Оричевского района Кировской области" },
                    { 681, "Киров, Нововятский район, улица Энгельса, 4А", false, "МКДОУ № 230 г. Кирова" },
                    { 682, "Киров, улица Грибоедова, 22А", false, "МКДОУ № 14 г. Кирова" },
                    { 683, "Киров, Первомайский район, Советская улица, 32", false, "МКДОУ детский сад № 72 Лукоморье" },
                    { 659, "Кировская область, Нолинск, улица Коммуны, 42А", false, "МКДОУ Детский сад № 5 Родничок г. Нолинска" },
                    { 685, "Киров, Первомайский район, Милицейская улица, 68А", false, "МКДОУ детский сад № 13 г. Кирова" },
                    { 686, "Кировская область, Омутнинск, улица Карла Либкнехта, 27", false, "МКДОУ детский сад № 19 Сказка г. Омутнинск" },
                    { 673, "Киров, Троллейбусный переулок, 10", false, "МКДОУ детский сад № 29 г. Кирова" },
                    { 658, "Кировская область, Уржум, улица Пирогова, 20", false, "Детский сад общеразвивающего вида № 3 г. Уржума МКДОУ" },
                    { 645, "Киров, улица Молодой Гвардии, 63А", false, "МКДОУ детский сад № 31 г. Кирова" },
                    { 656, "Киров, улица Кольцова, 28А", false, "МКДОУ детский сад № 124 г. Кирова" },
                    { 687, "Киров, микрорайон Красный Химик, улица Красный Химик, 2, корп. 3", false, "Детский сад" },
                    { 629, "Кировская область, Юрьянский район, посёлок городского типа Мурыгино, улица Большевиков, 2", false, "Детский сад Тополек пгт. Мурыгино" },
                    { 630, "Киров, Московская улица, 151А", false, "МКДОУ № 163" },
                    { 631, "Кировская область, Орлов, Орловская улица, 54", false, "МКДОУ детский сад общеразвивающего вида Калинка г. Орлова" },
                    { 632, "Киров, улица Труда, 84А", false, "Кроха" },
                    { 633, "Киров, слобода Лянгасы, Молчановская улица, 9", false, "МКДОУ детский сад № 25 г. Кирова" },
                    { 634, "Кировская область, Кирово-Чепецкий район, поселок Ключи, ул Дружбы 10", false, "Мкдоу Детский сад Солнышко п. Ключи" },
                    { 635, "Кировская область, Котельнич, улица Победы, 26А", false, "МБДОУ детский сад № 2 Сказка г. Котельнича" },
                    { 636, "Киров, Красноармейская улица, 4", false, "УПС! Пупс!" },
                    { 637, "Кировская область, посёлок городского типа Нагорск, Советская улица, 156", false, "Детсад № 4" },
                    { 638, "Кировская область, Юрьянский район, посёлок городского типа Мурыгино, Фестивальная улица, 11", false, "Детский сад" },
                    { 639, "Кировская область, посёлок городского типа Верхошижемье, Комсомольская улица, 10", false, "Детский сад № 2" },
                    { 640, "Киров, микрорайон Радужный, Школьный переулок, 9", false, "МКДОУ детский сад № 22 г. Кирова" },
                    { 641, "Кировская область, Тужинский район, посёлок городского типа Тужа, улица Комарова, 24А", false, "Родничок" },
                    { 642, "Кировская область, Нолинский район, деревня Рябиновщина, Полевая улица, 16А", false, "МКДОУ детский сад Березка д. Рябиновщина" },
                    { 643, "Киров, слобода Сошени, Трудовая улица, 25", false, "Детский сад № 226" },
                    { 644, "Кировская область, Советск, Солнечная улица, 14", false, "Светлячок" },
                    { 646, "Киров, Октябрьский проспект, 85", false, "МКДОУ детский сад № 20 г. Кирова" },
                    { 647, "Киров, Мостовицкая улица, 3А", false, "МКДОУ детский сад № 24" },
                    { 648, "Киров, улица Опарина, 32", false, "МКДОУ детский сад № 216 города Кирова" },
                    { 649, "Кировская область, Советск, улица Мира, 38", false, "Детский сад № 5 г. Советска Кировской области" },
                    { 650, "Кирово-Чепецк, проспект Мира, 53В", false, "МБДОУ детский сад № 5 г. Кирово-Чепецка" },
                    { 651, "Кировская область, Омутнинск, улица Свободы, 34", false, "Детский сад Алёнушка" },
                    { 652, "Киров, улица Дзержинского, 21А", false, "МКДОУ детский сад № 181 г. Кирова" },
                    { 653, "Киров, Чистопрудненская улица, 1А", false, "МКДОУ детский сад № 4 г. Кирова" },
                    { 654, "Кирово-Чепецкий муниципальный район, Пасеговское сельское поселение, село Пасегово, Молодёжная улица, 1А", false, "МКДОУ детский сад Колосок с. Пасегово" },
                    { 655, "Кировская область, Слободской район, посёлок городского типа Вахруши, Рабочая улица, 44", false, "МКДОУ детский сад комбинированного вида № 4 пгт. Вахруши" },
                    { 657, "Кировская область, Слободской район, деревня Салтыки, 18", false, "Муниципальное казенное общеобразовательное учреждение ООШ деревни Салтыки Слободского района Кировской области" },
                    { 688, "Киров, Красноармейская улица, 42к3", false, "Святки" },
                    { 733, "Киров, улица Энтузиастов, 17А", false, "Детский сад № 27" },
                    { 690, "Кировская область, Слободской, улица А.С. Пушкина, 31", false, "Солнышко" },
                    { 723, "Киров, улица Воровского, 75Б", false, "МКДОУ детский сад № 192 г. Кирова" },
                    { 724, "Кировская область, посёлок городского типа Свеча, улица Труда, 20", false, "МДОУ детский сад Родничок пгт. Свеча" },
                    { 725, "Киров, Первомайский район, улица Володарского, 164", false, "МКДОУ детский сад № 12" },
                    { 726, "Киров, улица Чехова, 1", false, "МКДОУ детский сад № 49 Улыбка г. Кирова" },
                    { 727, "Киров, Современная улица, 4", false, "МКДОУ детский сад № 8" },
                    { 728, "Кировская область, Яранск, улица Чапаева, 9А", false, "МКДОУ детский сад Петушок г. Яранска" },
                    { 729, "Кировская область, Верхнекамский район, поселок городского типа Рудничный, улица Пушкина, 1", false, "МКДОУ детский сад общеразвивающего вида Сказка пгт. Рудничный" },
                    { 730, "Кирово-Чепецкий муниципальный район, село Фатеево, Комсомольская улица, 5", false, "МКДОУ детский сад Березка с. Фатеево" },
                    { 731, "Киров, Московская улица, 157А", false, "МКДОУ детский сад № 33 г. Кирова" },
                    { 732, "Киров, улица Некрасова, 25А", false, "МКДОУ детский сад № 169 г. Кирова" },
                    { 628, "Киров, Ленинский район, улица Карла Либкнехта, 8", false, "МКДОУ детский сад № 199 Крепыш города Кирова" },
                    { 734, "Киров, Первомайский район, улица Володарского, 79А", false, "МКДОУ детский сад № 128 города Кирова" },
                    { 735, "Кировская область, Луза, 1-й Набережный переулок, 20", false, "МКДОУ детский сад № 14 г. Луза" },
                    { 736, "Кирово-Чепецк, проспект Россия, 27, корп. 1", false, "Детский сад № 8 г. Кирово-Чепецка" },
                    { 737, "Кировская область, Слободской район, посёлок городского типа Вахруши, улица Ленина, 26А", false, "МКДОУ детский сад общеразвивающего вида № 7 пгт. Вахруши" },
                    { 738, "Кировская область, Верхнекамский муниципальный округ, посёлок городского типа Рудничный, Овражная улица, 1", false, "Детский сад Теремок" },
                    { 739, "Кировская область, Фаленский район, поселок городского типа Фаленки, Сельская улица, 5", false, "МКДОУ детский сад Буратино пгт Фаленки" },
                    { 740, "Кировская область, Слободской, Советская улица, 50", false, "Алёнушка" },
                    { 741, "Кировская область, Оричевский район, село Адышево, Советская улица, 14А", false, "Солнышко" },
                    { 742, "Кирово-Чепецк, проспект Мира, 65, корп. 2", false, "МБДОУ детский сад № 22 г. Кирово-Чепецка" },
                    { 743, "Киров, улица Екатерины Кочкиной, 6, корп. 2", false, "МКДОУ детский сад № 165 г. Кирова" },
                    { 744, "Кировская область, Уржум, улица Дрелевского, 58А", false, "МКДОУ детский сад № 2" },
                    { 745, "Кировская область, Слободской, Советская улица, 52Ф", false, "Тополёк" },
                    { 746, "Киров, улица Воровского, 62А", false, "МКДОУ детский сад № 129 города Кирова Солнышко" },
                    { 747, "Кирово-Чепецкий муниципальный район, деревня Чуваши, Юбилейная улица, 15", false, "Детский сад" },
                    { 748, "Киров, микрорайон Коминтерновский, улица Павла Корчагина, 240к2", false, "Радуга" },
                    { 749, "Киров, улица Дзержинского, 19А", false, "МКДОУ детский сад № 6 г. Кирова" },
                    { 722, "Киров, улица Лепсе, 36", false, "МКДОУ детский сад № 16 города Кирова" },
                    { 721, "Киров, улица Ивана Попова, 26Б", false, "Детский сад № 207" },
                    { 720, "Кирово-Чепецкий муниципальный район, село Бурмакино, Школьная улица, 1", false, "МКДОУ детский сад Лучик с. Бурмакино" },
                    { 719, "Киров, улица Большева, 13", false, "МКДОУ детский сад № 191 г. Кирова" },
                    { 691, "Киров, улица Мельникова, 12", false, "МКДОУ детский сад № 85 г. Кирова" },
                    { 692, "Киров, улица Опарина, 34", false, "Детский сад комбинированного вида № 223" },
                    { 693, "Киров, улица Дружбы, 9А", false, "Детский сад № 61 города Кирова" },
                    { 694, "Киров, улица Олега Кошевого, 6", false, "МКДОУ детский сад № 151 г. Кирова" },
                    { 695, "Киров, Октябрьский проспект, 64А", false, "МКДОУ детский сад № 119 г. Кирова" },
                    { 696, "Киров, улица Сурикова, 10Б", false, "МКДОУ детский сад № 188 г. Кирова" },
                    { 697, "Киров, улица Гагарина, 2А", false, "Детский сад 216/2" },
                    { 698, "Киров, проезд Шаляпина, 5А", false, "МКДОУ № 84" },
                    { 699, "Кирово-Чепецк, улица Ленина, 2, корп. 3", false, "МБДОУ детский сад № 3 г. Кирово-Чепецка" },
                    { 700, "Кировская область, Кирс, улица Гоголя, 21", false, "МКДОУ детский сад общеразвивающего вида № 2 Журавушка г. Кирс" },
                    { 701, "Кировская область, посёлок городского типа Санчурск, Мирный переулок, 1", false, "МКДОУ детский сад Теремок пгт. Санчурск" },
                    { 702, "Кировская область, посёлок городского типа Опарино, Первомайская улица, 32", false, "МКДОУ детский сад общеразвивающего вида № 1 Светлячок пгт. Опарино" },
                    { 703, "Кировская область, посёлок городского типа Фалёнки, Советская улица, 35А", false, "МКДОУ детский сад Родничок" },
                    { 689, "Киров, улица Энтузиастов, 3к1", false, "МКДОУ детский сад № 40 г. Кирова" },
                    { 704, "Киров, улица Екатерины Кочкиной, 6", false, "МКДОУ детский сад № 185 г. Кирова" },
                    { 706, "Киров, улица Ивана Попова, 40Б", false, "МКДОУ детский сад № 164 г. Кирова" },
                    { 707, "Кировская область, Кирово-Чепецкий район, село Полом, улица Петра Родыгина, 15", false, "МКДОУ детский сад Ромашка с. Полом" },
                    { 708, "Киров, микрорайон Радужный, Школьный переулок, 2", false, "МКДОУ детский сад № 2" },
                    { 709, "Киров, улица Лепсе, 50", false, "МКДОУ детский сад № 28 г. Кирова" },
                    { 710, "Кировская область, Немский муниципальный округ, село Ильинское, Советская улица, 49", false, "Детский сад общеразвивающего вида Солнышко" },
                    { 711, "Кировская область, Оричевский район, посёлок городского типа Мирный, улица Ленина, 10", false, "Детский сад Светлячок" },
                    { 712, "Кировская область, Верхнекамский муниципальный округ, посёлок городского типа Лесной, улица МОПРа, 50", false, "Детский сад общеразвивающего вида Ромашка МКДОУ" },
                    { 713, "Киров, микрорайон Коминтерновский, Пионерская улица, 15", false, "МКДОУ детский сад № 91 города Кирова" },
                    { 714, "Киров, Профсоюзная улица, 46А", false, "МКДОУ детский сад № 66 г. Кирова" },
                    { 715, "Киров, улица Дерендяева, 64А", false, "МКДОУ № 172 г. Кирова" },
                    { 716, "Киров, улица Красина, 45А", false, "МКДОУ № 17 города Кирова" },
                    { 717, "городской округ Город Киров, деревня Большая Субботиха, Центральная улица, 9", false, "МКДОУ детский сад № 173 г. Кирова" },
                    { 718, "Кировская область, Подосиновский район, посёлок городского типа Демьяново, микрорайон Берёзки, 2", false, "МКДОУ детский сад Сказка" },
                    { 705, "Кировская область, Сунский район, деревня Кокуй, улица Космонавтов, 18", false, "МКДОУ детский сад Малышок д. Кокуй" },
                    { 627, "Киров, микрорайон Коминтерновский, улица 8 Марта, 7", false, "МКДОУ детский сад № 21 города Кирова" },
                    { 582, "Кировская область, Нолинск, улица Ленина, 14", false, "МКДОУ детский сад № 4" },
                    { 625, "Кировская область, Белохолуницкий район, поселок Подрезчиха", false, "Детский сад Березка п. Подрезчиха МКДОУ" },
                    { 535, "Кировская область, Кумёнский район, Речное сельское поселение, посёлок Речной, улица Фадеева, 3", false, "Детский сад Ручеек" },
                    { 536, "Кировская область, посёлок городского типа Оричи, улица 8 Марта, 13А", false, "Детский сад общеразвивающего вида Родничок пгт. Оричи МДОКУ" },
                    { 537, "Кировская область, Слободской район, посёлок городского типа Вахруши, Коммунистическая улица, 2А", false, "МКДОУ центр развития ребенка детский сад № 5 пгт. Вахруши" },
                    { 538, "Кирово-Чепецкий муниципальный район, село Кстинино, Профсоюзная улица, 6А", false, "Мкдоу Детский сад Колокольчик с. Кстинино" },
                    { 539, "Кировская область, Юрьянский район, посёлок городского типа Мурыгино, Советская улица, 4", false, "Детский сад Малиновка" },
                    { 540, "Кировская область, Котельнич, улица Победы, 8А", false, "МБДОУ детский сад № 5 Колокольчик г. Котельнича" },
                    { 541, "Кировская область, Мураши, улица Маяковского, 6", false, "МДОКУ детский сад № 2 г. Мураши" },
                    { 542, "Кировская область, посёлок городского типа Первомайский, Советская улица, 20", false, "МКДОУ детский сад Золотые зернышки" },
                    { 543, "Кировская область, Слободской, улица Энгельса, 31Ф", false, "МКДОУ детский сад Огонёк" },
                    { 544, "городской округ Киров, посёлок Костино, улица 60 лет СССР, 20", false, "МКДОУ детский сад № 190 г. Кирова" },
                    { 545, "Кировская область, посёлок городского типа Первомайский, улица Волкова, 1", false, "МКДОУ детский сад Улыбка Закрытого Административно-Территориального Образования Первомайский Кировской области" },
                    { 546, "Кировская область, Слободской, Рождественская улица, 1А", false, "МКДОУ детский сад Золотой ключик" },
                    { 547, "Кировская область, посёлок городского типа Оричи, улица Молодой Гвардии, 52", false, "МДОКУ детский сад Сказка пгт. Оричи Оричевского района Кировской области" },
                    { 548, "Кировская область, Слободской район, деревня Митино, Санаторная улица, 7", false, "Детский сад" },
                    { 549, "Кировская область, Юрьянский район, посёлок городского типа Юрья, улица Ленина, 50", false, "МКДОУ детский сад Колобок пгт. Юрья" },
                    { 550, "Кировская область, Мураши, Пионерская улица, 26/9", false, "Детский сад № 1 Города Мураши Кировской области" },
                    { 551, "Кировская область, посёлок городского типа Первомайский, улица Ленина, 6", false, "Теремок" },
                    { 552, "Киров, улица Крупской, 5А", false, "МКДОУ детский сад № 181 корпус 2 Белый аист" },
                    { 553, "городской округ Киров, село Бахта, Советская улица, 19", false, "Детский сад № 10 г. Кирово" },
                    { 554, "Кировская область, Слободской район, деревня Стулово, Трактовая улица, 43/1", false, "МКДОУ детский сад № 2 деревни Стулово Слободского района Кировской области" },
                    { 555, "Киров, Московская улица, 215", false, "Детский сад" },
                    { 556, "Кировская область, Белая Холуница, Советская улица, 26", false, "Детский сад Колокольчик" },
                    { 557, "Кировская область, Омутнинский район, посёлок городского типа Восточный, улица Кирова, 4Б", false, "МКДОУ детский сад № 3 Сказка пгт. Восточный" },
                    { 558, "Кировская область, Орлов, улица Степана Халтурина, 9", false, "МКДОУ детский сад общеразвивающего вида № 3 г. Орлова" },
                    { 559, "Кировская область, Котельничский район, поселок Юбилейный, Молодёжная улица, 3", false, "Ленок" },
                    { 560, "Кировская область, Нолинский район, Красноярское сельское поселение, деревня Чащино, Центральная улица, 18", false, "Детский сад" },
                    { 561, "Кировская область, Кирс, улица Кирова, 44", false, "МКДОУ детский сад № 5 Улыбка г. Кирс" },
                    { 534, "Кировская область, Яранск, улица Чернышевского, 2А", false, "МКДОУ детский сад Солнышко" },
                    { 533, "городской округ Киров, село Порошино, Порошинская улица, 35А", false, "МКДОУ детский сад № 144 г. Кирова" },
                    { 532, "Кировская область, посёлок городского типа Кумёны, улица Гагарина, 33", false, "МКДОУ детский сад общеразвивающего вида Колокольчик пгт. Кумёны Кумёнского района Кировской области" },
                    { 531, "городской округ Киров, поселок Дороничи, улица Мира, 10А", false, "МКДОУ детский сад № 157 г. Кирова" },
                    { 503, "городской округ Киров, село Русское, Новая улица, 14", false, "Детский сад общеразвивающего вида № 15 г. Кирова" },
                    { 504, "Кировская область, Слободской, улица Корто, 12", false, "МКДОУ детский сад Родничок" },
                    { 505, "Кировская область, Верхошижемский район, посёлок городского типа Верхошижемье, улица Кирова, 100", false, "Детский сад № 1 пгт Верхошижемье Кировской области" },
                    { 506, "Кировская область, Орлов, улица Кирова, 102", false, "МКДОУ Дсорв Теремок" },
                    { 507, "Кировская область, Советск, улица Кирова, 113", false, "МКДОУ детский сад Малышок г. Советск" },
                    { 508, "Кировская область, Слободской район, посёлок городского типа Вахруши, улица Кирова, 6", false, "Детский сад комбинированного вида № 3 пгт. Вахруши МКДОУ" },
                    { 509, "Кировская область, Слободской, Кедровая улица, 7", false, "Детский сад" },
                    { 510, "Кировская область, Белохолуницкий район, посёлок Дубровка", false, "Детский сад Солнышко п. Дубровка МКДОУ" },
                    { 511, "Кировская область, Слободской район, посёлок городского типа Вахруши, улица Мира, 2А", false, "Детский сад комбинированного вида № 6" },
                    { 512, "Кировская область, Верхошижемский район, село Среднеивкино, улица Труда, 3", false, "МКДОУ детский сад с. Среднеивкино" },
                    { 513, "Кировская область, Слободской, проспект Гагарина, 22", false, "МКДОУ детский сад Берёзка" },
                    { 514, "Кировская область, посёлок городского типа Юрья, улица Энгельса, 19", false, "МКДОУ детский сад общеразвивающего вида Калинка пгт. Юрья" },
                    { 515, "Киров, Спортивная улица, 1", false, "Детский сад № 213" },
                    { 562, "Киров, микрорайон Коминтерновский, Торфяная улица, 11", false, "МКДОУ детский сад № 166, корпус 2" },
                    { 516, "Кировская область, Оричевский район, посёлок городского типа Стрижи, Комсомольская улица, 6", false, "МДОКУ ЦРР детский сад Солнышко пгт Стрижи Оричевского района Кировской области" },
                    { 518, "Кировская область, Слободской район, село Бобино, улица Мира, 18", false, "МКДОУ детский сад общеразвивающего вида с. Бобино" },
                    { 519, "Кировская область, Советск, улица Карла Маркса, 58", false, "Детский сад Родничок г. Советска" },
                    { 520, "Киров, Октябрьский проспект, 120А", false, "Детский сад" },
                    { 521, "Кировская область, посёлок городского типа Уни, улица 40 лет Победы, 2", false, "Детский сад" },
                    { 522, "Кировская область, Слободской район, деревня Шихово, Центральная улица, 14", false, "Мкоду детский сад общеразвивающего вида д. Шихово Слободского района Кировской области" },
                    { 523, "Кировская область, Слободской, Рабочая улица, 17", false, "МКДОУ детский сад Золотой петушок" },
                    { 524, "Кировская область, Советск, улица Кирова, 32", false, "МКДОУ детский сад комбинированного вида Василек г. Советск" },
                    { 525, "Кировская область, Юрьянский район, посёлок городского типа Мурыгино, Набережная улица, 2А", false, "МКДОУ детский сад Теремок пгт. Мурыгино" },
                    { 526, "Кировская область, Слободской, улица Петра Стучки, 49", false, "МКДОУ детский сад Колобок" },
                    { 527, "Кировская область, Слободской район, деревня Стулово, Трактовая улица, 59", false, "МКДОУ детский сад № 1" },
                    { 528, "Кировская область, Слободской, Никольская улица, 36", false, "МКДОУ детский сад Колокольчик" },
                    { 529, "Кировская область, Лебяжский район, поселок городского типа Лебяжье, улица Мира, 14", false, "МКДОУ детский сад общеразвивающего вида № 1 пгт. Лебяжье" },
                    { 530, "Кировская область, Слободской, Рождественская улица, 102Ф", false, "МКДОУ детский сад Звездочка г. Слободского" },
                    { 517, "Кировская область, Юрьянский район, деревня Подгорцы, Зелёная улица, 2", false, "МКДОУ детский сад Василек д. Подгорцы Кировской области" },
                    { 626, "Кировская область, Омутнинский район, посёлок городского типа Восточный, Снежная улица, 10", false, "МКДОУ детский сад Снежинка п Восточный" },
                    { 563, "Кировская область, посёлок городского типа Арбаж, Кооперативная улица, 22", false, "МБДОУ детский сад Солнышко" },
                    { 565, "Кировская область, Котельнич, Советская улица, 38", false, "МБДОУ детский сад № 7 Калинка г. Котельнича" },
                    { 598, "Киров, улица Дзержинского, 66", false, "МКДОУ детский сад № 79 г. Кирова" },
                    { 599, "Кировская область, посёлок городского типа Кумёны, Лесная улица, 17А", false, "Березка" },
                    { 600, "Киров, улица Ленина, 188к1", false, "МКДОУ детский сад № 11 города Кирова" },
                    { 601, "Кировская область, Мураши, улица Кирова, 13", false, "МДОКУ детский сад № 3 г. Мураши" },
                    { 602, "Кировская область, Белая Холуница, улица Энгельса, 6", false, "МКДОУ детский сад № 2 Светлячок г. Белая Холуница" },
                    { 603, "Кировская область, посёлок городского типа Даровской, улица Большевиков, 25", false, "МКДОУ детский сад общеразвивающего вида № 1 пгт. Даровской" },
                    { 604, "Кировская область, Сунский район, посёлок Большевик, Центральный переулок, 4", false, "МКДОУ детский сад Колосок п. Большевик" },
                    { 605, "Кирово-Чепецкий муниципальный район, железнодорожная станция Просница, Коммунистическая улица, 16", false, "МКДОУ детский сад Радуга СТ. Просница" },
                    { 606, "Кировская область, Мурашинский муниципальный округ, посёлок Безбожник, Почтовая улица, 48", false, "МДОКУ детский сад Лесная сказка" },
                    { 607, "Киров, микрорайон Лянгасово, Лесная улица, 9", false, "МКДОУ детский сад № 171 г. Кирова" },
                    { 608, "Кировская область, Верхнекамский муниципальный округ, посёлок городского типа Светлополянск, улица Дзержинского, 18", false, "МКДОУ детский сад общеразвивающего вида Аленушка поселка городского типа Светлополянск" },
                    { 609, "Киров, Чистопрудненская улица, 8А", false, "Детский сад № 4, Корпус 2" },
                    { 610, "Киров, улица Чапаева, 10А", false, "МКДОУ детский сад комбинированного типа № 9 Колобок города Кирова" },
                    { 611, "Киров, Московская улица, 22", false, "МКДОУ детский сад № 70" },
                    { 612, "Кировская область, Советск, Кооперативная улица, 12", false, "МКДОУ детский сад для детей раннего возраста Солнышко г. Советск" },
                    { 613, "Киров, улица Ленина, 189, корп. 1", false, "Family" },
                    { 614, "Кировская область, посёлок городского типа Кильмезь, улица Труда, 29", false, "МКДОУ детский сад общеразвивающего вида Солнышко" },
                    { 615, "Кировская область, Котельнич, улица Ленина, 7", false, "МБДОУ детский сад № 4 Родничок г. Котельнича" },
                    { 616, "Кировская область, Оричевский район, посёлок городского типа Мирный, улица Ленина, 20", false, "Светлячок" },
                    { 617, "Киров, улица Дзержинского, 6", false, "Logo Сад" },
                    { 618, "Россия, Киров, Краснополянская улица, 15", false, "Счастье" },
                    { 619, "Кировская область, Нолинск, улица Федосеева, 41", false, "Солнышко" },
                    { 620, "Кировская область, Яранск, улица Некрасова, 55", false, "МКДОУ детский сад Малышка г. Яранска" },
                    { 621, "Кировская область, Омутнинск, Северная улица, 73", false, "МКДОУ ДС № 8 Колокольчик г. Омутнинск Кировской области" },
                    { 622, "Киров, улица Ивана Попова, 95", false, "Разноцветная планета" },
                    { 623, "Киров, микрорайон Лянгасово, Октябрьская улица, 32", false, "МКДОУ детский сад № 179 г. Кирова" },
                    { 624, "Кировская область, Слободской район, деревня Стулово, Садовая улица, 14А", false, "МКДОУ детский сад № 9 деревни Стулово Слободского района Кировской области" },
                    { 597, "Киров, улица Ленина, 89Б", false, "Sova, Английский детский сад" },
                    { 596, "Кировская область, Зуевка, улица Кирова, 9А", false, "МКДОУ детский сад Улыбка г. Зуевка" },
                    { 595, "Кировская область, Кирс, улица Большевиков, 19", false, "МКДОУ детский сад общеразвивающего вида № 7 Теремок г. Кирс" },
                    { 594, "Кировская область, Слободской район, село Ильинское, Набережная улица, 1", false, "МКДОУ детский сад с. Ильинское" },
                    { 566, "Киров, улица Энтузиастов, 25А", false, "Мир детства" },
                    { 567, "Киров, Чистопрудненская улица, 15", false, "Детский сад № 5" },
                    { 568, "Кировская область, Зуевка, Торговая улица, 10", false, "МКДОУ Родничок г. Зуевка" },
                    { 569, "Кировская область, посёлок городского типа Свеча, улица Культуры, 8", false, "МДОУ детский сад Теремок пгт. Свеча" },
                    { 570, "Кировская область, Нолинск, улица Бехтерева, 11Б", false, "МКДОУ детский сад № 2 Колобок г. Нолинска" },
                    { 571, "Киров, Коммунистическая улица, 30", false, "Детский сад № 227 города Кирова" },
                    { 572, "Кировская область, Оричевский район, посёлок городского типа Лёвинцы, улица 70-летия Октября, 122", false, "МДОКУ детский сад комбинированного вида Сказка пгт. Лёвинцы" },
                    { 573, "Киров, Первомайский район, улица МОПРа, 82В", false, "МКДОУ детский сад № 235" },
                    { 574, "Киров, микрорайон Юго-Западный, улица Космонавта Владислава Волкова, 2, корп. 2", false, "МКДОУ детский сад № 51 г. Кирова" },
                    { 575, "Киров, Севастопольская улица, 5", false, "МКДОУ детский сад № 226, корпус 2" },
                    { 576, "Киров, село Макарье, Проезжая улица, 22А", false, "Детский сад № 46 г. Кирова" },
                    { 577, "городской округ Город Киров, поселок Ганино, Центральная улица, 10", false, "МКДОУ детский сад № 183 г. Кирова" },
                    { 578, "Кировская область, Советск, Советская улица, 81А", false, "Полянка" },
                    { 564, "Кировская область, Слободской, улица Грина, 47А", false, "МКДОУ Солнышко" },
                    { 579, "городской округ Город Киров, поселок Сидоровка, улица Космонавтов, 15", false, "МКДОУ детский сад № 225 г. Кирова" },
                    { 581, "Кировская область, Немский муниципальный округ, село Архангельское, Советская улица, 74А", false, "Детский сад Колосок" },
                    { 750, "Кировская область, Кирс, улица Ленина, 14", false, "МКДОУ детский сад № 4 Росинка" },
                    { 583, "Кировская область, Яранск, улица Мицкевича, 44", false, "МКДОУ детский сад Сказка г. Яранска" },
                    { 584, "Кировская область, Омутнинск, улица 30-летия Победы, 30", false, "МКДОУ детский сад № 17 Чебурашка г. Омутнинск" },
                    { 585, "Кировская область, Сунский район, посёлок городского типа Суна, улица Большевиков, 1А", false, "МКДОУ детский сад Родничок пгт. Суна" },
                    { 586, "Кировская область, посёлок городского типа Даровской, Заречная улица, 3", false, "МКДОУ детский сад общеразвивающего вида № 4 пгт. Даровской" },
                    { 587, "Кировская область, Белая Холуница, улица Глазырина, 4Б", false, "Алёнушка" },
                    { 588, "Кировская область, Омутнинск, улица Свободы, 29", false, "МКДОУ ДС Рябинка-центр развития ребенка" },
                    { 589, "Кировская область, Котельнич, Октябрьская улица, 162", false, "Муниципальное бюджетное дошкольное образовательное учреждение детский сад № 10 Ягодка" },
                    { 590, "Кировская область, Кумёнский район, поселок городского типа Нижнеивкино, Садовый переулок, 3", false, "МКДОУ детский сад Сказка пгт. Нижнеивкино" },
                    { 591, "Киров, микрорайон Радужный, улица Конституции, 8А", false, "МКДОУ детский сад № 3" },
                    { 592, "Киров, Первомайский район, Заводская улица, 10А", false, "МКДОУ детский сад № 88" },
                    { 593, "Кировская область, Орловский район, деревня Кузнецы, Школьная улица, 4", false, "Золотой Ключик" },
                    { 580, "Киров, Профсоюзная улица, 52", false, "МКДОУ детский сад № 202 Теремок города Кирова" },
                    { 751, "Киров, улица Рудницкого, 68А", false, "Страна детей" },
                    { 795, "Кировская область, Кирс, Милицейская улица, 26/22", false, "Детский сад № 3 Радуга" },
                    { 753, "Киров, Ленинский район, улица Азина, 80В", false, "МКДОУ детский сад № 133 г. Кирова" },
                    { 911, "Киров, Ленинский район, улица 65-летия Победы, 1", false, "Здоровые Дети" },
                    { 912, "Кировская область, Луза, улица Тургенева, 1А", false, "МКДОУ детский сад № 2 г. Луза" },
                    { 913, "Киров, Ленинский район, Агрономическая улица, 9", false, "Наследие" },
                    { 914, "Кировская область, Слободской, посёлок Межколхозстрой, 2", false, "Детский сад № 8 пгт Вахруши Слободского района Кировской области" },
                    { 915, "Кировская область, Луза, Песчаная улица, 11", false, "МКДОУ детский сад № 22 г. Лузы" },
                    { 916, "Киров, Московская улица, 107к1", false, "Андрюшка" },
                    { 917, "Россия, Киров, улица Молодой Гвардии, 90", false, "Капуста" },
                    { 918, "Кировская область, Слободской район, деревня Беляевская, коттеджный посёлок Посёлок Программистов", false, "Детский сад Комбинированного Вида № 3 Посёлка Городского Типа Вахруши Слободского района Кировской области" },
                    { 919, "Киров, улица Захватаева, 7", false, "МКДОУ № 26" },
                    { 920, "Киров, Студенческий проезд, 3", false, "Ладошки" },
                    { 921, "Киров, Милицейская улица, 71", false, "Мэри Поппинс" },
                    { 922, "Киров, улица Горбуновой, 10", false, "Мамина Радость" },
                    { 923, "Кировская область, Слободской район, село Бобино, улица Мира, 2А", false, "Детский сад Комбинированного Вида № 6 Поселка Городского Типа Вахруши Слободского района Кировской области" },
                    { 924, "Киров, улица Правды, 5А", false, "Happy Kids" },
                    { 925, "Киров, Стахановская улица, 25", false, "Страна детей" },
                    { 926, "Кировская область, Вятские Поляны, улица Дружбы, 11", false, "МКДОУ детский сад общеразвивающего вида № 7 Сокол" },
                    { 927, "Киров, улица Грибоедова, 55", false, "Детский сад № 52" },
                    { 928, "Киров, Первомайский район, Советская улица, 94", false, "Солнышко" },
                    { 929, "Киров, Солнечная улица, 16", false, "Ясельки" },
                    { 930, "Киров, Верхосунская улица, 16", false, "Мир движения" },
                    { 931, "Киров, Московская улица, 203", false, "Крошка" },
                    { 932, "Кирово-Чепецк, улица Алексея Некрасова, 33, корп. 2", false, "Детский сад № 19 г. Кирово-Чепецка" },
                    { 933, "Кировская область, Вятские Поляны, улица Ленина, 331", false, "МКДОУ детский сад № 3 Колосок" },
                    { 934, "Киров, улица Карла Маркса, 134А", false, "Частный детский сад Лисёнок" },
                    { 935, "Киров, улица Ивана Попова, 30Б", false, "Солнечный город" },
                    { 936, "Кировская область, посёлок городского типа Афанасьево, улица Соболева, 64", false, "МКДОУ детский сад № 1 пгт. Афанасьево" },
                    { 937, "Киров, Мостовицкая улица, 10", false, "Бакалибрики" },
                    { 910, "Кировская область, Вятские Поляны, улица Азина, 58А", false, "МКДУ детский сад № 6 Рябинка" },
                    { 938, "Кировская область, Верхнекамский муниципальный округ, деревня Кочкино, Новая улица, 14", false, "МДОУ Рябинка" },
                    { 909, "Кировская область, Малмыж, Зелёная улица, 10", false, "Детский сад Колосок" },
                    { 907, "Киров, проспект Строителей, 46к1", false, "МКДОУ детский сад № 194" },
                    { 880, "Кировская область, посёлок городского типа Санчурск, улица Пушкина, 16", false, "МКДОУ детский сад № 3 пгт. Санчурск" },
                    { 881, "Киров, улица Горбачёва, 48Б", false, "МКДОУ детский сад № 90 г. Кирова" },
                    { 882, "Кировская область, Уржумский район, село Лазарево, улица Рабочая, 4", false, "МКДОУ детский сад общеразвивающего вида Родничок с. Лазарево" },
                    { 883, "Кировская область, Вятские Поляны, улица Мира, 59", false, "МКДОУ центр развития ребенка-детский сад № 5 Чебурашка г. Вятские Поляны" },
                    { 884, "Киров, Производственная улица, 18к1", false, "МКДОУ детский сад № 200 г. Кирова" },
                    { 885, "Киров, улица Воровского, 50Б", false, "МКДОУ детский сад № 120 г. Кирова" },
                    { 886, "Киров, улица Карла Маркса, 124А", false, "МКДОУ детский сад № 57 Святки" },
                    { 887, "Кировская область, Вятскополянский район, посёлок городского типа Красная Поляна, улица Калинина, 13", false, "МКДОУ детский сад Калинка пгт. Красная Поляна, корпус № 2" },
                    { 888, "Кировская область, посёлок городского типа Подосиновец, Боровая улица, 1", false, "Детский сад общеразвивающего вида с приоритетным осуществлением деятельности по художественно-эстетическому развитию детей Подснежник" },
                    { 889, "Киров, Ленинский район, Комсомольская улица, 63", false, "Бэбикум" },
                    { 890, "Киров, Первомайский район, улица Розы Люксембург, 56", false, "Мир движения" },
                    { 891, "Киров, Коммунистическая улица, 30", false, "Сказка" },
                    { 892, "Кировская область, Слободской район, посёлок городского типа Вахруши", false, "Детский сад № 5" },
                    { 893, "Кировская область, Вятские Поляны, Первомайская улица, 51", false, "МКДОУ детский сад № 4 Аленький цветочек" },
                    { 894, "Киров, улица Ивана Попова, 18Б", false, "МКДОУ детский сад № 147 города Кирова" },
                    { 895, "Кировская область, Вятские Поляны, улица Мира, 39А", false, "Детский сад № 11 Теремок" },
                    { 896, "Киров, улица Герцена, 17", false, "Family" },
                    { 897, "Кировская область, Малмыж, улица Строителей, 10", false, "Муниципальное казенное дошкольное образовательное учреждение детский сад № 5 Золотой ключик города Малмыжа Кировской области" },
                    { 898, "городской округ Город Киров, поселок Ганино, Центральная улица, 15К1", false, "Непоседы" },
                    { 899, "Киров, Ленинский район, улица Калинина, 40", false, "Карамелька" },
                    { 900, "Киров, Первомайский район, Советская улица, 67А", false, "Кораблик детства" },
                    { 901, "Киров, улица Циолковского, 3А", false, "МКДОУ детский сад № 211 г. Кирова" },
                    { 902, "городской округ Город Киров, поселок Сидоровка, улица Космонавтов, 13", false, "Детский сад" },
                    { 903, "Кировская область, Вятские Поляны, улица Дзержинского, 74А", false, "Детский сад общеразвивающего вида с приоритетным осуществлением деятельности по одному из направлений развития воспитанников № 8 Паровозик г. Вятские Поляны Кировская область МКДОУ" },
                    { 904, "Киров, улица Дерендяева, 74", false, "МКДОУ детский сад № 160 г. Кирова" },
                    { 905, "Киров, улица Чапаева, 18А", false, "МКДОУ детский сад № 7 г. Кирова" },
                    { 906, "Киров, улица Ленина, 152", false, "Ладошки" },
                    { 908, "Киров, улица Воровского, 11, корп. 1", false, "Фиксики43 - частный детский сад" },
                    { 939, "Киров, улица Маклина, 36", false, "НикоСад" },
                    { 940, "Киров, Солнечная улица, 55", false, "Bambini" },
                    { 941, "Кировская область, Луза, улица Энгельса, 44А", false, "МКДОУ детский сад № 12 г. Луза" },
                    { 974, "Кирово-Чепецк, Почтовая улица, 14Б", false, "Негосударственная автономная некоммерческая дошкольная образовательная организация детский сад Улыбка" },
                    { 975, "Кировская область, Слободской район, деревня Беляевская, коттеджный посёлок Посёлок Программистов", false, "Детский сад Комбинированного Вида № 4 Посёлка Городского Типа Вахруши Слободского района Кировской области" },
                    { 976, "Киров, улица Ленина, 198к2", false, "Успех" },
                    { 977, "Киров, Первомайский район, улица Урицкого, 48, корп. 1", false, "Мир движения" },
                    { 978, "Киров, улица Кольцова, 13", false, "Росток" },
                    { 979, "Киров, улица Физкультурников, 14", false, "Монтессори Family" },
                    { 980, "Кировская область, Даровской район, село Красное, улица Труда, 40", false, "Красносельский детский сад" },
                    { 981, "Киров, Красноармейская улица, 65", false, "Почемучки" },
                    { 982, "Киров, Казанская улица, 9", false, "Добрый жук" },
                    { 983, "Киров, улица Красина, 55", false, "Медвежонок" },
                    { 984, "Удмуртская Республика, посёлок Балезино, улица Кирова, 38", false, "Детский сад" },
                    { 985, "Киров, Октябрьский район, улица Свердлова, 25А", false, "Дочки-сыночки" },
                    { 986, "Киров, улица Мира, 39", false, "Baby club" },
                    { 987, "Киров, улица Капитана Дорофеева, 5", false, "Катигорошек" },
                    { 988, "Киров, Первомайский район, Советская улица, 66", false, "Мисоль" },
                    { 989, "Кировская область, посёлок городского типа Кумёны, Садовая улица, 5А", false, "Дом детского творчества пгт Кумены Куменского района Кировской области" },
                    { 990, "Киров, Ленинский район, Агрономическая улица, 9", false, "Здоровые Дети" },
                    { 991, "Киров, улица Воровского, 21А", false, "Аистёнок" },
                    { 992, "Республика Марий Эл, посёлок городского типа Медведево, улица Кирова, 9", false, "Медведевский детский сад № 7 Семицветик" },
                    { 993, "Кировская область, Слободской район, село Совье, улица Труда, 8", false, "МКОУ Средняя общеобразовательная школа с. Совье" },
                    { 994, "Киров, улица Чернышевского, 7", false, "РостОК" },
                    { 995, "Киров, улица Горького, 63, корп. 1", false, "Диснейка" },
                    { 996, "Киров, Краснополянская улица, 9", false, "Анютины глазки" },
                    { 997, "Киров, Ленинский район, улица Карла Либкнехта, 13", false, "Солнышко" },
                    { 998, "Киров, улица Сурикова, 14к1", false, "Сами С Усами" },
                    { 999, "Киров, улица Красина, 7", false, "Домик С" },
                    { 1000, "Киров, улица Сурикова, 37", false, "Совенок" },
                    { 973, "Нижегородская область, Тоншаевский муниципальный округ, рабочий посёлок Пижма, улица Кирова, 12", false, "МДОУ детский сад № 15 Ромашка" },
                    { 972, "Киров, улица Сурикова, 14", false, "Детский центр Солнечный зайчик" },
                    { 971, "Киров, проспект Строителей, 52", false, "Ладошки" },
                    { 970, "Кировская область, Лузский муниципальный округ, посёлок Северные Полянки, Советская улица, 10", false, "МДОКУ детский сад № 3 п. Северные Полянки" },
                    { 942, "Киров, улица Воровского, 131", false, "МКДОУ детский сад № 153 г. Кирова" },
                    { 943, "Киров, улица Ивана Попова, 30А", false, "Каляка-Маляка" },
                    { 944, "Киров, Краснополянская улица, 4", false, "Лялечка" },
                    { 945, "Киров, улица Кольцова, 13Б", false, "Ладошки" },
                    { 946, "Кировская область, Кирово-Чепецкий район, поселок Быстрицкий тубсанаторий", false, "Быстрицкий филиал МКДОУ детский сад Колосок с. Пасегово" },
                    { 947, "Киров, улица Ленина, 184к4", false, "Умнички" },
                    { 948, "Кирово-Чепецк, Сосновая улица, 4А", false, "МБДОУ детский сад № 14 г. Кирово-Чепецка" },
                    { 949, "Киров, Московская улица, 107к1", false, "Аленький Цветочек" },
                    { 950, "Кировская область, Слободской район, деревня Беляевская, коттеджный посёлок Посёлок Программистов", false, "Детский сад Общеразвивающего Вида № 7 Посёлка Городского Типа Вахруши Слободского района Кировской области" },
                    { 951, "Киров, Ярославская улица, 32", false, "Росток" },
                    { 952, "Киров, Октябрьский район, Преображенская улица, 29/2", false, "Ясельки" },
                    { 953, "Кировская область, Слободской район, деревня Беляевская, коттеджный посёлок Посёлок Программистов", false, "Центр Развития Ребенка - детский сад № 5 Посёлка Городского Типа Вахруши Слободского района Кировской области" },
                    { 954, "Киров, улица Андрея Упита, 16", false, "Детки-конфетки" },
                    { 879, "Кирово-Чепецк, Сосновая улица, 5А", false, "МБДОУ детский сад № 7 г. Кирово-Чепецка Кировской области" },
                    { 955, "Киров, улица Крупской, 5, корп. 1", false, "Ладошки" },
                    { 957, "Киров, Первомайский район, улица Розы Люксембург, 18", false, "Мы Растём" },
                    { 958, "Киров, Чистопрудненская улица, 2А", false, "Алиса" },
                    { 959, "Кирово-Чепецк, Вятская набережная, 7А", false, "МБДОУ детский сад № 13 города Кирово-Чепецка" },
                    { 960, "Киров, Красноармейская улица, 4", false, "МАМАнтенок" },
                    { 961, "Киров, улица Ленина, 191, корп. 2", false, "Династия" },
                    { 962, "Киров, улица Архитектора Валерия Зянкина, 13", false, "РостОК" },
                    { 963, "Киров, улица Герцена, 23", false, "Детское село" },
                    { 964, "Киров, улица Ивана Попова, 60", false, "Львенок" },
                    { 965, "Кирово-Чепецк, улица Калинина, 16А", false, "МБДОУ детский сад № 24 г. Кирово-Чепецка" },
                    { 966, "Кировская область, Юрьянский район, село Монастырское, Тополиная улица, 15", false, "МКДОУ детский сад Колокольчик с. Монастырское" },
                    { 967, "Кировская область, Кумёнский район, Большеперелазское сельское поселение, деревня Парфеновщина, улица Мира, 2", false, "Детский сад Зоренька д. Парфеновщина МКДОУ" },
                    { 968, "Киров, Ленинский район, улица Щорса, 19к2", false, "Мир движения" },
                    { 969, "Киров, улица Чехова, 8", false, "Домик друзей" },
                    { 956, "Киров, проспект Строителей, 19, корп. 1", false, "Росток" },
                    { 878, "Кирово-Чепецкий район, село Каринка, Новая улица, 14", false, "Мкому детский сад Рябинка" },
                    { 877, "Кирово-Чепецк, Юбилейная улица, 3", false, "Надежда" },
                    { 876, "Кировская область, Вятские Поляны, Пароходная улица, 9", false, "МКДОУ детский сад комбинированного вида № 2 Светлячок" },
                    { 786, "Киров, микрорайон Мининский, улица Тургенева, 30", false, "Частный детский сад Baby сад" },
                    { 787, "Киров, Пятницкая улица, 96А", false, "МКДОУ № 130 г. Кирова" },
                    { 788, "Кировская область, Зуевка, улица Куйбышева, 4", false, "МКДОУ детский сад Дюймовочка г. Зуевка" },
                    { 789, "Кировская область, Нолинский район, посёлок Медведок, Затонская улица, 12", false, "Муниципальное казённое дошкольное образовательное учреждение детский сад Тополек п. Медведок Нолинского района Кировской области" },
                    { 790, "Киров, Нововятский район, улица Тренера Пушкарева, 9", false, "МКДОУ детский сад № 220" },
                    { 791, "Киров, улица Чапаева, 57В", false, "МКДОУ детский сад № 63 г. Кирова" },
                    { 792, "Кирово-Чепецк, улица Маяковского, 5", false, "МБДОУ детский сад № 26 г. Кирово-Чепецка" },
                    { 793, "Кировская область, Белая Холуница, улица Энгельса, 8", false, "МКДОУ детский сад комбинированного вида № 6 Теремок г. Белая Холуница" },
                    { 794, "Кировская область, Кумёнский район, село Вожгалы, Краснооктябрьская улица, 8А", false, "Детский сад Тополек" },
                    { 502, "Кировская область, Советский район, деревня Родыгино, Юбилейный переулок, 6", false, "МКДОУ детский сад Гномик" },
                    { 796, "Кировская область, Луза, улица Маяковского, 26А", false, "МКДОУ детский сад № 11 г. Луза" },
                    { 797, "Кировская область, Котельнич, Прудная улица, 47А", false, "Апельсин" },
                    { 798, "Кирово-Чепецк, улица Азина, 9", false, "МБДОУ детский сад № 11 г. Кирово-Чепецка" },
                    { 799, "Киров, улица Циолковского, 3", false, "Детский сад № 97 г. Кирова МКДОУ" },
                    { 800, "Киров, улица Красина, 2Б", false, "Детский сад № 117" },
                    { 801, "Кировская область, Орловский район, деревня Цепели", false, "Детский сад Колосок д. Цепели МКДОУ" },
                    { 802, "Киров, улица Романа Ердякова, 19", false, "МКДОУ детский сад № 109 города Кирова" },
                    { 803, "Киров, улица Ленина, 52Б", false, "Наши Детки" },
                    { 804, "Киров, проспект Строителей, 32", false, "МКДОУ детский сад № 155" },
                    { 805, "Киров, Верхосунская улица, 4", false, "МКДОУ детский сад № 146 города Кирова" },
                    { 806, "Киров, улица Лепсе, 39", false, "МКДОУ детский сад № 148" },
                    { 807, "Киров, улица Воровского, 169", false, "Страна детей" },
                    { 808, "Киров, Октябрьский проезд, 18", false, "Птенчики" },
                    { 809, "Киров, улица Крутикова, 3А", false, "МКДОУ детский сад № 74 г. Кирова" },
                    { 810, "Киров, улица Пугачёва, 24Б", false, "Детский сад № 198 г. Кирова" },
                    { 811, "Кировская область, Шабалинский район, посёлок городского типа Ленинское, улица Гусарова, 6А", false, "Шмдоку детский сад Солнышко пгт. Ленинское" },
                    { 812, "Киров, Первомайский район, улица МОПРа, 54А", false, "МКДОУ детский сад № 96 Пингвинчик" },
                    { 785, "Киров, улица 60 лет Комсомола, 21к1", false, "МКДОУ детский сад № 195 г. Кирова" },
                    { 784, "Кировская область, Нагорский район, поселок городского типа Нагорск, Садовая улица, 1", false, "МКДОУ детский сад № 2 пгт. Нагорск" },
                    { 783, "Киров, Первомайский район, Советская улица, 31", false, "МКДОУ детский сад № 202 города Кирова" },
                    { 782, "Киров, микрорайон Юго-Западный, улица Космонавта Владислава Волкова, 1, корп. 1", false, "МКДОУ детский сад № 184 г. Кирова" },
                    { 754, "Кировская область, Шабалинский район, посёлок городского типа Ленинское, улица Калинина, 4", false, "Шмдоку детский сад № 1 пгт. Ленинское" },
                    { 755, "Киров, улица Жуковского, 6", false, "BebY&БУМ" },
                    { 756, "Киров, Нововятский район, улица Кирова, 53", false, "Корпус № 1" },
                    { 757, "Киров, микрорайон Коминтерновский, улица Баумана, 1", false, "МКДОУ детский сад № 68 г. Кирова" },
                    { 758, "Кировская область, Верхнекамский муниципальный округ, посёлок Созимский, Набережная улица, 15", false, "МКДОУ детский сад Чайка п. Созимский" },
                    { 759, "Кировская область, Тужинский район, посёлок городского типа Тужа, Советская улица, 6", false, "МКДОУ детский сад Сказка пгт. Тужа" },
                    { 760, "Киров, Первомайский район, Милицейская улица, 61А", false, "Детский сад № 76" },
                    { 761, "Киров, Первомайский район, улица Урицкого, 24", false, "Шалуны" },
                    { 762, "Киров, улица Капитана Дорофеева, 26", false, "Катигорошек" },
                    { 763, "Кировская область, Даровской район, село Красное, Школьная улица, 22", false, "Детский сад с. Красное" },
                    { 764, "Кировская область, Кумёнский район, посёлок Вичевщина, Октябрьская улица, 20", false, "МКДОУ детский сад Звоночек п. Вичёвщина" },
                    { 765, "Киров, улица Чернышевского, 6А", false, "МКДОУ детский сад № 127 г. Кирова" },
                    { 766, "Киров, улица Лепсе, 59А", false, "МКДОУ детский сад № 152" },
                    { 813, "Киров, улица Ленина, 164, корп. 5", false, "Family" },
                    { 767, "Кировская область, Зуевка, Восточная улица, 18", false, "МКДОУ Колокольчик г. Зуевка" },
                    { 769, "Киров, улица Опарина, 31", false, "МКДОУ детский сад № 222 города Кирова" },
                    { 770, "Киров, улица Циолковского, 11А", false, "МКДОУ детский сад № 149" },
                    { 771, "Киров, микрорайон Лянгасово, улица Горького, 16А", false, "МКДОУ детский сад № 180 г. Кирова" },
                    { 772, "Киров, улица Героя Ивана Костина, 3А", false, "МКДОУ детский сад № 1 г. Кирова" },
                    { 773, "Киров, микрайон Вересники, Лесозаводская улица, 18А", false, "МКДОУ детский сад № 19" },
                    { 774, "Кировская область, Белая Холуница, Юбилейная улица, 5", false, "Ромашка" },
                    { 775, "Киров, Первомайский район, Пролетарская улица, 48А", false, "Детский сад № 110" },
                    { 776, "Киров, улица Романа Ердякова, 15А", false, "МКДОУ № 206" },
                    { 777, "Киров, улица Ивана Попова, 18А", false, "МКДОУ детский сад № 102 города Кирова" },
                    { 778, "Кировская область, Кумёнский район, поселок Олимпийский, улица Садовая, 3", false, "Теремок" },
                    { 779, "Киров, Первомайский район, улица МОПРа, 118", false, "МКДОУ детский сад № 100 города Кирова" },
                    { 780, "Киров, Московская улица, 132Б", false, "МКДОУ детский сад № 48 г. Кирова" },
                    { 781, "Киров, Первомайский район, Милицейская улица, 22", false, "МКДОУ детский сад № 67 г. Кирова" },
                    { 768, "Киров, улица Большева, 1", false, "МКДОУ детский сад № 35" },
                    { 752, "Кировская область, Нолинский район, посёлок городского типа Аркуль, Коммунальная улица, 21", false, "МКДОУ детский сад Ромашка пгт. Аркуль" },
                    { 814, "Киров, Московская улица, 189к1", false, "МКДОУ детский сад № 209 г Кирова" },
                    { 816, "Киров, Октябрьский проспект, 8А", false, "МКДОУ детский сад № 42 г. Кирова" },
                    { 849, "Кировская область, Белая Холуница, Западная улица, 12", false, "Рябинка" },
                    { 850, "Кировская область, посёлок городского типа Подосиновец, Тракторная улица, 6", false, "МКДОУ детский сад общеразвивающего вида с приоритетным осуществлением деятельности по социально-личностному направлению развития детей Светлячок пгт. Подосиновец Кировской области" },
                    { 851, "Киров, Первомайский район, улица Володарского, 115", false, "Детское Село" },
                    { 852, "Киров, улица Тимирязева, 6", false, "МКДОУ детский сад № 162" },
                    { 853, "Киров, проспект Строителей, 54, корп. 1", false, "Детский сад Кировского педагогического колледжа" },
                    { 854, "Киров, улица Екатерины Кочкиной, 6, корп. 1", false, "Монтессори" },
                    { 855, "Кирово-Чепецк, улица Ленина, 6к4", false, "Детский сад № 20 Города Кирово-Чепецка Кировской области" },
                    { 856, "Кирово-Чепецкий район, село Филиппово, улица Михаила Злобина, 7", false, "Детский сад Филиппок" },
                    { 857, "Киров, улица Маклина, 24А", false, "МКДОУ детский сад № 122 г. Кирова" },
                    { 858, "Кировская область, посёлок городского типа Опарино, Советский переулок, 3", false, "МКДОУ детский сад № 2 Теремок посёлок городского типа Опарино" },
                    { 859, "Киров, Подгорная улица, 1", false, "МКДОУ детский сад № 159" },
                    { 860, "Киров, улица Сутырина, 9", false, "Ромашка" },
                    { 861, "Киров, Нововятский район, улица Энгельса, 4А", false, "Корпус № 2" },
                    { 862, "Кирово-Чепецк, улица Горького, 12А", false, "МБДОУ детский сад № 18 г. Кирово-Чепецка" },
                    { 863, "Кировская область, Слободской, улица Свободы, 5", false, "Алёнушка" },
                    { 864, "Кировская область, Малмыж, Лесная улица, 7А", false, "Светлячок" },
                    { 865, "Киров, микрорайон Коминтерновский, Заречная улица, 11", false, "МКДОУ детский сад № 103 г. Кирова" },
                    { 866, "Кирово-Чепецк, проезд Дзержинского, 2А", false, "МБДОУ детский сад № 10 Города Кирово-Чепецка Кировской области" },
                    { 867, "Кирово-Чепецк, переулок Родыгина, 6", false, "МБДОУ детский сад № 9 г. Кирово-Чепецка" },
                    { 868, "Кировская область, Вятские Поляны, микрорайон Центральный, 3А", false, "МКДОУ детский сад компенсирующего вида № 1 Ручеек города Вятские Поляны Кировской области" },
                    { 869, "Кировская область, Яранский район, местечко Знаменка, улица Кирова, 22", false, "МКДОУ детский сад Звездочка м. Знаменка" },
                    { 870, "Кировская область, Омутнинск, Комсомольская улица, 26А", false, "МКДОУ детский сад № 16 Малыш города Омутнинск" },
                    { 871, "Киров, Октябрьский проспект, 6А", false, "МКДОУ детский сад № 83 города Кирова" },
                    { 872, "Кирово-Чепецк, Красноармейская улица, 9А", false, "МБДОУ детский сад № 2 г. Кирово-Чепецка" },
                    { 873, "Кирово-Чепецк, улица Сергея Ожегова, 3", false, "МБДОУ детский сад № 10 г. Кирово-Чепецка" },
                    { 874, "Кирово-Чепецк, улица Алексея Некрасова, 23А", false, "МБДОУ детский сад № 17 г. Кирово-Чепецка" },
                    { 875, "Киров, улица Пугачёва, 19", false, "МКДОУ детский сад № 41 г. Кирова" },
                    { 848, "Киров, микрорайон Юго-Западный, улица Космонавта Владислава Волкова, 10к2", false, "МКДОУ детский сад № 205 г. Кирова" },
                    { 847, "Киров, улица Маклина, 40А", false, "Детский сад № 201 г. Кирова" },
                    { 846, "Кировская область, Вятские Поляны, улица Ленина, 162", false, "МКДОУ детский сад общеразвивающего вида с приоритетным осуществлением деятельности по одному из направлений развития воспитанников № 10 Сказка" },
                    { 845, "Киров, микрорайон Коминтерновский, улица Павла Корчагина, 217А", false, "МКДОУ детский сад № 166 Алёнушка" },
                    { 817, "Кирово-Чепецк, улица Ленина, 68к3", false, "МБОУ детский сад № 6 г. Кирово-Чепецка" },
                    { 818, "Киров, улица Менделеева, 31", false, "МКДОУ детский сад № 150 Антошка" },
                    { 819, "Киров, Казанская улица, 107", false, "Леопольд" },
                    { 820, "Кировская область, Оричевский район, посёлок городского типа Стрижи, Силикатная улица, 6", false, "МДОКУ центр развития ребенка-детский сад Солнышко пгт. Стрижи" },
                    { 821, "Кировская область, Вятскополянский район, посёлок городского типа Красная Поляна, Радужная улица, 3", false, "МКДОУ детский сад Калинка" },
                    { 822, "городской округ Киров, посёлок Садаковский, Зелёная улица, 11", false, "МКДОУ № 182" },
                    { 823, "Кировская область, Верхнекамский район, село Лойно, улица Большевиков, 18", false, "МКДОУ Алёнка" },
                    { 824, "Кировская область, Нолинск, улица Фрунзе, 12А", false, "Василек" },
                    { 825, "Кирово-Чепецк, улица Володарского, 4", false, "МБДОУ детский сад № 1 города Кирово-Чепецка" },
                    { 826, "Кировская область, Вятскополянский район, Сосновка, улица Пушкина, 2А", false, "МКДОУ детский сад Улыбка г. Сосновка" },
                    { 827, "Кирово-Чепецк, улица Рудницкого, 41", false, "МБДОУ детский сад № 4 г. Кирово-Чепецка" },
                    { 828, "Киров, улица Свободы, 107", false, "МКДОУ детский сад № 18 г. Кирова" },
                    { 829, "Киров, Первомайский район, Пролетарский переулок, 4", false, "МКДОУ детский сад № 204 г. Кирова" },
                    { 815, "Кирово-Чепецк, Сосновая улица, 5Б", false, "МБДОУ детский сад № 7 г. Кирово-Чепецка Кировской области" },
                    { 830, "Киров, Первомайский район, Советская улица, 73", false, "Катигорошек" },
                    { 832, "Киров, улица Сурикова, 17", false, "Детское Село" },
                    { 833, "Кировская область, Белохолуницкий район", false, "Детский сад" },
                    { 834, "Кирово-Чепецк, улица Революции, 10к2", false, "МБДОУ детский сад № 15 города Кирово-Чепецка" },
                    { 835, "Киров, улица Ленина, 145", false, "Росток" },
                    { 836, "Киров, улица Добролюбова, 2", false, "МКДОУ детский сад № 138" },
                    { 837, "Кирово-Чепецкий муниципальный район, деревня Шутовщина, Октябрьская улица, 5", false, "Детский сад Колокольчик" },
                    { 838, "Киров, улица Воровского, 92", false, "Хэппи Кидс Воровского 92" },
                    { 839, "Киров, улица Монтажников, 28А", false, "МКДОУ детский сад № 170" },
                    { 840, "Киров, проспект Строителей, 46к2", false, "МКДОУ детский сад № 193" },
                    { 841, "Киров, улица Свободы, 47Б", false, "МКДОУ детский сад № 145 города Кирова" },
                    { 842, "Кировская область, Кумёнский район, деревня Чекоты", false, "Детский сад Колокольчик" },
                    { 843, "городской округ Город Киров, посёлок Захарищевы, Эстрадная улица, 9", false, "Детский сад п. Захарищевы МАДОУ, Структурное подразделение МКДОУ детский сад общеразвивающего вида № 175 г. Кирова" },
                    { 844, "Киров, Пятницкая улица, 40", false, "Частный детский сад Baby сад" },
                    { 831, "Киров, улица Труда, 23", false, "КЭПЛёнОК" },
                    { 501, "Кировская область, Юрьянский район, посёлок Гирсово, Заводская улица, 5", false, "МКДОУ детский сад Родничок п. Гирсово" },
                    { 460, "Удмуртская Республика, Якшур-Бодьинский район, село Старые Зятцы, Октябрьская улица, 10", true, "Старозятцинская Средняя Общеобразовательная школа" },
                    { 499, "Удмуртская Республика, Завьяловский район, деревня Лудорвай, Школьная улица, 10", true, "МБОУ Лудорвайская СОШ имени Героя Советского Союза А. М. Лушникова" },
                    { 158, "Киров, улица Андрея Упита, 9", true, "МБОУ СОШ с углубленным изучением отдельных предметов № 47 города Кирова" },
                    { 159, "Киров, микрорайон Красный Химик, улица Красный Химик, 2, корп. 3", true, "Средняя общеобразовательная школа № 34 г. Кирова МБОУ" },
                    { 160, "Кировская область, посёлок городского типа Фалёнки, Первомайская улица, 23", true, "МКОУ Вш пгт Фаленки Фаленского района Кировской области" },
                    { 161, "Кировская область, Нолинский район, село Татаурово, Садовая улица, 1А", true, "МКОУ ООШ с. Татаурово" },
                    { 162, "Кировская область, Уржумский район, село Лазарево, Октябрьская улица, 7", true, "МКОУ Средняя общеобразовательная школа с. Лазарево" },
                    { 163, "Кировская область, посёлок городского типа Свеча, улица Тотмянина, 10", true, "КОГОБУ Средняя школа пгт Свеча" },
                    { 164, "Кировская область, Белохолуницкий район, деревня Быданово, Советская улица, 18", true, "Средняя общеобразовательная школа д. Быданово МКОУ" },
                    { 165, "Киров, улица Воровского, 74", true, "МБОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 51 города Кирова, корпус № 2" },
                    { 166, "Кировская область, Нолинский район, село Швариха, улица Труда, 32", true, "МКОУ Основная общеобразовательная школа с. Швариха" },
                    { 167, "Кировская область, Юрьянский район, село Медяны, улица Энергетиков, 2Б", true, "Основная общеобразовательная школа с. Медяны с дошкольным отделением" },
                    { 168, "Кировская область, Слободской район, деревня Салтыки, Полевая улица, 17", true, "Основная общеобразовательная школа деревни Салтыки" },
                    { 169, "Кировская область, Слободской район, деревня Светозарево, Глазовская улица, 17", true, "МКОУ СОШ д. Светозарево" },
                    { 170, "Кировская область, Луза, улица Победы, 10", true, "МОКУ СОШ № 2 г. Лузы Кировской области" },
                    { 171, "Киров, микрорайон Юго-Западный, улица Космонавта Владислава Волкова, 6", true, "Средняя общеобразовательная школа № 27 с углубленным изучением отдельных предметов" },
                    { 172, "Кировская область, Котельничский район, деревня Родичи, улица Труда, 4", true, "МКОУ основная общеобразовательная школа д. Родичи" },
                    { 173, "Кировская область, Кумёнский район, село Быково", true, "Быковская школа" },
                    { 174, "Кировская область, Зуевский район, село Суна, Коммунистическая улица, 10", true, "МКОУ Средняя общеобразовательная школа с. Суна" },
                    { 175, "Кировская область, Верхнекамский муниципальный округ, деревня Кочкино, Новая улица, 18", true, "МКОУ Основная общеобразовательная школа д. Кочкино" },
                    { 176, "Киров, улица Ленина, 158А", true, "МБОУ Средняя общеобразовательная школа № 70 г. Кирова" },
                    { 177, "Кировская область, Кильмезский район, деревня Селино, Советская улица, 12", true, "Основная Общеобразовательная школа Д. Селино Кильмезского района Кировской области" },
                    { 178, "Кировская область, Омутнинский район, посёлок городского типа Восточный, Пионерская улица, 2", true, "МКОУ Средняя общеобразовательная школа № 2 с углубленным изучением отдельных предметов пгт Восточный" },
                    { 179, "Кировская область, Сунский район, посёлок городского типа Суна, Советская улица, 31", true, "МКОУ Основная общеобразовательная школа № 1 пгт. Суна" },
                    { 180, "Киров, улица Мира, 34", true, "МБОУ Средняя общеобразовательная школа № 2" },
                    { 181, "Кировская область, Советск, улица Олега Кошевого, 14", true, "МКОУ СОШ с УИОП № 2 г. Советска" },
                    { 182, "Киров, село Макарье, Школьная улица, 1", true, "Кировский физико-математический лицей" },
                    { 183, "Кировская область, Подосиновский район, посёлок городского типа Пинюг, Школьная улица, 15", true, "МКОУ Средняя общеобразовательная школа поселка городского типа Пинюг" },
                    { 184, "Кировская область, Зуевский район, посёлок Октябрьский, улица Ленина, 11", true, "Средняя общеобразовательная школа п. Октябрьский МКОУ" },
                    { 157, "Кировская область, Омутнинск, Комсомольская улица, 18", true, "Муниципальное казеное общеобразовательное учреждение Средняя общеобразовательная школа № 6 г. Омутнинска Кировской области" },
                    { 185, "Кировская область, Слободской, Школьная улица, 3", true, "Специальная школа-интернат для детей-сирот и детей оставшихся без попечения родителей с отклонениями в развитии" },
                    { 156, "Кировская область, Советский район, село Зашижемье, Молодёжная улица, 21", true, "МКОУ Основная общеобразовательная школа с. Зашижемье" },
                    { 154, "городской округ Киров, деревня Малая Субботиха, Центральная улица, 20", true, "МБОУ Основная общеобразовательная школа № 19 г. Кирова" },
                    { 127, "Кирово-Чепецкий район, село Полом, улица Петра Родыгина, 11", true, "МКОУ Основная общеобразовательная школа с. Полом" },
                    { 128, "Кировская область, Фалёнский муниципальный округ, село Николаево, Юбилейная улица, 18", true, "Основная общеобразовательная школа с. Николаево МКОУ" },
                    { 129, "Киров, Ленинский район, улица Калинина, 53", true, "МБОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 51 города Кирова" },
                    { 130, "Кировская область, Богородский городской округ, село Ошлань, Новая улица, 10", true, "Средняя общеобразовательная школа с. Ошлань МКОУ" },
                    { 131, "Кирово-Чепецкий район, посёлок Перекоп", true, "Кирово-Чепецкая санаторная школа-интернат" },
                    { 132, "Кировская область, посёлок городского типа Санчурск, улица Ленина, 46", true, "МКОУ СОШ с УИОП пгт. Санчурск" },
                    { 133, "Киров, улица Опарина, 14", true, "МБОУ СОШ с углубленным изучением отдельных предметов № 66 г. Кирова" },
                    { 134, "Киров, Нововятский район, улица Ленина, 14", true, "Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 61" },
                    { 135, "Кировская область, Котельничский район, село Боровка, улица Кирова, 11", true, "Основная Общеобразовательная школа с. Боровка Котельничского района Кировской области" },
                    { 136, "Киров, Октябрьский проспект, 129", true, "Средняя общеобразовательная школа № 37 с углубленным изучением отдельных предметов" },
                    { 137, "Кировская область, Уржум, улица Чернышевского, 19", true, "Средняя Общеобразовательная школа № 3" },
                    { 138, "Кировская область, Яранск, улица Гоголя, 25", true, "КОГОБУ СШ с УИОП" },
                    { 139, "Киров, Современная улица, 6", true, "МБОУ Средняя общеобразовательная школа № 11 г. Кирова" },
                    { 140, "Кировская область, Котельнич, Советская улица, 153", true, "МБОУ Средняя школа № 3 г. Котельнича" },
                    { 141, "Кировская область, Белохолуницкий район, Школьная улица, 11", true, "МКОУ ООШ д. Ракалово" },
                    { 142, "Кировская область, Яранский район, местечко Знаменка, улица Кирова, 38", true, "Муниципальное казенное общеобразовательное учреждение Средняя школа м. Знаменка Яранского района Кировской области" },
                    { 143, "Кировская область, Белохолуницкий район, село Троица, Советская улица, 39", true, "МКОУ Средняя общеобразовательная школа с. Троица" },
                    { 144, "Кировская область, Верхнекамский муниципальный округ, посёлок Созимский, Набережная улица, 1", true, "Средняя общеобразовательная школа поселка Созимский Верхнекамского района Кировской области" },
                    { 145, "Кирово-Чепецкий муниципальный район, деревня Чуваши, Советская улица, 4", true, "МКОУ Краснооктябрьская основная общеобразовательная школа д. Чуваши" },
                    { 146, "Кировская область, Малмыж, улица Карла Маркса, 7", true, "МКОУ Средняя общеобразовательная школа № 2" },
                    { 147, "Киров, улица 60 лет Комсомола, 4", true, "МБОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 9" },
                    { 148, "Киров, микрорайон Радужный, Школьный переулок, 4", true, "МБОУ Средняя общеобразовательная школа № 74 с углубленным изучением отдельных предметов" },
                    { 149, "Кировская область, Слободской, проспект Гагарина, 25", true, "Средняя общеобразовательная школа № 14" },
                    { 150, "Кировская область, Слободской район, село Карино, улица Ленина, 32", true, "МКОУ Основная общеобразовательная школа с. Карино" },
                    { 151, "Кировская область, Омутнинский район, посёлок Белореченск, улица Петра Русских, 30", true, "Средняя общеобразовательная школа № 10 пос. Белореченск Омутнинского района Кировской области" },
                    { 152, "Кировская область, Зуевский район, посёлок Кордяга, Школьная улица, 10А", true, "МКОУ Основная общеобразовательная школа п. Кордяга" },
                    { 153, "Кирово-Чепецк, микрорайон Каринторф, Лесная улица, 8А", true, "МКОУ ООШ микрорайон Каринторф" },
                    { 155, "Кировская область, Слободской, Рождественская улица, 77", true, "МКОУ Гимназия г. Слободского" },
                    { 186, "Кировская область, Немский муниципальный округ, село Ильинское, Советская улица, 32А", true, "Основная общеобразовательная школа с. Ильинское, филиал КОГОБУ Средняя школа с. Архангельское Немского района" },
                    { 187, "Киров, улица Энтузиастов, 25", true, "МБОУ СОШ № 26" },
                    { 188, "Кирово-Чепецк, проспект Кирова, 1", true, "МКОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 4 г. Кирово-Чепецка" },
                    { 221, "Кировская область, Пижанский муниципальный округ, поселок Ластик 2-й, Советская улица, 68", true, "Основная общеобразовательная школа д. Второй Ластик МКОУ" },
                    { 222, "Кировская область, Опаринский муниципальный округ, посёлок Маромица, улица Конева, 13", true, "МКОУ Средняя общеобразовательная школа п. Маромица" },
                    { 223, "Кировская область, Слободской, проспект Гагарина, 10", true, "Средняя общеобразовательная школа № 14" },
                    { 224, "Кировская область, Котельничский район, посёлок Комсомольский, Школьная улица, 2", true, "МКОУ ООШ п. Комсомольский Котельничского района Кировской области" },
                    { 225, "Киров, улица 4-й Пятилетки, 40", true, "Железнодорожный образовательный центр г. Кирова" },
                    { 226, "Кировская область, Вятскополянский район, Сосновка, Спортивная улица, 8", true, "Средняя школа-интернат г. Сосновки Вятскополянского района КОГОБУ, для детей-сирот и детей, оставшихся без попечения родителей" },
                    { 227, "Кировская область, Яранский район, село Никулята, улица Труда, 3", true, "Средняя общеобразовательная школа с. Никулята МКОУ" },
                    { 228, "Киров, улица Красина, 49", true, "МБОУ СОШ с УИОП № 32 города Кирова" },
                    { 229, "городской округ Город Киров, поселок Дороничи, улица Мира, 1", true, "Школа № 7" },
                    { 230, "Киров, улица Горького, 37", true, "МБОУ Средняя общеобразовательная школа № 57 города Кирова" },
                    { 231, "Кировская область, Слободской район, село Совье, улица Труда, 8", true, "МКОУ Средняя общеобразовательная школа с. Совье" },
                    { 232, "Кировская область, Советский район, село Колянур, Советская улица, 17", true, "МКОУ ООШ с. Колянур" },
                    { 233, "Кировская область, Малмыжский район, село Тат-Верх-Гоньба", true, "Основная общеобразовательная школа с. Тат-Верх-Гоньба Малмыжского района Кировской области" },
                    { 234, "Кировская область, Яранск, улица Кирова, 18", true, "МКОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 2 им. А. Жаркова г. Яранска" },
                    { 235, "Кировская область, Луза, улица Калинина, 9А", true, "КОГОАУ Средняя школа г. Лузы" },
                    { 236, "Киров, улица Некрасова, 20", true, "Средняя общеобразовательная школа № 31 г. Кирова" },
                    { 237, "Кировская область, посёлок городского типа Даровской, Советская улица, 42", true, "Интернат средней общеобразовательной школы пгт. Даровской" },
                    { 238, "Киров, Октябрьский проспект, 36", true, "МБОУ СОШ с УИОП № 48 города Кирова" },
                    { 239, "Киров, улица Горького, 51А", true, "МБОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 30" },
                    { 240, "Кировская область, Уржум, улица Гоголя, 91", true, "Муниципальное казенное общеобразовательное учреждение Средняя Общеобразовательная школа № 2" },
                    { 241, "Кировская область, Афанасьевский муниципальный округ, село Гордино, улица Мира, 34", true, "МБОУ СОШ села Гордино" },
                    { 242, "Киров, Милицейская улица, 67", true, "Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 58 г. Кирова" },
                    { 243, "Киров, улица Воровского, 153", true, "МБОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 60 г. Кирова" },
                    { 244, "Киров, улица Воровского, 16А", true, "Средняя общеобразовательная школа № 16" },
                    { 245, "Кирово-Чепецкий муниципальный район, село Каринка, Школьная улица, 13", true, "МКОУ СОШ с. Каринка" },
                    { 500, "Удмуртская Республика, Глазов, Сибирская улица, 19", true, "Средняя Общеобразовательная школа № 1" },
                    { 247, "Кировская область, Тужинский район, село Ныр, Советская улица, 10", true, "Средняя общеобразовательная школа с. Ныр МКОУ" },
                    { 220, "Кировская область, Фалёнский муниципальный округ, село Белая, Школьная улица, 2", true, "Основная общеобразовательная школа с. Белая МКОУ" },
                    { 219, "Киров, улица Шинников, 33А", true, "МБОУ Средняя общеобразовательная школа № 53" },
                    { 218, "Кировская область, Советский район, деревня Грехово, Молодёжная улица, 1", true, "Начальная общеобразовательная школа д. Грехово МКОУ" },
                    { 217, "Кировская область, Мурашинский муниципальный округ, деревня Даниловка, Молодёжная улица, 9", true, "МОКУ Нош д. Даниловка" },
                    { 189, "Кировская область, Унинский район, село Елгань, Центральная улица, 7", true, "Средняя общеобразовательная школа с. Елгань МБОУ" },
                    { 190, "Киров, улица Красина, 41", true, "Средняя общеобразовательная школа № 40 города Кирова" },
                    { 191, "Кировская область, Нолинский район, село Кырчаны, Полевая улица, 7", true, "МКОУ Основная общеобразовательная школа с. Кырчаны" },
                    { 192, "Кировская область, Нолинский район, деревня Липино, Заречная улица, 1", true, "МКОУ ООШ с. Зыково Нолинского района Кировской области" },
                    { 193, "Кировская область, Слободской, Железнодорожная улица, 11А", true, "КОГОБУ Лицей № 9 г. Слободского" },
                    { 194, "Кировская область, Кирово-Чепецкий район, село Бурмакино, улица Вихарева, 67", true, "КОГОБУ школа-интернат для детей сирот с ограниченными возможностями с. Бурмакино" },
                    { 195, "Киров, улица Ленина, 105", true, "Вечерняя школа города Кирова" },
                    { 196, "Кировская область, Афанасьевский район, поселок Бор, Школьная улица, 8", true, "Муниципальное бюджетное общеобразовательное учреждение средняя общеобразовательная школа п. Бор Афанасьевского района Кировской области" },
                    { 197, "Кировская область, Свечинский муниципальный округ, село Юма, улица Коммуны, 18", true, "КОГОБУ ОШ с. Юма" },
                    { 198, "Кировская область, Уржумский район, поселок Пиляндыш, Советская улица, 14", true, "МКОУ Средняя общеобразовательная школа п. Пиляндыш" },
                    { 199, "Кировская область, Немский муниципальный округ, деревня Городище, Центральный переулок, 2", true, "Основная общеобразовательная школа д. Городище, филиал КОГОБУ Средняя школа с. Архангельское Немского района" },
                    { 200, "Кировская область, Шабалинский район, поселок Высокораменское, улица Ленина, 3", true, "Средняя общеобразовательная школа с. Высокораменское Шмоку" },
                    { 201, "Кировская область, Нолинский район, посёлок городского типа Аркуль, Заводская улица, 15", true, "Средняя Общеобразовательная школа п Аркуль Нолинского района Кировской области" },
                    { 126, "Кировская область, Омутнинск, Комсомольская улица, 38", true, "КОГОБУ СШ с УИОП г. Омутнинска" },
                    { 202, "Кировская область, Подосиновский район, посёлок городского типа Демьяново, Школьная улица, 5", true, "КОГОБУ СШ пгт Демьяново Подосиновского района" },
                    { 204, "Кировская область, Советск, Октябрьская улица, 6", true, "КОГОБУ школа-интернат для обучающихся с ограниченными возможностями здоровья города Советска" },
                    { 205, "Кировская область, Вятскополянский район, деревня Дым-Дым-Омга, Советская улица, 16", true, "Основная Общеобразовательная школа дер. Дым-дым Омга Вятскополянского района Кировской области" },
                    { 206, "Киров, улица Ломоносова, 29Б", true, "Муниципальное бюджетное общеобразовательное учреждение Гимназия № 46 города Кирова" },
                    { 207, "Кировская область, Яранск, улица Некрасова, 59", true, "МКОУ Средняя школа с углубленным изучением отдельных предметов № 3 г. Яранска" },
                    { 208, "Кировская область, Малмыжский район, село Калинино, Пролетарская улица, 111", true, "МКОУ СОШ имени генерал-лейтенант В. Г. Асапова с. Калинино" },
                    { 209, "Киров, Нововятский район, Советская улица, 170", true, "МБОУ СОШ с УИОП № 65 г. Кирова" },
                    { 210, "Кировская область, Фалёнский муниципальный округ, деревня Малахи, Баранниковская улица, 21", true, "Основная Общеобразовательная школа Д. Малахи Фалёнского района Кировской области" },
                    { 211, "Кировская область, Малмыжский район, село Новая Смаиль, Школьная улица, 2", true, "МКОУ Средняя общеобразовательная школа с. Новая Смаиль Малмыжского района Кировской области" },
                    { 212, "Кировская область, Афанасьевский муниципальный округ, посёлок Лытка, Молодёжный переулок, 1А", true, "МБОУ ООШ п. Лытка" },
                    { 213, "Киров, улица Воровского, 74А", true, "КОГОБУ школа для обучающихся с ограниченными возможностями здоровья № 50 г. Кирова" },
                    { 214, "Кировская область, посёлок городского типа Кумёны, улица Гагарина, 7", true, "КОГОБУ ШИОВЗ пгт. Кумены" },
                    { 215, "Кирово-Чепецкий муниципальный район, железнодорожная станция Просница, улица Большевиков, 8А", true, "Начальная общеобразовательная школа Ж. Д. СТ. Просница Кирово-Чепецкого района Кировской области" },
                    { 216, "Киров, Первомайский район, улица Розы Люксембург, 40", true, "Специальная общеобразовательная школа VIII вида № 13 г. Кирова" },
                    { 203, "Кировская область, Уржумский район, село Русский Турек", true, "МКОУ СОШ с. Русский Турек" },
                    { 125, "Кировская область, Слободской, улица Гоголя, 97", true, "МБОУ Средняя общеобразовательная школа № 5" },
                    { 124, "Кировская область, Слободской район, село Ильинское, Школьная улица, 2", true, "МКОУ СОШ с. Ильинского" },
                    { 123, "Кировская область, посёлок городского типа Пижанка, Советская улица, 61", true, "КОГОБУ Средняя школа с углубленным изучением отдельных предметов пгт. Пижанка" },
                    { 33, "Кировская область, посёлок городского типа Верхошижемье, Школьная улица, 1", true, "КОГОБУ Средняя школа имени И. С. Березина пгт. Верхошижемье" },
                    { 34, "Кировская область, Нолинский район, деревня Перевоз, Советская улица, 46А", true, "МКОУ Основная общеобразовательная школа д. Перевоз" },
                    { 35, "Кировская область, Опаринский район, посёлок городского типа Опарино, Октябрьская улица, 20", true, "КОГОБУ Средняя школа пгт. Опарино" },
                    { 36, "Кировская область, Зуевка, улица Куйбышева, 3", true, "КОГОБУ Средняя школа с углубленным изучением отдельных предметов г. Зуевка" },
                    { 37, "Кирово-Чепецкий район, село Бурмакино, Школьная улица, 10", true, "Средняя общеобразовательная школа с. Бурмакино Кирово-Чепецкого района Кировской области" },
                    { 38, "Кировская область, Кирс, улица Кирова, 6", true, "КОГОБУ Средняя школа с углубленным изучением отдельных предметов г. Кирс" },
                    { 39, "Кировская область, Мурашинский муниципальный округ, посёлок Октябрьский, Футбольная улица, 2А", true, "Средняя общеобразовательная школа п. Октябрьский Мурашинского района Кировской области" },
                    { 40, "Кировская область, Опаринский муниципальный округ, посёлок Заря, улица Ленина, 23", true, "МКОУ Средняя общеобразовательная школа п. Заря" },
                    { 41, "Кировская область, Унинский район, посёлок городского типа Уни, улица Ленина, 21", true, "КОГОБУ СШ с УИОП пгт. Уни" },
                    { 42, "Кировская область, Мураши, улица Халтурина, 51", true, "Средняя общеобразовательная школа им. С. С. Ракитиной г. Мураши МОКУ" },
                    { 43, "Кировская область, Зуевский район, посёлок Косино, улица Кирова, 21", true, "МКОУ Средняя общеобразовательная школа п. Косино" },
                    { 44, "Киров, Первомайский район, Милицейская улица, 50", true, "Средняя общеобразовательная школа № 20 города Кирова" },
                    { 45, "Кировская область, Белохолуницкий район, село Полом, улица Энгельса, 27", true, "МКОУ Средняя общеобразовательная школа с. Полом" },
                    { 46, "Кировская область, Юрьянский район, деревня Ложкари, Модежная улица, 17", true, "Основная Общеобразовательная школа Д. Ложкари Юрьянского района Кировской области" },
                    { 47, "Кировская область, Омутнинский район, посёлок городского типа Песковка, улица Ленина, 81", true, "МКОУ Средняя общеобразовательная школа № 4 пгт Песковка" },
                    { 48, "Кировская область, Верхнекамский муниципальный округ, посёлок городского типа Рудничный, улица Пушкина, 4", true, "МКОУ Средняя общеобразовательная школа пгт. Рудничный Верхнекамского района Кировской области" },
                    { 49, "Кировская область, Мураши, Пионерская улица, 37", true, "Кировское областное государственное общеобразовательное бюджетное учреждение Средняя школа г. Мураши" },
                    { 50, "Кировская область, посёлок городского типа Кумёны, Поселковая улица, 10", true, "КОГОБУ Средняя школа пгт. Кумёны" },
                    { 51, "Кировская область, Мурашинский муниципальный округ, посёлок Безбожник, Почтовая улица, 38", true, "МОКУ СОШ п. Безбожник" },
                    { 52, "Кировская область, посёлок городского типа Арбаж, улица Свободы, 29", true, "КОГОБУ СШ пгт Арбаж" },
                    { 53, "Кировская область, Котельничский район, Биртяевское сельское поселение, поселок Ленинская Искра, улица Ленина, 6А", true, "МКОУ Спицынская СОШ п. Ленинская Искра" },
                    { 54, "Кировская область, Котельнич, улица Урицкого, 21/79", true, "Средняя школа с углублённым изучением отдельных предметов № 1" },
                    { 55, "Кировская область, Орловский район, деревня Кузнецы, Школьная улица, 10", true, "МКОУ Средняя общеобразовательная школа д. Кузнецы" },
                    { 56, "Кировская область, Зуевский район, поселок Семушино, улица Кирова, 1", true, "МКОУ Средняя общеобразовательная школа п. Семушино" },
                    { 57, "Киров, Октябрьский проспект, 21", true, "МБОУ Средняя общеобразовательная школа № 56 города Кирова" },
                    { 58, "городской округ Киров, село Русское, Новая улица, 16", true, "Основная общеобразовательная школа № 69" },
                    { 59, "Кировская область, посёлок городского типа Кикнур, улица Ленина, 41", true, "КОГОБУ Средняя школа с углубленным изучением отдельных предметов пгт. Кикнур" },
                    { 32, "Кировская область, Юрьянский район, посёлок городского типа Мурыгино, улица Красных Курсантов, 6", true, "КОГОБУ СШ с УИОП пгт Мурыгино Юрьянского района" },
                    { 31, "Кировская область, Зуевский район, посёлок Соколовка, Центральная улица, 16", true, "МКОУ Средняя общеобразовательная школа п. Соколовка" },
                    { 30, "городской округ Киров, село Бахта, Юбилейная улица, 14", true, "МБОУ Основная общеобразовательная школа № 68 г. Кирова" },
                    { 29, "Кировская область, Зуевский район, село Мухино, Советская улица, 14", true, "МКОУ Средняя общеобразовательная школа с. Мухино" },
                    { 1, "Кировская область, Слободской район, деревня Шихово, Центральная улица, 11", true, "Средняя Общеобразовательная школа д. Шихово Слободского района Кировской области" },
                    { 2, "Кировская область, Орловский район, деревня Цепели, Школьная улица, 1", true, "МКОУ ООШ деревни Цепели Орловского района Кировской области" },
                    { 3, "Кировская область, Оричевский район, село Адышево, Советская улица, 11", true, "МОКУ Средняя общеобразовательная школа с. Адышево Оричевского района" },
                    { 4, "Кировская область, Котельничский район, поселок Юбилейный, улица Хитрина, 4", true, "МКОУ СОШ" },
                    { 5, "Кировская область, Слободской район, село Шестаково, Советская улица, 25", true, "МКОУ Средняя общеобразовательная школа с. Шестаково" },
                    { 6, "Кировская область, посёлок городского типа Оричи, улица Карла Маркса, 22", true, "КОГОБУ СШ пгт Оричи" },
                    { 7, "Кировская область, Слободской район, посёлок городского типа Вахруши, улица Ленина, 4", true, "КОГОБУ СШ пгт Вахруши Слободского района" },
                    { 8, "Кировская область, Кумёнский район, Речное сельское поселение, посёлок Речной, улица Ленина, 8", true, "МКОУ Средняя общеобразовательная школа п. Речной" },
                    { 9, "Кировская область, Оричевский район, село Коршик, Советская улица, 11Б", true, "Средняя общеобразовательная школа с. Коршик Оричевского района Кировской области" },
                    { 10, "Кировская область, Оричевский район, посёлок Юбилейный, 30", true, "Лугоболотная средняя школа" },
                    { 11, "Кировская область, Слободской район, посёлок Октябрьский, улица Ленина, 20", true, "Средняя общеобразовательная школа п. Октябрьский Слободского района Кировской области" },
                    { 12, "Кировская область, Слободской район, деревня Стулово, Трактовая улица, 33А", true, "МКОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов" },
                    { 13, "Кировская область, посёлок городского типа Лебяжье, Кооперативная улица, 41", true, "МКОУ Средняя общеобразовательная школа пгт. Лебяжье Кировской области" },
                    { 60, "Кировская область, Фалёнский муниципальный округ, деревня Леваны, Школьная улица, 2А", true, "МКОУ Основная общеобразовательная школа д. Леваны" },
                    { 14, "Кировская область, Советск, улица Карла Либкнехта, 24", true, "МОУ СОШ сУИОП № 1 г. Советска Кировской области" },
                    { 16, "Кировская область, Нагорский район, посёлок городского типа Нагорск, Советская улица, 169", true, "КОГОБУ Средняя школа с углубленным изучением отдельных предметов пгт Нагорск" },
                    { 17, "Кировская область, посёлок городского типа Фалёнки, улица Воробьёва, 13", true, "КОГОБУ Средняя школа с углубленным изучением отдельных предметов пгт Фаленки" },
                    { 18, "Кировская область, Уржумский район, село Шурма, переулок Школьный, 1", true, "МКОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов с. Шурма" },
                    { 19, "Кировская область, Кумёнский район, посёлок городского типа Нижнеивкино, Октябрьский переулок, 7", true, "МКОУ СОШ пгт Нижнеивкино" },
                    { 20, "Кировская область, Белая Холуница, улица Ленина, 2", true, "МКОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов им. В. И. Десяткова г. Белая Холуница" },
                    { 21, "Кировская область, Шабалинский район, посёлок городского типа Ленинское, улица Гусарова, 14", true, "КОГОБУ Средняя школа с углубленным изучением отдельных предметов пгт. Ленинское" },
                    { 22, "Кировская область, Богородский район, поселок городского типа Богородское, улица 1 Мая, 7", true, "КОГОБУ Средняя школа с углубленным изучением отдельных предметов пгт. Богородское" },
                    { 23, "Кировская область, Кумёнский район, поселок Вичевщина, Северихина улица, 33", true, "МКОУ СОШ П. Вичёвщина" },
                    { 24, "Кировская область, посёлок городского типа Первомайский, улица Волкова, 12", true, "МКОУ СОШ Зато Первомайский Кировской обласити" },
                    { 25, "Кировская область, Слободской, Вятская улица, 40", true, "МКОУ Средняя общеобразовательная школа № 7" },
                    { 26, "Кировская область, Кумёнский район, поселок Краснооктябрьский, Краснооктябрьская улица, 7", true, "МКОУ СОШ поселка Краснооктябрьский" },
                    { 27, "Кировская область, Котельнич, Школьная улица, 2", true, "Муниципальное бюджетное общеобразовательное учреждение средняя общеобразовательная школа с углубленным изучением отдельных предметов № 5 города Котельнича Кировской области" },
                    { 28, "Кировская область, Уржумский район, село Петровское, улица Кирова, 113", true, "МКОУ Основная общеобразовательная школа с. Петровского Уржумского района Кировской области" },
                    { 15, "Кировская область, Юрьянский район, село Загарье, улица Гагарина, 22", true, "МКОУ Основная общеобразовательная школа с. Загарье" },
                    { 248, "Кировская область, Омутнинск, улица Свободы, 9", true, "МКОУ Базовая начальная общеобразовательная школа г. Омутнинск" },
                    { 61, "Киров, Первомайский район, улица Розы Люксембург, 57", true, "МОАУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 10 им. К. Э. Циолковского" },
                    { 63, "Кировская область, Слободской район, село Закаринье", true, "Основная общеобразовательная школа с. Закаринье Слободского района Кировской области" },
                    { 96, "Кировская область, Сунский район, село Верхосунье, улица Лопатина, 2", true, "МКОУ Средняя общеобразовательная школа с. Верхосунье Сунского района Кировской области" },
                    { 97, "Кировская область, Нолинск, улица Фрунзе, 51", true, "КОГОБУ Средняя школа с углубленным изучением отдельных предметов г. Нолинска" },
                    { 98, "Кировская область, Орлов, улица Степана Халтурина, 2", true, "Школа № 1 им. Зонова" },
                    { 99, "Кировская область, Белая Холуница, Школьная улица, 3", true, "КОГОБУ СШ с УИОП г. Белой Холуницы" },
                    { 100, "Кировская область, Омутнинск, улица Кооперации, 91", true, "Средняя школа № 2" },
                    { 101, "Кировская область, Слободской район, поселок Центральный", true, "Озерницкая основная общеобразовательная школа п. Центральный МКОУ" },
                    { 102, "Киров, улица Труда, 67А", true, "Средняя общеобразовательная школа № 14" },
                    { 103, "Кировская область, Котельничский район, посёлок Светлый, улица Ленина, 10", true, "МКОУ Отворская основная общеобразовательная школа п. Светлый Котельничского района Кировской области" },
                    { 104, "Кировская область, Пижанский муниципальный округ, деревня Павлово, Школьная улица, 3", true, "МКОУ Основная общеобразовательная школа д. Павлово" },
                    { 105, "Кировская область, Советский район, деревня Воробьева Гора, Школьная улица, 3", true, "МКОУ Основная общеобразовательная школа д. Воробьева Гора" },
                    { 106, "Кировская область, Слободской район, деревня Денисовы, Советская улица, 9А", true, "МКОУ СОШ д. Денисовы" },
                    { 107, "городской округ Город Киров, поселок Ганино, Школьный переулок, 18", true, "МБОУ Средняя общеобразовательная школа № 55 г. Кирова" },
                    { 108, "Кировская область, Немский муниципальный округ, посёлок городского типа Нема, Советская улица, 42", true, "КОГОБУ Средняя школа пгт. Нема" },
                    { 109, "Кировская область, Кумёнский район, поселок Краснооктябрьский", true, "Школа" },
                    { 110, "Кировская область, Унинский район, село Порез, улица Ленина, 24", true, "Средняя общеобразовательная школа с. Порез Унинского района Кировской области им. Г. Ф. Шулятьева МБОУ" },
                    { 111, "Кировская область, Сунский район, село Курчум, Школьная улица, 1", true, "Основная общеобразовательная школа с. Курчум МКОУ" },
                    { 112, "Кировская область, Оричевский район, посёлок городского типа Лёвинцы, улица 70-летия Октября, 121", true, "МОКУ СОШ пгт. Левинцы" },
                    { 113, "Кировская область, Кильмезский район, посёлок городского типа Кильмезь, Больничная улица, 3", true, "КОГОБУ Средняя школа с углубленным изучением отдельных предметов пгт. Кильмезь" },
                    { 114, "городской округ Киров, посёлок Садаковский, Московская улица, 1", true, "Средняя общеобразовательная школа № 4 города Кирова" },
                    { 115, "Кировская область, Юрьянский район, деревня Подгорцы, Кольцевая улица, 3А", true, "МКОУ Основная общеобразовательная школа д. Подгорцы" },
                    { 116, "Кировская область, Оричевский район, посёлок городского типа Стрижи, Комсомольская улица, 12", true, "МОКУ Средняя общеобразовательная школа пгт Стрижи" },
                    { 117, "Кирово-Чепецкий муниципальный район, село Фатеево, Школьная улица, 3", true, "МКОУ Основная общеобразовательная школа с. Фатеево" },
                    { 118, "Кировская область, Омутнинский район, деревня Ежово, улица Мира, 2", true, "Школа" },
                    { 119, "Киров, Октябрьский район, улица Свердлова, 21", true, "МБОУ Средняя общеобразовательная школа № 18 г. Кирова" },
                    { 120, "городской округ Киров, посёлок Костино, Парковая улица, 19", true, "МБОУ Средняя общеобразовательная школа № 5 г. Кирова" },
                    { 121, "Кировская область, Верхнекамский муниципальный округ, село Лойно, улица Ленина, 20", true, "МКОУ Средняя общеобразовательная школа с. Лойно" },
                    { 122, "Кировская область, Зуевский район, деревня Зуи, Молодёжная улица, 1А", true, "МКОУ Основная общеобразовательная школа д. Зуи" },
                    { 95, "Кировская область, Котельничский район, деревня Зайцевы, Школьная улица, 5", true, "Основная Общеобразовательная школа Д. Зайцевы Котельничского района Кировской области" },
                    { 94, "Кировская область, Советский район, село Ильинск, Комсомольская улица, 17", true, "МКОУ Средняя общеобразовательная школа с. Ильинск" },
                    { 93, "Кировская область, Белохолуницкий район, деревня Гуренки", true, "Общеобразовательная школа-интернат основного общего образования д. Гуренки МКОУ" },
                    { 92, "Кировская область, Нагорский район, поселок Кобра, Школьная улица, 13", true, "МКОУ Средняя общеобразовательная школа п. Кобра" },
                    { 64, "Кировская область, Белохолуницкий район, поселок Климковка, улица Кооперации, 5", true, "МКОУ Основная общеобразовательная школа п. Климковка" },
                    { 65, "Кировская область, Юрьянский район, посёлок Гирсово, улица Труда, 6", true, "МКОУ Основная общеобразовательная школа п. Гирсово" },
                    { 66, "Кировская область, Верхошижемский район, деревня Угор", true, "МКОУ Основная общеобразовательная школа д. Угор" },
                    { 67, "Кировская область, посёлок городского типа Юрья, улица Ленина, 13", true, "КОГОБУ Средняя школа с углубленным изучением отдельных предметов пгт. Юрья" },
                    { 68, "Кировская область, Арбажский район, село Сорвижи, Советская улица, 28", true, "МКОУ Средняя общеобразовательная школа с. Сорвижи" },
                    { 69, "Кировская область, Зуевка, Исполкомовская улица, 174", true, "МКОУ СОШ Образовательный центр, здание 1" },
                    { 70, "городской округ Киров, село Порошино, Бассейная улица, 1", true, "МБОУ Основная общеобразовательная школа № 1 г. Кирова" },
                    { 71, "Кировская область, Верхошижемский район, село Среднеивкино, Школьная улица, 13", true, "МКОУ Средняя общеобразовательная школа с. Среднеивкино" },
                    { 72, "Кировская область, Белохолуницкий район, поселок Подрезчиха, улица Кирова, 30А", true, "МКОУ СОШ п. Подрезчиха" },
                    { 73, "Кировская область, Орлов, улица Василия Сокованова, 6/62", true, "КОГОБУ Средняя школа г. Орлова" },
                    { 74, "Кировская область, Слободской район, село Бобино, Советская улица, 47", true, "МКОУ СОШ села Бобино" },
                    { 75, "Кировская область, Фалёнский муниципальный округ, посёлок Октябрьский, Школьная улица, 25", true, "Средняя общеобразовательная школа п. Октябрьский МКОУ" },
                    { 76, "Кировская область, посёлок городского типа Даровской, Октябрьская улица, 19А", true, "КОГОБУ Средняя школа пгт. Даровской" },
                    { 62, "Кировская область, Тужинский район, посёлок городского типа Тужа, улица Фокина, 1", true, "КОГОБУ СШ с УИОП пгт Тужа" },
                    { 77, "Кировская область, Немский муниципальный округ, село Архангельское, Молодёжная улица, 44А", true, "КОГОБУ Средняя школа села Архангельское Немского района Кировской области" },
                    { 79, "Кировская область, Слободской район, село Волково, Верхняя улица, 27А", true, "МКОУ Основная общеобразовательная школа с. Волково" },
                    { 80, "Кирово-Чепецкий муниципальный район, Пасеговское сельское поселение, село Пасегово, Школьная улица, 15", true, "МБОУ Средняя общеобразовательная школа с. Пасегово" },
                    { 81, "Кировская область, Лебяжский муниципальный округ, село Лаж, Советская улица, 56", true, "Средняя общеобразовательная школа с. Лаж МКОУ" },
                    { 82, "Кировская область, Даровской район, село Кобра, улица Гагарина, 7", true, "МКОУ Основная общеобразовательная школа с. Кобра" },
                    { 83, "Кировская область, Советский район, деревня Челка, Советская улица, 15", true, "МКОУ Основная общеобразовательная школа д. Челка" },
                    { 84, "Кировская область, Белохолуницкий район, посёлок Дубровка", true, "Муниципальное казенное общеобразовательное учереждение средние общеобразовательная школа п дубровка" },
                    { 85, "Кировская область, Оричевский район, посёлок городского типа Мирный, улица Степана Халтурина, 35", true, "МОКУ Средняя общеобразовательная школа пгт. Мирный Оричевского района Кировской области" },
                    { 86, "Киров, микрорайон Лянгасово, улица Ленина, 16", true, "МБОУ Средняя общеобразовательная школа № 73 города Кирова" },
                    { 87, "Кировская область, Котельнич, Октябрьская улица, 109", true, "МБОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 2 г. Котельнича" },
                    { 88, "Кировская область, Оричевский район, село Истобенск, улица Труда, 10", true, "Муниципальное Общеобразовательное Казенное Учреждение Основная общеобразовательная школа с. Истобенск Оричевского р-на Кировской обл." },
                    { 89, "Кировская область, Фалёнский муниципальный округ, село Талица, улица Ленина, 25", true, "МКОУ Средняя общеобразовательная школа с. Талица" },
                    { 90, "Кировская область, Советск, Советская улица, 84", true, "МКОУ Основная общеобразовательная школа № 4 г. Советск" },
                    { 91, "Кировская область, Котельничский район, село Юрьево, Школьная улица, 1", true, "МКОУ Основная общеобразовательная школа с. Юрьево" },
                    { 78, "Кировская область, Верхнекамский муниципальный округ, посёлок городского типа Лесной, улица Энтузиастов, 21", true, "МКОУ Средняя общеобразовательная школа пгт. Лесной" },
                    { 249, "Кирово-Чепецк, Сосновая улица, 24, корп. 2", true, "МКОУ Средняя общеобразовательная школа № 6 г. Кирово-Чепецка" },
                    { 246, "Кировская область, Белая Холуница, Юбилейная улица, 13", true, "Школа-интернат" },
                    { 251, "Кировская область, Пижанский район, поселок городского типа Пижанка, Советская улица, 32", true, "Кировское областное общеобразовательное бюджетное учреждение школа-интернат для обучающихся с ограниченными возможностями здоровья пгт Пижанка" },
                    { 408, "Удмуртская Республика, Глазов, Пионерская улица, 19", true, "МБОУ Гимназия № 8" },
                    { 409, "Республика Коми, муниципальный район Прилузский, село Черёмуховка, Октябрьская улица, 21А", true, "МБОУ СОШ село Черемуховка" },
                    { 410, "Республика Марий Эл, посёлок городского типа Советский, улица Победы, 18Б", true, "Советская средняя общеобразовательная школа № 2" },
                    { 411, "Удмуртская Республика, Юкаменский район, село Пышкет, Советская улица, 13", true, "Пышкетская средняя общеобразовательная школа" },
                    { 412, "Удмуртская Республика, Яр пос., ул. Школьная, 2", true, "МБОУ Ярская СОШ № 1" },
                    { 413, "Республика Марий Эл, посёлок городского типа Медведево, улица Логинова, 4", true, "Медведевская средняя общеобразовательная школа № 3 с углубленным изучением отдельных предметов имени 50-летия Медведевского района" },
                    { 414, "Нижегородская область, Шарангский район, село Роженцово", true, "МБОУ Роженцовская средняя школа" },
                    { 415, "Киров, улица Воровского, 77А", true, "Magic Move" },
                    { 416, "Удмуртская Республика, Балезинский район, посёлок Балезино, Сибирская улица, 1А", true, "МБОУ Балезинская средняя школа № 5" },
                    { 417, "Удмуртская Республика, Селтинский район, село Селты, Первомайская улица, 17", true, "Селтинская Средняя Общеобразовательная школа" },
                    { 418, "Республика Марий Эл, Сернурский район, деревня Калеево", true, "МОУ Калеевская ООШ" },
                    { 419, "Нижегородская область, Шахунья, Комсомольская улица, 27", true, "МБОУ СОШ № 14" },
                    { 420, "Удмуртская Республика, Глазов, улица Мира, 34", true, "Средняя общеобразовательная школа № 12" },
                    { 421, "Удмуртская Республика, Глазовский район, село Понино, Коммунальная улица, 3", true, "МОУ Понинская СОШ" },
                    { 422, "Удмуртская Республика, Глазов, улица Пехтина, 22А", true, "Средняя Общеобразовательная школа № 11" },
                    { 423, "Республика Марий Эл, городской округ Йошкар-Ола, село Семёновка, Молодёжная улица, 11", true, "Средняя общеобразовательная школа № 21" },
                    { 424, "Удмуртская Республика, Глазовский район, деревня Удмуртские Ключи, Школьная улица, 4", true, "Ключевская СОШ" },
                    { 425, "Удмуртская Республика, Глазов, улица Кирова, 49", true, "Физико-математический лицей" },
                    { 426, "Республика Марий Эл, Сернурский район, село Кукнур, Садовая улица, 1А", true, "Кукнурская Средняя Общеобразовательная школа" },
                    { 427, "Удмуртская Республика, Селтинский район, село Копки, Школьная улица, 7", true, "МКОУ Копкинская СОШ" },
                    { 428, "Республика Марий Эл, Оршанский район, деревня Лужбеляк, Центральная улица, 53", true, "Лужбелякская Основная Общеобразовательная школа" },
                    { 429, "Республика Марий Эл, Мари-Турекский район, деревня Елымбаево, Школьная улица, 9", true, "Нартасская средняя общеобразовательная школа" },
                    { 430, "Нижегородская область, городской округ Шахунья, рабочий посёлок Вахтан, улица Ленина, 12", true, "МАОУ Вахтанская средняя школа" },
                    { 431, "Нижегородская область, Тонкинский район, село Вязовка, Коммунистическая улица, 15", true, "Муниципальное бюджетное общеобразовательное учреждение Вязовская основная школа" },
                    { 432, "Удмуртская Республика, Кезский район, посёлок Кез, улица Пушкина, 11", true, "Кезская Средняя Общеобразовательная школа № 1" },
                    { 433, "Удмуртская Республика, Сюмсинский район, село Сюмси, Партизанская улица, 25", true, "Сюмсинская Средняя Общеобразовательная школа" },
                    { 434, "Удмуртская Республика, Ярский район, посёлок Яр, улица Вершининой, 6", true, "МКОУ Ярская Специальная Коррекционная Общеобразовательная школа-интернат" },
                    { 407, "Удмуртская Республика, Ярский район, село Дизьмино, Школьная улица, 28", true, "Дизьминская Средняя Общеобразовательная школа" },
                    { 435, "Удмуртская Республика, Глазов, Колхозная улица, 12", true, "Средняя общеобразовательная школа № 16" },
                    { 406, "Удмуртская Республика, Селтинский район, деревня Колесур, улица М.В. Карачева, 1", true, "Колесурская средняя общеобразовательная школа" },
                    { 404, "Удмуртская Республика, Глазовский район, село Октябрьский, Школьная улица, 6А", true, "Школа" },
                    { 377, "Удмуртская Республика, Глазовский район, село Дзякино, улица Кирова, 2", true, "МОУ Дзякинская СОШ" },
                    { 378, "Кировская область, посёлок городского типа Арбаж, улица Свободы, 19", true, "Начальная школа" },
                    { 250, "Киров, микрорайон Лянгасово, Комсомольская улица, 49", true, "МБОУ Средняя общеобразовательная школа № 71 города Кирова" },
                    { 380, "Кировская область, Вятскополянский район, поселок городского типа Красная Поляна, Сосновая улица, 24", true, "МКОУ Лицей пгт. Красная Поляна Корпус 3" },
                    { 381, "Удмуртская Республика, Ярский район, посёлок Яр, Школьная улица, 2", true, "МБОУ Ярская СОШ № 2" },
                    { 382, "Удмуртская Республика, Ижевск, улица Оружейника Драгунова, 74", true, "Школа № 61" },
                    { 383, "Республика Коми, муниципальный район Прилузский, село Гурьевка, Школьная улица, 3", true, "МБОУ СОШ села Гурьевка" },
                    { 384, "Удмуртская Республика, Малопургинский район, деревня Нижние Юри, Кировская улица, 15", true, "Средняя Общеобразовательная школа д. Нижние Юри Малопургинского района Удмуртской Республики" },
                    { 385, "Кировская область, Вятские Поляны, улица Азина, 62", true, "Начальная школа № 2" },
                    { 386, "Кировская область, Луза, улица Ленина, 78", true, "Начальная школа Василёк" },
                    { 387, "Удмуртская Республика, Глазов, улица Кирова, 37", true, "МБОУ Средняя Общеобразовательная школа № 3" },
                    { 388, "Киров, улица Ивана Попова, 58", true, "Квартал Талантов" },
                    { 389, "Республика Коми, муниципальный район Прилузский, муниципальное образование Ношуль, село Ношуль, Советская улица, 22", true, "Средняя общеобразовательная школа" },
                    { 390, "Киров, улица Свободы, 53А", true, "Юный гражданин" },
                    { 391, "Нижегородская область, Тоншаевский муниципальный округ, рабочий посёлок Пижма, улица Калинина, 8", true, "Пижемская средняя школа" },
                    { 392, "Республика Марий Эл, Советский район, село Вятское, улица Дружбы, 7", true, "Вятская средняя общеобразовательная школа" },
                    { 393, "Республика Марий Эл, посёлок городского типа Сернур, Коммунистическая улица, 78", true, "Сернурская средняя общеобразовательная школа № 1 имени героя Советского Союза А. М. Яналова" },
                    { 394, "Удмуртская Республика, Можга, улица Кирова, 67", true, "Средняя Общеобразовательная школа № 10" },
                    { 395, "Удмуртская Республика, Ярский район, село Укан, Школьная улица, 15А", true, "Уканская средняя общеобразовательная школа" },
                    { 396, "Удмуртская Республика, Глазов, улица Короленко, 8", true, "Школа № 17" },
                    { 397, "Республика Марий Эл, посёлок городского типа Куженер, улица Кирова, 2Б", true, "Школа № 1" },
                    { 398, "Нижегородская область, Тоншаевский муниципальный округ, рабочий посёлок Пижма", true, "МОУ Лесозаводская ООШ" },
                    { 399, "Республика Коми, муниципальный район Койгородский, муниципальное образование Койгородок, село Койгородок, Луговой переулок, 12А", true, "МБОУ СОШ села Койгородок" },
                    { 400, "Удмуртская Республика, Ижевск, улица Кирова, 56", true, "МБОУ Средняя общеобразовательная школа № 62 имени Ю.А.Гагарина" },
                    { 401, "Удмуртская Республика, Глазов, улица Белинского, 7", true, "Школа" },
                    { 402, "Республика Коми, муниципальный район Прилузский, село Черёмуховка, Школьная улица, 2", true, "Школа" },
                    { 403, "Киров, улица Карла Маркса, 127", true, "Iron" },
                    { 405, "Костромская область, Октябрьский район, село Боговарово, Первомайская улица, 28", true, "Боговаровская школа" },
                    { 436, "Республика Марий Эл, Медведевский район, посёлок Куяр, Садовая улица, 20", true, "Куярская средняя общеобразовательная школа" },
                    { 437, "Республика Коми, Койгородский район, посёлок Кажым, Школьная улица, 2", true, "Средняя общеобразовательная школа п. Кажым МБОУ" },
                    { 438, "Чувашская Республика, Чебоксары, микрорайон Новый Город, Новогородская улица, 23", true, "Школа № 65" },
                    { 472, "Удмуртская Республика, Глазовский район, деревня Адам, Восточная улица, 8-1", true, "Адамская Средняя Общеобразовательная школа" },
                    { 473, "Республика Марий Эл, Йошкар-Ола, улица 8 Марта, 19", true, "Школа № 17" },
                    { 474, "Чувашская Республика, Чебоксары, улица Тимофея Кривова, 15А", true, "Средняя общеобразовательная школа № 29" },
                    { 475, "Республика Марий Эл, Йошкар-Ола, улица Волкова, 126", true, "МБОУ СОШ № 5 Обыкновенное Чудо" },
                    { 476, "Республика Марий Эл, Куженерский район, село Юледур", true, "Юледурская средняя общеобразовательная школа" },
                    { 477, "Республика Марий Эл, Сернурский район, село Марисола, Центральная улица, 21", true, "Школа" },
                    { 478, "Республика Марий Эл, Параньгинский район, деревня Олоры, Школьная улица, 8", true, "Олорская средняя общеобразовательная школа" },
                    { 479, "Республика Марий Эл, Йошкар-Ола, улица Прохорова, 48", true, "Средняя общеобразовательная школа № 31 г. Йошкар-Олы" },
                    { 480, "Удмуртская Республика, Ижевск, микрорайон Ключевой Посёлок, Прасовский переулок, 5", true, "Школа № 46" },
                    { 481, "Республика Марий Эл, Звениговский район, городское поселение Суслонгер, посёлок городского типа Суслонгер, Гвардейская улица, 8", true, "МОУ Суслонгерская средняя общеобразовательная школа" },
                    { 482, "Удмуртская Республика, Ижевск, улица А.Н. Сабурова, 49А", true, "Средняя образовательная школа № 34" },
                    { 483, "Удмуртская Республика, Глазов, улица Пряженникова, 37А", true, "Средняя общеобразовательная школа № 13" },
                    { 484, "Удмуртская Республика, Красногорский район, село Курья, Юбилейная улица, 6", true, "Курьинская Средняя Общеобразовательная школа Имени Героя Советского Союза Григория Федоровича Ожмегова" },
                    { 485, "Республика Марий Эл, Медведевский район, посёлок Юбилейный, улица Культуры, 2", true, "Юбилейная средняя общеобразовательная школа" },
                    { 486, "Удмуртская Республика, Ижевск, Удмуртская улица, 143", true, "Средняя общеобразовательная школа № 97 Гармония, учебный корпус № 2" },
                    { 487, "Удмуртская Республика, Юкаменский район, село Юкаменское, Вежеевская улица, 39", true, "Школа" },
                    { 488, "Республика Марий Эл, Йошкар-Ола, улица Подольских Курсантов, 8Б", true, "Школа № 30" },
                    { 489, "Удмуртская Республика, Завьяловский район, село Бабино, Центральная улица, 17", true, "Бабинская Средняя Общеобразовательная школа" },
                    { 490, "Республика Татарстан, Атнинский район, деревня Нижние Шаши, улица Кирова, 56", true, "МБОУ Кунгерская СОШ" },
                    { 491, "Республика Марий Эл, Мари-Турекский район, село Косолапово, Советская улица, 29", true, "Косолаповская средняя общеобразовательная школа" },
                    { 492, "Республика Марий Эл, Параньгинский район, деревня Ильпанур, Школьная улица, 9", true, "Ильпанурская Основная Общеобразовательная школа" },
                    { 493, "Республика Коми, муниципальный район Прилузский, посёлок Вухтым, Спортивная улица, 2", true, "МБОУ Средняя общеобразовательная школа СПТ. Вухтым" },
                    { 494, "Удмуртская Республика, Ижевск, Широкий переулок, 71А", true, "Средняя общеобразовательная школа № 28" },
                    { 495, "Киров, улица Воровского, 108", true, "Мелиссента" },
                    { 496, "Удмуртская Республика, Балезинский район, посёлок Балезино, улица Карла Маркса, 30", true, "Балезинская средняя общеобразовательная школа № 1" },
                    { 497, "Республика Марий Эл, Йошкар-Ола, улица Петрова, 15", true, "МОУ Средняя общеобразовательная школа № 1" },
                    { 498, "Удмуртская Республика, Балезинский район, посёлок Балезино, улица Свердлова, 1", true, "Балезинская Средняя Общеобразовательная школа № 3" },
                    { 471, "Удмуртская Республика, Глазов, улица Революции, 8", true, "МБОУ СОШ № 2" },
                    { 470, "Удмуртская Республика, Кезский район, село Чепца, Школьный переулок, 6", true, "Чепецкая Средняя Общеобразовательная школа" },
                    { 469, "Нижегородская область, городской округ Шахунья, село Хмелевицы, Автомобильная улица, 1А", true, "Хмелевицкая средняя общеобразовательная школа" },
                    { 468, "Республика Марий Эл, Медведевский район, село Кузнецово, Пионерская улица, 1А", true, "Кузнецовская средняя образовательная школа" },
                    { 439, "Республика Марий Эл, Параньгинский район, село Куракино, Советская улица, 25", true, "Школа" },
                    { 440, "Нижегородская область, рабочий посёлок Тоншаево, Октябрьская улица, 54", true, "Тоншаевская Средняя школа" },
                    { 441, "Нижегородская область, Шарангский район, село Кушнур, Центральная улица, 37", true, "МБОУ Кушнурская СШ" },
                    { 442, "Удмуртская Республика, Глазов, улица Калинина, 9А", true, "МБОУ СШ № 15 им. В. Н. Рождественского" },
                    { 443, "Удмуртская Республика, Кезский район, посёлок Кез, 1-я Лесная улица, 27", true, "Кезская Средняя Общеобразовательная школа № 2" },
                    { 444, "Республика Татарстан, Балтасинский район, деревня Смаиль, улица Кирова, 61", true, "Смаильская средняя общеобразовательная школа" },
                    { 445, "Республика Коми, муниципальный район Койгородский, муниципальное образование Койдин, посёлок Койдин, Школьная улица, 16", true, "МОУ Начальная общеобразовательная школа ПСТ. Койдин" },
                    { 446, "Республика Марий Эл, посёлок городского типа Советский, улица Пушкина, 32А", true, "Средняя общеобразовательная школа № 3 п. Советский" },
                    { 447, "Удмуртская Республика, Кизнерский район, посёлок Кизнер, Школьная улица, 1", true, "Кизнерская Средняя Общеобразовательная школа № 1" },
                    { 448, "Удмуртская Республика, Ярский район, село Пудем, улица Гагарина, 1", true, "Муниципальное казённое общеобразовательное учреждение Пудемская средняя общеобразовательная школа" },
                    { 449, "Удмуртская Республика, Игринский район, посёлок Игра, Коммунальная улица, 28", true, "Игринская Средняя Общеобразовательная школа № 1" },
                    { 450, "Удмуртская Республика, Глазов, улица Толстого, 45", true, "Гимназия № 14" },
                    { 451, "Киров, улица Карла Маркса, 75", true, "Millenium" },
                    { 376, "Удмуртская Республика, Глазов, улица Кирова, 75А", true, "Средняя Общеобразовательная школа № 9" },
                    { 452, "Киров, улица Пугачёва, 18", true, "Детская школа классического танца" },
                    { 454, "Костромская область, посёлок Вохма, Советская улица, 70", true, "МОУ Вохомская средняя общеобразовательная школа Вохомского муниципального района Костромской области" },
                    { 455, "Удмуртская Республика, Ижевск, микрорайон Липовая Роща, Вараксинский бульвар, 1А", true, "Средняя общеобразовательная школа № 26 с углубленным изучением отдельных предметов" },
                    { 456, "Республика Коми, муниципальный район Прилузский, село Спаспоруб, Школьная улица, 11", true, "Средняя Общеобразовательная школа" },
                    { 457, "Киров, Первомайский район, Советская улица, 100А", true, "Ювента" },
                    { 458, "Удмуртская Республика, Игринский район, посёлок Игра, улица Пугачёва, 36", true, "МБОУ Игринская Средняя Общеобразовательная школа № 3" },
                    { 459, "Удмуртская Республика, Ижевск, улица Леваневского, 2А", true, "Средняя общеобразовательная школа № 20, корпус № 1" },
                    { 461, "Удмуртская Республика, Завьяловский район, деревня Подшивалово, 6", true, "Подшиваловская средняя общеобразовательная школа Имени Героя Советского Союза В. П. Зайцева" },
                    { 462, "Удмуртская Республика, Юкаменский район, деревня Новоелово, Центральная улица, 1", true, "Новоеловская средняя общеобразовательная школа" },
                    { 463, "Республика Коми, муниципальный район Прилузский, муниципальное образование на территории поселения Объячево, село Чёрныш, Школьный переулок, 8", true, "МБОУ Средняя общеобразовательная школа с. Чёрныш" },
                    { 464, "Республика Марий Эл, Мари-Турекский район, деревня Сысоево, улица Центральная Усадьба, 10", true, "Сысоевская средняя общеобразовательная школа им. С. Р. Суворова" },
                    { 465, "Чувашская Республика, Чебоксары, проспект Тракторостроителей, 38", true, "Школа № 56" },
                    { 466, "Удмуртская Республика, Балезинский район, деревня Исаково, Школьная улица, 1", true, "Исаковская средняя общеобразовательная школа" },
                    { 467, "Удмуртская Республика, Глазовский район, деревня Качкашур, Центральная улица, 5", true, "Качкашурская средняя общеобразовательная школа" },
                    { 453, "Удмуртская Республика, Ижевск, Клубная улица, 58", true, "МБОУ СОШ № 100" },
                    { 375, "Республика Коми, муниципальный район Прилузский, село Летка, Весенняя улица, 29", true, "МАОУ Средняя общеобразовательная школа с. Летка" },
                    { 379, "Кирово-Чепецк, Фестивальная улица, 16", true, "Гимназия № 1, корпус Б" },
                    { 373, "Удмуртская Республика, Глазовский район, поселок Кожиль, Кировская улица, 80", true, "Кожильская Средняя Общеобразовательная школа Сельскохозяйственного Направления" },
                    { 283, "Киров, Первомайский район, Милицейская улица, 28А", true, "КОГОАУ Вятская гуманитарная гимназия с углубленным изучением английского языка Учебный корпус" },
                    { 284, "Киров, улица Герцена, 23", true, "Первая школа" },
                    { 285, "Кировская область, Опаринский муниципальный округ, поселок Речной, Заречная улица, 1", true, "МКОУ СОШ п. Речной Опаринского района" },
                    { 286, "Кировская область, Вятскополянский район, Сосновка, Советская улица, 73Б", true, "МКОУ Основная общеобразовательная школа г. Сосновка" },
                    { 287, "Кировская область, посёлок городского типа Опарино, Пионерский переулок, 5", true, "КОГОБУ ШИ ОВЗ пгт Опарино" },
                    { 288, "Кировская область, Оричевский район, село Быстрица, Школьная улица, 7", true, "Быстринская Основная школа" },
                    { 289, "Кировская область, Вятскополянский район, село Слудка, Молодёжная улица, 6", true, "Средняя общеобразовательная школа с. Слудка Вятскополянского района Кировской области" },
                    { 290, "Кировская область, Богородский городской округ, посёлок городского типа Богородское, улица Гагарина, 17", true, "Богородская школа" },
                    { 291, "Киров, Уральская улица, 9", true, "МБОУ Лингвистическая гимназия города Кирова" },
                    { 292, "Кировская область, Яранский район, село Кугалки, Зелёная улица, 1", true, "МКОУ Основная общеобразовательная школа с. Кугалки Яранского района Кировской области" },
                    { 293, "Киров, Первомайский район, улица МОПРа, 19В", true, "МБОУ Основная общеобразовательная школа № 24 г. Кирова" },
                    { 294, "Киров, улица Лепсе, 31", true, "Кировский центр дистанционного образования детей" },
                    { 295, "Киров, улица Кольцова, 9", true, "МБОУ СОШ № 42" },
                    { 296, "Кировская область, Фалёнский муниципальный округ, деревня Филейка", true, "Школа-интернат д. Филейка МКОУ" },
                    { 297, "Кировская область, Советский район, село Мокино, Октябрьская улица, 5", true, "Основная Общеобразовательная школа села Мокино Советского района Кировской области" },
                    { 298, "Киров, Первомайский район, улица Розы Люксембург, 87", true, "КОГОБУ школа для обучающихся с ограниченными возможностями здоровья № 44 г. Кирова" },
                    { 299, "Кировская область, Вятскополянский район, посёлок городского типа Красная Поляна, улица Дружбы, 33", true, "Школа № 2" },
                    { 300, "Кирово-Чепецкий район, деревня Шутовщина, Октябрьская улица, 5А", true, "МКОУ Начальная общеобразовательная школа деревни Шутовщина" },
                    { 301, "Киров, Казанская улица, 43", true, "Кировский экономико-правовой лицей" },
                    { 302, "Кировская область, посёлок городского типа Подосиновец, Боровая улица, 6", true, "КОГОБУ Средняя школа пгт. Подосиновец" },
                    { 303, "Кировская область, Малмыжский район, село Аджим, Советская улица, 15А", true, "МКОУ школа с. Аджим" },
                    { 304, "Кировская область, Котельнич, Советская улица, 151", true, "КОГОБУ школа-интернат для обучающихся с ограниченными возможностями здоровья г. Котельнича" },
                    { 305, "Киров, Первомайский район, улица Володарского, 114Б", true, "Петербургский лицей АНОО" },
                    { 306, "Киров, улица Гайдара, 7", true, "ЧОУ СОШ Наша школа" },
                    { 307, "Кирово-Чепецк, Вятская набережная, 5", true, "Средняя общеобразовательная школа № 5 г. Кирово-Чепецка" },
                    { 374, "Кировская область, Уржум, Советская улица, 38", true, "Спальный корпус КОГОАУ Гимназия г. Уржума" },
                    { 309, "Киров, улица Свободы, 76", true, "Вятская гуманитарная гимназия с углубленным изучением английского языка" },
                    { 282, "Кировская область, Вятскополянский район, деревня Средние Шуни, 37", true, "МКОУ Средняя общеобразовательная школа д. Средние Шуни" },
                    { 310, "Кировская область, Советск, улица Ленина, 24", true, "КОГОБУ Лицей г. Советска" },
                    { 281, "Кировская область, Яранск, улица Ленина, 2", true, "Школа № 1" },
                    { 279, "Киров, улица Риммы Юровской, 11", true, "Аэлита" },
                    { 252, "Кирово-Чепецк, Школьная улица, 4А", true, "МКОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 10 г. Кирово-Чепецка" },
                    { 253, "Киров, улица Ленина, 52", true, "Лицей информационных технологий № 28" }
                });

            migrationBuilder.InsertData(
                table: "School",
                columns: new[] { "ID", "Address", "IsSchool", "Name" },
                values: new object[,]
                {
                    { 254, "Кировская область, Малмыжский район, село Константиновка, Школьный переулок, 3", true, "МКОУ Средняя общеобразовательная школа с. Константиновка" },
                    { 255, "Кировская область, Кильмезский район, деревня Зимник, Школьная улица, 1", true, "Основная общеобразовательная школа д. Зимник МКОУ" },
                    { 256, "Кировская область, Лебяжский район, село Ветошкино, улица Свободы, 43", true, "Средняя общеобразовательная школа с. Ветошкино МКОУ" },
                    { 257, "Кировская область, Омутнинский район, посёлок городского типа Восточный, улица 30 лет Победы, 4", true, "Школа № 2" },
                    { 258, "Кировская область, Уржумский район, село Шевнино, улица Кирова, 30А", true, "Основная общеобразовательная школа с. Шевнино МКОУ" },
                    { 259, "Киров, проспект Строителей, 44", true, "МБОУ Средняя общеобразовательная школа с углубленным изучением отдельных предметов № 52" },
                    { 260, "Кировская область, Кикнурский муниципальный округ, деревня Ваштранга, Новая улица, 2А", true, "Средняя общеобразовательная школа д. Ваштранга МКОУ" },
                    { 261, "Кировская область, Омутнинский район, поселок Котчиха, Комсомольская улица, 6", true, "Основная общеобразовательная школа п. Котчиха МКОУ" },
                    { 262, "Кировская область, Уржумский район, село Большой Рой, Центральная улица, 25", true, "МКОУ СОШ с. Б-Рой Уржумского района Кировской области" },
                    { 263, "Кировская область, Арбажский муниципальный округ, село Верхотулье, Советская улица, 16", true, "Основная общеобразовательная школа с. Верхотулье МКОУ" },
                    { 264, "Киров, Солнечная улица, 21", true, "МОАУ Средняя общеобразовательная школа № 8 г. Кирова" },
                    { 265, "Киров, Сормовская улица, 38", true, "МБОУ Средняя общеобразовательная школа № 54" },
                    { 266, "Кировская область, Оричевский район, посёлок Зенгино, Школьная улица, 3", true, "МОКУ СОШ п. Зенгино" },
                    { 267, "Кировская область, Арбажский район, поселок городского типа Арбаж, Советская улица, 6", true, "КОГОБУ ШИ ОВЗ пгт Арбаж" },
                    { 268, "Кировская область, Кикнурский муниципальный округ, село Русские Краи, Молодёжная улица, 16", true, "МКОУ Средняя общеобразовательная школа с. Русские Краи" },
                    { 269, "Кировская область, Лузский муниципальный округ, посёлок городского типа Лальск, Набережный переулок, 8", true, "МОКУ Средняя общеобразовательная школа пгт Лальск" },
                    { 270, "Кировская область, Вятскополянский район, деревня Чекашево, Школьная улица, 20", true, "МКОУ СОШ д. Чекашево Вятскополянского района Кировской области" },
                    { 271, "Кировская область, городской округ Слободской, село Успенское, Красная улица, 9, стр. 2", true, "КОГОБУ ШИ ОВЗ с. Успенское Слободского района" },
                    { 272, "Киров, улица Возрождение, 6", true, "КОГОАУ Лицей естественных наук, корпус № 1" },
                    { 273, "Кировская область, Малмыж, Красноармейская улица, 76", true, "Средняя Общеобразовательная школа № 2 г. Малмыжа Кировской области" },
                    { 274, "Кировская область, Уржумский район, село Цепочкино, улица Кирова, 34", true, "Цепочкинская школа" },
                    { 275, "Кировская область, посёлок городского типа Оричи, Комсомольская улица, 3", true, "Оричевская вечерняя школа" },
                    { 276, "Киров, улица Гайдара, 5", true, "МБОУ Средняя общеобразовательная школа № 45 им. А. П. Гайдара" },
                    { 277, "Киров, улица Некрасова, 57", true, "Школа № 59" },
                    { 278, "Кировская область, Кильмезский район, деревня Четай, Лесная улица, 1", true, "МКОУ Основная общеобразовательная школа д. Четай Кильмезского района Кировской области" },
                    { 280, "Киров, Нововятский район, Советская улица, 48", true, "МБОУ Средняя общеобразовательная школа № 62 им. А. Я. Опарина с углубленным изучением отдельных предметов" },
                    { 311, "Киров, Первомайский район, улица МОПРа, 55А", true, "Вятская гуманитарная гимназия с углубленным изучением английского языка" },
                    { 308, "Киров, улица Физкультурников, 15", true, "МОАУ Гимназия имени Александра Грина г. Кирова" },
                    { 313, "Кировская область, Юрьянский район, село Монастырское, Тополиная улица, 37", true, "Начальная общеобразовательная школа с. Монастырское МКОУ" },
                    { 345, "Кировская область, Малмыж, улица Тимирязева, 6", true, "КОГОБУ Лицей г. Малмыжа" },
                    { 312, "Кирово-Чепецкий район, село Филиппово, улица Заева, 41", true, "МКОУ Средняя общеобразовательная школа с. Филиппово" },
                    { 347, "Киров, улица Ленина, 198к2", true, "Успех" },
                    { 348, "Кирово-Чепецк, проспект Мира, 61, корп. 3", true, "МБОУ Гимназия № 2 г. Кирово-Чепецка" },
                    { 349, "Кировская область, Вятские Поляны, улица Азина, 45", true, "Вятский многопрофильный лицей" },
                    { 350, "Кировская область, Юрьянский район, деревня Высоково, Лесная улица, 9", true, "МБОУ Куйбышевская СОШ" },
                    { 351, "Кировская область, Кирс, улица Кирова, 24", true, "Начальная школа Школа села УИОП г. Кирс" },
                    { 352, "Киров, Ленинградская улица, 3", true, "МБОУ Художественно-технологический лицей города Кирова" },
                    { 353, "Киров, улица Дзержинского, 25", true, "КОГБУ школа-интернат для обучающихся с ограниченными возможностями здоровья № 3 г. Кирова" },
                    { 354, "Кировская область, Уржумский район, деревня Кизерь, Новая улица, 6", true, "Филиал МКОУ СОШ с. Русский Турек, Начальная общеобразовательная школа д. Кизерь" },
                    { 355, "Кировская область, Вятскополянский район, Сосновка, улица Дзержинского, 24", true, "Школа" },
                    { 356, "Кировская область, посёлок городского типа Кикнур, Комсомольская улица, 4", true, "КОГОБУ ШИ ОВЗ" },
                    { 357, "Кирово-Чепецк, улица Терещенко, 13", true, "МКОУ центр образования им. Алексея Некрасова г. Кирово-Чепецка, Корпус № 2" },
                    { 344, "Кировская область, Вятскополянский район, Сосновка, улица Куйбышева, 8", true, "КОГОБУ Шовз г. Сосновки" },
                    { 358, "Кировская область, Подосиновский район, посёлок городского типа Демьяново, Парковая улица, 4А", true, "Кировское областное государственное общеобразовательное бюджетное учреждение Школа-интернат для обучающихся с ограничеными возможностями здоровья пгт Демьяново Подосиновского района" },
                    { 360, "Киров, улица Дерендяева, 112", true, "Престиж" },
                    { 361, "Киров, улица Ивана Попова, 37", true, "Вятский технический лицей" },
                    { 362, "Кировская область, Малмыжский район, село Савали", true, "Школа" },
                    { 363, "Кировская область, Вятские Поляны, Школьная улица, 55А", true, "МКОУ Лицей с кадетскими классами имени Г. С. Шпагина города Вятские Поляны Кировской области" },
                    { 364, "Кировская область, посёлок городского типа Подосиновец, Школьная улица, 3/1", true, "Средняя школа пгт Демьяново Подосиновского района" },
                    { 365, "Кировская область, Вятскополянский район, Сосновка, Пролетарская улица, 64", true, "МКОУ Гимназия г. Сосновка" },
                    { 366, "Кировская область, Вятскополянский район, поселок городского типа Красная Поляна, улица Дружбы, 17", true, "МКОУ Лицей пгт Красная Поляна Вятскополянского района Кировской области" },
                    { 367, "Нижегородская область, Тоншаевский муниципальный округ, рабочий посёлок Пижма, улица Кирова, 8", true, "Лесозаводская Основная Общеобразовательная школа" },
                    { 368, "Кировская область, Верхнекамский муниципальный округ, поселок Новый Поселок №3", true, "Школа-интернат для Обучающихся С Ограниченными Возможностями Здоровья П. Светлополянска Верхнекамского района" },
                    { 369, "Кировская область, Вятские Поляны, улица Гагарина, 17", true, "МКОУ Гимназия г. Вятские Поляны" },
                    { 370, "Кировская область, Вятские Поляны, улица Шорина, 20А", true, "Гимназия" },
                    { 371, "Кировская область, Слободской район, посёлок Октябрьский, Первомайская улица, 8", true, "Школьная мастерская" },
                    { 372, "Кировская область, посёлок городского типа Уни, улица Ленина, 24", true, "Начальная школа" },
                    { 359, "Кировская область, Слободской район, посёлок городского типа Вахруши, Советская улица, 7", true, "Школа №1" },
                    { 343, "Кировская область, Санчурский муниципальный округ, село Матвинур, Школьная улица, 2", true, "МКОУ Средняя общеобразовательная школа с. Матвинур" },
                    { 346, "Киров, улица Ивана Попова, 33", true, "Вятский технический лицей" },
                    { 341, "Кировская область, Вятскополянский район, посёлок городского типа Красная Поляна, улица Дружбы, 17", true, "Школа № 1" },
                    { 314, "Киров, микрорайон Коминтерновский, улица Павла Корчагина, 66", true, "МБОУ Основная общеобразовательная школа № 33 г. Кирова" },
                    { 315, "Киров, Московская улица, 35", true, "Вятская православная гимназия во имя преподобного Трифона Вятского" },
                    { 316, "Кировская область, Верхнекамский муниципальный округ, посёлок городского типа Светлополянск, улица Дзержинского, 8", true, "КОГОБУ ШИ ОВЗ Специальная общеобразовательная школа-интернат для детей с ограниченными возможностями пгт. Светлополянск" },
                    { 317, "Киров, улица Дерендяева, 99", true, "Кировское областное государственное образовательное бюджетное учреждение школа-интернат для обучающихся с ограниченными возможностями здоровья г. Кирова" },
                    { 318, "Кировская область, Уржум, Красная улица, 98", true, "МКОУ Средняя общеобразовательная школа г. Уржума" },
                    { 319, "Киров, Нововятский район, улица Пушкина, 27", true, "Специальная" },
                    { 320, "Киров, Первомайский район, Милицейская улица, 52А", true, "Кировское областное государственное общеобразовательное бюджетное учреждение школа для обучающихся с ограниченными возможностями здоровья Хрусталик г. Кирова" },
                    { 321, "Кирово-Чепецк, проезд Лермонтова, 1", true, "МКОУ центр образования им. Алексея Некрасова г. Кирово-Чепецка" },
                    { 322, "Кирово-Чепецк, проспект Мира, 52", true, "Гимназия № 1 города Кирово-Чепецка" },
                    { 323, "Кировская область, Вятские Поляны, улица Дзержинского, 55", true, "Муниципальное казенное общеобразовательное учреждение средняя общеобразовательная школа № 5 города Вятские Поляны" },
                    { 342, "Кировская область, Нолинск, Первомайская улица, 21", true, "Кировское областное государственное общеобразовательное бюджетное учреждение Школа-интернат для обучающихся с ограниченными возможностями здоровья № 1 города Нолинска" },
                    { 325, "Кировская область, Немский муниципальный округ, село Архангельское, Заречная улица, 30", true, "Школа" },
                    { 326, "Кировская область, Кильмезский район, деревня Малая Кильмезь, Зелёная улица, 1", true, "МКОУ ООШ д. Малая Кильмезь" },
                    { 327, "Кировская область, Вятскополянский район, деревня Старый Пинигерь, Школьная улица, 1Д", true, "МКОУ Средняя общеобразовательная школа д. Старый Пинигерь" },
                    { 324, "Кировская область, Санчурский городской округ, деревня Большая Шишовка, 54", true, "Основная общеобразовательная школа д. Большая Шишовка МКОУ" },
                    { 329, "Кировская область, Вятскополянский район, село Ершовка, Молодёжная улица, 17", true, "МКОУ Основная общеобразовательная школа с. Ершовка" },
                    { 340, "Кирово-Чепецк, улица Комиссара Утробина, 5", true, "МБОУ Многопрофильный лицей города Кирово-Чепецка Кировской области" },
                    { 339, "Кировская область, Малмыжский район, село Мари-Малмыж, Школьная улица, 32", true, "МКОУ Основная общеобразовательная школа с. Мари-Малмыж" },
                    { 328, "Кировская область, Уржум, улица Гоголя, 57", true, "КОГОАУ Гимназия г. Уржума" },
                    { 337, "Кировская область, Нолинск, Первомайская улица, 16", true, "КОГОБУ ШИ ОВЗ № 2 г. Нолинска" },
                    { 336, "Кировская область, Омутнинский район, село Залазна, Шоссейная улица, 1", true, "МКОУ СОШ с. Залазна" },
                    { 335, "Кировская область, Вятские Поляны, Советская улица, 24", true, "Специальная ОУ, для обучающихся, воспитанников с ограниченными возможностями здоровья" },
                    { 338, "Кировская область, Пижанский район, деревня Новые Щеглята, Советская улица, 32", true, "Школа-интернат для Обучающихся С Ограниченными Возможностями Здоровья пгт Пижанка" },
                    { 334, "Киров, улица Горбуновой, 13", true, "МБУ СОШ № 22 г. Кирова" },
                    { 333, "Кирово-Чепецк, проспект Мира, 37", true, "Школа для обучающихся с ограниченными возможностями здоровья" },
                    { 332, "Кирово-Чепецкий район, посёлок Ключи, улица Дружбы, 6", true, "Муниципальное казенное общеобразовательное учреждение средняя общеобразовательная школа п. Ключи" },
                    { 331, "Киров, улица Воровского, 133А", true, "МОАУ Лицей № 21 г. Кирова" },
                    { 330, "Кирово-Чепецк, улица Алексея Некрасова, 21", true, "МБОУ Лицей города Кирово-Чепецка Кировской области" }
                });

            migrationBuilder.InsertData(
                table: "Transport",
                columns: new[] { "ID", "Brand", "CarNumber", "DateDiagnosticCard", "DateDiagnosticCardStr", "DiagnosticCardNumber", "IsRemoved" },
                values: new object[,]
                {
                    { 1, "Higer KLQ 6885 Q", "H 233 XA 43 RUS", new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "14.06.2023", "126681052200980", false },
                    { 2, "Zhong tong LCK", "В 197 СР 43 RUS", new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "20.04.2023", "056571012201376", false },
                    { 3, "Mersedes-Benz O 510 Tour", "А 375 ХО 43 RUS", new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "17.02.2023", "126681052200365", false },
                    { 4, "Higer KLQ 6122 B", "В 503 ТВ 43 RUS", new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "26.10.2023", "126681052200723", false }
                });

            migrationBuilder.InsertData(
                table: "TypeEvent",
                columns: new[] { "ID", "Description", "IsRemoved", "Name", "Shablon", "ShortName" },
                values: new object[,]
                {
                    { 1, "Новый год", false, "Новогодье", "ddm", "ДДМ" },
                    { 2, "Масленица", false, "Встреча весны", "vm", "ВМ" },
                    { 3, "Выпускной", false, "Выпускные", "vip", "ВЫП" },
                    { 4, "Ночной Выпускной", false, "Ночные выпускные", "nv", "НВЫП" },
                    { 5, "Выпускные,г.Сыктывкар", false, "Выпускные,г.Сыктывкар", "vip", "ВЫП" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "ID", "EmploymentDate", "Middlename", "Name", "PassportData", "PhoneNumber", "RoleID", "Surname" },
                values: new object[] { 1, new DateTime(2020, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Матвеевич", "Леонид", "3316 345677", "+79532521240", 1, "Кондрашов" });

            migrationBuilder.InsertData(
                table: "Route",
                columns: new[] { "ID", "CheckpointFinishID", "CheckpointStartID", "Description", "FullDescription", "Name", "NumberDays", "River" },
                values: new object[,]
                {
                    { 1, 2, 1, "Красавица река НЕМДА является жемчужиной Вятского края", "Красавица река НЕМДА является жемчужиной Вятского края. Природа этих мест уникальна: выходы известняковых скал, рельефные берега, бурлящие перекаты, самый высокий водопад Кировской области, чистая родниковая вода, отсутствие комаров, живописные пейзажи", "Любимая Немда", 3, "Nemda" },
                    { 2, 2, 1, "Красавица река НЕМДА является жемчужиной Вятского края", "Красавица река НЕМДА является жемчужиной Вятского края. Природа этих мест уникальна: выходы известняковых скал, рельефные берега, бурлящие перекаты, самый высокий водопад Кировской области, чистая родниковая вода, отсутствие комаров, живописные пейзажи", "Любимая Немда(4 дня)", 4, "Nemda" },
                    { 3, 4, 3, "Затерянный мир На Вятке", "Затерянный мир На Вятке. Маршрут, где можно насладиться по настоящему дикой природой, редкими расстениями и ощутить настоящее единение с природой. ", "Затерянный мир", 3, "Vyatka" },
                    { 4, 6, 5, "Великолепный маршрут Родные просторы по берегам реки Вятки", "Великолепный маршрут Родные просторы по берегам реки Вятки подарит огромное количество позитивных эмоций и незабываемых впечатлений.", "Родные просторы", 3, "Vyatka}" },
                    { 5, 8, 7, "Поющие пески Вятки ", "У заброшенной деревни Атары в Кировской области, где Вятка делает крутой поворот, находится трехкилометровая отмель с белым песком из горного хрусталя и молочного кварца. ", "Поющие пески", 3, "Vyatka" },
                    { 6, 10, 9, "Очень красивые и живописные места, на очень быстрой и стремительной реке Быстрице", "Очень красивые и живописные места, на очень быстрой и стремительной реке Быстрице откроются перед вами если вы посетите этот маршрут", "Быстрая вода", 2, "Bystrica" },
                    { 7, 10, 9, "Очень красивые и живописные места, на очень быстрой и стремительной реке Быстрице", "Очень красивые и живописные места, на очень быстрой и стремительной реке Быстрице откроются перед вами если вы посетите этот маршрут", "Быстрая вода(3 дня)", 3, "Bystrica" },
                    { 8, 12, 11, "С воды раскрываются все красоты города Кирова", "С воды раскрываются все красоты города Кирова. Появляется возможность насладиться ими прямо с водной глаяди реки Вятки.", "Город с воды", 1, "Vyatka" },
                    { 9, 14, 13, "Мосты вятки", "Мосты вятки", "Мосты вятки", 1, "Vyatka" },
                    { 10, 16, 15, "Путь ушкуйников", "Путь ушкуйников", "Путь ушкуйников", 1, "Vyatka" },
                    { 11, 10, 17, "Фестивальный", "Фестивальный", "Фестивальный", 1, "Bystrica" },
                    { 12, 19, 18, "Слободская регата PRO", "Слободская регата PRO", "Слободская регата PRO", 1, "Vyatka" },
                    { 13, 20, 18, "Слободская регата LITE", "Слободская регата LITE", "Слободская регата LITE", 1, "Vyatka" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Charter_DriverID",
                table: "Charter",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_Charter_TransportID",
                table: "Charter",
                column: "TransportID");

            migrationBuilder.CreateIndex(
                name: "IX_Charter_UserID",
                table: "Charter",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_EventID",
                table: "Contract",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_CountableHikeEquipment_CountableEquipmentID",
                table: "CountableHikeEquipment",
                column: "CountableEquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_CountableHikeEquipment_HikeID",
                table: "CountableHikeEquipment",
                column: "HikeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PassportData",
                table: "Employee",
                column: "PassportData",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PhoneNumber",
                table: "Employee",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_RoleID",
                table: "Employee",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentHike_HikesListID",
                table: "EquipmentHike",
                column: "HikesListID");

            migrationBuilder.CreateIndex(
                name: "IX_Event_SchoolID",
                table: "Event",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Event_TypeEventID",
                table: "Event",
                column: "TypeEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Event_UserID",
                table: "Event",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Hike_RouteID",
                table: "Hike",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_PhoneNumber",
                table: "Instructor",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InstructorGroup_HikeID",
                table: "InstructorGroup",
                column: "HikeID");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorInstructorGroup_InstructorsListID",
                table: "InstructorInstructorGroup",
                column: "InstructorsListID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ApplicationTypeID",
                table: "Order",
                column: "ApplicationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_EmployeeID",
                table: "Order",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_HikeID",
                table: "Order",
                column: "HikeID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_InstructorID",
                table: "Order",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_RouteID",
                table: "Order",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_TouristGroupID",
                table: "Order",
                column: "TouristGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_TouristGroupID",
                table: "Participant",
                column: "TouristGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_UserID",
                table: "Participant",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Route_CheckpointFinishID",
                table: "Route",
                column: "CheckpointFinishID");

            migrationBuilder.CreateIndex(
                name: "IX_Route_CheckpointStartID",
                table: "Route",
                column: "CheckpointStartID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteHike_FinishBusID",
                table: "RouteHike",
                column: "FinishBusID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteHike_FinishCargoID",
                table: "RouteHike",
                column: "FinishCargoID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteHike_HikeID",
                table: "RouteHike",
                column: "HikeID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteHike_RouteID",
                table: "RouteHike",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteHike_StartBusID",
                table: "RouteHike",
                column: "StartBusID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteHike_StartCargoID",
                table: "RouteHike",
                column: "StartCargoID");

            migrationBuilder.CreateIndex(
                name: "IX_RoutePoint_CharterID",
                table: "RoutePoint",
                column: "CharterID");

            migrationBuilder.CreateIndex(
                name: "IX_TouristGroup_UserID",
                table: "TouristGroup",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_CarNumber",
                table: "Transport",
                column: "CarNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransportCompany_PhoneNumber",
                table: "TransportCompany",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_PhoneNumber",
                table: "User",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "CountableHikeEquipment");

            migrationBuilder.DropTable(
                name: "EquipmentHike");

            migrationBuilder.DropTable(
                name: "InstructorInstructorGroup");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Participant");

            migrationBuilder.DropTable(
                name: "RouteHike");

            migrationBuilder.DropTable(
                name: "RoutePoint");

            migrationBuilder.DropTable(
                name: "TransportCompany");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "CountableEquipment");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "InstructorGroup");

            migrationBuilder.DropTable(
                name: "ApplicationType");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "TouristGroup");

            migrationBuilder.DropTable(
                name: "Charter");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "TypeEvent");

            migrationBuilder.DropTable(
                name: "Hike");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "EventUser");

            migrationBuilder.DropTable(
                name: "Transport");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "CheckpointRoute");
        }
    }
}
