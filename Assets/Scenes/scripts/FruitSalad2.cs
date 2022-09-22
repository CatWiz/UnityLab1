using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FruitSalad2Namespace;

namespace FruitSalad2Namespace
{
    class Fruit
    {
        public string Color;
        public Fruit()
        {
            Color = "orange";
            Debug.Log("First base fruit constructor called");
        }
        public Fruit(string color)
        {
            Color = color;
            Debug.Log("Second base fruit constructor called");
        }
        public void Chop(uint pieces)
        {
            Debug.Log($"The {Color} fruit has been chopped into {pieces} pieces");
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
            Color = "red";
            Debug.Log("First apple constructor has been called");
        }
        public Apple(string color) : base(color)
        {
            Debug.Log("Second apple constructor has been called");
        }
    }
}

public class FruitSalad2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fruit fruit = new Fruit();
        Apple apple = new Apple();

        fruit.SayHello();
        fruit.Chop(10);
        apple.SayHello();
        apple.Chop(5);

        fruit = new Fruit("yellow");
        apple = new Apple("green");

        fruit.SayHello();
        fruit.Chop(10);
        apple.SayHello();
        apple.Chop(5);
    }
}
