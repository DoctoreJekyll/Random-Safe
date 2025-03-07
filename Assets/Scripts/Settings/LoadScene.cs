using UnityEngine;
using UnityEngine.SceneManagement;

namespace Settings
{
    public class LoadScene : MonoBehaviour
    {
        public enum LoadType
        {
            ByInt,
            ByString
        }
        
        public LoadType loadType;


        public int sceneIndex;
        public string sceneName;

        public void LoadSceneBy()
        {
            if (loadType == LoadType.ByInt)
            {
                SceneManager.LoadScene(sceneIndex);
            }
            else
            {
                SceneManager.LoadScene(sceneName);
            }
        }

    }
}
