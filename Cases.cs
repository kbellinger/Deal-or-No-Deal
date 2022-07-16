// randomizes amounts into cases

public class Cases 
{
    public int round = 1;

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
 
    public List<int> caseNums = new List<int>()
    {
        1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26
    };

    public List<int> gameValues = new List<int>();

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
        for (int i = 0; i < amounts.length; i++){
            index = rand.Next(0,26);
            gameValues.Add(amounts[index]);
            Console.WriteLine(gameValues);
        }
        // Console.WriteLine(caseNums);
        // foreach(var c in caseNums){
        //    do { 
        //        int number = rand.Next(1,26);

        //    } while (caseNums.Contains(number));
        //     Console.WriteLine(this.amounts[number]);

        }

    // }

    //gives prompt to choose players case and then store it and remove from list.
    public void choosePCase(){

    }

    //takes value of chosen case values and adds them to the totalChosen amount and returns the value.
    public int chosenCasesValue(){
        return 0;
    }

    public void DisplayCases()
    {
        Console.WriteLine("\n -----      -----      -----      -----      -----      -----      -----          Money");
        Console.WriteLine($"|  {caseNums[0]}  |    |  {caseNums[1]}  |    |  {caseNums[2]}  |    |  {caseNums[3]}  |    |  {caseNums[4]}  |    |  {caseNums[5]}  |    |  {caseNums[6]}  |         {amounts[0]}         {amounts[13]}");
        Console.WriteLine($" -----      -----      -----      -----      -----      -----      -----          {amounts[1]}         {amounts[14]}");
        Console.WriteLine($"                                                                                  {amounts[2]}         {amounts[15]}");
        Console.WriteLine($"     -----      -----      ------      ------      ------      ------             {amounts[3]}        {amounts[16]}");
        Console.WriteLine($"    |  {caseNums[7]}  |    |  {caseNums[8]}  |    |  {caseNums[9]}  |    |  {caseNums[10]}  |    |  {caseNums[11]}  |    |  {caseNums[12]}  |            {amounts[4]}        {amounts[17]}");
        Console.WriteLine($"     -----      -----      ------      ------      ------      ------             {amounts[5]}        {amounts[18]}");
        Console.WriteLine($"                                                                                  {amounts[6]}        {amounts[19]}");
        Console.WriteLine($" ------     ------     ------     ------     ------     ------     ------         {amounts[7]}       {amounts[20]}");
        Console.WriteLine($"|  {caseNums[13]}  |   |  {caseNums[14]}  |   |  {caseNums[15]}  |   |  {caseNums[16]}  |   |  {caseNums[17]}  |   |  {caseNums[18]}  |   |  {caseNums[19]}  |        {amounts[8]}       {amounts[21]}");
        Console.WriteLine($" ------     ------     ------     ------     ------     ------     ------         {amounts[9]}       {amounts[22]}");
        Console.WriteLine($"                                                                                  {amounts[10]}       {amounts[23]}");
        Console.WriteLine($"     ------     ------     ------      ------      ------      ------             {amounts[11]}       {amounts[24]}");
        Console.WriteLine($"    |  {caseNums[20]}  |   |  {caseNums[21]}  |   |  {caseNums[22]}  |    |  {caseNums[23]}  |    |  {caseNums[24]}  |    |  {caseNums[25]}  |            {amounts[12]}       {amounts[25]}");
        Console.WriteLine($"     ------     ------     ------      ------      ------      ------           ");
    }

    //Displays what amount is inside the case and removes amount and case from their lists.
    public void OpenCase(int caseNumber, int caseAmnt)
    {

    }


}

//when player picks case number, pass through if statement and match with list. 
//what was selected subtract one and have that be the index then set that case number to nothing