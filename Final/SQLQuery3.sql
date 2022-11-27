CREATE TABLE Customer(
Customer_ID BIGINT PRIMARY KEY,
Email VARCHAR(102) NOT NULL,
Fname VARCHAR(102) NOT NULL,
Lname VARCHAR(102) NOT NULL,
Mobile_Num VARCHAR(102) NOT NULL,
Password VARCHAR(130) NOT NULL,
Salt VARCHAR(18) NOT NULL,
);

CREATE TABLE CD(
CD_ID INT PRIMARY KEY NOT NULL,
Movie_Name VARCHAR(50) NOT NULL,
Unit_Price FLOAT NOT NULL,
);


CREATE TABLE OrderT(
Customer_ID BIGINT FOREIGN KEY REFERENCES Customer(Customer_ID) NOT NULL,
Movie_Name VARCHAR(50) NOT NULL,
Order_Quantity INT NOT NULL,
Order_Date DATETIME NOT NULL,
Total_Price FLOAT NOT NULL,
);
