using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(StartNextLevel());
    }

    public IEnumerator StartNextLevel()
    {
        yield return new WaitForSeconds(16);
        SceneManager.LoadScene("MainScene");
    }

}
