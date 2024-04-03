using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass
{

    public int playerNum;
    public int playerCar;
    public int playerPoints;

    public PlayerClass(int argPlayerNum, int argPlayerCar) {
        playerNum = argPlayerNum;
        playerCar = argPlayerCar;
        playerPoints = 0;
    }

}
