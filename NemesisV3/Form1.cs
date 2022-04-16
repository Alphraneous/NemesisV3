using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NemesisV3
{
    public partial class Nemesis : Form
    {
        EasyExploits.Module module = new EasyExploits.Module();
        public Nemesis()
        {
            InitializeComponent();
        }

        private void injectButton_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            module.ExecuteScript(scriptBox.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            scriptBox.Clear();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            module.ExecuteScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = " + wkSpdBox.Text);
            module.ExecuteScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = " + jmpPwrBox.Text);
        }

        private void execute2Btn_Click(object sender, EventArgs e)
        {
            if (scriptList.SelectedIndex == 0)
            {
                module.ExecuteScript("loadstring(game:HttpGet('loadstring(game:HttpGet('https://pastebin.com/raw/4fnLaS1T', true))()'))()");
            } else if(scriptList.SelectedIndex == 1)
            {
                module.ExecuteScript("loadstring(game:HttpGet('https://rentry.co/h63mg/raw'))()");
            } else if(scriptList.SelectedIndex == 2)
            {
                module.ExecuteScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/TestForCry/robloxhacks/master/JailBreak%20Best%20Script%20Gui'))()");
            }
            else if (scriptList.SelectedIndex == 4)
            {
                module.ExecuteScript("loadstring(game:HttpGet('https://pastebin.com/raw/EZWZYvCV'))()");
            }
            else if (scriptList.SelectedIndex == 5)
            {
                module.ExecuteScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub'))()");
            }
            else if (scriptList.SelectedIndex == 6)
            {
                module.ExecuteScript("loadstring(game:HttpGet(('https://darkhub.xyz/remote-script.lua'), true))()");
            }
        }
        private void flyButton_Click(object sender, EventArgs e)
        {
            module.ExecuteScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/PhoenixAceVFX/Roblox-Scripts/master/FE%20Fly.lua'))()");
        }

        private void infJumpButton_Click(object sender, EventArgs e)
        {
            module.ExecuteScript("loadstring(game:HttpGet('https://pastebin.com/raw/8nYi8xtS'))()");
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            module.killRoblox();
        }
    }
}
