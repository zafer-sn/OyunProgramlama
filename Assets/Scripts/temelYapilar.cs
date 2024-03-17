using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temelYapilar : MonoBehaviour
{
    /*
     Awake starttan önce çalýþýr
     Script componenti aktif olmasa bile Awake çalýþýr
     */
    private void Awake()
    {
        print("AWAKE çalýþtý"); //Debug.Log("AWAKE çalýþtý");
    }
    private void Start()
    {
        Debug.Log("START çalýþtý");
        
    }
    /*
     Update metodu bir saniyede kaç kara alýnýyorsa o kadar kez çalýþýr.
     FixedUpdate metodu saniyede daima 50 kez çalýþýr(deðiþtirilmezse)
     LateUpdate ise Update ile aynýdýr sadece Update ve FixedUpdate'ten sonra çalýþýr.
     */
    private void Update()
    {
        print("UPDATE çalýþtý");
        print(Time.fixedDeltaTime);
    }

    private void FixedUpdate()
    {
        print("FixedUPDATE çalýþtý");

    }

    private void LateUpdate()
    {
        print("LateUPDATE çalýþtý");

    }


}
