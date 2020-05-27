using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHand : MonoBehaviour
{


    public void RotateHand()
    {
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * (-12)));
    }

    public void RotateBack (float rotateAmount)
    {
        transform.Rotate(new Vector3(0, 0, rotateAmount));
    }

    // Update is called once per frame
    void Update()
    {
        RotateHand();
    }
}
