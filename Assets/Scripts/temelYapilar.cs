using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temelYapilar : MonoBehaviour
{
    /*
     Awake starttan �nce �al���r
     Script componenti aktif olmasa bile Awake �al���r
     */
    private void Awake()
    {
        print("AWAKE �al��t�"); //Debug.Log("AWAKE �al��t�");
    }
    private void Start()
    {
        Debug.Log("START �al��t�");
        
    }
    /*
     Update metodu bir saniyede ka� kara al�n�yorsa o kadar kez �al���r.
     FixedUpdate metodu saniyede daima 50 kez �al���r(de�i�tirilmezse)
     LateUpdate ise Update ile ayn�d�r sadece Update ve FixedUpdate'ten sonra �al���r.
     */
    private void Update()
    {
        print("UPDATE �al��t�");
        print(Time.fixedDeltaTime);
    }

    private void FixedUpdate()
    {
        print("FixedUPDATE �al��t�");

    }

    private void LateUpdate()
    {
        print("LateUPDATE �al��t�");

    }


}
