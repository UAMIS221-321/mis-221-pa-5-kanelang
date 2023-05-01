
using mis_221_pa_5_kanelang;


public class Program{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Trainer[] trainers = new Trainer[100];
        Listing[] listings = new Listing[100];
        Booking[] bookings = new Booking[100];
        Report[] reports = new Report[100];

        TrainerUtility trainerUtility = new TrainerUtility(trainers);
        ListingUtility listingUtility = new ListingUtility(listings);


        // Main menu loop
        while (true)
        {
            Console.Clear();
            // Display menu
            string title = @"
╔╗╔╗╔╗    ╔╗                      ╔╗         ╔════╗                  ╔╗     ╔╗      
║║║║║║    ║║                     ╔╝╚╗        ║╔╗╔╗║                  ║║     ║║      
║║║║║║╔══╗║║ ╔══╗╔══╗╔╗╔╗╔══╗    ╚╗╔╝╔══╗    ╚╝║║╚╝╔═╗╔══╗ ╔╗╔═╗     ║║   ╔╗║║╔╗╔══╗
║╚╝╚╝║║╔╗║║║ ║╔═╝║╔╗║║╚╝║║╔╗║     ║║ ║╔╗║      ║║  ║╔╝╚ ╗║ ╠╣║╔╗╗    ║║ ╔╗╠╣║╚╝╝║╔╗║
╚╗╔╗╔╝║║═╣║╚╗║╚═╗║╚╝║║║║║║║═╣     ║╚╗║╚╝║     ╔╝╚╗ ║║ ║╚╝╚╗║║║║║║    ║╚═╝║║║║╔╗╗║║═╣
 ╚╝╚╝ ╚══╝╚═╝╚══╝╚══╝╚╩╩╝╚══╝     ╚═╝╚══╝     ╚══╝ ╚╝ ╚═══╝╚╝╚╝╚╝    ╚═══╝╚╝╚╝╚╝╚══╝
         ╔═══╗╔╗                             ╔═══╗                        ╔╗      ╔═══╗   ╔╗                 ╔╗
         ║╔═╗║║║                             ║╔═╗║                        ║║      ║╔══╝  ╔╝╚╗                ║║
╔══╗     ║║ ╚╝║╚═╗╔══╗ ╔╗╔╗╔══╗╔╗╔══╗╔═╗     ║╚═╝║╔══╗╔═╗╔══╗╔══╗╔═╗ ╔══╗ ║║      ║╚══╗╔╗╚╗╔╝╔═╗ ╔══╗╔══╗╔══╗║║
╚ ╗║     ║║ ╔╗║╔╗║╚ ╗║ ║╚╝║║╔╗║╠╣║╔╗║║╔╗╗    ║╔══╝║╔╗║║╔╝║══╣║╔╗║║╔╗╗╚ ╗║ ║║      ║╔══╝╠╣ ║║ ║╔╗╗║╔╗║║══╣║══╣╚╝
║╚╝╚╗    ║╚═╝║║║║║║╚╝╚╗║║║║║╚╝║║║║╚╝║║║║║    ║║   ║║═╣║║ ╠══║║╚╝║║║║║║╚╝╚╗║╚╗    ╔╝╚╗  ║║ ║╚╗║║║║║║═╣╠══║╠══║╔╗
╚═══╝    ╚═══╝╚╝╚╝╚═══╝╚╩╩╝║╔═╝╚╝╚══╝╚╝╚╝    ╚╝   ╚══╝╚╝ ╚══╝╚══╝╚╝╚╝╚═══╝╚═╝    ╚══╝  ╚╝ ╚═╝╚╝╚╝╚══╝╚══╝╚══╝╚╝
                           ║║                                                                                  
                           ╚╝                                                                                  
";
            System.Console.WriteLine(title);
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("Please select one of the options below:");
            System.Console.WriteLine("1. Manage Trainer Data");
            System.Console.WriteLine("2. Manage Listing Data");
            System.Console.WriteLine("3. Manage Customer Booking Data");
            System.Console.WriteLine("4. Run Reports");
            System.Console.WriteLine("5. Exit The Application");
            System.Console.WriteLine("===============================================");

            // Get user choice
            System.Console.Write("Enter your choice (1-5): ");
            string userInput = Console.ReadLine();

            // Process user choice
            switch (userInput) 
            {
                case "1":
                System.Console.WriteLine("Manage trainer data selected.");
                ManageTrainerData(trainers);
                break;
                

                case "2":
                System.Console.WriteLine("Manage listing data selected.");
                ManageListingData(listings);
                break;
                        
                case "3":
                System.Console.WriteLine("Manage customer booking data selected.");
                ManageBookingData(bookings);
                break;
                        
                // case "4":
                // Console.WriteLine("Run reports selected.");
                // RunReports(reports, bookings, listings, trainers);
                // break;
                        
                case "5":
                System.Console.WriteLine("Exiting application...");
                return;
                        
                default:
                System.Console.WriteLine("Invalid input. Please try again.");
                break;

            }
        }
    }


    static void ManageTrainerData(Trainer[] trainers)
    {
        TrainerUtility trainerUtility = new TrainerUtility(trainers);
        TrainerReport trainerReport = new TrainerReport(trainers);

        while (true)
        {
            // Display trainer menu
            Console.Clear();
            string title = @"
╔═╗╔═╗                          ╔════╗                         ╔═══╗      ╔╗      
║║╚╝║║                          ║╔╗╔╗║                         ╚╗╔╗║     ╔╝╚╗     
║╔╗╔╗║╔══╗ ╔═╗ ╔══╗ ╔══╗╔══╗    ╚╝║║╚╝╔═╗╔══╗ ╔╗╔═╗ ╔══╗╔═╗     ║║║║╔══╗ ╚╗╔╝╔══╗ 
║║║║║║╚ ╗║ ║╔╗╗╚ ╗║ ║╔╗║║╔╗║      ║║  ║╔╝╚ ╗║ ╠╣║╔╗╗║╔╗║║╔╝     ║║║║╚ ╗║  ║║ ╚ ╗║ 
║║║║║║║╚╝╚╗║║║║║╚╝╚╗║╚╝║║║═╣     ╔╝╚╗ ║║ ║╚╝╚╗║║║║║║║║═╣║║     ╔╝╚╝║║╚╝╚╗ ║╚╗║╚╝╚╗
╚╝╚╝╚╝╚═══╝╚╝╚╝╚═══╝╚═╗║╚══╝     ╚══╝ ╚╝ ╚═══╝╚╝╚╝╚╝╚══╝╚╝     ╚═══╝╚═══╝ ╚═╝╚═══╝
                    ╔═╝║                                                          
                    ╚══╝                                                          
";
            System.Console.WriteLine(title);
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("Please select one of the options below:");
            System.Console.WriteLine("1. Add a New Trainer");
            System.Console.WriteLine("2. Edit an Existing Trainer");
            System.Console.WriteLine("3. Delete a Trainer");
            System.Console.WriteLine("4. Return to Main Menu");
            System.Console.WriteLine("===============================================");

            // Get user choice
            System.Console.Write("Enter your choice (1-4): ");
            string userInput = Console.ReadLine();

            // Process user choice
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    title = @"
╔═══╗  ╔╗  ╔╗    ╔═╗ ╔╗              ╔════╗                        
║╔═╗║  ║║  ║║    ║║╚╗║║              ║╔╗╔╗║                        
║║ ║║╔═╝║╔═╝║    ║╔╗╚╝║╔══╗╔╗╔╗╔╗    ╚╝║║╚╝╔═╗╔══╗ ╔╗╔═╗ ╔══╗╔═╗╔═╗
║╚═╝║║╔╗║║╔╗║    ║║╚╗║║║╔╗║║╚╝╚╝║      ║║  ║╔╝╚ ╗║ ╠╣║╔╗╗║╔╗║║╔╝╚═╝
║╔═╗║║╚╝║║╚╝║    ║║ ║║║║║═╣╚╗╔╗╔╝     ╔╝╚╗ ║║ ║╚╝╚╗║║║║║║║║═╣║║ ╔═╗
╚╝ ╚╝╚══╝╚══╝    ╚╝ ╚═╝╚══╝ ╚╝╚╝      ╚══╝ ╚╝ ╚═══╝╚╝╚╝╚╝╚══╝╚╝ ╚═╝
                                                                   
                                                                   
";                  
                    System.Console.WriteLine(title);
                    System.Console.WriteLine("Current Trainers:");
                    System.Console.WriteLine("==========================================================================================================================================================================================");
                    trainerUtility.GetAllTrainersFromFile();
                    trainerReport.PrintAllTrainers();
                    trainerUtility.AddTrainer();
                    trainerReport.PrintAllTrainers();
                    break;

                case "2":
                    Console.Clear();
                    title = @"
╔═══╗  ╔╗   ╔╗     ╔════╗                        
║╔══╝  ║║  ╔╝╚╗    ║╔╗╔╗║                        
║╚══╗╔═╝║╔╗╚╗╔╝    ╚╝║║╚╝╔═╗╔══╗ ╔╗╔═╗ ╔══╗╔═╗╔═╗
║╔══╝║╔╗║╠╣ ║║       ║║  ║╔╝╚ ╗║ ╠╣║╔╗╗║╔╗║║╔╝╚═╝
║╚══╗║╚╝║║║ ║╚╗     ╔╝╚╗ ║║ ║╚╝╚╗║║║║║║║║═╣║║ ╔═╗
╚═══╝╚══╝╚╝ ╚═╝     ╚══╝ ╚╝ ╚═══╝╚╝╚╝╚╝╚══╝╚╝ ╚═╝
                                                 
                                                 
";
                    System.Console.WriteLine(title);
                    System.Console.WriteLine("Current Trainers:");
                    System.Console.WriteLine("==========================================================================================================================================================================================");
                    trainerUtility.GetAllTrainersFromFile();
                    trainerReport.PrintAllTrainers();
                    trainerUtility.EditTrainer();
                    trainerReport.PrintAllTrainers();
                    break;

                case "3":
                    Console.Clear();
                    System.Console.WriteLine("Deleting a trainer...");
                    trainerUtility.GetAllTrainersFromFile();
                    trainerReport.PrintAllTrainers();
                    // trainerUtility.DeleteTrainer();
                    trainerReport.PrintAllTrainers();
                    break;

                case "4":
                    System.Console.WriteLine("Returning to main menu...");
                    return;

                default:
                    System.Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }

    static void ManageListingData(Listing[] listings)
{
    ListingUtility listingUtility = new ListingUtility(listings);
    ListingReport listingReport = new ListingReport(listings);

    while (true)
    {
        // Display sub-menu
        Console.Clear();
        string title = @"
╔═╗╔═╗                          ╔╗          ╔╗               ╔═══╗      ╔╗      
║║╚╝║║                          ║║         ╔╝╚╗              ╚╗╔╗║     ╔╝╚╗     
║╔╗╔╗║╔══╗ ╔═╗ ╔══╗ ╔══╗╔══╗    ║║   ╔╗╔══╗╚╗╔╝╔╗╔═╗ ╔══╗     ║║║║╔══╗ ╚╗╔╝╔══╗ 
║║║║║║╚ ╗║ ║╔╗╗╚ ╗║ ║╔╗║║╔╗║    ║║ ╔╗╠╣║══╣ ║║ ╠╣║╔╗╗║╔╗║     ║║║║╚ ╗║  ║║ ╚ ╗║ 
║║║║║║║╚╝╚╗║║║║║╚╝╚╗║╚╝║║║═╣    ║╚═╝║║║╠══║ ║╚╗║║║║║║║╚╝║    ╔╝╚╝║║╚╝╚╗ ║╚╗║╚╝╚╗
╚╝╚╝╚╝╚═══╝╚╝╚╝╚═══╝╚═╗║╚══╝    ╚═══╝╚╝╚══╝ ╚═╝╚╝╚╝╚╝╚═╗║    ╚═══╝╚═══╝ ╚═╝╚═══╝
                    ╔═╝║                             ╔═╝║                       
                    ╚══╝                             ╚══╝                       
";
        System.Console.WriteLine(title);
        System.Console.WriteLine("===================");
        System.Console.WriteLine("Please select one of the options below:");
        System.Console.WriteLine("1. Add a new listing");
        System.Console.WriteLine("2. Edit an existing listing");
        System.Console.WriteLine("3. Delete a listing");
        System.Console.WriteLine("4. Return to main menu");
        System.Console.WriteLine("===================");

        // Get user choice
        System.Console.Write("Enter your choice (1-5): ");
        string userInput = Console.ReadLine();

        // Process user choice
        switch (userInput)
        {
            case "1":
                System.Console.WriteLine("Add a new listing");
                listingUtility.GetAllListingsFromFile();
                listingReport.PrintAllListings();
                listingUtility.AddListing();
                listingReport.PrintAllListings();
                break;

            case "2":
                System.Console.WriteLine("Edit an existing listing");
                listingUtility.GetAllListingsFromFile();
                listingReport.PrintAllListings();
                listingUtility.EditListing();
                listingReport.PrintAllListings();
                break;

            case "3":
                System.Console.WriteLine("Delete a listing");
                listingUtility.GetAllListingsFromFile();
                listingReport.PrintAllListings();
                listingUtility.DeleteListing();
                listingReport.PrintAllListings();
                break;

            case "4":
                System.Console.WriteLine("Returning to main menu...");
                return;

            default:
                System.Console.WriteLine("Invalid input. Please try again.");
                break;
        }
    }
}             

static void ManageBookingData(Booking[] bookings)
    {
       BookingUtility bookingUtility = new BookingUtility(bookings);

    while (true)
    {
        // Display sub-menu
        Console.Clear();
        string title = @"
╔═╗╔═╗                          ╔═══╗         ╔╗                
║║╚╝║║                          ║╔═╗║        ╔╝╚╗               
║╔╗╔╗║╔══╗ ╔═╗ ╔══╗ ╔══╗╔══╗    ║║ ╚╝╔╗╔╗╔══╗╚╗╔╝╔══╗╔╗╔╗╔══╗╔═╗
║║║║║║╚ ╗║ ║╔╗╗╚ ╗║ ║╔╗║║╔╗║    ║║ ╔╗║║║║║══╣ ║║ ║╔╗║║╚╝║║╔╗║║╔╝
║║║║║║║╚╝╚╗║║║║║╚╝╚╗║╚╝║║║═╣    ║╚═╝║║╚╝║╠══║ ║╚╗║╚╝║║║║║║║═╣║║ 
╚╝╚╝╚╝╚═══╝╚╝╚╝╚═══╝╚═╗║╚══╝    ╚═══╝╚══╝╚══╝ ╚═╝╚══╝╚╩╩╝╚══╝╚╝ 
                    ╔═╝║                                        
                    ╚══╝                                        
╔══╗         ╔╗                ╔═══╗      ╔╗      
║╔╗║         ║║                ╚╗╔╗║     ╔╝╚╗     
║╚╝╚╗╔══╗╔══╗║║╔╗╔╗╔═╗ ╔══╗     ║║║║╔══╗ ╚╗╔╝╔══╗ 
║╔═╗║║╔╗║║╔╗║║╚╝╝╠╣║╔╗╗║╔╗║     ║║║║╚ ╗║  ║║ ╚ ╗║ 
║╚═╝║║╚╝║║╚╝║║╔╗╗║║║║║║║╚╝║    ╔╝╚╝║║╚╝╚╗ ║╚╗║╚╝╚╗
╚═══╝╚══╝╚══╝╚╝╚╝╚╝╚╝╚╝╚═╗║    ╚═══╝╚═══╝ ╚═╝╚═══╝
                       ╔═╝║                       
                       ╚══╝                       
";
        System.Console.WriteLine(title);
        System.Console.WriteLine("===========================");
        System.Console.WriteLine("Please select one of the options below:");
        System.Console.WriteLine("1. View Training Sessions");
        System.Console.WriteLine("2. Book a training session");
        System.Console.WriteLine("3. List all bookings");
        System.Console.WriteLine("4. Return to main menu");
        System.Console.WriteLine("===========================");

        // Get user choice
        System.Console.Write("Enter your choice (1-4): ");
        string userInput = Console.ReadLine();

        // Process user choice
        switch (userInput)
        {
            case "1":
                System.Console.WriteLine("Training Sessions:");
                bookingUtility.GetAllTransactionsFromFile();
                break;

            case "2":
                System.Console.WriteLine("Book a training session:");
                bookingUtility.BookSession();
                break;

            case "3":
                System.Console.WriteLine("Current Bookings:");
                bookingUtility.ViewAvailableSessions();
                break;

            case "4":
                System.Console.WriteLine("Returning to main menu...");
                return;

            default:
                System.Console.WriteLine("Invalid input. Please try again.");
                break;
        }
    }
}


static void RunReports(Report[] reports)
{
    while (true)
    {
        // Display sub-menu
        Console.Clear();
        string title = @"
╔═══╗            ╔═══╗                ╔╗     
║╔═╗║            ║╔═╗║               ╔╝╚╗    
║╚═╝║╔╗╔╗╔═╗     ║╚═╝║╔══╗╔══╗╔══╗╔═╗╚╗╔╝╔══╗
║╔╗╔╝║║║║║╔╗╗    ║╔╗╔╝║╔╗║║╔╗║║╔╗║║╔╝ ║║ ║══╣
║║║╚╗║╚╝║║║║║    ║║║╚╗║║═╣║╚╝║║╚╝║║║  ║╚╗╠══║
╚╝╚═╝╚══╝╚╝╚╝    ╚╝╚═╝╚══╝║╔═╝╚══╝╚╝  ╚═╝╚══╝
                          ║║                 
                          ╚╝                 
";
        System.Console.WriteLine(title);
        System.Console.WriteLine("===========");
        System.Console.WriteLine("Please select one of the options below:");
        System.Console.WriteLine("1. Trainer utilization report");
        System.Console.WriteLine("2. Listing occupancy report");
        System.Console.WriteLine("3. Return to main menu");
        System.Console.WriteLine("===========");

        // Get user choice
        System.Console.Write("Enter your choice (1-3): ");
        string userInput = Console.ReadLine();

        // Process user choice
        switch (userInput)
        {
            case "1":
                System.Console.WriteLine("Trainer utilization report");
                
                break;

            case "2":
                System.Console.WriteLine("Listing occupancy report");
                
                break;

            case "3":
                System.Console.WriteLine("Returning to main menu...");

                return;

            default:
                System.Console.WriteLine("Invalid input. Please try again.");

                break;
        }
    }
}
}





