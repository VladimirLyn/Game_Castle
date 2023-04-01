using System.Collections;
using UnityEngine;

public class Boss1CreateBalls : MonoBehaviour
{
    public GameObject Boss1Ball;

    private void Start()
    {
        StartCoroutine(Create());
    }

    public IEnumerator Create()
    {
        while (true)
        {

            yield return new WaitForSeconds(1f);
            Instantiate(Boss1Ball, gameObject.transform);

            yield return new WaitForSeconds(1f);
        }

    }
}
