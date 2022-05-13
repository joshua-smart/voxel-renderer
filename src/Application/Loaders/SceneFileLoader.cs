using VoxelRenderer.Domain.Interfaces;

namespace VoxelRenderer.Application.Loaders;

public class SceneFileLoader : IScenceLoader {

    private readonly IFileLoader FileLoader;
    private readonly string FilePath;

    public SceneFileLoader(IFileLoader fileLoader, string filePath) {
        FileLoader = fileLoader;
        FilePath = filePath;
    }

    public IScene Load() {
        return null;
    }
}
