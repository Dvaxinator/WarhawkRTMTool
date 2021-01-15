using PS3Lib;
using System;
using System.Windows.Forms;

/*DISCLAIMER
 * PROGRAM HAS BEEN DISCONTINUED DUE TO TROJAN BEING FOUND IN EITHER PS3Lib.dll or ps3tmapi_net.dll! PLEASE ONLY RUN IN A SANDBOX ENVIRONMENT OR DON'T RUN AT ALL!!!
 * Code can be used for reference
*/
namespace WarhawkRTMTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static PS3API PS3 = new PS3API(); //New PS3API object declaration used for connecting to PS3
        private void CCAPI_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole); //Changes the API to CCAPI
        }

        private void TMAPI_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager); //Changes the API to TMAPI
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (PS3.ConnectTarget(0)) //If there is a connection between the PS3 and computer
                {
                    MessageBox.Show("Connected", "Successful", MessageBoxButtons.OK);

                }
            }
            catch (Exception) //Handles the exception if the PS3 is not connected
            {
                MessageBox.Show("Unable To Connect To Process", "Unsuccessful", MessageBoxButtons.OK);
            }
        }

        private void Attach_Click(object sender, EventArgs e)
        {
            try
            {
                if (PS3.AttachProcess()) //If the PS3 is successfully connected to the computer and Warhawk
                {
                    MessageBox.Show("Attached To Process! Have Fun Modding!", "Successful", MessageBoxButtons.OK);
                }
            }
            catch (Exception) //Handles the exception if the PS3 was not able to attach to Warhawk
            {
                MessageBox.Show("Unable To Attach To Process", "Unsuccessful", MessageBoxButtons.OK);
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            PS3.DisconnectTarget(); //Disconnects the PS3 from the computer
            MessageBox.Show("Disconnected", "Disconnected", MessageBoxButtons.OK);
        }

        private void NormalBlade_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteByte(0xA5EA30, 0x00); //Writes 0 bytes to the value stored at the specific address
        }

        private void CerimonialBlade_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteByte(0xA5EA30, 0x01); //Changes the blade by writing 1 byte to the value stored at the address
        }

        private void ChampionsBlade_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteByte(0xA5EA30, 0x02); //Gives the user the best blade by writing two bytes to the value stored at the address
        }
        
        private void Godmode_CheckedChanged(object sender, EventArgs e)
        {
            if(Godmode.Checked) //If the user clicks on the godmode checkbox
            {
                uint Godmode = PS3.Extension.ReadUInt32(0x0088E100) + 0x4; //Sets the Godmode variable equal to the address of the base client (0x0088E100 is the base client) incremented by 4 bytes to properly get to the client address
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Godmode) + 0x20, 0x7FFFFFFF); //Reads the client address of the Godmode variable and increments it by the 0x20 offset to get to the address of the health function of the client in-game. Once there, it continuously writes 7FFFFFFF (2147483647 in dec) to the health, essentially enabling godmode 
            }
            else //If the checkbox isn't enabled
            {
                uint Godmode = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Godmode) + 0x20, 0x43160000); //Sets the health of the client to the normal amount

            }
        }

        private void SuperSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (SuperSpeed.Checked)
            {
                PS3.Extension.WriteByte(0x007B768C, 0x50); //Sets the client's speed to max
            }
            else
            {
                PS3.Extension.WriteByte(0x007B768C, 0x00); //Resets the client's speed to normal
            }
        }

        private void EveryoneSuicide_CheckedChanged(object sender, EventArgs e)
        {
            if (EveryoneSuicide.Checked)
            {
                PS3.Extension.WriteByte(0x007B768C, 0xFF); //Causes everyone in the lobby to suicide (Works only if client is host)
            }
            else
            {
                PS3.Extension.WriteByte(0x007B768C, 0x00);
            }
        }

        private void InfiniteAmmo_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (InfiniteAmmo.Checked) //Enables infinite ammo for all weapons
                {
                    uint TopSlot = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(TopSlot) + 0x1008, 0x06090802); //0x1008 is the offset for the top weapons' slot while 0x06090802 is the value written to the specific address and offset

                    uint BottomSlot = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(BottomSlot) + 0x100C, 0x0B030701); 

                    //Each offset is different for every weapon. Offsets were calculated through NetCheat
                    uint Grenades = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Grenades) + 0x4684, 0x0099AA00);

                    uint Rocket = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Rocket) + 0x50B4, 0x0099AA00);

                    uint Sniper = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Sniper) + 0x4C84, 0x0099AA00);

                    uint FlameThrower = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(FlameThrower) + 0x4A34, 0x00007FFF);

                    uint Mines = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Mines) + 0x48B4, 0x0099AA00);

                    uint Binoculars = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Binoculars) + 0x4344, 0x0099AA02);

                    uint BioSphere = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(BioSphere) + 0x40A8, 0x0099AA02);

                    uint MachineGun = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(MachineGun) + 0x41E8, 0x0099AA00);

                    uint Pistol = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Pistol) + 0x47A4, 0x06);
                }
                else //If the ammo checkbox is disabled
                {
                    uint Grenades = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Grenades) + 0x4684, 0x06);

                    uint Rocket = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Rocket) + 0x50B4, 0x06);

                    uint Sniper = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Sniper) + 0x4C84, 0xE);

                    uint FlameThrower = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(FlameThrower) + 0x4A34, 0x78);

                    uint Mines = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Mines) + 0x48B4, 0x00000000);

                    uint Binoculars = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Binoculars) + 0x4344, 0x03);

                    uint BioSphere = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(BioSphere) + 0x40A8, 0x02);

                    uint MachineGun = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(MachineGun) + 0x41E8, 0x28);

                    uint Pistol = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                    PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Pistol) + 0x47A4, 0x0099AA00);
                }
            }
        }

        private void RapidFire_CheckedChanged(object sender, EventArgs e)
        {
            if (InfiniteAmmo.Checked)
            {
                uint BioRapid = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(BioRapid) + 0x51A4, 0x00000000); //0x51A4 is the offset for the weapon while 0x00000000 is the time it takes for the weapon to fire. 0 time equals rapidfire

                uint RPG = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(RPG) + 0x4450, 0x00000000);

                uint Sniper = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Sniper) + 0x4D74, 0x00000000);

                uint Bino = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Bino) + 0x49AC, 0x00000000);

                uint SpeedBino = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(SpeedBino) + 0x49E8, 0x3f800000); //Writing a 0 time to the specific address and offset caused an overflow that crashed the game

                uint Mines = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Mines) + 0x4894, 0x00000000);
            }
            else
            {
                uint BioRapid = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(BioRapid) + 0x51A4, 0x00002710);

                uint RPG = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(RPG) + 0x4450, 0x00000708);

                uint Sniper = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Sniper) + 0x4D74, 0x000006A4);

                uint Bino = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Bino) + 0x49AC, 0x00007530);

                uint MINES = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(MINES) + 0x4894, 0x000006d6);
            }
        }
        private void Wrench_CheckedChanged(object sender, EventArgs e)
        {
            if (Wrench.Checked)
            {
                uint Wrench = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Wrench) + 0x1008, 0x06090802); //Since the wrench isn't a normal weapon, writing 7FFFFFFF resulted in an integer overflow, crashing the game. 0x06090802 is the max value that can be given
            }
            else
            {
                uint Wrench = PS3.Extension.ReadUInt32(0x0088E100) + 0x4;
                PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Wrench) + 0x1008, 0x06090802);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            uint Cartoon = PS3.Extension.ReadUInt32(0x007BA264) + 0x44; //Custom modification that makes all characters appear cartoony (Only works on client-side not server-side)
            PS3.Extension.WriteUInt32(PS3.Extension.ReadUInt32(Cartoon) + 0x2A8, 0x43FA7EBC); 
        }

        private void CartoonMode_CheckedChanged(object sender, EventArgs e)
        {
            if (CartoonMode.Checked)
            {
                timer1.Start(); //Starts the cartoon mod
            }
            else
            {
                timer1.Stop();
            }
        }

        private void Generate_Click_1(object sender, EventArgs e)
        {
            String option = (string)SymbolsForNameAndClan.SelectedItem; //Allows for custom symbols to be displayed in the name/clan of the client
            CopyAndPasteSymbols.Text = option;
            if (option.Equals( "Checkbox Checked"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals("Checkbox Unchecked"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals( "X Button"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals( "O Button"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals( "Triangle Button"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals( "Square Button"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals( "Dpad Up"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals( "Dpad Down"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals( "L1 Button"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals( "L2 Button"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals( "R1 Button"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals( "R2 Button"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals( "Upside Down Exclamation Mark"))
            {
                CopyAndPasteSymbols.Text = "¡";
            }
            else if (option.Equals( "Cents Sign"))
            {
                CopyAndPasteSymbols.Text = "¢";
            }
            else if (option.Equals( "Euros Sign"))
            {
                CopyAndPasteSymbols.Text = "£";
            }
            else if (option.Equals( "Weird E Sign"))
            {
                CopyAndPasteSymbols.Text = "¤";
            }
            else if (option.Equals( "Letter Y With Lines Through It"))
            {
                CopyAndPasteSymbols.Text = "¥";
            }
            else if (option.Equals( "Interlined Letter S"))
            {
                CopyAndPasteSymbols.Text = "§";
            }
            else if (option.Equals( "Tag Eyes"))
            {
                CopyAndPasteSymbols.Text = "¨";
            }
            else if (option.Equals( "Letter C With a Circle Around It"))
            {
                CopyAndPasteSymbols.Text = "©";
            }
            else if (option.Equals( "Letter R With Circle Around It"))
            {
                CopyAndPasteSymbols.Text = "®";
            }
            else if (option.Equals( "Dash Above Tag"))
            {
                CopyAndPasteSymbols.Text = "¯";
            }
            else if (option.Equals( "Degrees Symbol"))
            {
                CopyAndPasteSymbols.Text = "°";
            }
            else if (option.Equals( "Positive/Negative Symbol"))
            {
                CopyAndPasteSymbols.Text = "±";
            }
            else if (option.Equals( "Locked Lock"))
            {
                CopyAndPasteSymbols.Text = "²";
            }
            else if (option.Equals( "Unlocked Lock"))
            {
                CopyAndPasteSymbols.Text = "³";
            }
            else if (option.Equals( "2 With Circle Around It"))
            {
                CopyAndPasteSymbols.Text = "Still Need to do it";
            }
            else if (option.Equals( "Musical Note"))
            {
                CopyAndPasteSymbols.Text = "¶";
            }
            else if (option.Equals( "4 With Circle Around It"))
            {
                CopyAndPasteSymbols.Text = "·";
            }
            else if (option.Equals( "3 With Circle Around It"))
            {
                CopyAndPasteSymbols.Text = "Still need to do it";
            }
            else if (option.Equals( "Unavailable Right Now"))
            {
                CopyAndPasteSymbols.Text = "";
            }
            else if (option.Equals( "Upside Down Question Mark"))
            {
                CopyAndPasteSymbols.Text = "¿";
            }
            else if (option.Equals( "Letter A With Eyes Above It"))
            {
                CopyAndPasteSymbols.Text = "Ä";
            }
            else if (option.Equals( "AE Slanted Text"))
            {
                CopyAndPasteSymbols.Text = "Æ";
            }
            else if (option.Equals( "Letter C With Circle Under It"))
            {
                CopyAndPasteSymbols.Text = "Ç";
            }
            else if (option.Equals( "Letter E With Eyes Above It"))
            {
                CopyAndPasteSymbols.Text = "Ë";
            }
            else if (option.Equals( "Letter I With Eyes Above It"))
            {
                CopyAndPasteSymbols.Text = "Ï";
            }
            else if (option.Equals( "Letter D With Line Through It"))
            {
                CopyAndPasteSymbols.Text = "Ð";
            }
            else if (option.Equals( "Letter O With Eyes Above It"))
            {
                CopyAndPasteSymbols.Text = "Ö";
            }
            else if (option.Equals( "Small x"))
            {
                CopyAndPasteSymbols.Text = "×";
            }
            else if (option.Equals( "Letters P And b As One Character"))
            {
                CopyAndPasteSymbols.Text = "Þ";
            }
            else if (option.Equals( "Divide Symbol"))
            {
                CopyAndPasteSymbols.Text = "÷";
            }
            else if (option.Equals( "Small 0 With / Through It"))
            {
                CopyAndPasteSymbols.Text = "ø";
            }
            else if (option.Equals( "Mu Physics Symbol"))
            {
                CopyAndPasteSymbols.Text = "µ";
            }
            else if (option.Equals( "1 Over 2 Fraction"))
            {
                CopyAndPasteSymbols.Text = "½";
            }
            else if (option.Equals( "1 Over 4 Fraction"))
            {
                CopyAndPasteSymbols.Text = "¼";
            }
            else if (option.Equals( "2 Arrows Pointing Left"))
            {
                CopyAndPasteSymbols.Text = "«";
            }
            else if (option.Equals( "2 Arrows Pointing Right"))
            {
                CopyAndPasteSymbols.Text = "»";
            }
            else if (option.Equals( "Fancy Letter B"))
            {
                CopyAndPasteSymbols.Text = "ß";
            }
        }

        private void ButtonForNameChange_Click_1(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(0x0098EBBC, PlayerName.Text); //Changes the name of the client
        }

        private void ButtonForClanChange_Click_1(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(0x00979E94, Clan.Text); //Changes the name of the client's clan
        }
        private static string Team = "";
        private static string getClientTeam(int clientIndex) //Gets the team of the specific client
        {
            if (PS3.Extension.ReadByte(0xA572F9) == (byte)0)
            {
                return "Client is not on a team";
            }
                
            if (PS3.Extension.ReadUInt32((uint)(0x97B658 + clientIndex * 0x9B0)) == 0U)
            {
                Team = "Blue: ";
            }
            if (PS3.Extension.ReadUInt32((uint)(0x97B658 + clientIndex * 0x9B0)) == 1U)
            {
                Team = "Red: ";
            }
            if (PS3.Extension.ReadUInt32((uint)(0x97AD84 + clientIndex * 0x9B0)) == 0U || (Team.Equals(null)))
            {
                return "Client is not on a team";
            }   
            return Team;
        }
        public static uint GetClientAddress(int i) //0x97AD84 is the base address of the host and 0x9B0 is the amount of space each client address occupies. If i=0, the function returns the address of the host, if i=1, the function returns the address of the first client after the host, etc
        {
            return (uint)(0x97AD84 + i * 0x9B0);
        }
        public static uint get_ptr(uint addr, int off) //Returns the pointer of an address with the offset
        {
            return (uint)(PS3.Extension.ReadInt32(addr) + off);
        }
        private static uint Return_Players() //Returns all the players that are inside the lobby
        {
            uint numOfPlayers = 0;
            for (int index = 0; index < 36; index++) //Loops 36 times as there could be maximum 36 players inside a lobby
            {
                if (PS3.Extension.ReadUInt32((uint)(0x99009C - index * 0x9B0)) != 0U) //If there is a valid client
                {
                    numOfPlayers = (uint)(0x99009C - index * 0x9B0 - 0x97A3DC) / 2480U;
                }
            }
            return numOfPlayers;
        }
        private static string getClientName(int clientIndex)
        {
            string clientName = PS3.Extension.ReadString((uint)(0x97B69C + clientIndex * 0x9B0)); //Reads the string of the specific client offset
            if (PS3.Extension.ReadUInt32((uint)(0x97AD84 + clientIndex * 0x9B0)) == 0U)
            {
                if (PS3.Extension.ReadUInt32((uint)(0x97B69C + clientIndex * 0x9B0)) == 0U) //Determines if there aren't any connected clients
                {
                    return "No Client Found";
                }
                   
                if (PS3.Extension.ReadString((uint)(0x97B69C + clientIndex + 0x9B0)) == PS3.Extension.ReadString((uint)(0x97B69C + (clientIndex - 3) + 0x9B0))) //Determines if the client is inactive
                {
                    return clientName + "Isn't Active";
                }
                if ((int)PS3.Extension.ReadUInt32((uint)(0x97AD84 + clientIndex * 0x9B0)) == (int)PS3.Extension.ReadUInt32(Form1.get_ptr(0x8970496U, 4))) //If a client is found and they are active
                {
                    clientName.Equals(PS3.Extension.ReadString(0x98EBBC)); //Returns the client name
                }
            }
            return clientName;
        }
        private void GetPlayerNames_Click(object sender, EventArgs e)
        {
            ClientListbox.Enabled = true;
            ClientListbox.Items.Clear();
            int int32 = Convert.ToInt32(Return_Players());
            if (PS3.Extension.ReadUInt32(0x0088E100) != 0x0097AD80) 
            {
               
            }
            if (PS3.Extension.ReadUInt32(0x0088E100).Equals(0x0097AD80)) //If the base client's address equals the base address of the host
            {
                for (int clientIndex = 0; clientIndex < int32; clientIndex++) //The listbox gets updated with the name and team of the clients
                {
                    ClientListbox.Update();
                    ClientListbox.Items.Add((object)(getClientTeam(clientIndex) + getClientName(clientIndex)));
                }
            }
            else
            {
                ClientListbox.Update();
                ClientListbox.Items.Add((object)"No clients found.");
            }    
        }
        private void SelectName_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientListbox.SelectedItems.Count; i++) //Adds a selected client into a new listbox. This function allows individual selected clients to be modified.
            {
                SelectedClients.Items.Add(ClientListbox.SelectedItems[i].ToString());
            }
        }
        private void Suicide_CheckedChanged(object sender, EventArgs e) //Suicides the selected client that was received from listbox (NOT WORKING)
        {
            if (Suicide.Checked)
            {
                PS3.Extension.WriteFloat(PS3.Extension.ReadUInt32((uint)(0x0097AD80 + 0x9B0 * SelectedClients.SelectedIndex + 4)) + 0x20, 0.0f); //Sets the specific client's health to 0, essentially making them suicide
            }
            else
            {
                PS3.Extension.WriteFloat(PS3.Extension.ReadUInt32((uint)(0x0097AD84 + 0x9B0 * SelectedClients.SelectedIndex + 4)) + 0x20, 150.0f); //Resets the client's health
            }
        }
    }
}



