using System.Collections;
using UnityEngine;

public class AnemyDamage : MonoBehaviour
{
    float HP = 100;
    void Start()
    {
        StartCoroutine(PlayerHP());
    }

    public IEnumerator PlayerHP()
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
        }
    }
}
