using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBoxScript : MonoBehaviour
{
    public GameObject coinsprite;
    Rigidbody2D rbcoin;
    // Start is called before the first frame update
    void Start()
    {
        rbcoin = coinsprite.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject x = Instantiate(coinsprite, transform.position, Quaternion.identity);
            rbcoin.AddForce(new Vector3(0f, 1f, 0f));
            Destroy(this.gameObject);
           
        }
    }

}
