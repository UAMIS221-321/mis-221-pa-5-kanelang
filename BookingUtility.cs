namespace mis_221_pa_5_kanelang
{
    public class BookingUtility
    {
        private Booking[] bookings;

        public BookingUtility(Booking[] bookings) {
            this.bookings = bookings;
        }

        public int GetNextSessionId() {     // get next id
            int maxSessionId = 0;
            foreach (Booking booking in bookings) {
                if (booking != null && booking.GetSessionId() > maxSessionId) {
                    maxSessionId = booking.GetSessionId();
                }
            }
            return maxSessionId + 1;
        }
        

        public void ViewAvailableSessions()    // view the current sessions
        {
            System.Console.WriteLine("Enter R to return");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "r") {
            return;
            }
        }

        public void BookSession()     // book a new session
        {
            Console.WriteLine("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter customer email: ");
            string customerEmail = Console.ReadLine();

            Console.WriteLine("Enter training date (dd/mm/yyyy): ");
            string trainingDate = Console.ReadLine();

            Console.WriteLine("Enter trainer ID: ");
            int trainerId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter trainer name: ");
            string trainerName = Console.ReadLine();

            string sessionStatus = "Booked";

            int sessionId = GetNextSessionId();
            Booking booking = new Booking(sessionId, customerName, customerEmail, trainingDate, trainerId, trainerName, sessionStatus);
            Array.Resize(ref bookings, bookings.Length + 1);
            bookings[bookings.Length - 1] = booking;

            Console.WriteLine($"Session {sessionId} has been booked for {customerName} on {trainingDate}.");
        }

        public void UpdateSessionStatus()      // update session status
        {
            Console.WriteLine("Enter session ID to update: ");
            int sessionId = int.Parse(Console.ReadLine());
            

            bool sessionFound = false;
            foreach (Booking booking in bookings)
            {
                if (booking.GetSessionId() == sessionId)
                {
                    Console.WriteLine("Enter new session status (Booked, Attended, Cancelled, Rescheduled): ");
                    string newStatus = Console.ReadLine();

                    booking.SetSessionStatus(newStatus);
                    Console.WriteLine($"Session {sessionId} status updated to {newStatus}.");
                    sessionFound = true;
                    break;
                }
            }

            if (!sessionFound)
            {
                Console.WriteLine($"Session {sessionId} not found.");
            }
            

            SaveBookings();
        }

        private void SaveBookings() {    // save method
            StreamWriter outFile = new StreamWriter("transactions.txt");

            for(int i = 0; i < Booking.GetCount(); i++) {
                outFile.WriteLine(bookings[i].ToFile());
            }

            outFile.Close();

        }


        

        public void GetAllTransactionsFromFile() {     // get transactions from file
            StreamReader inFile = new StreamReader("transactions.txt");

            Booking.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null) {
                string[] temp = line.Split('#');
                bookings[Booking.GetCount()] = new Booking(int.Parse(temp[0]), temp[1], temp[2], temp[3], int.Parse(temp[4]), temp[5], temp[6]);
                Booking.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
        }

        


    }
}