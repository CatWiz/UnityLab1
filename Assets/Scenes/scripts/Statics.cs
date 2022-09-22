using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StaticsNamespace;

namespace StaticsNamespace
{
    public class Player
    {
        public static int playerCount = 0;
        public Player()
        {
            playerCount++;
        }
    }

    public class Utilities
    {
        public static int Add(int a, int b) => a + b;
        public static int Multiply(int a, int b) => a * b;
    }
}

public class Statics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var players = new List<Player>();
        players.Add(new Player());
        players.Add(new Player());
        players.Add(new Player());

        Debug.Log($"Current player count: {Player.playerCount}");

        int a = 2, b = 5;
        Debug.Log(Utilities.Add(a, b));
        Debug.Log(Utilities.Multiply(a, b));
    }
}
