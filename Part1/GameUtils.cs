using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18Part1
{
    public class GameUtils
    {
        public static string DescribeItem<T>(T item)
        {
            return "This item is a " + item.ToString();
        }
    }
}
