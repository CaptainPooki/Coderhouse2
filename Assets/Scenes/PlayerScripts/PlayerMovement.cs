using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    public float cameraAxisX = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationCamera();
        if(Input.GetKey(KeyCode.W))
        {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
    if(Input.GetKey(KeyCode.S))
        {
        transform.Translate(Vector3.back * speed * Time.deltaTime);

    }
    if(Input.GetKey(KeyCode.A))
        {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

    }
    if(Input.GetKey(KeyCode.D))
        {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

    }
    }
    public void rotationCamera()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Quaternion newRotation = Quaternion.Euler(0,cameraAxisX,0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 2f * Time.deltaTime);
    }
}
