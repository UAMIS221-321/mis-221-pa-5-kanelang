namespace mis_221_pa_5_kanelang
{
    public class Booking
    {
        private int sessionId;
        private string customerName;
        private string customerEmail;
        private int trainingDate;
        private int trainerId;
        private string trainerName;
        private string sessionStatus;

        static private int count;

        public Booking()
        {

        }

        public Booking(int sessionId, string customerName, string customerEmail, int trainingDate, int trainerId, string trainerName, string sessionStatus)
        {
            this.sessionId = sessionId;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.trainingDate = trainingDate;
            this.trainerId = trainerId;
            this.trainerName = trainerName;
            this.sessionStatus = sessionStatus;
        }

        public Booking(string[] bookingData)
        {
            this.sessionId = int.Parse(bookingData[0]);
            this.customerName = bookingData[1];
            this.customerEmail = bookingData[2];
            this.trainingDate = int.Parse(bookingData[3]);
            this.trainerId = int.Parse(bookingData[4]);
            this.trainerName = bookingData[5];
            this.sessionStatus = bookingData[6];
        }

        public void SetSessionId(int sessionId)
        {
            this.sessionId = sessionId;
        }

        public int GetSessionId()
        {
            return sessionId;
        }

        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public void SetCustomerEmail(string customerEmail)
        {
            this.customerEmail = customerEmail;
        }

        public string GetCustomerEmail()
        {
            return customerEmail;
        }

        public void SetTrainingDate(int trainingDate)
        {
            this.trainingDate = trainingDate;
        }

        public int GetTrainingDate()
        {
            return trainingDate;
        }

        public void SetTrainerId(int trainerId)
        {
            this.trainerId = trainerId;
        }

        public int GetTrainerId()
        {
            return trainerId;
        }

        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName;
        }

        public string GetTrainerName()
        {
            return trainerName;
        }

        public void SetSessionStatus(string sessionStatus)
        {
            this.sessionStatus = sessionStatus;
        }

        public string GetSessionStatus()
        {
            return sessionStatus;
        }

        static public void SetCount(int count)
        {
            Booking.count = count;
        }

        static public void IncCount()
        {
            Booking.count++;
        }

        static public int GetCount()
        {
            return Booking.count;
        }

        public override string ToString()
        {
            return $"{this.sessionId}{this.customerName}{this.customerEmail}{this.trainingDate}{this.trainerId}{this.trainerName}{this.sessionStatus}";
        }

        public string ToFile()
        {
            return $"{sessionId}#{customerName}#{customerEmail}#{trainingDate}#{trainerId}#{trainerName}#{sessionStatus}";
        }
    }
}