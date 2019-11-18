using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaCember : MonoBehaviour
{
    public GameObject kucukCember;
    GameObject OyunYonetici;

    public float saplamaHizi = 5;
    // Start is called before the first frame update
    void Start()
    {
        OyunYonetici = GameObject.FindGameObjectWithTag("OyunYoneticisiTag");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            kucukCemberOlustur();
            OyunYonetici.GetComponent<OyunYoneticisi>().KucukCemberdeTextGosterme();
        }

    }

    void kucukCemberOlustur()
    {
        Instantiate(kucukCember, transform.position * saplamaHizi * Time.deltaTime, transform.rotation);
    }
}
