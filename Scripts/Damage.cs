using System;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
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

    void Start()
    {
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        PlayerHP();
        PlayerCristals();
    }

    public void PlayerHP()
    {
        i = Convert.ToInt32(HP);
        if (HP > 100) HP = 100;
        PlayerHelthText.text = i.ToString();
        PlayerHelthBar.fillAmount = HP / 100;
        if (HP <= 0) SceneManager.LoadScene("DethScene");
    }
    public void PlayerCristals()
    {

        x = Convert.ToInt32(Cristals);
        PlayerCristalsText.text = x.ToString();
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
                    HP-=20;
                    break;
                }
        }
    }

   
}
