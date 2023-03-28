using System.Collections;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    float MoveSpeed = 7;
    Rigidbody2D Rb;
    private void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        StartCoroutine(DeleteBall());
    }
    private void FixedUpdate()
    {
        Rb.velocity = new Vector2(MoveSpeed, 0);
    }

    public IEnumerator DeleteBall() 
    {
    yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
