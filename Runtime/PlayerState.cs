using UnityEngine;

namespace TeaGames.Unity.GameplayFramework.Runtime
{
    /// <summary>
    /// A PlayerState is the state of a participant in the game,
    /// such as a human player or a bot that is simulating a player.
    /// Non-player AI that exists as part of the game would not have a PlayerState.
    /// Example data that would be appropriate in a PlayerState include
    /// player name, score, in-match level for something like a MOBA, or
    /// whether the player is currently carrying the flag in a CTF game.
    /// PlayerStates for all players exist on all machines (unlike PlayerControllers)
    /// and can replicate freely to keep things in sync.
    /// </summary>
    [DisallowMultipleComponent]
    public class PlayerState : MonoBehaviour
    {
    }
}
