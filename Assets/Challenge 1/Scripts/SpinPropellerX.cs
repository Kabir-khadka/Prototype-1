using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float turnSpeed = 60f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed);
    }
}
