namespace trojan_win_starter
{
  static class MainClass
  {
    static void Main()
    {
      System.Diagnostics.Process process = new System.Diagnostics.Process();
      process.StartInfo.FileName = "./trojan.exe";
      process.StartInfo.Arguments = "./config.json";
      process.StartInfo.CreateNoWindow = true;
      process.StartInfo.UseShellExecute = false;
      process.Start();
    }
  }
}
