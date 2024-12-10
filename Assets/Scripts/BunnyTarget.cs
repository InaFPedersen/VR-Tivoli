using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyTarget : MonoBehaviour
{
    //used on the bunnies, and hammer

    public bool activeBunny;


    public void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
        if(activeBunny && collision.gameObject.CompareTag("Hammer"))
        {
            PlayerScore.instance.AddPoints();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (activeBunny && other.gameObject.CompareTag("Hammer"))
        {
            PlayerScore.instance.AddPoints();
        }
    }

}
    
