using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    //Config Params
    [SerializeField] int delayTime=4;



    int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            LoadStartScene();
        }
    }

   public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }


    public void LoadStartScene()
    {
        StartCoroutine(DelayAndLoad("Start Scene"));
    }

    IEnumerator DelayAndLoad(string sceneName)
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(sceneName);
    }




     
}
