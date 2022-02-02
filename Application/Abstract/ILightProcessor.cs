using Domain;

namespace Application.Abstract
{
    public interface ILightProcessor
    {
        VisualModel ApplyLightToModel(VisualModel m, LightSource[] lights);
    }
}