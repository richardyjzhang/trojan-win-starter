# trojan-win-starter

用于 Windows 系统后台运行[trojan](https://trojan-gfw.github.io/trojan/)程序，可以避免显示小黑框，代码就下面这几行：

```C#
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
```

编译后的.exe 二进制文件和 trojan 程序放置于同级目录，双击即可在后台调用，没有黑框。

如果需要开机自动启动，可创建快捷方式后，拖入开始菜单的启动中。Win10 系统可通过运行`shell:startup`来打开相关路径。
