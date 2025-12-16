using UnityBootSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sample {
    /// <summary>
    /// ボタン押下時の処理ハンドリング用
    /// </summary>
    public class ButtonPresenter : MonoBehaviour {
        public void ChangeSceneA() {
            SceneManager.LoadScene("scene_a");
        }

        public void ChangeSceneB() {
            SceneManager.LoadScene("scene_b");
        }

        public void RebootSystem() {
            BootManager.Reboot();
        }
    }
}