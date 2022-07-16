// gives offer every turn
public class Banker : Cases
{

    //constructor
    public Banker(){

    }

    // first turn eliminates 6 cases. second turn eliminates 5, 
    //and so on until turn 6 then it is only 1 case elimination til the end of round 9.
    // total is 3418418 . subtract by selected amounts and it will be new total amounts
    //then divide by remaining cases then mutliply by percentage 
    //amount which will start at 0.6 and increment by 0.1
    public void GiveOffer(int round, int totalChosenAmt){
        int totalGameAmt = 3418418;

        round = this.round;
        if (round == 2){
            // 6 cases have been opened so toal number of cases is now 20
            double formula = (((totalGameAmt - totalChosenAmt) / 20 ) * 0.6);
            double offer = Math.Round(formula, 0);
            Console.WriteLine($"The Bank offers you ${offer}");
        }
        // else if (round == 3){
        //     // 5 cases have been opened
        //     int offer = Math.Round(((totalGameAmt - totalChosenAmt) / 15 ) * 0.7);
        //     Console.WriteLine($"The Bank offers you ${offer}");            
        // }
        // else if (round == 4){
        //     // 4 cases have been opened
        //     int offer = Math.Round(((totalGameAmt - totalChosenAmt) / 11 ) * 0.75);
        //     Console.WriteLine($"The Bank offers you ${offer}");            
        // }
        // else if (round == 5){
        //     // 3 cases have been opened
        //     int offer = Math.Round(((totalGameAmt - totalChosenAmt) / 8 ) * 0.8);
        //     Console.WriteLine($"The Bank offers you ${offer}");
        // }
        // else if (round == 6){
        //     // 2 cases have been opened
        //     int offer = Math.Round(((totalGameAmt - totalChosenAmt) / 6 ) * 0.85);
        //     Console.WriteLine($"The Bank offers you ${offer}");
        // }
        // else if (round == 7){
        //     // 1 case has been opened
        //     int offer = Math.Round(((totalGameAmt - totalChosenAmt) / 5 ) * 0.9);
        //     Console.WriteLine($"The Bank offers you ${offer}");
        // }
        // else if (round == 8){
        //     // 1 case has been opened
        //     int offer = Math.Round(((totalGameAmt - totalChosenAmt) / 4 ) * 0.9);
        //     Console.WriteLine($"The Bank offers you ${offer}");
        // }
        // else if (round == 9){
        //     // 1 case has been opened
        //     int offer = Math.Round(((totalGameAmt - totalChosenAmt) / 3 ) * 0.9);
        //     Console.WriteLine($"The Bank offers you ${offer}");
        // }
        else if(round == 10){
            // there is just the players chosen case and on hidden case left. 
            //Player now gets to choose to either keep chosen case or switch to other case.
            Console.WriteLine("There is now only one case left. Would you like to keep you case or switch your case?");
            
        }
            
    }

    public void FinalDealorNo(){
        Console.WriteLine("(1)keep (2)switch");
        int userChoice = int.Parse(Console.ReadLine());

        if (userChoice == 1){

        }
    }


}