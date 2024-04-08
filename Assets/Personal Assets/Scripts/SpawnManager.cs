using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    [SerializeField]
    private GameObject[] spawnPoints;
    [SerializeField]
    private GameObject[] cars;
    private List<PlayerClass> selectedPlayers;

    private void Awake() {
        selectedPlayers = CarSelector.players;
    }

    private void Start() {
        //Debug.Log(selectedPlayers.Count);
        SpawnCars();
    }

    void SpawnCars() {
        foreach (PlayerClass player in selectedPlayers) {
            if (player != null) {
                switch (player.playerCar) {
                    case 0:
                        Instantiate(cars[0], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(cars[1], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(cars[2], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(cars[3], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(cars[4], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                        break;
                }
            }
        }
    }

}
