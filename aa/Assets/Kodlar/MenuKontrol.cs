using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{


    public void oyunaGit()
    {
        //sahne yükledik
        SceneManager.LoadScene("1");
    }

    public void oyundanCik()
    {
        //çıkış için
        Application.Quit();
    }
}
