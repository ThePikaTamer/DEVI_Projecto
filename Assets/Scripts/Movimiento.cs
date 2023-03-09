using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [Serialize]
    public int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    void movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Time.deltaTime * Vector3.forward * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Time.deltaTime * Vector3.back * speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Time.deltaTime * Vector3.left * speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Time.deltaTime * Vector3.right * speed;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            //transform.position += Time.deltaTime * Vector3.up * speed;
            this.GetComponent<Rigidbody>().AddForce(transform.up * speed);
        }
    }
}
