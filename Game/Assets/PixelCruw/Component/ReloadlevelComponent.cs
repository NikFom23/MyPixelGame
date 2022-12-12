using UnityEngine;
using UnityEngine.SceneManagement;

namespace PixelCrew.Components
{

    public class ReloadlevelComponent : MonoBehaviour
    {
        public void Reload()
        {
            var scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }   
    }


}