using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HittingGame : MonoBehaviour
{
    //Variables
    [Header("BunnyTargets")]
    public bool isSpawning = false;
    public BunnyTargets bunnyTargets;
    public float speed = 0.2f;

    public GameObject[] bunnyTarget;
    float time;
    public float spawnTimer;
    int targetBunny;
    //public float elapsed = 0f;
    //public float duration = 2f;

    //When click start
    public void StartButtonPressed()
    {
        isSpawning = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (isSpawning)
        {
        time += Time.deltaTime;
            
            if (time > spawnTimer)
            {
                bunnyTarget[targetBunny].GetComponent<BunnyTarget>().activeBunny = false;

                targetBunny = Random.Range(0, bunnyTarget.Length - 1);
                bunnyTarget[targetBunny].GetComponent<BunnyTarget>().activeBunny = true;
                time = 0;
            }

            if(time < spawnTimer/2)
            {
                bunnyTarget[targetBunny].transform.position = new Vector3(bunnyTarget[targetBunny].transform.position.x, Mathf.Lerp(0.517f, 1.085f, Mathf.Clamp01(time)), bunnyTarget[targetBunny].transform.position.z);
            }
            else
            {
                bunnyTarget[targetBunny].transform.position = new Vector3(bunnyTarget[targetBunny].transform.position.x, Mathf.Lerp(1.085f, 0.517f, Mathf.Clamp01(time - (spawnTimer - 1))), bunnyTarget[targetBunny].transform.position.z);
            }
            
            

            

            //Alle bunnytargets starter i 0.517
            //Random bunnytarget flyttes til Y: 1.085
            //Vent 5 sekunder i Y: 1.085
            //Gå ned igjen til Y: 0.517
        }
    }

    public enum BunnyTargets
    {
        Bunny1,
        Bunny2,
        Bunny3,
        Bunny4,
        Bunny5,
        Bunny6

    }
}
