using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BallTigger : MonoBehaviour
{
    [SerializeField] GameObject BreathIn = null;
    [SerializeField] GameObject HoldYouBreath = null;
    [SerializeField] GameObject BreathOut = null;
    [SerializeField] GameObject BreathFinished = null;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("HoldYourBreath"))
        {
            BreathIn.SetActive(false);
            BreathOut.SetActive(false);
            HoldYouBreath.SetActive(true);
        }
        if (other.gameObject.CompareTag("BreatheOut"))
        {
            HoldYouBreath.SetActive(false);
            BreathOut.SetActive(true);
        }
        if (other.gameObject.CompareTag("StopTrigger"))
        {
            BreathFinished.SetActive(true);
            SceneManager.LoadScene("Menue");
        }
    }
}
