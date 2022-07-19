// randomizes amounts into cases

public class Cases 
{
    public int totalChosenAmt = 0;
    public int playerCase;
    public int round = 1;
    public bool offerGiven = false;


    public List<int> amounts = new List<int>()
    {
        1, 
        2,
        5,
        10, 
        25, 
        50, 
        75, 
        100, 
        200, 
        300, 
        400, 
        500, 
        750, 
        1000, 
        5000, 
        10000, 
        25000, 
        50000, 
        75000, 
        100000, 
        200000, 
        300000, 
        400000, 
        500000, 
        750000, 
        1000000
    };
 
    public List<string> caseNums = new List<string>()
    {
        " 1 "," 2 "," 3 "," 4 "," 5 "," 6 "," 7 "," 8 "," 9 "," 10"," 11"," 12"," 13"," 14"," 15"," 16"," 17"," 18"," 19"," 20"," 21"," 22"," 23"," 24"," 25"," 26"
    };

    public List<int> gameValues = new List<int>(){
        // 300000,
        // 500,
        // 2,
        // 750,
        // 1000,
        // 300,
        // 200,
        // 25,
        // 100000,
        // 400,
        // 75,
        // 5,
        // 50000,
        // 10000,
        // 5000,
        // 1,
        // 10,
        // 750000,
        // 75000,
        // 400000,
        // 1000000,
        // 500000,
        // 50,
        // 25000,
        // 200000,
        // 100
    };

    public Cases()
    {

    }


//assign each case a random value from list of amounts
//
//selects random numbers from 1-26, uses that as an index to select 
//an amount from the amounts list and assign that amount to a new list 
//with the new index to creat our hidden case values
    public void RandomizeCases()
    {

        Random rand = new Random();
        int index;
        while( gameValues.Count < 26){
            for (int i = 0; i < amounts.Count; i++){
                index = rand.Next(0,amounts.Count);
                if (!gameValues.Contains(amounts[index])){
                gameValues.Add(amounts[index]);
                
                }
            }
        }
        // gameValues.ForEach(Console.WriteLine);
    }


    //gives prompt to choose players case and then store it and edit the list.
    public void choosePCase(){

        // string filler;
        Console.WriteLine("\nYou will now get to select your case.\nThis will be your case until the end of the game.");
        Console.Write("\nPick your case: ");
        this.playerCase = playerCase;
        playerCase = int.Parse(Console.ReadLine());
        // if (playerCase < 9){
        //     filler = "***";
        // } else {
        //     filler = "**";
        // }
        caseNums = this.caseNums;
        caseNums[playerCase - 1] = "***";       
        // caseNums = caseNums;

        Console.WriteLine($"You chose case number {playerCase}");
        Thread.Sleep(2000);
        DisplayCases();

    }

    //takes value of chosen case values and adds them to the totalChosen amount and returns the value.
    public int chosenCasesValue(int totalChosenValue){
        totalChosenValue = this.totalChosenAmt;
        totalChosenValue += totalChosenValue;
        return totalChosenValue;
    }

    public void DisplayCases()
    {
        Console.WriteLine("\n -----      -----      -----      -----      -----      -----      -----          Money");
        Console.WriteLine($"| {caseNums[0]} |    | {caseNums[1]} |    | {caseNums[2]} |    | {caseNums[3]} |    | {caseNums[4]} |    | {caseNums[5]} |    | {caseNums[6]} |         {amounts[0]}         {amounts[13]}");
        Console.WriteLine($" -----      -----      -----      -----      -----      -----      -----          {amounts[1]}         {amounts[14]}");
        Console.WriteLine($"                                                                                  {amounts[2]}         {amounts[15]}");
        Console.WriteLine($"     -----      -----      ------      ------      ------      ------             {amounts[3]}        {amounts[16]}");
        Console.WriteLine($"    | {caseNums[7]} |    | {caseNums[8]} |    | {caseNums[9]}  |    | {caseNums[10]}  |    | {caseNums[11]}  |    | {caseNums[12]}  |            {amounts[4]}        {amounts[17]}");
        Console.WriteLine($"     -----      -----      ------      ------      ------      ------             {amounts[5]}        {amounts[18]}");
        Console.WriteLine($"                                                                                  {amounts[6]}        {amounts[19]}");
        Console.WriteLine($" ------     ------     ------     ------     ------     ------     ------         {amounts[7]}       {amounts[20]}");
        Console.WriteLine($"| {caseNums[13]}  |   | {caseNums[14]}  |   | {caseNums[15]}  |   | {caseNums[16]}  |   | {caseNums[17]}  |   | {caseNums[18]}  |   | {caseNums[19]}  |        {amounts[8]}       {amounts[21]}");
        Console.WriteLine($" ------     ------     ------     ------     ------     ------     ------         {amounts[9]}       {amounts[22]}");
        Console.WriteLine($"                                                                                  {amounts[10]}       {amounts[23]}");
        Console.WriteLine($"     ------     ------     ------      ------      ------      ------             {amounts[11]}       {amounts[24]}");
        Console.WriteLine($"    | {caseNums[20]}  |   | {caseNums[21]}  |   | {caseNums[22]}  |    | {caseNums[23]}  |    | {caseNums[24]}  |    | {caseNums[25]}  |            {amounts[12]}       {amounts[25]}");
        Console.WriteLine($"     ------     ------     ------      ------      ------      ------           ");
    }

    //Displays what amount is inside the case and removes amount and case from their lists.
    public int OpenCase(int caseNumber, List<int> gameValuesList)
    {

        int caseNumberIndex = caseNumber - 1;
        int value = gameValuesList[caseNumberIndex];

        Console.WriteLine($"Opening case number {caseNumber} in...");
        Thread.Sleep(500);
        Console.WriteLine("3");
        Thread.Sleep(500);
        Console.WriteLine("2");
        Thread.Sleep(500);
        Console.WriteLine("1");
        Thread.Sleep(500);
        Console.WriteLine($"\nCase number {caseNumber} has {gameValuesList[caseNumberIndex]}");
        Thread.Sleep(2000);


        //removing the value from the list and blanking out the case. then displaying new board to repeat.
        caseNums[caseNumberIndex] = "   ";


        //replaces the amount with 0 so they don't show on game board any more
        int newIndex = amounts.FindIndex(n => n == value);
        if (newIndex != -1){
            amounts[newIndex] = 0;
        }
        amounts = amounts;

        DisplayCases();
        
        return value;
        
    }


}
//for total chosen amount, take index of gamevalue that is equal with 
//chosen case and set it equal to variable named value and send to ChosenCaseValue function.
//when player picks case number, pass through if statement and match with list. 
//what was selected subtract one and have that be the index then set that case number to nothing