using System.Collections;
using UnityEngine;

public class AnemyMoveInSecondScene : MonoBehaviour
{

    Rigidbody2D Rb;
    public GameObject Player;


    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Atack());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator Atack()
    {
          
        while (true)
        {
            Player = GameObject.Find("PlayerInSecondScene");
                Rb.velocity = new Vector2(Player.transform.position.x - gameObject.transform.position.x, Player.transform.position.y - gameObject.transform.position.y);
           
            yield return new WaitForSeconds(0.1f);
        }

    }
}
