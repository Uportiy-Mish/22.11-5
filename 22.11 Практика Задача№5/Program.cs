using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _22._11_Практика_Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1;
            name1 = Interaction.InputBox("Введите ваше имя",
                "Ввод Имени");
            string name2;
            name2 = Interaction.InputBox("Введите ваш год рождения => Пример - 11.11.1111",
            "Ввод года рождения");
            string txt = "Имя: " + name1 + ", Год Рождения: " + name2;
            MessageBox.Show(txt, "Итог.");
        }
    }
}