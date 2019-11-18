using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCember : MonoBehaviour
{
    Rigidbody2D Fizik;
    public float hiz;
    bool hareketKontrol = false;

    GameObject oyunYoneticisi;

    void Start()
    {
        Fizik = GetComponent<Rigidbody2D>();
        //taga göre OyunYöneticisi objesine ulaştık
        oyunYoneticisi = GameObject.FindGameObjectWithTag("OyunYoneticisiTag");
    }


    void FixedUpdate()
    {
        if (!hareketKontrol)
        {
            Fizik.MovePosition(Fizik.position + Vector2.up * hiz * Time.deltaTime);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DonenCemberTag")
        {
            transform.SetParent(collision.transform);
            hareketKontrol = true;
        }

        if (collision.tag == "KucukCemberTag")
        {
            //ulaştığımız "OyunYöneticisi" objesi içinde "OyunBitti" fonksiyonunu çağırdık
            oyunYoneticisi.GetComponent<OyunYoneticisi>().OyunBitti();
        }
    }
}