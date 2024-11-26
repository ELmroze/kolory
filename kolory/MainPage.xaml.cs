namespace kolory
{
    public partial class MainPage : ContentPage
    {
        byte[] text=new byte[3];
        Color color=new Color();
        public MainPage()
        {
            InitializeComponent();
            text[0] = (byte)rSlider.Value;
            text[1] = (byte)gSlider.Value;
            text[2] = (byte)bSlider.Value;
            rLabel.Text=$"r: {text[0].ToString()}";
            gLabel.Text = $"g: {text[1].ToString()}";
            bLabel.Text = $"b: {text[2].ToString()}";
        }

        private void redSlider(object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
        {
            text[0] = (byte)e.NewValue;
            rLabel.Text = $"r: {text[0].ToString()}";
            color = new Color(text[0], text[1], text[2]);
            box.Color = color;
        }

        private void greenSlider(object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
        {
            text[1] = (byte)e.NewValue;
            gLabel.Text = $"g: {text[1].ToString()}";
            color = new Color(text[0], text[1], text[2]);
            box.Color = color;
        }

        private void blueSlider(object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
        {
            text[2] = (byte)e.NewValue;
            bLabel.Text = $"b: {text[2].ToString()}";
            color=new Color(text[0], text[1], text[2]);
            box.Color = color;
        }
    }
}
