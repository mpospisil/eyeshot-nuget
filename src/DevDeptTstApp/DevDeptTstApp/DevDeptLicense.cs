namespace DevDeptTstApp
{
  public class DevDeptLicense
  {
    private static bool isInited;
    private static object EyeshotLock = new object();

    public static void Init(string key)
    {
      lock (EyeshotLock)
      {
        if (isInited)
        {
          return;
        }

        //devDept.LicenseManager.Unlock(Key);
        devDept.LicenseManager.Unlock(key);

        isInited = true;
      }
    }
  }
}
