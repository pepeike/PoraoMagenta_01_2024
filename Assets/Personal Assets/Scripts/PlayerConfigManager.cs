using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerConfigManager : MonoBehaviour
{
    private List<PlayerConfiguration> playerConfigs;
    [SerializeField] private LobbyMenu menu;

    [HideInInspector]
    public int MaxPlayers;

    public static PlayerConfigManager Instance { get; private set; }

    private void Awake() {
        if (Instance != null) {
            Debug.Log("SINGLETON - Trying to create another instance of a singleton!");
        } else {
            Instance = this;
            DontDestroyOnLoad(Instance);
            playerConfigs = new List<PlayerConfiguration>();
        }
    }

    public void SetPlayerColor(int index, int car) {
        playerConfigs[index].PlayerCar = car;
    }

    public void ReadyPlayer(int index) {
        playerConfigs[index].IsReady = true;
        if(playerConfigs.Count == MaxPlayers && playerConfigs.All(p => p.IsReady == true)) {
            SceneManager.LoadScene("CharSel");
        }
    }

    public void HandlePlayerJoin(PlayerInput pi) {
        Debug.Log("Player Joined " + pi.playerIndex);
        pi.transform.SetParent(transform);
        if (!playerConfigs.Any(p => p.PlayerIndex == pi.playerIndex)) {
            playerConfigs.Add(new PlayerConfiguration(pi));
            //menu.playerInputs.Add(pi);
            //menu.LogNewPlayer();
        }
    }

}

public class PlayerConfiguration {

    public PlayerConfiguration(PlayerInput pi) {
        PlayerIndex = pi.playerIndex;
        Input = pi;
    }
    public PlayerInput Input { get; set; }

    public InputDevice InputDevice { get; set; }

    public InputActionMap InputActionMap { get; set; }

    public int PlayerIndex { get; set; }

    public bool IsReady { get; set; }

    public int PlayerCar { get; set; }

}
