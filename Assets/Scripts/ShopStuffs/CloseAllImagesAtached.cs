using System.Collections.Generic;
using UnityEngine;

namespace ShopStuffs
{
    public class CloseAllImagesAtached : MonoBehaviour
    {

        [SerializeField] private List<GameObject> objectsToClose;

        public void CloseAllImages()
        {
            foreach (var objs in objectsToClose)
            {
                objs.gameObject.SetActive(false);
            }
        }
        
        
        
    }
}
