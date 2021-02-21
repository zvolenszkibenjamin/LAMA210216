using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210216
{
    public partial class LamaForm : Form
    {
        private static readonly List<Lama> Lamak = new List<Lama>();
        private const string LamaTxt = "..\\..\\..\\Res\\lama.txt";
        private static readonly Regex NumberRegex = new Regex("^\\d+$");
        private static readonly Regex EdesSosRegex = new Regex("^(édes)|(sós)$");

        public LamaForm()
        {
            InitializeComponent();

            var rnd = new Random();
            base.BackColor = Color.FromArgb( // Random szín beállítása
                rnd.Next(128, 256),
                rnd.Next(128, 256),
                rnd.Next(128, 256));

            ujLamaBtn.Enabled = false;

            LamakBetoltese();
        }

        private void LamakBetoltese()
        {
            // Az adatok betöltése a listába
            using (var reader = new StreamReader(LamaTxt, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    var dataParts = reader.ReadLine()?.Split(';'); // Sor beolvasása
                    if (dataParts != null)
                        Lamak.Add(new Lama(dataParts[0], // Név
                            Convert.ToUInt16(dataParts[1]), // Születési év
                            dataParts[2] == "édes" // Kedvenc íz
                                ? Lama.Izek.Edes
                                : Lama.Izek.Sos));
                }
            }

            // A lista betöltése a ComboBox-ba
            lamaSelector.Items.AddRange(Lamak.Select(lama => lama.Nev).ToArray<object>());
        }

        private void lamaSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLama = Lamak[lamaSelector.SelectedIndex]; // Kiválasztott láma megkeresése
            szulEvLabel.Text = selectedLama.SzulEv.ToString(); // Szül. év megjelenítése
            szulEvLabel.ForeColor = // Szül. év label színének beállítása kedvenc íz alapján
                selectedLama.KedvencIz == Lama.Izek.Edes ? Color.Fuchsia : Color.Aqua;
        }

        private void ujLamaBtn_canEnable(object sender, EventArgs e) => // A gomb bekapcsolása, ha mindegyik mezőben
            ujLamaBtn.Enabled = ujLamaNev.Text != "" && ujLamaSzulEv.Text != "" && ujLamaIz.Text != ""; // van szöveg

        private void ujLamaBtn_Click(object sender, EventArgs e)
        {
            if (Lamak.Select(lama => lama.Nev).Contains(ujLamaNev.Text)) // Van már ilyen nevű láma?
            {
                MessageBox.Show("Van már ilyen nevű láma!");
                return;
            }
            if (!NumberRegex.IsMatch(ujLamaSzulEv.Text)) // A beírt születési év szám?
            {
                MessageBox.Show("A beírt születési év nem szám!");
                return;
            }
            if (!EdesSosRegex.IsMatch(ujLamaIz.Text)) // A beírt íz édes vagy sós?
            {
                MessageBox.Show("Sajnos csak sós vagy édes ízeket kedvelő lámákkal tudunk dolgozni!");
                return;
            }

            var ujLama = new Lama( // Új láma létrehozása
                ujLamaNev.Text,
                Convert.ToUInt16(ujLamaSzulEv.Text),
                ujLamaIz.Text == "édes" ? Lama.Izek.Edes : Lama.Izek.Sos);

            // Mezők kiürítése
            ujLamaNev.Text = "";
            ujLamaSzulEv.Text = "";
            ujLamaIz.Text = "";

            Lamak.Add(ujLama); // Új láma hozzáadása a listához
            lamaSelector.Items.Add(ujLama.Nev); // Új láma hozzáadása a láma választó listához
            lamaSelector.SelectedIndex = lamaSelector.Items.Count - 1; // Új láma kiválasztása
            
            using (var writer = new StreamWriter(LamaTxt, true, Encoding.UTF8)) // Új láma fájlbaírása
                writer.WriteLine(
                    $"{ujLama.Nev};" +
                    $"{ujLama.SzulEv};" +
                    $"{(ujLama.KedvencIz == Lama.Izek.Edes ? "édes" : "sós")}");
        }
    }
}