using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovement : MonoBehaviour
{
    public int speedAmt = 4;
    public float x;
    public float y;
    SpriteRenderer DinoSprite;    
    // Start is called before the first frame update
    void Start()
    {
        DinoSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x <= x)
        {
            speedAmt = 5;
            DinoSprite.flipX = false;
        }
        if (transform.position.x >= y)
        {
            speedAmt = -5;
            DinoSprite.flipX = true;
        }
        transform.Translate(speedAmt * Time.deltaTime, 0, 0);//time.deltatime updates the timetaken
    }

}
