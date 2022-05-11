namespace VoxelRenderer.Domain.Maths;

public class Quaternion {
    public readonly double R, I, J, K;

    public Quaternion(double r, double i, double j, double k) {
        R = r;
        I = i;
        J = j;
        K = k;
    }

    public static Quaternion operator *(Quaternion p, Quaternion q) {
        return new (
            p.R * q.R - p.I * q.I - p.J * q.J - p.K * q.K,
            p.R * q.I + p.I * q.R - p.J * q.K + p.K * q.J,
            p.R * q.J + p.I * q.K + p.J * q.R - p.K * q.I,
            p.R * q.K - p.I * q.J + p.J * q.I + p.K * q.R
        );
    }

    public static Vector3 RotatePoint(Quaternion q, Vector3 v) {
        Quaternion p = new (0, v.X, v.Y, v.Z);
        Quaternion s = q.Inverse() * p * q;
        return new (s.I, s.J, s.K);
    }

    public static Quaternion Compose(Quaternion p, Quaternion q) {
        return q * p;
    }

    public static Quaternion Inverse(Quaternion p) { return new (p.R, -p.I, -p.J, -p.K); }
    public Quaternion Inverse() { return Inverse(this); }
}
