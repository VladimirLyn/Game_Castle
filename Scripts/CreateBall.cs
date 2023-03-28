using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public GameObject Ball;
    void Start()
    {
        StartCoroutine(Create());
    }

    public IEnumerator Create()
    {
        while (true)
        {
            Instantiate(Ball, gameObject.transform);
            yield return new WaitForSeconds(0.5f);
        }

    }

}
