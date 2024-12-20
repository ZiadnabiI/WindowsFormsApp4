use GYM
go
-- Insert sample data into Customer table
INSERT INTO Customer (Customer_id, Customer_Name, Customer_phone, Customer_Gender, Customer_email)
VALUES
(1, 'John Doe', '01234567890', 'M', 'john@example.com'),
(2, 'Jane Smith', '09876543210', 'F', 'jane@example.com');

-- Insert sample data into Trainer table
INSERT INTO Trainer (Trainer_id, Trainer_Name, Trainer_Gender, Trainer_phone, Trainer_email)
VALUES
(1, 'Mike Tyson', 'M', '02345678901', 'mike@trainer.com'),
(2, 'Sarah Johnson', 'F', '09876543211', 'sarah@trainer.com');

-- Insert sample data into Staff table
INSERT INTO Staff (Staff_id, Staff_Name, Staff_gender, Staff_phone)
VALUES
(1, 'Alice Brown', 'F', '01239876543'),
(2, 'Bob White', 'M', '01122334455');

-- Insert sample data into Employee table
INSERT INTO Employee (Employee_id, Employee_Name, Employee_gender, Employee_phone)
VALUES
(1, 'Charlie Green', 'M', '01237648592'),
(2, 'Debbie Black', 'F', '01938475639');

-- Insert sample data into Equipment table
INSERT INTO Equipment (E_Type, Number, Type, Condition)
VALUES
('Treadmill', 10, 'Cardio', 'Good'),
('Dumbbell', 5, 'Strength', 'Fair');

-- Insert sample data into Area table
INSERT INTO Area (Area_id, Area_Type, staff_id, trainer_id)
VALUES
(1, 'Cardio', 1, 1),
(2, 'Strength', 2, 2);

-- Insert sample data into Booking table
INSERT INTO Booking (booking_id, booking_Start_date, booking_end_date, Customer_id)
VALUES
(1, '2024-11-01', '2024-11-07', 1),
(2, '2024-11-05', '2024-11-10', 2);

-- Insert sample data into Payment table
INSERT INTO Payment (Payment_id, Customer_id, Trainer_id, Amount, Date)
VALUES
(1, 1, 1, 50.00, '2024-11-01'),
(2, 2, 2, 75.00, '2024-11-05');

-- Insert sample data into Workout table
INSERT INTO Workout (workout_id, Area_id, Customer_id, payment_id)
VALUES
(1, 1, 1, 1),
(2, 2, 2, 2);

-- Insert sample data into GTM table
INSERT INTO GYM(GYM_Name,GYM_Address)
VALUES
('MONSTER','GYM ADDRESS'),
('Hero GYM','GYM ADDRESS');
