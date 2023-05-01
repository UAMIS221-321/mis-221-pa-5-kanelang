namespace mis_221_pa_5_kanelang
{
    public class Listing
    {
        private int listingId;
        private string trainerName;
        private string dateOfSession;
        private string timeOfSession;
        private string costOfSession;
        private string isListingTaken;

        static private int count;

        public Listing() {

        }

        public Listing(int listingId, string trainerName, string dateOfSession, string timeOfSession, string costOfSession, string isListingTaken) {
            this.listingId = listingId;
            this.trainerName = trainerName;
            this.dateOfSession = dateOfSession;
            this.timeOfSession = timeOfSession;
            this.costOfSession = costOfSession;
            this.isListingTaken = isListingTaken;
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

        public void SetDateOfSession(string dateOfSession) {
            this.dateOfSession = dateOfSession;
        }

        public string GetDateOfSession() {
            return dateOfSession;
        }
        public void SetTimeOfSession(string timeOfSession) {
            this.timeOfSession = timeOfSession;        
        }
        public string GetTimeOfSession() {
            return timeOfSession;
        }
        public void SetCostOfSession(string costOfSession) {
            this.costOfSession = costOfSession;        
        }
        public string GetCostOfSession() {
            return costOfSession;
        }
        public void SetIsListingTaken(string isListingTaken) {
            this.isListingTaken = isListingTaken;        
        }
        public string GetIsListingTaken() {
            return isListingTaken;
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
            return $"LISTING ID:{this.listingId}        TRAINER NAME:{this.trainerName}     DATE OF SESSION:{this.dateOfSession}        TIME OF SESSION:{this.timeOfSession}        COST OF SESSION:{this.costOfSession}        IS LISTING TAKEN:{this.isListingTaken} ";
        }

         public string ToFile()
        {
            return $"{listingId}#{trainerName}#{dateOfSession}#{timeOfSession}#{costOfSession}#{isListingTaken}";
        }
    }
}