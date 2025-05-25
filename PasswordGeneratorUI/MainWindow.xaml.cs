﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordGeneratorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public class Program
    {
        static int GetPasswordLength()
        {
           // Console.WriteLine("Введите длину пароля: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string GeneratePassword(int length)
        {
            const string chars =
                "abcdefghijklmnopqrstuvwxyz" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "0123456789!@#$%&*";

            var random = new Random();
            var result = new StringBuilder();

            for (var i = 0; i < length; i++)
                result.Append(chars[random.Next(chars.Length)]);
            return result.ToString();
        }

        static void Main()
        {
            var length = GetPasswordLength();
            var password = GeneratePassword(length);

            //Console.WriteLine($"Ваш случайный пароль: {password}");
            //Console.WriteLine("Нажмите Enter для выхода...");
            //Console.ReadLine();
        }
    }
}