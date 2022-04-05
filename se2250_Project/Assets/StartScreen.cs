using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
{
    int screen = 0;
    public GameObject startS;
    public GameObject instr;
    public GameObject inv;
    
    // Start is called before the first frame update
    void Start()
    {
      //  screen = 1;
        startS.SetActive(true);
        instr.SetActive(false);
        inv.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       // if(screen == 1)
        {
            if(Input.GetMouseButton(0)){
                startS.SetActive(false);
                instr.SetActive(true);
               // screen = 2;
            }
        
        }
       // else if(screen == 2)
        {
            if(Input.anyKey && !Input.GetMouseButton(0)){
                startS.SetActive(false);
                instr.SetActive(false);
                inv.SetActive(true);
               // screen = 3;
            }
        }
       // else if (screen == 3){
      //      startS.SetActive(false);
      //      instr.SetActive(false);
       // }
    }
}
