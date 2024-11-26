namespace kolory;

public partial class NewPage1 : ContentPage
{
    int[] liczba = new int[3];
	public NewPage1()
	{
		InitializeComponent();
	}

    private void odejmi1(object sender, EventArgs e)
    {
        if (liczba[0] != 0)
        {
            liczba[0]--;
            text1.Text = $"{liczba[0]} polubieñ";
        }
    }

    private void dodaj1(object sender, EventArgs e)
    {
        liczba[0]++;
        text1.Text = $"{liczba[0]} polubieñ";
    }

    private void odejmi2(object sender, EventArgs e)
    {
        if (liczba[1] != 0)
        {
            liczba[1]--;
            text2.Text = $"{liczba[1]} polubieñ";
        }
    }

    private void dodaj2(object sender, EventArgs e)
    {
        liczba[1]++;
        text2.Text = $"{liczba[1]} polubieñ";
    }

    private void odejmi3(object sender, EventArgs e)
    {
        if (liczba[2] != 0)
        {
            liczba[2]--;
            text3.Text = $"{liczba[2]} polubieñ";
        }
    }

    private void dodaj3(object sender, EventArgs e)
    {
        liczba[2]++;
        text3.Text = $"{liczba[2]} polubieñ";
    }
}