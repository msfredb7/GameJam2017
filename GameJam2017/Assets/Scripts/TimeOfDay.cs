using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeOfDay : MonoBehaviour {

    public Text text;
	
	void Update () {

        Display((int)(ScenarioEventManager.GetSeconds() / 60)+8, (int)ScenarioEventManager.GetSeconds() % 60, (int)((ScenarioEventManager.GetSeconds() * 60) % 60));
    }

    void Display(int hours, int minutes, int seconds)
    {
        string hoursString = hours.ToString();
        string minutesString = minutes.ToString();
        string secondsString = seconds.ToString();

        if (hoursString.Length <= 1)
            hoursString = "0" + hoursString;
        if (minutesString.Length <= 1)
            minutesString = "0" + minutesString;
        if (secondsString.Length <= 1)
            secondsString = "0" + secondsString;

        text.text = hoursString + ":" + minutesString + ":" + secondsString;
    }
}
