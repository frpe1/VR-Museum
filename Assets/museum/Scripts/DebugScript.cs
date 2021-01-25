using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void PrintMessage(string msg)
    {
        Debug.Log(msg);
    }
}
