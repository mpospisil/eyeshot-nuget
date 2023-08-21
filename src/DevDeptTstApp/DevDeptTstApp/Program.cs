// See https://aka.ms/new-console-template for more information
using DevDeptTstApp;
using Microsoft.Extensions.Configuration;

public class Program
{
  public static int Main(string[] args)
  {
    try
    {
      Console.WriteLine("Building configuration");
      var configuration = BuildConfiguration();
      
      var deptDepthKey = configuration["DEV_DEPT_KEY"];
      if (string.IsNullOrEmpty(deptDepthKey))
      {
        throw new Exception("missing 'DEV_DEPT_KEY' in configuration");
      }
        Console.WriteLine($"Trying to unlock devDept license key = '{deptDepthKey}'");
      DevDeptLicense.Init(deptDepthKey);
    }
    catch (Exception e)
    {
      Console.WriteLine(e.ToString());
      return 1;
    }

    Console.WriteLine("devDept.LicenseManager.Unlock succeeded");
    return 0;
  }

  public static IConfigurationRoot BuildConfiguration()
  {
    return new ConfigurationBuilder()
      .AddJsonFile("appsettings.json")
      .AddEnvironmentVariables()
      .Build();
  }
}
