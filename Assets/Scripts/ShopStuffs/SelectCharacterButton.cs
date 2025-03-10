using UnityEngine;

namespace ShopStuffs
{
    public class SelectCharacterButton : MonoBehaviour
    {

        [SerializeField] private PjSelectable pjSelected;
        private readonly string playerSelectableKey = "PlayerIdActive";

        public void Select(PjSelectable selectable)
        {
            pjSelected = selectable;
        }
        
        public void Pick()
        {
            PlayerPrefs.SetInt(playerSelectableKey, pjSelected.SelectorID);
            Debug.Log("Picked" +  pjSelected.SelectorID);
        }


    }
}
