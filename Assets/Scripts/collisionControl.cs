using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionControl : MonoBehaviour
{
    // Floor isimli nesneye �arp�ld���nda 1 kez �al���r.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            Destroy(gameObject, 3f);
            print("Zemine �arp�ld�");
        }
    }
    // Floor isimli nesne ile temas halinde olundu�u s�rece �al���r.
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            print("Zemine �arp�ld� ve halen temas halinde");
        }
    }
    // Floor isimli nesne ile temas kesildi�inde 1 kez �al���r.
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            print("Zeminle temas kesildi");
        }
    }
    // tehlikeliBolge isimli collision alan�na girildi�inde 1 kez �al���r.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "tehlikeliBolge")
        {
            print("tehlikeli b�lgeye girildi.");
        }
    }
    // tehlikeliBolge isimli collision alan�nda bulunuldu�u s�rece �al���r.
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "tehlikeliBolge")
        {
            print("tehlikeli b�lge ile temas halinde");
        }
    }
    // tehlikeliBolge isimli collision alan�ndan ��k�ld���nda 1 kez �al���r.
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "tehlikeliBolge")
        {
            print("tehlikeli b�lge ile temas kesildi");
        }
    }
}
