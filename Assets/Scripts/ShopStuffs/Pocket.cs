using System;
using UnityEngine;

namespace ShopStuffs
{
    public class Pocket : MonoBehaviour
    {

        private int popCornInPocket;

        private void Awake()
        {
            CheckPopCornValues();
        }

        private void CheckPopCornValues()
        {
            popCornInPocket = PlayerPrefs.HasKey("popCorn") ? PlayerPrefs.GetInt("popCorn", 0) : 0;
            
            if (popCornInPocket < 0)
            {
                popCornInPocket = 0;
            }
        }

        public int GetPopCorn()
        {
            return popCornInPocket;
        }
        
    }
}
