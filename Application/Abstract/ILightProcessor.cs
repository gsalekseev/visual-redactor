using Domain;

namespace Application.Abstract
{
    public interface ILightProcessor
    {
        VisualModel ApplyLightToModel(Camera currentCamera, VisualModel m, LightSource[] lights);
    }
}