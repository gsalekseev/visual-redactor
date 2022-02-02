using Domain;

namespace Infrastructure
{
    public interface ISceneLoader
    {
        Scene Load(string filepath);
    }
}