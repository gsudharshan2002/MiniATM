using System.Configuration;
using System.Data;
using System.Windows;

namespace MiniATM
{
    /// <summary>
    
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var obj=new LonginWindow();
            obj.Show();
        }
    }

}
