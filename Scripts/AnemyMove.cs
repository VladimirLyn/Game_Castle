using System.Collections;
using UnityEngine;

public class AnemyMove : MonoBehaviour
{
    Rigidbody2D Rb;
    public Transform PlayerTransform;
    float DistanceForAtack = 10;
    float MoveSpeed = 2;
    float DistanceToPlayer;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        DistanceForAtack = 10;
        MoveSpeed = 2;
        StartCoroutine(Atack());
    }

    public IEnumerator Atack()
    {
        while (true)
        {
            DistanceToPlayer = Vector2.Distance(transform.position, PlayerTransform.position);
            if (DistanceToPlayer < DistanceForAtack)
            {
                Rb.velocity = new Vector2(-MoveSpeed, 0);
            }
            yield return new WaitForSeconds(0.1f);
        }

    }

}
