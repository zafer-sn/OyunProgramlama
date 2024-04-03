using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class incrementBut : MonoBehaviour
{
    int deger = 0;
    public TMP_Text deger_text;
    private void Awake()
    {
        print("Bu awaketir");
    }
    public void Start()
    {
        print("Selamlar");
    }

    private void Update()
    {
        deger_text.text = deger.ToString();
    }

    public void incre()
    {
        deger++;
    }
}
