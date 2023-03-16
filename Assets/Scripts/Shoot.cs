using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject tower;
    [SerializeField]
    private float speed = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GameObject newBullet = Instantiate(bullet, tower.transform);//);
            newBullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
        }
    }
}
