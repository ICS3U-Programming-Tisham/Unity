using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestTimer : MonoBehaviour
{

    private static TestTimer _instance;

    public Text timerLabel;

    private float time;

    /*void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }*/

    //Begin New
    void Awake()
    {
        //if we don't have an [_instance] set yet
        if (!_instance)
            _instance = this;
        //otherwise, if we do, kill this thing
        else
            Destroy(this.gameObject);


        DontDestroyOnLoad(this.gameObject);
    }
    //End New

    void Update()
    {
        time += Time.deltaTime;

        var minutes = Mathf.Floor(time / 60);
        var seconds = time % 60;//Use the euclidean division for the seconds.
        var fraction = (time * 100) % 100;

        //update the label value
        timerLabel.text = string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction);
    }

    //Reset Timer
    public void ResetTimer()
    {
        time = 0;
        Debug.Log("Timer Reset");
    }

    //Stop Timer
    public void StopTimer()
    {
        //Stop Timer Here

        Debug.Log("Timer Stopped");
    }
}