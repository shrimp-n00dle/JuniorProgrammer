using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;

    private float horizontalInput,forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move tehe vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //turn
        transform.Rotate(Vector3.up, turnSpeed *  horizontalInput * Time.deltaTime );
        // DEPRECATED transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
