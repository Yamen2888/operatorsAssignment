using System;

namespace OperatorsAssignment
{
    // 1. Create an Employee class with Id, FirstName and LastName properties.
    public class Employee
    {
        // Properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // 2. Overload the "==" operator to check if two Employee objects are equal by comparing their Id properties.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Handle null checks first to prevent NullReferenceException
            if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
            {
                return true;
            }
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false;
            }

            // Compare the Id properties of both employees
            return employee1.Id == employee2.Id;
        }

        // Comparison operators must be overloaded in pairs (== and !=)
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // Reuses the == operator logic and negates it
            return !(employee1 == employee2);
        }

        // Overriding Equals() to match the overloaded == operator behavior
        public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        // Overriding GetHashCode() using the Id property as the unique identifier
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
