
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace clasePlayer
{
    public class character
    {

        public string name;
        private int kills;
        private int healthPoints;

        public character(string name)
        {
            this.name = name;
            healthPoints = 10;
            Debug.Log("Hola, soy" + name);
        }

     
        public int getKills()
        {
            return kills;
        }
    }
}
