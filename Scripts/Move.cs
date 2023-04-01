using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Move : MonoBehaviour
{
    public FixedJoystick FixedJoystickOnCanvas;
    public Rigidbody2D RigidBodyOfPlayer;
    readonly float MovementSpeed = 10;
    float vertical, horizontal;
    bool CanMoveVertical = false;

    private void Start()
    {
        StartCoroutine(SwitchCanMoveVertical());
        RigidBodyOfPlayer = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        horizontal = FixedJoystickOnCanvas.Horizontal * MovementSpeed * Time.deltaTime;
        transform.Translate(horizontal, 0, 0);

        if (CanMoveVertical)
        {
            vertical = FixedJoystickOnCanvas.Vertical * MovementSpeed * Time.deltaTime;
            transform.Translate(0, vertical, 0);
        }

    }
    public IEnumerator SwitchCanMoveVertical()
    {
        while (true)
        {
            string SceneName = SceneManager.GetActiveScene().name;
            if (SceneName == "MainScene")
            {
                CanMoveVertical = true;
            }
            yield return new WaitForSeconds(0.2f);
        }

    }
}
