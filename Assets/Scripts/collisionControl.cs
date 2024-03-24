using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionControl : MonoBehaviour
{
    // Floor isimli nesneye çarpýldýðýnda 1 kez çalýþýr.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            Destroy(gameObject, 3f);
            print("Zemine çarpýldý");
        }
    }
    // Floor isimli nesne ile temas halinde olunduðu sürece çalýþýr.
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            print("Zemine çarpýldý ve halen temas halinde");
        }
    }
    // Floor isimli nesne ile temas kesildiðinde 1 kez çalýþýr.
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            print("Zeminle temas kesildi");
        }
    }
    // tehlikeliBolge isimli collision alanýna girildiðinde 1 kez çalýþýr.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "tehlikeliBolge")
        {
            print("tehlikeli bölgeye girildi.");
        }
    }
    // tehlikeliBolge isimli collision alanýnda bulunulduðu sürece çalýþýr.
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "tehlikeliBolge")
        {
            print("tehlikeli bölge ile temas halinde");
        }
    }
    // tehlikeliBolge isimli collision alanýndan çýkýldýðýnda 1 kez çalýþýr.
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "tehlikeliBolge")
        {
            print("tehlikeli bölge ile temas kesildi");
        }
    }
}
