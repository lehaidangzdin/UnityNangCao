using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{

    SpriteRenderer sprite;
    float yOffset;
    public static float speed = 0.05f;

    public float folowSpeed = 15f;
    public float yOffsetFollow = 1f;
    public float xOffsetFollow = 1f;

    public Transform target;

   
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // bg follow
        transform.position = new Vector3(target.position.x + xOffsetFollow * speed * Time.deltaTime, 4f, 0f);
        //
        // prallax
        yOffset += Time.deltaTime;
        sprite.material.SetTextureOffset("_MainTex", new Vector2(yOffset *speed, 0));

    }
}
