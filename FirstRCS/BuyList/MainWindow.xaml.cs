using System.Windows;

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
            //Lai varētu iet cauri sarakstam klikšķinot lietas atsevišķi, lai viņas nerādās kā viens kopīgs saraksts
           var ReturnFromFile = File.ReadAllLines(@"C:\Users\Diana\CODES\RigaCodingSchool.test.txt");
            //i ir counters tikai īsāk nosaukts
            //no sākuma sistēma skata i=0, tad tiek pie i<Return....., kad šis izpildās, sistēma izpilda, to, kas zemā sistēmā minēts
            //kad viss izdarīts tad veic darbību i++, kas ir i = i+1
            for(int i = 0; i < ReturnFromFile.Length; i++)
            {
                //xxx ir jauns mainīgais, kurš ir atsevišķi no visa kopējā saraksta un var viņu ieklikšķināt
                var xxx = ReturnFromFile[i];
                this.BuyItemsList.Add(xxx);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedItems = this.BuyItemListControl.SelectedItems[0] as string;
            this.BuyItemsList.Remove(selectedItems);

           
        }
    }
}
