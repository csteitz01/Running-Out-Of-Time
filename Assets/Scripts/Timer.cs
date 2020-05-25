using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float secondsLeft = 30;
    public bool takingAway = false;

    private void Start()
    {
        textMesh.GetComponent<TextMeshProUGUI>().text = "" + secondsLeft;
    }

    private void Update()
    {
        secondsLeft -= 1 * Time.deltaTime;
        textMesh.GetComponent<TextMeshProUGUI>().text = secondsLeft.ToString("0");

        if (secondsLeft <= 0)
        {
            secondsLeft = 0;
        }
    }

    //IEnumerator TimerTake()
    //{
    //    takingAway = true;
    //    yield return new WaitForSeconds(1);
    //    secondsLeft -= 1;
        
    //    takingAway = false;
    //}

}
