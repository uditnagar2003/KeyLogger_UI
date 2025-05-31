using Client_Library;
using KLDS;
namespace KLDS_UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           bool token = new Authentication_State().readUser_session(); // Load user session data
           if(token.Equals(false))
            {
                Application.Run(new Login_Form());
                
            }
           else
            {
                // Set the authorization header for HTTP requests
                bool tok= new AuthService().EnsureTokenValidAsync(User_Session.AccessToken);
                if (tok.Equals(false))
                {
                    Application.Run(new Login_Form());

                }
                else
                {
                    DashboardForm f = new DashboardForm();
                    f.loadform(new Dashboard(f));
                    f.Show();
                    Application.Run(f);
                } 
                    // If the token is valid, proceed to the dashboard
                   // Application.Run(new DashboardForm());
              
            }
           
        }
           // Application.Run(new Login_Form());
       
    }
   
}
