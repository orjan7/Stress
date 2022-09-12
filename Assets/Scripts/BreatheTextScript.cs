using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BreatheTextScript : MonoBehaviour
{
    [SerializeField] GameObject _BreatheIn = null;
    [SerializeField] GameObject _HoldYourBreath = null;
    [SerializeField] GameObject _BrathOut = null;

    void Start()
    {
        _HoldYourBreath.SetActive(false);
        _BrathOut.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("HoldYourBreath"))
        {
            _BreatheIn.SetActive(false);
            _HoldYourBreath.SetActive(true);
            _BrathOut.SetActive(false);
        }

        if (other.gameObject.CompareTag("BreatheOut"))
        {
            Debug.Log("Out");
            _BreatheIn.SetActive(false);
            _HoldYourBreath.SetActive(false);
            _BrathOut.SetActive(true);
        }

        if (other.gameObject.CompareTag("HoldYourBreath"))
        {
            _BreatheIn.SetActive(false);
            _HoldYourBreath.SetActive(true);
            _BrathOut.SetActive(false);
        }

        if (other.gameObject.CompareTag("StopTrigger"))
        {
            Debug.Log("Stop");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // name=menue
        }
    }
}
