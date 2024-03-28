using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelector : MonoBehaviour
{
    public GameObject[] carList;
    public int selectedCar = 0;
    public static GameObject currentCar;
    public GameObject carousel;
    public string SceneName;
    public AudioSource beep;
    // Start is called before the first frame update
    public void Update()
    {
        //move the carousel to the selected car
        carousel.transform.position = Vector3.Lerp(carousel.transform.position,
           new Vector3(selectedCar * 10, 0, 0), Time.deltaTime*10);

        //check if the player presses the right or left arrow
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            LeftButton();
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RightButton();
        }
    }
    //get the right event button
    public void RightButton()
    {
        beep.Play();
        //get the current car
        currentCar = carList[selectedCar];
        //move the carousel to the right
        selectedCar++;
        //if the selected car is greater than the length of the list, set it to 0
        if(selectedCar > carList.Length - 1)
        {
            selectedCar = 0;
        }
        
    }
    public void LeftButton()
    {
        beep.Play();
        currentCar = carList[selectedCar];  
        selectedCar--;
        if(selectedCar < 0)
        {
            selectedCar = carList.Length - 1;
        }
       
    }
    //select the car
    public void SelectCar()
    {
        //set the current car to the selected car
        currentCar = carList[selectedCar];
        //load the scene
        SceneManager.LoadSceneAsync(SceneName);
    }
}
