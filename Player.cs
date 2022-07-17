// tracks player's case choice. handles player's deal or no deal choose to switch case with last one
// namespace Deal-Or-No-Deal


public class  Player : Cases{
    // public Cases c = new Cases();
    // constructor
    public Player() : base(){

    }

//Handle each round, prompts the user to pick a certain number of cases. 
//Stores those case numbers in a variable to be sent to the open case function.
//Increases round number and also decreases number of cases for each round.
    public void HandleRounds(){
        Banker banker = new Banker();

        round = this.round;
        
        int numberOfCaseToOpen = 6;
        // Console.WriteLine($"The list is in handle function: {c.gameValues.Count}");
        // c.OpenCase(4);
        while (round == 1){
            // Console.Clear();
            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} cases to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice);
            int totalValue = chosenCasesValue(returnedAmt);

            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){

                banker.GiveOffer(2, totalValue);
                DisplayCases();
                round += 1;

                // if (offerGiven == true){
                //     DisplayCases();
                //     round += 1;            

                // }
            }
        }

        numberOfCaseToOpen = 5;
        while (round == 2){

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} cases to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice);
            int totalValue = chosenCasesValue(returnedAmt);

            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){
                
                banker.GiveOffer(3, totalValue);
                DisplayCases();
                round += 1;
                // if (offerGiven == true){
                //     round += 1;            

                // }
            }        
        }

        numberOfCaseToOpen = 4;
        while (round == 3){

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} cases to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice);
            int totalValue = chosenCasesValue(returnedAmt);

            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){
                
                banker.GiveOffer(4, totalValue);
                DisplayCases();
                round += 1;           
            }        
        }

        numberOfCaseToOpen = 3;
        while (round == 4){

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} cases to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice);
            int totalValue = chosenCasesValue(returnedAmt);

            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){
                banker.GiveOffer(5, totalValue);
              
                DisplayCases();

                round += 1;             
            }        
        }

        numberOfCaseToOpen = 2;
        while (round == 5){

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} cases to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice);
            int totalValue = chosenCasesValue(returnedAmt);

            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){
                banker.GiveOffer(6, totalValue);
              
                DisplayCases();

                round += 1;             
            }        
        }
        numberOfCaseToOpen = 1;
        while (round == 6){

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} case to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice);
            int totalValue = chosenCasesValue(returnedAmt);
            numberOfCaseToOpen = numberOfCaseToOpen - 1;

            if (numberOfCaseToOpen == 0){
                banker.GiveOffer(round, totalValue);
              
                DisplayCases();

                round += 1; 
            }        
        }

        while (round == 7){
            numberOfCaseToOpen = 1;

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} case to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice);
            int totalValue = chosenCasesValue(returnedAmt);
            numberOfCaseToOpen = numberOfCaseToOpen - 1;

            if (numberOfCaseToOpen == 0){
                banker.GiveOffer(round, totalValue);
              
                DisplayCases();

                round += 1; 
            }        
        }

        while (round == 8){
            numberOfCaseToOpen = 1;

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} case to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice);
            int totalValue = chosenCasesValue(returnedAmt);
            
            numberOfCaseToOpen = numberOfCaseToOpen - 1;

            if (numberOfCaseToOpen == 0){
                banker.GiveOffer(round, totalValue);
              
                DisplayCases();

                round += 1; 
            }        
        }

        while (round == 9){
            numberOfCaseToOpen = 1;

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} case to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice);
            int totalValue = chosenCasesValue(returnedAmt);

            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){
                banker.GiveOffer(round, totalValue);
              
                DisplayCases();

                round += 1; 
            }        
        }

        playerCase = this.playerCase;

        while (round == 10) {
            Console.WriteLine("Type in the last case number");
            int lastCase = int.Parse(Console.ReadLine());
            Console.WriteLine("There is now only one case left. Would you like to keep you case or switch your case?");
            FinalDealorNo(playerCase, lastCase);

        }
        
    }


    public void FinalDealorNo(int player, int lastCase){
        Console.WriteLine("(1)keep (2)switch");
        int userChoice = int.Parse(Console.ReadLine());

        if (userChoice == 1){
            Console.WriteLine("Your case has..");
            OpenCase(player);
        } else {
            Console.WriteLine($"Case Number {lastCase} contains...");
            OpenCase(lastCase);
        }
        Console.WriteLine("Thanks for Playing!");
    }


}