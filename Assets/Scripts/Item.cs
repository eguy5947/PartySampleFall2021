using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string title;
    public string description;

    public int speed;
    public int acceleration;
    public int steering;
    public int boost;
    
    string[] first = new string[] { "Ald", "Alf", "Ash", "Barn", "Blan", "Brack", "Brad", "Brain", "Brom", "Bur", "Cas", "Chelm", "Clere",
            "Cook", "Dart", "Dur", "Edg", "Eg", "El", "Elm", "En", "Farn", "Flit", "Hart", "Horn", "Hors", "Hurst", "Kings", "Leather", "Maiden",
            "Marl", "Mel", "Nort", "Pem", "Pen", "Prest", "Rock", "Shaft", "Shriv", "Sod", "South", "Staf", "Stain", "Stap", "Sud", "Sun", "Walt",
            "Watch", "Wen", "Wet", "Whit", "Win", "Wy", "Wych" };
    string[] adj = new string[] { "turbine", "refined", "extra", "super", "bonkers", "i dont know", "something", "cock", "rocker", "raunchy", "ok", "fucking"};

    string[] noun = new string[] {"property","relation","person","shit","inflation","city","criticism","song","virus","girlfriend","refrigerator","manager","piano","obligation","information","protection","meat"};
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateItem()
    {
        speed = Random.Range(-6,6);
        acceleration = Random.Range(-5,5);
        boost = Random.Range(-20,20);
        steering = Random.Range(-5, 5);
        title = first[Random.Range(1, (first.Length - 1))] + "'s " + adj[Random.Range(1, (adj.Length - 1))] + " " + noun[Random.Range(1, (noun.Length - 1))];
    }
}
