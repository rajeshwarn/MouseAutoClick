using System.Collections.Generic;
using System.Threading;

#region -   文   件   说   明  -
//
//      创 建 人：何 苦
//      创建时间：2013/05/04 15:18:43
//      功    能：自动点击线程封装
//      个人网站：http://iheku.com
//
#endregion

namespace MouseAutoClick
{
    /// <summary>
    /// 自动点击封装
    /// </summary>
    static class AutoClickThread
    {
        public static List<string> PositionData;
        static CancellationTokenSource cts;

        //开始
        public static void Start(bool isRecycleRun)
        {
            if (PositionData.Count == 0) return;

            if (cts != null && !cts.IsCancellationRequested) return;

            cts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(new WaitCallback(Run), isRecycleRun);
        }

        //停止
        public static void Stop()
        {
            if (cts != null)
                cts.Cancel();
        }

        //执行
        static void Run(object isRecycleRun)
        {
            string[] stringArray;
            int x, y, sleepTime;

            do
            {
                foreach (string item in PositionData)
                {
                    if (cts.Token.IsCancellationRequested) return;

                    stringArray = item.Split('|');
                    x = int.Parse(stringArray[0]);
                    y = int.Parse(stringArray[1]);
                    sleepTime = int.Parse(stringArray[3]);

                    switch (stringArray[2])
                    {
                        case "左单击": MouseHelper.LeftButtonClick(x, y); break;
                        case "左双击": MouseHelper.LeftButtonDoubleClick(x, y); break;
                        case "右单击": MouseHelper.RightButtonClick(x, y); break;
                        case "右双击": MouseHelper.RightButtonDoubleClick(x, y); break;
                    }

                    Thread.Sleep(sleepTime);
                }
            }
            while ((bool)isRecycleRun);
        }
    }
}
