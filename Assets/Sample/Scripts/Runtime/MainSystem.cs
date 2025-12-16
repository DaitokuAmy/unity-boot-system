using System.Collections;
using UnityBootSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sample {
    /// <summary>
    /// メインシステム
    /// </summary>
    public class MainSystem : MainSystemBase {
        /// <summary>
        /// スタート時の引数
        /// </summary>
        private struct StartArgs {
            public string SceneName;
        }

        /// <summary>
        /// リブート時の引数
        /// </summary>
        private struct RebootArgs {
            public string SceneName;
        }

        [SerializeField, Tooltip("引数無し時の開始シーン名")]
        private string _defaultStartSceneName = "scene_a";

        /// <inheritdoc/>
        public override IEnumerator StartRoutine(object[] args) {
            var startArgs = ParseStartArgs(args);
            yield return SceneManager.LoadSceneAsync(startArgs.SceneName);
        }

        /// <inheritdoc/>
        public override IEnumerator RebootRoutine(object[] args) {
            var rebootArgs = ParseRebootArgs(args);
            yield return SceneManager.LoadSceneAsync("empty");
            yield return SceneManager.LoadSceneAsync(rebootArgs.SceneName);
        }

        /// <summary>
        /// Start時引数の解析
        /// </summary>
        private StartArgs ParseStartArgs(object[] args) {
            var startArgs = new StartArgs { SceneName = _defaultStartSceneName };
            if (args.Length > 0) {
                startArgs.SceneName = (string)args[0];
            }

            return startArgs;
        }

        /// <summary>
        /// Reboot時引数の解析
        /// </summary>
        private RebootArgs ParseRebootArgs(object[] args) {
            var rebootArgs = new RebootArgs { SceneName = _defaultStartSceneName };
            if (args.Length > 0) {
                rebootArgs.SceneName = (string)args[0];
            }

            return rebootArgs;
        }
    }
}