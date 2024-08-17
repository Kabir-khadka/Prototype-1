using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20f;
    private float turnSpeed = 45;
    private float horizontalInput;
    private float forwardInput;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public string inputID;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        //Calling the inout values using Input.Axis method
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        //Moving the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotates the vehicle 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);


        //Calling camera variables to enable the toogle property of two cameras.

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;

        }
    }
}
