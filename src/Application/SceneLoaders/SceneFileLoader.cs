using VoxelRenderer.Domain.Interfaces;
using VoxelRenderer.Application.Interfaces;

namespace VoxelRenderer.Application.SceneLoaders;

public class SceneFileLoader : ISceneLoader {

    private readonly IFileLoader FileLoader;
    private readonly string FilePath;

    public SceneFileLoader(IFileLoader fileLoader, string filePath) {
        FileLoader = fileLoader;
        FilePath = filePath;
    }

    public IScene Load() {
        string fileContents = FileLoader.Load(FilePath);
        return null;
    }
}
