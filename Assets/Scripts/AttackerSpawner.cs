using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    //configParams
    [SerializeField] Attacker[] enemyPrefabs;
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
        
        int randomAtackerIndex = Random.Range(0, enemyPrefabs.Length);
        Attacker newAttacker= Instantiate(enemyPrefabs[randomAtackerIndex], transform.position, Quaternion.identity)as Attacker;
        newAttacker.transform.parent = transform;   
      

    }
    public void StopSpawning()
    {
        spawn = false;
    }

  

    // Update is called once per frame
    void Update()
    {
        
    }


}
