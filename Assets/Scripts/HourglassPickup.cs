using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourglassPickup : MonoBehaviour
{

    [SerializeField] int timeToAdd = 2;
    [SerializeField] int backRotation = 24;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<Timer>().TimeAdd(timeToAdd);
        FindObjectOfType<ClockHand>().RotateBack(backRotation);
        Destroy(gameObject);
    }

}
