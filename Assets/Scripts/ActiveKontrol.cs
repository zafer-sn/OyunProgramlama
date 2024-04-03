using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActiveKontrol : MonoBehaviour
{
    private void Start()
    {
        Invoke("nesneyi_yoket", 5f);
    }

    private void OnEnable()
    {
        print("Nesne aktiftir.");
    }

    private void OnDisable()
    {
        print("Nesne aktif de�ildir.");
    }

    private void OnDestroy()
    {
        print("Nesne silinmi�tir.");
    }

    void nesneyi_yoket()
    {
        Destroy(gameObject);
    }
}
