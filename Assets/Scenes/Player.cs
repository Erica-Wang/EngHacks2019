using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int enemyHealth;
    public int playerHealth;

    void reset(){
        enemyHealth = 200;
        playerHealth = 200;
    }

    void Start()
    {
        reset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
