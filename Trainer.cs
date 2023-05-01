namespace mis_221_pa_5_kanelang
{
    public class Trainer
    {
        private int trainerId;
        private string trainerName;
        private string mailingAddress;
        private string trainerEmailAddress;
        private bool isDeleted;

        static private int count;

        public Trainer() {   // no arg constructor

        }

        public Trainer(int trainerId, string trainerName, string mailingAddress, string trainerEmailAddress, bool isDeleted) {  // constructor
            this.trainerId = trainerId;
            this.trainerName = trainerName;
            this.mailingAddress = mailingAddress;
            this.trainerEmailAddress = trainerEmailAddress;
            this.isDeleted = isDeleted;
        }
        
        // getters and setters:
        public void SetTrainerId(int trainerId) {
            this.trainerId = trainerId;
        }

        public int GetTrainerId() {
            return trainerId;
        }

        public void SetTrainerName(string trainerName) {
            this.trainerName = trainerName;
        }

        public string GetTrainerName() {
            return trainerName;
        }

        public void SetMailingAddress(string mailingAddress) {
            this.mailingAddress = mailingAddress;
        }

        public string GetMailingAddress() {
            return mailingAddress;
        }
        public void SetTrainerEmailAddress(string trainerEmailAddress) {
            this.trainerEmailAddress = trainerEmailAddress;        
        }
        public string GetTrainerEmailAddress() {
            return trainerEmailAddress;
        }
        public void SetIsDeleted(bool isDeleted){
            this.isDeleted = isDeleted;
        }
        public bool GetIsDeleted(){
            return isDeleted;
        }

        static public void SetCount(int count) {
            Trainer.count = count;
        }

        static public void IncCount() {
            Trainer.count++;
        }

        static public int GetCount() {
            return Trainer.count;
        }

        public override string ToString()  // to string method
        {
            return $"TRAINER ID: {this.trainerId}       TRAINER EMAIL:{this.trainerEmailAddress}        TRAINER NAME:{this.trainerName}         TRAINER ADDRESS:{this.mailingAddress}       Is Deleted:{this.isDeleted}";
        }

         public string ToFile()    // file method
        {
            return $"{trainerId}#{trainerName}#{mailingAddress}#{trainerEmailAddress}#{isDeleted}";
        }

        public void Delete(){      // delete method
            isDeleted = !isDeleted;
        }

        
    }
    }








        