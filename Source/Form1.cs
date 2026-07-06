using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace CrispyMasterMenu
{
    public partial class Form1 : Form
    {
        private System.Drawing.Image imagen1;
        private System.Drawing.Image imagen2;
        private System.Drawing.Image imagen3;
        private System.Drawing.Image imagen4;
        private System.Drawing.Image imagen5;
        private System.Drawing.Image imagen6;
        private System.Drawing.Image imagen7;
        private System.Drawing.Image imagen8;
        private System.Drawing.Image imagen9;
        private System.Drawing.Image imagen10;
        private System.Drawing.Image imagen11;
        private System.Drawing.Image imagen12;
        private System.Drawing.Image imagen13;
        private System.Drawing.Image imagen14;
        private System.Drawing.Image imagen15;
        private System.Drawing.Image imagen16;
        private System.Drawing.Image imagen17;
        private System.Drawing.Image imagen18;
        private System.Drawing.Image imagen19;
        private System.Drawing.Image imagen20;
        private System.Drawing.Image imagen21;
        private System.Drawing.Image imagen22;
        private System.Drawing.Image imagen23;
        private System.Drawing.Image imagen24;
        private System.Drawing.Image imagen25;
        private System.Drawing.Image imagen26;
        private System.Drawing.Image imagen27;
        private System.Drawing.Image imagen28;
        private System.Drawing.Image imagen29;
        private System.Drawing.Image imagen30;
        private System.Drawing.Image imagen31;
        private System.Drawing.Image imagen32;
        private System.Drawing.Image imagen33;
        private System.Drawing.Image imagen34;
        private System.Drawing.Image imagen35;
        private System.Drawing.Image imagen36;
        private System.Drawing.Image imagen37;
        private System.Drawing.Image imagen38;
        private System.Drawing.Image imagen39;
        private System.Drawing.Image imagen40;
        private System.Drawing.Image imagen41;
        private System.Drawing.Image imagen42;

        private int _lastFormSize;

        private const string MasterServerUrl = "https://master.chocolate-doom.org/";



        private System.Drawing.Color currentMSDOSBackground = System.Drawing.Color.Navy;
        private System.Drawing.Color currentMSDOSText = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Menu);

       
        private int backgroundBrightnessPercent = 50;
        private int textBrightnessPercent = 50;

        
        private readonly System.Drawing.Color[] MSDOSBackgroundBasePalette = new System.Drawing.Color[]
        {
    System.Drawing.Color.Black,       System.Drawing.Color.Green,        System.Drawing.Color.Navy,       System.Drawing.Color.Teal,
    System.Drawing.Color.Maroon,      System.Drawing.Color.Purple,      System.Drawing.Color.Olive,       System.Drawing.Color.Silver,
    System.Drawing.Color.FromArgb(80, 85, 90),     
    System.Drawing.Color.FromArgb(40, 95, 160),    
    System.Drawing.Color.FromArgb(50, 145, 80),    
    System.Drawing.Color.FromArgb(45, 125, 145),   
    System.Drawing.Color.FromArgb(150, 60, 60),    
    System.Drawing.Color.FromArgb(125, 65, 135),   
    System.Drawing.Color.FromArgb(170, 145, 65),   
    System.Drawing.Color.FromArgb(235, 232, 224)    
        };

        
        private readonly System.Drawing.Color[] MSDOSTextBasePalette = new System.Drawing.Color[]
        {
    System.Drawing.Color.Black,                      System.Drawing.Color.FromArgb(35, 85, 225),
    System.Drawing.Color.FromArgb(35, 185, 70),      System.Drawing.Color.FromArgb(40, 165, 185),
    System.Drawing.Color.FromArgb(225, 50, 50),      System.Drawing.Color.FromArgb(185, 45, 205),
    System.Drawing.Color.FromArgb(195, 165, 50),     System.Drawing.Color.FromArgb(235, 230, 220),
    System.Drawing.Color.FromArgb(150, 155, 160),    System.Drawing.Color.FromArgb(100, 180, 255),
    System.Drawing.Color.FromArgb(110, 245, 150),    System.Drawing.Color.FromArgb(100, 230, 255),
    System.Drawing.Color.FromArgb(255, 120, 120),    System.Drawing.Color.FromArgb(235, 140, 255),
    System.Drawing.Color.FromArgb(255, 230, 115),    System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Menu),
        };









        public Form1()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            InitializeComponent();
            ConfigurarRichTextBox();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);


            imagen1 = Properties.Resources.doom2;
            imagen2 = Properties.Resources.ATTACK;
            imagen3 = Properties.Resources.doom2;
            imagen4 = Properties.Resources.BLACKTWR;
            imagen5 = Properties.Resources.doom2;
            imagen6 = Properties.Resources.BLOODSEA;
            imagen7 = Properties.Resources.doom2;
            imagen8 = Properties.Resources.CANYON;
            imagen9 = Properties.Resources.doom2;
            imagen10 = Properties.Resources.CATWALK;
            imagen11 = Properties.Resources.doom2;
            imagen12 = Properties.Resources.COMBINE;
            imagen13 = Properties.Resources.doom2;
            imagen14 = Properties.Resources.FISTULA;
            imagen15 = Properties.Resources.doom2;
            imagen16 = Properties.Resources.GARRISON;
            imagen17 = Properties.Resources.doom2;
            imagen18 = Properties.Resources.GERYON;
            imagen19 = Properties.Resources.doom2;
            imagen20 = Properties.Resources.MANOR;
            imagen21 = Properties.Resources.doom2;
            imagen22 = Properties.Resources.MEPHISTO;
            imagen23 = Properties.Resources.doom2;
            imagen24 = Properties.Resources.MINOS;
            imagen25 = Properties.Resources.doom2;
            imagen26 = Properties.Resources.NESSUS;
            imagen27 = Properties.Resources.doom2;
            imagen28 = Properties.Resources.PARADOX;
            imagen29 = Properties.Resources.doom2;
            imagen30 = Properties.Resources.SUBSPACE;
            imagen31 = Properties.Resources.doom2;
            imagen32 = Properties.Resources.SUBTERRA;
            imagen33 = Properties.Resources.doom2;
            imagen34 = Properties.Resources.TEETH31;
            imagen35 = Properties.Resources.doom2;
            imagen36 = Properties.Resources.TTRAP;
            imagen37 = Properties.Resources.doom2;
            imagen38 = Properties.Resources.VESPERAS;
            imagen39 = Properties.Resources.doom2;
            imagen40 = Properties.Resources.VIRGIL;
            imagen41 = Properties.Resources.doom2;
            imagen42 = Properties.Resources.BAD;


            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            button3.MouseEnter += button3_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;
            button4.MouseEnter += button4_MouseEnter;
            button4.MouseLeave += button4_MouseLeave;
            button5.MouseEnter += button5_MouseEnter;
            button5.MouseLeave += button5_MouseLeave;
            button6.MouseEnter += button6_MouseEnter;
            button6.MouseLeave += button6_MouseLeave;
            button7.MouseEnter += button7_MouseEnter;
            button7.MouseLeave += button7_MouseLeave;
            button8.MouseEnter += button8_MouseEnter;
            button8.MouseLeave += button8_MouseLeave;
            button9.MouseEnter += button9_MouseEnter;
            button9.MouseLeave += button9_MouseLeave;
            button10.MouseEnter += button10_MouseEnter;
            button10.MouseLeave += button10_MouseLeave;
            button11.MouseEnter += button11_MouseEnter;
            button11.MouseLeave += button11_MouseLeave;
            button12.MouseEnter += button12_MouseEnter;
            button12.MouseLeave += button12_MouseLeave;
            button13.MouseEnter += button13_MouseEnter;
            button13.MouseLeave += button13_MouseLeave;
            button14.MouseEnter += button14_MouseEnter;
            button14.MouseLeave += button14_MouseLeave;
            button15.MouseEnter += button15_MouseEnter;
            button15.MouseLeave += button15_MouseLeave;
            button16.MouseEnter += button16_MouseEnter;
            button16.MouseLeave += button16_MouseLeave;
            button17.MouseEnter += button17_MouseEnter;
            button17.MouseLeave += button17_MouseLeave;
            button18.MouseEnter += button18_MouseEnter;
            button18.MouseLeave += button18_MouseLeave;
            button19.MouseEnter += button19_MouseEnter;
            button19.MouseLeave += button19_MouseLeave;
            button20.MouseEnter += button20_MouseEnter;
            button20.MouseLeave += button20_MouseLeave;
            button21.MouseEnter += button21_MouseEnter;
            button21.MouseLeave += button21_MouseLeave;


            this.button24.Enabled = false;
            button24.Text = "";
            this.comboBox1.Enabled = false;
            textBox27.Enabled = false;
            textBox28.Enabled = false;
            this.comboBox7.Enabled = false;
            this.comboBox11.Enabled = false;
            textBox18.Enabled = false;
           
            this.listBox1.Visible = false;
            button25.Enabled = false;
            button25.Text = "";
            textBox29.Visible = false;
            textBox32.Visible = false;
            textBox34.Visible = false;
            textBox37.Visible = false;
            textBox38.Visible = false;
            textBox39.Visible = false;



            this.Resize += new EventHandler(Form1_Resize);
            _lastFormSize = GetFormArea(this.Size);
            listBox1.SelectionMode = SelectionMode.MultiExtended;


            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "FullName";

        }
        public class Item
        {
            public string Name { get; set; }
            public string Value { get; set; }

            public Item(string name, string value)
            {
                Name = name;
                Value = value;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {

            string assemblyName = new AssemblyName(args.Name).Name + ".dll";


            string resourceName = $"{typeof(Form1).Namespace}.{assemblyName}";

            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    byte[] assemblyData = new byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            }
            return null;
        }

        private System.Drawing.Color AdjustColorLuminance(System.Drawing.Color baseColor, int brightnessPercent)
        {
            
            int lightOffset = (brightnessPercent - 50) * 4;

            int r = System.Math.Max(0, System.Math.Min(baseColor.R + lightOffset, 255));
            int g = System.Math.Max(0, System.Math.Min(baseColor.G + lightOffset, 255));
            int b = System.Math.Max(0, System.Math.Min(baseColor.B + lightOffset, 255));

            return System.Drawing.Color.FromArgb(r, g, b);
        }



        private void ApplyGlobalTheme(System.Windows.Forms.Control mainControl, System.Drawing.Color backgroundColor, System.Drawing.Color textColor, System.Drawing.Color inputFieldsColor, System.Drawing.Color customHover)
        {
            
            if (mainControl is System.Windows.Forms.Form)
            {
                return;
            }

            
            if (mainControl is System.Windows.Forms.ComboBox)
            {
                return;
            }

           
            if (mainControl.Name == "button22" || mainControl.Name == "button23" || mainControl.Name == "button24" ||
                mainControl.Name == "button25" || mainControl.Name == "button29" || mainControl.Name == "button30" ||
                mainControl.Name == "textBox28" || mainControl.Name == "listBox1" || mainControl.Name == "textBox11" ||
                mainControl.Name == "textBox29" || mainControl.Name == "textBox19" || mainControl.Name == "textBox12" ||
                mainControl.Name == "textBox27" || mainControl.Name == "textBox23" || mainControl.Name == "textBox34" ||
                mainControl.Name == "textBox24" || mainControl.Name == "textBox25" || mainControl.Name == "textBox18" ||
                mainControl.Name == "textBox14" || mainControl.Name == "textBox32" || mainControl.Name == "textBox20" ||
                mainControl.Name == "textBox17" || mainControl.Name == "textBox37" || mainControl.Name == "textBox38" ||
                mainControl.Name == "textBox39" || mainControl.Name == "listBoxBackground" || mainControl.Name == "listBoxText")
            
            {

                
                if (mainControl is System.Windows.Forms.Button targetWhitelistButton)
                {
                    targetWhitelistButton.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Control);
                    targetWhitelistButton.ForeColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ControlText);
                    targetWhitelistButton.UseVisualStyleBackColor = true;
                }
                else if (mainControl is System.Windows.Forms.TextBox targetWhitelistTextBox)
                {
                    targetWhitelistTextBox.BackColor = System.Drawing.Color.White;
                    targetWhitelistTextBox.ForeColor = System.Drawing.Color.Black;
                    targetWhitelistTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
                else if (mainControl is System.Windows.Forms.ListBox targetWhitelistListBox)
                {
                    targetWhitelistListBox.BackColor = System.Drawing.Color.White;
                    targetWhitelistListBox.ForeColor = System.Drawing.Color.Black;
                }

                return; 
            }

           
            if (mainControl is System.Windows.Forms.TextBox)
            {
                System.Windows.Forms.TextBox targetTextBox = (System.Windows.Forms.TextBox)mainControl;
                targetTextBox.BackColor = backgroundColor; 
                targetTextBox.ForeColor = textColor;
                targetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None; 
            }
            else if (mainControl is System.Windows.Forms.RichTextBox)
            {
                System.Windows.Forms.RichTextBox targetRichText = (System.Windows.Forms.RichTextBox)mainControl;
                targetRichText.BackColor = backgroundColor; 
                targetRichText.ForeColor = textColor;
                targetRichText.BorderStyle = System.Windows.Forms.BorderStyle.None; 
            }
           
            else if (mainControl is System.Windows.Forms.Button)
            {
                System.Windows.Forms.Button targetButton = (System.Windows.Forms.Button)mainControl;
                targetButton.BackColor = backgroundColor;
                targetButton.ForeColor = textColor;
                targetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

               
                targetButton.FlatAppearance.BorderSize = 1;
                targetButton.FlatAppearance.BorderColor = backgroundColor;

                targetButton.FlatAppearance.MouseOverBackColor = customHover;
                targetButton.FlatAppearance.MouseDownBackColor = inputFieldsColor;
            }
           
            else if (mainControl is System.Windows.Forms.CheckBox)
            {
                System.Windows.Forms.CheckBox targetCheckBox = (System.Windows.Forms.CheckBox)mainControl;
                targetCheckBox.BackColor = System.Drawing.Color.Transparent;
                targetCheckBox.ForeColor = textColor;
                targetCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

                targetCheckBox.FlatAppearance.CheckedBackColor = inputFieldsColor;
                targetCheckBox.FlatAppearance.MouseOverBackColor = customHover;
                targetCheckBox.FlatAppearance.BorderColor = backgroundColor;
            }
            else if (mainControl is System.Windows.Forms.RadioButton)
            {
                System.Windows.Forms.RadioButton targetRadio = (System.Windows.Forms.RadioButton)mainControl;
                targetRadio.BackColor = System.Drawing.Color.Transparent;
                targetRadio.ForeColor = textColor;
                targetRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

                targetRadio.FlatAppearance.CheckedBackColor = inputFieldsColor;
                targetRadio.FlatAppearance.MouseOverBackColor = customHover;
                targetRadio.FlatAppearance.BorderColor = backgroundColor;
            }
            
            else if (mainControl is System.Windows.Forms.Label)
            {
                mainControl.BackColor = System.Drawing.Color.Transparent;
                mainControl.ForeColor = textColor;
            }
           
            else if (mainControl is System.Windows.Forms.TabControl || mainControl is System.Windows.Forms.TabPage || mainControl is System.Windows.Forms.Panel || mainControl is System.Windows.Forms.GroupBox)
            {
                mainControl.BackColor = backgroundColor;
                mainControl.ForeColor = textColor;
            }
           
            else
            {
                mainControl.BackColor = backgroundColor;
                mainControl.ForeColor = textColor;
            }

            
            foreach (System.Windows.Forms.Control childControl in mainControl.Controls)
            {
                ApplyGlobalTheme(childControl, backgroundColor, textColor, inputFieldsColor, customHover);
            }
        }





        private void ConfigurarRichTextBox()
        {

            richTextBox1.Font = new Font("Consolas", 12, FontStyle.Regular);
            richTextBox1.WordWrap = false;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void PatchWadMapSlot(string tempWadPath, string oldSlot, string newSlot)
        {

            byte[] oldBytes = System.Text.Encoding.ASCII.GetBytes(oldSlot.PadRight(8, '\0'));
            byte[] newBytes = System.Text.Encoding.ASCII.GetBytes(newSlot.PadRight(8, '\0'));

            try
            {

                byte[] fileBytes = File.ReadAllBytes(tempWadPath);


                for (int i = 0; i <= fileBytes.Length - oldBytes.Length; i++)
                {
                    bool coincidencia = true;
                    for (int j = 0; j < oldBytes.Length; j++)
                    {
                        if (fileBytes[i + j] != oldBytes[j])
                        {
                            coincidencia = false;
                            break;
                        }
                    }


                    if (coincidencia)
                    {
                        Buffer.BlockCopy(newBytes, 0, fileBytes, i, newBytes.Length);

                    }
                }


                File.WriteAllBytes(tempWadPath, fileBytes);
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine($"Error patching binary WAD");
            }
        }


        private void LaunchMasterLevelGame(

      string wadResourceName, string midiFileName, string wadName, string mapSlot, string warpSuffix,
      System.Windows.Forms.CheckBox fastCheck,
      System.Windows.Forms.CheckBox nomonstersCheck,
      System.Windows.Forms.CheckBox respawnCheck,
      System.Windows.Forms.CheckBox autojoinCheck,
      System.Windows.Forms.CheckBox privateCheck,
      System.Windows.Forms.CheckBox connectCheck,
      System.Windows.Forms.CheckBox serverNameCheck,
      System.Windows.Forms.CheckBox portCheck,
      System.Windows.Forms.CheckBox recordCheck,
      System.Windows.Forms.CheckBox playDemoCheck)
        {
            ActualizarNombreJugador(textBox34.Text.Trim());

            string chocolateDoomPath = "crispy-doom.exe";
            string tempWadPath = Path.Combine(Path.GetTempPath(), midiFileName);

            string statsFilePath = "stats.txt";
            if (File.Exists(statsFilePath))
            {
                try { File.Delete(statsFilePath); } catch { }
            }


            string serverName2 = textBox23.Text.Trim();
            string puertoServidor4 = textBox24.Text.Trim();
            string ipServidor4 = textBox25.Text.Trim();
            string demoName = textBox27.Text.Trim();

            string param1 = comboBox1.SelectedItem?.ToString() ?? "";
            string param2 = comboBox17.SelectedItem?.ToString() ?? "";
            string param3 = comboBox18.SelectedItem?.ToString() ?? "";
            string param4 = comboBox19.SelectedItem?.ToString() ?? "";
            string param5 = comboBox20.SelectedItem?.ToString() ?? "";
            string Argument = $"{param1} {param2} {param3} {param4} {param5}".Trim();

            string parametrosDoom = "";
            if (fastCheck.Checked) stringParamAppend(ref parametrosDoom, "-fast");
            if (nomonstersCheck.Checked) stringParamAppend(ref parametrosDoom, "-nomonsters");
            if (respawnCheck.Checked) stringParamAppend(ref parametrosDoom, "-respawn");

            if (!string.IsNullOrWhiteSpace(textBox38.Text))
            {
                stringParamAppend(ref parametrosDoom, textBox38.Text.Trim());
            }

               string parametrosRed = "";
            if (autojoinCheck.Checked) stringParamAppend(ref parametrosRed, "-autojoin");
            if (privateCheck.Checked) stringParamAppend(ref parametrosRed, "-privateserver");


            if (connectCheck.Checked && !string.IsNullOrEmpty(ipServidor4))
            {
                stringParamAppend(ref parametrosRed, $"-connect {ipServidor4}");
            }

            if (serverNameCheck.Checked && !string.IsNullOrEmpty(serverName2))
            {
                stringParamAppend(ref parametrosRed, $"-servername \"{serverName2}\"");
            }

            if (portCheck.Checked && !string.IsNullOrEmpty(puertoServidor4))
            {
                stringParamAppend(ref parametrosRed, $"-port {puertoServidor4}");
            }

            string parametrosDemo = "";
            if (!string.IsNullOrEmpty(demoName))
            {
                if (recordCheck.Checked)
                {
                    stringParamAppend(ref parametrosDemo, $"-record {demoName}");
                }
                else if (playDemoCheck.Checked)
                {
                    stringParamAppend(ref parametrosDemo, $"-playdemo {demoName}");
                }
            }

            string fileArgument = "";
            if (checkBox9.Checked)
            {
                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wadResourceName))
                {
                    if (stream != null)
                    {
                        using (FileStream fileStream = new FileStream(tempWadPath, FileMode.Create, FileAccess.Write))
                        {
                            stream.CopyTo(fileStream);
                        }
                        fileArgument = $"-file \"{tempWadPath}\"";
                    }
                    else
                    {
                        MessageBox.Show($"The MIDI resource '{wadResourceName}' could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            string masterWadFullPath = Path.Combine("master-wads", wadName);
            string coreArgs = "";
            if (File.Exists(masterWadFullPath))
            {
                coreArgs = $"-iwad DOOM2.WAD -merge {masterWadFullPath} -warp {mapSlot}{warpSuffix}";
            }
            else
            {
                coreArgs = $"-iwad DOOM2.WAD";
            }

            string ipExtra = (!connectCheck.Checked && !string.IsNullOrEmpty(ipServidor4)) ? ipServidor4 : "";


            string finalArguments = $"-statdump \"{statsFilePath}\" {fileArgument} {coreArgs} {parametrosDoom} {Argument} {parametrosRed} {parametrosDemo} {ipExtra}".Trim();



            List<string> tempWadsCreados = new List<string>();

            try
            {
                if (checkBox5.Checked)
                {

                    string[] wadsOriginales = new string[]
                    {
                "ATTACK.WAD",   
                "CANYON.WAD",   
                "CATWALK.WAD",  
                "COMBINE.WAD",  
                "FISTULA.WAD",  
                "GARRISON.WAD", 
                "MEPHISTO.WAD", 
                "BLOODSEA.WAD", 
                "MANOR.WAD",    
                "NESSUS.WAD",   
                "PARADOX.WAD",   
                "SUBSPACE.WAD", 
                "SUBTERRA.WAD", 
                "MINOS.WAD",    
                "VESPERAS.WAD", 
                "VIRGIL.WAD",   
                "GERYON.WAD",   
                "TTRAP.WAD",    
                "BLACKTWR.WAD", 
                "TEETH.WAD"      
                    };

                    string listaWadsArgumento = "";

                    for (int i = 0; i < wadsOriginales.Length; i++)
                    {
                        string wadNombre = wadsOriginales[i];
                        string rutaOriginal = Path.Combine("master-wads", wadNombre);

                        if (File.Exists(rutaOriginal))
                        {

                            string rutaTemporal = Path.Combine(Path.GetTempPath(), $"temp_camp_{wadNombre}");
                            File.Copy(rutaOriginal, rutaTemporal, true);
                            tempWadsCreados.Add(rutaTemporal);


                            string slotOriginal = "MAP01";

                            if (wadNombre == "VIRGIL.WAD") slotOriginal = "MAP03";
                            if (wadNombre == "MINOS.WAD") slotOriginal = "MAP05";
                            if (wadNombre == "MEPHISTO.WAD") slotOriginal = "MAP07";
                            if (wadNombre == "NESSUS.WAD") slotOriginal = "MAP07";
                            if (wadNombre == "BLOODSEA.WAD") slotOriginal = "MAP07";
                            if (wadNombre == "GERYON.WAD") slotOriginal = "MAP08";
                            if (wadNombre == "VESPERAS.WAD") slotOriginal = "MAP09";
                            if (wadNombre == "BLACKTWR.WAD") slotOriginal = "MAP25";
                            if (wadNombre == "TEETH.WAD") slotOriginal = "MAP31";


                            string slotDestino = $"MAP{(i + 1):D2}";


                            PatchWadMapSlot(rutaTemporal, slotOriginal, slotDestino);


                            if (wadNombre == "TEETH.WAD")
                            {
                                PatchWadMapSlot(rutaTemporal, "MAP32", "MAP21");
                            }


                            listaWadsArgumento += $"\"{rutaTemporal}\" ";
                        }
                    }

                    string resourceCieloPath = "CrispyMasterMenu.SKYGREEN.wad";
                    string tempSkyPath = Path.Combine(Path.GetTempPath(), "temp_camp_sky_patch.wad");
                    string argumentoCieloFile = "";

                    try
                    {
                        using (Stream streamCielo = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceCieloPath))
                        {
                            if (streamCielo != null)
                            {
                                using (FileStream fileStreamCielo = new FileStream(tempSkyPath, FileMode.Create, FileAccess.Write))
                                {
                                    streamCielo.CopyTo(fileStreamCielo);
                                }


                                tempWadsCreados.Add(tempSkyPath);


                                argumentoCieloFile = $"-file \"{tempSkyPath}\"";
                            }
                        }
                    }
                    catch { }


                    string campaignCoreArgs = $"-iwad DOOM2.WAD -merge {listaWadsArgumento.Trim()}";


                    campaignCoreArgs += " -warp 01";


                    finalArguments = $"-statdump \"{statsFilePath}\" {fileArgument} {argumentoCieloFile} {campaignCoreArgs} {parametrosDoom} {Argument} {parametrosRed} {parametrosDemo} {ipExtra}".Trim();



                }

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = chocolateDoomPath,
                    Arguments = finalArguments,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process gameProcess = Process.Start(startInfo);

                if (gameProcess != null)
                {
                    gameProcess.EnableRaisingEvents = true;
                    gameProcess.Exited += (s, ev) =>
                    {

                        try { if (File.Exists(tempWadPath)) File.Delete(tempWadPath); } catch { }
                        foreach (string tempWad in tempWadsCreados)
                        {
                            try { if (File.Exists(tempWad)) File.Delete(tempWad); } catch { }
                        }


                        this.Invoke((MethodInvoker)delegate
                        {
                            string localStatsPath = "stats.txt";
                            if (File.Exists(localStatsPath))
                            {
                                try
                                {

                                    string[] statsLines = File.ReadAllLines(localStatsPath);
                                    bool maratonCompletada = false;

                                    foreach (string line in statsLines)
                                    {
                                        if (line.ToUpper().Contains("MAP 21") || line.ToUpper().Contains("MAP21"))
                                        {
                                            maratonCompletada = true;
                                        }
                                    }


                                    string outputReport = "";

                                    if (checkBox5.Checked)
                                    {

                                        if (maratonCompletada)
                                        {
                                            outputReport = "==================================================\r\n" +
                                                           "YOU HAVE SURVIVED THE TWISTED HELL OF THE MASTER LEVELS.\r\n" +
                                                           "CONGRATULATIONS, YOU ARE A TRUE MASTER!\r\n" +
                                                           "==================================================\r\n";
                                        }
                                        else
                                        {
                                            outputReport = "=== MARATHON CAMPAIGN TERMINATED ===\r\n\r\n" +
                                                           "Campaign closed. If you saved your game, you can safely resume where you left off!";
                                        }
                                    }
                                    else
                                    {

                                        outputReport = $"=== LEVEL RESULTS ===\r\n\r\n";
                                        foreach (string line in statsLines)
                                        {
                                            outputReport += line.ToUpper() + "\r\n";
                                        }
                                    }


                                    textBox3.Text = outputReport;
                                }
                                catch { }


                                try { File.Delete(localStatsPath); } catch { }
                            }
                        });


                    };
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Error launching custom marathon:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void stringParamAppend(ref string baseString, string param)
        {
            baseString += (string.IsNullOrEmpty(baseString) ? "" : " ") + param;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_RUNNIN.WAD",
                "D_RUNNIN.WAD",
                "ATTACK.WAD",
                "01",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_SHAWN2.WAD",
                "D_SHAWN2.WAD",
                "BLACKTWR.WAD",
                "25",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_DDTBL2.WAD",
                "D_DDTBL2.WAD",
                "BLOODSEA.WAD",
                "07",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_STALKS.WAD",
                "D_STALKS.WAD",
                "CANYON.WAD",
                "01",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_COUNTD.WAD",
                "D_COUNTD.WAD",
                "CATWALK.WAD",
                "01",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_BETWEE.WAD",
                "D_BETWEE.WAD",
                "COMBINE.WAD",
                "01",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }
        private void button7_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_DOOM.WAD",
                "D_DOOM.WAD",
                "FISTULA.WAD",
                "01",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_THE_DA.WAD",
                "D_THE_DA.WAD",
                "GARRISON.WAD",
                "01",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_STLKS3.WAD",
                "D_STLKS3.WAD",
                "GERYON.WAD",
                "08",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_SHAWN.WAD",
                "D_SHAWN.WAD",
                "MANOR.WAD",
                "01",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_RUNNI2.WAD",
                "D_RUNNI2.WAD",
                "MEPHISTO.WAD",
                "07",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_DOOM2.WAD",
                "D_DOOM2.WAD",
                "MINOS.WAD",
                "05",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button13_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_DEAD2.WAD",
                "D_DEAD2.WAD",
                "NESSUS.WAD",
                "07",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button14_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_DDTBLU.WAD",
                "D_DDTBLU.WAD",
                "PARADOX.WAD",
                "01",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button15_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_IN_CIT.WAD",
                "D_IN_CIT.WAD",
                "SUBSPACE.WAD",
                "01",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button16_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_DEAD.WAD",
                "D_DEAD.WAD",
                "SUBTERRA.WAD",
                "01",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button17_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.TEETHMIDI.wad",
                "TEETHMIDI.wad",
                "TEETH.WAD",
                "31",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button18_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_STLKS2.WAD",
                "D_STLKS2.WAD",
                "TTRAP.WAD",
                "01",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button19_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_ROMERO.WAD",
                "D_ROMERO.WAD",
                "VESPERAS.WAD",
                "09",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button20_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.D_THEDA2.WAD",
                "D_THEDA2.WAD",
                "VIRGIL.WAD",
                "03",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }

        private void button21_Click(object sender, EventArgs e)
        {
            LaunchMasterLevelGame(
                "CrispyMasterMenu.TEETHMIDI.wad",
                "TEETHMIDI.wad",
                "TEETH.WAD",
                "32",
                "M",
                checkBox6, checkBox7, checkBox8,
                checkBox43, checkBox44, checkBox45,
                checkBox41, checkBox42,
                checkBox46, checkBox11
            );
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(new Item(" -turbo 10x%", "10"));
            comboBox1.Items.Add(new Item(" -turbo 20x%", "20"));
            comboBox1.Items.Add(new Item(" -turbo 30x%", "30"));
            comboBox1.Items.Add(new Item(" -turbo 40x%", "40"));
            comboBox1.Items.Add(new Item(" -turbo 50x%", "50"));
            comboBox1.Items.Add(new Item(" -turbo 60x%", "60"));
            comboBox1.Items.Add(new Item(" -turbo 70x%", "70"));
            comboBox1.Items.Add(new Item(" -turbo 80x%", "80"));
            comboBox1.Items.Add(new Item(" -turbo 90x%", "90"));
            comboBox1.Items.Add(new Item(" -turbo 100x%", "100"));
            comboBox1.Items.Add(new Item(" -turbo 110x%", "110"));
            comboBox1.Items.Add(new Item(" -turbo 120x%", "120"));
            comboBox1.Items.Add(new Item(" -turbo 130x%", "130"));
            comboBox1.Items.Add(new Item(" -turbo 140x%", "140"));
            comboBox1.Items.Add(new Item(" -turbo 150x%", "150"));
            comboBox1.Items.Add(new Item(" -turbo 160x%", "160"));
            comboBox1.Items.Add(new Item(" -turbo 170x%", "170"));
            comboBox1.Items.Add(new Item(" -turbo 180x%", "180"));
            comboBox1.Items.Add(new Item(" -turbo 190x%", "190"));
            comboBox1.Items.Add(new Item(" -turbo 200x%", "200"));
            comboBox1.Items.Add(new Item(" -turbo 210x%", "210"));
            comboBox1.Items.Add(new Item(" -turbo 220x%", "220"));
            comboBox1.Items.Add(new Item(" -turbo 230x%", "230"));
            comboBox1.Items.Add(new Item(" -turbo 240x%", "240"));
            comboBox1.Items.Add(new Item(" -turbo 250x%", "250"));
            comboBox1.Items.Add(new Item(" -turbo 260x%", "260"));
            comboBox1.Items.Add(new Item(" -turbo 270x%", "270"));
            comboBox1.Items.Add(new Item(" -turbo 280x%", "280"));
            comboBox1.Items.Add(new Item(" -turbo 290x%", "290"));
            comboBox1.Items.Add(new Item(" -turbo 300x%", "300"));
            comboBox1.Items.Add(new Item(" -turbo 310x%", "310"));
            comboBox1.Items.Add(new Item(" -turbo 320x%", "320"));
            comboBox1.Items.Add(new Item(" -turbo 330x%", "330"));
            comboBox1.Items.Add(new Item(" -turbo 340x%", "340"));
            comboBox1.Items.Add(new Item(" -turbo 350x%", "350"));
            comboBox1.Items.Add(new Item(" -turbo 360x%", "360"));
            comboBox1.Items.Add(new Item(" -turbo 370x%", "370"));
            comboBox1.Items.Add(new Item(" -turbo 380x%", "380"));
            comboBox1.Items.Add(new Item(" -turbo 390x%", "390"));
            comboBox1.Items.Add(new Item(" -turbo 400x%", "400"));
            comboBox2.Items.Add(new Item("-skill 1", " I'm too young to die"));
            comboBox2.Items.Add(new Item("-skill 2", "Hey, not too rough"));
            comboBox2.Items.Add(new Item("-skill 3", "Hurt me plenty"));
            comboBox2.Items.Add(new Item("-skill 4", "Ultra-Violence"));
            comboBox2.Items.Add(new Item("-skill 5", "Nightmare!"));
            comboBox3.Items.Add(new Item(" -iwad DOOM.WAD", "The Ultimate Doom"));
            comboBox3.Items.Add(new Item(" -IWAD DOOM2.WAD", "Doom II: Hell on Earth"));
            comboBox3.Items.Add(new Item(" -IWAD TNT.WAD", "Final Doom: TNT Evilution"));
            comboBox3.Items.Add(new Item(" -IWAD PLUTONIA.WAD -file plutmidi.wad", "Final Doom: Plutonia Experiment"));
            comboBox4.Items.Add(new Item("-skill 1", " I'm too young to die"));
            comboBox4.Items.Add(new Item("-skill 2", "Hey, not too rough"));
            comboBox4.Items.Add(new Item("-skill 3", "Hurt me plenty"));
            comboBox4.Items.Add(new Item("-skill 4", "Ultra-Violence"));
            comboBox4.Items.Add(new Item("-skill 5", "Nightmare!"));
            comboBox7.Items.Add(new Item(" -turbo 10x%", "10"));
            comboBox7.Items.Add(new Item(" -turbo 20x%", "20"));
            comboBox7.Items.Add(new Item(" -turbo 30x%", "30"));
            comboBox7.Items.Add(new Item(" -turbo 40x%", "40"));
            comboBox7.Items.Add(new Item(" -turbo 50x%", "50"));
            comboBox7.Items.Add(new Item(" -turbo 60x%", "60"));
            comboBox7.Items.Add(new Item(" -turbo 70x%", "70"));
            comboBox7.Items.Add(new Item(" -turbo 80x%", "80"));
            comboBox7.Items.Add(new Item(" -turbo 90x%", "90"));
            comboBox7.Items.Add(new Item(" -turbo 100x%", "100"));
            comboBox7.Items.Add(new Item(" -turbo 110x%", "110"));
            comboBox7.Items.Add(new Item(" -turbo 120x%", "120"));
            comboBox7.Items.Add(new Item(" -turbo 130x%", "130"));
            comboBox7.Items.Add(new Item(" -turbo 140x%", "140"));
            comboBox7.Items.Add(new Item(" -turbo 150x%", "150"));
            comboBox7.Items.Add(new Item(" -turbo 160x%", "160"));
            comboBox7.Items.Add(new Item(" -turbo 170x%", "170"));
            comboBox7.Items.Add(new Item(" -turbo 180x%", "180"));
            comboBox7.Items.Add(new Item(" -turbo 190x%", "190"));
            comboBox7.Items.Add(new Item(" -turbo 200x%", "200"));
            comboBox7.Items.Add(new Item(" -turbo 210x%", "210"));
            comboBox7.Items.Add(new Item(" -turbo 220x%", "220"));
            comboBox7.Items.Add(new Item(" -turbo 230x%", "230"));
            comboBox7.Items.Add(new Item(" -turbo 240x%", "240"));
            comboBox7.Items.Add(new Item(" -turbo 250x%", "250"));
            comboBox7.Items.Add(new Item(" -turbo 260x%", "260"));
            comboBox7.Items.Add(new Item(" -turbo 270x%", "270"));
            comboBox7.Items.Add(new Item(" -turbo 280x%", "280"));
            comboBox7.Items.Add(new Item(" -turbo 290x%", "290"));
            comboBox7.Items.Add(new Item(" -turbo 300x%", "300"));
            comboBox7.Items.Add(new Item(" -turbo 310x%", "310"));
            comboBox7.Items.Add(new Item(" -turbo 320x%", "320"));
            comboBox7.Items.Add(new Item(" -turbo 330x%", "330"));
            comboBox7.Items.Add(new Item(" -turbo 340x%", "340"));
            comboBox7.Items.Add(new Item(" -turbo 350x%", "350"));
            comboBox7.Items.Add(new Item(" -turbo 360x%", "360"));
            comboBox7.Items.Add(new Item(" -turbo 370x%", "370"));
            comboBox7.Items.Add(new Item(" -turbo 380x%", "380"));
            comboBox7.Items.Add(new Item(" -turbo 390x%", "390"));
            comboBox7.Items.Add(new Item(" -turbo 400x%", "400"));
            comboBox8.Items.Add(new Item(" -server -coop", "Cooperative"));
            comboBox8.Items.Add(new Item(" -server -deathmatch", "Deathmatch"));
            comboBox8.Items.Add(new Item(" -server -altdeath", "Deathmatch 2.0"));
            comboBox9.Items.Add(new Item(" -timer 1", "1"));
            comboBox9.Items.Add(new Item(" -timer 2", "2"));
            comboBox9.Items.Add(new Item(" -timer 3", "3"));
            comboBox9.Items.Add(new Item(" -timer 4", "4"));
            comboBox9.Items.Add(new Item(" -timer 5", "5"));
            comboBox9.Items.Add(new Item(" -timer 6", "6"));
            comboBox9.Items.Add(new Item(" -timer 7", "7"));
            comboBox9.Items.Add(new Item(" -timer 8", "8"));
            comboBox9.Items.Add(new Item(" -timer 9", "9"));
            comboBox9.Items.Add(new Item(" -timer 10", "10"));
            comboBox9.Items.Add(new Item(" -timer 11", "11"));
            comboBox9.Items.Add(new Item(" -timer 12", "12"));
            comboBox9.Items.Add(new Item(" -timer 13", "13"));
            comboBox9.Items.Add(new Item(" -timer 14", "14"));
            comboBox9.Items.Add(new Item(" -timer 15", "15"));
            comboBox9.Items.Add(new Item(" -timer 16", "16"));
            comboBox9.Items.Add(new Item(" -timer 17", "17"));
            comboBox9.Items.Add(new Item(" -timer 18", "18"));
            comboBox9.Items.Add(new Item(" -timer 19", "19"));
            comboBox9.Items.Add(new Item(" -timer 20", "20"));
            comboBox9.Items.Add(new Item(" -timer 21", "21"));
            comboBox9.Items.Add(new Item(" -timer 22", "22"));
            comboBox9.Items.Add(new Item(" -timer 23", "23"));
            comboBox9.Items.Add(new Item(" -timer 24", "24"));
            comboBox9.Items.Add(new Item(" -timer 25", "25"));
            comboBox9.Items.Add(new Item(" -timer 26", "26"));
            comboBox9.Items.Add(new Item(" -timer 27", "27"));
            comboBox9.Items.Add(new Item(" -timer 28", "28"));
            comboBox9.Items.Add(new Item(" -timer 29", "29"));
            comboBox9.Items.Add(new Item(" -timer 30", "30"));
            comboBox9.Items.Add(new Item(" -timer 31", "31"));
            comboBox9.Items.Add(new Item(" -timer 32", "32"));
            comboBox9.Items.Add(new Item(" -timer 33", "33"));
            comboBox9.Items.Add(new Item(" -timer 34", "34"));
            comboBox9.Items.Add(new Item(" -timer 35", "35"));
            comboBox9.Items.Add(new Item(" -timer 36", "36"));
            comboBox9.Items.Add(new Item(" -timer 37", "37"));
            comboBox9.Items.Add(new Item(" -timer 38", "38"));
            comboBox9.Items.Add(new Item(" -timer 39", "39"));
            comboBox9.Items.Add(new Item(" -timer 40", "40"));
            comboBox9.Items.Add(new Item(" -timer 41", "41"));
            comboBox9.Items.Add(new Item(" -timer 42", "42"));
            comboBox9.Items.Add(new Item(" -timer 43", "43"));
            comboBox9.Items.Add(new Item(" -timer 44", "44"));
            comboBox9.Items.Add(new Item(" -timer 45", "45"));
            comboBox9.Items.Add(new Item(" -timer 46", "46"));
            comboBox9.Items.Add(new Item(" -timer 47", "47"));
            comboBox9.Items.Add(new Item(" -timer 48", "48"));
            comboBox9.Items.Add(new Item(" -timer 49", "49"));
            comboBox9.Items.Add(new Item(" -timer 50", "50"));
            comboBox9.Items.Add(new Item(" -timer 51", "51"));
            comboBox9.Items.Add(new Item(" -timer 52", "52"));
            comboBox9.Items.Add(new Item(" -timer 53", "53"));
            comboBox9.Items.Add(new Item(" -timer 54", "54"));
            comboBox9.Items.Add(new Item(" -timer 55", "55"));
            comboBox9.Items.Add(new Item(" -timer 56", "56"));
            comboBox9.Items.Add(new Item(" -timer 57", "57"));
            comboBox9.Items.Add(new Item(" -timer 58", "58"));
            comboBox9.Items.Add(new Item(" -timer 59", "59"));
            comboBox9.Items.Add(new Item(" -timer 60", "60"));
            comboBox10.Items.Add(new Item(" -nodes 1", "1"));
            comboBox10.Items.Add(new Item(" -nodes 2", "2"));
            comboBox10.Items.Add(new Item(" -nodes 3", "3"));
            comboBox10.Items.Add(new Item(" -nodes 4", "4"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/1_on_1.wad -warp 2 4", "1_on_1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/airwalk.wad -warp 1 1", "airwalk.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ambush.wad -warp 1 1", "ambush.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/asthree.wad -warp 1 3", "asthree.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/atrium.wad -warp 1 1", "atrium.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/aurora1.wad -warp 1 2", "aurora1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/awesome.wad -warp 1 1", "awesome.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/bunker5.wad -warp 1 1", "bunker5.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/combat.wad -warp 1 1", "combat.wad (E1M1, E1M2, E1M3)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/crescen2.wad -warp 1 1", "crescen2.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/dandeth2.wad -warp 1 1", "dandeth2.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/darkhell.wad -warp 2 1", "darkhell.wad (Episode 2)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/demon.wad -warp 1 1", "demon.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/dethpond.wad -warp 1 1", "dethpond.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/dmpits.wad -warp 1 6", "dmpits.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/dprison.wad -warp 1 1", "dprison.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/drkwrld1.wad -warp 1 1", "drkwrld1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/dungeon.wad -warp 1 1", "dungeon.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/e1l1rq.wad -warp 1 1", "e1l1rq.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/e1m1osku.wad -warp 1 1", "e1m1osku.wad "));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/e3l8hell.wad -warp 3 8", "e3l8hell.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ee2l1.wad -warp 2 1", "ee2l1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ep.wad -warp 1 1", "ep.wad (Episode 1)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ep4b.wad -warp 1 1", "ep4b.wad (Episode 1)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/fiffy3.wad -warp 2 1", "fiffy3.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/flash.wad -warp 1 1", "flash.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/forest.wad -warp 2 1", "forest.wad (E2M1, E2M2, E2M3"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/fortnew.wad -warp 1 1", "fortnew.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/free4all.wad -warp 2 9", "free4all.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/frozen.wad -warp 3 1", "frozen.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/garden.wad -warp 1 1", "garden.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/gerbilz.wad -warp 1 1", "gerbilz.wad (E1M1 and E1M2"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ggdeath!.wad -warp 2 1", "ggdeath!.wad (Episode 2)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/goregsnd.wad -warp 1 1", "goregsnd.wad (sound effects)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/grease.wad -warp 3 1", "grease.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/grid.wad -warp 1 1", "grid.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/hallspro.wad -warp 1 1", "hallspro.wad (Episode 1)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/hangr1l1.wad -warp 1 1", "hangr1l1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/headlong.wad -warp 1 1", "headlong.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/hellhole.wad -warp 1 1", "hellhole.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/hellmart.wad -warp 1 1", "hellmart.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/help!.wad -warp 1 1", "help!.wad (E1M1, E1M2, E1M3"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/hippie1.wad -warp 1 1", "hippie1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/hitmeinf.wad -warp 1 1", "hitmeinf.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/hockey10.wad -warp 1 1", "hockey10.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/honycomb.wad -warp 1 1", "honycomb.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/idbest.wad -warp 1 1", "idbest.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/iie.wad -warp 1 1", "iie.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/illusory.wad -warp 1 1", "illusory.wad (Episode 1)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/infinity.wad -warp 1 1", "infinity.wad (E1M1 to E1M8)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/jet.wad -warp 1 1", "jet.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/jhldth1.wad -warp 1 1", "jhldth1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/joi-cm1.wad -warp 2 1", "joi-cm1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/joi-ctc.wad -warp 2 1", "joi-ctc.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/jump.wad -warp 1 1", "jump.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/k9.wad -warp 1 1", "k9.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/kendm1.wad -warp 1 1", "kendm1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/kendm2.wad -warp 1 1", "kendm2.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/khoonb.wad -warp 1 1", "khoonb.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/kilemall.wad -warp 2 1", "kilemall.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/kill.wad -warp 1 1", "kill.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/land1.wad -warp 2 1", "land1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/land2.wad -warp 2 2", "land2.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/led.wad -warp 1 1", "led.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ledges.wad -warp 1 1", "ledges.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ledges2.wad -warp 1 1", "ledges2.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ledges2i.wad -warp 1 1", "ledges2i.wad (Update of ledges2)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ledges3.wad -warp 1 1", "ledges3.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ledges3i.wad -warp 1 1", "ledges3i.wad (Update of ledges3)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ledges4i.wad -warp 1 1", "ledges4i.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ledgesi.wad -warp 1 1", "ledgesi.wad  (Update of ledges)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/lewis21f.wad -warp 2 1", "lewis21f.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/lkdethv1.wad -warp 2 1", "lkdethv1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/longmtch.wad -warp 2 1", "longmtch.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/lost_dth.wad -warp 2 1", "lost_dth.wad (E2M1, E2M2"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/lurker.wad -warp 2 1", "lurker.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/lvnghel2.wad -warp 1 1", "lvnghel2.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/lvnghell.wad -warp 1 1", "lvnghell.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/madmax.wad -warp 1 1", "madmax.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/maniac.wad -warp 2 1", "maniac.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/markrm2.wad -warp 2 1", "markrm2.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/markrm3.wad -warp 1 1", "markrm3.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/marks1st.wad -warp 1 1", "marks1st.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/mav2d.wad -warp 1 1", "mav2d.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/mav2m1.wad -warp 1 1", "mav2m1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/maverick.wad -warp 2 1", "maverick.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/maxfrag.wad -warp 1 1", "maxfrag.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/mc94urb.wad -warp 1 1", "mc94urb.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/megadeth.wad -warp 2 7", "megadeth.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/megamaze.wad -warp 1 1", "megamaze.wad (E1M1, E1M2"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/mike2.wad -warp 1 1", "mike2.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/mntfire.wad -warp 2 2", "mntfire.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/moo.wad -warp 1 1", "moo.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/moodie.wad -warp 1 1", "moodie.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/moonbase.wad -warp 1 1", "moonbase.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/mudville.wad -warp 1 1", "mudville.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/mut.wad -warp 1 1", "mut.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/nemodm.wad -warp 1 1", "nemodm.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/newdoom.wad -warp 1 1", "newdoom.wad (Episode 1)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/nick.wad -warp 2 1", "nick.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/nj_castl.wad -warp 1 1", "nj_castl.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/nomercy.wad -warp 1 1", "nomercy.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/nomnln11.wad -warp 2 3", "nomnln11.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/octafrag.wad -warp 1 1", "octafrag.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/octapit.wad -warp 1 1", "octapit.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/octfrag2.wad -warp 1 1", "octfrag2.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/october.wad -warp 1 1", "october.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/office.wad -warp 1 1", "office.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/opost21.wad -warp 2 1", "opost21.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/peace_20.wad -warp 1 1", "peace_20.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/pellejos.wad -warp 1 1", "pellejos.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/pentadth.wad -warp 1 1", "pentadth.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/pet.wad -warp 1 2", "pet.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/pet2.wad -warp 1 1", "pet2.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/phrag21a.wad -warp 2 1", "phrag21a.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/pleasure.wad -warp 1 1", "pleasure.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/pot.wad -warp 1 1", "pot.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/pueblo.wad -warp 1 1", "pueblo.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/purdue.wad -warp 2 1", "purdue.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/pyramid.wad -warp 2 1", "pyramid.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/quad.wad -warp 1 1", "quad.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/quake!.wad -warp 1 1", "quake!.wad (E1M1 to E1M4)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/quirul.wad -warp 1 1", "quirul.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ralph4.wad -warp 1 1", "ralph4.wad (E1M1 to E1M8)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ralph5.wad -warp 1 1", "ralph5.wad (E1M1 to E1M8)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ralphnew.wad -warp 1 1", "ralphnew.wad (3 episodes)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/rampage.wad -warp 1 1", "rampage.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/raven.wad -warp 1 1", "raven.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/reactor1.wad -warp 2 1", "reactor1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/reactor3.wad -warp 2 1", "reactor3.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/riana001.wad -warp 2 1", "riana001.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/riker11.wad -warp 1 1", "riker11.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/rip3.wad -warp 1 2", "rip3.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/rip4.wad -warp 1 1", "rip4.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/rip5.wad -warp 1 3", "rip5.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/rip6.wad -warp 3 1", "rip6.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/rip7.wad -warp 1 5", "rip7.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/rip8.wad -warp 1 2", "rip8.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/rmh.wad -warp 1 1", "rmh.wad (Episode 1)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/rmh19.wad -warp 1 9", "rmh19.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/rock-it.wad -warp 1 1", "rock-it.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/roomy.wad -warp 1 1", "roomy.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/rot.wad -warp 1 1", "rot.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/rs_oozi.wad -warp 1 1", "rs_oozi.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/run666.wad -warp 1 1", "run666.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/runlkhel.wad -warp 2 1", "runlkhel.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/ry11ecr.wad -warp 1 1", "ry11ecr.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/sawtime.wad -warp 1 1", "sawtime.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/scc2.wad -warp 1 1", "scc2.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/school.wad -warp 1 1", "school.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/scream.wad -warp 1 1", "scream.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/sdmatch.wad -warp 2 4", "sdmatch.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/serpent.wad -warp 1 1", "serpent.wad (E1M1, E1M2"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/sewers.wad -warp 3 1", "sewers.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/shadows.wad -warp 1 1", "shadows.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/shadows3.wad -warp 1 1", "shadows3.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/shogun.wad -warp 1 1", "shogun.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/show.wad -warp 1 1", "show.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/sic_em.wad -warp 1 1", "sic_em.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/sif-d1.wad -warp 1 1", "sif-d1.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/slapme.wad -warp 1 1", "slapme.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/slaught.wad -warp 1 1", "slaught.wad (Episode 1)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/sneak.wad -warp 1 1", "sneak.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/spaz.wad -warp 2 1", "spaz.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/spchaunt.wad -warp 1 3", "spchaunt.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/speedoom.wad -warp 1 1", "speedoom.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/spiral.wad -warp 1 2", "spiral.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/spookydm.wad -warp 1 1", "spookydm.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/sports.wad -warp 2 1", "sports.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/spunk.wad -warp 1 1", "spunk.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/stewbeta.wad -warp 1 1", "stewbeta.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/subway11.wad -warp 1 1", "subway11.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/sweet.wad -warp 2 1", "sweet.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/swetdeth.wad -warp 1 1", "swetdeth.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/trench.wad -warp 1 1", "trench.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/uac_dead.wad -warp 1 8", "uac_dead.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/undersea.wad -warp 2 1", "undersea.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/urbnbeta.wad 1 1", "urbnbeta.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/urmeat.wad -warp 2 1", "urmeat.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/wadpak3.wad -warp 1 1", "wadpak3.wad (3 episodes)"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/war.wad -warp 1 1", "war.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/war5.wad -warp 2 1", "war5.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/warhouse.wad -warp 1 1", "warhouse.wad"));
            comboBox11.Items.Add(new Item("-iwad DOOM.WAD -file maximum1/xcalib11.wad -warp 2 1", "xcalib11.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/!csre2m2.wad -warp 01M", "!csre2m2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/!pipe!2.wad -warp 01M", "!pipe!2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/!pois!2.wad -warp 01M", "!pois!2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/!wow!2.wad -warp 01M", "!wow!2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/#1dwango.wad -warp 01M", "#1dwango.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/01.wad -warp 01M", "01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/1squares.wad -warp 01M", "1squares.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/1sttry2.wad -warp 01M", "1sttry2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/02.wad -warp 02M", "02.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/2bad.wad -warp 01M", "2bad.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/2bad2.wad -warp 01M", "2bad2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/2besiege.wad -warp 01M", "2besiege.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/2defwads.wad -warp 01M", "2defwads.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/2die.wad -warp 01M", "2die.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/2diefor.wad -warp 01M", "2diefor.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/4octa.wad -warp 01M", "4octa.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/4pdeath.wad -warp 01M", "4pdeath.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/4towers.wad -warp 01M", "4towers.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/5-lives.wad -warp 01M", "5-lives.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/9-to-52.wad -warp 01M", "9-to-52.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/11bones2.wad -warp 01M", "11bones2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/11fortk2.wad -warp 01M", "11fortk2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/11getbf2.wad -warp 01M", "11getbf2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/11inhel2.wad -warp 01M", "11inhel2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/12.wad -warp 01M", "12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/21hex_p2.wad -warp 01M", "21hex_p2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/57east.wad -warp 01M", "57east.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/100%dth.wad -warp 01M", "100%dth.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/187.wad -warp 01M", "187.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/303sux22.wad -warp 01M", "303sux22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/1012.wad -warp 01M", "1012.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/6662.wad -warp 01M", "6662.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/a2.wad -warp 01M", "a2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/aa222.wad -warp 01M", "aa222.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/abattrd2.wad -warp 01M", "abattrd2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/abbadonx.wad -warp 01M", "abbadonx.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/abyss2.wad -warp 01M", "abyss2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/acheron2.wad -warp 03M", "acheron2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/acidrain.wad -warp 01M", "acidrain.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ad_4_ds.wad -warp 01M", "ad_4_ds.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/adam2.wad -warp 01M", "adam2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/afro2.wad -warp 01M", "afro2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/again.wad -warp 01M", "again.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/aggadoo2.wad -warp 01M", "aggadoo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/agmax.wad -warp 32M", "agmax.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/akq5.wad -warp 01M", "akq5.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/alain2.wad -warp 01M", "alain2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/alcatra2.wad -warp 01M", "alcatra2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/alenship.wad -warp 01M", "alenship.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/alley.wad -warp 01M", "alley.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/allnew01.wad -warp 01M", "allnew01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/allskill.wad -warp 01M", "allskill.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/alone12.wad -warp 01M", "!alone12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/altar.wad -warp 01M", "altar.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/amadeus.wad -warp 01M", "amadeus.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/amadeus2.wad -warp 01M", "amadeus2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/amanda2.wad -warp 01M", "amanda2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ambush2.wad -warp 01M", "ambush2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ambushdm.wad -warp 01M", "ambushdm.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/amok2_11.wad -warp 12M", "amok2_11.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/amok10t2.wad -warp 01M", "amok10t2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/anguish2.wad -warp 01M", "anguish2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/annex2.wad -warp 01M", "annex2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/anthill2.wad -warp 01M", "anthill2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/apocaly2.wad -warp 01M", "apocaly2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/apoclps2.wad -warp 01M", "apoclps2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/apt.wad -warp 01M", "apt.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/arena.wad -warp 01M", "arena.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/arena2.wad -warp 01M", "arena2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/arena3.wad -warp 01M", "arena3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/arena112.wad -warp 01M", "arena112.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/arena-ii.wad -warp 01M", "arena-ii.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/argh!_12.wad -warp 01M", "argh!_12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/argus.wad -warp 01M", "argus.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/armor2.wad -warp 01M", "armor2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/armory2.wad -warp 01M", "armory2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/arsenal.wad -warp 01M", "arsenal.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/arsenal2.wad -warp 01M", "arsenal2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/artifac2.wad -warp 01M", "artifac2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/asd2_1s.wad -warp 01M", "asd2_1s.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/asd2_2s.wad -warp 02M", "asd2_2s.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/asd2_3s.wad -warp 03M", "asd2_3s.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/asd2_4s.wad -warp 04M", "asd2_4s.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/asd2_5s.wad -warp 05M", "asd2_5s.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/asd2_6s.wad -warp 06M", "asd2_6s.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/asdoom2.wad -warp 01M", "asdoom2.wad (Map 1 to map 9)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/asmo1_12.wad -warp 01M", "asmo1_12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/asmo1_22.wad -warp 01M", "asmo1_22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/assent2.wad -warp 01M", "assent2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/atica2.wad -warp 01M", "atica2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/atlnts12.wad -warp 01M", "atlnts12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/atrium2.wad -warp 01M", "atrium2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/avrax2.wad -warp 01M", "avrax2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/away2.wad -warp 01M", "away2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/awp112.wad -warp 01M", "awp112.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/badblu32.wad -warp 01M", "badblu32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/badboy2.wad -warp 01M", "badboy2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/baddrea2.wad -warp 01M", "baddrea2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ballloc2.wad -warp 01M", "ballloc2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/barfigh2.wad -warp 01M", "barfigh2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/baronhs2.wad -warp 01M", "baronhs2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/barrel22.wad -warp 01M", "barrel22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/base.wad -warp 01M", "base.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/base2.wad -warp 01M", "base2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/base2a.wad -warp 01M", "base2a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/base66-2.wad -warp 01M", "base66-2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/base122.wad -warp 01M", "base122.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/base212.wad -warp 01M", "base212.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bast2.wad -warp 01M", "bast2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bastard2.wad -warp 01M", "bastard2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/batman2.wad -warp 01M", "batman2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bckalley.wad -warp 01M", "bckalley.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bcomple2.wad -warp 01M", "bcomple2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/beav-but.wad -warp 01M", "beav-but.wad (Sound effects)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/behold22.wad -warp 01M", "behold22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/berserk2.wad -warp 01M", "berserk2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/beta7_82.wad -warp 01M", "beta7_82.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bewarne2.wad -warp 01M", "bewarne2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bfgspaz.wad -warp 07M", "bfgspaz.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bigbad1.wad -warp 01M", "bigbad1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bigbro2.wad -warp 01M", "bigbro2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bigearls.wad -warp 01M", "bigearls.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bigjuic2.wad -warp 01M", "bigjuic2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bigmac2.wad -warp 01M", "bigmac2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bigmaze.wad -warp 01M", "bigmaze.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bigmaze2.wad -warp 01M", "bigmaze2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bigsky.wad -warp 01M", "bigsky.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bigtrap2.wad -warp 01M", "bigtrap2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bill.wad -warp 01M", "bill.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/biotech2.wad -warp 01M", "biotech2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bip2.wad -warp 01M", "bip2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bitedus2.wad -warp 01M", "bitedus2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/blackwi2.wad -warp 01M", "blackwi2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/blast2.wad -warp 01M", "blast2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/blastem.wad -warp 01M", "blastem.wad (Map 1 and 2)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/blaze12.wad -warp 01M", "blaze12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bldgiii2.wad -warp 01M", "bldgiii2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bldletng.wad -warp 03M", "bldletng.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/blew2.wad -warp 01M", "blew2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/blitz2.wad -warp 01M", "blitz2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/blood2.wad -warp 01M", "blood2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bloodfs2.wad -warp 01M", "bloodfs2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bloodke2.wad -warp 01M", "bloodke2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/blside.wad -warp 01M", "blside.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/blt2.wad -warp 01M", "blt2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bludbath.wad -warp 01M", "bludbath.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bludfes2.wad -warp 01M", "bludfes2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bludlst2.wad -warp 01M", "bludlst2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bludlus2.wad -warp 01M", "bludlus2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/boa2.wad -warp 01M", "boa2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/body2.wad -warp 01M", "body2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bonsai2.wad -warp 01M", "bonsai2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bootcam2.wad -warp 01M", "bootcam2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/booty22.wad -warp 01M", "booty22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bop2.wad -warp 01M", "bop2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/boxing.wad -warp 01M", "boxing.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/boxingc.wad -warp 01M", "boxingc.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/brain2.wad -warp 01M", "brain2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/brave2.wad -warp 01M", "brave2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/brett12.wad -warp 01M", "brett12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/brikyard.wad -warp 01M", "brikyard.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/brundle2.wad -warp 01M", "brundle2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/bunker2.wad -warp 01M", "bunker2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/butt2.wad -warp 01M", "butt2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/butta2.wad -warp 01M", "butta2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cadet2.wad -warp 01M", "cadet2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cage.wad -warp 01M", "cage.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/camper.wad -warp 01M", "camper.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cap.wad -warp 01M", "cap.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/capfest.wad -warp 01M", "capfest.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/care2.wad -warp 01M", "care2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/carl2.wad -warp 01M", "carl2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/carnage2.wad -warp 01M", "carnage2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/castle.wad -warp 01M", "castle.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/castle2.wad -warp 01M", "castle2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/castle12.wad -warp 01M", "castle12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/castlem2.wad -warp 01M", "castlem2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/castles.wad -warp 01M", "castles.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/catacom2.wad -warp 01M", "catacom2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/catwalk2.wad -warp 01M", "catwalk2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/catwalks.wad -warp 01M", "catwalks.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cave.wad -warp 01M", "cave.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cave2.wad -warp 01M", "cave2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/caverns2.wad -warp 01M", "caverns2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cavlab12.wad -warp 01M", "cavlab12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cement2.wad -warp 01M", "cement2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cereals.wad -warp 01M", "cereals.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chalen2.wad -warp 01M", "chalen2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/challen2.wad -warp 01M", "challen2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chaseme.wad -warp 01M", "chaseme.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chasm2.wad -warp 01M", "chasm2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chess.wad -warp 01M", "chess.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chess2.wad -warp 01M", "chess2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chicken.wad -warp 01M", "chicken.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chicken2.wad -warp 01M", "chicken2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/choices.wad -warp 01M", "choices.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/choices2.wad -warp 01M", "choices2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chris_e2.wad -warp 01M", "chris_e2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chris2.wad -warp 01M", "chris2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chris2a.wad-warp 01M", "chris2a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chrisk2.wad -warp 01M", "chrisk2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chrisk12.wad -warp 01M", "chrisk12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chrisk22.wad -warp 01M", "chrisk22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chrispa2.wad -warp 01M", "chrispa2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/chump2.wad -warp 01M", "chump2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/church.wad -warp 01M", "church.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/circle.wad -warp 01M", "circle.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/citadel2.wad -warp 01M", "citadel2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/citdoom2.wad -warp 01M", "citdoom2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/city.wad -warp 01M", "city.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/city2.wad -warp 01M", "city2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/citylif2.wad -warp 01M", "citylif2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/claflin2.wad -warp 01M", "claflin2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cleim102.wad -warp 01M", "cleim102.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/clerdang.wad -warp 01M", "clerdang.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cliff2.wad -warp 01M", "cliff2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cochrans.wad -warp 01M", "cochrans.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/coffin2.wad -warp 01M", "coffin2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/coffina2.wad -warp 01M", "coffina2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/coloseu2.wad -warp 01M", "coloseu2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/combat2.wad -warp 01M", "combat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/combatz2.wad -warp 01M", "combatz2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/comcon2.wad -warp 01M", "comcon2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/compbas2.wad -warp 01M", "compbas2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/complex.wad -warp 01M", "complex.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/condo.wad -warp 01M", "condo.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/contam2.wad -warp 01M", "contam2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/convert2.wad -warp 01M", "convert2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cool2.wad -warp 01M", "cool2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/coole1m2.wad -warp 01M", "coole1m2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cor812.wad -warp 01M", "cor812.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/core2.wad -warp 01M", "core2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cortyar2.wad -warp 01M", "cortyar2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/coward2.wad -warp 01M", "coward2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cphobos2.wad -warp 01M", "cphobos2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cpm112.wad -warp 01M", "cpm112.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/crazy2.wad -warp 01M", "crazy2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cring662.wad -warp 01M", "cring662.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cringe2.wad -warp 01M", "cringe2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/crosfr02.wad -warp 01M", "crosfr02.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cross2.wad -warp 01M", "cross2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/crusher2.wad -warp 01M", "crusher2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/csrd2-01.wad -warp 01M", "csrd2-01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/csrd2-l2.wad -warp 02M", "csrd2-l2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cwwad2.wad -warp 01M", "cwwad2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cyblair2.wad -warp 01M", "cyblair2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cybofun2.wad -warp 01M", "cybofun2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cybrdth2.wad -warp 01M", "cybrdth2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/cyke2.wad -warp 01M", "cyke2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/d2battle.wad -warp 01M", "d2battle.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/d2city.wad -warp 03M", "d2city.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/d2funk.wad -warp 05M", "d2funk.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/d2grim.wad -warp 04M", "d2grim.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/d2house.wad -warp 01M", "d2house.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/d2pod1.wad -warp 01M", "d2pod1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/d2vault.wad -warp 02M", "d2vault.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/d9-2.wad -warp 01M", "d9-2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/d9-2-2.wad -warp 09M", "d9-2-2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/d92.wad -warp 01M", "d92.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/daemon22.wad -warp 01M", "daemon22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/damn2.wad -warp 01M", "damn2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/damn22.wad -warp 01M", "damn22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/damned01.wad -warp 01M", "damned01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/damned02.wad -warp 02M", "damned02.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/damned03.wad -warp 03M", "damned03.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dan32.wad -warp 01M", "dan32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dandd.wad -warp 01M", "dandd.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dante2.wad -warp 02M", "dante2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dante21.wad -warp 02M", "dante21.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dantes2.wad -warp 01M", "dantes2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/danzg11a.wad -warp 11M", "danzg11a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/danzhall.wad -warp 01M", "danzhall.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/danzig1.wad -warp 12M", "danzig1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/danzig16.wad -warp 16M", "danzig16.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/danzig18.wad -warp 18M", "danzig18.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/darkage2.wad -warp 01M", "darkage2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/darkbase.wad -warp 01M", "darkbase.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/darkdeat.wad -warp 01M", "darkdeat.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/darkgat2.wad -warp 01M", "darkgat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/darknes2.wad -warp 01M", "darknes2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/darkness.wad -warp 01M", "darkness.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/darkpass.wad -warp 01M", "darkpass.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dave.wad -warp 01M", "dave.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dave12.wad -warp 01M", "dave12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dave22.wad -warp 01M", "dave22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dave32.wad -warp 01M", "dave32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/daves2n2.wad -warp 01M", "daves2n2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/david22.wad -warp 01M", "david22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/db102.wad -warp 01M", "db102.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/db-e2m12.wad -warp 01M", "db-e2m12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/db-e2m22.wad -warp 01M", "db-e2m22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/db-e2m32.wad -warp 01M", "db-e2m32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/db-e2m42.wad -warp 01M", "db-e2m42.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dcat2.wad -warp 01M", "dcat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dceptive.wad -warp 01M", "dceptive.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dday.wad -warp 01M", "dday.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dead.wad -warp 01M", "dead.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deadbas2.wad -warp 01M", "deadbas2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deadly.wad -warp 01M", "deadly.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deadly22.wad -warp 01M", "deadly22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/death.wad -warp 01M", "death.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/death2.wad -warp 01M", "death2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/death2a.wad -warp 01M", "death2a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/death12.wad -warp 01M", "death12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/death16.wad -warp 16M", "death16.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/death17.wad -warp 17M", "death17.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/death18b.wad -warp 18M", "death18b.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/death32.wad -warp 01M", "death32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deatheb.wad -warp 01M", "deatheb.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deathebn.wad -warp 01M", "deathebn.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deathm2.wad -warp 01M", "deathm2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deathpit.wad -warp 01M", "deathpit.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deathrow.wad -warp 01M", "deathrow.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deathzon.wad -warp 01M", "deathzon.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deceit.wad -warp 01M", "deceit.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deeps2.wad -warp 01M", "deeps2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deeznut.wad -warp 01M", "deeznut.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/degenrt2.wad -warp 01M", "degenrt2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deimos12.wad -warp 01M", "deimos12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deimos22.wad -warp 01M", "deimos22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dejavu.wad -warp 01M", "dejavu.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dejavu41.wad -warp 04M", "dejavu41.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/depthlab.wad -warp 01M", "depthlab.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/depths2.wad -warp 01M", "depths2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/despair2.wad -warp 01M", "despair2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/destiny2.wad -warp 01M", "destiny2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/destrct2.wad -warp 01M", "destrct2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/destruc2.wad -warp 01M", "destruc2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deth.wad -warp 01M", "deth.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deth1dm2.wad -warp 10M", "deth1dm2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deth2.wad -warp 01M", "deth2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deth2dm2.wad -warp 11M", "deth2dm2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deth3dm2.wad -warp 12M", "deth3dm2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deth4dm2.wad -warp 13M", "deth4dm2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deth12.wad -warp 01M", "deth12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dethe2m2.wad -warp 01M", "dethe2m2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dethpool.wad -warp 01M", "dethpool.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dethrace.wad -warp 01M", "dethrace.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dethsta2.wad -warp 01M", "dethsta2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dethtra2.wad -warp 01M", "dethtra2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dethwal2.wad -warp 01M", "dethwal2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dethzone.wad -warp 01M", "dethzone.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/deum2.wad -warp 01M", "deum2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/devil2.wad -warp 01M", "devil2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/devourdm.wad -warp 01M", "devourdm.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dfield2.wad -warp 01M", "dfield2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dg.wad -warp 01M", "dg.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dg-core.wad -warp 29M", "dg-core.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/diamond2.wad -warp 01M", "diamond2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/diescum2.wad -warp 01M", "diescum2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dietdoo2.wad -warp 01M", "dietdoo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dieth.wad -warp 01M", "dieth.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dii1324.wad -warp 04M", "dii1324.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dirtytr2.wad -warp 01M", "dirtytr2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dis2.wad -warp 01M", "dis2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/distort2.wad -warp 01M", "distort2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ditch.wad -warp 01M", "ditch.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/diva2.wad -warp 01M", "diva2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/divide2.wad -warp 01M", "divide2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/divorce2.wad -warp 01M", "divorce2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dks-e1l2.wad -warp 01M", "dks-e1l2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dltful1.wad -warp 01M", "dltful1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm_fleu2.wad -warp 01M", "dm_fleu2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm_khan2.wad -warp 01M", "dm_khan2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm_tpa_2.wad -warp 01M", "dm_tpa_2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm_zigs.wad -warp 01M", "dm_zigs.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm1.wad -warp 01M", "dm1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm1_v1.wad -warp 01M", "dm1_v1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2aaa.wad -warp 01M", "dm2aaa.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2coo.wad -warp 02M", "dm2coo.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2deth.wad -warp 01M", "dm2deth.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2gm1.wad -warp 01M", "dm2gm1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2gm2.wad -warp 01M", "dm2gm2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2hev.wad -warp 03M", "dm2hev.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2icu.wad -warp 07M", "dm2icu.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2mud.wad -warp 01M", "dm2mud.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2nin.wad -warp 01M", "dm2nin.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2pak#1.wad -warp 01M", "dm2pak#1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2pak01.wad -warp 01M", "dm2pak01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2pak02.wad -warp 01M", "dm2pak02.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2pak03.wad -warp 01M", "dm2pak03.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2pak08.wad -warp 01M", "dm2pak08.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2pak09.wad -warp 01M", "dm2pak09.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2pri3.wad -warp 01M", "dm2pri3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2psg.wad -warp 10M", "dm2psg.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2psych.wad -warp 01M", "dm2psych.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2room.wad -warp 02M", "dm2room.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2spi.wad -warp 01M", "dm2spi.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2tiger.wad -warp 01M", "dm2tiger.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dm2war.wad -warp 01M", "dm2war.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmanmly2.wad -warp 01M", "dmanmly2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmarena4.wad -warp 01M", "dmarena4.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmatch2.wad -warp 01M", "dmatch2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmatch12.wad -warp 01M", "dmatch12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmatch42.wad -warp 01M", "dmatch42.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmbbath2.wad -warp 01M", "dmbbath2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmbest2.wad -warp 01M", "dmbest2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmbld.wad -warp 01M", "dmbld.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmcare2.wad -warp 01M", "dmcare2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmcity.wad -warp 01M", "dmcity.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmcwrd2.wad -warp 01M", "dmcwrd2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmcy2.wad -warp 01M", "dmcy2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmdeth2.wad -warp 01M", "dmdeth2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmdth162.wad -warp 01M", "dmdth162.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmdv2.wad -warp 01M", "dmdv2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dme3m12.wad -warp 01M", "dme3m12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmedle2.wad -warp 01M", "dmedle2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmeef2.wad -warp 01M", "dmeef2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmexpo2.wad -warp 01M", "dmexpo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmfred2.wad -warp 01M", "dmfred2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmfurn2.wad -warp 01M", "dmfurn2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmg.wad -warp 01M", "dmg.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmgwar2.wad -warp 01M", "dmgwar2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmhigh2.wad -warp 01M", "dmhigh2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmhous2.wad -warp 01M", "dmhous2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmhq2.wad -warp 01M", "dmhq2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmhunge2.wad -warp 01M", "dmhunge2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dminato2.wad -warp 01M", "dminato2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmjef12.wad -warp 01M", "dmjef12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmjef22.wad -warp 01M", "dmjef22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmjef32.wad -warp 01M", "dmjef32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmjh22.wad -warp 01M", "dmjh22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmjoe2.wad -warp 01M", "dmjoe2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmjon2.wad -warp 01M", "dmjon2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmlamou2.wad -warp 01M", "dmlamou2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmlaw2.wad -warp 01M", "dmlaw2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmmars2.wad -warp 01M", "dmmars2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmmisi2.wad -warp 01M", "dmmisi2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmnbk2.wad -warp 01M", "dmnbk2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmng82.wad -warp 01M", "dmng82.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmomen2.wad -warp 01M", "dmomen2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmpits2.wad -warp 01M", "dmpits2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmprtl2.wad -warp 01M", "dmprtl2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmpurge2.wad -warp 01M", "dmpurge2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmquick2.wad -warp 01M", "dmquick2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmrock2.wad -warp 01M", "dmrock2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmseek.wad -warp 15M", "dmseek.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmsfg2.wad -warp 01M", "dmsfg2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmsof2.wad -warp 01M", "dmsof2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmtexas2.wad -warp 01M", "dmtexas2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmtorc2.wad -warp 01M", "dmtorc2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmtown.wad -warp 01M", "dmtown.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmturm2.wad -warp 01M", "dmturm2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmwar2.wad -warp 01M", "dmwar2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmwarg2.wad -warp 01M", "dmwarg2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dmzoo2.wad -warp 01M", "dmzoo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doa-122.wad -warp 01M", "doa-122.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dog_frag.wad -warp 01M", "dog_frag.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doom1-32.wad -warp 01M", "doom1-32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doom2dm1.wad -warp 01M", "doom2dm1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doom2dm2.wad -warp 01M", "doom2dm2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doom4-62.wad -warp 01M", "doom4-62.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doom142.wad -warp 01M", "doom142.wad (Get ready to go back in time)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doome1l2.wad -warp 01M", "doome1l2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doomjs2.wad -warp 01M", "doomjs2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doomona2.wad -warp 01M", "doomona2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doom-pi2.wad -warp 01M", "doom-pi2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doompl12.wad -warp 01M", "doompl12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doompl32.wad -warp 01M", "doompl32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doompl42.wad -warp 01M", "doompl42.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doompoo2.wad -warp 01M", "doompoo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doomsda2.wad -warp 01M", "doomsda2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/doors2.wad -warp 01M", "doors2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dough12.wad -warp 01M", "dough12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/down2.wad -warp 01M", "down2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dprison2.wad -warp 01M", "dprison2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dragon12.wad -warp 01M", "dragon12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/drdeath2.wad -warp 01M", "drdeath2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/drunk.wad -warp 01M", "drunk.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dse1l4x2.wad -warp 01M", "dse1l4x2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dtepis32.wad -warp 01M", "dtepis32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dth2pcom.wad -warp 01M", "dth2pcom.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dth12.wad -warp 01M", "dth12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dth12a.wad -warp 01M", "dth12a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dthbox2.wad -warp 01M", "dthbox2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dthtown2.wad -warp 01M", "dthtown2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dthtrap2.wad -warp 01M", "dthtrap2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dude0.wad -warp 01M", "dude0.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dude-ii.wad -warp 01M", "dude-ii.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dungeon2.wad -warp 01M", "dungeon2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dwango.wad -warp 01M", "dwango.wad (Map 1 to map 4)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dwango1.wad -warp 01M", "dwango1.wad (Map 1 to map 11"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dwango2.wad -warp 01M", "!dwango2.wad (Map 1 to map 11)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dwango4.wad -warp 01M", "dwango4.wad (Map 1 to map 16)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/dwheel2.wad -warp 01M", "dwheel2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1l1a2.wad -warp 01M", "e1l1a2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1l1rq2.wad -warp 01M", "e1l1rq2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1l5ko2.wad -warp 01M", "e1l5ko2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1l12.wad -warp 01M", "e1l12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1.wad -warp 01M", "e1m1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1a2.wad -warp 01M", "e1m1a2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1-a2.wad -warp 01M", "e1m1-a2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1b2.wad -warp 01M", "e1m1b2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1-c2.wad -warp 01M", "e1m1-c2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1-d2.wad -warp 01M", "e1m1-d2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1djs2.wad -warp 01M", "e1m1djs2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1-e2.wad -warp 01M", "e1m1-e2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1-f2.wad -warp 01M", "e1m1-f2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1-g2.wad -warp 01M", "e1m1-g2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1-h2.wad -warp 01M", "e1m1-h2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1-ha2.wad -warp 01M", "e1m1-ha2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1hiv2.wad -warp 01M", "e1m1hiv2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1-i2.wad -warp 01M", "e1m1-i2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1-j2.wad -warp 01M", "e1m1-j2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1-k2.wad -warp 01M", "e1m1-k2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1lat2.wad -warp 01M", "e1m1lat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1osk2.wad -warp 01M", "e1m1osk2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1sas2.wad -warp 01M", "e1m1sas2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m1trp2.wad -warp 01M", "e1m1trp2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m12.wad -warp 01M", "e1m12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m22.wad -warp 01M", "e1m22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e1m20012.wad -warp 01M", "e1m20012.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/e132.wad -warp 01M", "e132.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/earthscm.wad -warp 01M", "earthscm.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/earthwa2.wad -warp 01M", "earthwa2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/edr12.wad -warp 01M", "edr12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ee2l12.wad -warp 01M", "ee2l12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/element.wad -warp 01M", "element.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/elevato2.wad -warp 01M", "elevato2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/empire12.wad -warp 01M", "empire12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/empire42.wad -warp 01M", "empire42.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/end3.wad -warp 01M", "end3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/engine2.wad -warp 01M", "engine2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ens.wad -warp 01M", "ens.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/enterprz.wad -warp 01M", "enterprz.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ep5a2.wad -warp 01M", "ep5a2.wad (Map 1 to map 9)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/epi1bes2.wad -warp 01M", "epi1bes2.wad (Map 1 to map 8)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/epi2bes2.wad -warp 01M", "epi2bes2.wad (Map 1 to map 8)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/esc_wol2.wad -warp 01M", "esc_wol2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/escape2.wad -warp 01M", "escape2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/escape12.wad -warp 01M", "escape12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/esw2.wad -warp 01M", "esw2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/eternit2.wad -warp 01M", "eternit2.wad (Map 1 to map 8)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/evil_e2.wad -warp 01M", "evil_e2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/evilr1d2.wad -warp 01M", "evilr1d2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/evilr12.wad -warp 01M", "evilr12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/excalibr.wad -warp 01M", "excalibr.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/exdoom2.wad -warp 01M", "exdoom2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/exodus2.wad -warp 01M", "exodus2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/explore2.wad -warp 01M", "explore2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/eyespy2.wad -warp 01M", "eyespy2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/face.wad -warp 01M", "face.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/faster2.wad -warp 01M", "faster2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/faust2.wad -warp 01M", "faust2.wad (Map 1 to map 10)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fball72.wad -warp 01M", "fball72.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fc2.wad -warp 01M", "fc2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fear2.wad -warp 01M", "fear2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fear212.wad -warp 01M", "fear212.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fearles2.wad -warp 01M", "fearles2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fearofd2.wad -warp 01M", "fearofd2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fenris2.wad -warp 01M", "fenris2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fertile2.wad -warp 01M", "fertile2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/f-hold2.wad -warp 01M", "f-hold2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fiffy22.wad -warp 01M", "fiffy22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fiffy32.wad -warp 01M", "fiffy32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fiffywa2.wad -warp 01M", "fiffywa2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fight.wad -warp 01M", "fight.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/filth2.wad -warp 01M", "filth2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/final2.wad -warp 01M", "final2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/firestm2.wad -warp 01M", "firestm2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fishcak2.wad -warp 01M", "fishcak2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/flash2.wad -warp 01M", "flash2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/flat-692.wad -warp 01M", "flat-692.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fleshlz2.wad -warp 01M", "fleshlz2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/florceil.wad -warp 01M", "florceil.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/florzoo2.wad -warp 01M", "florzoo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fng02.wad -warp 01M", "fng02.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/forest1b.wad -warp 01M", "forest1b.wad (Map 1 to map 3)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/forest2.wad -warp 01M", "forest2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/forge2.wad -warp 01M", "forge2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fort12.wad -warp 01M", "fort12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fortdeth.wad -warp 01M", "fortdeth.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fortdth!.wad -warp 01M", "fortdth!.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fortres2.wad -warp 01M", "fortres2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fortress.wad -warp 01M", "fortress.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/foxer.wad -warp 01M", "foxer.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/foxer2.wad -warp 01M", "foxer2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frag_it.wad -warp 01M", "frag_it.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frag_yo2.wad -warp 01M", "frag_yo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frag_you.wad -warp 01M", "frag_you.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frag2.wad -warp 01M", "frag2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frag4all.wad -warp 01M", "frag4all.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frag4ev1.wad -warp 01M", "frag4ev1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frag4hrs.wad -warp 01M", "frag4hrs.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fragem.wad -warp 01M", "fragem.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fragfest.wad -warp 01M", "fragfest.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fraggan.wad -warp 01M", "fraggan.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fraggan2.wad -warp 01M", "fraggan2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fraggan3.wad -warp 01M", "fraggan3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fragit2.wad -warp 01M", "fragit2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fragman2.wad -warp 01M", "fragman2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fragme.wad -warp 01M", "fragme.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fragmn2a.wad -warp 01M", "fragmn2a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frags.wad -warp 01M", "frags.wad (Map 1 to map 6)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fragsrus.wad -warp 29M", "fragsrus.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fragvill.wad -warp 01M", "fragvill.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fred_dm.wad -warp 01M", "fred_dm.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fred2.wad -warp 01M", "fred2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fred2a.wad -warp 01M", "fred2a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/freedom2.wad -warp 01M", "freedom2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frgfst22.wad -warp 01M", "frgfst22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frgfstii.wad -warp 19M", "frgfstii.wad (Map 19 to map 26)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frgmeagn.wad -warp 02M", "frgmeagn.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fried2.wad -warp 01M", "fried2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frodo482.wad -warp 01M", "frodo482.wad (Map 01 and 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frogger2.wad -warp 01M", "frogger2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/frozen2.wad -warp 01M", "frozen2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fthill2.wad -warp 02M", "fthill2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fthl3.wad -warp 03M", "fthl3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fthl4.wad -warp 01M", "fthl4.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fthl5.wad -warp 05M", "fthl5.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fullchu2.wad -warp 01M", "fullchu2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fullon2.wad -warp 01M", "fullon2.wad (Map 01 to map 08)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fuloled.wad -warp 01M", "fuloled.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fun2.wad -warp 01M", "fun2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fun32.wad -warp 01M", "fun32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/funball.wad -warp 01M", "funball.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fury2.wad -warp 01M", "fury2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fy1_1-22.wad -warp 01M", "fy1_1-22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/fywythr2.wad -warp 01M", "fywythr2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/g50.wad -warp 01M", "g50.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gac001.wad -warp 01M", "gac001.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gad002.wad -warp 01M", "gad002.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/galaxia2.wad -warp 01M", "galaxia2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gallery.wad -warp 01M", "gallery.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gallery2.wad -warp 01M", "gallery2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/games2.wad -warp 01M", "games2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gangsta2.wad -warp 01M", "gangsta2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gangup.wad -warp 01M", "gangup.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gate1.wad -warp 01M", "gate1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gather2.wad -warp 01M", "gather2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gathr2.wad -warp 01M", "gathr2.wad (Map 01 to map 04)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/genocid2.wad -warp 01M", "genocid2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/genocide.wad -warp 01M", "genocide.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gerbilz2.wad -warp 01M", "gerbilz2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/get12.wad -warp 01M", "get12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ghost.wad -warp 01M", "ghost.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ghostow2.wad -warp 01M", "ghostow2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gild2.wad -warp 01M", "gild2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gimp.wad -warp 01M", "gimp.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gj_e1m22.wad -warp 01M", "gj_e1m22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gkdm3.wad -warp 01M", "gkdm3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gkpak1.wad -warp 01M", "gkpak1.wad (Map 01 to map 10)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gladiat2.wad -warp 01M", "gladiat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/glenn.wad -warp 01M", "glenn.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gloom2.wad -warp 01M", "gloom2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gluckau2.wad -warp 01M", "gluckau2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/goat2.wad -warp 01M", "goat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gog2x2.wad -warp 01M", "gog2x2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gog22.wad -warp 01M", "gog22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gonzo2.wad -warp 01M", "gonzo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/good.wad -warp 01M", "good.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/goodlor2.wad -warp 01M", "goodlor2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/goodluc2.wad -warp 01M", "goodluc2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gore12.wad -warp 01M", "gore12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/goreg2.wad -warp 01M", "goreg2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gothmog2.wad -warp 01M", "gothmog2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/grudge01.wad -warp 01M", "grudge01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/grybloo2.wad -warp 01M", "grybloo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/guetap2.wad -warp 01M", "guetap2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gulch2.wad -warp 01M", "gulch2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/gun32.wad -warp 01M", "gun32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/h_hotel2.wad -warp 01M", "h_hotel2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/h2hczek3.wad -warp 03M", "h2hczek3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/h2hmud01.wad -warp 01M", "h2hmud01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/h2hmud02.wad -warp 02M", "h2hmud02.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/h2hmud03.wad -warp 03M", "h2hmud03.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/h2hmud04.wad -warp 04M", "h2hmud04.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/h2hmudd1.wad -warp 01M", "h2hmudd1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/h2hmuddx.wad -warp 01M", "h2hmuddx.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/h22.wad -warp 01M", "h22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/halibut2.wad -warp 01M", "halibut2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hall2.wad -warp 01M", "hall2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hall52.wad -warp 01M", "hall52.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/halls1-2.wad -warp 01M", "halls1-2.wad (Map 01 to map 08)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/halls1-a.wad -warp 01M", "halls1-a.wad (Map 01 to map 06)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/halls2.wad -warp 01M", "halls2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hallsodm.wad -warp 01M", "hallsodm.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hallspr2.wad -warp 01M", "hallspr2.wad (Map 01 to map 09)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hallspr3.wad -warp 01M", "hallspr3.wad (Map 01 to map 09)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hangar2.wad -warp 01M", "hangar2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/harbor2.wad -warp 01M", "harbor2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/haunted2.wad -warp 01M", "haunted2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hazmat2.wad -warp 01M", "hazmat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hcs2.wad -warp 01M", "hcs2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/helipad2.wad -warp 01M", "helipad2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hellblk2.wad -warp 01M", "hellblk2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hellbnd2.wad -warp 01M", "hellbnd2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hellcas2.wad -warp 01M", "hellcas2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hellfort.wad -warp 01M", "hellfort.wad (Map 01 to map 03)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hellpor2.wad -warp 01M", "hellpor2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hellrai2.wad -warp 01M", "hellrai2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/helltel2.wad -warp 01M", "helltel2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hellyeah.wad -warp 01M", "hellyeah.wad (Map 01 to map 07)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/heptic2.wad -warp 01M", "heptic2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hevnhel2.wad -warp 01M", "hevnhel2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hex12.wad -warp 01M", "hex12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hiclimb2.wad -warp 01M", "hiclimb2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hide.wad -warp 01M", "hide.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hiding2.wad -warp 01M", "hiding2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/higherv2.wad -warp 01M", "higherv2.wad (Map 01 to map 04)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/highwir2.wad -warp 01M", "highwir2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hill.wad -warp 01M", "hill.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hill1.wad -warp 01M", "hill1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hippie1b.wad -warp 01M", "hippie1b.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hop112.wad -warp 01M", "hop112.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hope.wad -warp 01M", "hope.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/horror2.wad -warp 01M", "horror2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/house2.wad -warp 01M", "house2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hunger12.wad -warp 01M", "hunger12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/hurtme12.wad -warp 01M", "hurtme12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ic112.wad -warp 01M", "ic112.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/icedeat2.wad -warp 01M", "icedeat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/icenite2.wad -warp 01M", "icenite2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/idmap01.wad -warp 01M", "idmap01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/igor5.wad -warp 01M", "igor5.wad (Map 01 to map 08)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/igor9.wad -warp 01M", "igor9.wad (Map 01 to map 10)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/igorx.wad -warp 01M", "igorx.wad (Map 01 to map 07)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/igotabig.wad -warp 01M", "igotabig.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/illusio2.wad -warp 01M", "illusio2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/illusion.wad -warp 01M", "illusion.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/imps2.wad -warp 01M", "imps2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/impsrus2.wad -warp 01M", "impsrus2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/impzone2.wad -warp 01M", "impzone2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/inca2.wad -warp 01M", "inca2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/inferno2.wad -warp 01M", "inferno2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/infest2.wad -warp 01M", "infest2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/insane2.wad -warp 01M", "insane2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/instantd.wad -warp 01M", "instantd.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/instinct.wad -warp 02M", "instinct.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/intzone.wad -warp 07M", "intzone.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/invade12.wad -warp 01M", "invade12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/inyofac2.wad -warp 01M", "inyofac2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/iru2-v22.wad -warp 01M", "iru2-v22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/itp1_v2c.wad -warp 01M", "itp1_v2c.wad (Map 01 and map 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/j_best.wad -warp 01M", "j_best.wad (Map 01 and map 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/j_crush.wad -warp 01M", "j_crush.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/j_htic2.wad -warp 01M", "j_htic2.wad (Map 01 to map 09)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/j_room_0.wad -warp 01M", "j_room_0.wad (Map 01 and 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/j_room3.wad -warp 01M", "j_room3.wad (Map 01 to map 10)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/j_room4.wad -warp 01M", "j_room4.wad (Map 01 to map 14)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/j_room9.wad -warp 01M", "j_room9.wad (Map 01 to map 04)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jade.wad -warp 01M", "jade.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jail1_12.wad -warp 01M", "jail1_12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jailbrk.wad -warp 10M", "jailbrk.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jawa2.wad -warp 01M", "jawa2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jawa22.wad -warp 01M", "jawa22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jawa32.wad -warp 01M", "jawa32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jawa42.wad -warp 01M", "jawa42.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jax01.wad -warp 01M", "jax01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jax02.wad -warp 01M", "jax02.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jcm2-162.wad -warp 01M", "jcm2-162.wad (Masp 01 to map 09)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jcm12.wad -warp 01M", "jcm12.wad (Map 01 to map 08)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jd1.wad -warp 01M", "jd1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jd2.wad -warp 01M", "jd2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jdgmtday.wad -warp 01M", "jdgmtday.wad (Map 01, 02 and 04)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jed1.wad -warp 01M", "jed1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jed2.wad -warp 02M", "jed2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jed3.wad -warp 03M", "jed3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jeff's.wad -warp 01M", "jeff's.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jeg_e1l2.wad -warp 01M", "jeg_e1l2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jeg_e2l2.wad -warp 01M", "jeg_e2l2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jim02012.wad -warp 01M", "jim02012.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jje2m22.wad -warp 01M", "jje2m22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jle-b-1.wad -warp 01M", "jle-b-1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jlf-e1m2.wad -warp 01M", "jlf-e1m2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/joe's.wad -warp 01M", "joe's.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/john12.wad -warp 01M", "john12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jojobeat.wad -warp 01M", "jojobeat.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/josfun2.wad -warp 01M", "josfun2.wad (Map 01 and 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jpzoo212.wad -warp 01M", "jpzoo212.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jstuff12.wad -warp 01M", "jstuff12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jump2.wad -warp 01M", "jump2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jumper01.wad -warp 19M", "jumper01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jumper02.wad -warp 23M", "jumper02.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/jv2.wad -warp 01M", "jv2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/k22.wad -warp 01M", "k22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/k32.wad -warp 01M", "k32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kaiowas2.wad -warp 01M", "kaiowas2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kat2.wad -warp 01M", "kat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kce.wad -warp 01M", "kce.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kd.wad -warp 01M", "kd.wad (Map 01 to map 08)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/keep.wad -warp 01M", "keep.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/keeper2.wad -warp 01M", "keeper2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/keepmov1.wad -warp 01M", "keepmov1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kenleve2.wad -warp 01M", "kenleve2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kentzla2.wad -warp 01M", "kentzla2.wad (Map 01 to map 08)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kewlio.wad -warp 01M", "kewlio.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/khoon.wad -warp 01M", "khoon.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/khorne.wad -warp 01M", "khorne.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kill-1.wad -warp 01M", "kill-1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kill2.wad -warp 01M", "kill2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kill-2.wad -warp 01M", "kill-2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kill-3.wad -warp 01M", "kill-3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kill-4.wad -warp 01M", "kill-4.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kill-6.wad -warp 01M", "kill-6.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kill-7.wad -warp 01M", "kill-7.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kill-8.wad -warp 01M", "kill-8.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kill-9.wad -warp 01M", "kill-9.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kill-12.wad -warp 01M", "kill-12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kill-12a.wad -warp 01M", "kill-12a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kill-17a.wad -warp 01M", "kill-17a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/killer1.wad -warp 01M", "killer1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/killer22.wad -warp 01M", "killer22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/killin2.wad -warp 01M", "killin2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/king.wad -warp 01M", "king.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kingmoun.wad -warp 01M", "kingmoun.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/knob.wad -warp 01M", "knob.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/koko.wad -warp 01M", "koko.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/kwfrag.wad -warp 01M", "kwfrag.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/lab2.wad -warp 01M", "lab2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/labyrin2.wad -warp 01M", "labyrin2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/lake42.wad -warp 01M", "lake42.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ledge.wad -warp 01M", "ledge.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ledges2.wad -warp 01M", "ledges2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ledges2i.wad -warp 01M", "ledges2i.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ledges22.wad -warp 01M", "ledges22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ledges32.wad -warp 01M", "ledges32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/legend22.wad -warp 01M", "legend22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/legion2.wad -warp 01M", "legion2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/letmak2.wad -warp 01M", "letmak2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/lev01ext.wad -warp 01M", "lev01ext.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/level1.wad -warp 01M", "level1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/level3.wad -warp 03M", "level3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/level7.wad -warp 01M", "level7.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/lewis212.wad -warp 01M", "lewis212.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/life2.wad -warp 01M", "life2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/liftll2.wad -warp 01M", "liftll2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/liftor2.wad -warp 01M", "liftor2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/liteoda2.wad -warp 01M", "liteoda2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/lkdethv2.wad -warp 01M", "lkdethv2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/loch2.wad -warp 01M", "loch2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/loco.wad -warp 01M", "loco.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/longmtc2.wad -warp 01M", "longmtc2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/looe12.wad -warp 01M", "looe12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/looe22.wad -warp 01M", "looe22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/looe32.wad -warp 01M", "looe32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/lord2.wad -warp 01M", "lord2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/lostlev2.wad -warp 01M", "lostlev2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/lowdark2.wad -warp 01M", "lowdark2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/lowrider.wad -warp 01M", "lowrider.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/lu_e1l12.wad -warp 01M", "lu_e1l12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/luckout2.wad -warp 01M", "luckout2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/lunar.wad -warp 01M", "lunar.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/m_room.wad -warp 08M", "m_room.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/m12.wad -warp 01M", "m12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/m32.wad -warp 01M", "m32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/m52.wad -warp 01M", "m52.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/m62.wad -warp 01M", "m62.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/m72.wad -warp 01M", "m72.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/m82.wad -warp 01M", "m82.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/m92.wad -warp 01M", "m92.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/madness2.wad -warp 01M", "madness2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/manifest.wad -warp 01M", "manifest.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/map01.wad -warp 01M", "map01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/map1mod.wad -warp 01M", "map1mod.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/markii.wad -warp 01M", "markii.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/markrm32.wad -warp 01M", "markrm32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/markroo2.wad -warp 01M", "markroo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/marmbos.wad -warp 01M", "marmbos.wad (Map 01 to map 10)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/marx1_12.wad -warp 01M", "marx1_12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/marx1_22.wad -warp 01M", "marx1_22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/massacre.wad -warp 01M", "massacre.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/master22.wad -warp 01M", "master22.wad (Map 01 and 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/match2.wad -warp 01M", "match2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/matmatc2.wad -warp 01M", "matmatc2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/matmatch.wad -warp 01M", "matmatch.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/matrix2.wad -warp 01M", "matrix2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mav2c2.wad -warp 01M", "mav2c2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/maveric2.wad -warp 01M", "maveric2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/maxbad12.wad -warp 01M", "maxbad12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/maxfrag2.wad -warp 01M", "maxfrag2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mayday2.wad -warp 01M", "mayday2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/maze.wad -warp 01M", "maze.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/maze2.wad -warp 01M", "maze2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/maze12.wad -warp 01M", "maze12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/maze22.wad -warp 01M", "maze22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mdk187.wad -warp 31M", "mdk187.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/meat2.wad -warp 01M", "meat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/medideth.wad -warp 01M", "medideth.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/medman22.wad -warp 01M", "medman22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mega!.wad -warp 01M", "mega!.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mega22.wad -warp 01M", "mega22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/megadeth.wad -warp 01M", "megadeth.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/megafate.wad -warp 01M", "megafate.wad (Map 01 to map 08)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/megalab2.wad -warp 01M", "megalab2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/meganut2.wad -warp 01M", "meganut2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/megawat2.wad -warp 01M", "megawat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/melange2.wad -warp 01M", "melange2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mental.wad -warp 10M", "mental.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mentzer1.wad -warp 01M", "mentzer1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mentzer2.wad -warp 01M", "mentzer2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mentzer3.wad -warp 01M", "mentzer3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mentzer4.wad -warp 01M", "mentzer4.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/merlin.wad -warp 01M", "merlin.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mesh2.wad -warp 01M", "mesh2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/metro.wad -warp 01M", "metro.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mhacker2.wad -warp 01M", "mhacker2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mia2.wad -warp 01M", "mia2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mic2.wad -warp 01M", "mic2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/microbe.wad -warp 01M", "microbe.wad (Map 01 to map 05)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mike4.wad -warp 01M", "mike4.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mike12.wad -warp 01M", "mike12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mike12a.wad -warp 01M", "mike12a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mike82.wad -warp 01M", "mike82.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mikes2.wad -warp 01M", "mikes2.wad (Map 01 to map 05)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mine12.wad -warp 01M", "mine12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mine32.wad -warp 01M", "mine32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mines2.wad -warp 01M", "mines2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/minideth.wad -warp 01M", "minideth.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/minion.wad -warp 01M", "minion.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/minion2.wad -warp 01M", "minion2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mis22.wad -warp 01M", "mis22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/missile1.wad -warp 01M", "missile1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/missile2.wad -warp 01M", "missile2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/missile3.wad -warp 01M", "missile3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mk3.wad -warp 03M", "mk3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mk212.wad -warp 01M", "mk212.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mkfrgtme.wad -warp 01M", "mkfrgtme.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mkhalls.wad -warp 01M", "mkhalls.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mkmines.wad -warp 03M", "mkmines.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mocha.wad -warp 01M", "mocha.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mooed2.wad -warp 01M", "mooed2.wad (Map 01, 02 and 03)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/moonbas2.wad -warp 01M", "moonbas2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mortem2.wad -warp 01M", "mortem2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/motion2.wad -warp 01M", "motion2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mountai2.wad -warp 01M", "mountai2.wad (Map 01 to map 09)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mournin2.wad -warp 01M", "mournin2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mre1m12.wad -warp 01M", "mre1m12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mt2.wad -warp 01M", "mt2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mtdoom2.wad -warp 01M", "mtdoom2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mud1st2.wad -warp 01M", "mud1st2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mudbas12.wad -warp 01M", "mudbas12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mudlab12.wad -warp 01M", "mudlab12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mudmad12.wad -warp 01M", "mudmad12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mudman12.wad -warp 01M", "mudman12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mudmano2.wad -warp 01M", "mudmano2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mudrat12.wad -warp 01M", "mudrat12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mudtow12.wad -warp 01M", "mudtow12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mudtown2.wad -warp 01M", "mudtown2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mudvill2.wad -warp 01M", "mudvill2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/multi2.wad -warp 01M", "multi2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/multi12.wad -warp 01M", "multi12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mxk_c-12.wad -warp 01M", "mxk_c-12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/mxk_d-12.wad -warp 01M", "mxk_d-12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/my_1st2.wad -warp 01M", "my_1st2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/myhouse2.wad -warp 01M", "myhouse2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nasty2.wad -warp 01M", "nasty2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nasty11.wad -warp 01M", "nasty11.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/natee1m2.wad -warp 01M", "natee1m2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nazi.wad -warp 01M", "nazi.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nefcat.wad -warp 01M", "nefcat.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nemodm2.wad -warp 01M", "nemodm2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/net9.wad -warp 01M", "net9.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/net10.wad -warp 01M", "net10.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/netbeas2.wad -warp 01M", "netbeas2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/netcity.wad -warp 01M", "netcity.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/neveres2.wad -warp 01M", "neveres2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/new.wad -warp 02M", "new.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/new2.wad -warp 01M", "new2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/new7.wad -warp 07M", "new7.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/newbonu2.wad -warp 01M", "newbonu2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/newday2.wad -warp 01M", "newday2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/newdoom2.wad -warp 01M", "newdoom2.wad (Map 01 to map 27)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/newhell.wad -warp 01M", "newhell.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/newhits2.wad -warp 01M", "newhits2.wad (Masp 01 to map 08)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/newhock2.wad -warp 01M", "newhock2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/newjoker.wad -warp 01M", "newjoker.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/newlev2.wad -warp 01M", "newlev2.wad (Map 01 to map 08)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/newmap01.wad -warp 01M", "newmap01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/newmiss4.wad -warp 01M", "newmiss4.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/newt.wad -warp 01M", "newt.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/newwest.wad -warp 02M", "newwest.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nghtmr2.wad -warp 01M", "nghtmr2.wad (Map 01 and 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nghtmr12.wad -warp 01M", "nghtmr12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nicks1st.wad -warp 01M", "nicks1st.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nightfa2.wad -warp 01M", "nightfa2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nin.wad -warp 01M", "nin.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nin02.wad -warp 01M", "nin02.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nirvana2.wad -warp 01M", "nirvana2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nitemar2.wad -warp 01M", "nitemar2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nj_cast2.wad -warp 01M", "nj_cast2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nj_soh12.wad -warp 01M", "nj_soh12.wad (Map 01 to map 09)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/njdoom2.wad -warp 01M", "njdoom2.wad (Map 01 to map 30)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/njdoom12.wad -warp 01M", "njdoom12.wad (Map 01 to map 27)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/njkd1a2.wad -warp 01M", "njkd1a2.wad (Map 01 to map 09)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nnhs.wad -warp 02M", "nnhs.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nocanwi2.wad -warp 01M", "nocanwi2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nofear2.wad -warp 01M", "nofear2.wad (Map 01 to map 09)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nomercy1.wad -warp 01M", "nomercy1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nopanic2.wad -warp 01M", "nopanic2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/noway.wad -warp 01M", "noway.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/n-river2.wad -warp 01M", "n-river2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nuclear2.wad -warp 01M", "nuclear2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nukeit2.wad -warp 01M", "nukeit2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/nukerai2.wad -warp 01M", "nukerai2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/number1.wad -warp 01M", "number1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/obdeath1.wad -warp 01M", "obdeath1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/obdeath2.wad -warp 01M", "obdeath2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/octafra2.wad -warp 01M", "octafra2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/octagon2.wad -warp 01M", "octagon2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/octd2.wad -warp 01M", "octd2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/octogon.wad -warp 01M", "octogon.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/office2.wad -warp 01M", "office2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ognawd1.wad -warp 01M", "ognawd1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/omega.wad -warp 01M", "omega.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/omega_ii.wad -warp 01M", "omega_ii.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/opost212.wad -warp 01M", "opost212.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ops2.wad -warp 01M", "ops2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/oracle.wad -warp 01M", "oracle.wad (Map 02 and 03)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/orbit2.wad -warp 01M", "orbit2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/outland2.wad -warp 01M", "outland2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ow2.wad -warp 01M", "ow2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/paddock.wad -warp 01M", "paddock.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/painles2.wad -warp 01M", "painles2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/paintbal.wad -warp 01M", "paintbal.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/palace2.wad -warp 01M", "palace2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/panic!2.wad -warp 01M", "panic!2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/par-0022.wad -warp 01M", "par-0022.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/paradox2.wad -warp 01M", "paradox2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pdeth2.wad -warp 01M", "pdeth2.wad (Map 01 to map 04)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/peace-d2.wad -warp 01M", "peace-d2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/peano2.wad -warp 01M", "peano2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pearlja2.wad -warp 01M", "pearlja2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/peekabo2.wad -warp 01M", "peekabo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/peekaboo.wad -warp 01M", "peekaboo.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pentagon.wad -warp 01M", "pentagon.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pentdro2.wad -warp 01M", "pentdro2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/penze12.wad -warp 01M", "penze12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/penze22.wad -warp 01M", "penze22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/penze32.wad -warp 01M", "penze32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pet2.wad -warp 01M", "pet2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/petkill2.wad -warp 01M", "petkill2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/phobos1a.wad -warp 01M", "phobos1a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/phobos12.wad -warp 01M", "phobos12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/phobos22.wad -warp 01M", "phobos22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/phobos32.wad -warp 01M", "phobos32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/phobos42.wad -warp 01M", "phobos42.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/phobos52.wad -warp 01M", "phobos52.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/phuct.wad -warp 01M", "phuct.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pillar2.wad -warp 01M", "pillar2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pimp.wad -warp 01M", "pimp.wad (Map 01 to map 27)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pina012.wad -warp 01M", "pina012.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pina022.wad -warp 01M", "pina022.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pina032.wad -warp 01M", "pina032.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pistol2.wad -warp 01M", "pistol2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pit.wad -warp 01M", "pit.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pit62.wad -warp 01M", "pit62.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pitdeath.wad -warp 01M", "pitdeath.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pitfalls.wad -warp 01M", "pitfalls.wad (Map 01 and 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pitsofd2.wad -warp 01M", "pitsofd2.wad (Map 01 and 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pizza.wad -warp 01M", "pizza.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pjs012.wad -warp 01M", "pjs012.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/plats2.wad -warp 01M", "plats2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/play2.wad -warp 01M", "play2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/playgnd2.wad -warp 01M", "playgnd2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/playgrnd.wad -warp 01M", "playgrnd.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pnp132.wad -warp 01M", "pnp132.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/polymad2.wad -warp 01M", "polymad2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pot-2.wad -warp 01M", "pot-2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ppalace.wad -warp 01M", "ppalace.wad (Map 01 to map 04)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/p-plant2.wad -warp 01M", "p-plant2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/predato2.wad -warp 01M", "predato2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/predator.wad -warp 01M", "predator.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/prison.wad -warp 01M", "prison.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/prison2.wad -warp 01M", "prison2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/prison12.wad -warp 01M", "prison12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/prisona2.wad -warp 01M", "prisona2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/private.wad -warp 01M", "private.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/private2.wad -warp 01M", "private2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/process2.wad -warp 01M", "process2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/protomud.wad -warp 05M", "protomud.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/proxima.wad -warp 01M", "proxima.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/psycho.wad -warp 01M", "psycho.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/psycho_a.wad -warp 01M", "psycho_a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/psycho1.wad -warp 01M", "psycho1.wad (Map 01 to map 06)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/psycho2.wad -warp 01M", "psycho2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ptultra2.wad -warp 01M", "ptultra2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ptwad!.wad -warp 01M", "ptwad!.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pueblo2.wad -warp 01M", "pueblo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/puffy.wad -warp 01M", "puffy.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pulpfx.wad -warp 01M", "pulpfx.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pumpkin2.wad -warp 01M", "pumpkin2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/purple22.wad -warp 01M", "purple22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pvbdeth2.wad -warp 01M", "pvbdeth2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/pwrplt15.wad -warp 18M", "pwrplt15.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/python2.wad -warp 01M", "python2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/qtbugnme.wad -warp 01M", "qtbugnme.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/quad2.wad -warp 01M", "quad2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/quark12.wad -warp 01M", "quark12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/quatro2.wad -warp 01M", "quatro2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/quikdeth.wad -warp 01M", "quikdeth.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/r.wad -warp 01M", "r.wad (Map 01 to map 30)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/r91.wad -warp 01M", "r91.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ra1.wad -warp 01M", "ra1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ra2.wad -warp 02M", "ra2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ra3.wad -warp 03M", "ra3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ra4.wad -warp 04M", "ra4.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ra5.wad -warp 05M", "ra5.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ra6.wad -warp 06M", "ra6.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ra7.wad -warp 07M", "ra7.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/race112.wad -warp 01M", "race112.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/radplant.wad -warp 01M", "radplant.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rage1.wad -warp 01M", "rage1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ralphii.wad -warp 01M", "ralphii.wad (Map 01 to map 30)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ram5.wad -warp 12M", "ram5.wad (Map 12 to map 20)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ram6.wad -warp 01M", "ram6.wad (Map 01 to map 11)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rambo2.wad -warp 01M", "rambo2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rand.wad -warp 01M", "rand.wad (Map 01 to map 03)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/random.wad -warp 01M", "random.wad (Map 01 and 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven1.wad -warp 01M", "raven1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven2.wad -warp 02M", "raven2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven3.wad -warp 03M", "raven3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven4.wad -warp 04M", "raven4.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven5.wad -warp 05M", "raven5.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven6.wad -warp 06M", "raven6.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven7.wad -warp 07M", "raven7.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven8.wad -warp 08M", "raven8.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven9.wad -warp 09M", "raven9.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven10.wad -warp 10M", "raven10.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven11.wad -warp 11M", "raven11.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven11b.wad -warp 11M", "raven11b.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raven111.wad -warp 01M", "raven111.wad (Map 01 to map 11)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/raygun2.wad -warp 01M", "raygun2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/razzor.wad -warp 01M", "razzor.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rck2.wad -warp 01M", "rck2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/r-dens2.wad -warp 01M", "r-dens2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/reactor2.wad -warp 01M", "reactor2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/reactora.wad -warp 01M", "reactora.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/real7.wad -warp 01M", "real7.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/realm.wad -warp 01M", "realm.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/realm3.wad -warp 01M", "realm3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/realm4.wad -warp 01M", "realm4.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/realm102.wad -warp 01M", "realm102.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/realmi.wad -warp 01M", "realmi.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/realmit!.wad -warp 01M", "realmit!.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/reddawgs.wad -warp 01M", "reddawgs.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/reddog2.wad -warp 01M", "reddog2.wad (Map 01, 02, 03)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/redrom2.wad -warp 01M", "redrom2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/redroom2.wad -warp 01M", "redroom2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/redrum2.wad -warp 01M", "redrum2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/remains.wad -warp 01M", "remains.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/reolwolf.wad -warp 01M", "reolwolf.wad (Map 01 to map 09)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rescue.wad -warp 01M", "rescue.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rescue12.wad -warp 01M", "rescue12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/return02.wad -warp 01M", "return02.wad (Map 01 to map 09)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/revenge.wad -warp 01M", "revenge.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/revile.wad -warp 02M", "revile.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rhe2l32.wad -warp 01M", "rhe2l32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rickdoo2.wad -warp 01M", "rickdoo2.wad (Map 01 to map 04)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ricks12.wad -warp 01M", "ricks12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rider01.wad -warp 01M", "rider01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rider1-4.wad -warp 01M", "rider1-4.wad (Map 01 to map 04)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rider02.wad -warp 02M", "rider02.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rider03.wad -warp 03M", "rider03.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rider04.wad -warp 04M", "rider04.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/right.wad -warp 01M", "right.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/riker102.wad -warp 01M", "riker102.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/riker112.wad -warp 01M", "riker112.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ring.wad -warp 01M", "ring.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ringdet2.wad -warp 01M", "ringdet2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rings2.wad -warp 01M", "rings2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rip52.wad -warp 01M", "rip52.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rip72.wad -warp 01M", "rip72.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rippedin.wad -warp 01M", "rippedin.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/river142.wad -warp 01M", "river142.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/road2.wad -warp 01M", "road2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rockets.wad -warp 08M", "rockets.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/romena.wad -warp 01M", "romena.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/room2.wad -warp 01M", "room2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/room2-1.wad -warp 01M", "room2-1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/room2-2.wad -warp 01M", "room2-2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/room3-1.wad -warp 01M", "room3-1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/room4-1.wad -warp 01M", "room4-1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/room5.wad -warp 01M", "room5.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/round.wad -warp 01M", "round.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ru_a_man.wad -warp 01M", "ru_a_man.wad (Map 01, 02, 03)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/runlkhe2.wad -warp 01M", "runlkhe2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rurqta.wad -warp 01M", "rurqta.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/rwk01102.wad -warp 01M", "rwk01102.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/s&jv12.wad -warp 01M", "s&jv12.wad (Map 01 to 05)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sabrmau2.wad -warp 01M", "sabrmau2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sacrfic2.wad -warp 01M", "sacrfic2.wad (Map 01 to 06)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/samurai2.wad -warp 01M", "samurai2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sanctum2.wad -warp 01M", "sanctum2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/santa.wad -warp 01M", "santa.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sapidus2.wad -warp 01M", "sapidus2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sbaw2.wad -warp 01M", "sbaw2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/scanyon2.wad -warp 01M", "scanyon2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/school.wad -warp 01M", "school.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/school2.wad -warp 01M", "school2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/scorche2.wad -warp 01M", "scorche2.wad (Map 01 and 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/scorpio2.wad -warp 01M", "scorpio2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/scumtre2.wad -warp 01M", "scumtre2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sequel2.wad -warp 01M", "sequel2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sewer2.wad -warp 01M", "sewer2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sewer2a.wad-warp 01M", "sewer2a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sewers2.wad -warp 01M", "sewers2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sewerv12.wad -warp 01M", "sewerv12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sewv12r2.wad -warp 01M", "sewv12r2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shadow.wad -warp 01M", "shadow.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shaft2.wad -warp 01M", "shaft2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shaft222.wad -warp 01M", "shaft222.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shinobi2.wad -warp 01M", "shinobi2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shogun2.wad -warp 01M", "shogun2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shoots20.wad -warp 01M", "shoots20.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shopbal2.wad -warp 01M", "shopbal2.wad (Map 01 and 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shotgun.wad -warp 01M", "shotgun.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shotgun1.wad -warp 01M", "shotgun1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shotgun2.wad -warp 01M", "shotgun2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shotgun3.wad -warp 01M", "shotgun3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shover.wad -warp 01M", "shover.wad (Map 01 and 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/showdow2.wad -warp 01M", "showdow2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/showdwn2.wad -warp 01M", "showdwn2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shriek.wad -warp 01M", "shriek.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shrin2.wad -warp 01M", "shrin2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shrine2.wad -warp 01M", "shrine2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shtgun!.wad -warp 01M", "shtgun!.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/shutdow2.wad -warp 01M", "shutdow2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sif-d2.wad -warp 01M", "sif-d2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sight.wad -warp 01M", "sight.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/!simon102.wad -warp 01M", "simon102.wad (Map 01 and 02)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/simp_gfx.wad -file maximum2/simp_snd.wad -warp 01M", "simp_gfx.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sin_city.wad -warp 01M", "sin_city.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sincity5.wad -warp 01M", "sincity5.wad (Map 01 to map 05)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/skill!.wad -warp 01M", "skill!.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/skirmish.wad -warp 01M", "skirmish.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/skrewd.wad -warp 01M", "skrewd.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sky1.wad -warp 01M", "sky1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/slapme2.wad -warp 01M", "slapme2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/slapme3.wad -warp 01M", "slapme3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/slaught2.wad -warp 01M", "slaught2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/slaughtr.wad -warp 01M", "slaughtr.wad (Map 1 and 2)")); ;
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/slayer2.wad -warp 01M", "slayer2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/slg-e2m2.wad -warp 01M", "slg-e2m2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sltrram2.wad -warp 01M", "sltrram2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/smega!.wad -warp 01M", "smega!.wad (Map 1 to map 4)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/smile2.wad -warp 01M", "smile2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sorrow2.wad -warp 01M", "sorrow2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/space2.wad -warp 01M", "space2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spaced2.wad -warp 01M", "spaced2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spankme2.wad -warp 01M", "spankme2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spanky04.wad -warp 01M", "spanky04.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spidere2.wad -warp 01M", "spidere2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spiff_2.wad -warp 01M", "spiff_2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spiffwad.wad -warp 01M", "spiffwad.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spillwa2.wad -warp 01M", "spillwa2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spinal.wad -warp 01M", "spinal.wad (Map 1 to map 8)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spiral1.wad -warp 01M", "spiral1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spiral2.wad -warp 01M", "spiral2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spit2.wad -warp 01M", "spit2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spoon!2.wad -warp 01M", "spoon!2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spring2.wad -warp 01M", "spring2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/spunk2.wad -warp 01M", "spunk2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/squid2.wad -warp 01M", "squid2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/squid22.wad -warp 01M", "squid22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sr212.wad -warp 01M", "sr212.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ss!.wad -warp 01M", "ss!.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ss_e2_m2.wad -warp 01M", "ss_e2_m2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ss27bet2.wad -warp 01M", "ss27bet2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stair2.wad -warp 01M", "stair2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stairs2.wad -warp 01M", "stairs2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stairwa2.wad -warp 01M", "stairwa2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stalag2.wad -warp 01M", "stalag2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stalker2.wad -warp 01M", "stalker2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stalkera.wad -warp 01M", "stalkera.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stand.wad -warp 01M", "stand.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/star2.wad -warp 01M", "star2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/star-b-2.wad -warp 01M", "star-b-2.wad (Map 1 and 2)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stardet2.wad -warp 01M", "stardet2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stargate.wad -warp 01M", "stargate.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/starshp2.wad -warp 01M", "starshp2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/starwar2.wad -warp 01M", "starwar2.wad (Map 1 and 2)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/station2.wad -warp 01M", "station2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/statues2.wad -warp 01M", "statues2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stjnoho2.wad -warp 01M", "stjnoho2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stjohns2.wad -warp 01M", "stjohns2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stones2.wad -warp 01M", "stones2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/storage2.wad -warp 01M", "storage2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/straps21.wad -warp 01M", "straps21.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/strengt2.wad -warp 01M", "strengt2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/strippe2.wad -warp 01M", "strippe2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/strmstr2.wad -warp 01M", "strmstr2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/stupid12.wad -warp 01M", "stupid12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/styx2.wad -warp 01M", "styx2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/subway2.wad -warp 01M", "subway2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/subway12.wad -warp 01M", "subway12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sudden.wad -warp 01M", "sudden.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sungod.wad -warp 01M", "sungod.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/super1.wad -warp 01M", "super1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/super222.wad -warp 01M", "super222.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/super332.wad -warp 01M", "super332.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/surpriz2.wad -warp 01M", "surpriz2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/surreal2.wad -warp 01M", "surreal2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/survive2.wad -warp 01M", "survive2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/swamp.wad -warp 01M", "swamp.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/swamp1.wad -warp 01M", "swamp1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/swamp2.wad -warp 01M", "swamp2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/swamp3.wad -warp 01M", "swamp3.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/swarm2.wad -warp 01M", "swarm2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sweepers.wad -warp 01M", "sweepers.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sweet2.wad -warp 01M", "sweet2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sword2.wad -warp 01M", "sword2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/symboli2.wad -warp 01M", "symboli2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/syn.wad -warp 01M", "syn.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/sys2.wad -warp 01M", "sys2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/taawts2.wad -warp 01M", "taawts2.wad (Map 1 and 2)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/target2.wad -warp 01M", "target2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/taxi.wad -warp 01M", "taxi.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tazmania.wad -warp 01M", "tazmania.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/t-base2.wad -warp 01M", "t-base2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tc3-ii.wad -warp 01M", "tc3-ii.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/teamfrag.wad -warp 02M", "teamfrag.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/teamfrg2.wad -warp 01M", "teamfrg2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/teamfrg4.wad -warp 01M", "teamfrg4.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/teamledg.wad -warp 01M", "teamledg.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/techno2.wad -warp 01M", "techno2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/technoi2.wad -warp 01M", "technoi2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tele_me.wad -warp 01M", "tele_me.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/telefra2.wad -warp 01M", "telefra2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/telepor2.wad -warp 01M", "telepor2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/temple2.wad -warp 01M", "temple2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/temple12.wad -warp 01M", "temple12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/temple22.wad -warp 01M", "temple22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/terror.wad -warp 01M", "terror.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tesc1_22.wad -warp 01M", "tesc1_22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/test2ki2.wad -warp 01M", "test2ki2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tfw12.wad -warp 01M", "tfw12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tfwdeth1.wad -warp 01M", "tfwdeth1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tgmo22.wad -warp 01M", "tgmo22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/the_gri2.wad -warp 01M", "the_gri2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/the_keep.wad -warp 01M", "the_keep.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/the_quad.wad -warp 12M", "the_quad.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/theatre2.wad -warp 01M", "theatre2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/thejoke2.wad -warp 01M", "thejoke2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/thejoker.wad -warp 01M", "thejoker.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/thekeep2.wad -warp 01M", "thekeep2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/thekeepa.wad -warp 01M", "thekeepa.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/thekurs2.wad -warp 01M", "thekurs2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/thelast2.wad -warp 01M", "thelast2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/thelord.wad -warp 01M", "thelord.wad (Map 1 to map 6)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/thenest2.wad -warp 01M", "thenest2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/thepit2.wad -warp 01M", "thepit2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/thepits2.wad -warp 01M", "thepits2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/theta-42.wad -warp 01M", "theta-42.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/theteet2.wad -warp 01M", "theteet2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/theyard.wad -warp 01M", "theyard.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/the-zone.wad -warp 01M", "the-zone.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/this2.wad -warp 01M", "this2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/thor.wad -warp 01M", "thor.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/three2.wad -warp 01M", "three2.wad (Map 1 to map 3)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/thud!.wad -warp 01M", "thud!.wad (Map 1 to map 9)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/thud2.wad -warp 10M", "thud2.wad (Map 10 to map 18)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/thud3.wad -warp 19M", "thud3.wad (Map 19 to map 27)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tibet2.wad -warp 01M", "tibet2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tie2.wad -warp 01M", "tie2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tigerde2.wad -warp 01M", "tigerde2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/timjay.wad -warp 01M", "timjay.wad (Map 1 to map 8)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tlb2.wad -warp 01M", "tlb2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tlhe2l12.wad -warp 01M", "tlhe2l12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/tmall2.wad -warp 14M", "tmall2.wad (Map 14,15,16,31,32)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tncross2.wad -warp 01M", "tncross2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tnspire2.wad -warp 01M", "tnspire2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tony32.wad -warp 01M", "tony32.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/toohard2.wad -warp 01M", "toohard2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/torchle2.wad -warp 01M", "torchle2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tornado2.wad -warp 01M", "tornado2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/torture2.wad -warp 01M", "torture2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tourney.wad -warp 01M", "tourney.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tourney2.wad -warp 01M", "tourney2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tower.wad -warp 01M", "tower.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tower2.wad -warp 01M", "tower2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tower2a.wad -warp 01M", "tower2a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tower532.wad -warp 01M", "tower532.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/town2.wad -warp 01M", "town2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/train2.wad -warp 01M", "train2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/trench2.wad -warp 01M", "trench2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/trench2a.wad -warp 01M", "trench2a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/trideat2.wad -warp 01M", "trideat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/trisa.wad -warp 01M", "trisa.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/trkdoom.wad -file maximum2/trksnds.wad -warp 01M", "trkdoom.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/try_it2.wad -warp 01M", "try_it2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tt112.wad -warp 01M", "tt112.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ttadom12.wad -warp 01M", "ttadom12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tunnel2.wad -warp 01M", "tunnel2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tunnel11.wad -warp 01M", "tunnel11.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tunnel12.wad -warp 01M", "tunnel12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/tunnels.wad -warp 01M", "tunnels.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/uac_dea2.wad -warp 01M", "uac_dea2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/uacpen2.wad -warp 01M", "uacpen2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/uae.wad -warp 02M", "uae.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/uc.wad -warp 01M", "uc.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ultim2.wad -warp 01M", "ultim2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ultimo2.wad -warp 01M", "ultimo2.wad (Map 1 to map 3)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ultmv202.wad -warp 01M", "ultmv202.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ultra54.wad -warp 01M", "ultra54.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/umbring2.wad -warp 01M", "umbring2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/under2.wad -warp 01M", "under2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/undergrd.wad -warp 01M", "undergrd.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/underse2.wad -warp 01M", "underse2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/unfun2.wad -warp 01M", "unfun2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/unlag1.wad -warp 01M", "unlag1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/unlag2.wad -warp 01M", "unlag2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/updown2.wad -warp 01M", "updown2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/upliftn2.wad -warp 01M", "upliftn2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/uranus2.wad -warp 01M", "uranus2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/urban2.wad -warp 01M", "urban2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/urbnbet2.wad -warp 01M", "urbnbet2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/urbnd2.wad -warp 01M", "urbnd2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/urmeat2.wad -warp 01M", "urmeat2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/usq22.wad -warp 01M", "usq22.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/usqe1m12.wad -warp 01M", "usqe1m12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/utopia2.wad -warp 01M", "utopia2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/vacation.wad -warp 01M", "vacation.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/vampire2.wad -warp 01M", "vampire2.wad (Map 1 and 2)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/vengenc2.wad -warp 01M", "vengenc2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/victim2.wad -warp 01M", "victim2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/viper2.wad -warp 01M", "viper2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/voidshi2.wad -warp 01M", "voidshi2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/vort01.wad -warp 01M", "vort01.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/vort02.wad -warp 02M", "vort02.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/vort03.wad -warp 03M", "vort03.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/vort04.wad -warp 04M", "vort04.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/vortex.wad -warp 01M", "vortex.wad (Map 1 to map 4)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/vortex2.wad -warp 01M", "vortex2.wad (Map 1 to map 3)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/vortpak.wad -warp 01M", "vortpak.wad (Map 1 to map 5)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wack2.wad -warp 01M", "wack2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/wadfthr.wad -warp 01M", "wadfthr.wad (Replace all maps)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wadpack2.wad -warp 01M", "wadpack2.wad (Map 1 to map 27)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wadpak4.wad -warp 01M", "wadpak4.wad (Map 1 to map 27)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wadpak22.wad -warp 01M", "wadpak22.wad (Map 1 to map 27)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/waldeth.wad -warp 01M", "waldeth.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/walker2.wad -warp 01M", "walker2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/walls2.wad -warp 01M", "walls2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/walltra2.wad -warp 01M", "walltra2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wanton12.wad -warp 01M", "wanton12.wad (Map 1 and 2)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/war1.wad -warp 01M", "war1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/warehou2.wad -warp 01M", "warehou2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/warfield.wad -warp 01M", "warfield.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/warhous2.wad -warp 01M", "warhous2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/warren2.wad -warp 01M", "warren2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/warzn2a.wad -warp 01M", "warzn2a.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/washmonu.wad -warp 01M", "washmonu.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/watch512.wad -warp 01M", "watch512.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/water.wad -warp 01M", "water.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wax.wad -warp 01M", "wax.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wax2.wad -warp 01M", "wax2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/waycool2.wad -warp 01M", "waycool2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wayne2.wad -warp 01M", "wayne2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/weapons.wad -warp 01M", "weapons.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wedding.wad -warp 01M", "wedding.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wedding2.wad -warp 01M", "wedding2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/weezul2.wad -warp 01M", "weezul2.wad (Map 1 to map 3)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/weezul12.wad -warp 01M", "weezul12.wad (Map 1 to map 5)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/welcome2.wad -warp 01M", "welcome2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/west.wad -warp 01M", "west.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/westcoop.wad -warp 01M", "westcoop.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/western.wad -warp 01M", "western.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/westgrfx.wad -warp 01M", "westgrfx.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wetwrkd2.wad -warp 01M", "wetwrkd2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/whackr2.wad -warp 01M", "whackr2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/whare152.wad -warp 01M", "whare152.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wheel2.wad -warp 01M", "wheel2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/whipme2.wad -warp 01M", "whipme2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/white2.wad -warp 01M", "white2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wicked2.wad -warp 01M", "wicked2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/widowmk2.wad -warp 01M", "widowmk2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/william2.wad -warp 01M", "william2.wad (Map 1 to map 3)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/win72.wad -warp 01M", "win72.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/windows.wad -warp 01M", "windows.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wireles2.wad -warp 01M", "wireles2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wish.wad -warp 01M", "wish.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wizdm201.wad -warp 01M", "wizdm201.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wizdoom2.wad -warp 01M", "wizdoom2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wolf.wad -warp 01M", "wolf.wad (Map 1 to map 4)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wolf2.wad -warp 01M", "wolf2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/woody.wad -warp 01M", "woody.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/wyb_e2m2.wad -warp 01M", "wyb_e2m2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/xcal1.wad -warp 01M", "xcal1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/xeno112.wad -warp 01M", "xeno112.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/xfire2.wad -warp 01M", "xfire2.wad (Map 1 to map 3)"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/x-ings2.wad -warp 01M", "x-ings2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/yakworl2.wad -warp 01M", "yakworl2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/yapper1.wad -warp 01M", "yapper1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/ycrbych2.wad -warp 01M", "ycrbych2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/yerdeath.wad -warp 10M", "yerdeath.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/yoho2.wad -warp 01M", "yoho2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/young12.wad -warp 01M", "young12.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/yourded2.wad -warp 01M", "yourded2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/zeus2.wad -warp 01M", "zeus2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -merge maximum2/zippy1.wad -warp 01M", "zippy1.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/zmaze112.wad -warp 01M", "!csre2m2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/zone2.wad -warp 01M", "zone2.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/zone2-x.wad -warp 01M", "zone2-x.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/zone132.wad -warp 01M", "zone132.wad"));
            comboBox12.Items.Add(new Item("-iwad DOOM2.WAD -file maximum2/zorf2.wad -warp 01M", "zorf2.wad"));
            comboBox13.Items.Add(new Item(" -server -coop", "Cooperative"));
            comboBox13.Items.Add(new Item(" -server -deathmatch", "Deathmatch"));
            comboBox13.Items.Add(new Item(" -server -altdeath", "Deathmatch 2.0"));
            comboBox14.Items.Add(new Item(" -timer 1", "1"));
            comboBox14.Items.Add(new Item(" -timer 2", "2"));
            comboBox14.Items.Add(new Item(" -timer 3", "3"));
            comboBox14.Items.Add(new Item(" -timer 4", "4"));
            comboBox14.Items.Add(new Item(" -timer 5", "5"));
            comboBox14.Items.Add(new Item(" -timer 6", "6"));
            comboBox14.Items.Add(new Item(" -timer 7", "7"));
            comboBox14.Items.Add(new Item(" -timer 8", "8"));
            comboBox14.Items.Add(new Item(" -timer 9", "9"));
            comboBox14.Items.Add(new Item(" -timer 10", "10"));
            comboBox14.Items.Add(new Item(" -timer 11", "11"));
            comboBox14.Items.Add(new Item(" -timer 12", "12"));
            comboBox14.Items.Add(new Item(" -timer 13", "13"));
            comboBox14.Items.Add(new Item(" -timer 14", "14"));
            comboBox14.Items.Add(new Item(" -timer 15", "15"));
            comboBox14.Items.Add(new Item(" -timer 16", "16"));
            comboBox14.Items.Add(new Item(" -timer 17", "17"));
            comboBox14.Items.Add(new Item(" -timer 18", "18"));
            comboBox14.Items.Add(new Item(" -timer 19", "19"));
            comboBox14.Items.Add(new Item(" -timer 20", "20"));
            comboBox14.Items.Add(new Item(" -timer 21", "21"));
            comboBox14.Items.Add(new Item(" -timer 22", "22"));
            comboBox14.Items.Add(new Item(" -timer 23", "23"));
            comboBox14.Items.Add(new Item(" -timer 24", "24"));
            comboBox14.Items.Add(new Item(" -timer 25", "25"));
            comboBox14.Items.Add(new Item(" -timer 26", "26"));
            comboBox14.Items.Add(new Item(" -timer 27", "27"));
            comboBox14.Items.Add(new Item(" -timer 28", "28"));
            comboBox14.Items.Add(new Item(" -timer 29", "29"));
            comboBox14.Items.Add(new Item(" -timer 30", "30"));
            comboBox14.Items.Add(new Item(" -timer 31", "31"));
            comboBox14.Items.Add(new Item(" -timer 32", "32"));
            comboBox14.Items.Add(new Item(" -timer 33", "33"));
            comboBox14.Items.Add(new Item(" -timer 34", "34"));
            comboBox14.Items.Add(new Item(" -timer 35", "35"));
            comboBox14.Items.Add(new Item(" -timer 36", "36"));
            comboBox14.Items.Add(new Item(" -timer 37", "37"));
            comboBox14.Items.Add(new Item(" -timer 38", "38"));
            comboBox14.Items.Add(new Item(" -timer 39", "39"));
            comboBox14.Items.Add(new Item(" -timer 40", "40"));
            comboBox14.Items.Add(new Item(" -timer 41", "41"));
            comboBox14.Items.Add(new Item(" -timer 42", "42"));
            comboBox14.Items.Add(new Item(" -timer 43", "43"));
            comboBox14.Items.Add(new Item(" -timer 44", "44"));
            comboBox14.Items.Add(new Item(" -timer 45", "45"));
            comboBox14.Items.Add(new Item(" -timer 46", "46"));
            comboBox14.Items.Add(new Item(" -timer 47", "47"));
            comboBox14.Items.Add(new Item(" -timer 48", "48"));
            comboBox14.Items.Add(new Item(" -timer 49", "49"));
            comboBox14.Items.Add(new Item(" -timer 50", "50"));
            comboBox14.Items.Add(new Item(" -timer 51", "51"));
            comboBox14.Items.Add(new Item(" -timer 52", "52"));
            comboBox14.Items.Add(new Item(" -timer 53", "53"));
            comboBox14.Items.Add(new Item(" -timer 54", "54"));
            comboBox14.Items.Add(new Item(" -timer 55", "55"));
            comboBox14.Items.Add(new Item(" -timer 56", "56"));
            comboBox14.Items.Add(new Item(" -timer 57", "57"));
            comboBox14.Items.Add(new Item(" -timer 58", "58"));
            comboBox14.Items.Add(new Item(" -timer 59", "59"));
            comboBox14.Items.Add(new Item(" -timer 60", "60"));
            comboBox15.Items.Add(new Item(" -nodes 1", "1"));
            comboBox15.Items.Add(new Item(" -nodes 2", "2"));
            comboBox15.Items.Add(new Item(" -nodes 3", "3"));
            comboBox15.Items.Add(new Item(" -nodes 4", "4"));
            comboBox16.Items.Add(new Item(" -turbo 10x%", "10"));
            comboBox16.Items.Add(new Item(" -turbo 20x%", "20"));
            comboBox16.Items.Add(new Item(" -turbo 30x%", "30"));
            comboBox16.Items.Add(new Item(" -turbo 40x%", "40"));
            comboBox16.Items.Add(new Item(" -turbo 50x%", "50"));
            comboBox16.Items.Add(new Item(" -turbo 60x%", "60"));
            comboBox16.Items.Add(new Item(" -turbo 70x%", "70"));
            comboBox16.Items.Add(new Item(" -turbo 80x%", "80"));
            comboBox16.Items.Add(new Item(" -turbo 90x%", "90"));
            comboBox16.Items.Add(new Item(" -turbo 100x%", "100"));
            comboBox16.Items.Add(new Item(" -turbo 110x%", "110"));
            comboBox16.Items.Add(new Item(" -turbo 120x%", "120"));
            comboBox16.Items.Add(new Item(" -turbo 130x%", "130"));
            comboBox16.Items.Add(new Item(" -turbo 140x%", "140"));
            comboBox16.Items.Add(new Item(" -turbo 150x%", "150"));
            comboBox16.Items.Add(new Item(" -turbo 160x%", "160"));
            comboBox16.Items.Add(new Item(" -turbo 170x%", "170"));
            comboBox16.Items.Add(new Item(" -turbo 180x%", "180"));
            comboBox16.Items.Add(new Item(" -turbo 190x%", "190"));
            comboBox16.Items.Add(new Item(" -turbo 200x%", "200"));
            comboBox16.Items.Add(new Item(" -turbo 210x%", "210"));
            comboBox16.Items.Add(new Item(" -turbo 220x%", "220"));
            comboBox16.Items.Add(new Item(" -turbo 230x%", "230"));
            comboBox16.Items.Add(new Item(" -turbo 240x%", "240"));
            comboBox16.Items.Add(new Item(" -turbo 250x%", "250"));
            comboBox16.Items.Add(new Item(" -turbo 260x%", "260"));
            comboBox16.Items.Add(new Item(" -turbo 270x%", "270"));
            comboBox16.Items.Add(new Item(" -turbo 280x%", "280"));
            comboBox16.Items.Add(new Item(" -turbo 290x%", "290"));
            comboBox16.Items.Add(new Item(" -turbo 300x%", "300"));
            comboBox16.Items.Add(new Item(" -turbo 310x%", "310"));
            comboBox16.Items.Add(new Item(" -turbo 320x%", "320"));
            comboBox16.Items.Add(new Item(" -turbo 330x%", "330"));
            comboBox16.Items.Add(new Item(" -turbo 340x%", "340"));
            comboBox16.Items.Add(new Item(" -turbo 350x%", "350"));
            comboBox16.Items.Add(new Item(" -turbo 360x%", "360"));
            comboBox16.Items.Add(new Item(" -turbo 370x%", "370"));
            comboBox16.Items.Add(new Item(" -turbo 380x%", "380"));
            comboBox16.Items.Add(new Item(" -turbo 390x%", "390"));
            comboBox16.Items.Add(new Item(" -turbo 400x%", "400"));
            comboBox17.Items.Add(new Item(" -server -coop", "Cooperative"));
            comboBox17.Items.Add(new Item(" -server -deathmatch", "Deathmatch"));
            comboBox17.Items.Add(new Item(" -server -altdeath", "Deathmatch 2.0"));
            comboBox18.Items.Add(new Item(" -timer 1", "1"));
            comboBox18.Items.Add(new Item(" -timer 2", "2"));
            comboBox18.Items.Add(new Item(" -timer 3", "3"));
            comboBox18.Items.Add(new Item(" -timer 4", "4"));
            comboBox18.Items.Add(new Item(" -timer 5", "5"));
            comboBox18.Items.Add(new Item(" -timer 6", "6"));
            comboBox18.Items.Add(new Item(" -timer 7", "7"));
            comboBox18.Items.Add(new Item(" -timer 8", "8"));
            comboBox18.Items.Add(new Item(" -timer 9", "9"));
            comboBox18.Items.Add(new Item(" -timer 10", "10"));
            comboBox18.Items.Add(new Item(" -timer 11", "11"));
            comboBox18.Items.Add(new Item(" -timer 12", "12"));
            comboBox18.Items.Add(new Item(" -timer 13", "13"));
            comboBox18.Items.Add(new Item(" -timer 14", "14"));
            comboBox18.Items.Add(new Item(" -timer 15", "15"));
            comboBox18.Items.Add(new Item(" -timer 16", "16"));
            comboBox18.Items.Add(new Item(" -timer 17", "17"));
            comboBox18.Items.Add(new Item(" -timer 18", "18"));
            comboBox18.Items.Add(new Item(" -timer 19", "19"));
            comboBox18.Items.Add(new Item(" -timer 20", "20"));
            comboBox18.Items.Add(new Item(" -timer 21", "21"));
            comboBox18.Items.Add(new Item(" -timer 22", "22"));
            comboBox18.Items.Add(new Item(" -timer 23", "23"));
            comboBox18.Items.Add(new Item(" -timer 24", "24"));
            comboBox18.Items.Add(new Item(" -timer 25", "25"));
            comboBox18.Items.Add(new Item(" -timer 26", "26"));
            comboBox18.Items.Add(new Item(" -timer 27", "27"));
            comboBox18.Items.Add(new Item(" -timer 28", "28"));
            comboBox18.Items.Add(new Item(" -timer 29", "29"));
            comboBox18.Items.Add(new Item(" -timer 30", "30"));
            comboBox18.Items.Add(new Item(" -timer 31", "31"));
            comboBox18.Items.Add(new Item(" -timer 32", "32"));
            comboBox18.Items.Add(new Item(" -timer 33", "33"));
            comboBox18.Items.Add(new Item(" -timer 34", "34"));
            comboBox18.Items.Add(new Item(" -timer 35", "35"));
            comboBox18.Items.Add(new Item(" -timer 36", "36"));
            comboBox18.Items.Add(new Item(" -timer 37", "37"));
            comboBox18.Items.Add(new Item(" -timer 38", "38"));
            comboBox18.Items.Add(new Item(" -timer 39", "39"));
            comboBox18.Items.Add(new Item(" -timer 40", "40"));
            comboBox18.Items.Add(new Item(" -timer 41", "41"));
            comboBox18.Items.Add(new Item(" -timer 42", "42"));
            comboBox18.Items.Add(new Item(" -timer 43", "43"));
            comboBox18.Items.Add(new Item(" -timer 44", "44"));
            comboBox18.Items.Add(new Item(" -timer 45", "45"));
            comboBox18.Items.Add(new Item(" -timer 46", "46"));
            comboBox18.Items.Add(new Item(" -timer 47", "47"));
            comboBox18.Items.Add(new Item(" -timer 48", "48"));
            comboBox18.Items.Add(new Item(" -timer 49", "49"));
            comboBox18.Items.Add(new Item(" -timer 50", "50"));
            comboBox18.Items.Add(new Item(" -timer 51", "51"));
            comboBox18.Items.Add(new Item(" -timer 52", "52"));
            comboBox18.Items.Add(new Item(" -timer 53", "53"));
            comboBox18.Items.Add(new Item(" -timer 54", "54"));
            comboBox18.Items.Add(new Item(" -timer 55", "55"));
            comboBox18.Items.Add(new Item(" -timer 56", "56"));
            comboBox18.Items.Add(new Item(" -timer 57", "57"));
            comboBox18.Items.Add(new Item(" -timer 58", "58"));
            comboBox18.Items.Add(new Item(" -timer 59", "59"));
            comboBox18.Items.Add(new Item(" -timer 60", "60"));
            comboBox19.Items.Add(new Item(" -nodes 1", "1"));
            comboBox19.Items.Add(new Item(" -nodes 2", "2"));
            comboBox19.Items.Add(new Item(" -nodes 3", "3"));
            comboBox19.Items.Add(new Item(" -nodes 4", "4"));
            comboBox20.Items.Add(new Item("-skill 1", " I'm too young to die"));
            comboBox20.Items.Add(new Item("-skill 2", "Hey, not too rough"));
            comboBox20.Items.Add(new Item("-skill 3", "Hurt me plenty"));
            comboBox20.Items.Add(new Item("-skill 4", "Ultra-Violence"));
            comboBox20.Items.Add(new Item("-skill 5", "Nightmare!"));



            comboBox1.DisplayMember = "value";
            comboBox2.DisplayMember = "value";
            comboBox3.DisplayMember = "value";
            comboBox4.DisplayMember = "value";
            comboBox5.DisplayMember = "value";
            comboBox7.DisplayMember = "value";
            comboBox8.DisplayMember = "value";
            comboBox9.DisplayMember = "value";
            comboBox10.DisplayMember = "value";
            comboBox11.DisplayMember = "value";
            comboBox12.DisplayMember = "value";
            comboBox13.DisplayMember = "value";
            comboBox14.DisplayMember = "value";
            comboBox15.DisplayMember = "value";
            comboBox16.DisplayMember = "value";
            comboBox17.DisplayMember = "value";
            comboBox18.DisplayMember = "value";
            comboBox19.DisplayMember = "value";
            comboBox20.DisplayMember = "value";

            comboBox2.SelectedIndex = 2;
            comboBox4.SelectedIndex = 2;
            comboBox3.SelectedIndex = 1;
            comboBox5.Enabled = true;
         
            
            comboBox20.SelectedIndex = 2;


            this.comboBox1.Enabled = false;
            this.comboBox7.Enabled = false;
            this.comboBox8.Enabled = false;
            this.comboBox9.Visible = false;
            this.comboBox10.Visible = false;
            this.comboBox14.Visible = false;
            this.comboBox15.Visible = false;
            this.comboBox12.Enabled = false;
            this.comboBox13.Enabled = false;
            this.comboBox16.Enabled = false;
            this.textBox11.Visible = false;
            this.textBox12.Visible = false;
            this.textBox14.Visible = false;
            this.textBox17.Visible = false;
            this.textBox19.Visible = false;
            this.textBox20.Visible = false;
            this.textBox23.Visible = false;
            this.textBox24.Visible = false;
            this.textBox25.Visible = false;
            this.comboBox17.Enabled = false;
            this.comboBox18.Visible = false;
            this.comboBox19.Visible = false;


            string[] colorNames = { "Black", "Blue (Navy)", "Green", "Cyan (Teal)", "Red (Maroon)", "Magenta (Purple)", "Brown (Olive)", "Light Gray (Silver)", "Dark Gray", "Bright Blue", "Bright Green", "Bright Cyan", "Bright Red", "Bright Magenta", "Bright Yellow", "Bright White" };

            listBoxBackground.Items.AddRange(colorNames);
            listBoxText.Items.AddRange(colorNames);




            string[] cleanBackgroundNames = {
        "Black", "Green", "Blue (Navy)", "Cyan (Teal)",
        "Red (Maroon)", "Magenta (Purple)", "Brown (Olive)", "Gray",
        "Dark Gray", "Steel Blue", "Sage Green", "Muted Cyan",
        "Coral Red", "Muted Magenta", "Muted Yellow", "Parchment White"
    };

            string[] cleanTextNames = {
        "Black", "Vivid Blue", "Clear Green", "Clear Cyan",
        "Clear Red", "Clear Magenta", "Amber Gold", "White",
        "Platinum Gray", "Bright Blue", "Bright Green", "Bright Cyan",
        "Bright Red", "Bright Magenta", "Bright Yellow", "Clear Silver"
    };


            listBoxBackground.Items.Clear();
            listBoxText.Items.Clear();

            listBoxBackground.Items.AddRange(cleanBackgroundNames);
            listBoxText.Items.AddRange(cleanTextNames);


            trackBar1.Minimum = 10;
            trackBar1.Maximum = 90;
            trackBar1.Value = 50;

            trackBar2.Minimum = 10;
            trackBar2.Maximum = 90;
            trackBar2.Value = 50;

            backgroundBrightnessPercent = 50;
            textBrightnessPercent = 50;


            if (Properties.Settings.Default.SelectedBackgroundIndex == 0 && Properties.Settings.Default.SelectedTextIndex == 0)
            {
                Properties.Settings.Default.SelectedBackgroundIndex = 1;
                Properties.Settings.Default.SelectedTextIndex = 7;
                Properties.Settings.Default.BackgroundBrightness = 50;
                Properties.Settings.Default.TextBrightness = 50;
                Properties.Settings.Default.Save();
            }


            backgroundBrightnessPercent = Properties.Settings.Default.BackgroundBrightness;
            textBrightnessPercent = Properties.Settings.Default.TextBrightness;


            trackBar1.Minimum = 10;
            trackBar1.Maximum = 90;
            trackBar1.Value = backgroundBrightnessPercent;

            trackBar2.Minimum = 10;
            trackBar2.Maximum = 90;
            trackBar2.Value = textBrightnessPercent;


            listBoxBackground.SelectedIndex = Properties.Settings.Default.SelectedBackgroundIndex;
            listBoxText.SelectedIndex = Properties.Settings.Default.SelectedTextIndex;


            currentMSDOSBackground = AdjustColorLuminance(MSDOSBackgroundBasePalette[listBoxBackground.SelectedIndex], backgroundBrightnessPercent);
            currentMSDOSText = AdjustColorLuminance(MSDOSTextBasePalette[listBoxText.SelectedIndex], textBrightnessPercent);
        }



        private void listBoxBackground_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBoxBackground.SelectedIndex >= 0)
            {
                Properties.Settings.Default.SelectedBackgroundIndex = listBoxBackground.SelectedIndex;
                Properties.Settings.Default.Save();

                System.Drawing.Color rawBase = MSDOSBackgroundBasePalette[listBoxBackground.SelectedIndex];
                currentMSDOSBackground = AdjustColorLuminance(rawBase, backgroundBrightnessPercent);

                int hoverPercent = System.Math.Min(backgroundBrightnessPercent + 12, 90);
                System.Drawing.Color customHover = AdjustColorLuminance(rawBase, hoverPercent);

                ApplyGlobalTheme(tabControl1, currentMSDOSBackground, currentMSDOSText, customHover, customHover);
                this.Refresh();
            }
        }

        private void listBoxText_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBoxText.SelectedIndex >= 0)
            {
                Properties.Settings.Default.SelectedTextIndex = listBoxText.SelectedIndex;
                Properties.Settings.Default.Save();

                System.Drawing.Color rawTextBase = MSDOSTextBasePalette[listBoxText.SelectedIndex];
                currentMSDOSText = AdjustColorLuminance(rawTextBase, textBrightnessPercent);

                System.Drawing.Color rawBgBase = MSDOSBackgroundBasePalette[listBoxBackground.SelectedIndex];
                int hoverPercent = System.Math.Min(backgroundBrightnessPercent + 12, 90);
                System.Drawing.Color customHover = AdjustColorLuminance(rawBgBase, hoverPercent);

                ApplyGlobalTheme(tabControl1, currentMSDOSBackground, currentMSDOSText, customHover, customHover);
                this.Refresh();
            }
        }




        private void button1_MouseEnter(object sender, EventArgs e)
        {


            textBox3.Text = " Name: Attack \r\n Author: Tim Willits \r\n Level replaced: Map 01 \r\n \r\n\"Master Levels: Attack\" is the first level in the Master Levels for Doom II, a collection of standalone levels designed by Tim Willits and Theresa Chasar. It serves as a good introduction to the collection, featuring a blend of most weapons and monsters from Doom II. The level involves navigating connected rooms, finding keys to unlock new areas, and battling a variety of enemies, including Pinkies, Imps, and Chaingunners. ";

            textBox3.Visible = true;

            pictureBox1.Image = imagen2;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {


            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";
            pictureBox1.Image = imagen1;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Black Tower \r\n Author: Sverre Andre Kvernmo \"Cranium\" \r\n Level replaced: Map 25 \r\n \r\nThe \"Black Tower\" is considered one of the most memorable and difficult maps of the Master Levels for Doom II, a single-player map designed by Sverre Kvernmo (Cranium). The player must ascend the Black Tower to confront the Cyberdemon Chagrin, a former friend now leading Hell's forces, defeat him, and escape. The level features a massive, complex layout, showcasing impressive level design and technical skill with elements like illusion of depth, well-manicured demonic lawns, and interactive architectural components that create a sense of progression as the player climbs the tower. ";
            textBox3.Visible = true;


            pictureBox1.Image = imagen4;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";
            pictureBox1.Image = imagen3;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {


            textBox3.Text = " Name: Bloodsea Keep \r\n Author: Sverre Andre Kvernmo \"Cranium\" \r\n Level replaced: Map 07 \r\n \r\nThe Bloodsea Keep is a challenging, non-linear map from the Master Levels for Doom II, designed by Sverre Andre Kvernmo, featuring a central blood-red pool, three keys, and hidden areas. The map's design involves navigating through a series of interconnected sections, often requiring backtracking, to find secrets and progress, with enemies like Cacodemons and Lost Souls swarming the player from the surrounding blood sea. Key features include a pier leading to a large central chamber and a unique pier structure, with a visplane overflow bug possible in the south-west corner. ";


            textBox3.Visible = true;
            pictureBox1.Image = imagen6;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen5;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {


            textBox3.Text = " Name: Canyon \r\n Author: Tim Willits \r\n Level replaced: Map 01 \r\n \r\nThe Master Levels for Doom II Canyon (MAP01) is a level with non-linear architecture, featuring a central courtyard with a toxic river, ledges, and a keycard tower, leading to a network of interconnected rooms and hallways that require navigating to find the red, blue, and yellow keys to progress and exit. Notable features include multiple routes, a \"poisonfall\" area, and several secrets, with a layered design that distinguishes it from a straightforward tech base through its unique architecture. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen8;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen7;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: The Catwalk \r\n Author: Christen David Klie \r\n Level replaced: Map 01 \r\n \r\nThe \"Catwalk\" is a level from the Master Levels for Doom II that features a long, central catwalk over a hazardous pit, requiring careful navigation and combat with enemies like Imps and Chaingunners. Players must activate switches along the catwalk to progress, eventually revealing hidden paths and the necessary keys to exit the level, often while dealing with precarious enemy placement and the risk of falling into the deadly pit below. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen10;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen9;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: The Combine \r\n Author: Christen David Klie \r\n Level replaced: Map 01 \r\n \r\n\"MAP01: The Combine\" is a 1995 Master Level for Doom II designed by Chris Klie. Players start in a courtyard, then navigate a series of interconnected rooms with a central focus on collecting a blue skull key, which is found after dropping into a nukage river and using a red teleporter. The map features several key areas, including a six-door room, a bridge, a room with a narrow walkway over nukage, and a chamber for the red key. Key items and traps include a megaarmor, the plasma gun, a partial invisibility powerup, and a crusher trap. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen12;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen11;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: The Fistula \r\n Author: Christen David Klie \r\n Level replaced: Map 01 \r\n \r\nThe Fistula is a maze-like, puzzle-focused Doom II Master Level where challenge comes primarily from finding keys and navigating its confusing criss-crossing layout rather than combat difficulty. Key elements include an Arch-vile encounter in a southern outdoor area, an intricate network of interconnected rooms and hallways, and multiple interactive elements to reveal the yellow skull key. The map features one secret, a room with Imps and a Chaingun. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen14;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen13;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: The Garrison \r\n Author: Christen David Klie \r\n Level replaced: Map 01 \r\n \r\nThe \"Garrison\" is Master Level 01 (MAP01) for DOOM II, featuring a castle-themed layout with both outdoor ramparts and underground caverns, and a heavy emphasis on managing limited ammo against a large number of hitscanners and imps. The level's primary challenge is a tricky key-hunting sequence where you must interact with switches and teleporters to progress. After collecting the blue key from the underground area and returning to the starting area, you can unlock the path to the next section and eventually exit the level. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen16;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen15;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Geryon: 6th Canto of INFERNO \r\n Author: John W. Anderson \" Dr Sleep\" \r\n Level replaced: Map 08 \r\n \r\nGeryon is a linear, relatively open Doom 2 Master Level with a blood-filled river, an outdoor courtyard, and an indoor area with large steps leading to a central platform. Players start by picking up items on the western side before dropping into a valley and following the blood river to the west to find a Backpack. The path then leads through a building with optional areas, up large stairs to a platform, and then to an outdoor courtyard featuring a Mancubus and Revenant. A key element is the slime pool, which can be raised by a switch to access a SoulSphere on a pillar. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen18;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen17;
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Titan Manor \r\n Author: Jim Flynn \r\n Level replaced: Map 01 \r\n \r\nTitan Manor is a MAP01 replacement map for Master Levels for Doom II by Jim Flynn, set on the alien surface of Titan, the moon of Saturn. The map is characterized by a large, rectangular perimeter with an exterior moat and pitch-black areas, making it challenging to spot monsters like Arachnotrons and Mancubuses. Players must explore the dark manor, utilizing its two main interior structures and numerous secrets, to find advanced technology for the Federation while navigating various monsters and environmental hazards. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen20;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen19;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Mephisto's Maosoleum \r\n Author: Sverre Andre Kvernmo \"Cranium\" \r\n Level replaced: Map 07 \r\n \r\nMAP07: Mephisto's Mausoleum is a Master Level for Doom II that begins with the player in the northeast of the map, facing a mausoleum with a teleporter on its west side. Entering the teleporter takes the player inside the mausoleum, where they must kill caged Mancubi to reveal Arachnotrons and Hell Knights before finding a red skull key and a way back outside. Upon leaving, several monster closets open, and the player must then find a lion switch to enter a tomb, solve its puzzle to get a Megaarmor, and eventually locate the exit. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen22;


        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen21;
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Minos' Judgement: 4th Canto of INFERNO \r\n Author: John W. Anderson \" Dr Sleep\" \r\n Level replaced: Map 05 \r\n \r\nThe Master Levels map Minos' Judgment is the \"Fourth Canto\" of Dr. Sleep's Inferno series, a large and complex map featuring a marble area, an indoor room with deadly crossfire and traps, a sewer-like nukage reservoir for the blue key, and a beautiful southwestern area with a distinctive staircase and more traps. The map culminates in a massive, trap-filled courtyard in the northeastern area with a central platform and enemies firing from all sides. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen24;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen23;
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Nessus: 5th Canto of INFERNO \r\n Author: John W. Anderson \" Dr Sleep\" \r\n Level replaced: Map 07 \r\n \r\nNessus is a smaller, more intricate Master Level for Doom II designed by John Anderson, featuring no keys and only one secret. Players should expect a dense, complex level with multiple paths and strategic enemy encounters, requiring careful exploration to locate powerful weapons like the BFG and Super Shotgun and access the exit through a specific button press after defeating a Baron of Hell and Hell Knight in the west. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen26;

        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen25;
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Paradox \r\n Author: Tom Mustaine \r\n Level replaced: Map 01 \r\n \r\n\"Paradox\" is a tricky, non-linear level centered around a large castle with guard towers, where players must clear passages and gather keys to access the inner fort and its rewards. Designed for extreme planning, it features numerous secret areas, including an illusionary wall, an extended great hall with a secret outdoor area, and an underground section with a megasphere. The level requires careful ammo management, as resources are placed in key strategic locations, but enough are provided to complete the level even from a pistol start. ";



            textBox3.Visible = true;

            pictureBox1.Image = imagen28;

        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen27;


        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Subspace \r\n Author: Christen David Klie \r\n Level replaced: Map 01 \r\n \r\nMaster Levels for Doom II's \"Subspace\" (MAP01) is a map by Chris Klie that features a central, multi-level structure with a yellow key puzzle, isolated man-made outposts, and an underground tunnel system connecting to the southern part of the map. The map's design includes a unique floating switchbox, a challenging yellow key puzzle requiring players to think outside the box, and several secrets, including a megasphere and soul sphere, that are easily accessible after the initial encounters. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen30;


        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen29;


        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Subterra \r\n Author: Christen David Klie \r\n Level replaced: Map 01 \r\n \r\nThe \"Subterra\" map from Master Levels for Doom II involves starting in a hole that rises to a central courtyard, fighting Imps on ledges, and navigating multiple interconnected rooms and teleporters to find keys and reach the exit. The map features high ledges, multi-level areas, and teleporters to access different sections, requiring players to explore to find the Red Skull Key, Yellow Key, and Blue Key to progress and defeat enemies like Hell Knights and Barons. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen32;

        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen31;

        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: The Express Elevator to Hell \r\n Author: Sverre Andre Kvernmo \"Cranium\" \r\n Level replaced: Map 31 \r\n \r\n\"The Express Elevator to Hell\" is a map where players are trapped on a descending elevator surrounded by enemies, requiring them to visit eight labeled floors in order to progress towards the exit. Each floor presents unique challenges and traps, such as the initial ambush of Chaingunners and Hell Knights, locked doors that require switches to open, and a secret exit achievable only through a risky Arch-Vile Jump. The level features interconnected areas, some accessed via teleporters or requiring the use of optional keycards for the secret exit, all revolving around the central, continuously moving elevator. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen34;

        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen33;
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Trapped on Titan \r\n Author: Jim Flynn \r\n Level replaced: Map 01 \r\n \r\n\"Trapped on Titan\" is a challenging level where players navigate a complex, interconnected facility to find the exit. The map is known for its intense combat encounters, including multiple Arch-Viles and other powerful enemies, and features several key-based locked areas and secret passages. Players must carefully collect the yellow, red, and blue keys to unlock different sections of the sprawling industrial map and eventually make their way to the exit teleporter located in the southern courtyard area. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen36;


        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen35;


        }

        private void button19_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Vesperas: 7th Canto of INFERNO \r\n Author: John W. Anderson \"Dr. Sleep\" \r\n Level replaced: Map 09 \r\n \r\nVesperas is a complex, trap-heavy Master Level in Doom II, starting with an exit behind the player but requiring a Blue Key. The level features hidden items behind wall icons, forcing players into a dangerous outer area to acquire weapons and clear enemies. Players must navigate traps and use a combination of lifts, teleporters, and a narrow, invisible ledge to obtain the Yellow and Red Keys before the Blue Key and exit. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen38;


        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen37;


        }

        private void button20_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Virgil's Lead: 3rd Canto of INFERNO \r\n Author: John W. Anderson \"Dr. Sleep\" \r\n Level replaced: Map 03 \r\n \r\nMAP03: Virgil's Lead, a level from the Master Levels for Doom II, features a design by John W. \"Dr. Sleep\" Anderson, characterized by interconnected marble chambers and techbase-style techbase outdoor areas. Players begin in a marble chamber before moving to a large central marble area and then an outdoor techbase crossroads. They then investigate three circular buildings and a final outdoor area with a blood pool. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen40;


        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen39;


        }

        private void button21_MouseEnter(object sender, EventArgs e)
        {

            textBox3.Text = " Name: Bad dream \r\n Author: Sverre Andre Kvernmo \"Cranium\" \r\n Level replaced: Map 32 \r\n \r\nIn MAP32: Bad Dream, players start in a small room, open a door, and trigger a teleporter by attacking a spiderdemon that gets stuck in the wall, leading to a circular room where picking up an invulnerability activates a slow ceiling crusher to kill overwhelming Cyberdemons. After collecting three colored keys, players use the teleporter to return and open doors with hidden enemies, and flip a switch to exit. ";




            textBox3.Visible = true;

            pictureBox1.Image = imagen42;


        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {

            textBox3.Text = " The Master Levels for Doom II were released on December 26, 1995 by id Software \r\n as an expansion for Doom II.\r\n\r\n The CD contains twenty WAD files created by various authors under contract. The\r\n file TEETH.WAD contains a secret level, so there are a total of 21 levels.";

            pictureBox1.Image = imagen41;


        }

        private void ActualizarNombreJugador(string nuevoNombre)
        {
            if (string.IsNullOrEmpty(nuevoNombre)) return;

           
            string rutaLocalConfig = Path.Combine(Directory.GetCurrentDirectory(), "crispy-doom.cfg");

            
            if (File.Exists(rutaLocalConfig))
            {
                try
                {
                   
                    string[] lineas = File.ReadAllLines(rutaLocalConfig);

                    for (int i = 0; i < lineas.Length; i++)
                    {
                        
                        if (lineas[i].StartsWith("player_name"))
                        {
                            
                            lineas[i] = $"player_name  \"{nuevoNombre}\"";
                            break;
                        }
                    }

                    
                    File.WriteAllLines(rutaLocalConfig, lineas);
                }
                catch
                {
                    
                }
            }
        }






        private string ConstruirLineaDeComandosRedYDemo()
        {
            string parametrosFinales = "";

           
            if (checkBox14.Checked) stringParamAppend(ref parametrosFinales, "-respawn");
            if (checkBox15.Checked) stringParamAppend(ref parametrosFinales, "-fast");
            if (checkBox16.Checked) stringParamAppend(ref parametrosFinales, "-nomonsters");

            
            if (checkBox21.Checked) stringParamAppend(ref parametrosFinales, "-autojoin");
            if (checkBox22.Checked) stringParamAppend(ref parametrosFinales, "-privateserver");

            string ipServidor = textBox12.Text.Trim();
            if (checkBox23.Checked && !string.IsNullOrEmpty(ipServidor))
            {
                stringParamAppend(ref parametrosFinales, $"-connect {ipServidor}");
            }

           
            string demoNameClean = textBox28.Text.Trim().Replace(" ", "-");
            if (!string.IsNullOrEmpty(demoNameClean))
            {
                if (checkBox12.Checked) stringParamAppend(ref parametrosFinales, $"-record {demoNameClean}");
                if (checkBox13.Checked) stringParamAppend(ref parametrosFinales, $"-playdemo {demoNameClean}");
            }

            
            string serverName = textBox11.Text.Trim();
            if (checkBox20.Checked && !string.IsNullOrEmpty(serverName))
            {
                stringParamAppend(ref parametrosFinales, $"-servername \"{serverName}\"");
            }

           
            string puertoServidor = textBox19.Text.Trim();
            if (checkBox38.Checked && !string.IsNullOrEmpty(puertoServidor))
            {
                stringParamAppend(ref parametrosFinales, $"-port {puertoServidor}");
            }

            
            if (!checkBox23.Checked && !string.IsNullOrEmpty(ipServidor))
            {
                stringParamAppend(ref parametrosFinales, ipServidor);
            }

            if (!string.IsNullOrWhiteSpace(textBox37.Text))
            {
                stringParamAppend(ref parametrosFinales, textBox37.Text.Trim());
            }


            return parametrosFinales.Trim();
        }


        private void button23_Click(object sender, EventArgs e)
        {
           
            ActualizarNombreJugador(textBox29.Text.Trim());

            string seccionMerge = "";
            string seccionDeh = "";

           
            if (checkBox47.Checked)
            {
                if (listBox1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select at least one file from the list.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string argumentosWad = "";
                string argumentosDeh = "";

                foreach (FileInfo archivoSeleccionado in listBox1.SelectedItems)
                {
                    string extension = archivoSeleccionado.Extension.ToLower();

                    if (extension == ".wad") argumentosWad += $" \"{archivoSeleccionado.FullName}\"";
                    else if (extension == ".deh" || extension == ".bex") argumentosDeh += $" \"{archivoSeleccionado.FullName}\"";
                }

                if (!string.IsNullOrEmpty(argumentosWad)) seccionMerge = $"-merge {argumentosWad.Trim()}";
                if (!string.IsNullOrEmpty(argumentosDeh)) seccionDeh = $"-deh {argumentosDeh.Trim()}";
            }

            
            string param2 = comboBox2.SelectedItem?.ToString() ?? "";
            string param3 = comboBox3.SelectedItem?.ToString() ?? "";
            string param5 = comboBox5.SelectedItem?.ToString() ?? "";
           
            string param7 = comboBox7.SelectedItem?.ToString() ?? "";
            string param8 = comboBox8.SelectedItem?.ToString() ?? "";
            string param9 = comboBox9.SelectedItem?.ToString() ?? "";
            string param10 = comboBox10.SelectedItem?.ToString() ?? "";

            string argument2 = $"{param2} {param3} {param5} {param7} {param8} {param9} {param10}".Trim();

            
            string parametrosUnificados = ConstruirLineaDeComandosRedYDemo();

            
            string argumentosFinales = $"{seccionMerge} {seccionDeh} {argument2} {parametrosUnificados}".Trim();

           
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "crispy-doom.exe",
                    Arguments = argumentosFinales,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                if (!checkBox47.Checked)
                {
                    psi.RedirectStandardOutput = true;
                }

                using (Process process = Process.Start(psi))
                {
                    if (!checkBox47.Checked && process != null)
                    {
                        string output = process.StandardOutput.ReadToEnd();
                        process.WaitForExit();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Error starting Crispy Doom: The system cannot find the specified file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox6.Checked = false;
            }

            if (checkBox7.Checked)
            {
                checkBox8.Checked = false;
            }
            if (checkBox7.Checked)
            {
                checkBox10.Checked = false;
            }

            if (checkBox7.Checked)
            {
                checkBox43.Checked = false;
            }

            if (checkBox7.Checked)
            {
                checkBox45.Checked = false;
            }
            if (checkBox7.Checked)
            {
                comboBox20.Enabled = false;
                comboBox20.SelectedIndex = -1;
            }
            else
            {
                comboBox20.Enabled = true;
                comboBox20.SelectedIndex = 2;

            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox6.Checked)
            {
                checkBox7.Checked = false;
            }
            if (checkBox6.Checked)
            {
                checkBox43.Checked = false;
            }

            if (checkBox6.Checked)
            {
                checkBox45.Checked = false;
            }

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox8.Checked)
            {
                checkBox7.Checked = false;
            }
            if (checkBox8.Checked)
            {
                checkBox43.Checked = false;
            }

            if (checkBox8.Checked)
            {
                checkBox45.Checked = false;
            }





        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox10.Checked)
            {
                comboBox1.Enabled = true;
                comboBox1.SelectedIndex = 0;
            }
            if (checkBox10.Checked)
            {
                checkBox43.Checked = false;

            }

            if (checkBox10.Checked)
            {
                checkBox45.Checked = false;

            }

            else
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedIndex = -1;
            }
            if (checkBox10.Checked)
            {

                checkBox7.Checked = false;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox18.Checked)
            {
                comboBox7.Enabled = true;
                comboBox7.SelectedIndex = 0;
            }
            else
            {
                comboBox7.Enabled = false;
                comboBox7.SelectedIndex = -1;
            }
        }







        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox17.Checked)
            {


                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox21.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                comboBox5.Enabled = false;
                comboBox5.SelectedIndex = -1;
               

                comboBox2.Enabled = false;
                comboBox2.SelectedIndex = -1;

            }
            else
            {
                if (comboBox3.SelectedIndex == 1)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }
                if (comboBox3.SelectedIndex == 0)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }



                if (comboBox3.SelectedIndex == 2)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }
                if (comboBox3.SelectedIndex == 3)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }

                comboBox2.Enabled = true;
                comboBox2.SelectedIndex = 2;
                comboBox5.Enabled = true;

                


            }

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {

                checkBox16.Checked = false;
                checkBox17.Checked = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {

                checkBox16.Checked = false;
                checkBox17.Checked = false;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                checkBox21.Checked = false;

                checkBox23.Checked = false;
                checkBox10.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox17.Checked = false;
                comboBox2.Enabled = false;
                comboBox2.SelectedIndex = -1;
            }
            else
            {
                comboBox2.Enabled = true;
                comboBox2.SelectedIndex = 2;
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private int GetFormArea(Size size)
        {
            return size.Width;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            float scaleFactor = (float)GetFormArea(control.Size) / (float)_lastFormSize;

            ResizeFont(this.Controls, scaleFactor);

            _lastFormSize = GetFormArea(control.Size);

        }

        private void ResizeFont(Control.ControlCollection coll, float scaleFactor)
        {
            foreach (Control c in coll)
            {
                if (c.HasChildren)
                {
                    ResizeFont(c.Controls, scaleFactor);
                }
                else
                {

                    if (true)
                    {

                        c.Font = new Font(c.Font.FontFamily.Name, c.Font.Size * scaleFactor);
                    }
                }
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                comboBox8.Enabled = true;
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox8.SelectedIndex = 0;

                checkBox21.Checked = false;

                checkBox23.Checked = false;
            }
            else
            {
                comboBox8.Enabled = false;
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;
            }


        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {

                checkBox21.Checked = false;

                checkBox23.Checked = false;
                textBox11.Visible = true;
                textBox11.Text = "your server name";
            }
            else
            {

                textBox11.Visible = false;
                textBox11.Text = "";
            }


        }




        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox4.Checked = false;
                comboBox5.Enabled = false;
                comboBox5.SelectedIndex = -1;
               

                comboBox2.Enabled = false;
                comboBox2.SelectedIndex = -1;
            }
            else
            {


                if (comboBox3.SelectedIndex == 1)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }
                if (comboBox3.SelectedIndex == 0)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }
                if (comboBox3.SelectedIndex == 2)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }
                if (comboBox3.SelectedIndex == 3)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }


                comboBox2.Enabled = true;
                comboBox2.SelectedIndex = 2;
                comboBox5.Enabled = true;

              


            }


        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                checkBox21.Checked = false;
                checkBox23.Checked = false;

            }

        }
        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
            {

                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox22.Checked = false;
                checkBox21.Checked = false;
                checkBox4.Checked = false;
                comboBox5.Enabled = false;
                comboBox5.SelectedIndex = -1;
               


                textBox12.Visible = true;
                comboBox2.Enabled = false;

                comboBox2.SelectedIndex = -1;

            }
            else
            {

                if (comboBox3.SelectedIndex == 1)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }
                if (comboBox3.SelectedIndex == 0)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }
                if (comboBox3.SelectedIndex == 2)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }
                if (comboBox3.SelectedIndex == 3)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }

                comboBox5.Enabled = true;

               

                textBox12.Visible = false;
                textBox12.Text = "";
                comboBox2.Enabled = true;
                comboBox2.SelectedIndex = 2;
            }



        }

        private string ConstruirLineaDeComandosMaximumDoom()
        {
            string parametrosFinales = "";

            
            if (checkBox35.Checked) stringParamAppend(ref parametrosFinales, "-respawn");
            if (checkBox34.Checked) stringParamAppend(ref parametrosFinales, "-fast");
            if (checkBox36.Checked) stringParamAppend(ref parametrosFinales, "-nomonsters");

            
            if (checkBox26.Checked) stringParamAppend(ref parametrosFinales, "-autojoin");
            if (checkBox27.Checked) stringParamAppend(ref parametrosFinales, "-privateserver");

            string ipServidor1 = textBox17.Text.Trim();
            if (checkBox28.Checked && !string.IsNullOrEmpty(ipServidor1))
            {
                stringParamAppend(ref parametrosFinales, $"-connect {ipServidor1}");
            }

           
            string demoNameClean = textBox18.Text.Trim().Replace(" ", "-");
            if (!string.IsNullOrEmpty(demoNameClean))
            {
                if (checkBox48.Checked) stringParamAppend(ref parametrosFinales, $"-record {demoNameClean}");
                if (checkBox49.Checked) stringParamAppend(ref parametrosFinales, $"-playdemo {demoNameClean}");
            }

            
            string serverName = textBox14.Text.Trim();
            if (checkBox25.Checked && !string.IsNullOrEmpty(serverName))
            {
                stringParamAppend(ref parametrosFinales, $"-servername \"{serverName}\"");
            }

            
            string puertoServidor2 = textBox20.Text.Trim();
            if (checkBox39.Checked && !string.IsNullOrEmpty(puertoServidor2))
            {
                stringParamAppend(ref parametrosFinales, $"-port {puertoServidor2}");
            }

            
            if (!checkBox28.Checked && !string.IsNullOrEmpty(ipServidor1))
            {
                stringParamAppend(ref parametrosFinales, ipServidor1);
            }

            if (!string.IsNullOrWhiteSpace(textBox39.Text))
            {
                stringParamAppend(ref parametrosFinales, textBox39.Text.Trim());
            }

            return parametrosFinales.Trim();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ActualizarNombreJugador(textBox32.Text.Trim());

            string param10 = comboBox4.SelectedItem?.ToString() ?? "";
            string param11 = comboBox11.SelectedItem?.ToString() ?? "";
            string param12 = comboBox12.SelectedItem?.ToString() ?? "";
            string param13 = comboBox13.SelectedItem?.ToString() ?? "";
            string param14 = comboBox14.SelectedItem?.ToString() ?? "";
            string param15 = comboBox15.SelectedItem?.ToString() ?? "";
            string param16 = comboBox16.SelectedItem?.ToString() ?? "";

            string Argument3 = $"{param10} {param11} {param12} {param13} {param14} {param15} {param16}".Trim();
            string parametrosMaximumUnificados = ConstruirLineaDeComandosMaximumDoom();
            string argumentosFinales = $"{Argument3} {parametrosMaximumUnificados}".Trim();

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "crispy-doom.exe",
                    Arguments = argumentosFinales,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    if (process != null)
                    {
                        string output = process.StandardOutput.ReadToEnd();
                        process.WaitForExit();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error executing the process: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox11.Enabled = true;
                comboBox11.SelectedIndex = 0;
                button24.Enabled = true;
                button24.Text = "Run Maximum Doom";
            }
            else
            {
                comboBox11.Enabled = false;
                comboBox11.SelectedIndex = -1;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox12.Enabled = true;
                comboBox12.SelectedIndex = 0;
                button24.Enabled = true;
                button24.Text = "Run Maximum Doom";

            }
            else
            {
                comboBox12.Enabled = false;
                comboBox12.SelectedIndex = -1;
            }
        }

       private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked)
            {
                checkBox36.Checked = false;
            }
            if (checkBox34.Checked)
            {
                checkBox26.Checked = false;
            }

            if (checkBox34.Checked)
            {
                checkBox28.Checked = false;
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked)
            {
                checkBox36.Checked = false;
            }
            if (checkBox35.Checked)
            {
                checkBox26.Checked = false;
            }

            if (checkBox35.Checked)
            {
                checkBox28.Checked = false;
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox36.Checked)
            {
                checkBox26.Checked = false;
            }
            if (checkBox36.Checked)
            {
                checkBox34.Checked = false;
            }
            if (checkBox36.Checked)
            {
                checkBox35.Checked = false;
            }
            if (checkBox36.Checked)
            {
                checkBox37.Checked = false;
            }

            if (checkBox36.Checked)
            {
                checkBox28.Checked = false;
            }

        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox37.Checked)
            {
                checkBox36.Checked = false;
            }
            if (checkBox37.Checked)
            {
                checkBox26.Checked = false;
            }

            if (checkBox37.Checked)
            {
                checkBox28.Checked = false;
            }
            if (checkBox37.Checked)
            {
                comboBox16.Enabled = true;
                comboBox16.SelectedIndex = 0;
            }
            else
            {
                comboBox16.Enabled = false;
                comboBox16.SelectedIndex = -1;
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
            {
                checkBox26.Checked = false;
            }

            if (checkBox24.Checked)
            {
                checkBox28.Checked = false;
            }
            if (checkBox24.Checked)
            {
                comboBox13.Enabled = true;
                comboBox13.SelectedIndex = 0;
                comboBox14.Visible = true;
                comboBox15.Visible = true;

            }
            else
            {
                comboBox13.Enabled = false;
                comboBox13.SelectedIndex = -1;
                comboBox14.Visible = false;
                comboBox14.SelectedIndex = -1;
                comboBox15.Visible = false;
                comboBox15.SelectedIndex = -1;
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                checkBox26.Checked = false;
            }

            if (checkBox25.Checked)
            {
                checkBox28.Checked = false;
            }
            if (checkBox25.Checked)
            {
                textBox14.Visible = true;
                textBox14.Text = "your server name";

            }
            else
            {
                textBox14.Visible = false;
                textBox14.Text = "";
            }


        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox26.Checked)
            {
                checkBox34.Checked = false;
            }
            if (checkBox26.Checked)
            {
                checkBox35.Checked = false;
            }
            if (checkBox26.Checked)
            {
                checkBox36.Checked = false;
            }
            if (checkBox26.Checked)
            {
                checkBox37.Checked = false;
            }
            if (checkBox26.Checked)
            {
                checkBox24.Checked = false;
            }
            if (checkBox26.Checked)
            {
                checkBox25.Checked = false;
            }
            if (checkBox26.Checked)
            {
                checkBox27.Checked = false;
            }
            if (checkBox26.Checked)
            {
                checkBox28.Checked = false;
            }
            if (checkBox26.Checked)
            {
                checkBox30.Checked = false;
            }
            if (checkBox26.Checked)
            {
                comboBox4.Enabled = false;
                comboBox4.SelectedIndex = -1;

            }
            else
            {
                comboBox4.Enabled = true;
                comboBox4.SelectedIndex = 2;

            }

        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox27.Checked)
            {
                checkBox26.Checked = false;
            }
            if (checkBox27.Checked)
            {
                checkBox28.Checked = false;
            }

        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox28.Checked)
            {
                checkBox34.Checked = false;
            }
            if (checkBox28.Checked)
            {
                checkBox35.Checked = false;
            }
            if (checkBox28.Checked)
            {
                checkBox36.Checked = false;
            }
            if (checkBox28.Checked)
            {
                checkBox37.Checked = false;
            }
            if (checkBox28.Checked)
            {
                checkBox24.Checked = false;
            }
            if (checkBox28.Checked)
            {
                checkBox25.Checked = false;
            }
            if (checkBox28.Checked)
            {
                checkBox26.Checked = false;
            }
            if (checkBox28.Checked)
            {
                checkBox27.Checked = false;
            }
            if (checkBox28.Checked)
            {
                checkBox30.Checked = false;
            }
            if (checkBox28.Checked)
            {
                textBox17.Visible = true;
            }
            if (checkBox28.Checked)
            {
                comboBox4.Enabled = false;
                comboBox4.SelectedIndex = -1;

            }

            else
            {
                textBox17.Visible = false;
                textBox17.Text = "";
                comboBox4.Enabled = true;
                comboBox4.SelectedIndex = 2;

            }

        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox38.Checked)
            {
                textBox19.Visible = true;
                textBox19.Text = "2342";
            }
            else
            {
                textBox19.Visible = false;
                textBox19.Text = "";

            }

        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox39.Checked)
            {
                textBox20.Visible = true;
                textBox20.Text = "2342";
            }
            else
            {
                textBox20.Visible = false;
                textBox20.Text = "";
            }
        }

      

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox43.Checked)
            {
                checkBox7.Checked = false;
            }
            if (checkBox43.Checked)
            {
                checkBox40.Checked = false;
            }
            if (checkBox43.Checked)
            {
                checkBox41.Checked = false;
            }

            if (checkBox43.Checked)
            {
                checkBox44.Checked = false;
            }
            if (checkBox43.Checked)
            {
                checkBox45.Checked = false;
            }
            if (checkBox43.Checked)
            {
                checkBox8.Checked = false;
            }
            if (checkBox43.Checked)
            {
                checkBox10.Checked = false;
            }
            if (checkBox43.Checked)
            {
                checkBox29.Checked = false;
            }
            if (checkBox43.Checked)
            {
                comboBox20.Enabled = false;
                comboBox20.SelectedIndex = -1;
            }
            else
            {
                comboBox20.Enabled = true;
                comboBox20.SelectedIndex = 2;

            }
        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox44.Checked)
            {
                checkBox43.Checked = false;
            }
            if (checkBox44.Checked)
            {
                checkBox45.Checked = false;
            }
        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox45.Checked)
            {
                checkBox7.Checked = false;
            }
            if (checkBox45.Checked)
            {
                checkBox40.Checked = false;
            }
            if (checkBox45.Checked)
            {
                checkBox41.Checked = false;
            }

            if (checkBox45.Checked)
            {
                checkBox43.Checked = false;
            }
            if (checkBox45.Checked)
            {
                checkBox44.Checked = false;
            }
            if (checkBox45.Checked)
            {
                checkBox8.Checked = false;
            }
            if (checkBox45.Checked)
            {
                checkBox10.Checked = false;
            }
            if (checkBox45.Checked)
            {
                checkBox29.Checked = false;
            }

            if (checkBox45.Checked)
            {
                textBox25.Visible = true;
                comboBox20.Enabled = false;
                comboBox20.SelectedIndex = -1;

            }
            else
            {

                comboBox20.Enabled = true;
                comboBox20.SelectedIndex = 2;
                textBox25.Visible = false;
                textBox25.Text = "";


            }
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox40.Checked)
            {
                checkBox43.Checked = false;
            }

            if (checkBox40.Checked)
            {
                checkBox45.Checked = false;
            }




            if (checkBox40.Checked)
            {
                comboBox17.Enabled = true;
                comboBox18.Visible = true;
                comboBox19.Visible = true;
                comboBox17.SelectedIndex = 0;
            }
            else
            {
                comboBox17.Enabled = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox17.SelectedIndex = -1;
                comboBox18.SelectedIndex = -1;
                comboBox19.SelectedIndex = -1;
            }
        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox41.Checked)
            {
                checkBox43.Checked = false;
            }

            if (checkBox41.Checked)
            {
                checkBox45.Checked = false;
            }


            if (checkBox41.Checked)
            {
                textBox23.Visible = true;
                textBox23.Text = "your server name";
            }
            else
            {
                textBox23.Visible = false;
                textBox23.Text = "";
            }
        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox42.Checked)
            {
                textBox24.Visible = true;
                textBox24.Text = "2342";
            }
            else
            {
                textBox24.Visible = false;
                textBox24.Text = "";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos Doom (*.wad;*.deh)|*.wad;*.deh|Archivos WAD (*.wad)|*.wad|Archivos DEH (*.deh)|*.deh|Todos los archivos (*.*)|*.*";
                ofd.Multiselect = true;
                ofd.Title = "Select your WAD and DEH files";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();

                    foreach (string rutaCompleta in ofd.FileNames)
                    {


                        FileInfo archivo = new FileInfo(rutaCompleta);
                        listBox1.Items.Add(archivo);
                    }
                }
            }
        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox47.Checked)
            {
                button25.Enabled = true;
                button25.Text = "Browse";
                listBox1.Visible = true;
            }


            else
            {
                button25.Enabled = false;
                button25.Text = "";
                listBox1.Visible = false;

            }
        }

       

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = comboBox3.SelectedIndex;

            switch (indiceSeleccionado)
            {
                case 1:
                    { 
                        
                        

                        List<Item> listaDoom2 = new List<Item>
                    {
                        new Item("-warp 01", "MAP01: Entryway"),
                        new Item("-warp 02", "MAP02: Underhalls"),
                        new Item("-warp 03", "MAP03: The Gantlet"),
                        new Item("-warp 04", "MAP04: The Focus"),
                        new Item("-warp 05", "MAP05: The Waste Tunnels"),
                        new Item("-warp 06", "MAP06: The Crusher"),
                        new Item("-warp 07", "MAP07: Dead Simple"),
                        new Item("-warp 08", "MAP08: Tricks and Traps"),
                        new Item("-warp 09", "MAP09: The Pit"),
                        new Item("-warp 10", "MAP10: Refueling Base"),
                        new Item("-warp 11", "MAP11: Circle of Death"),
                        new Item("-warp 12", "MAP12: The Factory"),
                        new Item("-warp 13", "MAP13: Downtown"),
                        new Item("-warp 14", "MAP14: The Inmost Dens"),
                        new Item("-warp 15", "MAP15: Industrial Zone"),
                        new Item("-warp 16", "MAP16: Suburbs"),
                        new Item("-warp 17", "MAP17: Tenements"),
                        new Item("-warp 18", "MAP18: The Courtyard"),
                        new Item("-warp 19", "MAP19: The Citadel"),
                        new Item("-warp 20", "MAP20: Gotcha!"),
                        new Item("-warp 21", "MAP21: Nirvana"),
                        new Item("-warp 22", "MAP22: The Catacombs"),
                        new Item("-warp 23", "MAP23: Barrels o' Fun"),
                        new Item("-warp 24", "MAP24: The Chasm"),
                        new Item("-warp 25", "MAP25: Bloodfalls"),
                        new Item("-warp 26", "MAP26: The Abandoned Mines"),
                        new Item("-warp 27", "MAP27: Monster Condo"),
                        new Item("-warp 28", "MAP28: The Spirit World"),
                        new Item("-warp 29", "MAP29: The Living End"),
                        new Item("-warp 30", "MAP30: Icon of Sin"),
                        new Item("-warp 31", "MAP31: Wolfenstein"),
                        new Item("-warp 32", "MAP32: Grosse")
                    };

                        comboBox5.DataSource = null;
                        comboBox5.DataSource = listaDoom2;
                        comboBox5.DisplayMember = "Value";
                       
                        comboBox5.SelectedIndex = 0;

                        
                        break;
                    } 

                case 0:
                    {
                       

                        List<Item> listaDoom1 = new List<Item>
                    {
                        new Item("-warp 1 1", "E1M1: Hangar"),
                        new Item("-warp 1 2", "E1M2: Nuclear Plant"),
                        new Item("-warp 1 3", "E1M3: Toxin Refinery"),
                        new Item("-warp 1 4", "E1M4: Command Control"),
                        new Item("-warp 1 5", "E1M5: Phobos Lab"),
                        new Item("-warp 1 6", "E1M6: Central Processing"),
                        new Item("-warp 1 7", "E1M7: Computer Station"),
                        new Item("-warp 1 8", "E1M8: Phobos Anomaly"),
                        new Item("-warp 1 9", "E1M9: Military Base"),
                        new Item("-warp 2 1", "E2M1: Deimos Anomaly"),
                        new Item("-warp 2 2", "E2M2: Containment Area"),
                        new Item("-warp 2 3", "E2M3: Refinery"),
                        new Item("-warp 2 4", "E2M4: Deimos Lab"),
                        new Item("-warp 2 5", "E2M5: Command Center"),
                        new Item("-warp 2 6", "E2M6: Halls of the Damned"),
                        new Item("-warp 2 7", "E2M7: Spawning Vats"),
                        new Item("-warp 2 8", "E2M8: Tower of Babel"),
                        new Item("-warp 2 9", "E2M9: Fortress of Mystery"),
                        new Item("-warp 3 1", "E3M1: Hell Keep"),
                        new Item("-warp 3 2", "E3M2: Slough of Despair"),
                        new Item("-warp 3 3", "E3M3: Pandemonium"),
                        new Item("-warp 3 4", "E3M4: House of Pain"),
                        new Item("-warp 3 5", "E3M5: Unholy Cathedral"),
                        new Item("-warp 3 6", "E3M6: Mt. Erebus"),
                        new Item("-warp 3 7", "E3M7: Limbo"),
                        new Item("-warp 3 8", "E3M8: Dis"),
                        new Item("-warp 3 9", "E3M9: Warrens"),
                        new Item("-warp 4 1", "E4M1: Hell Beneath"),
                        new Item("-warp 4 2", "E4M2: Perfect Hatred"),
                        new Item("-warp 4 3", "E4M3: Sever the Wicked"),
                        new Item("-warp 4 4", "E4M4: Unruly Evil"),
                        new Item("-warp 4 5", "E4M5: They Will Repent"),
                        new Item("-warp 4 6", "E4M6: Against Thee Wickedly"),
                        new Item("-warp 4 7", "E4M7: And Hell Followed"),
                        new Item("-warp 4 8", "E4M8: Unto the Cruel"),
                        new Item("-warp 4 9", "E4M9: Fear"),
                        new Item("-warp 5 1", "E5M1: Baphomet's Demesne"),
                        new Item("-warp 5 2", "E5M2: Sheol"),
                        new Item("-warp 5 3", "E5M3: Cages of the Damned"),
                        new Item("-warp 5 4", "E5M4: Paths of Wretchedness"),
                        new Item("-warp 5 5", "E5M5: Abaddon's Void"),
                        new Item("-warp 5 6", "E5M6: Unspeakable Persecution"),
                        new Item("-warp 5 7", "E5M7: Nightmare Underworld"),
                        new Item("-warp 5 8", "E5M8: Halls of Perdition"),
                        new Item("-warp 5 9", "E5M9: Realm of Iblis"),
                        new Item("-warp 6 1", "E6M1: Cursed Darkness"),
                        new Item("-warp 6 2", "E6M2: Violent Hatred"),
                        new Item("-warp 6 3", "E6M3: Twilight Desolation"),
                        new Item("-warp 6 4", "E6M4: Fragments of Sanity"),
                        new Item("-warp 6 5", "E6M5: Wrathful Reckoning"),
                        new Item("-warp 6 6", "E6M6: Vengeance Unleashed"),
                        new Item("-warp 6 7", "E6M7: Descent Into Terror"),
                        new Item("-warp 6 8", "E6M8: Abyss of Despair"),
                        new Item("-warp 6 9", "E6M9: Shattered Homecoming"),
                       };

                        comboBox5.DataSource = null;
                        comboBox5.DataSource = listaDoom1;
                        comboBox5.DisplayMember = "value";
                       
                        comboBox5.SelectedIndex = 0;

                       
                        break;
                    }
                case 2:
                    { 
                       

                        List<Item> listatnt = new List<Item>
                    {
                        new Item("-warp 01", "MAP01: System Control"),
                        new Item("-warp 02", "MAP02: Human BBQ"),
                        new Item("-warp 03", "MAP03: Power Control"),
                        new Item("-warp 04", "MAP04: Wormhole"),
                        new Item("-warp 05", "MAP05: Hanger"),
                        new Item("-warp 06", "MAP06: Open Season"),
                        new Item("-warp 07", "MAP07: Prison"),
                        new Item("-warp 08", "MAP08: Metal"),
                        new Item("-warp 09", "MAP09: Stronghold"),
                        new Item("-warp 10", "MAP10: Redemption"),
                        new Item("-warp 11", "MAP11: Storage Facility"),
                        new Item("-warp 12", "MAP12: Crater"),
                        new Item("-warp 13", "MAP13: Nukage Processing"),
                        new Item("-warp 14", "MAP14: Steel Works"),
                        new Item("-warp 15", "MAP15: Dead Zone"),
                        new Item("-warp 16", "MAP16: Deepest Reaches"),
                        new Item("-warp 17", "MAP17: Processing Area"),
                        new Item("-warp 18", "MAP18: Mill"),
                        new Item("-warp 19", "MAP19: Shipping/Respawning"),
                        new Item("-warp 20", "MAP20: Central Processing"),
                        new Item("-warp 21", "MAP21: Administration Center"),
                        new Item("-warp 22", "MAP22: Habitat"),
                        new Item("-warp 23", "MAP23: Lunar Mining Project"),
                        new Item("-warp 24", "MAP24: Quarry"),
                        new Item("-warp 25", "MAP25: Baron's Den"),
                        new Item("-warp 26", "MAP26: Ballistyx"),
                        new Item("-warp 27", "MAP27: Mount Pain"),
                        new Item("-warp 28", "MAP28: Heck"),
                        new Item("-warp 29", "MAP29: River Styx"),
                        new Item("-warp 30", "MAP30: Last Call"),
                        new Item("-warp 31", "MAP31: Pharaoh"),
                        new Item("-warp 32", "MAP32: Caribbean")
                    };

                        comboBox5.DataSource = null;
                        comboBox5.DataSource = listatnt;
                        comboBox5.DisplayMember = "value";
                      
                        comboBox5.SelectedIndex = 0;

                        
                       
                        break;
                    } 
                case 3:
                    { 
                       

                        List<Item> listaplutonia = new List<Item>
                    {
                        new Item("-warp 01", "MAP01: Congo"),
                        new Item("-warp 02", "MAP02: Well of Souls"),
                        new Item("-warp 03", "MAP03: Aztec"),
                        new Item("-warp 04", "MAP04: Caged"),
                        new Item("-warp 05", "MAP05: Ghost Town"),
                        new Item("-warp 06", "MAP06: Baron's Lair"),
                        new Item("-warp 07", "MAP07: Caughtyard"),
                        new Item("-warp 08", "MAP08: Realm"),
                        new Item("-warp 09", "MAP09: Abattoire"),
                        new Item("-warp 10", "MAP10: Onslaught"),
                        new Item("-warp 11", "MAP11: Hunted"),
                        new Item("-warp 12", "MAP12: Speed"),
                        new Item("-warp 13", "MAP13: The Crypt"),
                        new Item("-warp 14", "MAP14: Genesis"),
                        new Item("-warp 15", "MAP15: The Twilight"),
                        new Item("-warp 16", "MAP16: The Omen"),
                        new Item("-warp 17", "MAP17: Compound"),
                        new Item("-warp 18", "MAP18: Neurosphere"),
                        new Item("-warp 19", "MAP19: NME"),
                        new Item("-warp 20", "MAP20: The Death Domain"),
                        new Item("-warp 21", "MAP21: Slayer"),
                        new Item("-warp 22", "MAP22: Impossible Mission"),
                        new Item("-warp 23", "MAP23: Tombstone"),
                        new Item("-warp 24", "MAP24: The Final Frontier"),
                        new Item("-warp 25", "MAP25: Temple of Darkness"),
                        new Item("-warp 26", "MAP26: Bunker"),
                        new Item("-warp 27", "MAP27: Anti-Christ"),
                        new Item("-warp 28", "MAP28: The Sewers"),
                        new Item("-warp 29", "MAP29: Odyssey of Noises"),
                        new Item("-warp 30", "MAP30: Gateway of Hell"),
                        new Item("-warp 31", "MAP31: Cyberden"),
                        new Item("-warp 32", "MAP32: Go 2 It")
                    };

                        comboBox5.DataSource = null;
                        comboBox5.DataSource = listaplutonia;
                        comboBox5.DisplayMember = "value";

                        comboBox5.SelectedIndex = 0;

                       
                       
                        break;
                    } 


            }
        }



        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (checkBox17.Checked && comboBox5.SelectedIndex != -1)
            {

                comboBox5.SelectedIndex = -1;
            }
            if (checkBox21.Checked && comboBox5.SelectedIndex != -1)
            {

                comboBox5.SelectedIndex = -1;
            }

            if (checkBox23.Checked && comboBox5.SelectedIndex != -1)
            {

                comboBox5.SelectedIndex = -1;
            }
            if (checkBox13.Checked && comboBox5.SelectedIndex != -1)
            {

                comboBox5.SelectedIndex = -1;
            }

        }


        private void button26_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Archivos LMP|*.lmp";
            openFileDialog1.Title = "Select LMP file";
            openFileDialog1.FileName = "";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string rutaCompleta = openFileDialog1.FileName;


                string nombreArchivo = Path.GetFileName(rutaCompleta);


                textBox27.Text = nombreArchivo;
            }
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox46.Checked)
            {
                checkBox11.Checked = false;
                textBox27.Enabled = true;
            }
            else
            {
                textBox27.Enabled = false;
            }

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox46.Checked = false;
                textBox27.Enabled = true;
                checkBox40.Checked = false;
                checkBox41.Checked = false;
                checkBox42.Checked = false;
                checkBox43.Checked = false;
                checkBox44.Checked = false;
                checkBox45.Checked = false;

                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox10.Checked = false;

                checkBox40.Enabled = false;
                checkBox41.Enabled = false;
                checkBox42.Enabled = false;
                checkBox43.Enabled = false;
                checkBox44.Enabled = false;
                checkBox45.Enabled = false;

                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox10.Enabled = false;

            }
            else
            {
                textBox27.Enabled = false;
                checkBox40.Enabled = true;
                checkBox41.Enabled = true;
                checkBox42.Enabled = true;
                checkBox43.Enabled = true;
                checkBox44.Enabled = true;
                checkBox45.Enabled = true;



                checkBox40.Enabled = true;
                checkBox41.Enabled = true;
                checkBox42.Enabled = true;
                checkBox43.Enabled = true;
                checkBox44.Enabled = true;
                checkBox45.Enabled = true;

                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox10.Enabled = true;


            }


        }

        private void button27_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Archivos LMP|*.lmp";
            openFileDialog1.Title = "Select LMP file";
            openFileDialog1.FileName = "";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string rutaCompleta = openFileDialog1.FileName;


                string nombreArchivo = Path.GetFileName(rutaCompleta);


                textBox28.Text = nombreArchivo;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox13.Checked = false;
                textBox28.Enabled = true;
            }
            else
            {
                textBox28.Enabled = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                checkBox12.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox21.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox38.Checked = false;

                checkBox14.Enabled = false;
                checkBox15.Enabled = false;
                checkBox16.Enabled = false;
                checkBox17.Enabled = false;
                checkBox18.Enabled = false;
                checkBox19.Enabled = false;
                checkBox20.Enabled = false;
                checkBox21.Enabled = false;
                checkBox22.Enabled = false;
                checkBox23.Enabled = false;
                checkBox38.Enabled = false;


                comboBox5.SelectedIndex = -1;
               

                textBox28.Enabled = true;
            }
            else
            {
                if (comboBox3.SelectedIndex == 1)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }
                if (comboBox3.SelectedIndex == 0)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }


                if (comboBox3.SelectedIndex == 2)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }
                if (comboBox3.SelectedIndex == 3)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }


                checkBox14.Enabled = true;
                checkBox15.Enabled = true;
                checkBox16.Enabled = true;
                checkBox17.Enabled = true;
                checkBox18.Enabled = true;
                checkBox19.Enabled = true;
                checkBox20.Enabled = true;
                checkBox21.Enabled = true;
                checkBox22.Enabled = true;
                checkBox23.Enabled = true;
                checkBox38.Enabled = true;


                textBox28.Enabled = false;
            }


        }

        private void button28_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Archivos LMP|*.lmp";
            openFileDialog1.Title = "Select LMP file";
            openFileDialog1.FileName = "";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string rutaCompleta = openFileDialog1.FileName;


                string nombreArchivo = Path.GetFileName(rutaCompleta);


                textBox18.Text = nombreArchivo;
            }
        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox48.Checked)
            {
                checkBox49.Checked = false;
                textBox18.Enabled = true;
            }
            else
            {
                textBox18.Enabled = false;
            }
        }

        private void checkBox49_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox49.Checked)
            {
                checkBox48.Checked = false;
                checkBox34.Checked = false;
                checkBox35.Checked = false;
                checkBox36.Checked = false;
                checkBox37.Checked = false;
                checkBox25.Checked = false;
                checkBox27.Enabled = false;
                checkBox24.Checked = false;
                checkBox39.Checked = false;
                checkBox26.Checked = false;
                checkBox28.Checked = false;


                checkBox34.Enabled = false;
                checkBox35.Enabled = false;
                checkBox36.Enabled = false;
                checkBox37.Enabled = false;
                checkBox24.Enabled = false;
                checkBox25.Enabled = false;
                checkBox27.Enabled = false;
                checkBox39.Enabled = false;
                checkBox26.Enabled = false;
                checkBox28.Enabled = false;





                textBox18.Enabled = true;
            }
            else
            {
                if (comboBox3.SelectedIndex == 1)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }
               
                if (comboBox3.SelectedIndex == 2)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }
                if (comboBox3.SelectedIndex == 3)
                {
                    comboBox5.SelectedIndex = 0;
                    comboBox5.Visible = true;


                }


                checkBox34.Enabled = true;
                checkBox35.Enabled = true;
                checkBox36.Enabled = true;
                checkBox37.Enabled = true;
                checkBox25.Enabled = true;
                checkBox27.Enabled = true;
                checkBox24.Enabled = true;
                checkBox39.Enabled = true;
                checkBox26.Enabled = true;
                checkBox28.Enabled = true;


                textBox18.Enabled = false;
            }


        }

        private async void button29_Click(object sender, EventArgs e)
        {

            await CargarServidoresEnTabla();
        }

        private async Task CargarServidoresEnTabla()
        {
            richTextBox1.Text = "Loading server list from master.chocolate-doom.org...";

            try
            {
                using (HttpClient client = new HttpClient())
                {

                    string html = await client.GetStringAsync(MasterServerUrl);

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);


                    var tableRowNodes = doc.DocumentNode.SelectNodes("//table/tr");

                    if (tableRowNodes == null || tableRowNodes.Count <= 1)
                    {
                        richTextBox1.Text = "No active servers were found at this time.";
                        return;
                    }

                    StringBuilder sb = new StringBuilder();


                    int anchoIp = 26;
                    int anchoNombre = 35;
                    int anchoVersion = 22;
                    int anchoJugadores = 15;


                    sb.AppendLine(new string('=', anchoIp + anchoNombre + anchoVersion + anchoJugadores));
                    sb.AppendLine(
                        "Server Address".PadRight(anchoIp) +
                        "Server Name".PadRight(anchoNombre) +
                        "Version".PadRight(anchoVersion) +
                        "Max Players".PadRight(anchoJugadores)
                    );
                    sb.AppendLine(new string('-', anchoIp + anchoNombre + anchoVersion + anchoJugadores));


                    for (int i = 1; i < tableRowNodes.Count; i++)
                    {
                        var cells = tableRowNodes[i].SelectNodes("td");
                        if (cells != null && cells.Count >= 4)
                        {

                            string ip = cells[0].InnerText.Trim();
                            string nombre = cells[1].InnerText.Trim();
                            string version = cells[2].InnerText.Trim();
                            string jugadores = cells[3].InnerText.Trim();


                            if (nombre.Length > anchoNombre - 3) nombre = nombre.Substring(0, anchoNombre - 4) + "...";
                            if (version.Length > anchoVersion - 3) version = version.Substring(0, anchoVersion - 4) + "...";


                            sb.AppendLine(
                                ip.PadRight(anchoIp) +
                                nombre.PadRight(anchoNombre) +
                                version.PadRight(anchoVersion) +
                                jugadores.PadRight(anchoJugadores)

                           );
                        }
                    }

                    sb.AppendLine(new string('=', anchoIp + anchoNombre + anchoVersion + anchoJugadores));


                    richTextBox1.Text = sb.ToString();


                }
            }
            catch (Exception)
            {
                richTextBox1.Text = $"Error retrieving data: the process cannot continue.";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

       
     
        private async void button30_Click(object sender, EventArgs e)
        {
            string rutaChocolateDoom = "crispy-doom.exe";

            
            if (!File.Exists(rutaChocolateDoom))
            {
                richTextBox1.AppendText("Error: crispy-doom.exe was not found in the directory.\n");
                return;
            }

           
            button4.Enabled = false; 
            richTextBox1.Clear();
            richTextBox1.AppendText("Starting search for local servers...\n");

            
            await Task.Run(() => EjecutarBusquedaLocal(rutaChocolateDoom));

            
            button4.Enabled = true;
            richTextBox1.AppendText("\nSearch finished.\n");
        }

       
        private void EjecutarBusquedaLocal(string rutaExe)
        {
           
            string puertoServidorlocal = textBox26.Text.Trim();

            
            
            string argumentosFinales = "-localsearch";

            
            if (!string.IsNullOrEmpty(puertoServidorlocal))
            {
                argumentosFinales = $"-localsearch -port {puertoServidorlocal}";
            }

            
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = rutaExe,
                Arguments = argumentosFinales,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.UTF8
            };

            
            using (Process proceso = new Process { StartInfo = psi })
            {
                proceso.OutputDataReceived += (sender, e) => MostrarTextoEnRichTextBox(e.Data);
                proceso.ErrorDataReceived += (sender, e) => MostrarTextoEnRichTextBox(e.Data);

                proceso.Start();
                proceso.BeginOutputReadLine();
                proceso.BeginErrorReadLine();

                proceso.WaitForExit();
            }
        }

       
        private void MostrarTextoEnRichTextBox(string texto)
        {
            if (texto != null)
            {
               
                if (richTextBox1.InvokeRequired)
                {
                    richTextBox1.Invoke(new Action(() => MostrarTextoEnRichTextBox(texto)));
                }
                else
                {
                    richTextBox1.AppendText(texto + Environment.NewLine);

                    
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();
                }
            }
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }


            if (e.KeyCode == Keys.Escape)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                textBox29.Visible = true;
                textBox29.Text = "your player name";

            }
            else
            {
                textBox29.Visible = false;
                textBox29.Text = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                textBox32.Visible = true;
                textBox32.Text = "your player name";

            }
            else
            {
                textBox32.Visible = false;
                textBox32.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                textBox34.Visible = true;
                textBox34.Text = "your player name";
            }
            else
            {
                textBox34.Visible = false;
                textBox34.Text = "";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox3.Checked = false;
                checkBox3.Enabled = false;

                checkBox9.Checked = false;
                checkBox9.Enabled = false;

                checkBox29.Checked = false;
                checkBox29.Enabled = false;

                checkBox40.Checked = false;
                checkBox40.Enabled = false;

                checkBox41.Checked = false;
                checkBox41.Enabled = false;

                checkBox42.Checked = false;
                checkBox42.Enabled = false;

                checkBox43.Checked = false;
                checkBox43.Enabled = false;

                checkBox44.Checked = false;
                checkBox44.Enabled = false;

                checkBox45.Checked = false;
                checkBox45.Enabled = false;



                textBox3.Text = "=== MARATHON CAMPAIGN ACTIVE ===\r\n\r\n" +
                        "NOTICE: This launcher DOES NOT distribute commercial data. Temporary files are dynamically generated ONLY if you have legally purchased and placed the original WAD files inside the 'master-wads' folder. If files are missing, the marathon will not execute.\r\n\r\n" +
                        "Part 1 Skies: Native starry horizon enabled via Combine.wad.\r\n" +
                        "Part 2 Skies: Custom environment textures loaded successfully.\r\n" +
                        "[CREDITS: Secondary sky resource courtesy of 'Mek's Box 'O Skies' by Mechadon / Mekworx - Used under community free-use guidelines.]\r\n\r\n" +

                       "- Multiplayer has been disabled to prevent network desynchronization over virtual RAM streams.\r\n" +
                       "- Master MIDI Pack is locked due to engine map-slot music restrictions. Native Doom II audio will play.";
            }
            else
            {
                checkBox3.Enabled = true;
                checkBox9.Enabled = true;
                checkBox29.Enabled = true;
                checkBox40.Enabled = true;
                checkBox41.Enabled = true;
                checkBox42.Enabled = true;
                checkBox43.Enabled = true;
                checkBox44.Enabled = true;
                checkBox45.Enabled = true;


                textBox3.Text = "Marathon Campaign disabled. Ready to launch standard single map modes.";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox21.Checked = false;
                checkBox23.Checked = false;
                checkBox30.Checked = false;
                checkBox29.Checked = false;
                textBox37.Visible = true;
            }
            else
            {
                textBox37.Visible = false;
                textBox37.Text = "";
            }
        }


        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked)
            {
                checkBox43.Checked = false;
                checkBox45.Checked = false;
                checkBox4.Checked = false;
                checkBox30.Checked = false;

                textBox38.Visible = true;
            }
            else
            {
                textBox38.Visible = false;
                textBox38.Text = "";
            }
        }


         private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked)
            {
                checkBox26.Checked = false;
                checkBox28.Checked = false;
                checkBox4.Checked = false;
                checkBox29.Checked = false;

                textBox39.Visible = true;
            }
            else
            {
                textBox39.Visible = false;
                textBox39.Text = "";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                textBox3.Text = "CREDIT FOR THE MASTER MIDI PACK GOES TO PETER LAWRENCE";

            }
            else
            {
                textBox3.Text = "MASTER MIDI PACK DISABLED";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            backgroundBrightnessPercent = trackBar1.Value;

            // 🎯 PERSISTENCE SAVE: Guardar el nuevo brillo de fondo al vuelo
            Properties.Settings.Default.BackgroundBrightness = trackBar1.Value;
            Properties.Settings.Default.Save();

            if (listBoxBackground.SelectedIndex >= 0)
            {
                System.Drawing.Color rawBase = MSDOSBackgroundBasePalette[listBoxBackground.SelectedIndex];
                currentMSDOSBackground = AdjustColorLuminance(rawBase, backgroundBrightnessPercent);

                int hoverPercent = System.Math.Min(backgroundBrightnessPercent + 12, 90);
                System.Drawing.Color customHover = AdjustColorLuminance(rawBase, hoverPercent);

                ApplyGlobalTheme(tabControl1, currentMSDOSBackground, currentMSDOSText, customHover, customHover);
                this.Refresh();
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBrightnessPercent = trackBar2.Value;

            // 🎯 PERSISTENCE SAVE: Guardar el nuevo brillo de letra al vuelo
            Properties.Settings.Default.TextBrightness = trackBar2.Value;
            Properties.Settings.Default.Save();

            if (listBoxText.SelectedIndex >= 0)
            {
                System.Drawing.Color rawTextBase = MSDOSTextBasePalette[listBoxText.SelectedIndex];
                currentMSDOSText = AdjustColorLuminance(rawTextBase, textBrightnessPercent);

                System.Drawing.Color rawBgBase = MSDOSBackgroundBasePalette[listBoxBackground.SelectedIndex];
                int hoverPercent = System.Math.Min(backgroundBrightnessPercent + 12, 90);
                System.Drawing.Color customHover = AdjustColorLuminance(rawBgBase, hoverPercent);

                ApplyGlobalTheme(tabControl1, currentMSDOSBackground, currentMSDOSText, customHover, customHover);
                this.Refresh();
            }
        }
    }
}