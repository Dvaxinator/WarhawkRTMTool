namespace WarhawkRTMTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainMods = new System.Windows.Forms.TabPage();
            this.Blade = new System.Windows.Forms.GroupBox();
            this.ChampionsBlade = new MetroFramework.Controls.MetroButton();
            this.CerimonialBlade = new MetroFramework.Controls.MetroButton();
            this.NormalBlade = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Disconnect = new MetroFramework.Controls.MetroButton();
            this.Attach = new MetroFramework.Controls.MetroButton();
            this.Connect = new MetroFramework.Controls.MetroButton();
            this.API = new System.Windows.Forms.GroupBox();
            this.CCAPI = new MetroFramework.Controls.MetroRadioButton();
            this.TMAPI = new MetroFramework.Controls.MetroRadioButton();
            this.NameChanger = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Generate = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SymbolsForNameAndClan = new MetroFramework.Controls.MetroComboBox();
            this.CopyAndPasteSymbols = new System.Windows.Forms.TextBox();
            this.ButtonForClanChange = new MetroFramework.Controls.MetroButton();
            this.ButtonForNameChange = new MetroFramework.Controls.MetroButton();
            this.Clan = new MetroFramework.Controls.MetroTextBox();
            this.PlayerName = new MetroFramework.Controls.MetroTextBox();
            this.Credits = new System.Windows.Forms.TabPage();
            this.ClientMods = new System.Windows.Forms.TabPage();
            this.SelectName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Suicide = new System.Windows.Forms.CheckBox();
            this.SelectedClients = new System.Windows.Forms.ListBox();
            this.GetPlayerNames = new System.Windows.Forms.Button();
            this.ClientListbox = new System.Windows.Forms.ListBox();
            this.FunMods = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.CartoonMode = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EveryoneSuicide = new System.Windows.Forms.CheckBox();
            this.PlayerMods = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.Wrench = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RapidFire = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuperSpeed = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InfiniteAmmo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Godmode = new System.Windows.Forms.CheckBox();
            this.ConnectionPlusNameChanger = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.MainMods.SuspendLayout();
            this.Blade.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.API.SuspendLayout();
            this.NameChanger.SuspendLayout();
            this.Credits.SuspendLayout();
            this.ClientMods.SuspendLayout();
            this.FunMods.SuspendLayout();
            this.PlayerMods.SuspendLayout();
            this.ConnectionPlusNameChanger.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMods
            // 
            this.MainMods.Controls.Add(this.Blade);
            this.MainMods.Controls.Add(this.groupBox1);
            this.MainMods.Controls.Add(this.NameChanger);
            this.MainMods.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMods.Location = new System.Drawing.Point(4, 29);
            this.MainMods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainMods.Name = "MainMods";
            this.MainMods.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainMods.Size = new System.Drawing.Size(710, 635);
            this.MainMods.TabIndex = 0;
            this.MainMods.Text = "Main Mods";
            // 
            // Blade
            // 
            this.Blade.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Blade.Controls.Add(this.ChampionsBlade);
            this.Blade.Controls.Add(this.CerimonialBlade);
            this.Blade.Controls.Add(this.NormalBlade);
            this.Blade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blade.ForeColor = System.Drawing.Color.Blue;
            this.Blade.Location = new System.Drawing.Point(352, 352);
            this.Blade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Blade.Name = "Blade";
            this.Blade.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Blade.Size = new System.Drawing.Size(388, 274);
            this.Blade.TabIndex = 8;
            this.Blade.TabStop = false;
            this.Blade.Text = "Blade Editor";
            // 
            // ChampionsBlade
            // 
            this.ChampionsBlade.Highlight = true;
            this.ChampionsBlade.Location = new System.Drawing.Point(14, 212);
            this.ChampionsBlade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChampionsBlade.Name = "ChampionsBlade";
            this.ChampionsBlade.Size = new System.Drawing.Size(332, 35);
            this.ChampionsBlade.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChampionsBlade.StyleManager = null;
            this.ChampionsBlade.TabIndex = 5;
            this.ChampionsBlade.Text = "Champions Blade";
            this.ChampionsBlade.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CerimonialBlade
            // 
            this.CerimonialBlade.Highlight = true;
            this.CerimonialBlade.Location = new System.Drawing.Point(14, 132);
            this.CerimonialBlade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CerimonialBlade.Name = "CerimonialBlade";
            this.CerimonialBlade.Size = new System.Drawing.Size(332, 35);
            this.CerimonialBlade.Style = MetroFramework.MetroColorStyle.Blue;
            this.CerimonialBlade.StyleManager = null;
            this.CerimonialBlade.TabIndex = 4;
            this.CerimonialBlade.Text = "Cerimonial Blade";
            this.CerimonialBlade.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // NormalBlade
            // 
            this.NormalBlade.Highlight = true;
            this.NormalBlade.Location = new System.Drawing.Point(14, 55);
            this.NormalBlade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NormalBlade.Name = "NormalBlade";
            this.NormalBlade.Size = new System.Drawing.Size(332, 35);
            this.NormalBlade.Style = MetroFramework.MetroColorStyle.Blue;
            this.NormalBlade.StyleManager = null;
            this.NormalBlade.TabIndex = 3;
            this.NormalBlade.Text = "Normal Blade";
            this.NormalBlade.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.Disconnect);
            this.groupBox1.Controls.Add(this.Attach);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.API);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(340, 612);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // Disconnect
            // 
            this.Disconnect.Highlight = true;
            this.Disconnect.Location = new System.Drawing.Point(42, 511);
            this.Disconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(268, 80);
            this.Disconnect.Style = MetroFramework.MetroColorStyle.Red;
            this.Disconnect.StyleManager = null;
            this.Disconnect.TabIndex = 11;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Attach
            // 
            this.Attach.Highlight = true;
            this.Attach.Location = new System.Drawing.Point(42, 382);
            this.Attach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(268, 82);
            this.Attach.Style = MetroFramework.MetroColorStyle.Red;
            this.Attach.StyleManager = null;
            this.Attach.TabIndex = 10;
            this.Attach.Text = "Attach";
            this.Attach.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Attach.Click += new System.EventHandler(this.Attach_Click);
            // 
            // Connect
            // 
            this.Connect.Highlight = true;
            this.Connect.Location = new System.Drawing.Point(42, 245);
            this.Connect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(268, 83);
            this.Connect.Style = MetroFramework.MetroColorStyle.Red;
            this.Connect.StyleManager = null;
            this.Connect.TabIndex = 9;
            this.Connect.Text = "Connect";
            this.Connect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // API
            // 
            this.API.BackColor = System.Drawing.SystemColors.GrayText;
            this.API.Controls.Add(this.CCAPI);
            this.API.Controls.Add(this.TMAPI);
            this.API.ForeColor = System.Drawing.Color.Blue;
            this.API.Location = new System.Drawing.Point(69, 86);
            this.API.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.API.Name = "API";
            this.API.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.API.Size = new System.Drawing.Size(136, 117);
            this.API.TabIndex = 5;
            this.API.TabStop = false;
            this.API.Text = "API ";
            // 
            // CCAPI
            // 
            this.CCAPI.AutoSize = true;
            this.CCAPI.BackColor = System.Drawing.Color.DimGray;
            this.CCAPI.CustomBackground = true;
            this.CCAPI.CustomForeColor = true;
            this.CCAPI.FontSize = MetroFramework.MetroLinkSize.Small;
            this.CCAPI.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.CCAPI.ForeColor = System.Drawing.Color.Blue;
            this.CCAPI.Location = new System.Drawing.Point(24, 29);
            this.CCAPI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CCAPI.Name = "CCAPI";
            this.CCAPI.Size = new System.Drawing.Size(65, 15);
            this.CCAPI.Style = MetroFramework.MetroColorStyle.Blue;
            this.CCAPI.StyleManager = null;
            this.CCAPI.TabIndex = 1;
            this.CCAPI.TabStop = true;
            this.CCAPI.Text = "CCAPI   ";
            this.CCAPI.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CCAPI.UseStyleColors = false;
            this.CCAPI.UseVisualStyleBackColor = false;
            // 
            // TMAPI
            // 
            this.TMAPI.BackColor = System.Drawing.Color.DimGray;
            this.TMAPI.CustomBackground = true;
            this.TMAPI.CustomForeColor = true;
            this.TMAPI.FontSize = MetroFramework.MetroLinkSize.Small;
            this.TMAPI.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.TMAPI.ForeColor = System.Drawing.Color.Blue;
            this.TMAPI.Location = new System.Drawing.Point(24, 72);
            this.TMAPI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TMAPI.Name = "TMAPI";
            this.TMAPI.Size = new System.Drawing.Size(100, 23);
            this.TMAPI.Style = MetroFramework.MetroColorStyle.Blue;
            this.TMAPI.StyleManager = null;
            this.TMAPI.TabIndex = 0;
            this.TMAPI.TabStop = true;
            this.TMAPI.Text = "TMAPI";
            this.TMAPI.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TMAPI.UseStyleColors = false;
            this.TMAPI.UseVisualStyleBackColor = false;
            // 
            // NameChanger
            // 
            this.NameChanger.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NameChanger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NameChanger.Controls.Add(this.metroLabel6);
            this.NameChanger.Controls.Add(this.metroLabel5);
            this.NameChanger.Controls.Add(this.Generate);
            this.NameChanger.Controls.Add(this.metroLabel4);
            this.NameChanger.Controls.Add(this.metroLabel3);
            this.NameChanger.Controls.Add(this.SymbolsForNameAndClan);
            this.NameChanger.Controls.Add(this.CopyAndPasteSymbols);
            this.NameChanger.Controls.Add(this.ButtonForClanChange);
            this.NameChanger.Controls.Add(this.ButtonForNameChange);
            this.NameChanger.Controls.Add(this.Clan);
            this.NameChanger.Controls.Add(this.PlayerName);
            this.NameChanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameChanger.ForeColor = System.Drawing.Color.Blue;
            this.NameChanger.Location = new System.Drawing.Point(352, 9);
            this.NameChanger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameChanger.Name = "NameChanger";
            this.NameChanger.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameChanger.Size = new System.Drawing.Size(360, 329);
            this.NameChanger.TabIndex = 7;
            this.NameChanger.TabStop = false;
            this.NameChanger.Text = "Name Changer";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.CustomForeColor = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.Blue;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(9, 52);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(53, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 23;
            this.metroLabel6.Text = "Name:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.CustomForeColor = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.Blue;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(14, 291);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(151, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Copy/Paste Symbols:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = true;
            // 
            // Generate
            // 
            this.Generate.Highlight = true;
            this.Generate.Location = new System.Drawing.Point(6, 245);
            this.Generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(345, 35);
            this.Generate.Style = MetroFramework.MetroColorStyle.Green;
            this.Generate.StyleManager = null;
            this.Generate.TabIndex = 21;
            this.Generate.Text = "Generate";
            this.Generate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Generate.Click += new System.EventHandler(this.Generate_Click_1);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.DimGray;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.CustomForeColor = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Blue;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(26, 115);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Clan:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.DimGray;
            this.metroLabel3.CausesValidation = false;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.CustomForeColor = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.ForeColor = System.Drawing.Color.Blue;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(6, 183);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Symbols:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = true;
            // 
            // SymbolsForNameAndClan
            // 
            this.SymbolsForNameAndClan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SymbolsForNameAndClan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SymbolsForNameAndClan.FontSize = MetroFramework.MetroLinkSize.Small;
            this.SymbolsForNameAndClan.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.SymbolsForNameAndClan.FormattingEnabled = true;
            this.SymbolsForNameAndClan.ItemHeight = 19;
            this.SymbolsForNameAndClan.Items.AddRange(new object[] {
            "Checkbox Checked",
            "Checkbox Unchecked",
            "X Button",
            "O Button",
            "Triangle Button",
            "Square Button",
            "Dpad Up",
            "Dpad Down",
            "L1 Button",
            "L2 Button",
            "R1 Button",
            "R2 Button",
            "Upside Down Exclamation Mark",
            "Cents Sign",
            "Euros Sign",
            "Weird E Sign",
            "Letter Y With Lines Through It",
            "Interlined Letter S",
            "Tag Eyes",
            "Letter C With a Circle Around It",
            "Letter R With Circle Around It",
            "Dash Above Tag",
            "Degrees Symbol",
            "Positive/Negative Symbol",
            "Locked Lock",
            "Unlocked Lock",
            "2 With Circle Around It",
            "Musical Note",
            "4 With Circle Around It",
            "3 With Circle Around It",
            "Upside Down Question Mark",
            "Letter A With Eyes Above It",
            "AE Slanted Text",
            "Letter C With Circle Under It",
            "Letter E With Eyes Above It",
            "Letter I With Eyes Above It",
            "Letter D With Line Through It",
            "Letter O With Eyes Above It",
            "Small x",
            "Letters P And b As One Character",
            "Divide Symbol",
            "Small 0 With / Through It",
            "Mu Physics Symbol",
            "1 Over 4 Fraction",
            "1 Over 2 Fraction",
            "2 Arrows Pointing Left",
            "2 Arrows Pointing Right",
            "Fancy Letter B"});
            this.SymbolsForNameAndClan.Location = new System.Drawing.Point(99, 183);
            this.SymbolsForNameAndClan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SymbolsForNameAndClan.Name = "SymbolsForNameAndClan";
            this.SymbolsForNameAndClan.Size = new System.Drawing.Size(254, 25);
            this.SymbolsForNameAndClan.Style = MetroFramework.MetroColorStyle.Blue;
            this.SymbolsForNameAndClan.StyleManager = null;
            this.SymbolsForNameAndClan.TabIndex = 17;
            this.SymbolsForNameAndClan.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // CopyAndPasteSymbols
            // 
            this.CopyAndPasteSymbols.Location = new System.Drawing.Point(255, 289);
            this.CopyAndPasteSymbols.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CopyAndPasteSymbols.Name = "CopyAndPasteSymbols";
            this.CopyAndPasteSymbols.Size = new System.Drawing.Size(92, 30);
            this.CopyAndPasteSymbols.TabIndex = 16;
            // 
            // ButtonForClanChange
            // 
            this.ButtonForClanChange.Highlight = true;
            this.ButtonForClanChange.Location = new System.Drawing.Point(255, 115);
            this.ButtonForClanChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonForClanChange.Name = "ButtonForClanChange";
            this.ButtonForClanChange.Size = new System.Drawing.Size(96, 35);
            this.ButtonForClanChange.Style = MetroFramework.MetroColorStyle.Green;
            this.ButtonForClanChange.StyleManager = null;
            this.ButtonForClanChange.TabIndex = 13;
            this.ButtonForClanChange.Text = "Set";
            this.ButtonForClanChange.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButtonForClanChange.Click += new System.EventHandler(this.ButtonForClanChange_Click_1);
            // 
            // ButtonForNameChange
            // 
            this.ButtonForNameChange.Highlight = true;
            this.ButtonForNameChange.Location = new System.Drawing.Point(258, 52);
            this.ButtonForNameChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonForNameChange.Name = "ButtonForNameChange";
            this.ButtonForNameChange.Size = new System.Drawing.Size(96, 35);
            this.ButtonForNameChange.Style = MetroFramework.MetroColorStyle.Green;
            this.ButtonForNameChange.StyleManager = null;
            this.ButtonForNameChange.TabIndex = 12;
            this.ButtonForNameChange.Text = "Set";
            this.ButtonForNameChange.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ButtonForNameChange.Click += new System.EventHandler(this.ButtonForNameChange_Click_1);
            // 
            // Clan
            // 
            this.Clan.CustomBackground = false;
            this.Clan.CustomForeColor = false;
            this.Clan.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.Clan.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.Clan.Location = new System.Drawing.Point(99, 115);
            this.Clan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Clan.Multiline = false;
            this.Clan.Name = "Clan";
            this.Clan.SelectedText = "";
            this.Clan.Size = new System.Drawing.Size(141, 35);
            this.Clan.Style = MetroFramework.MetroColorStyle.Blue;
            this.Clan.StyleManager = null;
            this.Clan.TabIndex = 11;
            this.Clan.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Clan.UseStyleColors = false;
            // 
            // PlayerName
            // 
            this.PlayerName.CustomBackground = false;
            this.PlayerName.CustomForeColor = false;
            this.PlayerName.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.PlayerName.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.PlayerName.Location = new System.Drawing.Point(99, 52);
            this.PlayerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayerName.Multiline = false;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.SelectedText = "";
            this.PlayerName.Size = new System.Drawing.Size(141, 35);
            this.PlayerName.Style = MetroFramework.MetroColorStyle.Blue;
            this.PlayerName.StyleManager = null;
            this.PlayerName.TabIndex = 10;
            this.PlayerName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PlayerName.UseStyleColors = false;
            // 
            // Credits
            // 
            this.Credits.BackColor = System.Drawing.Color.Black;
            this.Credits.Controls.Add(this.label2);
            this.Credits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Credits.Location = new System.Drawing.Point(4, 29);
            this.Credits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Credits.Name = "Credits";
            this.Credits.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Credits.Size = new System.Drawing.Size(710, 635);
            this.Credits.TabIndex = 4;
            this.Credits.Text = "Credits";
            // 
            // ClientMods
            // 
            this.ClientMods.Controls.Add(this.SelectName);
            this.ClientMods.Controls.Add(this.label1);
            this.ClientMods.Controls.Add(this.Suicide);
            this.ClientMods.Controls.Add(this.SelectedClients);
            this.ClientMods.Controls.Add(this.GetPlayerNames);
            this.ClientMods.Controls.Add(this.ClientListbox);
            this.ClientMods.Location = new System.Drawing.Point(4, 29);
            this.ClientMods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientMods.Name = "ClientMods";
            this.ClientMods.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientMods.Size = new System.Drawing.Size(710, 635);
            this.ClientMods.TabIndex = 3;
            this.ClientMods.Text = "Client Mods";
            this.ClientMods.UseVisualStyleBackColor = true;
            // 
            // SelectName
            // 
            this.SelectName.BackColor = System.Drawing.Color.White;
            this.SelectName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectName.Location = new System.Drawing.Point(88, 295);
            this.SelectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectName.Name = "SelectName";
            this.SelectName.Size = new System.Drawing.Size(112, 35);
            this.SelectName.TabIndex = 5;
            this.SelectName.Text = "SelectName";
            this.SelectName.UseVisualStyleBackColor = false;
            this.SelectName.Click += new System.EventHandler(this.SelectName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(482, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Suicide";
            // 
            // Suicide
            // 
            this.Suicide.AutoSize = true;
            this.Suicide.Location = new System.Drawing.Point(554, 122);
            this.Suicide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Suicide.Name = "Suicide";
            this.Suicide.Size = new System.Drawing.Size(113, 24);
            this.Suicide.TabIndex = 3;
            this.Suicide.Text = "checkBox1";
            this.Suicide.UseVisualStyleBackColor = true;
            this.Suicide.CheckedChanged += new System.EventHandler(this.Suicide_CheckedChanged);
            // 
            // SelectedClients
            // 
            this.SelectedClients.FormattingEnabled = true;
            this.SelectedClients.ItemHeight = 20;
            this.SelectedClients.Location = new System.Drawing.Point(358, 14);
            this.SelectedClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectedClients.Name = "SelectedClients";
            this.SelectedClients.Size = new System.Drawing.Size(337, 84);
            this.SelectedClients.TabIndex = 2;
            // 
            // GetPlayerNames
            // 
            this.GetPlayerNames.BackColor = System.Drawing.Color.White;
            this.GetPlayerNames.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GetPlayerNames.Location = new System.Drawing.Point(88, 249);
            this.GetPlayerNames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetPlayerNames.Name = "GetPlayerNames";
            this.GetPlayerNames.Size = new System.Drawing.Size(112, 35);
            this.GetPlayerNames.TabIndex = 1;
            this.GetPlayerNames.Text = "Grab";
            this.GetPlayerNames.UseVisualStyleBackColor = false;
            this.GetPlayerNames.Click += new System.EventHandler(this.GetPlayerNames_Click);
            // 
            // ClientListbox
            // 
            this.ClientListbox.FormattingEnabled = true;
            this.ClientListbox.ItemHeight = 20;
            this.ClientListbox.Location = new System.Drawing.Point(9, 14);
            this.ClientListbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientListbox.Name = "ClientListbox";
            this.ClientListbox.Size = new System.Drawing.Size(338, 224);
            this.ClientListbox.TabIndex = 0;
            // 
            // FunMods
            // 
            this.FunMods.Controls.Add(this.label9);
            this.FunMods.Controls.Add(this.CartoonMode);
            this.FunMods.Controls.Add(this.label12);
            this.FunMods.Controls.Add(this.EveryoneSuicide);
            this.FunMods.Location = new System.Drawing.Point(4, 29);
            this.FunMods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FunMods.Name = "FunMods";
            this.FunMods.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FunMods.Size = new System.Drawing.Size(710, 635);
            this.FunMods.TabIndex = 2;
            this.FunMods.Text = "Fun Mods";
            this.FunMods.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(84, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cartoon Mode";
            // 
            // CartoonMode
            // 
            this.CartoonMode.AutoSize = true;
            this.CartoonMode.Location = new System.Drawing.Point(40, 118);
            this.CartoonMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CartoonMode.Name = "CartoonMode";
            this.CartoonMode.Size = new System.Drawing.Size(113, 24);
            this.CartoonMode.TabIndex = 2;
            this.CartoonMode.Text = "checkBox1";
            this.CartoonMode.UseVisualStyleBackColor = true;
            this.CartoonMode.CheckedChanged += new System.EventHandler(this.CartoonMode_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(80, 55);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Everyone Suicide (Host Only)";
            // 
            // EveryoneSuicide
            // 
            this.EveryoneSuicide.AutoSize = true;
            this.EveryoneSuicide.Location = new System.Drawing.Point(40, 55);
            this.EveryoneSuicide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EveryoneSuicide.Name = "EveryoneSuicide";
            this.EveryoneSuicide.Size = new System.Drawing.Size(113, 24);
            this.EveryoneSuicide.TabIndex = 0;
            this.EveryoneSuicide.Text = "checkBox1";
            this.EveryoneSuicide.UseVisualStyleBackColor = true;
            this.EveryoneSuicide.CheckedChanged += new System.EventHandler(this.EveryoneSuicide_CheckedChanged);
            // 
            // PlayerMods
            // 
            this.PlayerMods.Controls.Add(this.label4);
            this.PlayerMods.Controls.Add(this.Wrench);
            this.PlayerMods.Controls.Add(this.label3);
            this.PlayerMods.Controls.Add(this.RapidFire);
            this.PlayerMods.Controls.Add(this.label8);
            this.PlayerMods.Controls.Add(this.label7);
            this.PlayerMods.Controls.Add(this.SuperSpeed);
            this.PlayerMods.Controls.Add(this.label6);
            this.PlayerMods.Controls.Add(this.InfiniteAmmo);
            this.PlayerMods.Controls.Add(this.label5);
            this.PlayerMods.Controls.Add(this.Godmode);
            this.PlayerMods.Location = new System.Drawing.Point(4, 29);
            this.PlayerMods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayerMods.Name = "PlayerMods";
            this.PlayerMods.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayerMods.Size = new System.Drawing.Size(710, 635);
            this.PlayerMods.TabIndex = 1;
            this.PlayerMods.Text = "Player Mods";
            this.PlayerMods.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(70, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wrench Infinite Ammo";
            // 
            // Wrench
            // 
            this.Wrench.AutoSize = true;
            this.Wrench.Location = new System.Drawing.Point(32, 326);
            this.Wrench.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Wrench.Name = "Wrench";
            this.Wrench.Size = new System.Drawing.Size(113, 24);
            this.Wrench.TabIndex = 9;
            this.Wrench.Text = "checkBox1";
            this.Wrench.UseVisualStyleBackColor = true;
            this.Wrench.CheckedChanged += new System.EventHandler(this.Wrench_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(66, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rapid Fire";
            // 
            // RapidFire
            // 
            this.RapidFire.AutoSize = true;
            this.RapidFire.Location = new System.Drawing.Point(32, 263);
            this.RapidFire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RapidFire.Name = "RapidFire";
            this.RapidFire.Size = new System.Drawing.Size(113, 24);
            this.RapidFire.TabIndex = 7;
            this.RapidFire.Text = "checkBox1";
            this.RapidFire.UseVisualStyleBackColor = true;
            this.RapidFire.CheckedChanged += new System.EventHandler(this.RapidFire_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(66, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Super Speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            // 
            // SuperSpeed
            // 
            this.SuperSpeed.AutoSize = true;
            this.SuperSpeed.Location = new System.Drawing.Point(32, 197);
            this.SuperSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuperSpeed.Name = "SuperSpeed";
            this.SuperSpeed.Size = new System.Drawing.Size(113, 24);
            this.SuperSpeed.TabIndex = 4;
            this.SuperSpeed.Text = "checkBox3";
            this.SuperSpeed.UseVisualStyleBackColor = true;
            this.SuperSpeed.CheckedChanged += new System.EventHandler(this.SuperSpeed_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(66, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Infinite Ammo";
            // 
            // InfiniteAmmo
            // 
            this.InfiniteAmmo.AutoSize = true;
            this.InfiniteAmmo.Location = new System.Drawing.Point(32, 118);
            this.InfiniteAmmo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InfiniteAmmo.Name = "InfiniteAmmo";
            this.InfiniteAmmo.Size = new System.Drawing.Size(113, 24);
            this.InfiniteAmmo.TabIndex = 2;
            this.InfiniteAmmo.Text = "checkBox3";
            this.InfiniteAmmo.UseVisualStyleBackColor = true;
            this.InfiniteAmmo.CheckedChanged += new System.EventHandler(this.InfiniteAmmo_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(66, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Godmode (Host Only)";
            // 
            // Godmode
            // 
            this.Godmode.AutoSize = true;
            this.Godmode.Location = new System.Drawing.Point(32, 43);
            this.Godmode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Godmode.Name = "Godmode";
            this.Godmode.Size = new System.Drawing.Size(113, 24);
            this.Godmode.TabIndex = 0;
            this.Godmode.Text = "checkBox3";
            this.Godmode.UseVisualStyleBackColor = true;
            this.Godmode.CheckedChanged += new System.EventHandler(this.Godmode_CheckedChanged);
            // 
            // ConnectionPlusNameChanger
            // 
            this.ConnectionPlusNameChanger.Controls.Add(this.PlayerMods);
            this.ConnectionPlusNameChanger.Controls.Add(this.FunMods);
            this.ConnectionPlusNameChanger.Controls.Add(this.ClientMods);
            this.ConnectionPlusNameChanger.Controls.Add(this.Credits);
            this.ConnectionPlusNameChanger.Controls.Add(this.MainMods);
            this.ConnectionPlusNameChanger.Location = new System.Drawing.Point(13, -5);
            this.ConnectionPlusNameChanger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConnectionPlusNameChanger.Name = "ConnectionPlusNameChanger";
            this.ConnectionPlusNameChanger.SelectedIndex = 0;
            this.ConnectionPlusNameChanger.Size = new System.Drawing.Size(718, 668);
            this.ConnectionPlusNameChanger.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 625);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thank you Josh for all your assistance. I\'m glad that we worked together. I\'m sor" +
    "ry for discontinuing the tool but I didn\'t want to take anymore chances in getti" +
    "ng infected again. Much love bro <3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(732, 677);
            this.Controls.Add(this.ConnectionPlusNameChanger);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Warhawk RTM Tool By Daniel Vaxman and Joshua McKinney";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.MainMods.ResumeLayout(false);
            this.Blade.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.API.ResumeLayout(false);
            this.API.PerformLayout();
            this.NameChanger.ResumeLayout(false);
            this.NameChanger.PerformLayout();
            this.Credits.ResumeLayout(false);
            this.ClientMods.ResumeLayout(false);
            this.ClientMods.PerformLayout();
            this.FunMods.ResumeLayout(false);
            this.FunMods.PerformLayout();
            this.PlayerMods.ResumeLayout(false);
            this.PlayerMods.PerformLayout();
            this.ConnectionPlusNameChanger.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage MainMods;
        private System.Windows.Forms.GroupBox Blade;
        private MetroFramework.Controls.MetroButton ChampionsBlade;
        private MetroFramework.Controls.MetroButton CerimonialBlade;
        private MetroFramework.Controls.MetroButton NormalBlade;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton Disconnect;
        private MetroFramework.Controls.MetroButton Attach;
        private MetroFramework.Controls.MetroButton Connect;
        private System.Windows.Forms.GroupBox API;
        private MetroFramework.Controls.MetroRadioButton CCAPI;
        private MetroFramework.Controls.MetroRadioButton TMAPI;
        private System.Windows.Forms.GroupBox NameChanger;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton Generate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox SymbolsForNameAndClan;
        private System.Windows.Forms.TextBox CopyAndPasteSymbols;
        private MetroFramework.Controls.MetroButton ButtonForClanChange;
        private MetroFramework.Controls.MetroButton ButtonForNameChange;
        private MetroFramework.Controls.MetroTextBox Clan;
        private MetroFramework.Controls.MetroTextBox PlayerName;
        private System.Windows.Forms.TabPage Credits;
        private System.Windows.Forms.TabPage ClientMods;
        private System.Windows.Forms.Button SelectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Suicide;
        private System.Windows.Forms.ListBox SelectedClients;
        private System.Windows.Forms.Button GetPlayerNames;
        private System.Windows.Forms.ListBox ClientListbox;
        private System.Windows.Forms.TabPage FunMods;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox CartoonMode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox EveryoneSuicide;
        private System.Windows.Forms.TabPage PlayerMods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Wrench;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox RapidFire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox SuperSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox InfiniteAmmo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Godmode;
        private System.Windows.Forms.TabControl ConnectionPlusNameChanger;
        private System.Windows.Forms.Label label2;
    }
}

