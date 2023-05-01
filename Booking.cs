namespace mis_221_pa_5_kanelang
{
    public class Booking
    {
        private int sessionId;
        private string customerName;
        private string customerEmail;
        private string trainingDate;
        private int trainerId;
        private string trainerName;
        private string sessionStatus;

        static private int count;

        public Booking()   // no arg constructor
        {

        }

        public Booking(int sessionId, string customerName, string customerEmail, string trainingDate, int trainerId, string trainerName, string sessionStatus)  // constructor
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
            this.trainingDate = bookingData[3];
            this.trainerId = int.Parse(bookingData[4]);
            this.trainerName = bookingData[5];
            this.sessionStatus = bookingData[6];
        }

        // getters and setters:
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

        public void SetTrainingDate(string trainingDate)
        {
            this.trainingDate = trainingDate;
        }

        public string GetTrainingDate()
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

        public override string ToString()    // to string method
        {
            return $"SESSION ID:{this.sessionId}        CUSTOMER NAME:{this.customerName}       CUSTOMER EMAIL:{this.customerEmail}     TRAINING DATE:{this.trainingDate}       TRAINER ID:{this.trainerId}     TRAINER NAME:{this.trainerName}     SESSION STATUS:{this.sessionStatus}";
        }

        public string ToFile()    // file method
        {
            return $"{sessionId}#{customerName}#{customerEmail}#{trainingDate}#{trainerId}#{trainerName}#{sessionStatus}";
        }

        
    }
}
