using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
                if (player.playerNum == 1) {
                    switch (player.playerCar) {
                        case 0:
                            //Instantiate(cars[0], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput _pi1 = PlayerInput.Instantiate(cars[0], player.playerNum - 1, "Keyboard1", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            GameObject _go1 = _pi1.gameObject;
                            _go1.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 1:
                            PlayerInput _pi2 = PlayerInput.Instantiate(cars[1], player.playerNum - 1, "Keyboard1", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            GameObject _go2 = _pi2.gameObject;
                            _go2.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 2:
                            PlayerInput _pi3 = PlayerInput.Instantiate(cars[2], player.playerNum - 1, "Keyboard1", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            GameObject _go3 = _pi3.gameObject;
                            _go3.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 3:
                            PlayerInput _pi4 = PlayerInput.Instantiate(cars[3], player.playerNum - 1, "Keyboard1", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            GameObject _go4 = _pi4.gameObject;
                            _go4.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 4:
                            PlayerInput _pi5 = PlayerInput.Instantiate(cars[4], player.playerNum - 1, "Keyboard1", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            GameObject _go5 = _pi5.gameObject;
                            _go5.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                    }
                } else if (player.playerNum == 2) {
                    switch (player.playerCar) {
                        case 0:
                            PlayerInput _pi1 = PlayerInput.Instantiate(cars[0], player.playerNum - 1, "Keyboard2", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            GameObject _go1 = _pi1.gameObject;
                            _go1.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 1:
                            PlayerInput _pi2 = PlayerInput.Instantiate(cars[1], player.playerNum - 1, "Keyboard2", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            GameObject _go2 = _pi2.gameObject;
                            _go2.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 2:
                            PlayerInput _pi3 = PlayerInput.Instantiate(cars[2], player.playerNum - 1, "Keyboard2", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            GameObject _go3 = _pi3.gameObject;
                            _go3.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 3:
                            PlayerInput _pi4 = PlayerInput.Instantiate(cars[3], player.playerNum - 1, "Keyboard2", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            GameObject _go4 = _pi4.gameObject;
                            _go4.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 4:
                            PlayerInput _pi5 = PlayerInput.Instantiate(cars[4], player.playerNum - 1, "Keyboard2", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            GameObject _go5 = _pi5.gameObject;
                            _go5.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                    }
                } else {
                    switch (player.playerCar) {
                        case 0:
                            PlayerInput _pi1 = PlayerInput.Instantiate(cars[0], player.playerNum - 1, "Gamepad", player.playerNum - 1);
                            GameObject _go1 = _pi1.gameObject;
                            _go1.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 1:
                            PlayerInput _pi2 = PlayerInput.Instantiate(cars[1], player.playerNum - 1, "Gamepad", player.playerNum - 1);
                            GameObject _go2 = _pi2.gameObject;
                            _go2.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 2:
                            PlayerInput _pi3 = PlayerInput.Instantiate(cars[2], player.playerNum - 1, "Gamepad", player.playerNum - 1);
                            GameObject _go3 = _pi3.gameObject;
                            _go3.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 3:
                            PlayerInput _pi4 = PlayerInput.Instantiate(cars[3], player.playerNum - 1, "Gamepad", player.playerNum - 1);
                            GameObject _go4 = _pi4.gameObject;
                            _go4.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 4:
                            PlayerInput _pi5 = PlayerInput.Instantiate(cars[4], player.playerNum - 1, "Gamepad", player.playerNum - 1);
                            GameObject _go5 = _pi5.gameObject;
                            _go5.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                    }
                }
                
            }
        }
    }

}
