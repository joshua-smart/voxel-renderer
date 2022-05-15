using VoxelRenderer.Domain.Interfaces;
using VoxelRenderer.Application.Interfaces;

namespace VoxelRenderer.Application;

public class Renderer {

    private readonly ISceneLoader SceneLoader;
    private readonly IImageWriter ImageWriter;
    private readonly ICamera Camera;

    public Renderer(ISceneLoader sceneLoader, IImageWriter imageWriter, ICamera camera) {
        SceneLoader = sceneLoader;
        ImageWriter = imageWriter;
        Camera = camera;
    }

    public void Render() {
        IScene loadedScene = SceneLoader.Load();
        IImage renderedImage = Camera.Render(loadedScene);
        ImageWriter.Write(renderedImage);
    }
}
