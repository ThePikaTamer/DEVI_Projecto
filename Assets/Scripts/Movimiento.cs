using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    [Serialize]
    public int speed = 5;
    public int jumpForce = 5;
    public bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        canJump = false;
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
        else if (Input.GetKeyDown(KeyCode.Space)&&canJump)
        {
            //this.GetComponent<Rigidbody>().AddForce(transform.up * speed);

            Debug.Log("Espacio pulsado");
            this.GetComponent<Rigidbody>().AddForce(Vector3.up*jumpForce);
        }
    }


    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.layer==LayerMask.NameToLayer("Ground"))
        {
            canJump = true;
        }
    }
    void OnCollisionExit(Collision c)
    {
        canJump = false;
    }
}
