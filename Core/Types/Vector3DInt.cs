﻿using NiTiS.Core.Enums;
using System.Diagnostics;
using static System.Math;

namespace NiTiS.Core.Types
{
    [DebuggerDisplay("3DInt ({X}:{Y}:{Z})")]
    public struct Vector3DInt : IVector<int>
    {
        public int X;
        public int Y;
        public int Z;
        public int GetValueByDimension(DimensionAxis axis)
        {
            switch (axis)
            {
                case DimensionAxis.X: return X;
                case DimensionAxis.Y: return Y;
                case DimensionAxis.Z: return Z;
                default: return 0;
            }
        }

        public Vector3DInt(int x = 0, int y = 0, int z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Vector3DInt operator +(Vector3DInt a) => a;
        public static Vector3DInt operator ++(Vector3DInt a) => a + new Vector3DInt(1,1,1);
        public static Vector3DInt operator -(Vector3DInt a) => new Vector3DInt(-a.X, -a.Y, -a.Z);
        public static Vector3DInt operator --(Vector3DInt a) => a - new Vector3DInt(1,1,1);
        public static Vector3DInt operator +(Vector3DInt a, Vector3DInt b) => new Vector3DInt(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vector3DInt operator -(Vector3DInt a, Vector3DInt b) => new Vector3DInt(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static Vector3DInt operator *(Vector3DInt a, Vector3DInt b) => new Vector3DInt(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        public static Vector3DInt operator *(Vector3DInt a, int b) => new Vector3DInt(a.X * b, a.Y * b, a.Z * b);
        public static Vector3DInt operator /(Vector3DInt a, Vector3DInt b) => new Vector3DInt(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        public static Vector3DInt operator /(Vector3DInt a, int b) => new Vector3DInt(a.X / b, a.Y / b, a.Z / b);

        #region Transforms
        public static explicit operator Vector4D(Vector3DInt b) => new Vector4D(b.X, b.Y, b.Z, 0);
        public static explicit operator Vector4DInt(Vector3DInt b) => new Vector4DInt(b.X, b.Y, b.Z, 0);
        public static implicit operator Vector3D(Vector3DInt b) => new Vector3D(b.X,b.Y,b.Z);
        public static implicit operator Vector2D(Vector3DInt b) => new Vector2D(b.X,b.Y);
        public static implicit operator Vector2DInt(Vector3DInt b) => new Vector2DInt(b.X,b.Y);
        public static implicit operator Vector1D(Vector3DInt b) => new Vector1D(b.X);
        public static implicit operator Vector1DInt(Vector3DInt b) => new Vector1DInt(b.X);
        #endregion
        public double LengthSquared => (X * X) + (Y * Y) + (Z * Z);
        public double Length => Sqrt(LengthSquared);
        public void Normalize()
        {
            this /= (int)Length;
        }
        public override string ToString() => "{" + X + ":" + Y + ":" + Z + "}";
    }
}
