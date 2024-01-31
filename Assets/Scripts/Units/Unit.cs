using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public enum UnitState
{
    Idle,
    Move,
    Attack,
    Die
}

public class Unit : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private string unitName;
    [SerializeField] private Sprite unitPic;
    [SerializeField] private int curHP;
    [SerializeField] private int maxHP = 100;
    [SerializeField] private int moveSpeed = 5;
    [SerializeField] private int minWpnDamage;
    [SerializeField] private int maxWpnDamage;
    [SerializeField] private int armour;
    [SerializeField] private float visualRange;
    [SerializeField] private UnitState state;
    [SerializeField] private Faction faction;
    [SerializeField] private GameObject selectionVisual;
    private NavMeshAgent navAgent;
    

    public int ID { get => id; set => id = value; }
    public string UnitName => unitName;
    public Sprite UnitPic => unitPic;
    public int CurHP { get => curHP; set => curHP = value; }
    public int MaxHP => maxHP;
    public int MoveSpeed => moveSpeed;
    public int MinWpnDamage => minWpnDamage;
    public int MaxWpnDamage => maxWpnDamage;
    public int Armour => armour;
    public float VisualRange => visualRange;
    public UnitState State { get => state; set => state = value; }
    public Faction Faction => faction;
    public GameObject SelectionVisual => selectionVisual;
    public NavMeshAgent NavAgent => navAgent;

    private void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        switch (state)
        {
            case UnitState.Move:
                MoveUpdate();
                break;
        }
    }
    
    public void ToggleSelectionVisual(bool flag)
    {
        if (selectionVisual != null)
            selectionVisual.SetActive(flag);
    }
    
    public void SetState(UnitState toState)
    {
        state = toState;

        if (state == UnitState.Idle)
        {
            navAgent.isStopped = true;
            navAgent.ResetPath();
        }
    }
    
    public void MoveToPosition(Vector3 dest)
    {
        if (navAgent != null)
        {
            navAgent.SetDestination(dest);
            navAgent.isStopped = false;
        }

        SetState(UnitState.Move); 
    }
    
    private void MoveUpdate()
    {
        float distance = Vector3.Distance(transform.position, navAgent.destination);

        if (distance <= 1f)
            SetState(UnitState.Idle);
    }
}