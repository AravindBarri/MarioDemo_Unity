using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    ScoreScript SCObj;
    // Start is called before the first frame update
    void Start()
    {
        SCObj = FindObjectOfType<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("coin touched");
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            SCObj.score += 10;
        }
        
    }
}
