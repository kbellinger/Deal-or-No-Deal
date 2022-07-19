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
    public void HandleRounds(int pCase, List<int> gameValues){
        Banker banker = new Banker(gameValues);

        round = this.round;
        
        int numberOfCaseToOpen = 6;
        // Console.WriteLine($"The list is in handle function: {c.gameValues.Count}");
        // c.OpenCase(4);
        while (round == 1){
            // Console.Clear();
            Console.WriteLine($"\nYOUR CASE: {pCase}");
            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} cases to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice, gameValues);
            int totalValue = chosenCasesValue(returnedAmt);

            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){

                banker.GiveOffer(2, totalValue, pCase, gameValues);
                DisplayCases();
                round += 1;

            }
        }

        numberOfCaseToOpen = 5;
        while (round == 2){

            Console.WriteLine($"\nYOUR CASE: {pCase}");
            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} cases to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice, gameValues);
            int totalValue = chosenCasesValue(returnedAmt);

            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){
                
                banker.GiveOffer(3, totalValue, pCase, gameValues);
                DisplayCases();
                round += 1;

            }        
        }

        numberOfCaseToOpen = 4;
        while (round == 3){

            Console.WriteLine($"\nYOUR CASE: {pCase}");
            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} cases to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice, gameValues);
            int totalValue = chosenCasesValue(returnedAmt);

            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){
                
                banker.GiveOffer(4, totalValue, pCase, gameValues);
                DisplayCases();
                round += 1;           
            }        
        }

        numberOfCaseToOpen = 3;
        while (round == 4){

            Console.WriteLine($"\nYOUR CASE: {pCase}");

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} cases to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice, gameValues);
            int totalValue = chosenCasesValue(returnedAmt);

            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){
                banker.GiveOffer(round, totalValue, pCase, gameValues);
              
                DisplayCases();

                round += 1;             
            }        
        }

        numberOfCaseToOpen = 2;
        while (round == 5){

            Console.WriteLine($"\nYOUR CASE: {pCase}");

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} cases to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice, gameValues);
            int totalValue = chosenCasesValue(returnedAmt);

            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){
                banker.GiveOffer(round, totalValue, pCase, gameValues);
              
                DisplayCases();

                round += 1;             
            }        
        }
        numberOfCaseToOpen = 1;
        while (round == 6){

            Console.WriteLine($"\nYOUR CASE: {pCase}");

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} case to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice, gameValues);
            int totalValue = chosenCasesValue(returnedAmt);
            numberOfCaseToOpen = numberOfCaseToOpen - 1;

            if (numberOfCaseToOpen == 0){
                banker.GiveOffer(round, totalValue, pCase, gameValues);
              
                DisplayCases();

                round += 1; 
            }        
        }

        while (round == 7){
            numberOfCaseToOpen = 1;
            Console.WriteLine($"\nYOUR CASE: {pCase}");

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} case to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice, gameValues);
            int totalValue = chosenCasesValue(returnedAmt);
            numberOfCaseToOpen = numberOfCaseToOpen - 1;

            if (numberOfCaseToOpen == 0){
                banker.GiveOffer(round, totalValue, pCase, gameValues);
              
                DisplayCases();

                round += 1; 
            }        
        }

        while (round == 8){
            numberOfCaseToOpen = 1;
            Console.WriteLine($"\nYOUR CASE: {pCase}");

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} case to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice, gameValues);
            int totalValue = chosenCasesValue(returnedAmt);
            
            numberOfCaseToOpen = numberOfCaseToOpen - 1;

            if (numberOfCaseToOpen == 0){
                banker.GiveOffer(round, totalValue, pCase, gameValues);
              
                DisplayCases();

                round += 1; 
            }        
        }

        while (round == 9){
            numberOfCaseToOpen = 1;
            Console.WriteLine($"\nYOUR CASE: {pCase}");

            Console.WriteLine($"\nRound {round} \nYou may now choose {numberOfCaseToOpen} case to open");
            Console.Write("Pick a case: ");
            int userChoice = int.Parse(Console.ReadLine());
            int returnedAmt = OpenCase(userChoice, gameValues);
            int totalValue = chosenCasesValue(returnedAmt);

            numberOfCaseToOpen = numberOfCaseToOpen - 1;
            if (numberOfCaseToOpen == 0){
                banker.GiveOffer(round, totalValue,pCase, gameValues);
              
                DisplayCases();

                round += 1; 
            }        
        }

        playerCase = this.playerCase;

        while (round == 10) {
            Console.WriteLine($"\nYOUR CASE: {pCase}");

            Console.WriteLine("\nType in the last case number");
            int lastCase = int.Parse(Console.ReadLine());
            Console.WriteLine("There is now only one case left. Would you like to keep you case or switch your case?");
            FinalDealorNo(pCase, lastCase, gameValues);

        }
        
    }


    public void FinalDealorNo(int player, int lastCase, List<int> gameValuesList){
        Console.WriteLine("(1)keep (2)switch");
        int userChoice = int.Parse(Console.ReadLine());

        if (userChoice == 1){
            Console.WriteLine("Your case has..");
            Thread.Sleep(2000);
            Console.WriteLine($"${gameValuesList[player - 1]}!");
            Thread.Sleep(2000);
            Console.WriteLine("Congratulations! \nThanks for playing!");
            Thread.Sleep(3000);
            Environment.Exit(0);

        } else {
            Console.WriteLine($"Case Number {lastCase} contains...");
            Thread.Sleep(2000);
            Console.WriteLine($"${gameValuesList[lastCase - 1]}!");
            Console.WriteLine("Congratulations! \nThanks for playing!");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }
        Console.WriteLine("Thanks for Playing!");
    }


}