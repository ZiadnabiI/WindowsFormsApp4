using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public static class DatabaseHelper
{
    private static string connectionString = @"Data Source=BORA3Y;Initial Catalog=GYM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

    // General method to insert data into any table
    public static void InsertIntoDatabase(string query, SqlParameter[] parameters)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add the parameters to the command
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting data: " + ex.Message);
            }
        }
    }

    // Insert Gym data into the GYM table
    public static void InsertGym(int gymId, string gymName)
    {
        string query = "INSERT INTO GYM (Gym_ID, Gym_Name) VALUES (@GymID, @GymName);";

        SqlParameter[] parameters = {
            new SqlParameter("@GymID", gymId),
            new SqlParameter("@GymName", gymName)
        };

        InsertIntoDatabase(query, parameters);
    }

    // Insert Member data into the Members table
    public static void InsertMember(string memberId, string gymId, string memberName, DateTime dob, string phone, string email)
    {
        string query = "INSERT INTO Members (Member_ID, Gym_ID, Member_Name, DOB, Phone_Number, Email) " +
                       "VALUES (@MemberID, @GymID, @MemberName, @DOB, @Phone, @Email);";

        SqlParameter[] parameters = {
            new SqlParameter("@MemberID", memberId),
            new SqlParameter("@GymID", gymId),
            new SqlParameter("@MemberName", memberName),
            new SqlParameter("@DOB", dob),
            new SqlParameter("@Phone", phone),
            new SqlParameter("@Email", email)
        };

        InsertIntoDatabase(query, parameters);
    }

    // Insert Trainer data into the Trainers table
    public static void InsertTrainer(string trainerId, string trainerName, string gymId, string phone, string email, decimal salary)
    {
        string query = "INSERT INTO Trainers (Trainer_ID, Trainer_Name, Gym_ID, Phone_Number, Email, Salary) " +
                       "VALUES (@TrainerID, @TrainerName, @GymID, @Phone, @Email, @Salary);";

        SqlParameter[] parameters = {
            new SqlParameter("@TrainerID", trainerId),
            new SqlParameter("@TrainerName", trainerName),
            new SqlParameter("@GymID", gymId),
            new SqlParameter("@Phone", phone),
            new SqlParameter("@Email", email),
            new SqlParameter("@Salary", salary)
        };

        InsertIntoDatabase(query, parameters);
    }

    // Insert Membership data into the Membership table
    public static void InsertMembership(string membershipId, string memberId, DateTime startDate, DateTime endDate, string membershipType)
    {
        string query = "INSERT INTO Membership (Membership_ID, Member_ID, Start_Date, End_Date, Membership_Type) " +
                       "VALUES (@MembershipID, @MemberID, @StartDate, @EndDate, @MembershipType);";

        SqlParameter[] parameters = {
            new SqlParameter("@MembershipID", membershipId),
            new SqlParameter("@MemberID", memberId),
            new SqlParameter("@StartDate", startDate),
            new SqlParameter("@EndDate", endDate),
            new SqlParameter("@MembershipType", membershipType)
        };

        InsertIntoDatabase(query, parameters);
    }

    // Insert Payment data into the Payments table
    public static void InsertPayment(string paymentId, string membershipId, decimal amount, DateTime paymentDate)
    {
        string query = "INSERT INTO Payments (Payment_ID, Membership_ID, Amount, Payment_Date) " +
                       "VALUES (@PaymentID, @MembershipID, @Amount, @PaymentDate);";

        SqlParameter[] parameters = {
            new SqlParameter("@PaymentID", paymentId),
            new SqlParameter("@MembershipID", membershipId),
            new SqlParameter("@Amount", amount),
            new SqlParameter("@PaymentDate", paymentDate)
        };

        InsertIntoDatabase(query, parameters);
    }

    // Insert Employee data into the Employees table
    public static void InsertEmployee(string employeeId, string employeeName, string gymId, string phone, string email, decimal salary, string role, DateTime hireDate)
    {
        string query = "INSERT INTO Employees (Employee_ID, Employee_Name, Gym_ID, Phone_Number, Email, Salary, Role, Hire_Date) " +
                       "VALUES (@EmployeeID, @EmployeeName, @GymID, @Phone, @Email, @Salary, @Role, @HireDate);";

        SqlParameter[] parameters = {
            new SqlParameter("@EmployeeID", employeeId),
            new SqlParameter("@EmployeeName", employeeName),
            new SqlParameter("@GymID", gymId),
            new SqlParameter("@Phone", phone),
            new SqlParameter("@Email", email),
            new SqlParameter("@Salary", salary),
            new SqlParameter("@Role", role),
            new SqlParameter("@HireDate", hireDate)
        };

        InsertIntoDatabase(query, parameters);
    }
}
