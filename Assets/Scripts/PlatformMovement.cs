using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    int Platformspeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(transform.position.x);
        if(this.transform.position.x > 100)
        {
            Platformspeed = 0;
        }
        transform.Translate(Platformspeed * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Platformspeed = 2;
        }

    }
}
