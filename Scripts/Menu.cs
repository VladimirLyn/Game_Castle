using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject GameObject;
    public void SetActivateMenu()
    {
        Time.timeScale = 0;
        GameObject.SetActive(true);
    }
    public void SetDeActivateMenu()
    {
        Time.timeScale = 1;
        GameObject.SetActive(false);
    }
}
