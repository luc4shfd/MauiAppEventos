namespace MauiAppEventos
{
    public partial class EventDetailsPage : ContentPage
    {
        public EventDetailsPage(Evento evento)
        {
            InitializeComponent();

            // Definindo o contexto de dados para exibir informações do evento
            BindingContext = evento;
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
