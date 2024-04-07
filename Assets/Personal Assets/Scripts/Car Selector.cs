using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(CharacterController))]
public class CarSelector : MonoBehaviour {
    public GameObject[] carList;
    public int selectedCar = 0;
    public static GameObject currentCar;
    public GameObject carousel;
    public string SceneName;
    public AudioSource beep;
    
    public static int playerstochoose;
    private int playerIndex = 1;
    public static List<PlayerClass> players = new List<PlayerClass>();
    private Vector2 movementInput = Vector2.zero;
    //private CharacterController characterController;

    //[SerializeField]
    //private PlayerInputManager playerInputManager;
    
    

    private void Start() {
        Debug.Log(playerstochoose);
        
        

        //Debug.Log(players);
        //characterController = GetComponent<CharacterController>();

    }

    public void Update() {
        //move the carousel to the selected car
        carousel.transform.position = Vector3.Lerp(carousel.transform.position,
           new Vector3(selectedCar * 10, 0, 0), Time.deltaTime * 10);

        //check if the player presses the right or left arrow
        //if (Input.GetKeyDown(KeyCode.RightArrow)) {
        //    LeftButton();
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow)) {
        //    RightButton();
        //}
        //if (Input.GetKeyDown(KeyCode.Space)) {
        //    SelectCar();
        //}
    }
    //get the right event button
    public void RightButton() {
        beep.pitch = 1;
        beep.Play();
        //get the current car
        currentCar = carList[selectedCar];
        //move the carousel to the right
        selectedCar++;
        //if the selected car is greater than the length of the list, set it to 0
        if (selectedCar > carList.Length - 1) {
            selectedCar = 0;
        }

    }
    public void LeftButton() {
        beep.pitch = 1;
        beep.Play();
        currentCar = carList[selectedCar];
        selectedCar--;
        if (selectedCar < 0) {
            selectedCar = carList.Length - 1;
        }

    }
    //select the car
    public void SelectCar() {
        //set the current car to the selected car
        //currentCar = carList[selectedCar];
        beep.pitch = 1.4f;
        beep.Play();
        if (playerIndex <= playerstochoose) {

            //PlayerClass = new PlayerClass(i, selectedCar);
            players.Add(new PlayerClass(playerIndex, selectedCar));
            Debug.Log(players[playerIndex - 1].playerCar);
            playerIndex++;
            if (playerIndex > playerstochoose) {
                Debug.Log("Finished");
            }
        }
        //load the scene
        
        //Debug.Log("Finished");
        //SceneManager.LoadSceneAsync(SceneName);
    }

    public void OnMove(InputAction.CallbackContext context) {
        movementInput = context.ReadValue<Vector2>();
        Debug.Log("Movement Input: " +  movementInput);
        if (movementInput.x > 0 && context.phase == InputActionPhase.Started) {
            LeftButton();
            Debug.Log(context.action.phase);
        } else if (movementInput.x < 0 && context.phase == InputActionPhase.Started) {
            RightButton();
            Debug.Log(context.action.phase);
        }
    }

    public void OnSelect(InputAction.CallbackContext context) {
        
        if (context.phase == InputActionPhase.Started) {
            SelectCar();
        }
    }

    public void OnEscape(InputAction.CallbackContext context) {
        
        if (context.phase == InputActionPhase.Started) {
            Debug.Log("Escape");
        }
    }

}
