using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Weapon
{
    private string name;
    private string Type;
    private int damage;
    public Weapon(string weaponName, int weaponDamage, string WeaponType)
    {
        name = weaponName;
        damage = weaponDamage;
        Type = WeaponType;

    }
    public void upgradeItem(int damageToAdd)
    {
        damage += damageToAdd;
    }
    public void ShowStats()
    {
        Console.WriteLine($"{name} is a {Type} type does {damage} damage");
       
    }
}
