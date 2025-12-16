using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityBootSystem {
    /// <summary>
    /// MainSystem開始用クラス
    /// </summary>
    public abstract class MainSystemStarter : MonoBehaviour {
        [SerializeField, Tooltip("Bootに使用するシーン名")]
        private string _bootSceneName = "";

        /// <summary>現在利用されているStarter</summary>
        internal static MainSystemStarter Current { get; private set; }

        /// <summary>
        /// MainSystemに渡す引数
        /// </summary>
        public abstract object[] GetArguments();

        /// <summary>
        /// 生成時処理
        /// </summary>
        private void Awake() {
            if (Current != null || BootManager.IsExists) {
                DestroyImmediate(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);
            Current = this;
        }

        /// <summary>
        /// 開始処理
        /// </summary>
        private void Start() {
            if (Current != this) {
                return;
            }

            SceneManager.LoadScene(_bootSceneName);
        }

        /// <summary>
        /// 廃棄時処理
        /// </summary>
        private void OnDestroy() {
            if (Current != this) {
                return;
            }

            Current = null;
        }
    }
}