using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    // fields
    public Text levelText, xpText, hitpointText;
    public Image characterSelectionSprite, weaponSprite; 
    public RectTransform xpBar;

    public GameObject playerG0;      // rehead
    public GameObject playerG1;      // wizard
    public GameObject playerG2;      // pirate


    public void UpdateMenu()
    {
        levelText.text = GameManager.instance.GetCurrentLevel().ToString();

        if(playerG0.activeInHierarchy){
            hitpointText.text = GameManager.instance.player1.hitpoint.ToString();
        }
        else if(playerG1.activeInHierarchy)
        {
            hitpointText.text = GameManager.instance.player2.hitpoint.ToString();
        }
        else if(playerG2.activeInHierarchy)
        {
            hitpointText.text = GameManager.instance.player3.hitpoint.ToString();
        }

        //exp bar
        int currLevel = GameManager.instance.GetCurrentLevel();
        if(currLevel == GameManager.instance.xpTable.Count)
        {
            xpText.text = GameManager.instance.experience.ToString() + " total experience points"; //display total xp
            xpBar.localScale = Vector3.one;
        }
        else 
        {
            int prevLevelXp = GameManager.instance.GetXpToLevel(currLevel - 1);
            int currLevelXp = GameManager.instance.GetXpToLevel(currLevel);

            int diff = currLevelXp - prevLevelXp;
            int currXpIntoLevel = GameManager.instance.experience - prevLevelXp;

            float completionRatio = (float)currXpIntoLevel / (float)diff;
            xpBar.localScale = new Vector3(completionRatio, 1, 1);
            xpText.text = currXpIntoLevel.ToString() + " / " + diff;
        }

    }
    
}
