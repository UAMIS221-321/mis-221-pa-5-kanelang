namespace mis_221_pa_5_kanelang
{
    public class ListingUtility
    {
        private Listing[] listings;

        public ListingUtility(Listing[] listings) {
            this.listings = listings;
        }
        public void AddListing() {    // add a listing
            System.Console.WriteLine("Please enter the Listing ID:");
            Listing myListing = new Listing();
            myListing.SetListingId(int.Parse(Console.ReadLine()));

            System.Console.WriteLine("Please enter the Trainer's Name:");
            myListing.SetTrainerName(Console.ReadLine());

            System.Console.WriteLine("Please enter the Date of the Session:");
            myListing.SetDateOfSession(Console.ReadLine());

            System.Console.WriteLine("Please enter the Time of the Session:");
            myListing.SetTimeOfSession(Console.ReadLine());

            System.Console.WriteLine("Please enter the Cost of the Session:");
            myListing.SetCostOfSession(Console.ReadLine());

            System.Console.WriteLine("Please Enter if the Listing is Booked or Open:");
            myListing.SetIsListingTaken(Console.ReadLine());
            
            listings[Listing.GetCount()] = myListing;
            Listing.IncCount();

            SaveListings();
        }

        private void SaveListings() {      // save method
            StreamWriter outFile = new StreamWriter("listings.txt");

            for(int i = 0; i < Listing.GetCount(); i++) {
                outFile.WriteLine(listings[i].ToFile());
            }

            outFile.Close();

        }

        public void DeleteListing()       // delete a listing
        {
            System.Console.WriteLine("Enter the ID of the Listing you would like to Delete:");
            int searchVal = int.Parse(Console.ReadLine());
            int foundIndex = Find(searchVal);

            if(foundIndex != -1){
                listings[foundIndex].Delete();
                SaveListings();
            }
            else{
                System.Console.WriteLine("The Listing ID is invalid");
            }
        }

        public int Find(int searchVal){     // find method
            for(int i =0; i < Listing.GetCount(); i++){
                if(listings[i].GetListingId() == searchVal){
                    return i;
                }
            }
            return -1;
        }

       

        public void EditListing()     // edit a listing
        {
            // Get trainer ID from user
            Console.Write("Enter the ID of the trainer to edit: ");
            int id = int.Parse(Console.ReadLine());

            // Find the trainer with the specified ID
            int index = -1;
            for (int i = 0; i < Listing.GetCount(); i++)
            {
                if (listings[i].GetListingId() == id)
                {
                    index = i;
                    break;
                }
            }

            // If the trainer was found, edit their details
            if (index != -1)
            {
                Console.WriteLine("Editing trainer with ID: " + id);
                Console.WriteLine("Enter new details:");

                // Get new trainer details from user
                Console.Write("Listing ID: ");
                int listingId = int.Parse(Console.ReadLine());
                
                Console.Write("Date of the Session: ");
                string dateOfSession = Console.ReadLine();
                Console.Write("Time of Session: ");
                string timeOfSession = Console.ReadLine();
                Console.Write("Cost of Session ");
                string costOfSession = Console.ReadLine();
                

                string trainerName = null;
                while (trainerName == null)
                    {
                        Console.Write("Trainer Name: ");
                        trainerName = Console.ReadLine();
                    }
                string isListingTaken = null;
                while (isListingTaken == null)
                {
                    Console.Write("Is Listing Taken: ");
                    isListingTaken = Console.ReadLine();
                }


                // Update trainer details
                listings[index].SetListingId(listingId);
                listings[index].SetTrainerName(trainerName);
                listings[index].SetDateOfSession(dateOfSession);
                listings[index].SetTimeOfSession(timeOfSession);
                listings[index].SetCostOfSession(costOfSession);
                listings[index].SetIsListingTaken(isListingTaken);

                // Save changes
                SaveListings();
            }
            else
            {
                Console.WriteLine("Listing with ID " + id + " not found.");
            }
        }

        public void GetAllListingsFromFile() {     // get listings from listings file
            StreamReader listingFile = new StreamReader("listings.txt");

            Listing.SetCount(0);
            string line = listingFile.ReadLine();
            while(line != null) {
                string[] temp = line.Split('#');
                listings[Listing.GetCount()] = new Listing(int.Parse(temp[0]), temp[1], temp[2], temp[3], temp[4], temp[5], bool.Parse(temp[6]));
                Listing.IncCount();
                line = listingFile.ReadLine();
            }
            listingFile.Close();
        }

    }
}

