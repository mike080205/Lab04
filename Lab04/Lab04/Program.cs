using System;

namespace Lab04
{
    class Tablet
    {
        // Поля класу
        public string ModelName { get; set; }
        public string Manufacturer { get; set; }
        public double ScreenSize { get; set; }
        public int MemorySize { get; set; }
        public int BatteryCapacity { get; set; }
        public bool SupportsWiFi { get; set; }
        public bool Supports4G { get; set; }
        public double Price { get; set; }

        // Метод класу
        public double CalculatePricePerBatteryCapacity()
        {
            return BatteryCapacity > 0 ? Price / BatteryCapacity : 0;
        }

        // Виведення інформації про планшет
        public void DisplayInfo()
        {
            Console.WriteLine($"Назва моделі: {ModelName}");
            Console.WriteLine($"Виробник: {Manufacturer}");
            Console.WriteLine($"Розмір екрану: {ScreenSize} дюймів");
            Console.WriteLine($"Розмір пам'яті: {MemorySize} GB");
            Console.WriteLine($"Ємність батареї: {BatteryCapacity} mAh");
            Console.WriteLine($"Підтримує Wi-Fi: {SupportsWiFi}");
            Console.WriteLine($"Підтримує 4G: {Supports4G}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Ціна за мАг: ${CalculatePricePerBatteryCapacity():0.00}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створення екземпляру класу Tablet
            Tablet tablet = new Tablet();

            // Введення даних про планшет
            Console.Write("Введіть назву моделі: ");
            tablet.ModelName = Console.ReadLine();

            Console.Write("Введіть виробника: ");
            tablet.Manufacturer = Console.ReadLine();

            Console.Write("Введіть розмір екрана (в дюймах): ");
            tablet.ScreenSize = double.Parse(Console.ReadLine());

            Console.Write("Введіть розмір пам'яті (в ГБ): ");
            tablet.MemorySize = int.Parse(Console.ReadLine());

            Console.Write("Введіть ємність акумулятора (в мАг): ");
            tablet.BatteryCapacity = int.Parse(Console.ReadLine());

            Console.Write("Введіть ціну: ");
            tablet.Price = double.Parse(Console.ReadLine());

            Console.Write("Чи підтримує планшет Wi-Fi (true/false): ");
            tablet.SupportsWiFi = bool.Parse(Console.ReadLine());

            Console.Write("Чи підтримує планшет 4G (true/false): ");
            tablet.Supports4G = bool.Parse(Console.ReadLine());

            // Виклик методу для виведення інформації про планшет
            tablet.DisplayInfo();

            // Пауза перед завершенням програми
            Console.WriteLine("Щоб вийти, натисніть будь-яку клавішу.");
            Console.ReadKey();
        }
    }
}
