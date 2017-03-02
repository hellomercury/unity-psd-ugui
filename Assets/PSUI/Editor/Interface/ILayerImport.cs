﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;


namespace PSDUIImporter
{
    public interface ILayerImport
    {
        UINode DrawLayer(Layer layer, UINode parent);
    }
}
