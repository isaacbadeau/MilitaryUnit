using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryUnit.Domain.Soldiers;
using MilitaryUnit.Domain.Weapons;
using MilitaryUnit.Domain.Vehicles;
using MilitaryUnit.Domain;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndDmg = new Random();
            List<Vehicle> gameVehicles = new List<Vehicle> { new Tank(), new TranspoTruck(), new Helicopter() };
            List<Weapon> gameWeapons = new List<Weapon> { new SubMachineGun(), new SAW(), new SniperRifle() };
            List<Soldier> gameSoldiers = new List<Soldier> { new FootSoldier(), new HeavySoldier(), new Sniper() };

            gameVehicles[2].loadTroops(8);
            gameVehicles[2].disembarkTroops(8);
            gameSoldiers[0].Move(3, 5);
            gameSoldiers[0].TakesDamage(rndDmg.Next(0,20));
            gameWeapons[0].FireWeapon();

        }
    }
}
