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
    public Text TextPotom;
    public static float HP = 100;
    public int Cristals = 0;
    int i, x;
    bool CanTakeDamage = true;
    bool CanTakeCristals = true;
    public static bool TakebonusHP = false, TakebonusDamage = false;
    void Start()
    {
        StartCoroutine(PlayerHP());
    }
    public IEnumerator PlayerHP()
    {
        while (true)
        {

            if (TakebonusHP)
            {
                HP += 0.1f;
            }
            i = Convert.ToInt32(HP);
            if (HP > 100) HP = 100;
            PlayerHelthText.text = i.ToString();
            PlayerHelthBar.fillAmount = HP / 100;
            if (HP <= 0) SceneManager.LoadScene("DethScene");
            yield return new WaitForSeconds(0.1f);
        }
    }
    /*
    public IEnumerator PlayerCristals()
    {
        while (true)
        {
            x = Convert.ToInt32(Cristals);
            PlayerCristalsText.text = x.ToString();
            yield return new WaitForSeconds(0.1f);
        }
    }
    */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case ("Cristals"):
                {
                    if (CanTakeCristals)
                    {
                        Debug.Log("Cristals");
                    }
                    TakebonusHP = true;
                    break;
                }
            case ("BonusDamage"):
                {
                    TakebonusDamage = true;
                    break;
                }
            case ("Anemy"):
                {
                    Debug.Log("Fire");
                    if (CanTakeDamage)
                    {
                        HP -= 10;
                    }
                    StartCoroutine(SwitchCanTakeDamage());
                    break;
                }
            case ("StrongAnemy"):
                {
                    Debug.Log("Fire");
                    if (CanTakeDamage)
                    {
                        HP -= 15;
                    }
                    StartCoroutine(SwitchCanTakeDamage());
                    break;
                }
            case ("TeleportToSecondLevel"):
                {
                    Debug.Log("TeleportToMainLevel");
                    SceneManager.LoadScene("FirstScene");
                    break;
                }

            case ("TeleportTOThirdtinLevel"):
                {
                    if (TakebonusHP)
                    {
                        SceneManager.LoadScene("SecondScene");
                    }
                    else
                    {
                        TextPotom.text = "Пройдите более ранние уровни (ближе к спавну)";
                    }
                    break;
                }
            case ("TeleportToFourtinLevel"):
                {
                    if (TakebonusDamage)
                        SceneManager.LoadScene("ThirdScene");
                    else
                    {
                        TextPotom.text = "Пройдите более ранние уровни (ближе к спавну)";
                    }
                    break;
                }
            case ("GoToMainScene"):
                {
                    Debug.Log("TeleportToMainLevel");
                    SceneManager.LoadScene("MainScene");
                    break;
                }
            case ("Potom"):
                {
                    Debug.Log("Potom");
                    StartCoroutine(Potom());
                    break;
                }
            case ("Boss1Ball"):
                {
                    if (CanTakeDamage)
                    {
                        HP -= 30;
                    }
                    StartCoroutine(SwitchCanTakeDamage());
                    break;
                }
            case ("Exit"):
                {
                    StartCoroutine(StartExit());
                    break;
                }
        }
    }

    public IEnumerator SwitchCanTakeDamage()
    {
        CanTakeDamage = false;
        yield return new WaitForSeconds(1f);
        CanTakeDamage = true;
        StopCoroutine(SwitchCanTakeDamage());
    }
    public IEnumerator SwitchCanTakeCristals()
    {
        CanTakeCristals = false;
        yield return new WaitForSeconds(0.05f);
        CanTakeCristals = true;
    }

    public IEnumerator Potom()
    {
        TextPotom.text = "Скоро будет доступно";
        yield return new WaitForSeconds(2f);
        TextPotom.text = "";
    }

    public IEnumerator StartExit()
    {
        yield return new WaitForSeconds(5);
        Application.Quit();
    }

}