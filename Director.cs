// takes user inputs and compares to assigned cases and choosen case.

public class Director{
    Cases c = new Cases();
    Player p = new Player();

    public Director(){

    }


    public void StartGame(){
    c.RandomizeCases(); // temporarily out of commission
    c.DisplayCases();
    c.choosePCase();

    p.HandleRounds(c.playerCase, c.gameValues);


    Banker b = new Banker(c.gameValues);
    }

}