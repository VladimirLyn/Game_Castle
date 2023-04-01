using System.Collections;
using UnityEngine;

public class Boss3Damage : MonoBehaviour
{
    public GameObject Crystal;
    float HP = 500;
    void Start()
    {
        StartCoroutine(AnemyHP());
    }

    public IEnumerator AnemyHP()
    {
        while (true)
        {
            if (HP <= 0)
            {
                Crystal.SetActive(true);
                gameObject.SetActive(false);
            }
            yield return new WaitForSeconds(0.1f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case ("ball"):
                {
                    Debug.Log("ball");
                    HP -= 20;
                    collision.gameObject.SetActive(false);
                    break;
                }
            case ("fireball"):
                {
                    Debug.Log("fireball");
                    HP -= 40;
                    collision.gameObject.SetActive(false);
                    break;
                }
        }
    }
}
