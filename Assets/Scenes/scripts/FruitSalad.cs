using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FruitSaladNamespace;

namespace FruitSaladNamespace
{
    class Fruit
    {
        public Fruit()
        {
            Debug.Log("Base fruit constructor called");
        }
        public void Chop(uint pieces)
        {
            Debug.Log($"The fruit has been chopped into {pieces} pieces");
        }
        public void SayHello()
        {
            Debug.Log("Hello, I am a fruit");
        }
    }
    class Apple : Fruit
    {
        public Apple()
        {
            Debug.Log("Apple constructor has been called");
        }
        public new void Chop(uint pieces)
        {
            Debug.Log($"An apple has been chopped into {pieces} pieces");
        }
        public new void SayHello()
        {
            Debug.Log("Hello, I am an apple");
        }
    }
}

public class FruitSalad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fruit fruit = new Apple();
        fruit.SayHello();
        fruit.Chop(12);

        var apple = (Apple)fruit;
        apple.SayHello();
        apple.Chop(20);
    }
}
