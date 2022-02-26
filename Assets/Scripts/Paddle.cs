using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidth = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 c=Camera.main.ScreenToWorldPoint(Input.mousePosition);
     
        transform.position =new Vector2(c.x,transform.position.y);
    }
}
