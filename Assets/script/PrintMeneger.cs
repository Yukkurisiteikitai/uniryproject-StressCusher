using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PrintMeneger : MonoBehaviour
{
    public GameObject Pushing_buttonUi;

    public GameObject Pushing;
    //public GameObject MouseMove;
    public static bool skipName;
    public static string name_save;

    public GameObject Startmenu;
    public InputField print;
    public static string print_text;
    public Text name;
    // Start is called before the first frame update
    void Start()
    {
        Pushing_buttonUi.SetActive(false);
        ChengeMove(false);
        if (skipName == true)
        {
            Debug.Log("a");//@debug
            Printe_retry();
            skipName = false;
        }
        else
        {
            Startmenu.SetActive(true);


        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            Printe();
        }
    }
    public void Printe()
    {
        //MouseMove.GetComponent<Setingmause>().MoveMouse();
        print_text = print.text;
        Startmenu.SetActive(false);
        name.text = print.text.ToString();
        Retry.restart = false;
        ChengeMove(true);
        name_save = print_text;
    }private void Printe_retry()
    {
        //MouseMove.GetComponent<Setingmause>().MoveMouse();
        name.text = name_save;
        Retry.restart = false;
        //Pushing.SetActive(true);
        ChengeMove(true);
        Startmenu.SetActive(false);
        
    }

    public void SkipingName()
    {
        skipName = true;
    }private void ChengeMove(bool switch_move)
    {
        //Pushing.GetComponent<PrintMeneger>().enabled = switch_move;
        Pushing.SetActive(switch_move);
    }
}
