using System.Collections;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    float MoveSpeed = 7;
    Rigidbody2D Rb;
    int x;

    private void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Destroy());
    }
    private void FixedUpdate()
    {
        switch (gameObject.name)
        {
            case "Left(Clone)":
                {

                    Rb.velocity = Vector2.left * MoveSpeed;
                    break;
                }
            case "Right(Clone)":
                {
                    Rb.velocity = Vector2.right * MoveSpeed;
                    break;
                }
            case "Up(Clone)":
                {
                    Rb.velocity = Vector2.up * MoveSpeed;
                    break;
                }
            case "Down(Clone)":
                {
                    Rb.velocity = Vector2.down * MoveSpeed;
                    break;
                }

        }
    }
    public IEnumerator Destroy()
    {


        
        yield return new WaitForSeconds(1.6f);
        Destroy(gameObject);
    }

}
