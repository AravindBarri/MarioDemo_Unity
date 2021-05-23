using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaMovementScript : MonoBehaviour
{
    int speedAmt = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedAmt * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            speedAmt = speedAmt * -1;
        }

    }
}
