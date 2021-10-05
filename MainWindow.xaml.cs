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

namespace самообучение
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public class Pleyer
        {
            private string name;
            private int heal;
            private int mana;
            private int dmg;
            private bool? clas;
            private string clasName;

            public Pleyer(string name, bool? clas)
            {
                this.name = name;
                this.clas = clas;
                if(clas == true)
                {
                    this.clasName = "War";
                    this.heal = 1000;
                    this.dmg = 250;
                    this.mana = 50;
                }
                else
                {
                    this.clasName = "Rouge";
                    this.heal = 750;
                    this.dmg = 100;
                    this.mana = 250;
                }
            }
            public (string, int, int, int, string) GetParam()
            {
                (string, int, int, int, string) Get = (name, heal, mana, dmg, clasName);
                return Get;
            }
        }
        public void attack(int dmg, int heal)
        {
            
        }
        public class Skill
        {

        }
        public class MageSkill : Skill
        {

        }
        public class MageFireSkill : MageSkill
        {

        }
        public class Fireboll : MageFireSkill
        {

        }
        public class Fireboll2 : Fireboll
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string NamePers = Name.Text;
            Pleyer biba = new Pleyer(NamePers, War.IsChecked);
            LogText.Text += biba.GetParam() + "\n";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            string NamePers2 = Name2.Text;
            Pleyer boba = new Pleyer(NamePers2, War2.IsChecked);
            LogText.Text += boba.GetParam() + "\n";
        }
    }
}
