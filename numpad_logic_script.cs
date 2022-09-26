using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
public class NumpadLogic : MonoBehaviour
{
    public string winCode = "4236";
    protected string currentCode = "0000";
    public UnityEvent onWin;
    public TMPro.TextMeshProUGUI display;
    void Awake() {
    currentCode = display.text;
    }
    public void ButtonPressed(int val) {
        currentCode = currentCode.Substring(1) + val.ToString();
        display.text = currentCode;
            if (currentCode == winCode) {
            Debug.Log("WINNER!");
                if (onWin != null) {
                onWin.Invoke();
                }
            }
    }
}

// Function: This script is in two parts. It obtains user input to exit the building and prints a
// congratulatory message upon completion of the drill.
// Explanation: A fixed code to exit is saved as ‘WINCODE’ with the code being ‘1111’. If the user
// enters the right code, the door opens. Simultaneously, a UI panel displaying a congratulatory
// message is activated.