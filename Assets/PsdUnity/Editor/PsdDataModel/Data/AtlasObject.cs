﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PSDUnity
{
    public class AtlasObject : ScriptableObject
    {
        public string psdFile;
        public string exportPath;
        public bool maskAsColor;
        public Vector2 psdSize;
        public List<PictureData> pictureDatas = new List<PictureData>();
        public List<GroupNode1> groups = new List<GroupNode1>();
    }
}