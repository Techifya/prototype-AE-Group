using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] spawners; 
    public GameObject enemy;

    public int roundNumber = 0;
    public int enemySpawnAmount = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        spawners = new GameObject[3];

        for(int i=0; i < spawners.Length; i++){
            spawners[i] = transform.GetChild(i).gameObject;
        }

        StartRound();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)){
            SpawnEnemy();
        }
    }

    void SpawnEnemy(){

        int spawn = Random.Range(0, spawners.Length);

        Instantiate(enemy, spawners[spawn].transform.position, spawners[spawn].transform.rotation);

    }


    void StartRound(){

        roundNumber = 1;
        enemySpawnAmount = 3; 
        
        for(int i=0; i < enemySpawnAmount; i++){
            SpawnEnemy();
        }

    }

    void NewRound(){
        roundNumber++;
        enemySpawnAmount += 2;

        for(int i=0; i < enemySpawnAmount; i++){
            SpawnEnemy();
        }


    }
}


