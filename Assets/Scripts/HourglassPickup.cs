using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourglassPickup : MonoBehaviour
{

    [SerializeField] int timeToAdd = 2;
    [SerializeField] int backRotation = 24;
    [SerializeField] AudioClip hourglassPickupSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(hourglassPickupSFX, Camera.main.transform.position);
        FindObjectOfType<Timer>().TimeAdd(timeToAdd);
        FindObjectOfType<ClockHand>().RotateBack(backRotation);
        Destroy(gameObject);
    }

}
