namespace mis_221_pa_5_kanelang
{
    public class BookingReport
    {
        Booking[] bookings;

        public BookingReport(Booking[] bookings) {
            this.bookings = bookings;
        }

        public void PrintAllTransactions() {
            for(int i = 0; i < Booking.GetCount(); i++) {
                System.Console.WriteLine(bookings[i].ToString());
            }
        }
    }
}