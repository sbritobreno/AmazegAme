using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitWin : MonoBehaviour
{
    //When player collides to the object this script is attached to,
    //it calls a function Finnish thats finishes the game by stopping the timer.
    private void OnTriggerEnter(Collider other)
    {
        //Finnish function locate in Timer.cs script.
        GameObject.Find("Player").SendMessage("Finnish");
    }
}
