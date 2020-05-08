using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using Ookii.Dialogs.Wpf;

namespace alba
{
    public partial class Form1 : Form
    {
        /*
        
        * dodělat parametry
        * ukládání
        * načítání
        * práce s programem a parametry
        
        */

        public Form1()
        {
            InitializeComponent();
        }
        // ///////////////////////////////
        // //        ok - start         //
        // ///////////////////////////////

        // PROMĚNNÉ //

        // index archivu k zobrazení / úpravě
        int indexArchivu;
        string slozkaProgramuCache;
        string slozkaProgramuData;

        // OBECNÉ - PRO VÍCE PANELŮ //

        private void ZkontrolujSoubor(string cesta, string pripona, Label labelStav)
        {
            // zkontroluje existenci souboru a jeho přípony -> jedna přípona
            // a zobrazí výsledek na label se stavem
            if (!File.Exists(cesta))
            {
                labelStav.Text = "Soubor neexistuje!";
            }
            else if (Path.GetExtension(cesta).ToLower() != pripona.ToLower())
            {
                labelStav.Text = "Nejedná se o soubor " + pripona + "!";
            }
            else
            {
                labelStav.Text = "";
            }
        }
        private void ZkontrolujSoubor(string cesta, string[] pripony, Label labelStav)
        {
            // zkontroluje existenci souboru a jeho přípony -> více přípon
            // a zobrazí výsledek na label se stavem
            if (!File.Exists(cesta))
            {
                labelStav.Text = "Soubor neexistuje!";
            }
            else
            {
                foreach (string pripona in pripony)
                {
                    // zkontroluje všechny přílohy
                    if (Path.GetExtension(cesta).ToLower() == pripona.ToLower())
                    {
                        labelStav.Text = "";
                        return;
                    }
                }
                labelStav.Text = "Nejedná se o soubor " + String.Join(", ", pripony) + "!";
            }
        }
        private void ZkontrolujSlozku(string cesta, bool zanrStat, Label labelStav)
        {
            labelStav.Text = "";
            // zkontroluje zda-li složka existuje
            // a zobrazí výsledek na label se stavem
            if (!Directory.Exists(cesta))
            {
                if (zanrStat)
                {
                    // jedná se o složky žánru a státu
                    // zobrazím jiný stav
                    labelStav.Text = "Složky žánru a státu neexistují!";
                }
                else
                {
                    labelStav.Text = "Složka neexistuje!";
                }
            }
            else
            {
                labelStav.Text = "";
            }
        }
        private bool ZkontrolujPredSpoustenim(string labelStavText, bool program)
        {
            // kontroluje cestu před spuštěním programu podle labelu se stavem
            // vrací true pokud je vše v pořádku
            // dostává hodnotu true pokud se jedná o program (false pro složku) a podle toho zobrazuje zprávu
            if (String.IsNullOrEmpty(labelStavText))
            {
                return true;
            }
            else
            {
                if (program)
                {
                    // program
                    ZobrazChybu("Změňte cestu k spustitelnému souboru v nastavení!", "Spouštění programu");
                }
                else
                {
                    // složka
                    ZobrazChybu("Změňte cestu k archivu!", "Spouštění programu");
                }
                return false;
            }
        }

        private void VyberSoubor(string filtr, ComboBox comboBoxSoubor)
        {
            // výběr souboru uživatelem
            comboBoxSoubor.Items.Remove("");
            using (var vyberSouboru = new OpenFileDialog())
            {
                vyberSouboru.Filter = filtr;
                DialogResult odpoved = vyberSouboru.ShowDialog();
                if (odpoved == DialogResult.OK && !string.IsNullOrWhiteSpace(vyberSouboru.FileName))
                {
                    PridejCestu(vyberSouboru.FileName, comboBoxSoubor, true);
                }
            }
        }
        private void PridejCestu(string cesta, ComboBox comboBoxPridani, bool soubor)
        {
            // přidá cestu do comboboxu

            if (soubor && !File.Exists(cesta))
            {
                // soubor neexistuje
                return;
            }
            if (!soubor && !Directory.Exists(cesta))
            {
                // složka neexistuje
                return;
            }
            if (!comboBoxPridani.Items.Contains(cesta))
            {
                // přidání cesty do comboboxu
                comboBoxPridani.Items.Add(cesta);
            }
            // vybrání cesty z comboboxu
            comboBoxPridani.SelectedIndex = comboBoxPridani.FindStringExact(cesta);
        }
        private void VyberSlozky(ComboBox comboBoxSlozka)
        {
            // slouží k výběru složky pomocí FolderBrowserDialogu
            // a následnému uložení do comboboxu
            comboBoxSlozka.Items.Remove("");
            VistaFolderBrowserDialog vyberSlozku = new VistaFolderBrowserDialog();
            if (Directory.Exists(comboBoxSlozka.Text))
            {
                vyberSlozku.SelectedPath = comboBoxSlozka.Text;
            }
            bool slozkaVybrana = (bool)vyberSlozku.ShowDialog();
            if (slozkaVybrana && !string.IsNullOrWhiteSpace(vyberSlozku.SelectedPath))
            {
                PridejCestu(vyberSlozku.SelectedPath, comboBoxSlozka, false);
            }
        }
        private void comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            // odstranění cest z comboBoxu
            // -> pokud uživatel zmáčkne "delete"

            ComboBox comboBoxVybrany = sender as ComboBox;

            if (e.KeyCode == Keys.Delete)
            {
                // uživatel zmáčkne "delete"
                int index = comboBoxVybrany.SelectedIndex;
                if (index < 0)
                {
                    // neexistuje žádná položka comboBoxu
                    return;
                }
                if (comboBoxVybrany.Items.Count == 1)
                {
                    // existuje 1 položka comboBoxu
                    comboBoxVybrany.Items[index] = string.Empty;
                    return;
                }
                if (index >= 0)
                {
                    // existuje více než 1 položka comboBoxu
                    comboBoxVybrany.SelectedIndex = index - 1;
                    comboBoxVybrany.Items.RemoveAt(index);
                }
            }
        }
        private void ZkontrolujSlozkuOpus()
        {
            // kontrola hudebních složek včetně státu a žánrů + zda-li již album není v uživatelovo knihovně

            // vyčistím stav u labelu přidání / úpravy archivu a v nastavení
            labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Text = "";
            labelNastaveni_SlozkaOpusStav.Text = "";
            toolTipInfo.SetToolTip(labelNastaveni_SlozkaOpusOtevrit, null);

            // zkontroluji existenci složky 
            ZkontrolujSlozku(comboBoxNastaveni_SlozkaOpus.Text, false, labelNastaveni_SlozkaOpusStav);

            if (String.IsNullOrEmpty(labelNastaveni_SlozkaOpusStav.Text))
            {
                // složka existuje
                // -> zkontoluji zda-li existují v dané složce podsložky žánru
                ZkontrolujSlozku(Path.Combine(comboBoxNastaveni_SlozkaOpus.Text, comboBoxPridaniUpravaArchivu_SlozkaZanr.Text), true, labelNastaveni_SlozkaOpusStav);
            }

            if (!String.IsNullOrEmpty(labelNastaveni_SlozkaOpusStav.Text))
            {
                // složka neexistuje nebo v ní neexistují podsložky žánru
                // -> zobrazím zprávu
                labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Text = "Změňte cestu složky opus v nastavení.";
                labelPridaniUpravaArchivu_SlozkaOpusCesta.Text = "";
                return;
            }
            // složka existuje
            toolTipInfo.SetToolTip(labelNastaveni_SlozkaOpusOtevrit, "Otevřít složku");

            if (String.IsNullOrEmpty(textBoxPridaniUpravaArchivu_Interpret.Text))
            {
                // interpret není vyplněn
                labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Text = "Není vyplněn interpret";
                labelPridaniUpravaArchivu_SlozkaOpusCesta.Text = "";
                return;
            }
            if (String.IsNullOrEmpty(textBoxPridaniUpravaArchivu_Album.Text))
            {
                // album není vyplněno
                labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Text = "Není vyplněno album";
                labelPridaniUpravaArchivu_SlozkaOpusCesta.Text = "";
                return;
            }
            // (rok je vyplněn vždy)

            // získám složku interpreta a alba do které má bý archiv přesunut
            string slozka = Path.Combine(comboBoxNastaveni_SlozkaOpus.Text, comboBoxPridaniUpravaArchivu_SlozkaZanr.Text,
                                            textBoxPridaniUpravaArchivu_Interpret.Text, numericUpDownPridaniUpravaArchivu_Rok.Value + " " + textBoxPridaniUpravaArchivu_Album.Text);
            labelPridaniUpravaArchivu_SlozkaOpusCesta.Text = slozka;

            if (Directory.Exists(slozka))
            {
                // složka již existuje
                // -> album již uživatel má stažené

                labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Text = "Toto album již ve hudební složce opus existuje!";
                toolTipInfo.SetToolTip(labelPridaniUpravaArchivu_SlozkaOpusCestaStav, "Otevřít složku");
            }
            else
            {
                // složka neexistuje
                // -> vše je v pořádku
                labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Text = "";
                toolTipInfo.SetToolTip(labelPridaniUpravaArchivu_SlozkaOpusCestaStav, null);
            }
        }

        private void ZkontrolujSlozkuMp3()
        {
            // kontrola hudebních složek včetně státu a žánrů + zda-li již album není v uživatelovo knihovně

            // vyčistím stav u labelu přidání / úpravy archivu a v nastavení
            labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Text = "";
            labelNastaveni_SlozkaMp3Stav.Text = "";

            // zkontroluji existenci složky 
            ZkontrolujSlozku(comboBoxNastaveni_SlozkaMp3.Text, false, labelNastaveni_SlozkaMp3Stav);

            if (String.IsNullOrEmpty(labelNastaveni_SlozkaMp3Stav.Text))
            {
                // složka existuje
                // -> zkontoluji zda-li existují v dané složce podsložky žánru
                ZkontrolujSlozku(Path.Combine(comboBoxNastaveni_SlozkaMp3.Text, comboBoxPridaniUpravaArchivu_SlozkaZanr.Text), true, labelNastaveni_SlozkaMp3Stav);
            }

            if (!String.IsNullOrEmpty(labelNastaveni_SlozkaMp3Stav.Text))
            {
                // složka neexistuje nebo v ní neexistují podsložky žánru
                // -> zobrazím zprávu
                labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Text = "Změňte cestu složky mp3 v nastavení.";
                labelPridaniUpravaArchivu_SlozkaMp3Cesta.Text = "";
                return;
            }
            // složka existuje
            toolTipInfo.SetToolTip(labelNastaveni_SlozkaMp3Otevrit, "Otevřít složku");

            if (String.IsNullOrEmpty(textBoxPridaniUpravaArchivu_Interpret.Text))
            {
                // interpret není vyplněn
                labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Text = "Není vyplněn interpret";
                labelPridaniUpravaArchivu_SlozkaMp3Cesta.Text = "";
                return;
            }
            if (String.IsNullOrEmpty(textBoxPridaniUpravaArchivu_Album.Text))
            {
                // album není vyplněno
                labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Text = "Není vyplněno album";
                labelPridaniUpravaArchivu_SlozkaMp3Cesta.Text = "";
                return;
            }
            // (rok je vyplněn vždy)

            // získám složku interpreta a alba do které má bý archiv přesunut
            string slozka = Path.Combine(comboBoxNastaveni_SlozkaMp3.Text, comboBoxPridaniUpravaArchivu_SlozkaZanr.Text, 
                                            textBoxPridaniUpravaArchivu_Interpret.Text, numericUpDownPridaniUpravaArchivu_Rok.Value + " " + textBoxPridaniUpravaArchivu_Album.Text);
            labelPridaniUpravaArchivu_SlozkaMp3Cesta.Text = slozka;

            if (Directory.Exists(slozka))
            {
                // složka již existuje
                // -> album již uživatel má stažené

                labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Text = "Toto album již ve hudební složce mp3 existuje!";
                toolTipInfo.SetToolTip(labelPridaniUpravaArchivu_SlozkaMp3CestaStav, "Otevřít složku");
            }
            else
            {
                // složka neexistuje
                // -> vše je v pořádku
                labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Text = "";
                toolTipInfo.SetToolTip(labelPridaniUpravaArchivu_SlozkaMp3CestaStav, null);
            }
        }
        private bool PresunSoubor(string puvodniSoubor, string novySoubor)
        {
            // přesune soubor
            //ZobrazStavPrubezny("přesunuji soubor " + Path.GetFileName(puvodniSoubor));
            try
            {
                if (File.Exists(novySoubor))
                {
                    File.Delete(novySoubor);
                }
                File.Move(puvodniSoubor, novySoubor);
            }
            catch (Exception ex)
            {
                //ZobrazStavPosledni("soubor se nepodařilo přesunout", false);
                ZobrazChybu(ex.Message, "Přesunování souboru");
                return false;
            }
            //ZobrazStavPosledni("soubor byl úspěšně přesunut", true);
            return true;
        }
        private void UlozSoubor(string cesta, string obsah)
        {
            // uloží do souboru obsah
            ZobrazStavPrubezny("ukládám soubor " + Path.GetFileName(cesta));
            try
            {
                if (File.Exists(cesta))
                {
                    File.Delete(cesta);
                }
            }
            catch (Exception ex)
            {
                ZobrazStavPosledni("soubor se nepodařilo uložit", false);
                ZobrazChybu(ex.Message, "Ukládání souboru");
            }
            using (var streamUloz = new FileStream(cesta, FileMode.Append))
            {
                using (var uloz = new StreamWriter(streamUloz, Encoding.Default))
                {
                    uloz.Write(obsah);
                }
            }
        }
        private void SpustitProgram(string cesta, string parametry, bool pockej)
        {
            // spustí program
            ZobrazStavPrubezny("spouštím " + cesta);
            if (File.Exists(cesta) || Directory.Exists(cesta))
            {
                try
                {
                    ProcessStartInfo info = new ProcessStartInfo(cesta, parametry);
                    Process spust = new Process();
                    spust.StartInfo = info;
                    spust.StartInfo.CreateNoWindow = false;
                    spust.Start();

                    if (pockej)
                    {
                        spust.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    ZobrazStavPosledni("program se nepodařilo spustit", false);
                    ZobrazChybu(ex.Message, "Spouštění programu");
                    return;
                }
            }
            else
            {
                ZobrazStavPosledni("program se nepodařilo spustit", false);
                ZobrazChybu("Neexistující soubor (" + cesta + ") nelze spustit!", "Spouštění programu");
                return;
            }
            ZobrazStavPosledni("program byl úspěšně ukončen", true);
        }

        // START PROGRAMU //

        private void Form1_Load(object sender, EventArgs e)
        {
            // zatím nedodělané funkce
            checkBoxPridaniUpravaArchivu_PrepsatSoubory.Visible = false;

            buttonZobrazeniArchivu_SpustitVse.Visible = false;
            buttonZobrazeniArchivu_PrevestNaOpusMp3.Visible = false;

            textBoxNastaveni_RozbaleniParametry.Visible = false;
            textBoxNastaveni_AlbumArtParametry.Visible = false;
            textBoxNastaveni_OpusEnkoderParametry.Visible = false;
            textBoxNastaveni_Mp3EnkoderParametry.Visible = false;
            label24.Visible = false;
            label6.Visible = false;
            label19.Visible = false;
            label22.Visible = false;

            // nastavím index upravovaného archivu
            indexArchivu = 0;

            // kontrola složek a smazání všech souborů ve složce cache
            // appdata/archive2music/cache/idProcesu/
            slozkaProgramuCache = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "archive2music", "cache", Process.GetCurrentProcess().Id.ToString());
            if (Directory.Exists(slozkaProgramuCache))
            {
                try
                {
                    Directory.Delete(slozkaProgramuCache, true);
                }
                catch (Exception ex)
                {
                    ZobrazChybu(ex.Message, "Spuštění programu");
                   // return;
                }
            }
            try
            {
                Directory.CreateDirectory(slozkaProgramuCache);
            }
            catch (Exception ex)
            {
                ZobrazChybu(ex.Message, "Spuštění programu");
               // return;
            }
            // pokud neexistuje složka data, vytvořím ji
            slozkaProgramuData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "archive2music", "data");
            try
            {
                Directory.CreateDirectory(slozkaProgramuData);
            }
            catch (Exception ex)
            {
                ZobrazChybu(ex.Message, "Spuštění programu");
               // return;
            }

            // nastavení prvků formuláře
            // -> přidání složky
            labelPridaniSlozky_Stav.Text = "Složka neexistuje!";
            buttonPridaniSlozky_PridatArchivy.Enabled = false;

            // -> nastavení
            labelNastaveni_SlozkaOpusStav.Text = "Složka neexistuje!";
            labelNastaveni_SlozkaMp3Stav.Text = "Složka neexistuje!";

            labelNastaveni_RozbaleniStav.Text = "Soubor neexistuje!";
            labelNastaveni_Mp3TagStav.Text = "Soubor neexistuje!";
            labelNastaveni_AlbumArtStav.Text = "Soubor neexistuje!";
            labelNastaveni_OpusEnkoderStav.Text = "Soubor neexistuje!";
            labelNastaveni_Mp3EnkoderStav.Text = "Soubor neexistuje!";
            labelNastaveni_DeezerStav.Text = "Soubor neexistuje!";

