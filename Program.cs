Cases c = new Cases();
Player p = new Player();

c.RandomizeCases();
Console.WriteLine(c.gameValues[8]);
c.DisplayCases();
c.choosePCase();
p.HandleRounds();

