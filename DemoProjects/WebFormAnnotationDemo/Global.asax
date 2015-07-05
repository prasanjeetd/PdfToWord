<%@ Application Language="C#" %>
<%@ Import Namespace="RasterEdge.XDoc.HTML5Viewer" %>
<%@ Import Namespace="RasterEdge.Imaging.Basic" %>
<script runat="server">

    public System.Threading.Thread schedulerThread = null;
    private static string DummyPageUrl = "";
    private const string DummyCacheItemKey = "CacheRegistry";
    void Application_Start(object sender, EventArgs e)
    {
        WorkRegistry.Reset();
        TimerTask();
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown
        if (null != schedulerThread)
        {
            schedulerThread.Abort();
        }
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs
        //Exception ex = Server.GetLastError().GetBaseException();
        //if(ex.GetType().Name.Equals("HttpException"))
        //{
        //    HttpException httpEx = (HttpException)ex;
        //    int httpCode = httpEx.GetHttpCode();
        //    if (httpCode == 404) return;
        //}
    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }

    private void TimerTask()
    {
        RegisterCacheEntry();
        Scheduler.FixAppDomainRestartWhenTouchingFiles();
        string projectName = HttpRuntime.AppDomainAppPath.Replace("\\", "/");
        string directory = projectName + System.Web.Configuration.WebConfigurationManager.AppSettings.Get("cacheFolder");
        //Scheduler.timingJobTask = new TimingJob(directory, new FixedTime(DayOfWeek.Friday, 2, 0, 0));
        Scheduler.inervalJobTask = new IntervalJob(new IntervalTime(0, 7, 0, 5), directory);
        Scheduler scheduler = new Scheduler();
        System.Threading.ThreadStart myThreadStart = new System.Threading.ThreadStart(scheduler.IntervalJobStart);
        schedulerThread = new System.Threading.Thread(myThreadStart);
        schedulerThread.Start();
    }
    
    private void RegisterCacheEntry()
    {
        if(null != HttpContext.Current.Cache[DummyCacheItemKey] ) return;
        HttpContext.Current.Cache.Add(DummyCacheItemKey,"Test",null,DateTime.MaxValue,TimeSpan.FromMinutes(15),CacheItemPriority.NotRemovable,new CacheItemRemovedCallback(CacheItemRemovedCallback));
    }
    
    public void CacheItemRemovedCallback(string key,object value,CacheItemRemovedReason reason)
    {
        System.Net.WebClient client = new System.Net.WebClient();
        client.DownloadData(DummyPageUrl);
    }
   
    protected void Application_BeginRequest(Object sender, EventArgs e)
    {
        if (DummyPageUrl == "")
            DummyPageUrl = HttpContext.Current.Request.Url.ToString();
        RegisterCacheEntry();
    }
</script>
