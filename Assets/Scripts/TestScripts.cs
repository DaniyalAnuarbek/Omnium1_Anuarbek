using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScripts : MonoBehaviour
{

    public float speed;


    void Start()
    {
        
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3  movementVector = new Vector3 (moveHorizontal, 0, moveVertical);
        transform.position = transform.position + movementVector * speed * Time.deltaTime;
    }
}
