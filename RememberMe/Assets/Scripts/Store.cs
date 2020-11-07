using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    #region Singleton
    private static Store _store = null;
    public static Store store
    {
        get
        {
            return _store;
        }
    }
    private void Awake()
    {
        if ((_store != null) || (_store != this))
        {
            Destroy(_store);
        }
        _store = this;
    }
    #endregion

    //Mutexes

    private int _tile_dimension = 0;

    //Properties
    public int tile_dimension
    {
        get
        {
            return _tile_dimension;
        }

        set
        {
            _tile_dimension = value; 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
