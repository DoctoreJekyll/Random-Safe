using UnityEngine;

namespace ShopStuffs
{
    public class PickPj : MonoBehaviour
    {
        private readonly string playerSelectableKey = "PlayerIdActive";
        [SerializeField] private PjSelectable selector;

        public void Pick()
        {
            PlayerPrefs.SetInt(playerSelectableKey, selector.SelectorID);
        }
    }
}
