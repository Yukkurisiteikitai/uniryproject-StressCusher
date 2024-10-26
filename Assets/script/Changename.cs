using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changename : MonoBehaviour
{
    public GameObject startmenu;
    public void Show_up()
    {
        startmenu.SetActive(true);
    }
    public void Show_down()
    {
        startmenu.SetActive(false);
    }
}
