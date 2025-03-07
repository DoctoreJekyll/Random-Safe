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

        public void UsePopCorn(int value)
        {
            popCornInPocket -= value;
        }

        private void Update()
        {
            //TODO Disable this
            if (Input.GetKeyDown(KeyCode.Q))
                popCornInPocket += 1000;

            if (Input.GetKeyDown(KeyCode.M))
            {
                PlayerPrefs.DeleteAll();
                Debug.LogWarning("Pocket has been deleted.");
            }
        }
    }
}
