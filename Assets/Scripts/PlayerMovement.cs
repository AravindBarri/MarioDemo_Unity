using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float playerspeed;
    public float jumpVelocity;
    SpriteRenderer playerSprite;
    RepeatBackground background;

    public GameObject GameOverCanva;
    public GameObject LevelCompleteCanva;
    bool Grounded;

    Animator anim;

    AudioSource playaudio;
    public AudioClip mainclip;
    public AudioClip deadclip;

    ScoreScript scobj;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        background = GameObject.Find("Background").GetComponent<RepeatBackground>();
        playaudio = GameObject.Find("Player").GetComponent<AudioSource>();
        playaudio.clip = mainclip;
        scobj = FindObjectOfType<ScoreScript>();
    }

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        float playerdirection = Input.GetAxis("Horizontal");
        if (playerdirection < 0f)
        {
            PlayerMove(movement);
            playerSprite.flipX = true;
            anim.SetTrigger("Run");
            background.xoffset = -0.25f;
        }
        else if(playerdirection >0f)
        {
            PlayerMove(movement);
            playerSprite.flipX = false;
            anim.SetTrigger("Run");
            background.xoffset = 0.25f;
        }
        if(playerdirection == 0f)
        {
            anim.SetTrigger("Runstop");
            background.xoffset = 0f;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Grounded)
            {
                JumpMethod();
                anim.SetTrigger("Jump");
            }

        }
        if(this.transform.position.y < -10f)
        {
            playaudio.clip = deadclip;
            playaudio.Play();
            GameOverCanva.SetActive(true);
        }
    }
    private void JumpMethod()
    {
        Grounded = false;
        playerRB.velocity = new Vector2(0, jumpVelocity);
    }
    private void PlayerMove(Vector3 movement)
    {
        transform.position += movement * Time.deltaTime * playerspeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Grounded = true;
        }
        if(collision.gameObject.tag == "Enemy")
        {
            anim.SetTrigger("Dead");
            playaudio.clip = deadclip;
            playaudio.Play();
            Invoke("GameOverScreen", 4f);
        }
        if(collision.gameObject.tag == "End")
        {
            scobj.score += 1000;
            Invoke("LevelComplete", 0f);
        }
    }

    private void LevelComplete()
    {
        LevelCompleteCanva.SetActive(true);
    }

    private void GameOverScreen()
    {
        GameOverCanva.SetActive(true);
        playaudio.Stop();
    }
}
