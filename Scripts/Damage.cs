using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    public Image PlayerHelthBar;
    public TMP_Text PlayerHelthText;
    public TMP_Text PlayerCristalsText;
    float HP = 100;
    public int Cristals = 0;
    int i, x;
    bool CanTakeDamage = true;

    void Start()
    {
        StartCoroutine(PlayerHP());
        StartCoroutine(PlayerCristals());
    }
    public IEnumerator PlayerHP()
    {
        while (true)
        {
            i = Convert.ToInt32(HP);
            if (HP > 100) HP = 100;
            PlayerHelthText.text = i.ToString();
            PlayerHelthBar.fillAmount = HP / 100;
            if (HP <= 0) SceneManager.LoadScene("DethScene");
            yield return new WaitForSeconds(0.1f);
        }
    }
    public IEnumerator PlayerCristals()
    {
        while (true)
        {
            x = Convert.ToInt32(Cristals);
            PlayerCristalsText.text = x.ToString();
            yield return new WaitForSeconds(0.1f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case ("Cristals"):
                {
                    Debug.Log("Cristals");
                    Cristals++;
                    collision.gameObject.SetActive(false);
                    break;
                }
            case ("fire"):
                {
                    Debug.Log("Fire");
                    if (CanTakeDamage)
                    {
                        HP -= 20;
                    }
                    StartCoroutine(SwitchCanTakeDamage());
                    break;
                }
        }
    }

    public IEnumerator SwitchCanTakeDamage()
    {
        CanTakeDamage = false;
        yield return new WaitForSeconds(0.2f);
        CanTakeDamage = true;
    }
}