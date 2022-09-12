using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimeBallTrigger : MonoBehaviour
{
    public float _time;
    float _returnTime;
    
    [SerializeField] Text _timeTex;
    [Header("Animation")]
    [SerializeField] Animator _TimeBallTwoSec;
    [SerializeField] Animator _TimeBallForSec;
    [SerializeField] GameObject _BreatheIn = null;
    [SerializeField] GameObject _StopTimeTrigger = null;

    [Header("Buttom")]
    [SerializeField] GameObject _StartButtom;
    [SerializeField] GameObject _StopButtom;
    [SerializeField] GameObject _QuitButtom;
    // Start is called before the first frame update
    void Start()
    {
        _time = ControlBreathTime.BreatheTime;
        _returnTime = _time;
        _TimeBallTwoSec.enabled = false;
        _TimeBallForSec.enabled = false;
        _StopTimeTrigger.SetActive(false);
    }
    void Timeball()
    {
        //Test set animator controller
        if (_time == 2)
        {
            _TimeBallTwoSec.enabled = true;
            GameObject.FindGameObjectWithTag("TimeBallForSec").SetActive(false);
        }
        else
        {
            _TimeBallForSec.enabled = true;
            GameObject.FindGameObjectWithTag("TimeBallTwoSec").SetActive(false);
        }

    }
    public void Play()
    {
        _BreatheIn.SetActive(true);
        Timeball();
        StartCoroutine(waiter());
        _StartButtom.SetActive(false);
        _StopButtom.SetActive(true);
        _QuitButtom.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        if (_TimeBallTwoSec.enabled == true || _TimeBallForSec.enabled == true)
        {
            if (_time > 0)
            {
                _time -= Time.deltaTime;
                _timeTex.text = _time.ToString("0");
            }
            else
            {
                _time = _returnTime;
            }
        }        
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(1);
        _StopTimeTrigger.SetActive(true);
    }
}