using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace BuyList
{
    using System.Collections.ObjectModel;
 

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

            //pievienoju mainīgo, kas ir texta fails, kur saglabājās pirkumu saraksts
            
            var text = System.IO.File.ReadAllText(@"C:\Users\Diana\CODES\RigaCodingSchool.test.txt");

            // pasakamkontrolē i laiizmanto mūsu sarakstu
            //šajā sarakstā norādam, lai automātiski parādās bumbieri (rakstot šajā.mainīgajā.Add();)
            this.BuyItemsList.Add("bumbieri");
            //tagad norādam, lai sarakstā parādās automātiski arī, tas, kas tika saglabāts iepriekš 
            //(ja saraksts tiek veidots pirmo reizi, tad tur noteikti parādīsies tukšums)
            //kas saglabājas failā. Iekavās rakstam mainīgo, kas šajā gadījumā ir "text"
            BuyItemsList.Add(text);


            //KOMENTĀRS PRIEKŠ MANIS :)"hmmm būtu forši izveidot kodu, kad lietotajam uzsākot darbu, automātiskis izveidojas savs personigais
            //saraksta fails, kas saglabājas projekta mapē, un tur arī vienmēr ievadās, visi viņa dati.
            //Droši vien šim vajadzētu izveidot profila izveides iespējas, un tad sistēma automatiski saglaba konkrētā lietotāja datus..."

            //tāpat rakstam mainīgā - kas ir šis bloks, kur parādās saraksts - lai pievieno izveidoto sarakstu
            BuyItemListControl.ItemsSource = BuyItemsList;
            for (int i = 0; i < text.Length; i++)
            {
                //xxx ir jauns mainīgais, kurš ir atsevišķi no visa kopējā saraksta un var viņu ieklikšķināt
                var xxx = text[i];
            }


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
           
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedItems = this.BuyItemListControl.SelectedItems[0] as string;
            this.BuyItemsList.Remove(selectedItems);

           
        }
        private void Window_Closed(object sender, EventArgs e)
        {

        }

        
    }
}
