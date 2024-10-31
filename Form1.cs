using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        private const int WM_HOTKEY = 0x0312;
        private const int MOD_CTRL = 0x0002; // Ctrl tipka
        private const int MOD_SHIFT = 0x0004; // Shift tipka
        private const int MOD_ALT = 0x0001;   // Alt tipka

        // Pomoćna metoda za registraciju globalne prečice
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, Keys vk);

        // Pomoćna metoda za uklanjanje registrirane globalne prečice
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // ID za vašu globalnu prečicu
        private const int HOTKEY_ID_START = 1;
        private const int HOTKEY_ID_STOP = 2;


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();

                // Provera koji hotkey je pritisnut
                if (id == HOTKEY_ID_STOP)
                {
                    buttonStop.PerformClick();
                    keyPressedStart = false;
                    keyPressedStop = false;
                }
                else if (id == HOTKEY_ID_START)
                {
                    // Akcija za drugu globalnu prečicu
                    buttonStart.PerformClick();
                    keyPressedStart = false;
                    keyPressedStop = false;
                }
            }
        }

        // ALT + S je START
        // ALT + E je STOP

        public void DoSomething()
        {
            if (keyPressedStart == false && keyPressedStop == false)
            {
                buttonStart.PerformClick();
                keyPressedStart = false;
                keyPressedStop = false;
            }
            else if (keyPressedStart == true)
            {
                buttonStop.PerformClick();
                keyPressedStart = false;
                keyPressedStop = false;
            }
            else if (keyPressedStop == true)
            {
                buttonStart.PerformClick();
                keyPressedStart = false;
                keyPressedStop = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, HOTKEY_ID_START, MOD_ALT, Keys.S);
            RegisterHotKey(this.Handle, HOTKEY_ID_STOP, MOD_ALT, Keys.E);
            buttonStop.Enabled = false;
            buttonStart.Enabled = false;
            radioButtonVremenskiRad.Checked = true;

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Uklanjamo registrovane globalne prečice prilikom zatvaranja forme
            UnregisterHotKey(this.Handle, HOTKEY_ID_START);
            UnregisterHotKey(this.Handle, HOTKEY_ID_STOP);
        }

        ////////////////////////////////////////////
        public Form1()
        {
            InitializeComponent();

        }
        public int leviPozicijaX;
        public int leviPozicijaY;
        public int leviDrugiPozicijaX;
        public int leviDrugiPozicijaY;
        int srednjiPozicijaX;
        int srednjiPozicijaY;


        private bool buttonWasClickedLeft = false;
        private bool buttonWasClickedLeftSecond = false;
        private bool buttonWasClickedMid = false;
        private bool radio= false;

       /////////////////////////////////

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x0040;

        /////////////////////////////////

        public static class MouseUtils
        {
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool SetCursorPos(int x, int y);

            public static void SetCursorPosition(int x, int y)
            {
                SetCursorPos(x, y);
            }
        }




        ////////////////////////////////////////////////////


        private void buttonPozicijaLeviKlik_Click(object sender, EventArgs e)
        {
            buttonWasClickedLeft = true;
            if (MessageBox.Show("Izaberite poziciju X i Y nakon klika na OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                timerLevi.Start();
                this.Hide();
            }
            Tester();

        }

        private void buttonPozicijaDrugiKlik_Click(object sender, EventArgs e)
        {
            buttonWasClickedLeftSecond = true;
            if (MessageBox.Show("Izaberite poziciju X i Y nakon klika na OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                timerDrugi.Start();
                this.Hide();
            }
            Tester();
        }

        private void buttonPozicijaSrednjiKlik_Click(object sender, EventArgs e)
        {
                buttonWasClickedMid = true;
            if (MessageBox.Show("Izaberite poziciju X i Y nakon klika na OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                timerDesni.Start();
                this.Hide();

            }
            Tester();
        }

        private void timerLevi_Tick(object sender, EventArgs e)
        {
            timerLevi.Stop();
              Point p = Cursor.Position;
              leviPozicijaX = p.X;
              leviPozicijaY = p.Y;
              labelLeviX.Text = Convert.ToString(leviPozicijaX);
              labelLeviY.Text = Convert.ToString(leviPozicijaY);
            this.Show();
        }

        private void timerDrugi_Tick(object sender, EventArgs e)
        {
            timerDrugi.Stop();
            Point p = Cursor.Position;
            leviDrugiPozicijaX = p.X;
            leviDrugiPozicijaY = p.Y;
            labelDrugiX.Text = Convert.ToString(leviDrugiPozicijaX);
            labelDrugiY.Text = Convert.ToString(leviDrugiPozicijaY);
            this.Show();
        }

        private void timerDesni_Tick(object sender, EventArgs e)
        {
            timerDesni.Stop();
            Point p = Cursor.Position;
            srednjiPozicijaX = p.X;
            srednjiPozicijaY = p.Y;
            labelSrednjiX.Text = Convert.ToString(srednjiPozicijaX);
            labelSrednjiY.Text = Convert.ToString(srednjiPozicijaY);
            this.Show();
        }

        public void SrednjiKlik()
        {
            MouseUtils.SetCursorPosition(srednjiPozicijaX, srednjiPozicijaY);
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, UIntPtr.Zero);
            System.Threading.Thread.Sleep(200);
            mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, UIntPtr.Zero);
        }
        public void LeviKlik()
        {
            MouseUtils.SetCursorPosition(leviPozicijaX, leviPozicijaY);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, UIntPtr.Zero);
            System.Threading.Thread.Sleep(400);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
        }
        public void LeviDrugiKlik()
        {
            MouseUtils.SetCursorPosition(leviDrugiPozicijaX, leviDrugiPozicijaY);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, UIntPtr.Zero);
            System.Threading.Thread.Sleep(400);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
        }


        private void Tester()
        {

            if (radio == true && buttonWasClickedLeft == true && buttonWasClickedMid == true && buttonWasClickedLeftSecond == true)
            {
                buttonStart.Enabled = true;
            }
            else
                buttonStart.Enabled = false;
        }
 
        private void radioButtonVremenskiRad_CheckedChanged(object sender, EventArgs e)
        {
            radio = true;
            textBoxHours.Enabled = true;
            textBoxMinutes.Enabled = true;
            textBoxSeconds.Enabled = true;
            textBoxHours.BackColor = Color.White;
            textBoxMinutes.BackColor = Color.White;
            textBoxSeconds.BackColor = Color.White;
            Tester();

        }

        private void UpdateTime(int ukupnoVreme)
        {
            int sati = ukupnoVreme / 3600;
            int minuti = (ukupnoVreme % 3600) / 60;
            int sekunde = ukupnoVreme % 60;

            textBoxHours.Text = sati.ToString("00");
            textBoxMinutes.Text = minuti.ToString("00");
            textBoxSeconds.Text = sekunde.ToString("00");
            
        }
