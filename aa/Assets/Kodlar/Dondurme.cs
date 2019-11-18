using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dondurme : MonoBehaviour
{

    public float hiz;

    void Update()
    {
        //cismi döndürmek için
        transform.Rotate(0, 0, hiz * Time.deltaTime);
    }
}
