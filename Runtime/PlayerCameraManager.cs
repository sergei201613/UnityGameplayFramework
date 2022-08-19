using UnityEngine;

namespace TeaGames.Unity.GameplayFramework.Runtime
{
    /// <summary>
    /// The PlayerCameraManager is the "eyeball" for a player and manages how it behaves.
    /// Each PlayerController typically has one of these as well.
    /// </summary>
    [DisallowMultipleComponent]
    [DefaultExecutionOrder(-100)]
    public class PlayerCameraManager : MonoBehaviour
    {
        public Camera Current { get; private set; }

        private void Awake()
        {
            Current = Camera.main;
        }
    }
}
