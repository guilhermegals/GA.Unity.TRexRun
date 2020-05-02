﻿using UnityEngine;

public abstract class BackgroundElement : MonoBehaviour{

    #region [ Properties ]

    [SerializeField]
    public float Speed = 1f;

    [SerializeField]
    private string Name;

    [SerializeField]
    private bool IncreaseElementSpeed = false;

    #endregion

    #region [ Protected Functions ]

    protected abstract void Move();

    #endregion

    #region [ Public Functions ]

    public void IncreaseSpeed(float amount) {
        if(this.IncreaseElementSpeed)
            this.Speed += amount;
    }

    #endregion
}