            // -> rozbalení
            labelPridaniUpravaArchivu_ArchivStav.Text = "Soubor neexistuje!";
            comboBoxPridaniUpravaArchivu_SlozkaZanr.SelectedIndex = 0;
            numericUpDownPridaniUpravaArchivu_Rok.Maximum = DateTime.Now.Year;
            if (DateTime.Now.Year >= numericUpDownPridaniUpravaArchivu_Rok.Minimum && DateTime.Now.Year <= numericUpDownPridaniUpravaArchivu_Rok.Maximum)
            {
                numericUpDownPridaniUpravaArchivu_Rok.Value = DateTime.Now.Year;
            }
            buttonPridaniUpravaArchivu_CoverSmazat.Enabled = false;
            labelPridaniUpravaArchivu_CoverInfo.Text = "";

            // přepne menu
            MenuPrepni(buttonMenuPridaniSlozky, panelPridaniSlozky);

            // načtení minulého stavu a kontrola
            // -> přidání složky
            NactiSoubor(Path.Combine(slozkaProgramuData, "h_slozky.txt"), comboBoxPridaniSlozky_Slozka);
            ZkontrolujSlozku(comboBoxPridaniSlozky_Slozka.Text, false, labelPridaniSlozky_Stav);


            // -> zobrazení archivů
            // skrytý label ke kontrole jednotlivých archivů ze seznamu listView
            labelZobrazeniArchivu_Kontrola.Text = "Soubor neexistuje!";
            labelZobrazeniArchivu_Kontrola.Visible = false;

            buttonPridaniUpravaArchivu_PridatPredchozi.Enabled = false;
            buttonMenuUpravaArchivu.Enabled = false;
            buttonZobrazeniArchivu_Odstranit.Enabled = false;
            buttonZobrazeniArchivu_VyberZrusit.Enabled = false;
            buttonZobrazeniArchivu_VyberVse.Enabled = false;
            checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.Enabled = false;
            buttonZobrazeniArchivu_Rozbalit.Enabled = false;
            buttonZobrazeniArchivu_PrevestNaOpus.Enabled = false;
            buttonZobrazeniArchivu_PrevestNaOpusMp3.Enabled = false;
            buttonZobrazeniArchivu_PresunDoKnihoven.Enabled = false;
            buttonZobrazeniArchivu_Mp3TagRozbalene.Enabled = false;
            buttonZobrazeniArchivu_Mp3TagOpus.Enabled = false;
            buttonZobrazeniArchivu_Mp3TagMp3.Enabled = false;
            buttonZobrazeniArchivu_Mp3TagVse.Enabled = false;
            buttonZobrazeniArchivu_PrevestNaMp3.Enabled = false;


            // -> nastavení
            NactiSoubor(Path.Combine(slozkaProgramuData, "h_opus.txt"), comboBoxNastaveni_SlozkaOpus);
            ZkontrolujSlozkuOpus();

            NactiSoubor(Path.Combine(slozkaProgramuData, "h_mp3.txt"), comboBoxNastaveni_SlozkaMp3);
            ZkontrolujSlozkuMp3();

            NactiSoubor(Path.Combine(slozkaProgramuData, "n_zip.txt"), comboBoxNastaveni_Rozbaleni);
            ZkontrolujSoubor(comboBoxNastaveni_Rozbaleni.Text, ".exe", labelNastaveni_RozbaleniStav);

            NactiSoubor(Path.Combine(slozkaProgramuData, "n_mp3tag.txt"), comboBoxNastaveni_Mp3Tag);
            ZkontrolujSoubor(comboBoxNastaveni_Mp3Tag.Text, ".exe", labelNastaveni_Mp3TagStav);

            NactiSoubor(Path.Combine(slozkaProgramuData, "n_albumart.txt"), comboBoxNastaveni_AlbumArt);
            ZkontrolujSoubor(comboBoxNastaveni_AlbumArt.Text, ".exe", labelNastaveni_AlbumArtStav);

            NactiSoubor(Path.Combine(slozkaProgramuData, "n_opusenkoder.txt"), comboBoxNastaveni_OpusEnkoder);
            ZkontrolujSoubor(comboBoxNastaveni_OpusEnkoder.Text, ".exe", labelNastaveni_OpusEnkoderStav);

            NactiSoubor(Path.Combine(slozkaProgramuData, "n_mp3enkoder.txt"), comboBoxNastaveni_Mp3Enkoder);
            ZkontrolujSoubor(comboBoxNastaveni_Mp3Enkoder.Text, ".exe", labelNastaveni_Mp3EnkoderStav);

            NactiSoubor(Path.Combine(slozkaProgramuData, "n_deezer.txt"), comboBoxNastaveni_Deezer);
            ZkontrolujSoubor(comboBoxNastaveni_Deezer.Text, ".exe", labelNastaveni_DeezerStav);

