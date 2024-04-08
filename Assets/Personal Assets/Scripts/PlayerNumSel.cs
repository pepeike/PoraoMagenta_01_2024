using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerNumSel : MonoBehaviour
{

    
    

    public void OnePlayer() {
        PlayerCount.SetPlayerCount(1);
        SceneManager.LoadScene("CharSel");
    }
    public void TwoPlayer() {
        PlayerCount.SetPlayerCount(2);
        SceneManager.LoadScene("CharSel");
    }
    
}
