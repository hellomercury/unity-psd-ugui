﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using PSDUnity.Data;
namespace PSDUnity.Import
{
    public class SpriteImport : IImageImport
    {
        public UGUINode DrawImage(ImgNode image, UGUINode parent)
        {
            UGUINode node = null;
            switch (image.type)
            {
                case ImgType.Image:
                case ImgType.AtlasImage:
                case ImgType.Color:
                    node = DrawNormalImage(image, parent);
                    break;
                case ImgType.Texture:
                    node = DrawRawImage(image, parent);
                    break;
                default:
                    break;
            }
            return node;
        }

        private UGUINode DrawRawImage(ImgNode image, UGUINode parent)
        {
            UGUINode node = PSDImporter.InstantiateItem(GroupType.RawIMAGE, image.sprite.name, parent);
            UnityEngine.UI.RawImage pic = node.InitComponent<UnityEngine.UI.RawImage>();
            PSDImporter.SetPictureOrLoadColor(image, pic);
            PSDImporter.SetRectTransform(image, pic.GetComponent<RectTransform>());
            return node;
        }

        private UGUINode DrawNormalImage(ImgNode image, UGUINode parent)
        {
            UGUINode node = PSDImporter.InstantiateItem(GroupType.IMAGE, image.Name, parent);
            UnityEngine.UI.Image pic = node.InitComponent<UnityEngine.UI.Image>();
            PSDImporter.SetPictureOrLoadColor(image, pic);
            pic.type = UnityEngine.UI.Image.Type.Simple;
            PSDImporter.SetRectTransform(image, pic.GetComponent<RectTransform>());
            return node;
        }
    }
}
