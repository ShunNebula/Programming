using System.Drawing;

namespace Programming.Resourses
{
    /// <summary>
    /// Добавляет данные цветов в перечисление ColorList.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет "Весна".
        /// </summary>
        public static Color springColor = Color.FromArgb(48, 213, 200);
        /// <summary>
        /// Цвет "Осень".
        /// </summary>
        public static Color autumnColor = Color.FromArgb(255, 166, 97);
        /// <summary>
        /// Цвет фигур, если они не сталкиваются с другими фигурами.
        /// </summary>
        public static Color nonCollision = Color.FromArgb(127, 127, 255, 127);
        /// <summary>
        /// Цвет фигур, если они сталкиваются с другими фигурами.
        /// </summary>
        public static Color collision = Color.FromArgb(127, 255, 127, 127);
        /// <summary>
        /// Цвет ошибки ввода.
        /// </summary>
        public static Color falseText = Color.LightPink;
        /// <summary>
        /// Обычный цвет окна.
        /// </summary>
        public static Color trueText = Color.FromKnownColor(KnownColor.Window);
    }
}
