using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftIsland : MonoBehaviour
   
{

    float speed = 1;
    GameObject player;
    PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerControllerScript = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.hasPowerUp == true)
        {
            Debug.Log("Island can move");
            // transform.position = new Vector3(transform.position.x, -1f, transform.position.z) * speed * Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, -1.0f, transform.position.z), Time.deltaTime * speed);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, -4.0f, transform.position.z), Time.deltaTime * speed);
        }
    }
    
}
