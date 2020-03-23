using System;
using UnityEngine;
using UnityEngine.Events;

public class EnumsSwitches : MonoBehaviour
{

    public UnityEvent idleEvent, walkEvent, runEvent, jumpEvent;
    public UnityEvent startingEvent, playingEvent, inStoreEvent, pausingEvent, endingEvent;

    public enum GameStates
    {
        Starting,
        Playing,
        InStore,
        Pausing,
        Ending
    }

    public GameStates currentGameState;

    public enum PlayerStates
    {
        Idle,
        Walk,
        Run,
        Jump
    }

    public void ChangeStateToPlaying()
    {
        currentGameState = GameStates.Playing;
    }
    
    public void ChangeStateToPausing()
    {
        currentGameState = GameStates.Pausing;
    }
    
    public void ChangeStateToInStore()
    {
        currentGameState = GameStates.InStore;
    }
    
    public void ChangeStateToStarting()
    {
        currentGameState = GameStates.Starting;
    }
    
    public void ChangeStateToEnding()
    {
        currentGameState = GameStates.Ending;
    }
    
    public PlayerStates currentPlayerState;


    void Update()
    {
        switch (currentPlayerState)
        {
            case PlayerStates.Idle:
                idleEvent.Invoke();
                break;
            case PlayerStates.Walk:
               walkEvent.Invoke();
                break;
            case PlayerStates.Run:
                runEvent.Invoke();
                break;
            case PlayerStates.Jump:
                jumpEvent.Invoke();
                break;
            default:
               print("I am any");
               break;
        }

        switch (currentGameState)
        {
            case GameStates.Starting:
                startingEvent.Invoke();
                break;
            case GameStates.Playing:
                playingEvent.Invoke();
                break;
            case GameStates.InStore:
                inStoreEvent.Invoke();
                break;
            case GameStates.Pausing:
                pausingEvent.Invoke();
                break;
            case GameStates.Ending:
                endingEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
