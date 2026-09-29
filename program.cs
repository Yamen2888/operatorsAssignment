using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Instantiate two objects of the Employee class and assign values to their properties.
            // Employee 1 creation
            Employee emp1 = new Employee()
            {
                Id = 101,
                FirstName = "John",
                LastName = "Doe"
            };

            // Employee 2 creation with the same ID but a different name to test ID-only comparison
            Employee emp2 = new Employee()
            {
                Id = 101,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Employee 3 creation with a completely different ID
            Employee emp3 = new Employee()
            {
                Id = 102,
                FirstName = "Alice",
                LastName = "Johnson"
            };

            // Compare emp1 and emp2 using the newly overloaded == operator
            Console.WriteLine("--- Testing Equality (Same IDs) ---");
            if (emp1 == emp2)
            {
                Console.WriteLine($"Employee 1 ({emp1.FirstName}) and Employee 2 ({emp2.FirstName}) are EQUAL because they share the same ID: {emp1.Id}");
            }
            else
            {
                Console.WriteLine("Employees are not equal.");
            }

            // Compare emp1 and emp3 using the newly overloaded != operator
            Console.WriteLine("\n--- Testing Inequality (Different IDs) ---");
            if (emp1 != emp3)
            {
                Console.WriteLine($"Employee 1 ({emp1.FirstName}, ID: {emp1.Id}) and Employee 3 ({emp3.FirstName}, ID: {emp3.Id}) are NOT EQUAL.");
            }
            else
            {
                Console.WriteLine("Employees are equal.");
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
