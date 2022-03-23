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

    public int experience; 

    //Upgrade weapon
    public bool TryUpgradeWeapon()
    {
        weapon.UpgradeWeapon();
        return true;
    }

}
