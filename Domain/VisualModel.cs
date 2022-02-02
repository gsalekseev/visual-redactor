using System;

namespace Domain
{
    /// <summary>
    /// Визульная модель
    /// </summary>
    public class VisualModel
    {
        /// <summary>
        /// Индентификатор
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Множество полигонов, образующих модель
        /// </summary>
        public Polygon[] Polygons { get; set; }
    }
}