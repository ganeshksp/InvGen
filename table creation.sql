create table UserInfo(
id int primary key identity,
username nvarchar(25),
[password] nvarchar(25),
[Role] nvarchar(15),
IsActive bit)

create table CompanyInfo(
Id int primary key identity,
CompanyName nvarchar(100),
GSTINNO nvarchar(50),
CIN nvarchar(50),
Address1 nvarchar(100),
Address2 nvarchar(100),
Address3 nvarchar(100),
Address4 nvarchar(100),
Address5 nvarchar(100),
PinCode nvarchar(6),
[State] nvarchar(30)
)

create table BusinessPartners
(
BPid int primary key identity,
BPName nvarchar(100),
GSTINNO nvarchar(50),
CIN nvarchar(50),
Address1 nvarchar(100),
Address2 nvarchar(100),
Address3 nvarchar(100),
Address4 nvarchar(100),
Address5 nvarchar(100),
PinCode nvarchar(6),
[State] nvarchar(30),
IsActive bit
)

create table ShippingItem(
ItemId int primary key identity,
ItemName nvarchar(100),
HSNCode nvarchar(10),
UnitPrice money,
IsActive bit,
UOM nvarchar(12),
BPID int references BusinessPartners(BPid)
)

create table InvoiceDetails(
InvoiceNumber int primary key,
InvoiceDate datetime,
VehicleNumber nvarchar(20),
BilledTo int references BusinessPartners(BPid),
ItemId int references ShippingItem(itemid),
Quantity nvarchar(20),
BeforeTax money,
AfterTax money
)





