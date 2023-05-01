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

        public Trainer() {

        }

        public Trainer(int trainerId, string trainerName, string mailingAddress, string trainerEmailAddress) {
            this.trainerId = trainerId;
            this.trainerName = trainerName;
            this.mailingAddress = mailingAddress;
            this.trainerEmailAddress = trainerEmailAddress;
        }

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

        public override string ToString()
        {
            return $"TRAINER ID: {this.trainerId}       TRAINER EMAIL:{this.trainerEmailAddress}        TRAINER NAME:{this.trainerName}         TRAINER ADDRESS:{this.mailingAddress}";
        }

         public string ToFile()
        {
            return $"{trainerId}#{trainerName}#{mailingAddress}#{trainerEmailAddress}";
        }

        public void Delete(){
            isDeleted = !isDeleted;
        }

        
    }
    }








        