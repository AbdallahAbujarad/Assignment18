using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18Part1
{
    
    public class GenericsTest : MonoBehaviour
    {
        private void Start() {
            GameContainer<string> container = new GameContainer<string>();
            container.SetItem("Healing Potion");
            Debug.Log("Stored Item : " + container.GetItem());
            Debug.Log(GameUtils.DescribeItem(container.GetItem()));
        }
    }

}
