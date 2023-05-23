namespace UI.Code;

public class Persist {
    public static void Save<T>(List<T> Data, string FileName) { 
        string ser = System.Text.Json.JsonSerializer.Serialize<List<T>>(Data);
        var fullSpec = CurrentFolder() + AppendJsonExtension(FileName);
        File.WriteAllText(fullSpec, ser);
    }

    public static bool Exists(string FileName) {
        return System.IO.File.Exists(CurrentFolder() + AppendJsonExtension(FileName));
    }

    public static List<T> Load<T>(string FileName) {
        var fullSpec = CurrentFolder() + AppendJsonExtension(FileName);
        var s = System.IO.File.ReadAllText(fullSpec);
        return System.Text.Json.JsonSerializer.Deserialize<List<T>>(s)??new List<T>();
    }

    private static string CurrentFolder() {
        return (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) ?? "") + "\\Patches\\";
    }

    private static string AppendJsonExtension(string fileName) {
        string extension = Path.GetExtension(fileName);
        if (extension != ".json") {
            fileName = string.Concat(fileName, ".json");
        }

        return fileName;
    }
}