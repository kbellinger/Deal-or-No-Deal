Cases c = new Cases();
Player p = new Player();
Banker b = new Banker();
// c.RandomizeCases(); // temporarily out of commission
c.DisplayCases();
int playerChoice = c.choosePCase();
c.DisplayCases();
// Console.WriteLine("This is a test to see if the list is empty BEFORE player function is called");
// Console.WriteLine($"The List: {c.gameValues.Count}");
// b.GiveOffer(2,155305);
p.HandleRounds();

// Console.WriteLine("This is a test to see if the list is empty AFTER player function is called");
// Console.WriteLine($"The List: {c.gameValues.Count}");

