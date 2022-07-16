// tracks player's case choice. handles player's deal or no deal choose to switch case with last one

public class  Player : Cases {


    // constructor
    public Player(){

    }

//Handle each round, prompts the user to pick a certain number of cases. 
//Stores those case numbers in a variable to be sent to the open case function.
//Increases round number and also decreases number of cases for each round.
    public void HandleRounds(){
        int numberOfCaseToOpen = 6;

        while (round == 1){
            Console.WriteLine($"Round 1 \nYou may now choose {numberOfCaseToOpen} cases to open");
            Console.WriteLine("Pick a case: ");
            int caseNumber = int.Parse(Console.ReadLine());
            OpenCase(9);
            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){
                round = 2;
            }
        }

        
    }


    public string DealOrNo(){
        return "";
    }


}