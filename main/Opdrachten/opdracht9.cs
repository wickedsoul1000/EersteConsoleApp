using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class opdracht9
{
    public void Start()
    {

        List<Weapon> weapons = new List<Weapon>();

        weapons.Add( new Weapon("glock", 30, "gun"));
        weapons.Add(new Weapon("spoon", 3, "melee"));
        weapons.Add( new Weapon("katana", 40, "sword"));

        foreach (Weapon weapon in weapons) {

            weapon.ShowStats();

        }
    }
}
