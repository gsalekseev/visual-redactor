using System;

namespace Domain
{
    /// <summary>
    /// Источник света
    /// </summary>
    public class LightSource
    {
        
        /// <summary>
        /// Индентификатор
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Температура света
        /// </summary>
        public int LightTemperature { get; set; }
        
        /// <summary>
        /// Координата размещения источника света по оси X
        /// </summary>
        public int X { get; set; }
        
        /// <summary>
        /// Координата размещения источника света по оси Y
        /// </summary>
        public int Y { get; set; }
        
        /// <summary>
        /// Координата размещения источника света Z
        /// </summary>
        public int Z { get; set; }
    }
}