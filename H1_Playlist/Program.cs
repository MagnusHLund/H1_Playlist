namespace H1_Playlist
{
    internal class Program
    {
        /// <summary>
        /// Calls the controller class and gets out of static
        /// </summary>
        static void Main()
        {
            Controller.Controller controller = new();
            controller.StartController();
        }
    }
}