namespace BlazorApp.Client.Shared
{
    public partial class MyPrompt
    {
        public bool? Happy { get; private set; } = null;

        private void DisplayHappy()
        {
            Happy = true;
        }

        private void DisplaySad()
        {
            Happy = false;
        }
    }
}
