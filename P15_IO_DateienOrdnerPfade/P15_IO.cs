using System.Collections;

namespace P15_IO_DateienOrdnerPfade
{
    internal class P15_IO
    {

        static void Main(string[] args)
        {

            Console.WriteLine("*********** File Class **********");
            // CREATE File
            string path = "demoFileClass.txt";
            File.Create(path).Close(); // wichtig: immer schliessen nach dem Erstellen

            // WRITE File
            File.WriteAllText(path, "Hallo von Manuel");

            // APPEND in File
            if (File.Exists(path))
            {
                File.AppendAllText(path, "\nDiese Zeile wird hinzugefügt");
            }

            // COPY File
            string newPath = "newDemoFileCass.txt";
            if (File.Exists(path))
            {
                File.Copy(path, newPath);
            }

            // READ File
            if (File.Exists(newPath))
            {
                Console.WriteLine(File.ReadAllText(newPath));
            }

            // DELETE File
            if (File.Exists(newPath))
            {
                File.Delete(newPath);
            }
            if (File.Exists(path))
            {
                File.Delete(path);
            }







            Console.WriteLine("*********** Directory Class **********");

            string demoPath = "files/";
            string demoFileName = "demoDirectoryClass.txt";

            // CREATE Directory
            if(Directory.Exists(demoPath))
            {
                Console.WriteLine("Ordner existiert");
            }
            else
            {
                // Erstellt neuen Ordner
                Directory.CreateDirectory(demoPath);

                // Erstellt neue Ordner mit darin enthaltenen Unterordnern
                Directory.CreateDirectory(demoPath + "/subfolder/subsubfolder");
                Directory.CreateDirectory(demoPath + "othersub/othersubsub");
            }

            // GET Functions

            // GetDirectories
            string[] directories = Directory.GetDirectories(demoPath);
            Console.WriteLine("*** GetDirectories ***");
            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }



            File.Create(demoPath + "/file1.txt").Close();
            File.Create(demoPath + "/file2.txt").Close();
            File.Create(demoPath + "/file3.txt").Close();


            // GetFiles

            string[] files =  Directory.GetFiles(demoPath);
            Console.WriteLine("*** GetFiles ***");
            foreach(string file in files)
            {
                Console.WriteLine(file);
            }


            // GetCurrentDirectory
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("*** GetCurrentDirectory ***");
            Console.WriteLine(currentDirectory);



            // DELETE Directory
            Directory.Delete(demoPath, true); // delete recursive (with all Content)



            Console.WriteLine("*********** Environment Class **********");
            Console.WriteLine("Wird verwendet, um spezielle Ordnerpfade zu erhalten");

            string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string myDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Console.WriteLine(myDocumentsPath);
            Console.WriteLine(myDesktop);



            Console.WriteLine("*********** Path Class **********");
            string myPath1 = "path1";
            string myPath2 = "path2";
            string myFileA = "text.txt";
            string myFileB = "music.mp3";
            List<string> finalPaths = [];
            finalPaths.Add(Path.Combine(myPath1, myPath2, myFileA)); // path1\path2\text.txt
            finalPaths.Add(Path.Combine(myPath1, myPath2, myFileB)); // path1\path2\music.mp3

            foreach (string finalPath in finalPaths)
            {
                Console.WriteLine(finalPath);
                Console.WriteLine(Path.GetExtension(finalPath));
            }

        }
    }
}
