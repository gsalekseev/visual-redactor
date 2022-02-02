using System;

namespace Domain
{
    /// <summary>
    /// Камера - совокупность позиции наблюдателя и направления его взгляда
    /// </summary>
    public class Camera
    {
        /// <summary>
        /// Индентификатор
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Координата размещения камеры по оси X
        /// </summary>
        public int X { get; set; }
        
        /// <summary>
        /// Координата размещения камеры по оси Y
        /// </summary>
        public int Y { get; set; }
        
        /// <summary>
        /// Координата размещения камеры по оси Z
        /// </summary>
        public int Z { get; set; }

        /// <summary>
        /// Метод поворота камеры
        /// </summary>
        public void Rotate()
        {
            //реализация Rotate
        }
        
        /// <summary>
        /// Метод перемещения камеры
        /// </summary>
        public void Move()
        {
            //реализация Move
        }
    }
}