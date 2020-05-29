using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    [SerializeField] float secondsLeft = 30f;
    //public bool freeze = false;

    private void Start()
    {
        textMesh.GetComponent<TextMeshProUGUI>().text = "" + secondsLeft;
    }

    public void TimeGo()
    {
            secondsLeft -= Time.deltaTime;
            textMesh.GetComponent<TextMeshProUGUI>().text = secondsLeft.ToString("0");

            if (secondsLeft <= 0)
            {
                var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex);
            }
    }
        

    public void TimeAdd (float timeAmount)
    {
        secondsLeft += timeAmount;
    }

    //public void TimeStop (float timeAmount)
    //{
    //    while (timeAmount > 0)
    //    {
    //        freeze = true;
    //        timeAmount -= 1 * Time.deltaTime;
    //        Debug.Log(timeAmount);
    //    }
    //    freeze = false;
    //}

    private void Update()
    {
        TimeGo();
    }

}
