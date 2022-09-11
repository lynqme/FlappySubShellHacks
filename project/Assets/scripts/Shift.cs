using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shift : MonoBehaviour
{
    
    public float speed;
    public float switchTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

        InvokeRepeating("Update", 0, switchTime);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }

}
