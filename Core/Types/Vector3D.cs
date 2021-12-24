﻿using NiTiS.Core.Enums;
using System.Diagnostics;
using static System.Math;

namespace NiTiS.Core.Types
{
    [DebuggerDisplay("3DFloat ({X}:{Y}:{Z})")]
    public struct Vector3D : IVector<float>
    {
        public float X;
        public float Y;
        public float Z;
        public float GetValueByDimension(DimensionAxis axis)
        {
            switch (axis)
            {
                    case DimensionAxis.X: return X;
                    case DimensionAxis.Y: return Y;
                    case DimensionAxis.Z: return Z;
                default: return 0;
            }
        }

        public Vector3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Vector3D operator +(Vector3D a) => a;
        public static Vector3D operator ++(Vector3D a) => a + new Vector3D(1,1,1);
        public static Vector3D operator -(Vector3D a) => new Vector3D(-a.X, -a.Y, -a.Z);
        public static Vector3D operator --(Vector3D a) => a - new Vector3D(1,1,1);
        public static Vector3D operator +(Vector3D a, Vector3D b) => new Vector3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vector3D operator -(Vector3D a, Vector3D b) => new Vector3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static Vector3D operator *(Vector3D a, Vector3D b) => new Vector3D(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        public static Vector3D operator *(Vector3D a, float b) => new Vector3D(a.X * b, a.Y * b, a.Z * b);
        public static Vector3D operator /(Vector3D a, Vector3D b) => new Vector3D(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        public static Vector3D operator /(Vector3D a, float b) => new Vector3D(a.X / b, a.Y / b, a.Z / b);

        #region Transforms
        public static explicit operator Vector4D(Vector3D b) => new Vector4D(b.X, b.Y, b.Z, 0);
        public static explicit operator Vector4DInt(Vector3D b) => new Vector4DInt((int)b.X, (int)b.Y, (int)b.Z, 0);
        public static implicit operator Vector3DInt(Vector3D b) => new Vector3DInt((int)b.X, (int)b.Y, (int)b.Z);
        public static implicit operator Vector2D(Vector3D b) => new Vector2D(b.X,b.Y);
        public static implicit operator Vector2DInt(Vector3D b) => new Vector2DInt( (int)b.X, (int)b.Y);
        public static implicit operator Vector1D(Vector3D b) => new Vector1D(b.X);
        public static implicit operator Vector1DInt(Vector3D b) => new Vector1DInt( (int)b.X);
        #endregion
        public double LengthSquared => (X * X) + (Y * Y) + (Z * Z);
        public double Length => Sqrt(LengthSquared);
        public void Normalize()
        {
            this /= (float)Length;
        }
        public override string ToString() => "{" + X + ":" + Y + ":" + Z + "}";
    }
}
