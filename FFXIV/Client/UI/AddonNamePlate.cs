﻿using FFXIVClientStructs.FFXIV.Client.System.String;
using FFXIVClientStructs.FFXIV.Component.GUI;
using System;
using System.Runtime.InteropServices;

namespace FFXIVClientStructs.FFXIV.Client.UI
{
    // Client::UI::AddonNamePlate
    //   Component::GUI::AtkUnitBase
    //     Component::GUI::AtkEventListener
    [StructLayout(LayoutKind.Explicit, Size = 0x460)]
    public unsafe struct AddonNamePlate
    {
        [FieldOffset(0x0)] public AtkUnitBase AtkUnitBase;
        [FieldOffset(0x220)] public BakePlateRenderer BakePlate;

        // Client::UI::AddonNamePlate::BakePlateRenderer
        //   Component::GUI::AtkTextNodeRenderer
        //     Component::GUI::AtkResourceRendererBase
        [StructLayout(LayoutKind.Explicit, Size = 0x238)]  // 0x240?
        public unsafe struct BakePlateRenderer
        {
            [FieldOffset(0x230)] public NamePlateObject* NamePlateObjects;  // 0 - 50

            public static int NumNamePlateObjects = 50;

            [StructLayout(LayoutKind.Explicit, Size = 0x70)]
            public unsafe struct NamePlateObject
            {
                [FieldOffset(0x0)] public AtkComponentNode* ComponentNode;
                [FieldOffset(0x8)] public AtkResNode* ResNode;
                [FieldOffset(0x10)] public AtkTextNode* TextNode10;
                [FieldOffset(0x18)] public AtkImageNode* ImageNode1;
                [FieldOffset(0x20)] public AtkImageNode* ImageNode2;
                [FieldOffset(0x28)] public AtkImageNode* ImageNode3;
                [FieldOffset(0x30)] public AtkImageNode* ImageNode4;
                [FieldOffset(0x38)] public AtkImageNode* ImageNode5;
                [FieldOffset(0x40)] public AtkCollisionNode* CollisionNode1;
                [FieldOffset(0x48)] public AtkCollisionNode* CollisionNode2;
                [FieldOffset(0x50)] public int index;
                [FieldOffset(0x54)] public short TextW;
                [FieldOffset(0x56)] public short TextH;
                [FieldOffset(0x58)] public short IconXAdjust;
                [FieldOffset(0x5A)] public short IconYAdjust;
            }
        }
        [FieldOffset(0x450)] public byte* NamePlateObjectArray;
    }
}
