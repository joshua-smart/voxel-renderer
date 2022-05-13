namespace VoxelRenderer.Application.Interfaces;

public interface IFileLoader<T> {
    public T LoadFile(string filePath);
}
