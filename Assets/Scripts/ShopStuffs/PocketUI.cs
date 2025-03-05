using System;
using TMPro;
using UnityEngine;

namespace ShopStuffs
{
    public class PocketUI : MonoBehaviour
    {
        [SerializeField] private Pocket pocket;
        [SerializeField] private TMP_Text  popCornText;


        private void Start()
        {
            popCornText.text = pocket.GetPopCorn().ToString();
        }
    }
}
