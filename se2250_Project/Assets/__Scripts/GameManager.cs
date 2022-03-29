using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    //Resources
    public List<Sprite> playerSprite;
    public List<Sprite> weaponSprite;
    public List<int> xpTable;

    //References
    public Player player;
    public Weapons weapon;
    public FloatingTextManager floatingTextManager;
    public int experience; 

    //floating text
    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }

    //Upgrade weapon
    public bool TryUpgradeWeapon()
    {
        weapon.UpgradeWeapon();
        return true;
    }

}
