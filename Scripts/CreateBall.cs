using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateBall : MonoBehaviour
{
    public GameObject Ball;
    public GameObject FireBall;
    bool CanFire4Balls;
    void Start()
    {

        StartCoroutine(SwitchCanFire4Balls());
        StartCoroutine(Create());
    }

    public IEnumerator Create()
    {
        while (true)
        {
            if(Damage.TakebonusDamage)
            {
                FireBall.name = "Right";
                Instantiate(FireBall, gameObject.transform);

                if (CanFire4Balls)
                {
                    FireBall.name = "Up";
                    Instantiate(FireBall, gameObject.transform);
                    FireBall.name = "Down";
                    Instantiate(FireBall, gameObject.transform);
                    FireBall.name = "Left";
                    Instantiate(FireBall, gameObject.transform);
                }
            }
            else
            {
                Ball.name = "Right";
                Instantiate(Ball, gameObject.transform);

                if (CanFire4Balls)
                {
                    Ball.name = "Up";
                    Instantiate(Ball, gameObject.transform);
                    Ball.name = "Down";
                    Instantiate(Ball, gameObject.transform);
                    Ball.name = "Left";
                    Instantiate(Ball, gameObject.transform);
                }
            }
           

            yield return new WaitForSeconds(0.5f);
        }

    }

    public IEnumerator SwitchCanFire4Balls()
    {
        while (true)
        {
            string SceneName = SceneManager.GetActiveScene().name;
            if (SceneName == "MainScene")
            {
                CanFire4Balls = true;
            }
            yield return new WaitForSeconds(0.2f);
        }

    }

}
