using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
{
    int state = 0;
    public GameObject startScreen;
    public GameObject instructionScreen;
    public GameObject inventory;
    
    // Start is called before the first frame update
    void Start()
    {
        startScreen.SetActive(true);
        instructionScreen.SetActive(false);
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(state == 0){//start state
            if(Input.GetKeyDown(KeyCode.Alpha0)){
                startScreen.SetActive(false);
                instructionScreen.SetActive(true);
                state = 1;
            }
        
        }
        if(state == 1){//instructions state
            if(Input.GetKeyDown(KeyCode.Alpha1)){
                startScreen.SetActive(false);
                instructionScreen.SetActive(false);
                inventory.SetActive(true);
            }
        }
    }
}
