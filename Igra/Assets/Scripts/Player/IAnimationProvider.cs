using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IAnimationProvider : MonoBehaviour {
    
    public abstract void SetIdle(bool idle);
    public abstract void Jump();

    public abstract void SetGrounded(bool grounded);
    public abstract void SetFalling(bool falling);
}
