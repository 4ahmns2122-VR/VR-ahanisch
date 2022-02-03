using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zielscheibe : MonoBehaviour
{
    public Animator EndDoor;
    private void OnCollisionEnter(Collision collision)
    {
        print(0);
        if (collision.gameObject.CompareTag("Snowball"))
        {
            print(1);
            EndDoor.SetTrigger("EndDoor");
        }
    }

}
