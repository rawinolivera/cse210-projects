using System.IO;
using System.Runtime.CompilerServices;

class Journal
{
  public List<Entry> _entries = new List<Entry>();
  public void DisplayJournal()
  {
    foreach (Entry entry in _entries)
    {
      entry.DisplayEntry();
    }
  }

  public void SetPrompts()
  {
    List<string> wPrompts = new List<string>();

    wPrompts.Add("what did you do today that was meaningful? ");
    wPrompts.Add("Is there something from this day that you could do different? ");
    wPrompts.Add("What did you do today to help someone? ");
    wPrompts.Add("Is there something special from this day that you want to remeber? ");
    wPrompts.Add("What did you do today that you want to do it again? ");
    wPrompts.Add("What did make this day funny? ");

    Random randomGenerator = new Random();
    int indexList = randomGenerator.Next(0, 5);

    Console.WriteLine(wPrompts[indexList]);
    string response = Console.ReadLine();

    //Let's define the date
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();

    Entry entry = new Entry();
    entry._date = dateText;
    entry._prompt = wPrompts[indexList];
    entry._response = response;
    _entries.Add(entry);
  }

  public void SaveJournal()
  {
    Console.Write("What is the file name? ");
    string name = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(name))
    {
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine(entry._date);
        outputFile.WriteLine(entry._prompt);
        outputFile.WriteLine(entry._response);
      }
      Console.WriteLine($"Your Jornal is saved as {name}");
    }
  }

  public void LoadJournal()
  {
    Console.Write("What is the file name? ");
    string name = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(name);
    int side = lines.Length;
    side = side - 1;

    int i = 0;
    int j = 1;
    int k = 2;
    for (int f = 0; f <= side; f = f + 3)
    {

      Entry entry = new Entry();
      //getting different positions from the array
      entry._date = lines[i];   //0, 3
      entry._prompt = lines[j];  //1,4
      entry._response = lines[k];   //2,5
                                    //incrementing the indexes
      i = i + 3;
      j = j + 3;
      k = k + 3;
      _entries.Add(entry);
    }
    Console.WriteLine("Journal Loaded!!");
  }

}