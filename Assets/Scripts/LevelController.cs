using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] int attackerDeath=0;
    [SerializeField] int attackerSpawned = 0;
    [SerializeField] bool isTimerFinished = false;
    [SerializeField] AudioClip winSFX;

    private void Start()
    {
        winLabel.SetActive(false);
    }
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
            StartCoroutine(WinScreen());
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

    IEnumerator WinScreen()
    {
        FindObjectOfType<AudioSource>().PlayOneShot(winSFX);
        winLabel.SetActive(true);
        yield return new WaitForSeconds(3);
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }


   
}
