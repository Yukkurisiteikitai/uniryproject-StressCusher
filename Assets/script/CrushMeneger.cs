using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrushMeneger : MonoBehaviour
{
    public GameObject retryUi;
    

    public float mixsize;
    public float Crush_speed;
    public float Crush = 2;

    public float physicsPower;
    

    // Start is called before the first frame update
    void Start()
    {
        retryUi.SetActive(false);
        ChangeScale(2,2,2);
        Debug.Log(PrintMeneger.print_text);
        if(PrintMeneger.print_text == null)
        {
            PrintMeneger.print_text = "NO NAME";//@debug
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //îºï™éÆ

        Physics.gravity = new Vector3(0, -physicsPower, 0);

        
        //åªè€éÆ
    }
    void ChangeScale(float x,float y,float z)
    {
        transform.localScale = new Vector3(x, y, z);
        //Debug.Log("nowCrush" + transform.position);//@debug
    }

    
    private void OnTriggerEnter(Collider other)
    {
        
        if (transform.localScale.y > mixsize) {
            Debug.Log("HIt");
            //îºï™éÆ
            //Crush /= 2;



            //åªè€éÆ
            //Crush -= Crush_speed;
            //îºå∏&å∏è≠éÆ
            if(Crush > 0.4)
            {
                Crush -= Crush_speed;
            }
            else
            {
                Crush /= 2;
            }



            ChangeScale(2, Crush, 2);

        }
        else
        {
            retryUi.SetActive(true);
        }
        if (other.gameObject.tag == "Delete")
        {
            Debug.Log("è’ìÀ");//@debug
            Destroy(gameObject);
            retryUi.SetActive(true);
        }
    }


    
}
