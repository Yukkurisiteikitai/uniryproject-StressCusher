using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class Setingmause : MonoBehaviour
{

    [DllImport("user32.dll")]
    public static extern bool SetCursorPos(int x, int y);

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveMouse()
    {
        SetCursorPos(1900, 790);
    }
}