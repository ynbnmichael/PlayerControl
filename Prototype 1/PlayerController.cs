using System.Runtime.CompilerServices;
using UnityEngine;
// Private Variables
private float speed = 5.0f;
private float turnSpeed = 25.0f;
private float horizontalInput;
private float forwardInput;
public class PlayerController : MonoBehaviour
{
    public float turnSpeed = 20;

    public Vector3 Speed { get; private set; }

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
