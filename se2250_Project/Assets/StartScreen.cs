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
        startS.SetActive(true);
        instr.SetActive(false);
        inv.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        {
            if(Input.GetMouseButton(0)){
                startS.SetActive(false);
                instr.SetActive(true);
            }
        
        }
        {
            if(Input.anyKey && !Input.GetMouseButton(0)){
                startS.SetActive(false);
                instr.SetActive(false);
                inv.SetActive(true);
            }
        }
    }
}
