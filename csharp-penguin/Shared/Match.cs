using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPenguin.Shared
{
    public class Match
    {
        public string MatchId { get; set; }
        public int MapWidth { get; set; }
        public int MapHeight { get; set; }
        public int WallDamage { get; set; }
        public int PenguinDamage { get; set; }
        public int WeaponDamage { get; set; }
        public int Visibility { get; set; }
        public int WeaponRange { get; set; }
        public You You { get; set; }
        public Enemy[] Enemies { get; set; }
        public Wall[] Walls { get; set; }
        public Bonustile[] BonusTiles { get; set; }
        public int SuddenDeath { get; set; }
        public Fire[] Fire { get; set; }
    }

    public class You
    {
        public string Direction { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Strength { get; set; }
        public int Ammo { get; set; }
        public string Status { get; set; }
        public int WeaponDamage { get; set; }
        public int WeaponRange { get; set; }
        public int TargetRange { get; set; }
        public string Bonus { get; set; }
    }

    public class Enemy
    {
        public string Direction { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Strength { get; set; }
        public int Ammo { get; set; }
        public int WeaponDamage { get; set; }
        public int WeaponRange { get; set; }
    }

    public class Wall
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Strength { get; set; }
    }

    public class Bonustile
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
    }

    public class Fire
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
