using System.Collections;
using UnityEngine;

namespace UnityBootSystem {
    /// <summary>
    /// MainSystemの基底クラス
    /// </summary>
    public abstract class MainSystemBase : MonoBehaviour {
        /// <summary>
        /// 開始処理
        /// </summary>
        /// <param name="args">起動時に渡された引数</param>
        public abstract IEnumerator StartRoutine(object[] args);
        
        /// <summary>
        /// リブート処理
        /// </summary>
        /// <param name="args">リブート時に渡された引数</param>
        public abstract IEnumerator RebootRoutine(object[] args);
    }
}