//Author: Brianna Ordaz
//Course: COMP003A
//Faculty: Jonathan Cruz
//Purpose: Budget management application demonstrating control flow.
namespace COMP003A.CodingAssignment3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Budget Management Tool!");
        Console.WriteLine("Enter your monthly income: ");
        int monthlyIncome = int.Parse(Console.ReadLine());
        
        
        int choice;
        int expenseAmount = 0;
        string expenseName = "";
        string nameExp;
        
        
        do
        {
            
            
            
            Console.WriteLine("Menu:");
            
            Console.WriteLine("1. Add an Expense");

            Console.WriteLine("2. View Expenses and Budget");

            Console.WriteLine("3. Remove an Expense");

            Console.WriteLine("4. Exit");

            Console.WriteLine("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            
            
            if (choice == 1)
            {

                Console.WriteLine("Enter the Expense name: ");
                expenseName = Console.ReadLine();

                Console.WriteLine("Enter the expense amount");
                expenseAmount = int.Parse(Console.ReadLine());

                Console.WriteLine("Expense added successfully!");

            }

            
            
            if (choice == 2)
            {
                
                    Console.WriteLine("Expenses: ");
                    
                    Console.WriteLine("-"+ expenseName + ": $" + expenseAmount);
                    
                    int budget = monthlyIncome - expenseAmount;
                    Console.WriteLine("Remaining Budget: $" + budget);
            }

            

            if (choice == 3)
            {
                Console.WriteLine("Enter the name of the expense to remove: ");
                string removeExp = Console.ReadLine();
                
                if (removeExp != expenseName)
                {
                    
                    Console.WriteLine("Expense Name does not match!");
                }
                else Console.WriteLine("Expense removed successfully!");
                
                
            }


            
            if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
            }


            
            
            try
            {
                if (choice < 1 || choice > 4) throw new Exception(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input, please choose 1-4!");
            }
            
            
        } while (choice != 4);

        
        
      
      


       


    }
}