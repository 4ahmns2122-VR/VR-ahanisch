using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorOne : MonoBehaviour
{
    public GameObject player;
    public Animator anim;
    public static int leafCounter = 0;
    public AudioSource doorsound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && leafCounter == 1)
        {
            anim.SetTrigger("DoorOpen");
            doorsound.Play();
        }
    }
}