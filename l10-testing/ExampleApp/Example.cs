//EXAMPLE TEST
namespace ExampleApp;

public class Example {
    public string combineArrayString(string[] stringArray) {
        throw new NotImplementedException();
    }
}


//_________________________________________________________
//CASE 1: VALID INPUT
public string combineArrayString(string[] stringArray) {
    string str = "";

    foreach (string item in stringArray)
    {
        str += item + " ";
    }

    return str.Trim();  // Trim leading/trailing spaces
}

