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

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            Debug.Log("Hit trap");
            collision.gameObject.GetComponent<Player>().TakeDamage(hitPoints);
            audioSource.Play();
        }

    }
}
