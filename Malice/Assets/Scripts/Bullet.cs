using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public float bulletDuration = 2f;

    private float bulletTimer;

    // Start is called before the first frame update
    void Start()
    {
        bulletTimer = bulletDuration;
    }

    // Update is called once per frame
    void Update()
    {
        // Make bullet move
        transform.position += transform.forward * speed * Time.deltaTime;

        // Check if bullet should disappear
        bulletTimer -= Time.deltaTime;
        if(bulletTimer <= 0f)
        {
            Destroy(gameObject);
        }

    }

    
}
