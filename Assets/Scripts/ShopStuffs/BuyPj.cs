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
        private readonly float c1 = 41f;
        private readonly float c2 = 41f;
        private readonly float c3 = 41f;

        private void Start()
        {
            image = GetComponent<Image>();
        }

        public void BuyThisPj()
        {
            if (pocket.GetPopCorn() > cost)
            {
                EnablePj();
                pocket.UsePopCorn(cost);
            }
        }

        private void EnablePj()
        {
            PlayerPrefs.SetInt(pjKey,1);
            image.color = new Color(c1, c2, c3);
        }
    }
}
