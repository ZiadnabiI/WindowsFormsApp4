Create database GYM
USE GYM;
GO

create table Customer(
Customer_id INT NOT NULL,
Customer_Name varchar(20) NOT NULL,
Customer_phone char(11) NOT NULL,
Customer_Gender char(1) NOT NULL,
Customer_email varchar(50),
primary Key(Customer_id)
)
create table Trainer(
Trainer_id int,
Trainer_Name varchar(20),
Trainer_Gender char(1),
Trainer_phone char(11),
Trainer_email varchar(50)
primary key(Trainer_id)

)
create table Staff(
Staff_id int NOT NULL,
Staff_Name varchar(20)NOT NULL,
Staff_gender char(1) NOT NULL,
Staff_phone char(11) NOT NULL,
primary key(Staff_id)
)
create table Employee(
Employee_id int NOT NULL,
Employee_Name varchar(20)NOT NULL,
Employee_gender char(1) NOT NULL,
Employee_phone char(11) NOT NULL,
primary key(Employee_id)
)
CREATE TABLE Booking (
    booking_id INT NOT NULL,
    booking_Start_date DATE NOT NULL,
    booking_end_date DATE NOT NULL,
    Customer_id INT,
    PRIMARY KEY (booking_id),
    FOREIGN KEY (Customer_id) REFERENCES Customer(Customer_id)
)
create table Payment(
Payment_id int NOT NULL,
Customer_id int NOT NULL,
Trainer_id int NOT NULL,
Amount DECIMAL(10,2),
Date DATE,	 
primary key(Payment_id),
foreign key(customer_id) references Customer(Customer_id),
foreign key(Trainer_id) references Trainer(Trainer_id)
)
CREATE TABLE Equipment(
Equipment_Type char(20),
Equipment_Number int NOT NULL,
Type VARCHAR(50),
Condition VARCHAR(50),
primary key(Equipment_Number)
)
create table Area(
Area_id int NOT NULL,
Area_Type VARCHAR(50),
staff_id int ,
trainer_id int ,
primary key(Area_id),
foreign key(staff_id) references staff(staff_id),
foreign key(trainer_id) references trainer(trainer_id)
)
create table workout(
workout_id int,
Area_id int,
Customer_id int,
payment_id int
primary key (workout_id),
FOREIGN KEY (Customer_id) REFERENCES Customer(Customer_id),
FOREIGN KEY (Area_id) REFERENCES Area(Area_id),
FOREIGN KEY (payment_id) REFERENCES payment(payment_id)
)
Create table GYM(
GYM_Name varchar(10),
GYM_Address varchar(50),
EMPLOYEE_ID INT,
Equipment_Number int,
Area_id int,
customer_id int,
primary key(GYM_id),
foreign key(EMPLOYEE_ID) references Employee,
foreign key(Equipment_Number) references Equipment,
foreign key(Area_id) references Area,
foreign key(customer_id) references Customer
)


Alter table employee add FOREIGN KEY (GYM_id) REFERENCES GYM(GYM_id)

Alter table Customer(
check value in ['m','f']
)
