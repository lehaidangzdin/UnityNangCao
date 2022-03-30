using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spamer_Wall : MonoBehaviour
{
  
    public GameObject wall1;
    public GameObject wall2;
    float randomEnemies;
    float randomY;
    Vector2 randomPos;
    //

    public float nextSpawn = 0f;
    public float spawnRate = 1f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            randomEnemies = Mathf.Round(Random.Range(1f, 2f));
            createEnemies(randomEnemies);
            nextSpawn = Time.time + spawnRate;
        }

    }
    private void createEnemies(float random)
    {
        switch (random)
        {
            case 1:
                {
                    randomY = Random.Range(-3f, -8f);
                    randomPos = new Vector2( transform.position.x,randomY);
                    Instantiate(wall1, randomPos, Quaternion.identity);
                    break;
                }
            case 2:
                {
                    randomY = Random.Range(-3f, -8f);
                    randomPos = new Vector2(transform.position.x, randomY);
                    Instantiate(wall2, randomPos, Quaternion.identity);
                    break;
                }
        }
    }
}
