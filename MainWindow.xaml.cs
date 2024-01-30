using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {

        private Random random = new Random();
        private Button[] buttons;
        private bool isPlayerXTurn = true;
        private char currentPlayer = 'x';



        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[9] { _1, _2, _3, _4, _5, _6, _7, _8, _9 };
            StartNewGame();

        }

        private void _1_Clicks(object sender, RoutedEventArgs e)
        {




            List<Button> availableButtons = new List<Button>();
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)
                    availableButtons.Add(button);
            }

            Button clickedButton = (sender as Button);

            // Проверка, пусто ли содержимое кнопки
            if (string.IsNullOrEmpty(clickedButton.Content as string))
            {
                clickedButton.Content = "x";
                clickedButton.IsEnabled = false;

                // Проверка на победу
                if (CheckForWinner("x"))
                {
                    MessageBox.Show("Игрок X победил!");
                    // Здесь вы можете добавить логику для завершения игры или начать новую игру
                }
                else
                {
                    Random random = new Random();


                    // Проверка, есть ли еще доступные кнопки
                    if (availableButtons.Count > 1)
                    {
                        currentPlayer = (currentPlayer == 'x') ? '0' : 'x'; // Переключение между X и 0

                        if (IsGameEnded()) return;

                        int knopka;
                        // Найти пустую кнопку для размещения "0"
                        do
                        {
                            knopka = random.Next(0, 9);
                        } while (!string.IsNullOrEmpty(buttons[knopka].Content as string) || buttons[knopka] == clickedButton);

                        buttons[knopka].Content = "0";
                        buttons[knopka].IsEnabled = false;

                        // Проверка на победу
                        if (CheckForWinner("0"))
                        {
                            MessageBox.Show("Игрок 0 победил!");
                            // Здесь вы можете добавить логику для завершения игры или начать новую игру
                        }
                    }
                }
                
            }
        }

        private void _2_Clicks(object sender, RoutedEventArgs e)
        {

   

            List<Button> availableButtons = new List<Button>();
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)
                    availableButtons.Add(button);
            }

            Button clickedButton = (sender as Button);

            // Проверка, пусто ли содержимое кнопки
            if (string.IsNullOrEmpty(clickedButton.Content as string))
            {
                clickedButton.Content = "x";
                clickedButton.IsEnabled = false;

                // Проверка на победу
                if (CheckForWinner("x"))
                {
                    MessageBox.Show("Игрок X победил!");
                    // Здесь вы можете добавить логику для завершения игры или начать новую игру
                }
                else
                {
                    Random random = new Random();



                    // Проверка, есть ли еще доступные кнопки
                    if (availableButtons.Count > 1)
                    {

                        currentPlayer = (currentPlayer == 'x') ? '0' : 'x'; // Переключение между X и 0
                        if (IsGameEnded()) return;
                        int knopka;
                        // Найти пустую кнопку для размещения "0"
                        do
                        {
                            knopka = random.Next(0, 9);
                        } while (!string.IsNullOrEmpty(buttons[knopka].Content as string) || buttons[knopka] == clickedButton);

                        buttons[knopka].Content = "0";
                        buttons[knopka].IsEnabled = false;

                        // Проверка на победу
                        if (CheckForWinner("0"))
                        {
                            MessageBox.Show("Игрок 0 победил!");
                            // Здесь вы можете добавить логику для завершения игры или начать новую игру
                        }
                    }
                }
            }
        }

        private void _3_Clicks(object sender, RoutedEventArgs e)
        {



            List<Button> availableButtons = new List<Button>();
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)
                    availableButtons.Add(button);
            }

            Button clickedButton = (sender as Button);

            // Проверка, пусто ли содержимое кнопки
            if (string.IsNullOrEmpty(clickedButton.Content as string))
            {
                clickedButton.Content = "x";
                clickedButton.IsEnabled = false;

                // Проверка на победу
                if (CheckForWinner("x"))
                {
                    MessageBox.Show("Игрок X победил!");
                    // Здесь вы можете добавить логику для завершения игры или начать новую игру
                }
                else
                {
                    Random random = new Random();



                    // Проверка, есть ли еще доступные кнопки
                    if (availableButtons.Count > 1)
                    {


                        currentPlayer = (currentPlayer == 'x') ? '0' : 'x'; // Переключение между X и 0
                        if (IsGameEnded()) return;

                        int knopka;
                        // Найти пустую кнопку для размещения "0"
                        do
                        {
                            knopka = random.Next(0, 9);
                        } while (!string.IsNullOrEmpty(buttons[knopka].Content as string) || buttons[knopka] == clickedButton);

                        buttons[knopka].Content = "0";
                        buttons[knopka].IsEnabled = false;

                        // Проверка на победу
                        if (CheckForWinner("0"))
                        {
                            MessageBox.Show("Игрок 0 победил!");
                            // Здесь вы можете добавить логику для завершения игры или начать новую игру
                        }
                    }
                }
            }

        }

        private void _4_Clicks(object sender, RoutedEventArgs e)
        {

      

            List<Button> availableButtons = new List<Button>();
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)
                    availableButtons.Add(button);
            }

            Button clickedButton = (sender as Button);

            // Проверка, пусто ли содержимое кнопки
            if (string.IsNullOrEmpty(clickedButton.Content as string))
            {
                clickedButton.Content = "x";
                clickedButton.IsEnabled = false;

                // Проверка на победу
                if (CheckForWinner("x"))
                {
                    MessageBox.Show("Игрок X победил!");
                    // Здесь вы можете добавить логику для завершения игры или начать новую игру
                }
                else
                {
                    Random random = new Random();




                    // Проверка, есть ли еще доступные кнопки
                    if (availableButtons.Count > 1)
                    {
                        currentPlayer = (currentPlayer == 'x') ? '0' : 'x'; // Переключение между X и 0
                        if (IsGameEnded()) return;

                        int knopka;
                        // Найти пустую кнопку для размещения "0"
                        do
                        {
                            knopka = random.Next(0, 9);
                        } while (!string.IsNullOrEmpty(buttons[knopka].Content as string) || buttons[knopka] == clickedButton);

                        buttons[knopka].Content = "0";
                        buttons[knopka].IsEnabled = false;

                        // Проверка на победу
                        if (CheckForWinner("0"))
                        {
                            MessageBox.Show("Игрок 0 победил!");
                            // Здесь вы можете добавить логику для завершения игры или начать новую игру
                        }
                    }
                }
            }
        }

        private void _5_Clicks(object sender, RoutedEventArgs e)
        {



            List<Button> availableButtons = new List<Button>();
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)
                    availableButtons.Add(button);
            }

            Button clickedButton = (sender as Button);

            // Проверка, пусто ли содержимое кнопки
            if (string.IsNullOrEmpty(clickedButton.Content as string))
            {
                clickedButton.Content = "x";
                clickedButton.IsEnabled = false;

                // Проверка на победу
                if (CheckForWinner("x"))
                {
                    MessageBox.Show("Игрок X победил!");
                    // Здесь вы можете добавить логику для завершения игры или начать новую игру
                }
                else
                {
                    Random random = new Random();




                    // Проверка, есть ли еще доступные кнопки
                    if (availableButtons.Count > 1)
                    {
                        currentPlayer = (currentPlayer == 'x') ? '0' : 'x'; // Переключение между X и 0
                        if (IsGameEnded()) return;

                        int knopka;
                        // Найти пустую кнопку для размещения "0"
                        do
                        {
                            knopka = random.Next(0, 9);
                        } while (!string.IsNullOrEmpty(buttons[knopka].Content as string) || buttons[knopka] == clickedButton);

                        buttons[knopka].Content = "0";
                        buttons[knopka].IsEnabled = false;

                        // Проверка на победу
                        if (CheckForWinner("0"))
                        {
                            MessageBox.Show("Игрок 0 победил!");
                            // Здесь вы можете добавить логику для завершения игры или начать новую игру
                        }
                    }
                }
            }
        }

        private void _6_Clicks(object sender, RoutedEventArgs e)
        {

   

            List<Button> availableButtons = new List<Button>();
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)
                    availableButtons.Add(button);
            }

            Button clickedButton = (sender as Button);

            // Проверка, пусто ли содержимое кнопки
            if (string.IsNullOrEmpty(clickedButton.Content as string))
            {
                clickedButton.Content = "x";
                clickedButton.IsEnabled = false;

                // Проверка на победу
                if (CheckForWinner("x"))
                {
                    MessageBox.Show("Игрок X победил!");
                    // Здесь вы можете добавить логику для завершения игры или начать новую игру
                }
                else
                {
                    Random random = new Random();




                    // Проверка, есть ли еще доступные кнопки
                    if (availableButtons.Count > 1)
                    {
                        currentPlayer = (currentPlayer == 'x') ? '0' : 'x'; // Переключение между X и 0
                        if (IsGameEnded()) return;

                        int knopka;
                        // Найти пустую кнопку для размещения "0"
                        do
                        {
                            knopka = random.Next(0, 9);
                        } while (!string.IsNullOrEmpty(buttons[knopka].Content as string) || buttons[knopka] == clickedButton);

                        buttons[knopka].Content = "0";
                        buttons[knopka].IsEnabled = false;

                        // Проверка на победу
                        if (CheckForWinner("0"))
                        {
                            MessageBox.Show("Игрок 0 победил!");
                            // Здесь вы можете добавить логику для завершения игры или начать новую игру
                        }
                    }
                }
            }
        }

        private void _7_Clicks(object sender, RoutedEventArgs e)
        {



            List<Button> availableButtons = new List<Button>();
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)
                    availableButtons.Add(button);
            }

            Button clickedButton = (sender as Button);

            // Проверка, пусто ли содержимое кнопки
            if (string.IsNullOrEmpty(clickedButton.Content as string))
            {
                clickedButton.Content = "x";
                clickedButton.IsEnabled = false;

                // Проверка на победу
                if (CheckForWinner("x"))
                {
                    MessageBox.Show("Игрок X победил!");
                    // Здесь вы можете добавить логику для завершения игры или начать новую игру
                }
                else
                {
                    Random random = new Random();



                    // Проверка, есть ли еще доступные кнопки
                    if (availableButtons.Count > 1)
                    {
                        currentPlayer = (currentPlayer == 'x') ? '0' : 'x'; // Переключение между X и 0
                        if (IsGameEnded()) return;


                        int knopka;
                        // Найти пустую кнопку для размещения "0"
                        do
                        {
                            knopka = random.Next(0, 9);
                        } while (!string.IsNullOrEmpty(buttons[knopka].Content as string) || buttons[knopka] == clickedButton);

                        buttons[knopka].Content = "0";
                        buttons[knopka].IsEnabled = false;

                        // Проверка на победу
                        if (CheckForWinner("0"))
                        {
                            MessageBox.Show("Игрок 0 победил!");
                            // Здесь вы можете добавить логику для завершения игры или начать новую игру
                        }
                    }
                }
            }
        }

        private void _8_Clicks(object sender, RoutedEventArgs e)
        {



            List<Button> availableButtons = new List<Button>();
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)
                    availableButtons.Add(button);
            }

            Button clickedButton = (sender as Button);

            // Проверка, пусто ли содержимое кнопки
            if (string.IsNullOrEmpty(clickedButton.Content as string))
            {
                clickedButton.Content = "x";
                clickedButton.IsEnabled = false;

                // Проверка на победу
                if (CheckForWinner("x"))
                {
                    MessageBox.Show("Игрок X победил!");
                    // Здесь вы можете добавить логику для завершения игры или начать новую игру
                }
                else
                {
                    Random random = new Random();


 


                    // Проверка, есть ли еще доступные кнопки
                    if (availableButtons.Count > 1)
                    {
                        currentPlayer = (currentPlayer == 'x') ? '0' : 'x'; // Переключение между X и 0
                        if (IsGameEnded()) return;

                        int knopka;
                        // Найти пустую кнопку для размещения "0"
                        do
                        {
                            knopka = random.Next(0, 9);
                        } while (!string.IsNullOrEmpty(buttons[knopka].Content as string) || buttons[knopka] == clickedButton);

                        buttons[knopka].Content = "0";
                        buttons[knopka].IsEnabled = false;

                        // Проверка на победу
                        if (CheckForWinner("0"))
                        {
                            MessageBox.Show("Игрок 0 победил!");
                            // Здесь вы можете добавить логику для завершения игры или начать новую игру
                        }
                    }
                }
            }
        }


            private void _9_Clicks(object sender, RoutedEventArgs e)
            {



            List<Button> availableButtons = new List<Button>();
                foreach (Button button in buttons)
                {
                      if (button.IsEnabled)
                        availableButtons.Add(button);
                }

                Button clickedButton = (sender as Button);

                // Проверка, пусто ли содержимое кнопки
                if (string.IsNullOrEmpty(clickedButton.Content as string))
                {
                    clickedButton.Content = "x";
                    clickedButton.IsEnabled = false;

                    // Проверка на победу
                    if (CheckForWinner("x"))
                    {
                        MessageBox.Show("Игрок X победил!");
                        // Здесь вы можете добавить логику для завершения игры или начать новую игру
                    }
                    else
                    {
                        Random random = new Random();

                    // Проверка, есть ли еще доступные кнопки
                    if (availableButtons.Count > 1)
                    {
                        currentPlayer = (currentPlayer == 'x') ? '0' : 'x'; // Переключение между X и 0
                        if (IsGameEnded()) return;

                        int knopka;
                        // Найти пустую кнопку для размещения "0"
                        do
                        {
                            knopka = random.Next(0, 9);
                        } while (!string.IsNullOrEmpty(buttons[knopka].Content as string) || buttons[knopka] == clickedButton);

                        buttons[knopka].Content = "0";
                        buttons[knopka].IsEnabled = false;

                        // Проверка на победу
                        if (CheckForWinner("0"))
                        {
                            MessageBox.Show("Игрок 0 победил!");
                            // Здесь вы можете добавить логику для завершения игры или начать новую игру
                        }
                    }
                }
                }
            }




        private void StartNewGame()
        {
            foreach (Button button in buttons)
            {
                button.IsEnabled = true;
                button.Content = "";
            }

            isPlayerXTurn = true;

        }

        private void EndGame()
        {
            foreach (Button button in buttons)
            {
                button.IsEnabled = false;
            }

            MessageBox.Show("Игра завершена");
        }


        private bool IsGameEnded()
        {
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)
                {
                    // Есть доступная кнопка, игра не завершена
                    return false;
                }
            }

            // Все кнопки заблокированы, игра завершена
            return true;
        }



        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            StartNewGame();
        }

        private bool CheckForWinner(string player)
        {
            // Проверка горизонтальных линий
            for (int i = 0; i < 3; i++)
            {
                if ((buttons[i * 3].Content as string == player) &&
                    (buttons[i * 3 + 1].Content as string == player) &&
                    (buttons[i * 3 + 2].Content as string == player))
                {
                    return true;
                }
            }

            // Проверка вертикальных линий
            for (int i = 0; i < 3; i++)
            {
                if ((buttons[i].Content as string == player) &&
                    (buttons[i + 3].Content as string == player) &&
                    (buttons[i + 6].Content as string == player))
                {
                    return true;
                }
            }

            // Проверка диагонали (слева направо)
            if ((buttons[0].Content as string == player) &&
                (buttons[4].Content as string == player) &&
                (buttons[8].Content as string == player))
            {
                return true;
            }

            // Проверка диагонали (справа налево)
            if ((buttons[2].Content as string == player) &&
                (buttons[4].Content as string == player) &&
                (buttons[6].Content as string == player))
            {
                return true;
            }

            return false;
        }



    }

}

 