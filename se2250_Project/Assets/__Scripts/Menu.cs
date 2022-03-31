using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    // 
    public Text levelText, xpText, hitpointText;

    //private int currentCharacterSelection = 0;
    public Image characterSelectionSprite, weaponSprite; 
    public RectTransform xpBar;

    //charcater selection

    //weapon change
    public void OnClick()
    {
        if (GameManager.instance.TryUpgradeWeapon())
            UpdateMenu();

    }


    public void UpdateMenu()
    {
        //weaponSprite.sprite = GameManager.instance.weaponSprite[0];

        levelText.text = "Not Implemented";
        hitpointText.text = GameManager.instance.player.hitpoint.ToString();

        //exp bar
        xpText.text = "Not imp";
        xpBar.localScale = new Vector3 (0.5f, 0, 0);

    }
    
}
