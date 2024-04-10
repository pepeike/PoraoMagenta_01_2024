using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class LobbyMenu : MonoBehaviour {

    public TextMeshProUGUI p1ReadyText;
    public TextMeshProUGUI p2ReadyText;
    public Button continueButton;

    [SerializeField]
    private PlayerConfigManager playerConfigManager;
    [SerializeField]
    private PlayerInputManager playerInputManager;

    private int maxPlayers;

    private bool canContinue;

    public List<PlayerInput> playerInputs;

    private void Start() {
        canContinue = false;
        continueButton.interactable = false;
        p1ReadyText.enabled = false;
        p2ReadyText.enabled = false;
        maxPlayers = playerInputManager.maxPlayerCount;

    }

    private void FixedUpdate() {
        WaitForPlayers(maxPlayers);

        if (canContinue) {
            continueButton.interactable = true;
        }



    }

    private void WaitForPlayers(int maxPlayers) {
        if (playerInputs.All(p => p != null)) {
            canContinue = true;
        }
    }

    public void LogNewPlayer() {
        if (playerInputs.Count == 1) {
            p1ReadyText.enabled = true;
        }
        if (playerInputs.Count == 2) {
            p2ReadyText.enabled = true;
        }
    }

}
