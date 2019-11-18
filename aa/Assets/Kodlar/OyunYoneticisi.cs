using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunYoneticisi : MonoBehaviour
{
    GameObject donenCember;
    GameObject anaCember;

    public Text DonenCarkLevelText;
    public Text bir;
    public Text iki;
    public Text uc;
    public int kacKucukCemberOlsun;

    bool gameOver = false;

    public Animator animator;


    IEnumerator OyunBittiAction()
    {
        gameOver = true;

        //scriptleri çıkarmış olduk böylece oyun durdu
        anaCember.GetComponent<AnaCember>().enabled = false;
        donenCember.GetComponent<Dondurme>().enabled = false;

        //oluşturduğumuz "OyunBitti" adlı animasyonu set ettik;
        animator.SetTrigger("OyunBitti");

        yield return new WaitForSeconds(2);
        //menuye döndük
        SceneManager.LoadScene("AnaMenu");
        Debug.Log("oyun bitti");
    }

    public void OyunBitti()
    {
        StartCoroutine(OyunBittiAction());
    }

    void Start()
    {
        //level no yazdırdık
        DonenCarkLevelText.text = SceneManager.GetActiveScene().name;

        donenCember = GameObject.FindGameObjectWithTag("DonenCemberTag");
        anaCember = GameObject.FindGameObjectWithTag("AnaCemberTag");

        if (kacKucukCemberOlsun < 2)
        {
            bir.text = kacKucukCemberOlsun.ToString();
        }
        else if (kacKucukCemberOlsun < 3)
        {
            bir.text = kacKucukCemberOlsun.ToString();
            iki.text = (kacKucukCemberOlsun - 1).ToString();

        }
        else
        {
            bir.text = kacKucukCemberOlsun.ToString();
            iki.text = (kacKucukCemberOlsun - 1).ToString();
            uc.text = (kacKucukCemberOlsun - 2).ToString();

        }
    }

    public void KucukCemberdeTextGosterme()
    {
        kacKucukCemberOlsun--;
        if (kacKucukCemberOlsun < 2)
        {
            bir.text = kacKucukCemberOlsun.ToString();
            iki.text = "";
            uc.text = "";

        }
        else if (kacKucukCemberOlsun < 3)
        {
            bir.text = kacKucukCemberOlsun.ToString();
            iki.text = (kacKucukCemberOlsun - 1).ToString();
            uc.text = "";

        }
        else
        {
            bir.text = kacKucukCemberOlsun.ToString();
            iki.text = (kacKucukCemberOlsun - 1).ToString();
            uc.text = (kacKucukCemberOlsun - 2).ToString();

        }
        if (kacKucukCemberOlsun == 0)
        {
            StartCoroutine(yeniLevel());
        }
    }

    IEnumerator yeniLevel()
    {
        anaCember.GetComponent<AnaCember>().enabled = false;
        donenCember.GetComponent<Dondurme>().enabled = false;

        yield return new WaitForSeconds(0.5f);

        if (!gameOver)
        {
            animator.SetTrigger("YeniLevel");
            yield return new WaitForSeconds(1);

            string newLevelName = (int.Parse(SceneManager.GetActiveScene().name) + 1).ToString();
            SceneManager.LoadScene(newLevelName);
        }
       
    }


}
