using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    //configParams
    [SerializeField] Attacker enemyPrefab;
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
        Attacker newAttacker= Instantiate(enemyPrefab, transform.position, Quaternion.identity)as Attacker;
        newAttacker.transform.parent = transform;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
