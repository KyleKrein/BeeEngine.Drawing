using BeeEngine.Mathematics;
using BeeEngine.OpenTK.Renderer;
using OpenTK.Graphics.OpenGL4;

namespace BeeEngine.OpenTK.Platform.OpenGL;

public class OpenGLRendererAPI: RendererAPI
{
    public override void SetClearColor(Color color)
    {
        GL.ClearColor(color.R, color.G, color.B, color.A);
    }

    public override void Clear()
    {
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
    }

    public override void DrawIndexed(VertexArray vertexArray)
    {
        GL.DrawElements(PrimitiveType.Triangles, vertexArray.IndexBuffer.Count, DrawElementsType.UnsignedInt, 0);
    }
}