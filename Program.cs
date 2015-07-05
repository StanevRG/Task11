using System;

namespace Task11
{
    public class Program
    {
        static void Main(string[] args)
        {
            var s = EnterS();
            var l = Math.Sqrt(s / Math.PI); //  Формула расчета длины окружности
            Console.WriteLine("Длина окружности = {0}", l);
            Console.WriteLine("Спасибо! Нажмите кнопку для завершения программы.");
            Console.ReadKey();
        }

        /// <summary>
        /// Функция возвращающая вводимое пользователем значение площади
        /// </summary>
        /// <returns></returns>
        internal static float EnterS()
        {
            var result = 0f;
            while (result <= 0f) {  //  Цикл повторяется до тех пор, пока не будет введено допустимое значение площади
                Console.Write("Введите значение площади: ");
                var value = Console.ReadLine(); //  Получаем значение вводимое пользователем в консоли в виде строки
                Console.WriteLine();    //  Перевод строки после пользовательского ввода
                float.TryParse(value, out result);  //  Используем безопасное конвертирование строкового значения во float
                if (result <= 0) {
                    //  Информируем пользователя об ошибочно введенных данных
                    Console.WriteLine("ОШИБКА ВВОДА! Вводимое значение должно быть числом более 0.");
                }
            }
            return result;
        }
    }
}
