using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushController : MonoBehaviour
{
    Vector3 screenPoint;
    public GameObject anyButtonUi;


    bool setMouse = false;
    public static bool setMouse_save;

    public GameObject c;
    // Start is called before the first frame update
    void Start()
    {

        if (setMouse == false && setMouse_save == false)
        {
            //anyButtonUi.SetActive(true);
        }
        
        c.SetActive(false);
        //setMouse = setMouse_save;
        setMouse = true;
    }

    // Update is called once per frame
    void Update()
    {
        //àÍéûí‚é~ÇÃëÄçÏ
        //if(Input.anyKey) {
        //    setMouse = true;
        //    anyButtonUi.SetActive(false);
        //    setMouse_save = true;
        //}
        if (setMouse == true)
        {
            this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 a = new Vector3 (Input.mousePosition.x,Input.mousePosition.y,screenPoint.z);
            transform.position = Camera.main.ScreenToWorldPoint (a);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.tag == "Delete")
        //{
            //Destroy(gameObject);
            //c.SetActive(true);
        //}
        
    }
}
