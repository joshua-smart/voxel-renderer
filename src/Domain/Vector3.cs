namespace VoxelRenderer.Domain;

struct Vector3 {

    public readonly double X;
    public readonly double Y;
    public readonly double Z;

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

    // Return Vector3 with unit length an invariant direction
    public static Vector3 Normalise(Vector3 a) { return a * (1 / Magnitude(a)); }
    public Vector3 Normalise() { return Normalise(this); }

    public static double SquareMagnitude(Vector3 a) { return a.X * a.X + a.Y * a.Y + a.Z * a.Z; }
    public double SquareMagnitude() { return SquareMagnitude(this); }

    public static double Magnitude(Vector3 a) { return Math.Sqrt(SquareMagnitude(a)); }
    public double Magnitude() { return Magnitude(this); }
}
