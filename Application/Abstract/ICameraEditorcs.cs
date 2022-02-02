using Domain;

namespace Application.Abstract
{
    public interface ICameraEditor
    {
        Camera Add(Scene s);

        void Remove(Scene s, Camera c);
    }
}