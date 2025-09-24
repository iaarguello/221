int userChoice = 0;

//main menu
while (userChoice != 3)
{
    System.Console.WriteLine("Welcome!");
    System.Console.WriteLine("1 - Compass");
    System.Console.WriteLine("2 - Fee Calculator");
    System.Console.WriteLine("3 - Exit");

    string input = Console.ReadLine();

    if (int.TryParse(input, out userChoice))
    {
        if (userChoice == 1)
        {
            System.Console.WriteLine("BUILD THE COMPASS FUNCTION");
        }
        else if (userChoice == 2)
        {
            FeeCalculator();
        }
        else if (userChoice == 3)
        {

        }
        else
        {
            System.Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");  //error codes
        }
    }
    else
    {
        System.Console.WriteLine("Please enter a valid number.");
    }
}












//fee calc
static void FeeCalculator()
{
    int rate = 0;
    int rvRate = 35;
    int other = 12;
    int userChoice = 0;
    int partySize = 0;
    int childTickets = 0;

    int ticketRate = 15;
    double childTicketRate = 11.25;

    double totalFee = 0;
    double totalAmountDue = 0;
    double amountPaid = 0;

    System.Console.WriteLine("Welcome to the park fee calculator.");
    System.Console.WriteLine("Enter 1 if you are driving an RV, enter 2 if you are in any other vehicle.");
    
    //calc menu
    while (userChoice != 3)
    {
        System.Console.WriteLine("\n1 - RV");
        System.Console.WriteLine("2 - Other Vehicle");
        System.Console.WriteLine("3 - Exit");
        System.Console.Write("Enter choice: ");

        string input = Console.ReadLine();

        if (int.TryParse(input, out userChoice))
        {
            if (userChoice == 1 || userChoice == 2)
            {

                if (userChoice == 1)
                {
                    rate = rvRate;
                }
                else
                {
                    rate = other;
                }

                System.Console.Write("Enter party size: ");
                partySize = int.Parse(Console.ReadLine());

                System.Console.Write("Enter number of child tickets: ");
                childTickets = int.Parse(Console.ReadLine());

                int numAdultTickets = partySize - childTickets;


                totalFee = rate;


                if (partySize >= 6)
                {
                    totalFee += 6;
                }


                totalFee += (numAdultTickets * ticketRate) + (childTickets * childTicketRate);


                totalAmountDue = totalFee * 1.07;


                System.Console.WriteLine($"Your total amount due is ${totalAmountDue:F2}.");


                System.Console.Write("Enter amount paid: ");
                amountPaid = double.Parse(Console.ReadLine());

                if (amountPaid == totalAmountDue)
                {
                    System.Console.WriteLine("Payment accepted. Thank you!");
                }
                else
                {
                    System.Console.WriteLine("Error: Amount paid does not equal the total due.");
                }
            }
            else if (userChoice == 3)
            {
                System.Console.WriteLine("Exiting program...");
            }
            else
            {
                System.Console.WriteLine("Invalid choice, try again.");
            }
        }
        else
        {
            System.Console.WriteLine("Please enter a valid number.");
        }
    }
}

//yes i will be at office hours help