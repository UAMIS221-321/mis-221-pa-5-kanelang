namespace mis_221_pa_5_kanelang
{
    public class ListingReport
    {
        Listing[] listings;

        public ListingReport(Listing[] listings) {
            this.listings = listings;
        }

        public void PrintAllListings() {
            for(int i = 0; i < Listing.GetCount(); i++) {
                System.Console.WriteLine(listings[i].ToString());
            }
        }
    }
}