using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    //configParams
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] int minSpawnDelay=1;
    [SerializeField] int maxSpawnDelay=5; 
    bool spawn = true;
   
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {

            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }


    }

    private void SpawnAttacker()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
