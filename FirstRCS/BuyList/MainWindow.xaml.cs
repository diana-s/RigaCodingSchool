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
    using System.Windows.Input;
 

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
            //[] norāda, ka šis mainīgais ir masīvs - vesels saraksts, tapēc string [] = var ....
            
            string[] AllItemsFromFile = System.IO.File.ReadAllLines(@"C:\Users\Diana\CODES\RigaCodingSchool.test.txt");
            
            // pasakamkontrolē i laiizmanto mūsu sarakstu
            //šajā sarakstā norādam, lai automātiski parādās bumbieri (rakstot šajā.mainīgajā.Add();)
            this.BuyItemsList.Add("bumbieri");
            //tagad norādam, lai sarakstā parādās automātiski arī, tas, kas tika saglabāts iepriekš 
            //(ja saraksts tiek veidots pirmo reizi, tad tur noteikti parādīsies tukšums)
            //kas saglabājas failā. Iekavās rakstam mainīgo, kas šajā gadījumā ir "text"
            


            //KOMENTĀRS PRIEKŠ MANIS :)"hmmm būtu forši izveidot kodu, kad lietotajam uzsākot darbu, automātiskis izveidojas savs personigais
            //saraksta fails, kas saglabājas projekta mapē, un tur arī vienmēr ievadās, visi viņa dati.
            //Droši vien šim vajadzētu izveidot profila izveides iespējas, un tad sistēma automatiski saglaba konkrētā lietotāja datus..."

            //tāpat rakstam mainīgā - kas ir šis bloks, kur parādās saraksts - lai pievieno izveidoto sarakstu
            BuyItemListControl.ItemsSource = BuyItemsList;
            //ar foreach iet cauri masīva katram elementam, izveidojam jaunu mainīgo - itemFromFile, kas saglabā atmiņā
            //katru rindiņu
            foreach (var itemFromFile in AllItemsFromFile)
            {
                this.BuyItemsList.Add(itemFromFile);
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
            for (int i = 0; i < ReturnFromFile.Length; i++)
            {
                //xxx ir jauns mainīgais, kurš ir atsevišķi no visa kopējā saraksta un var viņu ieklikšķināt
                var xxx = ReturnFromFile[i];
                this.BuyItemsList.Add("");
            }

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedItems = this.BuyItemListControl.SelectedItems[0] as string;
            this.BuyItemsList.Remove(selectedItems);

           
        }
        //tur, kur veidojam aplikaciju, zem window sadaļas (pirms Grid), ievadam Closing = "MainWindowClosing",
        //kas nozīmē, kad aizverot visu logu, mēs izsaucam konkretu funkciju

        private void MainWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //funkcija, ko izsaucam, ir ta pati, ko izsaucam nospiežot "Saglabāt" - saglabajas automatiski 
            //ierakstītais saraksts failā
            File.WriteAllLines(@"C:\Users\Diana\CODES\RigaCodingSchool.test.txt", this.BuyItemsList);
        }

        private void EnterAddItem(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                this.BuyItemsList.Add(this.BuyListItemName.Text);

                //pēc funkcijas izpildes, testa ievades lauks paliek tukšs
                this.BuyListItemName.Text = "";
            }
        }
    }
}
