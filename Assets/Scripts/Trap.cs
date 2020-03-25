using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public int hitPoints = 10;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Hit trap");
        collider.gameObject.GetComponent<Player>().TakeDamage(hitPoints);
        audioSource.Play();
    }
}
