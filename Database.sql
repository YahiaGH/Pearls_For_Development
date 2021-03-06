create database Pearls_For_Development_Test
go
-- Name for the charity we making the desktop application for.
-- Remove "Test" after everything is OKAY. I have used it to test only before final version.
-- i think all values should be "not null" we could check this out.
-- BRANCH will not be composite key with all  entities iw will be a regular attribute >??
use Pearls_For_Development_Test

create table Branch
(-- for all locations we could have ..
الفروع nvarchar(10) not null, 
primary key(الفروع),
);

create table Mothers
(
الرقم_القومي int not null check(الرقم_القومي > 9999999999999), -- > ex: more than 14 numbers ..
الاسم nvarchar(20) not null,
العنوان nvarchar(30) not null,
عدد_الاطفال int not null , 
الفرع nvarchar(10) not null, -- > for each branch of the charity.
primary key(الرقم_القومي),
foreign key (الفرع) references Branch
ON update cascade on delete cascade -- as if the branch closed there won't be any kids or mothers.
);

create table Kids
(
هوية_شخصية int not null check(هوية_شخصية > 1000),
 -- > ex: ID -- we can make the name as primary key ?? .....
الاسم nvarchar(20) not null,
تاريخ_الميلاد date not null,
اسم_الام nvarchar(20), -- >> should we store it ..??
الرقم_القومي_الام int check(الرقم_القومي_الام > 9999999999999) default(null),
اسم_المدرسة nvarchar(20) not null,
السنة_الدراسية nvarchar(20) not null, -- ex: الاول الاعدادي
العنوان nvarchar(30) not null,
رقم_الهاتف int not null check(رقم_الهاتف > 9999999), -- > ??
نتيجة_العام_الماضي nvarchar(4) not null, -- > ex: 100%
الفرع nvarchar(10) not null, -- > for each branch of the charity.
primary key(هوية_شخصية),
foreign key (الرقم_القومي_الام) references Mothers
ON update cascade on delete set default, -- check this ?? ..
foreign key (الفرع) references Branch
ON update no action on delete no action, -- as if the branch closed there won't be any kids or mothers.
-- on delete set null ?? i think the mother can leave the charity but her kid could stay ??.
);

create table Attendence
(
هوية_شخصية int not null check(هوية_شخصية > 1000),
التاريخ date not null,
الفرع nvarchar(10) not null, -- > for each branch of the charity.
primary key(التاريخ,هوية_شخصية),
foreign key (هوية_شخصية) references Kids
ON update no action on delete no action,-- as if kids leave the charity we don't care about attendence.
foreign key (الفرع) references Branch
ON update cascade on delete cascade -- as if the branch closed there won't be any kids or mothers.
);


create table DailyReport
(
الفرع nvarchar(10) not null, -- > for each branch of the charity.
السنة_الدراسية nvarchar(20) not null, -- ex: GRADE >> الاول الاعدادي
اسم_المشرف nvarchar(20) not null,
حضور_المشرف nvarchar(5) not null, -->> i made it nvar to be easier than time .. then we could form our representation of time ex: 00:00 5 chars.
انصراف_المشرف nvarchar(5) not null, -->> i made it nvar to be easier than time .. then we could form our representation of time ex: 00:00 5 chars.
اسم_المدرس nvarchar(20) not null, -- >> instructor and teacher wont have and entity as planned...
حضور_المدرس nvarchar(5) not null, -->> i made it nvar to be easier than time .. then we could form our representation of time ex: 00:00 5 chars.
انصراف_المدرس nvarchar(5) not null, -->> i made it nvar to be easier than time .. then we could form our representation of time ex: 00:00 5 chars.
عدد_الاولاد int not null,
عدد_البنات int not null, -- >> total number .. Boys + Girls will be calculated ??.
التاريخ date not null,
المنهج nvarchar(40) not null, --
ملاحظات nvarchar(40) not null, -- > for each branch of the charity.
primary key(التاريخ,الفرع,السنة_الدراسية),
foreign key (الفرع) references Branch
ON update cascade on delete cascade, -- as if the branch closed there won't be any kids or mothers.
);

--- >> check this table ..
create table WeeklyReport
(
الفرع nvarchar(10) not null, -- > for each branch of the charity.
السنة_الدراسية nvarchar(20) not null, -- ex: GRADE >> الاول الاعدادي
تاريخ_اول_الاسبوع date not null,
المنهج nvarchar(40) not null, --
ملاحظات nvarchar(40) not null, -- > for each branch of the charity.
primary key(تاريخ_اول_الاسبوع,الفرع,السنة_الدراسية),
foreign key (الفرع) references Branch
ON update cascade on delete cascade, -- as if the branch closed there won't be any kids or mothers.
);

create table Users
(
اسم_المستخدم nvarchar(15) not null,
كلمة_السر nvarchar(10) not null,
الاولوية nvarchar(8) not null, -- we have two types only.
Unique (اسم_المستخدم),
primary key(اسم_المستخدم)
);

--->> if you found a problem,first tell the team then just delete the whole database 
-- then modify what you want (datatype,keys,parameters,conditions,.etc).
-- then run the script again and commit it in SVC.
--->> besides MVC Architecture, we could use singleton pattern in all our forms. we will have 3 classes (Model,Procedures,Controller) any extras ??. 
--->> nvarchar can be used to write information and rows in arabic langauge.
--->> Send Me Notes and Modifications (if Needed) Version 1.01 