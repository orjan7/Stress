using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContolScript : MonoBehaviour
{
    public void StartGameForeSec(int number)
    {
        ControlBreathTime.BreatheTime = number;
        SceneManager.LoadScene("Stress"); // name=menue
    }
    public void Stop()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        SceneManager.LoadScene("Menue"); // name=menue
    }
}
