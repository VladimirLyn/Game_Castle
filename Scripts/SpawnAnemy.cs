using System.Collections;
using UnityEngine;

public class SpawnAnemy : MonoBehaviour
{
    public GameObject Anemy;
    public GameObject StrongAnemy;
    int x,c;
    void Start()
    {
        StartCoroutine(Create());
    }

    public IEnumerator Create()
    {
        while (true)
        {
            x = Random.Range(0, 2);
            if (x == 1)
            {
                Instantiate(StrongAnemy, gameObject.transform);
            }
            else
            {
                Instantiate(Anemy, gameObject.transform);

            }
            c = Random.Range(6, 12);
            yield return new WaitForSeconds(c);
        }

    }
}
