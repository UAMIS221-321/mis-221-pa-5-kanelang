namespace mis_221_pa_5_kanelang
{
    public class TrainerUtility
    {
        private Trainer[] trainers;

        public TrainerUtility(Trainer[] trainers) {
            this.trainers = trainers;
        }
        public void AddTrainer() {   // Add a Trainer
            System.Console.WriteLine("Please enter the Trainer's name:");
            Trainer myTrainer = new Trainer();
            myTrainer.SetTrainerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the Trainer's Email Address:");
            myTrainer.SetTrainerEmailAddress(Console.ReadLine());
            System.Console.WriteLine("Please enter the trainer's ID number:");
            myTrainer.SetTrainerId(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the Trainer's Mailing Address:");
            myTrainer.SetMailingAddress(Console.ReadLine());
            
            trainers[Trainer.GetCount()] = myTrainer;
            Trainer.IncCount();

            Save();
        }

        private void Save() {   // Save method
            StreamWriter outFile = new StreamWriter("trainers.txt");

            for(int i = 0; i < Trainer.GetCount(); i++) {
                outFile.WriteLine(trainers[i].ToFile());
            }

            outFile.Close();

        }

        public void DeleteTrainer()   // delete a trainer
        {
            System.Console.WriteLine("Enter the ID of the Trainer you would like to Delete:");
            int searchVal = int.Parse(Console.ReadLine());
            int foundIndex = Find(searchVal);

            if(foundIndex != -1){
                trainers[foundIndex].Delete();
                Save();
            }
            else{
                System.Console.WriteLine("The Trainer ID is invalid");
            }
        }

        public void EditTrainer()   // edit a trainer
        {
            // Get trainer ID from user
            Console.Write("Enter the ID of the trainer to edit: ");
            int id = int.Parse(Console.ReadLine());

            // Find the trainer with the specified ID
            int index = -1;
            for (int i = 0; i < Trainer.GetCount(); i++)
            {
                if (trainers[i].GetTrainerId() == id)
                {
                    index = i;
                    break;
                }
            }

            // If the trainer was found, edit their details
            if (index != -1)
            {
                Console.WriteLine("Editing trainer with ID: " + id);
                Console.WriteLine("Enter new details:");

                // Get new trainer details from user
                string trainerName = null;
                while (trainerName == null)
                {
                    Console.Write("Trainer Name: ");
                    trainerName = Console.ReadLine();
                }
                string trainerEmailAddress = null;
                while (trainerEmailAddress == null)
                {
                    Console.Write("Trainer Email Address: ");
                    trainerEmailAddress = Console.ReadLine();
                }
                string mailingAddress = null;
                while (mailingAddress == null)
                {
                    Console.Write("Trainer Mailing Address: ");
                    mailingAddress = Console.ReadLine();
                }

                // Update trainer details
                trainers[index].SetTrainerName(trainerName);
                trainers[index].SetTrainerEmailAddress(trainerEmailAddress);
                trainers[index].SetMailingAddress(mailingAddress);

                // Save changes
                Save();
            }
            else
            {
                Console.WriteLine("Trainer with ID " + id + " not found.");
            }
        }



        public void GetAllTrainersFromFile() {   // get trainers from file
            StreamReader inFile = new StreamReader("trainers.txt");

            Trainer.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null) {
                string[] temp = line.Split('#');
                trainers[Trainer.GetCount()] = new Trainer(int.Parse(temp[0]), temp[1], temp[2], temp[3], bool.Parse(temp[4]));
                Trainer.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
        }

        public int Find(int searchVal){    // find method
            for(int i =0; i < Trainer.GetCount(); i++){
                if(trainers[i].GetTrainerId() == searchVal){
                    return i;
                }
            }
            return -1;
        }

        public int Find(string searchVal){
            for(int i =0; i < Trainer.GetCount(); i++){
                if(trainers[i].GetTrainerName() == searchVal){
                    return i;
                }
            }
            return -1;
        }

        
    }

}
