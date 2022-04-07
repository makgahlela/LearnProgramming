using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProgramming.FileSystemDemo
{
     class Start
    {
      static string rootPath = @"C:\Users\kgets\Desktop\Builds\FileSystem";
        static string newPath = @"C:\Users\kgets\Desktop\Builds\FileSystem\SubFolder A\";
        static void Main(string[] args)
        {
            //string[] files=Directory.GetFiles(rootPath);

            //foreach (string file in files)
            //{
            //    File.Move(file, $"{newPath}{Path.GetFileName(file)}");
            //}

            //for (int i = 0; i < files.Length; i++)
            //{
            //    File.Copy(files[i], $"{newPath}{i}", true);
            //}

            //foreach (string file in files)
            //{
            //    File.Copy(file,$"{newPath}{Path.GetFileName(file)}",true);
            //}

            //////Fourth Examples
            //bool dirExist= Directory.Exists(newPath);
            // if (dirExist)
            // {
            //     Green();
            //     Console.WriteLine("dirExist exist");
            // }
            // else
            // {
            //     Red();
            //     Console.WriteLine("dirExist not exist");
            //     Directory.CreateDirectory(newPath);
            // }

            //////Second Examples
            var files = Directory.GetFiles(rootPath, "*studentData*.*", SearchOption.AllDirectories);
            //var files = Directory.GetFiles(rootPath, "*studentData*.*", SearchOption.AllDirectories);
            //var files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
                // Console.WriteLine(Path.GetFileName(file));
                //Console.WriteLine(Path.GetDirectoryName(file));
                //var info = new FileInfo(file);
                //White();
                //Console.Write($"{Path.GetFileName(file)}: ");
                //Green();

                //Console.Write($"{info.Length / 1024 / 1024} .MB/ .kbytes\n");
            }

            /////First Example
            //string[] dirs = Directory.GetDirectories(rootPath,"*",SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            Console.ReadLine();
        }

        private static void White()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        private static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
