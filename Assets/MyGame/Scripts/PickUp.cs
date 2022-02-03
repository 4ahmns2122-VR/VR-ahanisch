using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject leaf;
    public GameObject player;
    public AudioSource pickup;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            pickup.Play();
            OpenDoorOne.leafCounter++;
            //other.gameObject.GetComponent<UserInput>().munition += leaf;
            Destroy(this.gameObject);
            
        }
    }
}
