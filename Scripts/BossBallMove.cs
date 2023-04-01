using System.Collections;
using UnityEngine;

public class BossBallMove : MonoBehaviour
{

    Rigidbody2D Rb;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Destroy());
    }

    private void FixedUpdate()
    {

        Rb.velocity = Vector2.left * 6;
    }
    public IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1.2f);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case ("Player"):
                {
                    Destroy(gameObject);
                    break;
                }
        }

    }
}
