

CREATE TABLE alithe2 (
a int not null primary key,
);

CREATE TABLE alithe (
b int,
foreign key(b) references alithe2(a) on update cascade on delete cascade,
);

insert into alithe(b) values (4);
insert into alithe2(a) values (4);
select a from alithe2 where a = 4;



CREATE TABLE Customer(
Customer_ID INT PRIMARY KEY,
Fname VARCHAR(20) NOT NULL,
Lname VARCHAR(20) NOT NULL,
Mobile_Num INT,
Password VARCHAR(10) NOT NULL
);

CREATE TABLE CD(
CD_ID INT PRIMARY KEY,
Movie_Name VARCHAR(20) NOT NULL,
Unit_Price FLOAT,
Quantity INT
);


CREATE TABLE OrderT(
Customer_ID INT FOREIGN KEY REFERENCES Customer(Customer_ID),
CD_ID INT FOREIGN KEY REFERENCES CD(CD_ID),
Order_Quantity INT,
Order_date datetime
);

SELECT CD.CD_ID, Order_Quantity, Order_date, Unit_Price ,Movie_Name
FROM CD  , OrderT , Customer
WHERE CD.CD_ID = OrderT.CD_ID AND Customer.Customer_ID = OrderT.Customer_ID
ORDER BY Customer.Customer_ID