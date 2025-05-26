using System;
using System.Text;

public class Program
{
    public static int[] GetPassLength(int PickNumber)
    {
        int[] PassLength = new int[PickNumber];
        return PassLength;
    }
        static string GeneratePassword(int GetPassLength)
    {
        const string chars =
            "abcdefghijklmnopqrstuvwxyz" +
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
            "0123456789!@#$%&*";

        var random = new Random();
        var result = new StringBuilder();

        for (var i = 0; i < GetPassLength; i++) 
            result.Append(chars[random.Next(chars.Length)]);
        return result.ToString();
    }

    //static void pass()
    //{
    //    var length = GetPasswordLength();
    //    var password = GeneratePassword(length);
    //}
}