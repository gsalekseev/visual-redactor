using System;

namespace Domain
{
    /// <summary>
    /// Представляемая сцена с моделью, источниками света и камерами
    /// </summary>
    public class Scene
    {
        /// <summary>
        /// Индентификатор
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Источники света в сцене
        /// </summary>
        public LightSource[] LightSources { get; set; }
        
        /// <summary>
        /// Камеры на сцене
        /// </summary>
        public Camera[] Cameras { get; set; }
        
        /// <summary>
        /// Представляемая модель
        /// </summary>
        public VisualModel Model { get; set; }
    }
}