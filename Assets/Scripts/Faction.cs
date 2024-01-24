using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Nation
{
    Neutral = 0,
    Britain,
    Pirates,
    France,
    Spain,
    Portuguese,
    Dutch
}

public class Faction : MonoBehaviour
{
    [SerializeField] private Nation nation;
    public Nation Nation { get { return nation; } }

    [Header("Resources")]
    [SerializeField] private int food;
    [SerializeField] private int wood;
    [SerializeField] private int gold;
    [SerializeField] private int stone;
    
    public int Food { get { return food; } set {  food = value; } }
    public int Wood { get { return wood; } set { wood = value; } }
    public int Gold { get { return gold; } set { gold = value; } }
    public int Stone { get { return stone; } set { stone = value; } }
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
