﻿#if NITIS_TASKS
using NiTiS.Core.Types;
using System;
using System.Threading.Tasks;

namespace NiTiS.Core.Additions
{
    public static class GridCreator
    {
        public static async void Create1DGridAsync(int sizeX, bool startFromZero, Action<Vector1DInt> op) => await Task.Run(() => Create1DGrid(sizeX, startFromZero, op));
        public static async void Create2DGridAsync(int sizeX, int sizeZ, bool startFromZero, Action<Vector2DInt> op) => await Task.Run(() => Create2DGrid(sizeX, sizeZ, startFromZero, op));
        public static async void Create3DGridAsync(int sizeX, int sizeY, int sizeZ, bool startFromZero, Action<Vector3DInt> op) => await Task.Run(() => Create3DGrid(sizeX, sizeY, sizeZ, startFromZero, op));
        public static async void Create4DGridAsync(int sizeX, int sizeY, int sizeZ, int sizeW, bool startFromZero, Action<Vector4DInt> op) => await Task.Run(() => Create4DGrid(sizeX, sizeY, sizeZ, sizeW, startFromZero, op));
        public static void Create1DGrid(int sizeX, bool startFromZero, Action<Vector1DInt> op)
        {
            byte offset = startFromZero ? (byte)0 : (byte)1;
            for (int x = offset; x < sizeX + offset; x++)
            {
                op(new Vector1DInt(x));
            }
        }
        public static void Create2DGrid(int sizeX, int sizeY, bool startFromZero, Action<Vector2DInt> op)
        {
            byte offset = startFromZero ? (byte)0 : (byte)1;
            for (int x = offset; x < sizeX + offset; x++)
            {
                for (int y = offset; y < sizeY + offset; y++)
                {
                    op(new Vector2DInt(x, y));
                }
            }
        }
        public static void Create3DGrid(int sizeX, int sizeY, int sizeZ, bool startFromZero, Action<Vector3DInt> op)
        {
            byte offset = startFromZero ? (byte)0 : (byte)1;
            for (int x = offset; x < sizeX + offset; x++)
            {
                for (int y = offset; y < sizeY + offset; y++)
                {
                    for (int z = offset; z < sizeY + offset; z++)
                    {
                        op(new Vector3DInt(x, y, z));
                    }
                }
            }
        }
        public static void Create4DGrid(int sizeX, int sizeY, int sizeZ, int sizeW, bool startFromZero, Action<Vector4DInt> op)
        {
            byte offset = startFromZero ? (byte)0 : (byte)1;
            for (int x = offset; x < sizeX + offset; x++)
            {
                for (int y = offset; y < sizeY + offset; y++)
                {
                    for (int z = offset; z < sizeY + offset; z++)
                    {
                        for (int w = offset; w < sizeW + offset; w++)
                        {
                            op(new Vector4DInt(x, y, z, w));
                        }
                    }
                }
            }
        }
    }
}
#endif