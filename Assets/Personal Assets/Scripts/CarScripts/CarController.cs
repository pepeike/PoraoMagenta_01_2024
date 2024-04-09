using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour {
    [SerializeField]
    private WheelCollider frontRight;
    [SerializeField]
    private WheelCollider frontLeft;
    [SerializeField]
    private WheelCollider rearRight;
    [SerializeField]
    private WheelCollider rearLeft;
    private PlayerInput playerInput;

    private Rigidbody rb;

    #region Car Attributes

    
    public float motorForce;
    [SerializeField]
    private float brakeForce;
    [SerializeField]
    private float maxSteerAngle;

    #endregion



    private void Awake() {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
        IngameActions inputActions = new IngameActions();
        inputActions.Car.Enable();
        //inputActions.UI.Enable();


    }

    private void FixedUpdate() {
        Debug.Log(rb.velocity);
    }

    public void Drive(InputAction.CallbackContext context) {
        if (context.performed) {
            Debug.Log("Driving " + context.phase + " " + context.interaction);
            rearLeft.motorTorque = motorForce * 100;
            rearRight.motorTorque = motorForce * 100;
        }
        if (context.canceled) {
            Debug.Log("Stopped");
            rearLeft.motorTorque = 0;
            rearRight.motorTorque = 0;
        }
    }

    public void Brake(InputAction.CallbackContext context) {
        if (context.performed) {
            rearLeft.brakeTorque = brakeForce * 100;
            rearRight.brakeTorque = brakeForce * 100;
        }
        if (context.canceled) {
            rearLeft.brakeTorque = 0;
            rearRight.brakeTorque = 0;
        }
    }

    public void Steering(InputAction.CallbackContext context) {
        Vector2 direction = context.ReadValue<Vector2>();
        if (direction != Vector2.zero) {
            Debug.Log(direction);
        }

        if (context.started) {
            frontRight.steerAngle = direction.x * maxSteerAngle;
            frontLeft.steerAngle = direction.x * maxSteerAngle;
        }

        if (context.canceled) {
            frontRight.steerAngle = 0;
            frontLeft.steerAngle = 0;
        }
    }

    public void Reverse(InputAction.CallbackContext context) {
        if (context.performed) {
            rearLeft.motorTorque = -motorForce * 60;
            rearRight.motorTorque = -motorForce * 60;
        }

        if (context.canceled) {
            rearLeft.motorTorque = 0;
            rearRight.motorTorque = 0;
        }

    }

}
