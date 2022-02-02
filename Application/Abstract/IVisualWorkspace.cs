using System.Drawing;
using Domain;

namespace Application.Abstract
{
    /// <summary>
    /// Интерфейс рабочей области визуального редактора
    /// </summary>
    public interface IVisualWorkspace
    {
        public Scene CurrentScene { get; }

        public Bitmap Present();

        public void SetCurrentScene(string path);

        public void SaveToFile(string path);
    }
}