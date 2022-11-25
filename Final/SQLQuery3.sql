CREATE TABLE Customer(
Customer_ID INT PRIMARY KEY,
Fname VARCHAR(20) NOT NULL,
Lname VARCHAR(20) NOT NULL,
Mobile_Num INT,
Password VARCHAR(66) NOT NULL,
Salt VARCHAR(18) NOT NULL
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
