using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViActManage
{
    public static class ActManager
    {
        public static bool Retry(this Action act, int retryCount = 5)
        {
            for (int i = 0; i < retryCount || retryCount == 0; i++)
            {
                try
                {
                    act.Invoke();
                    return true;
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            return false;
        }
    }
}
