using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour
{
    public void LoadLevel2()
    {
        Damage.HP = 100;
        SceneManager.LoadScene("MainScene");
    }

}
