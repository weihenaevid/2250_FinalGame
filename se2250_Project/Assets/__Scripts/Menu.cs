using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    // 
    public Text levelText, xpText;

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
    }
    
}
