using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMainLevel1 : MonoBehaviour
{
    public GameObject image1;

    public IEnumerator Go()
    {
        image1.SetActive(true);
        yield return new WaitForSeconds(6);
        image1.SetActive(false);
        SceneManager.LoadScene("MainScene");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {

            case ("Player"):
                {

                    StartCoroutine(Go());
                    break;
                }
        }
    }


}
