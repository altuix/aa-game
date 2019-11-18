using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{

    int lastLevel;

    //private void Start()
    //{   //tüm saveleri silmek için
    //    //PlayerPrefs.DeleteAll();
    //}

    public void oyunaGit()
    {
        lastLevel = PlayerPrefs.GetInt("lastLevel");
        //kayıtlı level yoksa
        if (lastLevel == 0)
        {
            lastLevel = 1;
        }

        //sahne yükledik
        SceneManager.LoadScene(lastLevel.ToString());
    }

    public void oyundanCik()
    {
        //çıkış için
        Application.Quit();
    }
}
