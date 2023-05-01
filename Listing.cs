namespace mis_221_pa_5_kanelang
{
    public class Listing
    {
        private int listingId;
        private string trainerName;
        private int dateOfSession;
        private int timeOfSession;
        private int costOfSession;
        private string isListingTaken;

        static private int count;

        public Listing() {

        }

        public Listing(int listingId, string trainerName, int dateOfSession, int timeOfSession, string isListingTaken, int costOfSession) {
            this.listingId = listingId;
            this.trainerName = trainerName;
            this.dateOfSession = dateOfSession;
            this.timeOfSession = timeOfSession;
            this.isListingTaken = isListingTaken;
            this.costOfSession = costOfSession;
        }

        public void SetListingId(int listingId) {
            this.listingId = listingId;
        }

        public int GetListingId() {
            return listingId;
        }

        public void SetTrainerName(string trainerName) {
            this.trainerName = trainerName;
        }

        public string GetTrainerName() {
            return trainerName;
        }

        public void SetDateOfSession(int dateOfSession) {
            this.dateOfSession = dateOfSession;
        }

        public int GetDateOfSession() {
            return dateOfSession;
        }
        public void SetIsListingTaken(string isListingTaken) {
            this.isListingTaken = isListingTaken;        
        }
        public string GetIsListingTaken() {
            return isListingTaken;
        }

        public void SetCostOfSession(int costOfSession) {
            this.costOfSession = costOfSession;
        }

        public int GetCostOfSession() {
            return costOfSession;
        }

        public void SetTimeOfSession(int timeOfSession) {
            this.timeOfSession = timeOfSession;
        }

        public int GetTimeOfSession() {
            return timeOfSession;
        }

        static public void SetCount(int count) {
            Listing.count = count;
        }

        static public void IncCount() {
            Listing.count++;
        }

        static public int GetCount() {
            return Listing.count;
        }

        public override string ToString()
        {
            return $"{this.listingId} {this.trainerName} {this.dateOfSession} {this.timeOfSession} {this.costOfSession} {this.isListingTaken}";
        }

         public string ToFile()
        {
            return $"{listingId}#{trainerName}#{dateOfSession}#{timeOfSession}#{costOfSession}#{isListingTaken}";
        }
    }
}