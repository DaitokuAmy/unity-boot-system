using UnityBootSystem;

namespace Sample {
    /// <summary>
    /// 特定シーンを起動するスターター
    /// </summary>
    public class SceneStarter : MainSystemStarter {
        private string _sceneName;
        
        /// <inheritdoc/>
        public override object[] GetArguments() {
            return new object[] { _sceneName };
        }

        /// <inheritdoc/>
        protected override void AwakeInternal() {
            // 現在のシーン名を格納
            _sceneName = gameObject.scene.name;
        }
    }
}