            // -> rozbalení
            NactiSoubor(Path.Combine(slozkaProgramuData, "h_archiv.txt"), comboBoxPridaniUpravaArchivu_Archiv);
            ZkontrolujSoubor(comboBoxPridaniUpravaArchivu_Archiv.Text, new string[] { ".zip", ".rar", ".tar", ".7z" }, labelPridaniUpravaArchivu_ArchivStav);
        }

        private void NactiSoubor(string cesta, ComboBox comboBoxPridani)
        {
            // načtení dat ze souboru do comboboxu
            if (!File.Exists(cesta))
            {
                return;
            }
            using (FileStream streamNacti = new FileStream(cesta, FileMode.Open))
            {
                using (StreamReader nacti = new StreamReader(streamNacti, Encoding.Default))
                {
                    while (!nacti.EndOfStream)
                    {
                        comboBoxPridani.Items.Add(nacti.ReadLine());
                    }
                }
            }
            if (comboBoxPridani.Items.Count > 0)
            {
                comboBoxPridani.SelectedIndex = comboBoxPridani.Items.Count - 1;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ukončení programu

            // uložení nastavení:
            // -> přidání složky
            UlozSoubor(Path.Combine(slozkaProgramuData, "h_slozky.txt"), comboBoxPridaniSlozky_Slozka);

            // -> rozbalení
            UlozSoubor(Path.Combine(slozkaProgramuData, "h_archiv.txt"), comboBoxPridaniUpravaArchivu_Archiv);

            // -> nastavení
            UlozSoubor(Path.Combine(slozkaProgramuData, "h_opus.txt"), comboBoxNastaveni_SlozkaOpus);
            UlozSoubor(Path.Combine(slozkaProgramuData, "h_mp3.txt"), comboBoxNastaveni_SlozkaMp3);

            UlozSoubor(Path.Combine(slozkaProgramuData, "n_zip.txt"), comboBoxNastaveni_Rozbaleni);
            UlozSoubor(Path.Combine(slozkaProgramuData, "n_mp3tag.txt"), comboBoxNastaveni_Mp3Tag);
            UlozSoubor(Path.Combine(slozkaProgramuData, "n_albumart.txt"), comboBoxNastaveni_AlbumArt);
            UlozSoubor(Path.Combine(slozkaProgramuData, "n_opusenkoder.txt"), comboBoxNastaveni_OpusEnkoder);
            UlozSoubor(Path.Combine(slozkaProgramuData, "n_mp3enkoder.txt"), comboBoxNastaveni_Mp3Enkoder);
            UlozSoubor(Path.Combine(slozkaProgramuData, "n_deezer.txt"), comboBoxNastaveni_Deezer);

            // odstranění cache složky
            while (Directory.Exists(slozkaProgramuCache))
            {
                try
                {
                    Directory.Delete(slozkaProgramuCache, true);
                }
                catch (Exception ex)
                {
                    // pokud zruší, ukončí se program, pokud ne dojde k opakování
                    if (DialogResult.Cancel == MessageBox.Show(ex.Message, "Chyba - " + "Ukončení programu", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error))
                    {
                        return;
                    }
                }
            }
        }

        private void UlozSoubor(string cesta, ComboBox comboBoxUlozeni)
        {
            // uložení souboru z comboboxu
            // -> smaže již existující soubor a nahradí ho novým
            if (File.Exists(cesta))
            {
                try
                {
                    File.Delete(cesta);
                }
                catch (Exception ex)
                {
                    ZobrazChybu(ex.Message, "Ukončení programu");
                    return;
                }
            }
            using (FileStream streamUloz = new FileStream(cesta, FileMode.Append))
            {
                using (StreamWriter uloz = new StreamWriter(streamUloz, Encoding.Default))
                {
                    foreach (string cestaUloz in comboBoxUlozeni.Items)
                    {
                        if (!String.IsNullOrEmpty(cestaUloz))
                        {
                            uloz.WriteLine(cestaUloz);
                        }
                    }
                }
            }
        }

        // NASTAVENÍ //

        // kontrola hudebních složek nebo spustileného souboru
        // přidání cesty do comboboxu
        private void labelNastaveni_SlozkaOpusOtevrit_Click(object sender, EventArgs e)
        {
            // otevře složku opus
            SpustitProgram(comboBoxNastaveni_SlozkaOpus.Text, "", false);
        }
        private void comboBoxNastaveni_SlozkaOpus_Leave(object sender, EventArgs e)
        {
            ZkontrolujSlozkuOpus();
            PridejCestu(comboBoxNastaveni_SlozkaOpus.Text, comboBoxNastaveni_SlozkaOpus, false);
        }
        private void buttonNastaveni_SlozkaOpusVybrat_Click(object sender, EventArgs e)
        {
            VyberSlozky(comboBoxNastaveni_SlozkaOpus);
            ZkontrolujSlozkuOpus();
            PridejCestu(comboBoxNastaveni_SlozkaOpus.Text, comboBoxNastaveni_SlozkaOpus, false);
        }

        private void labelNastaveni_SlozkaMp3Otevrit_Click(object sender, EventArgs e)
        {
            // otevře složku mp3
            SpustitProgram(comboBoxNastaveni_SlozkaMp3.Text, "", false);
        }
        private void comboBoxNastaveni_SlozkaMp3_Leave(object sender, EventArgs e)
        {
            ZkontrolujSlozkuMp3();
            PridejCestu(comboBoxNastaveni_SlozkaMp3.Text, comboBoxNastaveni_SlozkaMp3, false);
        }
        private void buttonNastaveni_SlozkaMp3Vybrat_Click(object sender, EventArgs e)
        {
            VyberSlozky(comboBoxNastaveni_SlozkaMp3);
            ZkontrolujSlozkuMp3();
            PridejCestu(comboBoxNastaveni_SlozkaMp3.Text, comboBoxNastaveni_SlozkaMp3, false);
        }

        private void comboBoxNastaveni_Rozbaleni_Leave(object sender, EventArgs e)
        {
            ZkontrolujSoubor(comboBoxNastaveni_Rozbaleni.Text, ".exe", labelNastaveni_RozbaleniStav);
            PridejCestu(comboBoxNastaveni_Rozbaleni.Text, comboBoxNastaveni_Rozbaleni, true);
        }
        private void buttonNastaveni_RozbaleniVybrat_Click(object sender, EventArgs e)
        {
            VyberSoubor("Rozbalení | *.exe", comboBoxNastaveni_Rozbaleni);
            ZkontrolujSoubor(comboBoxNastaveni_Rozbaleni.Text, ".exe", labelNastaveni_RozbaleniStav);
        }
        private void textBoxNastaveni_RozbaleniParametry_Leave(object sender, EventArgs e)
        {

        }

        private void comboBoxNastaveni_Mp3Tag_Leave(object sender, EventArgs e)
        {
            ZkontrolujSoubor(comboBoxNastaveni_Mp3Tag.Text, ".exe", labelNastaveni_Mp3TagStav);
            PridejCestu(comboBoxNastaveni_Mp3Tag.Text, comboBoxNastaveni_Mp3Tag, true);
        }
        private void buttonNastaveni_Mp3TagVybrat_Click(object sender, EventArgs e)
        {
            VyberSoubor("Mp3Tag | *.exe", comboBoxNastaveni_Mp3Tag);
            ZkontrolujSoubor(comboBoxNastaveni_Mp3Tag.Text, ".exe", labelNastaveni_Mp3TagStav);
        }

        private void comboBoxNastaveni_AlbumArt_Leave(object sender, EventArgs e)
        {
            ZkontrolujSoubor(comboBoxNastaveni_AlbumArt.Text, ".exe", labelNastaveni_AlbumArtStav);
            PridejCestu(comboBoxNastaveni_AlbumArt.Text, comboBoxNastaveni_AlbumArt, true);
        }
        private void buttonNastaveni_AlbumArtVybrat_Click(object sender, EventArgs e)
        {
            VyberSoubor("Album Art Downloader | *.exe", comboBoxNastaveni_AlbumArt);
            ZkontrolujSoubor(comboBoxNastaveni_AlbumArt.Text, ".exe", labelNastaveni_AlbumArtStav);
        }
        private void textBoxNastaveni_AlbumArtParametry_Leave(object sender, EventArgs e)
        {

        }

        private void comboBoxNastaveni_OpusEnkoder_Leave(object sender, EventArgs e)
        {
            ZkontrolujSoubor(comboBoxNastaveni_OpusEnkoder.Text, ".exe", labelNastaveni_OpusEnkoderStav);
            PridejCestu(comboBoxNastaveni_OpusEnkoder.Text, comboBoxNastaveni_OpusEnkoder, true);
        }
        private void buttonNastaveni_OpusEnkoderVybrat_Click(object sender, EventArgs e)
        {
            VyberSoubor("Opus Encoder | *.exe", comboBoxNastaveni_OpusEnkoder);
            ZkontrolujSoubor(comboBoxNastaveni_OpusEnkoder.Text, ".exe", labelNastaveni_OpusEnkoderStav);
        }
        private void textBoxNastaveni_OpusEnkoderParametry_Leave(object sender, EventArgs e)
        {

        }

        private void comboBoxNastaveni_Mp3Enkoder_Leave(object sender, EventArgs e)
        {
            ZkontrolujSoubor(comboBoxNastaveni_Mp3Enkoder.Text, ".exe", labelNastaveni_Mp3EnkoderStav);
            PridejCestu(comboBoxNastaveni_Mp3Enkoder.Text, comboBoxNastaveni_Mp3Enkoder, true);
        }
        private void buttonNastaveni_Mp3EnkoderVybrat_Click(object sender, EventArgs e)
        {
            VyberSoubor("Mp3 Encoder | *.exe", comboBoxNastaveni_Mp3Enkoder);
            ZkontrolujSoubor(comboBoxNastaveni_Mp3Enkoder.Text, ".exe", labelNastaveni_Mp3EnkoderStav);
        }
        private void textBoxNastaveni_Mp3EnkoderParametry_Leave(object sender, EventArgs e)
        {

        }

        private void comboBoxNastaveni_Deezer_Leave(object sender, EventArgs e)
        {
            ZkontrolujSoubor(comboBoxNastaveni_Deezer.Text, ".exe", labelNastaveni_DeezerStav);
            PridejCestu(comboBoxNastaveni_Deezer.Text, comboBoxNastaveni_Deezer, true);
        }
        private void buttonNastaveni_DeezerVybrat_Click(object sender, EventArgs e)
        {
            VyberSoubor("Deezer search | *.exe", comboBoxNastaveni_Deezer);
            ZkontrolujSoubor(comboBoxNastaveni_Deezer.Text, ".exe", labelNastaveni_DeezerStav);
        }

        // PŘIDÁNÍ / ÚPRAVA ARCHIVU //

        private void comboBoxPridaniUpravaArchivu_Archiv_Leave(object sender, EventArgs e)
        {
            // změna cest archivu a složek
            /// DODĚLAT -> přidat další typy souborů ///
            ZkontrolujSoubor(comboBoxPridaniUpravaArchivu_Archiv.Text, new string[] { ".zip", ".rar", ".tar", ".7z" }, labelPridaniUpravaArchivu_ArchivStav);
            if (String.IsNullOrEmpty(labelPridaniUpravaArchivu_ArchivStav.Text))
            {
                buttonPridaniUpravaArchivu_PridatPredchozi.Enabled = true;
            }
            else
            {
                buttonPridaniUpravaArchivu_PridatPredchozi.Enabled = false;
            }
            /// DODĚLAT -> zde se pouze změní cesta
            ///         -> pokud uživatel vybere archiv, který je už v seznamu, zeptám se ho inhned, zdali chce načíst tento archiv a upravit ho
        }
        private void buttonPridaniUpravaArchivu_ArchivVybrat_Click(object sender, EventArgs e)
        {
            // výběr archivu + složek s hudbou
            /// DODĚLAT -> přidat další typy souborů ///
            VyberSoubor("Archiv (.zip, .rar, .tar, .7z | *.zip; *.rar; *.tar; *.7z", comboBoxPridaniUpravaArchivu_Archiv);
            comboBoxPridaniUpravaArchivu_Archiv_Leave(null, null);
        }
        private void checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit_CheckedChanged(object sender, EventArgs e)
        {
            // zobrazení / skrytí hesla
            if (checkBoxPridaniUpravaArchivu_ArchivHesloZobrazit.Checked)
            {
                textBoxPridaniUpravaArchivu_ArchivHeslo.PasswordChar = '\0';
            }
            else
            {
                textBoxPridaniUpravaArchivu_ArchivHeslo.PasswordChar = '*';
            }
        }
        private void comboBoxPridaniUpravaArchivu_SlozkaZanr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // změna žánru
            ZmenZanr();
            ZkontrolujSlozkuOpus();
            ZkontrolujSlozkuMp3();
        }
        private void comboBoxPridaniUpravaArchivu_SlozkaStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // změna státu
            ZmenZanr();
            ZkontrolujSlozkuOpus();
            ZkontrolujSlozkuMp3();
        }
        private void ZmenZanr()
        {
            if (checkBoxPridaniUpravaArchivu_ZanrMenit.Checked)
            {
                // automatická změna žánru zapnuta
                // -> automaticky změním žánr
                textBoxPridaniUpravaArchivu_Zanr.Text = ZiskejZanr();
            }
        }
        private string ZiskejZanr()
        {
            // automaticky získá žánr
            string zanr = DateTime.Now.Year + "." + DateTime.Now.Month.ToString("d2") + " " + comboBoxPridaniUpravaArchivu_SlozkaZanr.Text;
            return zanr;
        }

        private void textBoxPridaniUpravaArchivu_Interpret_Leave(object sender, EventArgs e)
        {
            // změna interpreta
            ZkontrolujSlozkuOpus();
            ZkontrolujSlozkuMp3();
        }
        private void textBoxPridaniUpravaArchivu_Album_Leave(object sender, EventArgs e)
        {
            // změna alba
            ZkontrolujSlozkuOpus();
            ZkontrolujSlozkuMp3();
        }
        private void numericUpDownPridaniUpravaArchivu_Rok_Leave(object sender, EventArgs e)
        {
            // změna roku
            ZkontrolujSlozkuOpus();
            ZkontrolujSlozkuMp3();
        }
        private void checkBoxPridaniUpravaArchivu_ZanrMenit_CheckedChanged(object sender, EventArgs e)
        {
            // automatická změna žánru byla změněna
            ZmenZanr();
        }

        private void textBoxPridaniUpravaArchivu_Zanr_Leave(object sender, EventArgs e)
        {
            // změna žánru
            if (textBoxPridaniUpravaArchivu_Zanr.Text == ZiskejZanr())
            {
                // žánr je stejný, jako ten co získám automaticky
                // zaškrtnu checkbox
                checkBoxPridaniUpravaArchivu_ZanrMenit.Checked = true;
            }
            else
            {
                // a naopak
                checkBoxPridaniUpravaArchivu_ZanrMenit.Checked = false;
            }
        }

        private void labelPridaniUpravaArchivu_SlozkaOpusCesta_Click(object sender, EventArgs e)
        {
            // otevření již existující složky opus interpreta a alba
            if (Directory.Exists(labelPridaniUpravaArchivu_SlozkaOpusCesta.Text))
            {
                // složka existuje
                // mohu ji otevřít
                Process.Start(labelPridaniUpravaArchivu_SlozkaOpusCesta.Text);
            }
        }
        private void labelPridaniUpravaArchivu_SlozkaMp3Cesta_Click(object sender, EventArgs e)
        {
            // otevření již existující složky mp3 interpreta a alba
            if (Directory.Exists(labelPridaniUpravaArchivu_SlozkaMp3Cesta.Text))
            {
                // složka existuje
                // mohu ji otevřít
                Process.Start(labelPridaniUpravaArchivu_SlozkaMp3Cesta.Text);
            }
        }

        private void buttonPridaniUpravaArchivu_CoverZiskat_Click(object sender, EventArgs e)
        {
            // cover - získání pomocí AlbumArtDownloaderu
            ZobrazStavNovy("získání coveru pomocí albumartdownloaderu", false);
            ZobrazStavPrubezny("kontroluji cestu " + comboBoxNastaveni_AlbumArt.Text);

            // zkontroluje cestu spustitelného programu
            ZkontrolujSoubor(comboBoxNastaveni_AlbumArt.Text, ".exe", labelNastaveni_AlbumArtStav);
            if (ZkontrolujPredSpoustenim(labelNastaveni_AlbumArtStav.Text, true))
            {
                // spustí AlbumArtDownloader
                // uloží nový cover jako "_cover.jpg"
                SpustitProgram(comboBoxNastaveni_AlbumArt.Text, "/ar \"" + textBoxPridaniUpravaArchivu_Interpret.Text + "\" /al \"" + textBoxPridaniUpravaArchivu_Album.Text +
                              "\" /path \"" + Path.Combine(slozkaProgramuCache, "_cover.jpg") + "\" /mn 1300 /mx 1600 /coverType front /sources \"Deezer,Itunes,Google Play Music\" /autoclose", true);

                if (File.Exists(Path.Combine(slozkaProgramuCache, "_cover.jpg")))
                {
                    // nový cover byl vybrán
                    // -> smažu starý cover
                    ZobrazStavPrubezny("mažu předchozí cover");
                    CoverSmaz(true);
                    // -> přejmenuji získaný cover ("_cover.jpg") na "cover.jpg"
                    PresunSoubor(Path.Combine(slozkaProgramuCache, "_cover.jpg"), Path.Combine(slozkaProgramuCache, "cover.jpg"));
                    // zobrazí obrázek
                    ZobrazStavPrubezny("načítám informace o coveru");
                    CoverZobraz(Path.Combine(slozkaProgramuCache, "cover.jpg"));
                    ZobrazStavPosledni("cover byl úspěšně změněn", true);
                }
                else
                {
                    ZobrazStavPosledni("cover nebyl změněn, protože nebyl vybrán nový", true);
                }
            }
            else
            {
                // neexistující soubor
                ZobrazStavPosledni(labelNastaveni_AlbumArtStav.Text, false);
            }
        }

        private void buttonPridaniUpravaArchivu_CoverVybrat_Click(object sender, EventArgs e)
        {
            ZobrazStavNovy("změna coveru", false);
            // výběr vlastního coveru
            using (var vyberSouboru = new OpenFileDialog())
            {
                /// DODĚLAT -> přidat další typy souborů ///
                vyberSouboru.Filter = "Obrázek | *.jpeg; *.jpg; *.gif; *.png; *.bmp"; //; *.JPEG; *.JPEG; *.GIF; *.PNG; *.BMP;
                DialogResult odpoved = vyberSouboru.ShowDialog();
                if (odpoved == DialogResult.OK && !string.IsNullOrWhiteSpace(vyberSouboru.FileName))
                {
                    ZobrazStavPrubezny("mažu předchozí cover");
                    CoverSmaz(true);
                    ZobrazStavPrubezny("kopíruji nový cover");
                    // zkopíruje vybraný obrázek a uloží ho do složky "cache" jako nový cover
                    CoverZkopiruj(vyberSouboru.FileName);
                    ZobrazStavPrubezny("načítám informace o novém coveru");
                    CoverZobraz(Path.Combine(slozkaProgramuCache, "cover" + Path.GetExtension(vyberSouboru.FileName)));
                }
            }
        }
        private void buttonPridaniUpravaArchivu_CoverSmazat_Click(object sender, EventArgs e)
        {
            ZobrazStavNovy("smazání coveru", false);
            // cover ve složce "cache"
            string cestaCoveru = ""; 
            if (buttonMenuUpravaArchivu.BackColor == Color.FromArgb(77, 77, 77))
            {
                // jedná se o úpravu archivu
                cestaCoveru = Path.Combine(slozkaProgramuCache, Path.GetFileNameWithoutExtension(textBoxPridaniUpravaArchivu_Archiv.Text), Path.GetFileName(pictureBoxPridaniUpravaArchivu_Cover.ImageLocation)); ;
            }
            else
            {
                // přidání nového archivu
                cestaCoveru = Path.Combine(slozkaProgramuCache, Path.GetFileNameWithoutExtension(comboBoxPridaniUpravaArchivu_Archiv.Text), Path.GetFileName(pictureBoxPridaniUpravaArchivu_Cover.ImageLocation)); ;
            }
            // smaže cover ve složce archivu (ne ten ve složce "cache")
            CoverSmaz(true);
            if (checkBoxPridaniUpravaArchivu_UkladatAutomaticky.Checked)
            {
                // automatické ukládání je zapnuto
                // -> smažu i cover ve složce "cache"
                if (File.Exists(cestaCoveru))
                {
                    try
                    {
                        File.Delete(cestaCoveru);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void buttonPridaniUpravaArchivu_Deezer_Click(object sender, EventArgs e)
        {
            // cover - získání pomocí Deezer
            ZobrazStavNovy("získání informací pomocí deezer search", false);
            ZobrazStavPrubezny("kontroluji cestu " + comboBoxNastaveni_Deezer.Text);

            // zkontroluje cestu spustitelného programu
            ZkontrolujSoubor(comboBoxNastaveni_Deezer.Text, ".exe", labelNastaveni_DeezerStav);
            if (ZkontrolujPredSpoustenim(labelNastaveni_DeezerStav.Text, true))
            {
                string slozka = Path.GetDirectoryName(comboBoxNastaveni_Deezer.Text);
                if (Directory.Exists(slozka))
                {
                    ZobrazStavPrubezny("měním nastavení programu deezer search");
                    UlozSoubor(Path.Combine(slozka, "cesta.txt"), slozkaProgramuCache);
                }
                else
                {
                    ZobrazStavPosledni("nastavení programu deezer search se nezdařilo", true);
                }
                SpustitProgram(comboBoxNastaveni_Deezer.Text, "\"" + textBoxPridaniUpravaArchivu_Interpret.Text + "\" \"" + textBoxPridaniUpravaArchivu_Album.Text + "\"", true);
            }
            else
            {
                // neexistující soubor
                ZobrazStavPosledni(labelNastaveni_DeezerStav.Text, false);
            }
        }

        private void CoverSmaz(bool zobraz)
        {
            // smaže cover
            string cesta = "";
            try
            {
                // cestu získá z pictureBoxu
                cesta = pictureBoxPridaniUpravaArchivu_Cover.ImageLocation;
            }
            catch (Exception ex)
            {
                ZobrazStavPosledni("cover se nepodařilo smazat", false);
                ZobrazChybu(ex.Message, "smazání coveru");
                return;
            }

            // skryji tlačítka a zruším zobrazení na pictureBoxu
            buttonPridaniUpravaArchivu_CoverSmazat.Enabled = false;
            labelPridaniUpravaArchivu_CoverInfo.Text = "";
            pictureBoxPridaniUpravaArchivu_Cover.ImageLocation = null;
            toolTipInfo.SetToolTip(pictureBoxPridaniUpravaArchivu_Cover, null);

            if (String.IsNullOrEmpty(cesta))
            {
                if (zobraz)
                {
                    ZobrazStavPosledni("cover byl úspěšně smazán", true);
                }
                return;
            }
            if (File.Exists(cesta))
            {
                // smaže soubor
                try
                {
                    File.Delete(cesta);
                }
                catch (Exception ex)
                {
                    ZobrazChybu(ex.Message, "smazání coveru");
                    ZobrazStavPosledni("cover se nepodařilo smazat", false);
                    return;
                }
                if (zobraz)
                {
                    ZobrazStavPosledni("cover byl úspěšně smazán", true);
                }
                return;
            }
            ZobrazChybu("cover" + cesta + " se nepodařilo smazat.", "smazání coveru");
            ZobrazStavPosledni("cover se nepodařilo smazat", false);
        }

        private void CoverZkopiruj(string puvodniCesta)
        {
            // zkopíruje cover do složky "cache"
            if (!File.Exists(puvodniCesta))
            {
                ZobrazStavPosledni("cover se nepodařilo zkopírovat", false);
                return;
            }
            try
            {
                File.Copy(puvodniCesta, Path.Combine(slozkaProgramuCache, "cover" + Path.GetExtension(puvodniCesta)), true);
            }
            catch (Exception ex)
            {
                ZobrazStavPosledni("cover se nepodařilo zkopírovat", false);
                ZobrazChybu(ex.Message, "Kopírování coveru");
                return;
            }
            ZobrazStavPosledni("cover byl úspěšně zkopírován", true);
        }

        private void CoverZobraz(string cesta)
        {
            // zobrazí nový cover a informace o něm
            if (File.Exists(cesta))
            {
                // zobrazí cover na pictureBoxu
                pictureBoxPridaniUpravaArchivu_Cover.ImageLocation = cesta;
                toolTipInfo.SetToolTip(pictureBoxPridaniUpravaArchivu_Cover, "Zobrazit obrázek");
                buttonPridaniUpravaArchivu_CoverSmazat.Enabled = true;

                // načte informace o coveru
                FileInfo soubor = new FileInfo(cesta);
                double coverVelikostB = soubor.Length;
                double coverVelikostMB = Math.Round(coverVelikostB / 1000000, 1);
                string coverNazev = Path.GetFileNameWithoutExtension(cesta);
                string coverTyp = Path.GetExtension(cesta).Replace(".", "");

                int coverSirka = 0;
                int coverVyska = 0;
                using (Bitmap img = new Bitmap(cesta))
                {
                    coverSirka = img.Width;
                    coverVyska = img.Height;
                }

                // zobrazí načtené informace na labelu
                labelPridaniUpravaArchivu_CoverInfo.Text = "Název:                " + coverNazev + Environment.NewLine
                                    + "Typ souboru:     " + coverTyp + Environment.NewLine
                                    + "Velikost:            " + coverVelikostMB + " MB   (" + coverVelikostB + " bajtů)" + Environment.NewLine
                                    + "Rozměry:           " + coverVyska + " x " + coverSirka + " px   (výška x šířka)";

                ZobrazStavPosledni("nový cover byl úspěšně načten", true);
            }
            else
            {
                ZobrazStavPosledni("nový cover se nepodařilo načíst", false);
            }
        }
        private void pictureBoxPridaniUpravaArchivu_Cover_Click(object sender, EventArgs e)
        {
            // zobrazení coveru v externím programu
            if (!String.IsNullOrEmpty(pictureBoxPridaniUpravaArchivu_Cover.ImageLocation))
            {
                ZobrazStavNovy("Zobrazuji cover", false);
                SpustitProgram(pictureBoxPridaniUpravaArchivu_Cover.ImageLocation, "", false);
            }
        }

        // PŘIDÁNÍ A ÚPRAVA //

        private void buttonPridaniUpravaArchivu_PridatPredchozi_Click(object sender, EventArgs e)
        {
            if (buttonPridaniUpravaArchivu_PridatPredchozi.Text == "Přidat archiv")
            {
                // přidání archivu
                ZobrazStavNovy("přidávání archivu do seznamu", false);
                ZobrazStavPrubezny("přidávám archiv " + comboBoxPridaniUpravaArchivu_Archiv.Text);

                // zkontroluje, zdali se jedná o archiv
                /// DODĚLAT -> přidat další typy souborů ///
                ZkontrolujSoubor(comboBoxPridaniUpravaArchivu_Archiv.Text, new string[] { ".zip", ".rar", ".tar", ".7z" }, labelPridaniUpravaArchivu_ArchivStav);
                if (!String.IsNullOrEmpty(labelPridaniUpravaArchivu_ArchivStav.Text))
                {
                    // přidávaný archiv neexistuje, nebo se nejedná o archiv
                    ZobrazChybu(labelPridaniUpravaArchivu_ArchivStav.Text, "Přidávání archivu do seznamu");
                    ZobrazStavPrubezny("archiv se nepodařilo přidat do seznamu");
                    ZobrazStavPosledni(labelPridaniUpravaArchivu_ArchivStav.Text, false);
                }
                else
                {
                    // přidávaný archiv existuje

                    int vysledekNalezeni = ExistujeCestaVSeznamuArchivu(comboBoxPridaniUpravaArchivu_Archiv.Text);
                    if (vysledekNalezeni == 0)
                    {
                        // název není v seznamu
                        // -> přidám do seznamu archivů
                        if (!UlozitArchiv(true))
                        {
                            return;
                        }
                        // -> zobrazím v menu možnost upravovat archivy a tlačítko v seznamu archivů, na výběr všech archivů
                        buttonMenuUpravaArchivu.Enabled = true;
                        buttonZobrazeniArchivu_VyberVse.Enabled = true;
                        checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.Enabled = true;
                        ZobrazStavPosledni("archiv byl úspěšně přidán do seznamu", true);
                    }
                    else if (vysledekNalezeni == 1)
                    {
                        // existuje stejný název archivu v seznamu
                        // -> nepřidám jej
                        ZobrazChybu("Archiv byl přidán do seznamu dříve", "Přidávání archivu do seznamu");
                        ZobrazStavPosledni("archiv byl přidán do seznamu dříve", false);
                    }
                    else if (vysledekNalezeni == 2)
                    {
                        /// DODĚLAT -> zde se pouze změní cesta
                        ///         -> pokud uživatel vybere archiv, který je už v seznamu, zeptám se ho ihned, zdali chce načíst tento archiv a upravit ho
                        // existuje stejný název archivu, ale rozdílná cesta, která byla aktualizována
                        ZobrazStavPosledni("archiv byl přidán do seznamu dříve, ale jeho cesta byla změněna", true);
                    }
                }

            }
            else
            {
                // předchozí archiv
                // -> uložení upravovaného archivu
                if (UkonciUpravu())
                {
                    // úprava se ukončila bez problému
                    // změním aktuální index archivu na předchozí a načtu ho
                    indexArchivu--;
                    NactiUpravu();
                }
            }
        }

        // ÚPRAVA //

        private void buttonPridaniUpravaArchivu_Nasledujici_Click(object sender, EventArgs e)
        {
            if (checkBoxPridaniUpravaArchivu_UkladatAutomaticky.Checked)
            {
                // automatické ukládání je zapnuto
                if (!UlozitArchiv(false))
                {
                    // ukládání archivu se nezdařilo (např. uživatel smazal interpreta / album / rok)
                    return;
                }
            }
            else
            {
                if (!UkonciUpravu())
                {
                    // úprava se neukončila v pořádku (např. uživatel smazal interpreta / album / rok)
                    return;
                }
            }
            // změním aktuální index archivu na následující a načtu ho
            indexArchivu++;
            NactiUpravu();
        }
        private bool UkonciUpravu()
        {
            // volá se při změně nebo zavření upravovaného archivu
            // provádí ukládání změn

            // vrací true, pokud se vše podařilo

            // je zapnuto automatické ukládání
            if (checkBoxPridaniUpravaArchivu_UkladatAutomaticky.Checked)
            {
                if (!UlozitArchiv(false))
                {
                    return false;
                }
            }
            else
            {
                // -> pokud ne, zeptám se uživatele
                DialogResult odpoved = MessageBox.Show("Automatické ukládání je vypnuto, chcete uložit změny?", "Uložení archivu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (odpoved == DialogResult.Yes)
                {
                    // uživatel souhlasí s uložením
                    // -> uložím
                    if (!UlozitArchiv(false))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool UlozitArchiv(bool novy)
        {
            // uloží nový nebo upravovaný archiv do seznamu
            ZobrazStavPrubezny("ukládám archiv");
            // zkontroluji ještě jednou archiv
            /// DODĚLAT -> přidat další typy souborů ///
            if (novy)
            {
                ZkontrolujSoubor(comboBoxPridaniUpravaArchivu_Archiv.Text, new string[] { ".zip", ".rar", ".tar", ".7z" }, labelPridaniUpravaArchivu_ArchivStav);

                if (!String.IsNullOrEmpty(labelPridaniUpravaArchivu_ArchivStav.Text))
                {
                    // je chyba archivu
                    ZobrazStavPosledni("ukládání archivu se nezdařilo, vyberte existující archiv", false);
                    ZobrazChybu(labelPridaniUpravaArchivu_ArchivStav.Text, "Ukládání archivu");
                    return false;
                }
            }
            string coverCesta = "";
            try
            {
                coverCesta = Path.GetFileName(pictureBoxPridaniUpravaArchivu_Cover.ImageLocation);
            }
            catch (Exception)
            {
                ZobrazStavPrubezny("nepodařilo se získat cestu coveru, nebude uložena");
            }
            // 0 název, 1 stav, 2 heslo (někdy skryté), 3 interpret, 4 rok, 5 album, 6 žánr, 7 složka opus, 8 složka mp3, 9 cover
            // tag = heslo, tooltiptext = cesta
            // stav: 0 = přidán archiv
            ListViewItem novyArchiv = new ListViewItem(new string[] {
                        Path.GetFileNameWithoutExtension(comboBoxPridaniUpravaArchivu_Archiv.Text),
                        "0",
                        "",
                        textBoxPridaniUpravaArchivu_Interpret.Text,
                        numericUpDownPridaniUpravaArchivu_Rok.Value.ToString(),
                        textBoxPridaniUpravaArchivu_Album.Text,
                        textBoxPridaniUpravaArchivu_Zanr.Text,
                        labelPridaniUpravaArchivu_SlozkaOpusCesta.Text,
                        labelPridaniUpravaArchivu_SlozkaMp3Cesta.Text,
                        coverCesta
                    });
            novyArchiv.ToolTipText = comboBoxPridaniUpravaArchivu_Archiv.Text;
            novyArchiv.Tag = textBoxPridaniUpravaArchivu_ArchivHeslo.Text;
            if (!String.IsNullOrEmpty(textBoxPridaniUpravaArchivu_ArchivHeslo.Text))
            {
                // je vyplněno heslo
                if (checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.Checked)
                {
                    // v seznamu archivů povoleno zobrazení hesel
                    novyArchiv.SubItems[2].Text = textBoxPridaniUpravaArchivu_ArchivHeslo.Text;
                }
                else
                {
                    // je zakázáno zobrazení hesel
                    novyArchiv.SubItems[2].Text = "***";
                }

            }
            if (String.IsNullOrEmpty(labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Text) && String.IsNullOrEmpty(labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Text))
            {
                // stav: 1 = vyplněna složka (interpret, album, rok)
                novyArchiv.SubItems[1].Text = "1";
            }
            if (novy)
            {
                // přidání nového
                // -> zašktnu a přidám
                novyArchiv.Checked = true;
                listViewZobrazeniArchivu_SeznamArchivu.Items.Add(novyArchiv);
            }
            else
            {
                novyArchiv.SubItems[0].Text = Path.GetFileNameWithoutExtension(textBoxPridaniUpravaArchivu_Archiv.Text);
                novyArchiv.ToolTipText = textBoxPridaniUpravaArchivu_Archiv.Text;
                ListViewItem upravovanyArchiv = listViewZobrazeniArchivu_SeznamArchivu.Items[indexArchivu];
                // úprava stávajícího
                if (upravovanyArchiv.Checked)
                {
                    // byl zaškrtnut
                    // -> zaškrtnu ho i po úpravě
                    novyArchiv.Checked = true;
                }
                // pokud byl stav původního archivu 0 nebo 1, neřeším nic
                if (upravovanyArchiv.SubItems[1].Text != "0" && upravovanyArchiv.SubItems[1].Text != "1")
                {
                    // stav nebyl 0 nebo 1
                    // tzn je 2 a výš
                    // složka musí být vyplněna
                    if (novyArchiv.SubItems[1].Text == "0")
                    {
                        // upravených archiv nemá vyplněného interpreta
                        ZobrazStavPosledni("archiv nebyl upraven, protože byla odstraněna cesta k hudebním složkám", false);
                        ZobrazChybu("Složka mp3 i opus musí být vyplněna", "Úprava archivu");
                        return false;
                    }
                    else
                    {
                        // uložím stav nového jako toho minulého
                        novyArchiv.SubItems[1].Text = upravovanyArchiv.SubItems[1].Text;
                    }
                }
                // uložím na index upravovaného již upravený archiv
                listViewZobrazeniArchivu_SeznamArchivu.Items[indexArchivu] = novyArchiv;
            }
            ZobrazStavPosledni("archiv byl úspěšně přidán do seznamu", true);
            // uložím změny do souboru
            UlozitZmeny(novy);
            VycistitText();
            return true;
        }

        private void UlozitZmeny(bool novy)
        {
            // uloží změny do souborů (interpret, album, rok, žánr)
            // přesune cover do složky
            ZobrazStavNovy("zapisování změn do souboru", false);
            string slozka = "";
            if (novy)
            {
                slozka = Path.GetFileNameWithoutExtension(comboBoxPridaniUpravaArchivu_Archiv.Text);
            }
            else
            {
                slozka = Path.GetFileNameWithoutExtension(textBoxPridaniUpravaArchivu_Archiv.Text);
            }
            try
            {
                if (!Directory.Exists(Path.Combine(slozkaProgramuCache, slozka)))
                {
                    Directory.CreateDirectory(Path.Combine(slozkaProgramuCache, slozka));
                }
            }
            catch (Exception ex)
            {
                ZobrazStavPosledni("zapisování změn do souboru se nezdařilo", false);
                ZobrazChybu(ex.Message, "Zapisování změn do souboru");
            }
            if (!String.IsNullOrEmpty(pictureBoxPridaniUpravaArchivu_Cover.ImageLocation))
            {
                // existuje cover
                // -> přesunu ho ze složky "cache" do složky archivu
                PresunSoubor(pictureBoxPridaniUpravaArchivu_Cover.ImageLocation, Path.Combine(slozkaProgramuCache, slozka, Path.GetFileName(pictureBoxPridaniUpravaArchivu_Cover.ImageLocation)));
            }
            // uloží do souborů informace
            UlozSoubor(Path.Combine(slozkaProgramuCache, slozka, "info_interpret.txt"), textBoxPridaniUpravaArchivu_Interpret.Text);
            UlozSoubor(Path.Combine(slozkaProgramuCache, slozka, "info_album.txt"), textBoxPridaniUpravaArchivu_Album.Text);
            UlozSoubor(Path.Combine(slozkaProgramuCache, slozka, "info_rok.txt"), numericUpDownPridaniUpravaArchivu_Rok.Value.ToString());
            UlozSoubor(Path.Combine(slozkaProgramuCache, slozka, "info_zanr.txt"), textBoxPridaniUpravaArchivu_Zanr.Text);
        }
        private void VycistitText()
        {
            // vymaže text v přidávání / úpravě archivu

            comboBoxPridaniUpravaArchivu_Archiv.Text = "";
            textBoxPridaniUpravaArchivu_ArchivHeslo.Text = "";
            textBoxPridaniUpravaArchivu_Interpret.Text = "";
            numericUpDownPridaniUpravaArchivu_Rok.Value = numericUpDownPridaniUpravaArchivu_Rok.Maximum;
            textBoxPridaniUpravaArchivu_Album.Text = "";
            if (!checkBoxPridaniUpravaArchivu_ZanrMenit.Checked)
            {
                textBoxPridaniUpravaArchivu_Zanr.Text = "";
            }
            labelPridaniUpravaArchivu_SlozkaOpusCesta.Text = "";
            labelPridaniUpravaArchivu_SlozkaMp3Cesta.Text = "";
            labelPridaniUpravaArchivu_SlozkaOpusCestaStav.Text = "";
            labelPridaniUpravaArchivu_SlozkaMp3CestaStav.Text = "";
            toolTipInfo.SetToolTip(labelPridaniUpravaArchivu_SlozkaOpusCestaStav, null);
            toolTipInfo.SetToolTip(labelPridaniUpravaArchivu_SlozkaMp3CestaStav, null);

            buttonPridaniUpravaArchivu_CoverSmazat.Enabled = false;
            labelPridaniUpravaArchivu_CoverInfo.Text = "";
            pictureBoxPridaniUpravaArchivu_Cover.ImageLocation = null;
            toolTipInfo.SetToolTip(pictureBoxPridaniUpravaArchivu_Cover, null);
        }

        private void NactiUpravu()
        {
            // načte aktuální archiv k úpravě

            ZobrazStavNovy("probíhá načítání archivu", false);
            // smaže cover
            CoverSmaz(false);

            // zobrazení / skrytí tlačítek "předchozí" a "následující"
            if (indexArchivu - 1 < 0)
            {
                buttonPridaniUpravaArchivu_PridatPredchozi.Enabled = false;
            }
            else
            {
                buttonPridaniUpravaArchivu_PridatPredchozi.Enabled = true;
            }

            if (indexArchivu + 1 > listViewZobrazeniArchivu_SeznamArchivu.Items.Count - 1)
            {
                buttonPridaniUpravaArchivu_Nasledujici.Enabled = false;
            }
            else
            {
                buttonPridaniUpravaArchivu_Nasledujici.Enabled = true;
            }

            // načtení upravovaného archivu
            // 0 název, 1 stav, 2 heslo (někdy skryté), 3 interpret, 4 rok, 5 album, 6 žánr, 7 složka opus, 8 složka mp3, 9 cover
            // tag = heslo, tooltiptext = cesta
            ListViewItem archiv = listViewZobrazeniArchivu_SeznamArchivu.Items[indexArchivu];
            textBoxPridaniUpravaArchivu_Archiv.Text = archiv.ToolTipText;
            textBoxPridaniUpravaArchivu_ArchivHeslo.Text = archiv.Tag.ToString();
            textBoxPridaniUpravaArchivu_Interpret.Text = archiv.SubItems[3].Text;
            if (String.IsNullOrEmpty(archiv.SubItems[4].Text))
            {
                // rok není vyplněn
                // -> nastavím aktuální rok (maximum)
                numericUpDownPridaniUpravaArchivu_Rok.Value = numericUpDownPridaniUpravaArchivu_Rok.Maximum;
            }
            else
            {
                numericUpDownPridaniUpravaArchivu_Rok.Value = Convert.ToInt32(archiv.SubItems[4].Text);
            }
            textBoxPridaniUpravaArchivu_Album.Text = archiv.SubItems[5].Text;
            if (String.IsNullOrEmpty(archiv.SubItems[6].Text))
            {
                // žánr není vyplněn
                // pokud je zaškrnutá automatická změna žánru, provedu automatickou aktualizaci
                ZmenZanr();
            }
            else
            {
                textBoxPridaniUpravaArchivu_Zanr.Text = archiv.SubItems[6].Text;
            }
            if (textBoxPridaniUpravaArchivu_Zanr.Text == ZiskejZanr())
            {
                // načtený žánr je roven automaticky nastavenému žánru
                // -> změna zaškrtnutí automatické změny žánru
                checkBoxPridaniUpravaArchivu_ZanrMenit.Checked = true;
            }
            else
            {
                checkBoxPridaniUpravaArchivu_ZanrMenit.Checked = false;
            }
            labelPridaniUpravaArchivu_SlozkaOpusCesta.Text = archiv.SubItems[7].Text;
            labelPridaniUpravaArchivu_SlozkaMp3Cesta.Text = archiv.SubItems[8].Text;
            // zkontroluje hudební složky (mp3 i opus)
            ZkontrolujSlozkuOpus();

            ZkontrolujSlozkuMp3();

            if (File.Exists(Path.Combine(slozkaProgramuCache, Path.GetFileNameWithoutExtension(textBoxPridaniUpravaArchivu_Archiv.Text), archiv.SubItems[9].Text)))
            {
                // ve složce k archivu jsem nalezl cover
                // -> zkopíruji ho pouze do slozky "cache"
                CoverZkopiruj(Path.Combine(slozkaProgramuCache, Path.GetFileNameWithoutExtension(textBoxPridaniUpravaArchivu_Archiv.Text), archiv.SubItems[9].Text));
                // -> a následně ho zobrazím
                ZobrazStavPrubezny("načítám informace o coveru");
                CoverZobraz(Path.Combine(slozkaProgramuCache, archiv.SubItems[9].Text));
            }
            ZobrazStavPosledni("archiv " + archiv.SubItems[0].Text + " byl úspěšně načten", true);
        }
        // PŘIDÁNÍ SLOŽKY //

        private void comboBoxPridaniSlozky_Slozka_Leave(object sender, EventArgs e)
        {
            // přidání složky do comboboxu se seznamem cest k již dříve otevřeným složkám
            PridejCestu(comboBoxPridaniSlozky_Slozka.Text, comboBoxPridaniSlozky_Slozka, false);
            // kontrola složky (zdali existuje)
            ZkontrolujSlozku(comboBoxPridaniSlozky_Slozka.Text, false, labelPridaniSlozky_Stav);
        }
        private void buttonPridaniSlozky_VybratSlozku_Click(object sender, EventArgs e)
        {
            // zobrazí dialog na výběr složky a přidá ji do comboboxu
            VyberSlozky(comboBoxPridaniSlozky_Slozka);
            // kontrola složky (zdali existuje)
            ZkontrolujSlozku(comboBoxPridaniSlozky_Slozka.Text, false, labelPridaniSlozky_Stav);
        }
        private void buttonPridaniSlozky_NacistArchivy_Click(object sender, EventArgs e)
        {
            // načte všechny archivy ze složky
            NactiArchivyZeSlozky(comboBoxPridaniSlozky_Slozka.Text);
        }
        // 0 = nepřidáno (chyba)
        // 1 = nepřidáno (již byl přidán dříve)
        // 2 = přidáno úspěšně
        private int PridejArchivNaSeznam(string soubor)
        {
            string pripona = Path.GetExtension(soubor);
            /// DODĚLAT -> přidat další typy souborů ///
            if (pripona == ".zip" || pripona == ".rar" || pripona == ".tar" || pripona == ".7z")
            {
                if (ExistujeCestaVSeznamuPridavanychArchivu(soubor))
                {
                    // existuje cesta v seznamu
                    return 1;
                }
                // cesta není v seznamu
                // -> vytvořím nový item a přidám ho do seznamu archivů
                ZobrazStavPrubezny("načítám archiv " + soubor);
                // název archivu, složka, typ archivu, cesta
                ListViewItem novyArchiv = new ListViewItem(new string[] { Path.GetFileNameWithoutExtension(soubor), new DirectoryInfo(Path.GetDirectoryName(soubor)).Name, pripona.Replace(".", ""), soubor });
                novyArchiv.Checked = true;
                listViewPridaniSlozky_SeznamArchivu.Items.Add(novyArchiv);
                return 2; // nově přidáno
            }
            return 0;
        }
        private void NactiArchivyZeSlozky(string slozka)
        {
            ZobrazStavNovy("načítání archivů ze složky", false);
            // kontrola složky
            ZkontrolujSlozku(comboBoxPridaniSlozky_Slozka.Text, false, labelPridaniSlozky_Stav);

            if (!String.IsNullOrEmpty(labelPridaniSlozky_Stav.Text))
            {
                // pokud je nějaká chyba, ukončím a zobrazím messagebox
                ZobrazChybu(labelPridaniSlozky_Stav.Text, "Načítání archivů ze složky");
                ZobrazStavPosledni(labelPridaniSlozky_Stav.Text, false);
                return;
            }

            int pocetArchivu = 0;
            int pocetJizPridanychArchivu = 0;
            // získám soubory ze složky
            List<string> souboryZeSlozky = null;
            try
            {
                if (checkBoxPridaniSlozky_NacistPodslozky.Checked)
                {
                    souboryZeSlozky = Directory.GetFiles(slozka, "*.*", SearchOption.AllDirectories).ToList();
                }
                else
                {
                    souboryZeSlozky = Directory.GetFiles(slozka, "*.*", SearchOption.TopDirectoryOnly).ToList();
                }
            }
            catch (Exception ex)
            {
                ZobrazChybu(ex.Message, "Načítání archivů ze složky");
                ZobrazStavPosledni("nepodařilo se získat soubory ze složky", false);
                return;
            }

            if (checkBoxPridaniSlozky_odstranitNacteneArchivy.Checked)
            {
                listViewPridaniSlozky_SeznamArchivu.Items.Clear();
            }

            foreach (string souborZeSlozky in souboryZeSlozky)
            {
                int pridano = PridejArchivNaSeznam(souborZeSlozky);
                if (pridano == 1)
                {
                    pocetJizPridanychArchivu++;
                }
                else if (pridano == 2)
                {
                    pocetArchivu++;
                }
            }
            if (pocetJizPridanychArchivu > 0)
            {
                // nalezeny nějaké již dříve přidané archivy
                if (pocetArchivu < 1)
                {
                    ZobrazStavPosledni("nebylo načteno " + pocetJizPridanychArchivu + " již dříve přidaných archivů", false);
                }
                else
                {
                    ZobrazStavPosledni("bylo načteno " + pocetArchivu + " archivů a nebylo přidáno " + pocetJizPridanychArchivu + " již dříve načtených archivů", true);
                }
            }
            else
            {
                if (pocetArchivu < 1)
                {
                    ZobrazStavPosledni("nebyl nazelen žádný archiv", false);
                }
                else
                {
                    ZobrazStavPosledni("bylo načteno " + pocetArchivu + " archivů", true);
                }
            }
        }
        private bool ExistujeCestaVSeznamuPridavanychArchivu(string cestaKProhledani)
        {
            // prohledá listview s načtenými archivy
            // kontroluje cesty
            // vrátí true, pokud byla cesta nalezena
            foreach (ListViewItem cestaZeSeznamu in listViewPridaniSlozky_SeznamArchivu.Items)
            {
                // cestaKProhledani == cestaListViewItemu
                if (cestaKProhledani == cestaZeSeznamu.SubItems[3].Text)
                {
                    return true;
                }
            }
            return false;
        }
        private void listViewPridaniSlozky_SeznamArchivu_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // zaškrnutí archivu a jeho následné zobrazení na labelu
            // zobrazení / skrytí tlačítka na přidání archivů
            // zobrazení počtu vybraných archivů na labelu
            if (listViewPridaniSlozky_SeznamArchivu.CheckedItems.Count == 0)
            {
                // není zašrtnut žádný archiv
                buttonPridaniSlozky_PridatArchivy.Enabled = false;
                if (listViewPridaniSlozky_SeznamArchivu.Items.Count == 0)
                {
                    labelPridaniSlozky_VybraneArchivy.Text = "Načtěte složku s archivy";
                }
                else
                {
                    labelPridaniSlozky_VybraneArchivy.Text = "Vyberte archiv ze seznamu k přidání";
                }
            }
            else
            {
                buttonPridaniSlozky_PridatArchivy.Enabled = true;
                labelPridaniSlozky_VybraneArchivy.Text = listViewPridaniSlozky_SeznamArchivu.CheckedItems.Count + " vybraných archivů z " + listViewPridaniSlozky_SeznamArchivu.Items.Count + " archivů ze složky";
            }
        }
        private void buttonPridaniSlozky_PridatArchivy_Click(object sender, EventArgs e)
        {
            // přidání archivů ze seznamu načtených archivů
            ZobrazStavNovy("přidávání archivů do seznamu", false);
            int pocetArchivu = 0;
            int pocetJizPridanychArchivu = 0;
            foreach (ListViewItem archivZeSeznamu in listViewPridaniSlozky_SeznamArchivu.CheckedItems)
            {
                ZobrazStavPrubezny("přidávám archiv " + archivZeSeznamu.SubItems[3].Text);

                // cesta
                int vysledek = ExistujeCestaVSeznamuArchivu(archivZeSeznamu.SubItems[3].Text);
                if (vysledek == 1)
                {
                    // existuje stejný název archivu v seznamu
                    // -> nepřidám je
                    archivZeSeznamu.Checked = false;
                    pocetJizPridanychArchivu++;
                    ZobrazStavPosledni("archiv " + archivZeSeznamu.SubItems[3].Text + " nebyl přidán, protože byl přidán již dříve", false);
                    if (checkBoxPridaniSlozky_SmazatDrivePridane.Checked)
                    {
                        listViewPridaniSlozky_SeznamArchivu.Items.Remove(archivZeSeznamu);
                    }
                }
                else if (vysledek == 2)
                {
                    // existuje stejný název archivu, ale rozdílná cesta, která byla aktualizována
                    // -> odstraním ze seznamu přidávaných
                    listViewPridaniSlozky_SeznamArchivu.Items.Remove(archivZeSeznamu);
                }
                else if (vysledek == 0)
                {
                    // název není v seznamu
                    // -> přidám do seznamu archivů

                    // 0 název, 1 stav, 2 heslo (někdy skryté), 3 interpret, 4 rok, 5 album, 6 žánr, 7 složka opus, 8 složka mp3, 9 cover
                    // tag = heslo, tooltiptext = cesta
                    ListViewItem novyArchiv = new ListViewItem(new string[] { archivZeSeznamu.SubItems[0].Text, "0", "", "", "", "", "", "", "", "" });
                    novyArchiv.ToolTipText = archivZeSeznamu.SubItems[3].Text; // cesta
                    novyArchiv.Tag = "";
                    novyArchiv.Checked = true;
                    // přidá na seznam archivů
                    listViewZobrazeniArchivu_SeznamArchivu.Items.Add(novyArchiv);
                    // odstraní ze seznamu načtených archivů ze složky
                    listViewPridaniSlozky_SeznamArchivu.Items.Remove(archivZeSeznamu);
                    pocetArchivu++;
                }
            }
            if (pocetJizPridanychArchivu > 0)
            {
                // nalezeny nějaké již dříve přidané archivy
                if (pocetArchivu < 1)
                {
                    ZobrazStavPosledni("nebylo přidáno " + pocetJizPridanychArchivu + " již dříve přidaných archivů", false);
                }
                else
                {
                    ZobrazStavPosledni("bylo přidáno " + pocetArchivu + " archivů a nebylo přidáno " + pocetJizPridanychArchivu + " již dříve přidaných archivů", true);
                    // povolení kliknutí na úpravu archivů
                    buttonMenuUpravaArchivu.Enabled = true;
                    buttonZobrazeniArchivu_VyberVse.Enabled = true;
                    checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.Enabled = true;
                }
            }
            else
            {
                if (pocetArchivu < 1)
                {
                    ZobrazStavPosledni("nepodařilo se přidat žádný archiv", false);
                }
                else
                {
                    ZobrazStavPosledni("bylo přidáno " + pocetArchivu + " archivů", true);
                    // povolení kliknutí na úpravu archivů
                    buttonMenuUpravaArchivu.Enabled = true;
                    buttonZobrazeniArchivu_VyberVse.Enabled = true;
                    checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.Enabled = true;
                }
            }
            // aktualizace labelu, který zobrazuje počet zaškrtnutých archivů
            listViewPridaniSlozky_SeznamArchivu_ItemChecked(null, null);
        }
        private int ExistujeCestaVSeznamuArchivu(string cestaKProhledani)
        {
            // 0 = nenalezeno, 1 = nalezeno, 2 = nalazeno a nahrazeno
            // kontroluje jména
            string nazevKProhledani = Path.GetFileNameWithoutExtension(cestaKProhledani);
            foreach (ListViewItem cestaZeSeznamu in listViewZobrazeniArchivu_SeznamArchivu.Items)
            {
                // nazevKProhledani == nazevListViewItemu
                if (nazevKProhledani == cestaZeSeznamu.SubItems[0].Text)
                {
                    if (cestaZeSeznamu.ToolTipText == null)
                    {
                        // ToolTipText není, nastavím ho aktuální cestou
                        cestaZeSeznamu.ToolTipText = cestaKProhledani;
                    }
                    else if (cestaZeSeznamu.ToolTipText != cestaKProhledani)
                    {
                        // jedná se o jiný soubor
                        // nabídnu uživateli možnost nahradit cestu
                        DialogResult odpoved = MessageBox.Show("Chcete změnit cestu k existujícímu archivu?" + Environment.NewLine + Environment.NewLine + "\"" + cestaZeSeznamu.ToolTipText.ToString() + "\"" + Environment.NewLine
                                                                + "     se nahradí" + Environment.NewLine + "\"" + cestaKProhledani + "\"",
                                                               "Změna cesty archivu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (odpoved == DialogResult.Yes)
                        {
                            cestaZeSeznamu.ToolTipText = cestaKProhledani;
                            return 2;
                        }
                    }
                    return 1;
                }
            }
            return 0;
        }

        // MENU //
        private void buttonMenuPridaniSlozky_Click(object sender, EventArgs e)
        {
            MenuPrepni(buttonMenuPridaniSlozky, panelPridaniSlozky);
        }
        private void buttonMenuPridaniArchivu_Click(object sender, EventArgs e)
        {
            MenuPrepniPridaniUprava(false);
        }
        private void buttonMenuZobrazeniArchivu_Click(object sender, EventArgs e)
        {
            MenuPrepni(buttonMenuZobrazeniArchivu, panelZobrazeniArchivu);
        }
        private void buttonMenuUpravaArchivu_Click(object sender, EventArgs e)
        {
            MenuPrepniPridaniUprava(true);
        }
        private void buttonMenuNastaveni_Click(object sender, EventArgs e)
        {
            MenuPrepni(buttonMenuNastaveni, panelNastaveni);
        }

        private void MenuPrepni(Button tlacitkoKZobrazeni, Panel panelKZobrazeni)
        {
            // slouží k přepínání panelů pomocí tlačítek menu

            if (buttonMenuUpravaArchivu.BackColor != Color.FromArgb(77, 77, 77))
            {
                // otevřen je tab "úprava archivu"
                // ukončím úpravu archivu
                if (!UkonciUpravu())
                {
                    // ukončení úpravy se nezdařilo (např. uživatel smazal interpreta / album / rok)
                    return;
                }
            }
            else if (buttonMenuNastaveni.BackColor != Color.FromArgb(77, 77, 77))
            {
                // otevřen je tab "nastavení"
                if (listViewZobrazeniArchivu_SeznamArchivu.Items.Count > 0)
                {
                    // existují nějaké archivy
                    ZkontrolujSlozkuOpus();
                    if (!String.IsNullOrEmpty(labelNastaveni_SlozkaOpusStav.Text))
                    {
                        ZobrazChybu(labelNastaveni_SlozkaOpusStav.Text, "ukládání nastavení - složka opus");
                        return;
                    }
                    ZkontrolujSlozkuMp3();
                    if (!String.IsNullOrEmpty(labelNastaveni_SlozkaMp3Stav.Text))
                    {
                        ZobrazChybu(labelNastaveni_SlozkaMp3Stav.Text, "ukládání nastavení - složka mp3");
                        return;
                    }

                    foreach (ListViewItem archiv in listViewZobrazeniArchivu_SeznamArchivu.Items)
                    {
                        /// DODĚLAT ///
                        /// pokud již byla složka vyplněna a já ji změním
                        /// ale nejde nalézt
                        /// neprovede se žádná změna
                        /// a zůstane tam ta stará složka opus a mp3
                        /// což je špatně
                        /// musím smazat složku z archivu
                        /// a také změnit její stav !!!!!!



                        /// DODĚLAT ///
                        /// neměním zde vůbec stav toho archivu !!!!!!!

                        // 0 název, 1 stav, 2 heslo (někdy skryté), 3 interpret, 4 rok, 5 album, 6 žánr, 7 složka opus, 8 složka mp3, 9 cover
                        // tag = heslo, tooltiptext = cesta

                        string interpret = archiv.SubItems[3].Text;
                        string rok = archiv.SubItems[3].Text;
                        string album = archiv.SubItems[3].Text;
                        string zanr = archiv.SubItems[6].Text;
                        if (String.IsNullOrEmpty(interpret) ||
                            String.IsNullOrEmpty(rok) ||
                            String.IsNullOrEmpty(album) ||
                            String.IsNullOrEmpty(zanr))
                        {
                            // není vyplněno
                            continue;
                        }
                        // je vyplněno vše potřebné k získání cesty hudebních složek

                        // zkontoluji složku opus a mp3
                        ZkontrolujSlozku(Path.Combine(comboBoxNastaveni_SlozkaOpus.Text, zanr), true, labelZobrazeniArchivu_Kontrola);
                        if (!String.IsNullOrEmpty(labelZobrazeniArchivu_Kontrola.Text))
                        {
                            // složka neexistuje nebo v ní neexistují podsložky žánru
                            continue;
                        }
                        ZkontrolujSlozku(Path.Combine(comboBoxNastaveni_SlozkaMp3.Text, zanr), true, labelZobrazeniArchivu_Kontrola);
                        if (!String.IsNullOrEmpty(labelZobrazeniArchivu_Kontrola.Text))
                        {
                            // složka neexistuje nebo v ní neexistují podsložky žánru
                            continue;
                        }
                        // získám složku interpreta a alba do které má bý archiv přesunut
                        archiv.SubItems[7].Text = Path.Combine(comboBoxNastaveni_SlozkaOpus.Text, zanr, interpret, rok + " " + album);
                        archiv.SubItems[8].Text = Path.Combine(comboBoxNastaveni_SlozkaMp3.Text, zanr, interpret, rok + " " + album);
                    }
                }                
            }

            // nastavím všem tlačítkům menu stejnou barvu a font
            buttonMenuPridaniSlozky.BackColor = Color.FromArgb(77, 77, 77);
            buttonMenuPridaniArchivu.BackColor = Color.FromArgb(77, 77, 77);
            buttonMenuZobrazeniArchivu.BackColor = Color.FromArgb(77, 77, 77);
            buttonMenuUpravaArchivu.BackColor = Color.FromArgb(77, 77, 77);
            buttonMenuNastaveni.BackColor = Color.FromArgb(77, 77, 77);

            buttonMenuPridaniSlozky.Font = new Font(buttonMenuNastaveni.Font, FontStyle.Regular);
            buttonMenuPridaniArchivu.Font = new Font(buttonMenuNastaveni.Font, FontStyle.Regular);
            buttonMenuZobrazeniArchivu.Font = new Font(buttonMenuNastaveni.Font, FontStyle.Regular);
            buttonMenuUpravaArchivu.Font = new Font(buttonMenuNastaveni.Font, FontStyle.Regular);
            buttonMenuNastaveni.Font = new Font(buttonMenuNastaveni.Font, FontStyle.Regular);

            // změním u tlačítka k zobrazení
            tlacitkoKZobrazeni.BackColor = Color.FromArgb(26, 26, 26);
            tlacitkoKZobrazeni.Font = new Font(buttonMenuPridaniArchivu.Font, FontStyle.Bold);

            // skryji všechny panely
            panelPridaniSlozky.Visible = false;
            panelPridaniUpravaArchivu.Visible = false;
            panelZobrazeniArchivu.Visible = false;
            panelNastaveni.Visible = false;

            // zobrazím panel k zobrazení
            panelKZobrazeni.Visible = true;
        }
        private void MenuPrepniPridaniUprava(bool uprava)
        {
            // slouží k přepínání panelů pomocí tlačítek menu
            // zde ale pouze při přepínání mezi přidáním nebo úpravou archivu
            // protože používám stejný panel
            // je potřeba skrýt / zobrazit některá tlačítka

            if (uprava)
            {
                textBoxPridaniUpravaArchivu_Archiv.Visible = true;
                comboBoxPridaniUpravaArchivu_Archiv.Visible = false;

                buttonPridaniUpravaArchivu_ArchivVybrat.Visible = false;
                buttonPridaniUpravaArchivu_Nasledujici.Visible = true;

                checkBoxPridaniUpravaArchivu_UkladatAutomaticky.Visible = true;
                buttonPridaniUpravaArchivu_PridatPredchozi.Text = "Předchozí";
                labelPridaniUpravaArchivu_ArchivStav.Text = "";

                // načte a zobrazí první úpravu do comboboxů a textboxů
                NactiUpravu();
                MenuPrepni(buttonMenuUpravaArchivu, panelPridaniUpravaArchivu);
            }
            else
            {
                textBoxPridaniUpravaArchivu_Archiv.Visible = false;
                comboBoxPridaniUpravaArchivu_Archiv.Visible = true;

                comboBoxPridaniUpravaArchivu_Archiv_Leave(null, null);
                buttonPridaniUpravaArchivu_ArchivVybrat.Visible = true;
                buttonPridaniUpravaArchivu_Nasledujici.Visible = false;

                checkBoxPridaniUpravaArchivu_UkladatAutomaticky.Visible = false;
                buttonPridaniUpravaArchivu_PridatPredchozi.Text = "Přidat archiv";

                MenuPrepni(buttonMenuPridaniArchivu, panelPridaniUpravaArchivu);
            }
        }

        // ZOBRAZENÍ STAVU //
        private void ZobrazStav(string stav)
        {
            listViewStav.Items.Add(stav);
            listViewStav.Items[listViewStav.Items.Count - 1].EnsureVisible();
        }
        private void ZobrazStavNovy(string stav, bool smazat)
        {
            if (smazat)
            {
                listViewStav.Items.Clear();
            }
            ZobrazStav("----------------------------------");
            ZobrazStav(stav.ToUpper() + ":");
        }
        private void ZobrazStavPrubezny(string stav)
        {
            if (!checkBoxNastaveni_ZobrazovatPodrobnostiStavu.Checked)
            {
                ZobrazStav("→ " + stav.ToLower());
            }
        }
        private void ZobrazStavPosledni(string stav, bool vPoradku)
        {
            if (vPoradku)
            {
                ZobrazStav("✔ " + stav.ToLower());
            }
            else
            {
                ZobrazStav("❌ " + stav.ToLower());
            }
        }

        private void ZobrazChybu(string zprava, string nadpis)
        {
            MessageBox.Show(zprava, "Chyba - " + nadpis, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void listViewStav_SizeChanged(object sender, EventArgs e)
        {
            // změna šířky sloupců listview se stavem
            listViewStav.Columns[0].Width = listViewStav.Width - 22;
        }
        
        // ZOBRAZENÍ ARCHIVŮ //
        // - tlačítka odstranění, výběru, změna počtu vybraných archivů -//
        private void buttonZobrazeniArchivu_Odstranit_Click(object sender, EventArgs e)
        {
            // odstraní vybrané archivy ze seznamu

            // nastaví index archivu k úpravě
            indexArchivu = 0;

            ZobrazStavNovy("odstranění archivů ze seznamu", false);
            int pocetSmazanych = 0;

            foreach (ListViewItem vybranyArchiv in listViewZobrazeniArchivu_SeznamArchivu.CheckedItems)
            {
                string archivNazev = vybranyArchiv.SubItems[0].Text;
                // odstraní zaškrnuté archivy
                if (Directory.Exists(Path.Combine(slozkaProgramuCache, archivNazev)))
                {
                    ZobrazStavPrubezny("odstraňuji archiv " + archivNazev);
                    // odstraní složku archivu
                    try
                    {
                        Directory.Delete(Path.Combine(slozkaProgramuCache, archivNazev), true);
                    }
                    catch (Exception ex)
                    {
                        ZobrazStavPosledni("archiv " + archivNazev + " se nepodařilo odstranit", false);
                        ZobrazChybu(ex.Message, "Odstraňování archivu");
                        continue;
                    }
                }
                listViewZobrazeniArchivu_SeznamArchivu.Items.Remove(vybranyArchiv);
                pocetSmazanych++;
            }
            if (listViewZobrazeniArchivu_SeznamArchivu.Items.Count <= 0)
            {
                // pokud je archivů 0
                // -> zruším zobrazení tlačítka
                // -> zakážu úpravy
                buttonMenuUpravaArchivu.Enabled = false;
                buttonZobrazeniArchivu_VyberVse.Enabled = false;
                checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.Enabled = false;
            }
            // změní se počet vybraných archivů
            // -> dojde k zobrazení / skrytí tlačítek
            listViewZobrazeniArchivu_SeznamArchivu_ItemChecked(null, null);
            // zobrazí zprávu
            ZobrazStavPosledni("bylo odstraněno " + pocetSmazanych + " archivů ze seznamu", true);
        }
        private void listViewZobrazeniArchivu_SeznamArchivu_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // změní se počet vybraných archivů
            // -> dojde k zobrazení / skrytí tlačítek
            if (listViewZobrazeniArchivu_SeznamArchivu.CheckedItems.Count > 0)
            {
                if (listViewZobrazeniArchivu_SeznamArchivu.CheckedItems.Count == 1)
                {
                    buttonZobrazeniArchivu_Rozbalit.Text = "Rozbalit archiv";
                    labelZobrazeniArchivu_VybraneArchivy.Text = "1 vybraný archiv";
                }
                else
                {
                    buttonZobrazeniArchivu_Rozbalit.Text = "Rozbalit archivy";
                    if (listViewZobrazeniArchivu_SeznamArchivu.CheckedItems.Count <= 4)
                    {
                        labelZobrazeniArchivu_VybraneArchivy.Text = listViewZobrazeniArchivu_SeznamArchivu.CheckedItems.Count + " vybrané archivy";
                    }
                    else
                    {
                        labelZobrazeniArchivu_VybraneArchivy.Text = listViewZobrazeniArchivu_SeznamArchivu.CheckedItems.Count + " vybraných archivů";
                    }
                }
                buttonZobrazeniArchivu_Odstranit.Enabled = true;
                buttonZobrazeniArchivu_VyberZrusit.Enabled = true;
                buttonZobrazeniArchivu_Rozbalit.Enabled = true;
                buttonZobrazeniArchivu_PrevestNaOpus.Enabled = true;
                buttonZobrazeniArchivu_PrevestNaOpusMp3.Enabled = true;
                buttonZobrazeniArchivu_PresunDoKnihoven.Enabled = true;
                buttonZobrazeniArchivu_Mp3TagRozbalene.Enabled = true;
                buttonZobrazeniArchivu_Mp3TagOpus.Enabled = true;
                buttonZobrazeniArchivu_Mp3TagMp3.Enabled = true;
                buttonZobrazeniArchivu_Mp3TagVse.Enabled = true;
                buttonZobrazeniArchivu_PrevestNaMp3.Enabled = true;
            }
            else
            {
                labelZobrazeniArchivu_VybraneArchivy.Text = "0 vybraných archivů";
                buttonZobrazeniArchivu_Odstranit.Enabled = false;
                buttonZobrazeniArchivu_VyberZrusit.Enabled = false;
                buttonZobrazeniArchivu_Rozbalit.Enabled = false;
                buttonZobrazeniArchivu_PrevestNaOpus.Enabled = false;
                buttonZobrazeniArchivu_PrevestNaOpusMp3.Enabled = false;
                buttonZobrazeniArchivu_PresunDoKnihoven.Enabled = false;
                buttonZobrazeniArchivu_Mp3TagRozbalene.Enabled = false;
                buttonZobrazeniArchivu_Mp3TagOpus.Enabled = false;
                buttonZobrazeniArchivu_Mp3TagMp3.Enabled = false;
                buttonZobrazeniArchivu_Mp3TagVse.Enabled = false;
                buttonZobrazeniArchivu_PrevestNaMp3.Enabled = false;
            }
            labelZobrazeniArchivu_VybraneArchivy.Text += " z " + listViewZobrazeniArchivu_SeznamArchivu.Items.Count;
            if (listViewZobrazeniArchivu_SeznamArchivu.Items.Count <= 0)
            {
                labelZobrazeniArchivu_VybraneArchivy.Text = "Přidejte nějaký archiv";
            }
            else if (listViewZobrazeniArchivu_SeznamArchivu.Items.Count == 1)
            {
                labelZobrazeniArchivu_VybraneArchivy.Text += " archivu";
            }
            else
            {
                labelZobrazeniArchivu_VybraneArchivy.Text += " archivů";
            }
        }

        private void buttonZobrazeniArchivu_VyberVse_Click(object sender, EventArgs e)
        {
            // vybere všechny archivy
            foreach (ListViewItem archiv in listViewZobrazeniArchivu_SeznamArchivu.Items)
            {
                archiv.Checked = true;
            }
        }

        private void buttonZobrazeniArchivu_VyberZrusit_Click(object sender, EventArgs e)
        {
            // zruší výběr archivů
            foreach (ListViewItem vybranyArchiv in listViewZobrazeniArchivu_SeznamArchivu.CheckedItems)
            {
                vybranyArchiv.Checked = false;
            }
        }


        // ZOBRAZENÍ ARCHIVŮ //
        // - tlačítko rozbalení archivů -//

        private void buttonZobrazeniArchivu_Rozbalit_Click(object sender, EventArgs e)
        {
            // 0 název, 1 stav, 2 heslo (někdy skryté), 3 interpret, 4 rok, 5 album, 6 žánr, 7 složka opus, 8 složka mp3, 9 cover
            // tag = heslo, tooltiptext = cesta

            // rozbalí vybrané archivy
            ZobrazStavNovy("rozbalování archivů", false);
            // zkontroluje cestu programu na rozbalení souborů
            ZkontrolujSoubor(comboBoxNastaveni_Rozbaleni.Text, ".exe", labelNastaveni_RozbaleniStav);
            if (!ZkontrolujPredSpoustenim(labelNastaveni_RozbaleniStav.Text, true))
            {
                // je chybná cesta programu
                // -> ukončí rozbalení
                ZobrazStavPosledni("žádný archiv se nepodařilo rozbalit", false);
                ZobrazChybu(labelNastaveni_RozbaleniStav.Text, "Rozbalování archivů");
                return;
            }
            int pocetUspesneRozbalenych = 0;
            foreach (ListViewItem archivKRozbaleni in listViewZobrazeniArchivu_SeznamArchivu.CheckedItems)
            {
                if (String.IsNullOrEmpty(archivKRozbaleni.ToolTipText))
                {
                    // cesta archivu neexistuje
                    ZobrazStavPrubezny("rozbaluji archiv " + archivKRozbaleni.SubItems[0].Text);
                    ZobrazStavPosledni("archiv " + archivKRozbaleni.SubItems[0].Text + " se nepodařilo rozbalit", false);
                    continue;
                }
                ZobrazStavPrubezny("rozbaluji archiv " + archivKRozbaleni.ToolTipText);
                if (archivKRozbaleni.SubItems[1].Text == "0")
                {
                    // stav archivu je 0
                    // tz. není vyplněna složka a další info o archivu
                    ZobrazStavPosledni("archiv " + archivKRozbaleni.SubItems[0].Text + " se nepodařilo rozbalit, doplňte informace o archivu (interpret, album, rok a hudební složky)", false);
                    continue;
                }
                if (archivKRozbaleni.SubItems[1].Text != "1")
                {
                    // stav není 1
                    // archiv byl rozbalen již dříve
                    ZobrazStavPosledni("archiv " + archivKRozbaleni.SubItems[0].Text + " se nepodařilo rozbalit, byl rozbalen již dříve", false);
                    continue;
                }
                if (RozbalArchiv(archivKRozbaleni.ToolTipText, archivKRozbaleni.Tag.ToString()))
                {
                    pocetUspesneRozbalenych++;
                    // stav = 2 = úspěšně rozbaleno
                    archivKRozbaleni.SubItems[1].Text = "2";
                }
            }
            if (pocetUspesneRozbalenych <= 0)
            {
                ZobrazStavPosledni("nepodařilo se rozbalit žádný archiv z " + listViewZobrazeniArchivu_SeznamArchivu.CheckedItems.Count, false);
            }
            else
            {
                ZobrazStavPosledni("úspěšně se podařilo rozbalit " + pocetUspesneRozbalenych + " archivů z " + listViewZobrazeniArchivu_SeznamArchivu.CheckedItems.Count, true);
            }
        }
        private bool RozbalArchiv(string cestaArchivu, string heslo)
        {
            // rozbalí archiv

            // získá cílovou složku rozbalení archivu
            string cilovaSlozka = Path.Combine(slozkaProgramuCache, Path.GetFileNameWithoutExtension(cestaArchivu), "zip");
            try
            {
                // vytvoří složku archivu ve složce "cache"
                if (Directory.Exists(cilovaSlozka))
                {
                    // pokud již existuje
                    // -> smažu ji
                    Directory.Delete(cilovaSlozka, true);
                }
                Directory.CreateDirectory(cilovaSlozka);
            }
            catch (Exception ex)
            {
                ZobrazStavPosledni("archiv " + cestaArchivu + " se nepodařilo rozbalit", false);
                ZobrazChybu(ex.Message, "Rozbalení archivu");
                return false;
            }

            // zkontroluje, zdali se jedná o soubor archivu
            /// DODĚLAT -> přidat další typy souborů ///
            ZkontrolujSoubor(cestaArchivu, new string[] { ".zip", ".rar", ".tar", ".7z" }, labelZobrazeniArchivu_Kontrola);
            if (!ZkontrolujPredSpoustenim(labelZobrazeniArchivu_Kontrola.Text, false))
            {
                ZobrazStavPosledni("archiv " + cestaArchivu + " se nepodařilo rozbalit", false);
                return false;
            }

            if (String.IsNullOrEmpty(heslo))
            {
                // bez hesla
                SpustitProgram(comboBoxNastaveni_Rozbaleni.Text, "e \"" + cestaArchivu + "\" \"" + cilovaSlozka + "\"", true);
            }
            else
            {
                // s heslem
                SpustitProgram(comboBoxNastaveni_Rozbaleni.Text, "e -p\"" + heslo + "\" \"" + cestaArchivu + "\" \"" + cilovaSlozka + "\"", true);
            }

            int pocetRozbalenychSouboru = 0;
            try
            {
                /// DODĚLAT -> přidat kontrolu dle typů souborů ///
                /// -> pokud nalezne další archiv (v rozbaleném archivu), zeptá se uživatele na jeho rozbalení
                /// -> pokud nenalezne žádný hudební soubor -> chyba
                pocetRozbalenychSouboru = Directory.GetFiles(cilovaSlozka, "*.*", SearchOption.AllDirectories).Count();
            }
            catch (Exception ex)
            {
                ZobrazStavPosledni("nepodařilo se zkontrolovat rozbalení archivu" + cestaArchivu, false);
                ZobrazChybu(ex.Message, "Rozbalení archivu");
                return false;
            }
            if (pocetRozbalenychSouboru == 0)
            {
                ZobrazStavPosledni("archiv " + cestaArchivu + " se nepodařilo rozbalit, nebo neobsahoval žádné soubory", false);
                return false;
            }
            ZobrazStavPosledni("archiv " + cestaArchivu + " byl úspěšně rozbalen", true);
            return true;
        }


        // ZOBRAZENÍ ARCHIVŮ //
        // - mp3tag -//

        private void buttonZobrazeniArchivu_Mp3TagRozbalene_Click(object sender, EventArgs e)
        {
            SpustitMp3Tag(false, false);
        }
        private void buttonZobrazeniArchivu_Mp3TagMp3_Click(object sender, EventArgs e)
        {
            SpustitMp3Tag(false, true);
        }
        private void buttonZobrazeniArchivu_Mp3TagOpus_Click(object sender, EventArgs e)
        {
            SpustitMp3Tag(true, false);
        }
        private void buttonZobrazeniArchivu_Mp3TagVse_Click(object sender, EventArgs e)
        {
            SpustitMp3Tag(true, false);
            SpustitMp3Tag(false, true);
        }
        private void SpustitMp3Tag(bool opus, bool mp3)
        {
            string cestaMp3tagu = comboBoxNastaveni_Mp3Tag.Text;
            // spustí mp3tag
            // opus = true -> opus
            // mp3 = true -> mp3
            // opus + mp3 = false -> rozbalené soubory
            if (opus)
            {
                ZobrazStavNovy("otevření souborů opus z archivu v mp3tagu", false);
            }
            else if (mp3)
            {
                ZobrazStavNovy("otevření souborů mp3 z archivu v mp3tagu", false);
            }
            else
            {
                ZobrazStavNovy("otevření rozbalených souborů z archivu v mp3tagu", false);
            }
            // zkontroluje cestu programu na rozbalení souborů
            ZkontrolujSoubor(cestaMp3tagu, ".exe", labelNastaveni_Mp3TagStav);
            if (!ZkontrolujPredSpoustenim(labelNastaveni_Mp3TagStav.Text, true))
            {
                // je chybná cesta programu
                // -> ukončí otevření
                ZobrazStavPosledni("nepodařilo se spustit mp3tag", false);
                ZobrazChybu(labelNastaveni_RozbaleniStav.Text, "Otevření Mp3tagu");
                return;
            }
            foreach (ListViewItem archivKOtevreni in listViewZobrazeniArchivu_SeznamArchivu.CheckedItems)
            {
                if (archivKOtevreni.SubItems[1].Text == "0")
                {
                    // stav archivu je 0
                    // tz. není vyplněna složka a další info o archivu
                    ZobrazStavPosledni("nepodařilo se otevřít soubory v mp3tagu, doplňte informace o archivu (interpret, album, rok a hudební složky)", false);
                    continue;
                }
                if (archivKOtevreni.SubItems[1].Text == "1")
                {
                    // stav je 1, archiv nebyl rozbalen
                    ZobrazStavPosledni("nepodařilo se otevřít soubory v mp3tagu, rozbalte archiv", false);
                    continue;
                }

                string cesta;
                if (archivKOtevreni.SubItems[1].Text == "6")
                {
                    if (mp3)
                    {
                        cesta = archivKOtevreni.SubItems[8].Text;
                    }
                    else if (opus)
                    {
                        cesta = archivKOtevreni.SubItems[7].Text;
                    }
                    else
                    {
                        cesta = Path.Combine(Directory.GetCurrentDirectory(), slozkaProgramuCache, archivKOtevreni.SubItems[0].Text);
                    }
                }
                else
                {
                    cesta = Path.Combine(Directory.GetCurrentDirectory(), slozkaProgramuCache, archivKOtevreni.SubItems[0].Text);
                }

                if (opus)
                {
                    if (archivKOtevreni.SubItems[1].Text == "2" || archivKOtevreni.SubItems[1].Text == "4")
                    {
                        // stav je 2 nebo 4, archiv nebyl převeden na opus
                        ZobrazStavPosledni("nepodařilo se otevřít soubory opus v mp3tagu, převeďte soubory na formát opus", false);
                        continue;
                    }

                    if (archivKOtevreni.SubItems[1].Text != "6")
                    {
                        cesta = Path.Combine(cesta, "opus");
                    }
                    if (Directory.Exists(cesta))
                    {
                        SpustitProgram(cestaMp3tagu, "/fp:\"" + cesta + "\"", false);
                    }
                    else
                    {
                        ZobrazStavPosledni("Složka opus daného archivu neexistuje (" + cesta + ")", false);
                    }
                }
                else if (mp3)
                {
                    if (archivKOtevreni.SubItems[1].Text == "2" || archivKOtevreni.SubItems[1].Text == "3")
                    {
                        // stav je 2 nebo 3, archiv nebyl převeden na mp3
                        ZobrazStavPosledni("nepodařilo se otevřít soubory mp3 v mp3tagu, převeďte soubory na formát mp3", false);
                        continue;
                    }

                    if (archivKOtevreni.SubItems[1].Text != "6")
                    {
                        cesta = Path.Combine(cesta, "mp3");
                    }
                    if (Directory.Exists(cesta))
                    {
                        SpustitProgram(cestaMp3tagu, "/fp:\"" + cesta + "\"", false);
                    }
                    else
                    {
                        ZobrazStavPosledni("Složka mp3 daného archivu neexistuje (" + cesta + ")", false);
                    }
                }
                else
                {
                    cesta = Path.Combine(cesta, "zip");
                    if (Directory.Exists(cesta))
                    {
                        SpustitProgram(cestaMp3tagu, "/fp:\"" + cesta + "\"", false);
                    }
                    else
                    {
                        ZobrazStavPosledni("Složka mp3 daného archivu neexistuje (" + cesta + ")", false);
                    }
                }
            }
        }
        private void checkBoxZobrazeniArchivu_ZobrazitSkrytHesla_CheckedChanged(object sender, EventArgs e)
        {
            // zobrazí / skryje hesla
            if (checkBoxZobrazeniArchivu_ZobrazitSkrytHesla.Checked)
            {
                // zobrazí hesla
                foreach (ListViewItem archiv in listViewZobrazeniArchivu_SeznamArchivu.Items)
                {
                    archiv.SubItems[2].Text = archiv.Tag.ToString();
                }
            }
            else
            {
                foreach (ListViewItem archiv in listViewZobrazeniArchivu_SeznamArchivu.Items)
                {
                    if (!String.IsNullOrEmpty(archiv.SubItems[2].Text))
                    {
                        // skryje hesla, jen tam kde nějaké jsou
                        archiv.SubItems[2].Text = "***";
                    }
                }
            }
        }


        // ZOBRAZENÍ ARCHIVŮ //
        // - převod na mp3 -//

        private void buttonZobrazeniArchivu_PrevestNaMp3_Click(object sender, EventArgs e)
        {            
            if (buttonZobrazeniArchivu_PrevestNaMp3.Text == "Zrušit převod na mp3")
            {
                // je nastaveno zrušení probíhajícího převodu
                backgroundWorkerPrevodNaMp3.CancelAsync();
                ZobrazStavPrubezny("probíhá ukončování převodu na mp3");
                buttonZobrazeniArchivu_PrevestNaMp3.Text = "Probíhá ukončování...";
                buttonZobrazeniArchivu_PrevestNaMp3.Enabled = false;
                return;
            }
            ZobrazStavNovy("převod souborů na formát mp3", false);
            buttonZobrazeniArchivu_PrevestNaMp3.Text = "Zrušit převod na mp3";

            // zkontroluje cestu mp3 enkoderu
            ZkontrolujSoubor(comboBoxNastaveni_Mp3Enkoder.Text, ".exe", labelNastaveni_Mp3EnkoderStav);
            if (!ZkontrolujPredSpoustenim(labelNastaveni_Mp3EnkoderStav.Text, true))
            {
                ZobrazStavPosledni(labelNastaveni_Mp3EnkoderStav.Text, false);
                buttonZobrazeniArchivu_PrevestNaMp3.Text = "Převést na mp3";
                return;
            }
            if (!backgroundWorkerPrevodNaMp3.IsBusy)
            {
                // předáme argumenty backgroundworkeru
                List<ListViewItem> seznamVybranychArchivu = new List<ListViewItem>();
                seznamVybranychArchivu.AddRange(listViewZobrazeniArchivu_SeznamArchivu.CheckedItems.OfType<ListViewItem>());
                List<object> argumenty = new List<object>();
                argumenty.Add(comboBoxNastaveni_Mp3Enkoder.Text);
                argumenty.Add(seznamVybranychArchivu);
                backgroundWorkerPrevodNaMp3.RunWorkerAsync(argumenty);
            }
            else
            {
                ZobrazStavPosledni("chyba převádění souborů", false);
                buttonZobrazeniArchivu_PrevestNaMp3.Text = "Převést na mp3";
            }
        }        

        private void backgroundWorkerPrevodNaMp3_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorkerPrevodNaMp3.CancellationPending)
            {
                // ukončení uživatelem
                e.Cancel = true;
                return;
            }

            // získám předané argumenty
            List<object> predaneArgumenty = e.Argument as List<object>;
            PrevedSoubory("mp3", predaneArgumenty.First().ToString(), (List<ListViewItem>)predaneArgumenty.Last(), backgroundWorkerPrevodNaMp3);

            if (backgroundWorkerPrevodNaMp3.CancellationPending)
            {
                // ukončení uživatelem
                e.Cancel = true;
                return;
            }

            
            /// DODĚLAT ///
            /// přidat kontrolu (nebo získat z backgroundworkeru), jestli byly převedeny soubory
            /// poté mohu dělat toto:
            /*if (archivKPrevodu.SubItems[1].Text == "4")
            {
                // bylo už převedeno na opus
                archivKPrevodu.SubItems[1].Text = "5";
            }
            else
            {
                archivKPrevodu.SubItems[1].Text = "3";
            }
            ZobrazStavPosledni("chyba převádění souborů", false);*/
        }

        private void backgroundWorkerPrevodNaMp3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                ZobrazStavPosledni("převod souborů na mp3 zrušen uživatelem", true);
                buttonZobrazeniArchivu_PrevestNaMp3.Enabled = true;
            }
            else if (e.Error != null)
            {
                ZobrazStavPosledni("převod souborů na mp3 se nezdařil", false);
            }
            else
            {
                ZobrazStavPosledni("převod souborů na mp3 byl úspěšně ukončen", true);
            }
            buttonZobrazeniArchivu_PrevestNaMp3.Text = "Převést na mp3";
        }

        private void buttonZobrazeniArchivu_PrevestNaOpus_Click(object sender, EventArgs e)
        {
            if (buttonZobrazeniArchivu_PrevestNaOpus.Text == "Zrušit převod na opus")
            {
                // je nastaveno zrušení probíhajícího převodu
                backgroundWorkerPrevodNaOpus.CancelAsync();
                ZobrazStavPrubezny("probíhá ukončování převodu na opus");
                buttonZobrazeniArchivu_PrevestNaOpus.Text = "Probíhá ukončování...";
                buttonZobrazeniArchivu_PrevestNaOpus.Enabled = false;
                return;
            }
            ZobrazStavNovy("převod souborů na formát opus", false);
            buttonZobrazeniArchivu_PrevestNaOpus.Text = "Zrušit převod na opus";

            // zkontroluje cestu opus enkoderu
            ZkontrolujSoubor(comboBoxNastaveni_OpusEnkoder.Text, ".exe", labelNastaveni_OpusEnkoderStav);
            if (!ZkontrolujPredSpoustenim(labelNastaveni_OpusEnkoderStav.Text, true))
            {
                ZobrazStavPosledni(labelNastaveni_OpusEnkoderStav.Text, false);
                buttonZobrazeniArchivu_PrevestNaOpus.Text = "Převést na opus";
                return;
            }
            if (!backgroundWorkerPrevodNaOpus.IsBusy)
            {
                // předáme argumenty backgroundworkeru
                List<ListViewItem> seznamVybranychArchivu = new List<ListViewItem>();
                seznamVybranychArchivu.AddRange(listViewZobrazeniArchivu_SeznamArchivu.CheckedItems.OfType<ListViewItem>());
                List<object> argumenty = new List<object>();
                argumenty.Add(comboBoxNastaveni_OpusEnkoder.Text);
                argumenty.Add(seznamVybranychArchivu);
                backgroundWorkerPrevodNaOpus.RunWorkerAsync(argumenty);
            }
            else
            {
                ZobrazStavPosledni("chyba převádění souborů", false);
                buttonZobrazeniArchivu_PrevestNaOpus.Text = "Převést na opus";
            }
        }
        private void backgroundWorkerPrevodNaOpus_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorkerPrevodNaOpus.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            // získám předané argumenty
            List<object> predaneArgumenty = e.Argument as List<object>;
            PrevedSoubory("opus", predaneArgumenty.First().ToString(), (List<ListViewItem>)predaneArgumenty.Last(), backgroundWorkerPrevodNaOpus);

            if (backgroundWorkerPrevodNaOpus.CancellationPending)
            {
                // ukončení uživatelem
                e.Cancel = true;
                return;
            }
        }
        private void backgroundWorkerPrevod_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                // 0 = neúspěšné, 1 = průběžné, 2 = úspěšné
                if (e.ProgressPercentage == 0)
                {
                    ZobrazStavPosledni(e.UserState.ToString(), false);
                }
                else if (e.ProgressPercentage == 1)
                {
                    ZobrazStavPrubezny(e.UserState.ToString());
                }
                else
                {
                    ZobrazStavPosledni(e.UserState.ToString(), true);
                }
            }
        }
        private void backgroundWorkerPrevodNaOpus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                ZobrazStavPosledni("převod souborů na opus zrušen uživatelem", true);
                buttonZobrazeniArchivu_PrevestNaOpus.Enabled = true;
            }
            else if (e.Error != null)
            {
                ZobrazStavPosledni("převod souborů na opus se nezdařil", false);
            }
            else
            {
                ZobrazStavPosledni("převod souborů na opus byl úspěšně ukončen", true);
            }
            buttonZobrazeniArchivu_PrevestNaOpus.Text = "Převést na opus";
        }

        private void PrevedSoubory(string typSouboru, string enkoder, List<ListViewItem> archivyKPrevodu, BackgroundWorker prevadec)
        {
            // procházím vybrané archivy
            foreach (ListViewItem archivKPrevodu in archivyKPrevodu)
            {
                string nazevArchivu = archivKPrevodu.SubItems[0].Text;
                string cestaArchivuZip = Path.Combine(slozkaProgramuCache, nazevArchivu, "zip");
                string cestaArchivuTyp = Path.Combine(slozkaProgramuCache, nazevArchivu, typSouboru);

                prevadec.ReportProgress(1, "převádím archiv " + nazevArchivu + " na " + typSouboru);

                // 1. kontrola stavu archivu
                if (archivKPrevodu.SubItems[1].Text == "0")
                {
                    // stav archivu je 0
                    // tz. není vyplněna složka a další info o archivu
                    prevadec.ReportProgress(0, "archiv " + nazevArchivu + " se nepodařilo převést na " + typSouboru + ", doplňte informace o archivu (interpret, album, rok a hudební složky)");
                    continue;
                }
                if (archivKPrevodu.SubItems[1].Text == "1")
                {
                    // stav je 1, archiv nebyl rozbalen
                    prevadec.ReportProgress(0, "archiv " + nazevArchivu + " se nepodařilo převést na " + typSouboru + ", rozbalte archiv");
                    continue;
                }
                if (archivKPrevodu.SubItems[1].Text == "5" ||
                    (typSouboru == "opus" && archivKPrevodu.SubItems[1].Text == "3") ||
                    (typSouboru == "mp3" && archivKPrevodu.SubItems[1].Text == "4"))
                {
                    // stav je 1, archiv nebyl rozbalen
                    prevadec.ReportProgress(0, "archiv " + nazevArchivu + " již byl převeden dříve na " + typSouboru);
                    continue;
                }

                // 2. kontrola složek archivu
                try
                {
                    if (!Directory.Exists(cestaArchivuTyp))
                    {
                        Directory.CreateDirectory(cestaArchivuTyp);
                    }
                }
                catch (Exception ex)
                {
                    prevadec.ReportProgress(0, "archiv " + nazevArchivu + " se nepodařilo převést na " + typSouboru);
                    ZobrazChybu(ex.Message, "Převod souborů na " + typSouboru);
                    continue;
                }

                // 3. získání souborů ze složky

                // a) mp3/opus soubory
                string[] souborySlozka = Directory.GetFiles(cestaArchivuZip, "*." + typSouboru, SearchOption.AllDirectories);
                int pocetJizExistujicich = 0;

                if (souborySlozka.Count() > 0)
                {
                    // nalezené soubory mp3/opus nakopíruje do složky "mp3/opus"
                    // přesunu do složky mp3/opus

                    // zkopíruje soubory ze složky ("cesta") do složky dle typu (mp3 / opus)
                    int pocetPresunutych = 0;

                    foreach (string souborTyp in souborySlozka)
                    {
                        if (prevadec.CancellationPending)
                        {
                            return;
                        }
                        if (File.Exists(Path.Combine(cestaArchivuTyp, Path.GetFileNameWithoutExtension(souborTyp) + "." + typSouboru)))
                        {
                            // již existuje soubor se stejným názvem ve složce mp3
                            prevadec.ReportProgress(0, "Soubor " + souborTyp + " byl přesunut do hudební složky " + typSouboru + " již dříve");
                            pocetJizExistujicich++;
                            continue;
                        }
                        prevadec.ReportProgress(1, "přesunuji soubor " + souborTyp);
                        // projdu soubory a přesunu
                        try
                        {
                            File.Copy(souborTyp, Path.Combine(Path.GetDirectoryName(cestaArchivuZip), typSouboru, Path.GetFileName(souborTyp)));
                        }
                        catch (Exception ex)
                        {
                            prevadec.ReportProgress(0, "Soubor " + souborTyp + " se nepodařilo přesunout");
                            ZobrazChybu(ex.Message, "Přesunování souboru");
                            continue;
                        }
                        prevadec.ReportProgress(2, "Soubor " + souborTyp + " byl přesunut do hudební složky " + typSouboru);
                        pocetPresunutych++;
                    }
                    prevadec.ReportProgress(2, "bylo přesunuto " + pocetPresunutych + " souborů " + typSouboru + " (z " + souborySlozka.Count() + " nalezených souborů)");
                }

                // b) jiné soubory (".wma" | ".ogg" | ".acc" | ".mpc" | ".flac" | ".alac" | ".wavpack" | ".tak" | ".wma" | ".wav" | ".m4a" ...)
                souborySlozka = Directory.GetFiles(cestaArchivuZip, "*.*", SearchOption.AllDirectories);

                if (souborySlozka.Count() > 0)
                {
                    // existují ostatní soubory
                    int pocetPrevedenych = 0;
                    foreach (string souborOstatni in souborySlozka)
                    {
                        if (prevadec.CancellationPending)
                        {
                            // ukončení uživatelem
                            return;
                        }
                        if (File.Exists(Path.Combine(cestaArchivuTyp, Path.GetFileNameWithoutExtension(souborOstatni) + "." + typSouboru)))
                        {
                            // již existuje soubor se stejným názvem ve složce mp3
                            prevadec.ReportProgress(0, "soubor " + Path.GetFileName(souborOstatni) + " byl převeden již dříve na " + typSouboru);
                            pocetJizExistujicich++;
                            continue;
                        }

                        string souborOstatniKoncovka = Path.GetExtension(souborOstatni);
                        // abych mohl převést i soubory opus na mp3 / / mp3 na opus
                        string koncovkaOstatni = "";
                        if (typSouboru == "opus")
                        {
                            koncovkaOstatni = ".mp3";
                        }
                        else
                        {
                            koncovkaOstatni = ".opus";
                        }
                        if (souborOstatniKoncovka == ".wma" || souborOstatniKoncovka == ".ogg" || souborOstatniKoncovka == ".flac" ||
                            souborOstatniKoncovka == ".mpc" || souborOstatniKoncovka == ".acc" || souborOstatniKoncovka == ".alac" ||
                            souborOstatniKoncovka == ".tak" || souborOstatniKoncovka == ".wma" || souborOstatniKoncovka == ".wavpack" ||
                            souborOstatniKoncovka == ".wav" || souborOstatniKoncovka == ".m4a" || souborOstatniKoncovka == koncovkaOstatni)
                        {
                            prevadec.ReportProgress(1, "převádím soubor " + Path.GetFileName(souborOstatni));


                            string parametry = "";
                            if (typSouboru == "mp3")
                            {
                                parametry = "-i \"" + Path.Combine(cestaArchivuZip, Path.GetFileName(souborOstatni)) + "\" -acodec libmp3lame -ab 320k \""
                                                    + Path.Combine(cestaArchivuTyp, Path.GetFileNameWithoutExtension(souborOstatni)) + "." + typSouboru + "\"";
                            }
                            else
                            {
                                parametry = "-y -i \"" + Path.Combine(cestaArchivuZip, Path.GetFileName(souborOstatni)) + "\" -acodec libopus -b:a 128000 -vbr on -compression_level 10 -map a \""
                                                       + Path.Combine(cestaArchivuTyp, Path.GetFileNameWithoutExtension(souborOstatni)) + ".opus\"";
                            }

                            Process cmd = new Process();
                            ProcessStartInfo psi = new ProcessStartInfo();

                            psi.Arguments = parametry;
                            psi.WindowStyle = ProcessWindowStyle.Maximized;
                            psi.FileName = enkoder;
                            psi.UseShellExecute = false;
                            //psi.WorkingDirectory = "cache";

                            psi.CreateNoWindow = true;
                            psi.ErrorDialog = true;
                            psi.RedirectStandardInput = true;
                            psi.RedirectStandardOutput = true;
                            
                            cmd.StartInfo = psi;
                            cmd.Start();
                            cmd.WaitForExit();
                            pocetPrevedenych++;
                            prevadec.ReportProgress(2, "soubor " + Path.GetFileName(souborOstatni) + " byl úspěšně převeden na " + typSouboru);
                        }
                    }
                    prevadec.ReportProgress(2, "bylo převedeno " + pocetPrevedenych + " souborů " + typSouboru + " (z " + souborySlozka.Count() + " nalezených souborů)");
                }
                prevadec.ReportProgress(2, "bylo nalezeno " + pocetJizExistujicich + " již dříve převedených souborů " + typSouboru);

                listViewZobrazeniArchivu_SeznamArchivu.Invoke(new Action(() =>
                {
                    // uložení stavu
                    if (archivKPrevodu.SubItems[1].Text == "3" || (archivKPrevodu.SubItems[1].Text == "4"))
                    {
                        // archiv byl dříve převeden na opus nebo mp3
                        archivKPrevodu.SubItems[1].Text = "5";
                        // nyní je převeden na oboje
                    }
                    else if (archivKPrevodu.SubItems[1].Text == "2")
                    {
                        // archiv byl dříve rozbalen
                        if (typSouboru == "opus")
                        {
                            // převedeno na opus
                            archivKPrevodu.SubItems[1].Text = "3";
                        }
                        else
                        {
                            // převedeno na mp3
                            archivKPrevodu.SubItems[1].Text = "4";
                        }
                    }
                }));
                
            }
        }

        private void buttonZobrazeniArchivu_PresunDoKnihoven_Click(object sender, EventArgs e)
        {
            if (buttonZobrazeniArchivu_PresunDoKnihoven.Text == "Zrušit přesun do knihoven")
            {
                // je nastaveno zrušení probíhajícího převodu
                backgroundWorkerPresunDoKnihoven.CancelAsync();
                ZobrazStavPrubezny("probíhá ukončování přesunu souborů");
                buttonZobrazeniArchivu_PresunDoKnihoven.Text = "Probíhá ukončování...";
                buttonZobrazeniArchivu_PresunDoKnihoven.Enabled = false;
                return;
            }
            ZobrazStavNovy("převos souborů do knihoven", false);
            buttonZobrazeniArchivu_PresunDoKnihoven.Text = "Zrušit přesun do knihoven";

            if (!backgroundWorkerPresunDoKnihoven.IsBusy)
            {
                // předáme list vybraných archivů backgroundworkeru
                List<ListViewItem> seznamVybranychArchivu = new List<ListViewItem>();
                seznamVybranychArchivu.AddRange(listViewZobrazeniArchivu_SeznamArchivu.CheckedItems.OfType<ListViewItem>());
                backgroundWorkerPresunDoKnihoven.RunWorkerAsync(seznamVybranychArchivu);
            }
            else
            {
                ZobrazStavPosledni("chyba přesunování souborů", false);
                buttonZobrazeniArchivu_PresunDoKnihoven.Text = "Přesunout do knihoven";
            }
        }

        private void backgroundWorkerPresunDoKnihoven_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorkerPresunDoKnihoven.CancellationPending)
            {
                // ukončení uživatelem
                e.Cancel = true;
                return;
            }

            // získám předané seznam archivů
            List<ListViewItem> archivy = e.Argument as List<ListViewItem>;
            foreach (ListViewItem archiv in archivy)
            {
                if (backgroundWorkerPresunDoKnihoven.CancellationPending)
                {
                    // ukončení uživatelem
                    e.Cancel = true;
                    return;
                }
                // 0 název, 1 stav, 2 heslo (někdy skryté), 3 interpret, 4 rok, 5 album, 6 žánr, 7 složka opus, 8 složka mp3, 9 cover
                // tag = heslo, tooltiptext = cesta

                // 1. kontrola stavu archivu
                if (archiv.SubItems[1].Text == "0")
                {
                    // stav archivu je 0
                    // tz. není vyplněna složka a další info o archivu
                    backgroundWorkerPresunDoKnihoven.ReportProgress(0, "rozbalené soubory z archivu se nepodařilo přesunout, doplňte informace o archivu (interpret, album, rok a hudební složky)");
                    continue;
                }
                if (archiv.SubItems[1].Text == "1")
                {
                    // stav je 1, archiv nebyl rozbalen
                    backgroundWorkerPresunDoKnihoven.ReportProgress(0, "rozbalené soubory z archivu se nepodařilo přesunout, rozbalte archiv");
                    continue;
                }
                if (archiv.SubItems[1].Text == "2" ||
                    archiv.SubItems[1].Text == "3" ||
                    archiv.SubItems[1].Text == "4")
                {
                    // stav je 1, archiv nebyl rozbalen
                    backgroundWorkerPresunDoKnihoven.ReportProgress(0, "rozbalené soubory z archivu se nepodařilo přesunout, převeďte je na opus i mp3");
                    continue;
                }

                string nazevArchivu = archiv.SubItems[0].Text;
                string slozkaOpus = archiv.SubItems[7].Text;
                string slozkaMp3 = archiv.SubItems[8].Text;
                string cover = Path.Combine(slozkaProgramuCache, nazevArchivu, archiv.SubItems[9].Text);
                if (!PresunDoSlozky("opus", nazevArchivu, slozkaOpus, cover))
                {
                    return;
                }
                if (!PresunDoSlozky("mp3", nazevArchivu, slozkaMp3, cover))
                {
                    return;
                }
                listViewZobrazeniArchivu_SeznamArchivu.Invoke(new Action(() =>
                {
                    // uložení stavu
                    archiv.SubItems[1].Text = "6";
                }));
            }
        }

        private bool PresunDoSlozky(string typ, string nazevArchivu, string cilovaSlozka, string cover)
        {
            backgroundWorkerPresunDoKnihoven.ReportProgress(1, "přesunuji soubory " + typ + " z archivu " + nazevArchivu);

            // získá soubory ze složky archivu ("cache/nazevarchivu/opus" nebo "../mp3")
            string pocatecniSlozka = Path.Combine(slozkaProgramuCache, nazevArchivu, typ);
            string[] souboryVPocatecniSlozce = Directory.GetFiles(pocatecniSlozka, "*." + typ, SearchOption.AllDirectories);            

            if (!Directory.Exists(cilovaSlozka))
            {
                try
                {
                    Directory.CreateDirectory(cilovaSlozka);
                }
                catch (Exception ex)
                {
                    ZobrazStavPosledni("soubory se nepodařilo přesunout", false);
                    ZobrazChybu(ex.Message, "přesun souborů");
                    return false;
                }
            }

            if (File.Exists(cover))
            {
                // existuje cover
                // zkopíruji ho do složky
                backgroundWorkerPresunDoKnihoven.ReportProgress(1, "kopíruji cover");
                string coverCil = Path.Combine(cilovaSlozka, Path.GetFileName(cover));
                if (File.Exists(coverCil))
                {
                    // existuje v cílové složce
                    backgroundWorkerPresunDoKnihoven.ReportProgress(0, "cover se nepodařilo zkopírovat, protože již existuje v cílové složce");
                }
                else
                {
                    // zkopíruji cover
                    try
                    {
                        File.Copy(cover, coverCil);
                    }
                    catch (Exception ex)
                    {
                        backgroundWorkerPresunDoKnihoven.ReportProgress(0, "cover se nepodařilo zkopírovat");
                        ZobrazChybu(ex.Message, "Kopírovaní coveru");
                    }
                }
            }

            int pocetKPresunuti = souboryVPocatecniSlozce.Count();
            int pocetPresunutych = 0;
            int pocetExistujicich = 0;

            foreach (string cestaSouboruPocatecni in souboryVPocatecniSlozce)
            {
                // projde soubory ve složce "cache"
                backgroundWorkerPresunDoKnihoven.ReportProgress(1, "přesunuji soubor " + cestaSouboruPocatecni);

                string cestaSouboruCilova = Path.Combine(cilovaSlozka, Path.GetFileName(cestaSouboruPocatecni));
                if (File.Exists(cestaSouboruCilova))
                {
                    // existuje stejný soubor v cílové složce
                    pocetExistujicich++;
                    backgroundWorkerPresunDoKnihoven.ReportProgress(0, "soubor nebyl přesunut, protože existuje stejný v cílové složce");
                }
                else
                {
                    // soubor neexistuje
                    // mohu ho přesunout
                    if (PresunSoubor(cestaSouboruPocatecni, cestaSouboruCilova))
                    {
                        pocetPresunutych++;
                    }
                    else
                    {
                        backgroundWorkerPresunDoKnihoven.ReportProgress(0, "soubor se nepodařilo přesunout");
                    }
                }
            }
            backgroundWorkerPresunDoKnihoven.ReportProgress(1, "bylo přesunuto " + pocetPresunutych + " souborů (z " + pocetKPresunuti + ")");
            if (pocetExistujicich > 0)
            {
                backgroundWorkerPresunDoKnihoven.ReportProgress(0, "nebylo přesunuto " + pocetExistujicich + " již existujících souborů (z " + pocetKPresunuti + ")");
            }
            return true;
        }

        private void backgroundWorkerPresunDoKnihoven_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                if (e.ProgressPercentage == 0)
                {
                    ZobrazStavPosledni(e.UserState.ToString(), false);
                }
                else
                {
                    ZobrazStavPrubezny(e.UserState.ToString());
                }
            }
        }

        private void backgroundWorkerPresunDoKnihoven_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                ZobrazStavPosledni("přesun souborů zrušen uživatelem", true);
                buttonZobrazeniArchivu_PresunDoKnihoven.Enabled = true;
            }
            else if (e.Error != null)
            {
                ZobrazStavPosledni("přesun souborů se nezdařil", false);
            }
            else
            {
                ZobrazStavPosledni("přesun souborů byl úspěšně ukončen", true);
            }
            buttonZobrazeniArchivu_PresunDoKnihoven.Text = "Přesunout do knihoven";
        }

        private void buttonZobrazeniArchivu_PrevestNaOpusMp3_Click(object sender, EventArgs e)
        {
            /// ******* ///
            /// DODĚLAT ///
            /// ******* ///

            if (buttonZobrazeniArchivu_PrevestNaOpusMp3.Text == "Převést na opus a mp3")
            {
                buttonZobrazeniArchivu_PrevestNaOpusMp3.Text = "Zrušit převod";
                // převede soubory na opus a mp3
            }
            else
            {
                // zastaví převod
                buttonZobrazeniArchivu_PrevestNaOpusMp3.Text = "Převést na opus a mp3";
            }
            buttonZobrazeniArchivu_PrevestNaOpus_Click(null, null);
            buttonZobrazeniArchivu_PrevestNaMp3_Click(null, null);
        }

        private void listViewPridaniSlozky_SeznamArchivu_DragDrop(object sender, DragEventArgs e)
        {
            // povoluje přetažení složek/archivů na listview

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] pretazenePolozky = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string pretazenaPolozka in pretazenePolozky)
                {
                    if (Directory.Exists(pretazenaPolozka))
                    {
                        comboBoxPridaniSlozky_Slozka.Text = pretazenaPolozka;

                        // přidání složky do comboboxu se seznamem cest k již dříve otevřeným složkám
                        PridejCestu(comboBoxPridaniSlozky_Slozka.Text, comboBoxPridaniSlozky_Slozka, false);
                        // kontrola složky (zdali existuje)
                        ZkontrolujSlozku(comboBoxPridaniSlozky_Slozka.Text, false, labelPridaniSlozky_Stav);

                        NactiArchivyZeSlozky(pretazenaPolozka);
                    }
                    else if (File.Exists(pretazenaPolozka))
                    {
                        ZobrazStavNovy("přidávání archivů", false);
                        int pridano = PridejArchivNaSeznam(pretazenaPolozka);
                        if (pridano == 1)
                        {
                            ZobrazStavPosledni("archiv \"" + pretazenaPolozka + "\" nebyl přidán, protože byl přidán dříve", false);
                        }
                        else if (pridano == 2)
                        {
                            ZobrazStavPosledni("archiv \"" + pretazenaPolozka + "\" úšpěšně přidán", true);
                        }
                        else
                        {
                            ZobrazStavPosledni("archiv \"" + pretazenaPolozka + "\" nebyl přidán, protože se nejedná o podporovaný typ souboru", false);
                        }
                    }
                    else
                    {
                        ZobrazStavNovy("přidávání archivů", false);
                        ZobrazStavPosledni("archiv \"" + pretazenaPolozka + "\" nebyl přidán, protože se nejedná o podporovaný typ souboru", false);
                    }
                }
            }
        }

        private void prvek_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }            
        }

        private void comboBoxSlozka_DragDrop(object sender, DragEventArgs e)
        {
            // povoluje přetažení složek na combobox

            ComboBox comboBoxPridani = (ComboBox)sender;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] pretazeneSlozky = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string pretazenaSlozka in pretazeneSlozky)
                {
                    if (Directory.Exists(pretazenaSlozka))
                    {
                        // přidá pouze první existující složku
                        comboBoxPridani.Text = pretazenaSlozka;                   
                        return;
                    }
                }
            }
        }

        private void comboBoxSoubor_DragDrop(object sender, DragEventArgs e)
        {
            // povoluje přetažení souborů na combobox

            ComboBox comboBoxPridani = (ComboBox)sender;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] pretazeneSoubory = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string pretazenySoubor in pretazeneSoubory)
                {
                    if (File.Exists(pretazenySoubor))
                    {

                        // přidá pouze první existující soubor

                        /// DODĚLAT -> NEKONTROLUJE A NEPŘIDÁVÁ DO COMBOPBOXU
                        comboBoxPridani.Text = pretazenySoubor;
                    }
                }
            }
        }
    }
}

/*

    0 = přidán archiv
    1 = vyplněna složka (interpret, album, rok)
    2 = archiv rozbalen
    3 = převedeno na mp3
    4 = převedeno na opus
    5 = 1 + 2 + 3 + 4
    6 = přesunuto do knihovny

    musí být splněno
    -> 0
    -> 1
    -> 2
    2 -> 3
    2 -> 4
    1, 2, 3, 4 -> 6

    mohu dělat ze stavu
    1, 2, 3, 4, 5 -> 1
    1 -> 2
    2, 4 -> 3
    2, 3 -> 4
    1 + 2 + 3 + 4 -> 5
    5 (=1+2+3+4) -> 6

    staré*****
    1 = vyplněna složka (interpret, album, rok)
      -> připraveno k rozbalení

    2 = úspěšně rozbaleno
      -> připraveno k převodu na mp3 nebo opus

    3 = převedeno na mp3
      -> mohu otevřít mp3 v mp3tagu

    4 = převedeno na opus
      -> mohu otevřít opus v mp3tagu

    5 = převedeno na opus i mp3
      -> mohu otevřít mp3 a opus (vše) v mp3tagu
      -> připraveno na přesun do knihoven

    6 = přesunuto do knihovny

*/
