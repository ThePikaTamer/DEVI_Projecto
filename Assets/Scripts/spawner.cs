using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Object bullet;
    [Serialize]
    public int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bullet);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void movement()
    {
        
    }
}
