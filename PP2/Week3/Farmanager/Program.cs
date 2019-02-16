using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManager
{
    enum FARMode
    {
        DIR,
        FILE
    }
    class Program
    {
        static void Main(string[] args)
        {
            FARMode mode = FARMode.DIR;
            DirectoryInfo root = new DirectoryInfo(@"C:\");//basic directory//
            Stack<Layer> history = new Stack<Layer>();
            history.Push(
                    new Layer
                    {
                        Content = root.GetFileSystemInfos().ToList(),
                        SelectedItem = 0
                    }
                );


            while (true)
            {
                if (mode == FARMode.DIR)
                {
                    history.Peek().Draw();
                }
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.Delete://delete//
                        history.Peek().DeleteSelectedItem();
                        break;
                    case ConsoleKey.UpArrow://up//
                        history.Peek().SelectedItem--;
                        break;
                    case ConsoleKey.DownArrow://down//
                        history.Peek().SelectedItem++;
                        break;
                    case ConsoleKey.Backspace://go back//
                        if (mode == FARMode.DIR)
                        {
                            history.Pop();
                        }
                        else
                        {
                            mode = FARMode.DIR;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.Enter://open dir//
                        int x = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo = history.Peek().Content[x];
                        if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo directoryInfo = fileSystemInfo as DirectoryInfo;
                            history.Push(
                               new Layer//executes another code Layer with new info about directory//
                               {
                                   Content = directoryInfo.GetFileSystemInfos().ToList(),
                                   SelectedItem = 0
                               });
                        }
                        else
                        {
                            mode = FARMode.FILE;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            using (StreamReader sr = new StreamReader(fileSystemInfo.FullName))
                            {
                                Console.WriteLine(sr.ReadToEnd());
                            }
                        }
                        break;
                }
            }
        }
    }
}