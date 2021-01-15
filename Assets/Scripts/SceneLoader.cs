using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float theDelay = 2.5f;
    int currentSceneIndex;

    private void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitAndLoad());
        }
    }
     
    
       IEnumerator WaitAndLoad() ///////VERY IMPORTANT COROUTINE DELAY!
    {
        yield return new WaitForSeconds(theDelay);
        LoadNextScene();
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadNextSceneGame()
    {
        SceneManager.LoadScene(2);
    }
}