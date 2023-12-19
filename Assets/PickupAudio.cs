using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAudio : MonoBehaviour
{
    public AudioClip pickupSound;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = pickupSound;
    }

    void OnTriggerEnter(Collider other)
    {
 
        if (other.CompareTag("Player"))
        {

            audioSource.Play();

        }
    }
}
// Update is called once per frame
