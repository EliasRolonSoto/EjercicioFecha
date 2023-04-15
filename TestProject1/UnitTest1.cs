namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var fecha = DateTime.Now;

            //Directory.CreateDirectory("Año2023");

            //var d = new DirectoryInfo("Año2023");

            //d.CreateSubdirectory("Mes04");

            //var d2 = new DirectoryInfo("Año2023/Mes04");

            //d2.CreateSubdirectory("Dia11");

            //var d3 = new DirectoryInfo("Año2023/Mes04/Dia11");

            // archivo 2023/04/11/2023-11-04

            string directoryPath = string.Format("{0}/{1}/{2}", "2023", "11", "04");

            Directory.CreateDirectory(directoryPath);

            string archivoFormato = string.Format("{0}.txt", "2023-11-04");

            File.WriteAllText
                (path: directoryPath,
                contents: "cualquier cosa"
                );




            Assert.True(true);

        }
    }
}