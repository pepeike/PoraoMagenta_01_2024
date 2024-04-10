using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour {
    [SerializeField]
    private GameObject[] spawnPoints;
    [SerializeField]
    private GameObject[] cars;
    private List<PlayerClass> selectedPlayers;
    public PlayerInputManager playerInputManager;

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
                            GameObject pl1 = Instantiate(cars[0], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi1 = pl1.GetComponent<PlayerInput>();
                            //pi1.defaultControlScheme = "Keyboard1";
                            pi1.SwitchCurrentControlScheme("Keyboard1", devices: Keyboard.current);

                            //PlayerInput _pi1 = PlayerInput.Instantiate(cars[0], player.playerNum - 1, "Keyboard1", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            //GameObject _go1 = _pi1.gameObject;
                            //_go1.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 1:
                            GameObject pl2 = Instantiate(cars[1], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi2 = pl2.GetComponent<PlayerInput>();
                            pi2.SwitchCurrentControlScheme("Keyboard1", devices: Keyboard.current);
                            //pi2.defaultControlScheme = "Keyboard1";
                            //PlayerInput _pi2 = PlayerInput.Instantiate(cars[1], player.playerNum - 1, "Keyboard1", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            //GameObject _go2 = _pi2.gameObject;
                            //_go2.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 2:
                            GameObject pl3 = Instantiate(cars[2], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi3 = pl3.GetComponent<PlayerInput>();
                            pi3.SwitchCurrentControlScheme("Keyboard1", devices: Keyboard.current);
                            //PlayerInput _pi3 = PlayerInput.Instantiate(cars[2], player.playerNum - 1, "Keyboard1", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            //GameObject _go3 = _pi3.gameObject;
                            //_go3.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 3:
                            GameObject pl4 = Instantiate(cars[3], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi4 = pl4.GetComponent<PlayerInput>();
                            pi4.SwitchCurrentControlScheme("Keyboard1", devices: Keyboard.current);
                            //PlayerInput _pi4 = PlayerInput.Instantiate(cars[3], player.playerNum - 1, "Keyboard1", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            //GameObject _go4 = _pi4.gameObject;
                            //_go4.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 4:
                            GameObject pl5 = Instantiate(cars[4], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi5 = pl5.GetComponent<PlayerInput>();
                            pi5.SwitchCurrentControlScheme("Keyboard1", devices: Keyboard.current);
                            //PlayerInput _pi5 = PlayerInput.Instantiate(cars[4], player.playerNum - 1, "Keyboard1", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            //GameObject _go5 = _pi5.gameObject;
                            //_go5.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                    }
                } else if (player.playerNum == 2) {
                    switch (player.playerCar) {
                        case 0:
                            GameObject pl1 = Instantiate(cars[0], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi1 = pl1.GetComponent<PlayerInput>();
                            //PlayerInput pi2 = playerInputManager.JoinPlayer(1, 1, "Keyboard2", pairWithDevice: Keyboard.current);
                            //pi2.transform.SetParent(pl2.transform);
                            pi1.SwitchCurrentControlScheme("Keyboard2", devices: Keyboard.current);
                            
                            //pi2.defaultControlScheme = "Keyboard2";
                            //PlayerInput _pi12 = PlayerInput.Instantiate(cars[0], player.playerNum - 1, "Keyboard2", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            //GameObject _go12 = _pi12.gameObject;
                            //_go12.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 1:
                            GameObject pl2 = Instantiate(cars[1], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi2 = pl2.GetComponent<PlayerInput>();
                            //PlayerInput pi1 = playerInputManager.JoinPlayer(1, 1, "Keyboard2", pairWithDevice: Keyboard.current);
                            //pi1.transform.SetParent(pl1.transform);
                            pi2.SwitchCurrentControlScheme("Keyboard2", devices: Keyboard.current);
                            //PlayerInput _pi22 = PlayerInput.Instantiate(cars[1], player.playerNum - 1, "Keyboard2", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            //GameObject _go22 = _pi22.gameObject;
                            //_go22.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 2:
                            GameObject pl3 = Instantiate(cars[2], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi3 = pl3.GetComponent<PlayerInput>();
                            pi3.SwitchCurrentControlScheme("Keyboard2", devices: Keyboard.current);
                            //PlayerInput _pi32 = PlayerInput.Instantiate(cars[2], player.playerNum - 1, "Keyboard2", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            //GameObject _go32 = _pi32.gameObject;
                            //_go32.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 3:
                            GameObject pl4 = Instantiate(cars[3], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi4 = pl4.GetComponent<PlayerInput>();
                            pi4.SwitchCurrentControlScheme("Keyboard2", devices: Keyboard.current);
                            //PlayerInput _pi42 = PlayerInput.Instantiate(cars[3], player.playerNum - 1, "Keyboard2", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            //GameObject _go42 = _pi42.gameObject;
                            //_go42.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 4:
                            GameObject pl5 = Instantiate(cars[4], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi5 = pl5.GetComponent<PlayerInput>();
                            pi5.SwitchCurrentControlScheme("Keyboard2", devices: Keyboard.current);
                            //PlayerInput _pi52 = PlayerInput.Instantiate(cars[4], player.playerNum - 1, "Keyboard2", player.playerNum - 1, pairWithDevice: Keyboard.current);
                            //GameObject _go52 = _pi52.gameObject;
                            //_go52.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                    }
                } else {
                    switch (player.playerCar) {
                        case 0:
                            GameObject pl1 = Instantiate(cars[0], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi1 = pl1.GetComponent<PlayerInput>();
                            pi1.SwitchCurrentControlScheme("Gamepad");
                            //pi1.SwitchCurrentControlScheme("Gamepad", devices: Gamepad.all[]);
                            //PlayerInput _pi1 = PlayerInput.Instantiate(cars[0], player.playerNum - 1, "Gamepad", player.playerNum - 1);
                            //GameObject _go1 = _pi1.gameObject;
                            //_go1.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 1:
                            GameObject pl2 = Instantiate(cars[1], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi2 = pl2.GetComponent<PlayerInput>();
                            pi2.SwitchCurrentControlScheme("Gamepad");
                            //PlayerInput _pi2 = PlayerInput.Instantiate(cars[1], player.playerNum - 1, "Gamepad", player.playerNum - 1);
                            //GameObject _go2 = _pi2.gameObject;
                            //_go2.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 2:
                            GameObject pl3 = Instantiate(cars[2], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi3 = pl3.GetComponent<PlayerInput>();
                            pi3.SwitchCurrentControlScheme("Gamepad");
                            //PlayerInput _pi3 = PlayerInput.Instantiate(cars[2], player.playerNum - 1, "Gamepad", player.playerNum - 1);
                            //GameObject _go3 = _pi3.gameObject;
                            //_go3.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 3:
                            GameObject pl4 = Instantiate(cars[3], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi4 = pl4.GetComponent<PlayerInput>();
                            pi4.SwitchCurrentControlScheme("Gamepad");
                            //PlayerInput _pi4 = PlayerInput.Instantiate(cars[3], player.playerNum - 1, "Gamepad", player.playerNum - 1);
                            //GameObject _go4 = _pi4.gameObject;
                            //_go4.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                        case 4:
                            GameObject pl5 = Instantiate(cars[4], spawnPoints[player.playerNum - 1].transform.position, Quaternion.identity);
                            PlayerInput pi5 = pl5.GetComponent<PlayerInput>();
                            pi5.SwitchCurrentControlScheme("Gamepad");
                            //PlayerInput _pi5 = PlayerInput.Instantiate(cars[4], player.playerNum - 1, "Gamepad", player.playerNum - 1);
                            //GameObject _go5 = _pi5.gameObject;
                            //_go5.transform.position = spawnPoints[player.playerNum - 1].transform.position;
                            break;
                    }
                }
                
            }
        }
    }

}
