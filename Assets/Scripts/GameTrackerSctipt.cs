using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTrackerSctipt : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public int numbOfBlocks;
    [SerializeField] public int score=0;
    [SerializeField] public int BlockPoint;
    [SerializeField] public Text scoreText;
    [Range(0.5f, 5f)] [SerializeField] float gameSpeed=1f;


    private void Awake()
    {

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            PlayerPrefs.DeleteAll();
        }
        //int gameTrackerNumOfScriptsAvailable = FindObjectsOfType<GameTrackerSctipt>().Length;
        //if (gameTrackerNumOfScriptsAvailable > 1)
        //{
        //gameObject.SetActive(false);
        //Destroy(gameObject);
        //}
        // else
        //{
            //DontDestroyOnLoad(gameObject);
        //}
    }
    void Start()
    {
        Time.timeScale = gameSpeed;
        int scoreGot=PlayerPrefs.GetInt("Score");
        Debug.Log(scoreGot);
        score = scoreGot;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
      
        PlayerPrefs.SetInt("Score", score);
        
    }
}
