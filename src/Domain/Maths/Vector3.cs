namespace VoxelRenderer.Domain.Maths;

public struct Vector3 : System.IEquatable<Vector3> {

    public readonly double X, Y, Z;

    public Vector3(double x, double y, double z) {
        X = x;
        Y = y;
        Z = z;
    }

    // Vector addition
    public static Vector3 operator +(Vector3 a, Vector3 b) { return new (a.X + b.X, a.Y + b.Y, a.Z + b.Z); }
    // Scalar multiplication
    public static Vector3 operator *(Vector3 a, double scalar) { return new (a.X * scalar, a.Y * scalar, a.Z * scalar); }
    // Vector subtraction
    public static Vector3 operator -(Vector3 a, Vector3 b) { return a + (b * (-1)); }
    // Dot product
    public static Vector3 operator *(Vector3 a, Vector3 b) { return new (a.X * b.X, a.Y * b.Y, a.Z * b.Z); }
    // Cross product
    public static Vector3 Cross(Vector3 a, Vector3 b) { return new (a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X); }

    // Vector3 to string for printing and debug purposes
    public static string ToString(Vector3 a) { return $"({a.X}, {a.Y}, {a.Z}"; }
    public override string ToString() {
        return ToString(this);
    }

    // Return Vector3 with unit length an invariant direction
    public Vector3 Normalised => Normalise(this);
    public static Vector3 Normalise(Vector3 a) { return a * (1 / a.Magnitude); }

    public double SquareMagnitude => X * X + Y * Y + Z * Z;

    public double Magnitude => Math.Sqrt(SquareMagnitude);

    public bool Equals(Vector3 a) {
        return a.X == X && a.Y == Y && a.Z == Z;
    }
}
