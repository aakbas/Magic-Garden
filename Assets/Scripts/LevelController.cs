using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] int attackerDeath=0;
    [SerializeField] int attackerSpawned = 0;
    [SerializeField] bool isTimerFinished = false;


    private void Update()
    {
        EndLevel();
    }

    public void CountDeathAttacker()
    {
        attackerDeath++;
    }
    public void CountSpawnedAttacker()
    {
        attackerSpawned++;
    }

    public void EndLevel()
    {
        if (attackerSpawned == attackerDeath && isTimerFinished)
        {
            Debug.Log("End Level Now!");
        }
    }

    public void IsTimerFinished()
    {
        isTimerFinished = true;
        StopSpawners();
    }

    public void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }



   
}
