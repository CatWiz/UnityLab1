using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameNamespace;

namespace GameNamespace
{
    public class Player
    {
        private int experience;
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        public int Level
        {
            get { return experience / 1000; }
            set { experience = value * 1000; }
        }
        public int Health { get; set; }
    }
}

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var player = new Player();
        
        player.Experience = 2500;
        Debug.Log($"Player exp: {player.Experience}");
        Debug.Log($"Player lvl: {player.Level}");

        player.Level = 5;
        Debug.Log($"Player exp: {player.Experience}");
        Debug.Log($"Player lvl: {player.Level}");
    }
}
