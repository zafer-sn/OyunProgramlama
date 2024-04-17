using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class degerArtirma : MonoBehaviour
{
    public TMP_Text puanText;
    int sayi = 0;

    private void Start()
    {
        puanText.text = PlayerPrefs.GetInt("puan").ToString();
    }
    public void Artir()
    {
        sayi = PlayerPrefs.GetInt("puan") + 1;
        puanText.text = sayi.ToString();
        PlayerPrefs.SetInt("puan", sayi);

    }

}
