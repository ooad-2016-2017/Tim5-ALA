﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class IGrounding : MonoBehaviour
{
    public abstract bool Grounded { get; }
}
