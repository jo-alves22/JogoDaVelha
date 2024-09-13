using System;

namespace JogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int jogadas = 0; // Contador de jogadas

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;

            var buttons_list = new List<Button> { btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18 };

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            jogadas++; // Incrementa o contador de jogadas

            // Verificando se o X ganhou
            if (
                (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") ||
                (btn13.Text == "X" && btn14.Text == "X" && btn15.Text == "X") ||
                (btn16.Text == "X" && btn17.Text == "X" && btn18.Text == "X") ||
                (btn10.Text == "X" && btn14.Text == "X" && btn18.Text == "X") ||
                (btn16.Text == "X" && btn14.Text == "X" && btn12.Text == "X") ||
                (btn10.Text == "X" && btn13.Text == "X" && btn16.Text == "X") ||
                (btn11.Text == "X" && btn14.Text == "X" && btn17.Text == "X") ||
                (btn12.Text == "X" && btn15.Text == "X" && btn18.Text == "X")
                )
            {
                DisplayAlert("Parabéns", "X ganhou", "OK");
                Zerar();
                return;
            }

            // Verificando se o O ganhou
            if (
                (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") ||
                (btn13.Text == "O" && btn14.Text == "O" && btn15.Text == "O") ||
                (btn16.Text == "O" && btn17.Text == "O" && btn18.Text == "O") ||
                (btn10.Text == "O" && btn14.Text == "O" && btn18.Text == "O") ||
                (btn16.Text == "O" && btn14.Text == "O" && btn12.Text == "O") ||
                (btn10.Text == "O" && btn13.Text == "O" && btn16.Text == "O") ||
                (btn11.Text == "O" && btn14.Text == "O" && btn17.Text == "O") ||
                (btn12.Text == "O" && btn15.Text == "O" && btn18.Text == "O")
                )
            {
                DisplayAlert("Parabéns", "O ganhou", "OK");
                Zerar();
                return;
            }

            // Verificando se todas as jogadas foram feitas (empate)
            if (jogadas == 9)
            {
                DisplayAlert("Ninguém ganhou", "Recomece o jogo", "OK");
                Zerar();
            }
        } // Fecha metodo

        void Zerar()
        {
            // Crie uma lista ou array com os botões
            var buttons_list = new List<Button> { btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18 };

            // Percorra a lista para alterar as propriedades dos botões
            foreach (var button in buttons_list)
            {
                button.Text = "";
                button.IsEnabled = true;
            }

            jogadas = 0; // Reseta o contador de jogadas
        }

    } // fecha classe

} // fecha o namespace
