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

namespace BuyList
{
    using System.Collections.ObjectModel;
    using System.IO;
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //nodefinējam, ka šajā logā (aplikācijā), tiks izveidots saraksts mainīgs
        //Ja mēs nodefinējam vienkārši "List" tad logā neparadas nekas jauns, tikai, tas kas ir kodā, ja 
        //ievadam textboksā jaunu tekstu, viņš pazūd
        //tapēc vadam "ObservableCollection", kas ir tas pats, kas List, tikai uzreiz parāda izmaiņas.
        public ObservableCollection<string> BuyItemsList = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            BuyListItemName.Text = "";
            this.BuyItemsList.Add("āboli");
            // pasakamkontrolē i laiizmanto mūsu sarakstu
            this.BuyItemsList.Add("bumbieri");

            BuyItemListControl.ItemsSource = BuyItemsList;
        }

        private void AddListItemButton_Click(object sender, RoutedEventArgs e)
        {
            //norādam ka mainīgais x būs šis konkretais teksts, kas tiek ievadīts šajā konkretajā Textboksā
            string x = this.BuyListItemName.Text;
            //kolīdz nospiežam pogu PIEVIENOT, tad šajā Textboksā izdzēšas teksts un viņš paliek tukšs
            this.BuyListItemName.Text = "";
            //Blokā, ko izveidojām, norādam, ka, pēc pogas PIEVIENOT nospiešanas ievadītā prece Textboksā paršadās
            //šajā konkrētajā blokā tad rakstam this.ByItemName.Text = x
            
            //Taču šoreiz mēs gribam, lai Textboksā parādās neierobezots skaits ar atzīmētajiem tekstiem Textboksā
            this.BuyItemsList.Add(x);


        }

        private void SaveItems_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllLines(@"C:\Users\Diana\CODES\RigaCodingSchool.test.txt", this.BuyItemsList);
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
           string ReturnFromFile = File.ReadAllLines(@"C:\Users\Diana\CODES\RigaCodingSchool.test.txt");
           this.BuyItemsList.Add(ReturnFromFile);

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedItems = this.BuyItemListControl.SelectedItems[0] as string;
            this.BuyItemsList.Remove(selectedItems);

        }
    }
}
