using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDoor : MonoBehaviour
{
    public int health = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projektil")
        {

            health = health - 1;

        }

    }
    void Update()
    {
        if (health == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
