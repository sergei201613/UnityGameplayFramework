using UnityEngine;

namespace TeaGames.Unity.GameplayFramework.Runtime
{
    /// <summary>
    /// The concept of a "game" is split into 2 classes.
    /// The GameMode and GameState is the definition of the game,
    /// including things like the game rules and win conditions.
    /// It only exists on the server (networking is not implemented yet!).
    /// It typically should not have much data that changes during play, 
    /// and it definitely should not have transient data that clients need to know about.
    /// </summary>
    [DisallowMultipleComponent]
    public class GameMode : MonoBehaviour
    {
    }
}
