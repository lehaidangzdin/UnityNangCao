using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Controller : MonoBehaviour
{
    public float speed = 5f;
    public float _random_ScaleX;


    // Start is called before the first frame update
    void Start()
    {
       
        _random_ScaleX = Random.Range(0.3f, 1.2f);

        //
        gameObject.transform.localScale = new Vector2(_random_ScaleX,1);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "boxEnd")
        {
            Destroy(gameObject);
        }
    }

  
}
