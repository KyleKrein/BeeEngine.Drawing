using BeeEngine.OpenTK.Platform.OpenGL;
using NotSupportedException = System.NotSupportedException;

namespace BeeEngine.OpenTK.Renderer;

public abstract class IndexBuffer: IDisposable
{
    public int Count { get; protected init; }
    public static IndexBuffer Create(uint[] indecis)
    {
        switch (Renderer.RendererAPI)
        {
            case RendererAPI.OpenGL:
                return new OpenGLIndexBuffer(indecis);
            case RendererAPI.None:
                Log.Error("{0} is not supported", Renderer.RendererAPI);
                throw new NotSupportedException();
            default:
                Log.Error("Unknown Renderer API is not supported");
                throw new NotSupportedException();
        }
    }

    public abstract void Bind();
    public abstract void Unbind();

    protected abstract void Dispose(bool disposing);

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~IndexBuffer()
    {
        Dispose(false);
    }
}