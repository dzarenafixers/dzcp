using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string basePath = @"C:\Users\moncef\Videos\w"; // المسار الأساسي حيث سيتم إنشاء المجلدات والملفات

        // إنشاء المجلدات
        for (int i = 1; i <= 6; i++)
        {
            string folderPath = Path.Combine(basePath, $"Folder{i}");
            Directory.CreateDirectory(folderPath);
            Console.WriteLine($"تم إنشاء المجلد: {folderPath}");
        }

        // إنشاء الملفات
        string[] fileNames = { "plugins.txt", "config.txt", "depancies.txt" };
        foreach (var fileName in fileNames)
        {
            string filePath = Path.Combine(basePath, fileName);
            File.WriteAllText(filePath, "هذا محتوى الملف.");
            Console.WriteLine($"تم إنشاء الملف: {filePath}");
        }

        // تعديل تواريخ الملفات والمجلدات
        DateTime modifiedDate = new DateTime(2025, 10, 10, 23, 13, 0); // التاريخ المطلوب: 10/2025 11:13 PM
        foreach (var folder in Directory.GetDirectories(basePath))
        {
            Directory.SetLastWriteTime(folder, modifiedDate);
            Console.WriteLine($"تم تعديل تاريخ المجلد: {folder}");
        }

        foreach (var file in Directory.GetFiles(basePath))
        {
            File.SetLastWriteTime(file, modifiedDate);
            Console.WriteLine($"تم تعديل تاريخ الملف: {file}");
        }

        Console.WriteLine("تم إنشاء المجلدات والملفات وتعديل تواريخها بنجاح!");
    }
}