#pragma warning disable CS0414 // The field 'Form1.interval' is assigned but its value is never used
        private int interval = 1000;
#pragma warning restore CS0414 // The field 'Form1.interval' is assigned but its value is never used
        bool keyPressedStart = false;
        bool keyPressedStop = false;
        private void Kliker()
        {
            int zez = Convert.ToInt32(sekundaraTextBox.Text);
            zez = zez * 1000;
            LeviKlik();
            Thread.Sleep(zez+1500);
            LeviDrugiKlik();
            Thread.Sleep(zez);
            SrednjiKlik();
            Thread.Sleep(250);
            SrednjiKlik();
            Thread.Sleep(250);
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            keyPressedStart = true;
            int sat = Convert.ToInt32(textBoxHours.Text);
            int minut = Convert.ToInt32(textBoxMinutes.Text);
            int sekunda = Convert.ToInt32(textBoxSeconds.Text);
            Klikovi = 0;

            buttonPozicijaLeviKlik.Enabled = false;
            buttonPozicijaSrednjiKlik.Enabled = false;
            radioButtonVremenskiRad.Enabled = false;
            textBoxHours.Enabled = false;
            textBoxMinutes.Enabled = false;
            textBoxSeconds.Enabled = false;
            buttonStop.Enabled = true;
            buttonStart.Enabled = false;

            int ukupnoVreme = sat * 3600 + minut * 60 + sekunda;

            timerTime.Enabled = true;
            timerCounter.Enabled = true;
            startTime = DateTime.Now;
            UpdateTime(ukupnoVreme);

        
        }

        private void timerStoper()
        {
            buttonPozicijaLeviKlik.Enabled = true;
            buttonPozicijaSrednjiKlik.Enabled = true;
            radioButtonVremenskiRad.Enabled = true;
            textBoxHours.Enabled = true;
            textBoxMinutes.Enabled = true;
            textBoxSeconds.Enabled = true;
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            textBoxHours.Text = "00";
            textBoxMinutes.Text = "00";
            textBoxSeconds.Text = "00";
            BringToTop();


        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            keyPressedStop = true;
            timerTime.Stop();
            timerStoper();
        }
        private DateTime startTime;
        private int Klikovi = 0;
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            protekloVreme = DateTime.Now - startTime;

        }
        bool timerTimerT = false;
        int preostaloVreme;
        TimeSpan protekloVreme;
        private void timerTime_Tick(object sender, EventArgs e)
        {
            
            preostaloVreme = Convert.ToInt32(textBoxHours.Text) * 3600
                   + Convert.ToInt32(textBoxMinutes.Text) * 60
                   + Convert.ToInt32(textBoxSeconds.Text);

            if (preostaloVreme > 0)
            {
                preostaloVreme--;
                UpdateTime(preostaloVreme);
                Kliker();
                Klikovi++;
                labelKlikovi.Text = $"Klikovi: {Klikovi}";
                labelTrajanje.Text = string.Format("Trajanje: {0:00}:{1:00}:{2:00}", protekloVreme.Hours, protekloVreme.Minutes, protekloVreme.Seconds);

            }
            else if(preostaloVreme == 0 || preostaloVreme < 0)
            {
                timerTime.Enabled = false;
                timerStoper();
            }

        }

        public void BringToTop()
        {
            //Checks if the method is called from UI thread or not
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(BringToTop));
            }
            else
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                //Keeps the current topmost status of form
                bool top = TopMost;
                //Brings the form to top
                TopMost = true;
                //Set form's topmost status back to whatever it was
                TopMost = top;
            }
            Point p = Cursor.Position;
            int midPosX = 979;
            int midPosY = 510;
            p.X = midPosX; p.Y = midPosY;   
    }

        private void textBoxHours_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxHours.Text, "[^0-9]"))
            {
                MessageBox.Show("Karakter nije ispravan. Brojevi su samo omogućeni","Greška!");
                textBoxHours.Text = textBoxHours.Text.Remove(textBoxHours.Text.Length - 1);
            }
        }

        private void textBoxMinutes_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxMinutes.Text, "[^0-9]"))
            {
                MessageBox.Show("Karakter nije ispravan. Brojevi su samo omogućeni", "Greška!");
                textBoxMinutes.Text = textBoxMinutes.Text.Remove(textBoxMinutes.Text.Length - 1);
            }
        }

        private void textBoxSeconds_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxSeconds.Text, "[^0-9]"))
            {
                MessageBox.Show("Karakter nije ispravan. Brojevi su samo omogućeni", "Greška!");
                textBoxSeconds.Text = textBoxSeconds.Text.Remove(textBoxSeconds.Text.Length - 1);
            }
        }

        private void sekundaraTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(sekundaraTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Karakter nije ispravan. Brojevi su samo omogućeni", "Greška!");
                sekundaraTextBox.Text = textBoxSeconds.Text.Remove(sekundaraTextBox.Text.Length - 1);
            }
        }

    }
}
