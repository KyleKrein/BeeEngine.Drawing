using BeeEngine.Mathematics;

namespace BeeEngine.OpenTK.Renderer;

public class Renderer
{
    private static API _api = API.None;
    private static Matrix4 _viewProjectionMatrix;

    // ReSharper disable once InconsistentNaming
    public static API API
    {
        get => _api;
        set
        {
            if (_api != API.None)
                throw new Exception("Can't change Renderer api if it was assigned before");
            _api = value;
        }
    }

    public static void BeginScene(OrthographicCamera camera)
    {
        _viewProjectionMatrix = camera.ViewProjectionMatrix;
    }

    public static void EndScene()
    {
        
    }

    public static void Submit(VertexArray vertexArray, Shader shader, Matrix4 transform)
    {
        shader.Bind();
        shader.UploadUniformMatrix4("u_ViewProjection",ref _viewProjectionMatrix);
        shader.UploadUniformMatrix4("u_Transform",ref transform);
        vertexArray.Bind();
        RenderCommand.DrawIndexed(vertexArray);
    }
}