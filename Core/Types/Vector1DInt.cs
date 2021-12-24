﻿using NiTiS.Core.Enums;
using static System.Math;
using System.Diagnostics;

namespace NiTiS.Core.Types
{
    [DebuggerDisplay("1DInt ({X})")]
    public struct Vector1DInt : IVector<int>
    {

        public int X;
        public int GetValueByDimension(DimensionAxis axis)
        {
            if (axis == DimensionAxis.X) { return X; } else { return 0; }
        }

        public Vector1DInt(int x = 0)
        {
            X = x;
        }
        public static Vector1DInt operator +(Vector1DInt a) => a;
        public static Vector1DInt operator -(Vector1DInt a) => new Vector1DInt(-a.X);
        public static Vector1DInt operator ++(Vector1DInt a) => new Vector1DInt(a.X + 1);
        public static Vector1DInt operator --(Vector1DInt a) => new Vector1DInt(a.X - 1);
        public static Vector1DInt operator +(Vector1DInt a, Vector1DInt b) => new Vector1DInt(a.X + b.X);
        public static Vector1DInt operator -(Vector1DInt a, Vector1DInt b) => new Vector1DInt(a.X - b.X);
        public static Vector1DInt operator *(Vector1DInt a, Vector1DInt b) => new Vector1DInt(a.X * b.X);
        public static Vector1DInt operator *(Vector1DInt a, int b) => new Vector1DInt(a.X * b);
        public static Vector1DInt operator /(Vector1DInt a, Vector1DInt b) => new Vector1DInt(a.X / b.X);
        public static Vector1DInt operator /(Vector1DInt a, int b) => new Vector1DInt(a.X / b);

        #region Transforms
        public static explicit operator Vector4D(Vector1DInt b) => new Vector4D(b.X, 0, 0, 0);
        public static explicit operator Vector4DInt(Vector1DInt b) => new Vector4DInt(b.X, 0, 0, 0);
        public static explicit operator Vector3D(Vector1DInt b) => new Vector3D(b.X, 0, 0);
        public static explicit operator Vector3DInt(Vector1DInt b) => new Vector3DInt(b.X, 0, 0);
        public static explicit operator Vector2D(Vector1DInt b) => new Vector2D(b.X, 0);
        public static explicit operator Vector2DInt(Vector1DInt b) => new Vector2DInt(b.X, 0);
        public static implicit operator Vector1D(Vector1DInt b) => new Vector1D(b.X);
        #endregion

        public override string ToString() => "{" + X + "}";

        public double LengthSquared => X * X;
        public double Length => Abs(X);
        public void Normalize()
        {
            if (X == 0) { return; }
            if (X < 0) { X = -1; } else { X = 1; }
        }
    }
}
