using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    [SerializeField] Paddle paddle;
    [SerializeField] float ballSpeed;
    [SerializeField] AudioClip[] sounds;
    [SerializeField] GameTrackerSctipt gameTracker;
    bool cantMove;
    void Start()
    {
        cantMove = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (cantMove == false)
        {
            AudioClip clip = sounds[Random.Range(0, sounds.Length)];
            GetComponent<AudioSource>().PlayOneShot(clip);

            if (collision.gameObject.name == "Block")
            {
                gameTracker.numbOfBlocks -= 1;
                gameTracker.score += gameTracker.BlockPoint;
                gameTracker.scoreText.text = gameTracker.score.ToString();
                if (gameTracker.numbOfBlocks == 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && cantMove)
        {
            cantMove = false;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f* ballSpeed);
        }
        
        if (cantMove)
        {
            transform.position = new Vector2(paddle.transform.position.x, transform.position.y);
          
        }
       
        
    }
}
