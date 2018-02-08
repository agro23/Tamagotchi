using System.Collections.Generic;

namespace TamagotchiLand.Model
{
  public class Tamagotchi
  {
    private string _name;
    private int _food;
    private int _attention;
    private int _rest;

    public Tamagotchi (string myName, int myFood, int myAttention, int myRest)
    {
      _name = myName;
      _food = myFood;
      _attention = myAttention;
      _rest = myRest;
    }

    public void SetName(string aName)
    {
      _name = aName;
    }

    public string GetName()
    {
      return _name;
    }

    public static void SetFood(int aFood)
    {
      _food = aFood;
    }

    public static int GetFood()
    {
      return _food;
    }

    public void SetAttention(int aTtention)
    {
      _attention = aTtention;
    }

    public int GetAttention()
    {
      return _attention;
    }

    public void SetRest(int aRest)
    {
      _rest = aRest;
    }

    public int GetRest()
    {
      return _rest;
    }

    // public static void incFood(){
    //   _food++;
    //   if (_food > 100) { food = 100; }
    // }




  }
}
