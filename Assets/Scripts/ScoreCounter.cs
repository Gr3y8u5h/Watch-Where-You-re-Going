using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    
    public TextMeshProUGUI countText;
    public int count;
    GameObject player;
    




    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        count = 0;

        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other != player)
        {
            count++;

            SetCountText();
        }
        
    }

    void SetCountText()
    {
        countText.text = "Defeated Foes: " + count.ToString();
    }

}
