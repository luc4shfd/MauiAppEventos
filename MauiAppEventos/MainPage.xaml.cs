using System;

namespace MauiAppEventos
{
    public partial class MainPage : ContentPage
    {
        private Evento evento;

        public MainPage()
        {
            InitializeComponent();

            // Inicializando a instância de Evento e configurando o BindingContext
            evento = new Evento
            {
                DataInicio = DateTime.Now,
                DataTermino = DateTime.Now
            };
            BindingContext = evento;
        }

        private async void OnSendDataClicked(object sender, EventArgs e)
        {
            // Validação simples
            if (string.IsNullOrWhiteSpace(evento.Nome) || evento.NumeroParticipantes <= 0 || evento.CustoPorParticipante <= 0)
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos corretamente.", "OK");
                return;
            }

            if (evento.DataInicio > evento.DataTermino)
            {
                await DisplayAlert("Erro", "A data de início deve ser antes da data de término.", "OK");
                return;
            }

            // Navegando para a página de resumo
            await Navigation.PushAsync(new EventDetailsPage(evento));
        }
    }
}
