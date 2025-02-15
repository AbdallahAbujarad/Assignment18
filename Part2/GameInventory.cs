using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18Part2
{
    public class GameInventory : MonoBehaviour
    {
        void Start()
        {
            Inventory potions = new Inventory();
            potions.AddItem("Healing Potion");
            potions.AddItem("Strength Potion");
            Inventory elixirs = new Inventory();
            potions.AddItem("Elixir");
            potions.AddItem("Dark Elixir");

            Inventory combined = potions + elixirs;
            combined.ShowItems();
        }
    }
}


