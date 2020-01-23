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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        //lists
        List<Band> FliterBands;
        List<Band> AllBands; 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            AllBands = new List<Band>();
            FliterBands = new List<Band>();
           

            //List<Band> = new rockband 
            RockBand rb1 = new RockBand() { BandName = "Led Zeppelin", YearFormed = "1968", Members = "Robert Plant, John Bonham, Jimmy Page, John Paul Jones" };
            RockBand rb2 = new RockBand() { BandName = "The Rolling Stones", YearFormed = "1962", Members = "Mick Jagger, Brian Jones, Keith Richards" };


            IndieBand I1 = new IndieBand() { BandName = "Arctic Monkeys", YearFormed = "2002", Members = "Alex Turne,Matt Helders,Jamie Cook," };
            IndieBand I2 = new IndieBand() { BandName = "The Strokes", YearFormed = "1998", Members = "Julian Casablancas,Albert Hammond,Nick Valensi,Fabrizio Moretti"};

            PopBand P1 = new PopBand() { BandName = "Jonas Brothers", YearFormed = "2005", Members = "Nick Jonas, Joe Jonas, Kevin Jonas" };
            PopBand P2 = new PopBand() { BandName = "Imagine Dragons", YearFormed = "2008", Members = "Dan Reynolds, Andrew Tolman,Aurora Florence" };


            AllBands.Add(rb1);
            AllBands.Add(rb2);
            AllBands.Add(I1);
            AllBands.Add(I2);
            AllBands.Add(P1);
            AllBands.Add(P2);

            AllBands.Sort();
            lbxBands.ItemsSource = AllBands;


            //combo box info
            cbxgenre.ItemsSource = new string [] { "Rock", "Pop", "Indie" };
            cbxgenre.SelectedIndex = 0;



            //Album Info 
            Album AR1 = new Album() { AlbumName = "Led Zeppelin IV", AlbumYear = 1969, AlbumMembers = "All Members" };
            Album AR2 = new Album() { AlbumName = "Some Girls", AlbumYear = 1978, AlbumMembers = "all" };
            Album AI1 = new Album() { AlbumName = "Whatever people say I am thats what I am not", AlbumYear = 2006, AlbumMembers = "all" };
          

        }


  

        private void lbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedband = lbxBands.SelectedItem as Band;

            txtblkmembers.Text = "Members" + selectedband.Members;
          txtblkformed.Text = "Formed" + selectedband.YearFormed; 
          
           
          

        }

        private void Cbxgenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBox selectedB = sender as ComboBox;
            string flitering = selectedB.Text as string; 



        }

        private void Fliter(string flitering)
        {


            Band[] fliteredbands = new Band[2];
            int counter = 0; 
            switch(flitering)
            {
                case "Rock":
                    foreach(Band Cband in AllBands)
                    {
                        if(Cband.GetType().Name == "RockBand")
                        {
                            fliteredbands[counter] = Cband;
                            counter++; 
                        }
                    }
                    lbxBands.ItemsSource = fliteredbands;
                    break;

                case "Pop":
                    foreach(Band Cband in AllBands)
                    {
                        if(Cband.GetType().Name == "PopBand")
                        {
                            fliteredbands[counter] = Cband;
                            counter++; 
                        }
                    }
                    lbxBands.ItemsSource = fliteredbands;
                    break;

                case "Indie":
                    foreach(Band Cband in AllBands)
                    {
                        if(Cband.GetType().Name == "IndeBand")
                        {
                            fliteredbands[counter] = Cband;
                            counter++; 
                        }
                    }
                    lbxBands.ItemsSource = fliteredbands;
                    break; 

                    
            }
           
        
        }

            
            
        

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selection = lbxBands.SelectedItem as Band; 
            if(selection != null)
            {
               
            }
        }

       
    }
}
