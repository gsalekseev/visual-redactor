using System;

namespace Domain
{
    /// <summary>
    /// Один из полигонов визаульной модели
    /// </summary>
    public class Polygon
    {
        
        /// <summary>
        /// Индентификатор
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Координата начала полигона по оси X
        /// </summary>
        public int X { get; set; }
        
        /// <summary>
        /// Координата начала полигона по оси Y
        /// </summary>
        public int Y { get; set; }
        
          
        /// <summary>
        /// Координата начала полигона по оси Z
        /// </summary>
        public int Z { get; set; }

        /// <summary>
        /// Ширина полигона
        /// </summary>
        public int Width { get; set; }
        
        /// <summary>
        /// Длина полигона
        /// </summary>
        public int Length { get; set; }
        
        /// <summary>
        /// Высота полигона
        /// </summary>
        public int Height { get; set; }
    }
}