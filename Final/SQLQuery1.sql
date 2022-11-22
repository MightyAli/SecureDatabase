CREATE TABLE Student(
Student_ID INT PRIMARY KEY,
Fname VARCHAR(20) NOT NULL,
Lname VARCHAR(20) NOT NULL,
Password VARCHAR(20) NOT NULL
);

CREATE TABLE Course(
Course_Num INT,
Course_Name VARCHAR(20),
Credit_Hour INT,
Grade FLOAT,
Student_ID INT FOREIGN KEY REFERENCES Student(Student_ID)
);

INSERT INTO Student VALUES (1, 'Ali', 'Al-Ramadan', 12345);
INSERT INTO Student VALUES (2, 'Ahmed', 'Al-Ramadan', 54321);

INSERT INTO Course VALUES (123, 'Math', 3, 95,1);
INSERT INTO Course VALUES (456, 'CPP', 4, 80,1);