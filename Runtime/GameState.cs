using UnityEngine;

namespace TeaGames.Unity.GameplayFramework.Runtime
{
    /// <summary>
    /// The GameState contains the state of the game,
    /// which could include things like the list of connected players,
    /// the score, where the pieces are in a chess game,
    /// or the list of what missions you have completed in an open world game.
    /// The GameState (networking is not implemented yet!) exists on the server
    /// and all clients and can replicate freely to keep all machines up to date.
    /// </summary>
    [DisallowMultipleComponent]
    public class GameState : MonoBehaviour
    {
    }
}
