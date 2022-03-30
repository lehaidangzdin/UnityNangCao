using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D _rigid2D;
    public float _force = 150f;
    public static float _speed = 4f;
    public float nextSpawn = 0f;
    //
    bool isGround = false;
    public GameController _gameControll;
    //
    Vector3 _countMetter;
    Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _rigid2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        // new posChar
        Vector3 newPosChar = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        // first posChar 
        Vector3 firstPosChar = new Vector3(-5f, -2.593f, 0f);
        _countMetter = newPosChar - firstPosChar;
        GameController._numMetter = Mathf.Round(_countMetter.magnitude); // count number of vector

        transform.Translate(_speed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space) && isGround==true)
        {
            _animator.Play("Player_jump");
            _rigid2D.AddForce(transform.up*_force);
            isGround = false;
        }
        // gameOver
        if(gameObject.transform.position.y < -6)
        {
            _gameControll.GameOver();
        }
        //up speed
        switch (GameController._numMetter)
        {
            case 50:
                {
                    _speed = 6f;
                    break;
                }
            case 100:
                {
                    _speed = 7f;
                    break;
                }
            case 150:
                {
                    _speed = 8f;
                    break;
                }
            case 250:
                {
                    _speed = 9f;
                    break;
                }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "gold")
        {
            Destroy(collision.gameObject);
            GameController._numGold++;
        }
        if (collision.gameObject.tag == "wall")
        {
            isGround = true;
        }
      
    }
    
}
