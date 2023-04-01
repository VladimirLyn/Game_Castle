using System.Collections;
using UnityEngine;

public class StrongAnemyDamage : MonoBehaviour
{
    float HP = 130;
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
