using System.IO;
using Application.Abstract;
using Domain;

namespace Infrastructure
{
    /// <summary>
    /// Интерфейс репозитория сцен
    /// </summary>
    public class FileSceneRepository : ISceneRepository
    {
        private readonly ISceneObjectsFormatter _sceneObjectsFormatter;
        
        public Scene Get(string path)
        {
            return _sceneObjectsFormatter.Format(File.ReadAllBytes(path));
        }
    }
}