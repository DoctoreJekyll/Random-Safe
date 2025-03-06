using System;
using UnityEngine;
using UnityEngine.UI;

namespace ShopStuffs
{
    public class PjSelectable : MonoBehaviour
    {

        [SerializeField] private string pjKey;

        [Header("Components")]
        [SerializeField] private Button button;
        [SerializeField] private Image image;

        private void Awake()
        {
            button = GetComponent<Button>();
            image = GetComponent<Image>();
        }

        private void Start()
        {
            EnableComponents();
        }

        private void EnableComponents()
        {
            if (!PlayerPrefs.HasKey(pjKey)) return;
            if (PlayerPrefs.GetInt(pjKey) != 1) return;
            button.enabled = true;
            image.enabled = true;
        }
    }
}
