using UnityEngine;
using UnityEngine.UI;

public class ClearTimer : MonoBehaviour
{
    Text timeText;
    
    void Start()
    {
        timeText = GetComponent<Text>();
    }
    
    float clearTime;
    //bool win = false;

    void FixedUpdate()
    {
        //if (win) return;
        clearTime += Time.fixedDeltaTime;
        timeText.text = System.TimeSpan.FromSeconds(value: clearTime).ToString(format: @"mm\:ss\:ff");
    }

    public void stop()
    {
        //win = true;
        Time.timeScale = 0;
    }

    public void resume()
    {
        //win = true;
        Time.timeScale = 1;
        clearTime = 0;
    }
}
