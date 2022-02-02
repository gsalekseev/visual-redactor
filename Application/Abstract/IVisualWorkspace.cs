using System;
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

        public Bitmap Present(Guid selectedCameraId);

        public void SetCurrentScene(string path);

        public void SaveModelToFile(string path);
        public void SavePresentationToFile(Guid presentationCameraId, string path);
    }
}