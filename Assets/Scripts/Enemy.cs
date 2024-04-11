using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float speed = 3;
    Rigidbody enemyRb;
    GameObject player;
    ParticleSystem particle;
    PlayerController playerControllerScript;
    public bool enemyDestroyed = false;
    






    // Start is called before the first frame update
    void Start()
    {
        
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        particle = gameObject.GetComponent<ParticleSystem>();
        playerControllerScript = player.GetComponent<PlayerController>();
        


    }

    // Update is called once per frame
    void Update()
    {
        // have to take players position - enemy position to find vector from enemy to player
        // with .normalized the enemy will always be coming at the same speed
        // otherwise with a larger vector they'll be more speed

        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);

        DestroyEnemy();

    }

    

    void OnCollisionEnter(Collision collision)
    {

        // if (collision.gameObject.CompareTag("Player") && playerControllerScript.hasPowerUp == true)
        if (collision.gameObject == player && playerControllerScript.hasPowerUp == true)
        {
            Debug.Log("Can Play Particle");
            particle.Play();
        }
    }

    public void DestroyEnemy()
    {
        if (transform.position.y < -5)
        {
            enemyDestroyed = true;
            if (transform.position.y < -10)
            {
                Destroy(gameObject);
            }
            
            

        }
    }


}
