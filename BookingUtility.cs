namespace mis_221_pa_5_kanelang
{
    public class BookingUtility
    {
        private Booking[] bookings;

        public BookingUtility(Booking[] bookings) {
            this.bookings = bookings;
        }
        

        public void ViewAvailableSessions()
        {
            System.Console.WriteLine("Enter R to return");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "r") {
            return;
            }
        }

        public void BookSession()
        {
            
        }

        public void UpdateSessionStatus()
        {
            
        }

        public void GetAllTransactionsFromFile() {
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