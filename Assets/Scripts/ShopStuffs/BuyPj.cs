using System;
using UnityEngine;
using UnityEngine.UI;

namespace ShopStuffs
{
    public class BuyPj : MonoBehaviour
    {

        [SerializeField] private int cost;
        [SerializeField] private Pocket pocket;
        [SerializeField] private string pjKey;

        private Image image;
        private readonly byte c1 = 41;
        private readonly byte c2 = 41;
        private readonly byte c3 = 41;

        private void Start()
        {
            image = GetComponent<Image>();
        }

        public void BuyThisPj()
        {
            if (pocket.GetPopCorn() >= cost)
            {
                EnablePj();
                pocket.UsePopCorn(cost);
            }
        }

        private void EnablePj()
        {
            PlayerPrefs.SetInt(pjKey,1);
            image.color = new Color32(c1, c2, c3,255);
        }
    }
}
