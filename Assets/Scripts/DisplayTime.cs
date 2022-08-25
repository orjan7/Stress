using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    float _time = 4;
    float _timStop = 0;
    [SerializeField] Text _timeTex;
    // Start is called before the first frame update
    void Start()
    {
        _timeTex.text = _time.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        var Ball = GameObject.Find("TimeBall").transform.position.y;
        
        _time -= Time.deltaTime;
        Debug.Log(_time);
        if (_time <= _timStop)
        {
            Debug.Log("Test");
        }
        _timeTex.text = Mathf.Round(_time).ToString();

    }
}
