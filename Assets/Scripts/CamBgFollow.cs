using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBgFollow : MonoBehaviour
{
    [SerializeField] Vector3 offset;

    Transform playerTransform;

    float delayspeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float yoffset = playerTransform.transform.position.x;
        //Vector3 camposition = playerTransform.position + (offset - new Vector3(0f,yoffset,0f));
        Vector3 camposition = offset - new Vector3(-yoffset, 0f, 0f);

        transform.position = Vector3.Lerp(transform.position, camposition, Time.deltaTime * delayspeed);
    }
}
