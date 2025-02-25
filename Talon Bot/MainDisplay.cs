using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using InputManager; // https://www.codeproject.com/Articles/117657/InputManager-library-Track-user-input-and-simulate
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Talon_Bot
{
    public partial class MainDisplay : Form
    {

        private volatile bool isRunning = false;
        private Thread mouseThread;
        private string keyString = "";

        Color target = Color.FromArgb(55, 174, 108);
        int City_Pos_X, City_Pos_Y;
        int Ticket_Pos_X, Ticket_Pos_Y;
        int Confirm_Pos_X, Confirm_Pos_Y;
        int Refresh_Pos_X, Refresh_Pos_Y;
        int AdditionalCheck_Pos_X, AdditionalCheck_Pos_Y;

        int pos_X = 0, pos_Y = 0;
        string CaseMenu = " ";

        int delayTime = 0;
        public MainDisplay()
        {
            InitializeComponent();
        }

        private void MainDisplay_Load(object sender, EventArgs e)
        {
            delayTime = Convert.ToInt16(speed_textbox.Text);
            KeyboardHook.KeyDown += new KeyboardHook.KeyDownEventHandler(KeyboardHook_KeyDown);
            KeyboardHook.KeyUp += new KeyboardHook.KeyUpEventHandler(KeyboardHook_KeyUp);
            KeyboardHook.InstallHook();
        }

        [DllImport("gdi32.dll")]
        private static extern int GetPixel(IntPtr hdc, int nXPos, int nYPos);

        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        public static bool ComparePixelColor(int x, int y, Color targetColor)
        {
                IntPtr hdc = GetDC(IntPtr.Zero); 
                int pixel = GetPixel(hdc, x, y); 
                ReleaseDC(IntPtr.Zero, hdc); 


                int r = (pixel & 0x000000FF);
                int g = (pixel & 0x0000FF00) >> 8;
                int b = (pixel & 0x00FF0000) >> 16;

                Color pixelColor = Color.FromArgb(r, g, b);

            return pixelColor == targetColor;
        }

        void KeyboardHook_KeyUp(int vkCode)
        {
        }

        void KeyboardHook_KeyDown(int vkCode)
        {
            keyString = ((Keys)vkCode).ToString();
            if (keyString == "S") isRunning = false;
        }

        void MouseHook_MouseMove(MouseHook.POINT ptLocat)
        {
            pos_X = ptLocat.x;
            pos_Y = ptLocat.y;
        }

        void MouseHook_MouseEvent(MouseHook.MouseEvents mEvent)
        {
            if (mEvent.ToString() == "RightDown")
            {
                switch (CaseMenu)
                {
                    case "city":
                        City_Pos_X = pos_X;
                        City_Pos_Y = pos_Y;

                    label_city_position.Text = City_Pos_X + ", " + City_Pos_Y;

                        break;

                    case "get":
                        Ticket_Pos_X = pos_X;
                        Ticket_Pos_Y = pos_Y;
                        
                    label_ticket_button_position.Text = Ticket_Pos_X + ", " + Ticket_Pos_Y;

                        break;
                    case "confirm":
                        Confirm_Pos_X = pos_X;
                        Confirm_Pos_Y = pos_Y;
                        
                    label_confirm_button_position.Text = Confirm_Pos_X + ", " + Confirm_Pos_Y;

                        break;
                    case "refresh":
                        Refresh_Pos_X = pos_X;
                        Refresh_Pos_Y = pos_Y;

                    label_reload_page_position.Text = Refresh_Pos_X + ", " + Refresh_Pos_Y;

                        break;
                    case "Additional":
                        AdditionalCheck_Pos_X = pos_X;
                        AdditionalCheck_Pos_Y = pos_Y;

                    label_additional_check_position.Text = AdditionalCheck_Pos_X + ", " + AdditionalCheck_Pos_Y;

                        break;
                    case "days":

                        list_next_day_positions.Items.Add(pos_X + ", " + pos_Y);
                        manual_textBox.Text = pos_X + ", " + pos_Y;

                        break;
                }

                CaseMenu = " ";


                hook_End();
            }
        }

        void hook_Start()
        {
            MouseHook.MouseEvent += new MouseHook.MouseEventEventHandler(MouseHook_MouseEvent);
            MouseHook.MouseMove += new MouseHook.MouseMoveEventHandler(MouseHook_MouseMove);
            MouseHook.InstallHook();
        }

        void hook_End()
        {
            MouseHook.MouseEvent -= MouseHook_MouseEvent;
            MouseHook.MouseMove -= MouseHook_MouseMove;
            MouseHook.UninstallHook();
        }

        private void btn_set_next_day_position_Click(object sender, EventArgs e)
        {
            hook_Start();
            CaseMenu = "days";
        }

        private void btn_set_city_position_Click(object sender, EventArgs e)
        {
            hook_Start();
            CaseMenu = "city";
        }

        private void btn_set_ticket_button_position_Click(object sender, EventArgs e)
        {
            hook_Start();
            CaseMenu = "get";
        }

        private void btn_confirm_ticket_postion_Click(object sender, EventArgs e)
        {
            hook_Start();
            CaseMenu = "confirm";
        }

        private void btn_refresh_page_position_Click(object sender, EventArgs e)
        {
            hook_Start();
            CaseMenu = "refresh";
        }

        private void btn_Addcheck_position_Click(object sender, EventArgs e)
        {
            hook_Start();
            CaseMenu = "Additional";
        }

        private void btn_manual_enter_Click(object sender, EventArgs e)
        {
            list_next_day_positions.Items.Add(manual_textBox.Text);
        }

        private void btn_set_speed_Click(object sender, EventArgs e)
        {
            delayTime = Convert.ToInt16(speed_textbox.Text);
        }

        private void btn_save_config_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "talonconfig.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine($"City_Pos_X={City_Pos_X}");
                writer.WriteLine($"City_Pos_Y={City_Pos_Y}");
                writer.WriteLine($"Ticket_Pos_X={Ticket_Pos_X}");
                writer.WriteLine($"Ticket_Pos_Y={Ticket_Pos_Y}");
                writer.WriteLine($"Confirm_Pos_X={Confirm_Pos_X}");
                writer.WriteLine($"Confirm_Pos_Y={Confirm_Pos_Y}");
                writer.WriteLine($"Refresh_Pos_X={Refresh_Pos_X}");
                writer.WriteLine($"Refresh_Pos_Y={Refresh_Pos_Y}");
                writer.WriteLine($"AdditionalCheck_Pos_X={AdditionalCheck_Pos_X}");
                writer.WriteLine($"AdditionalCheck_Pos_Y={AdditionalCheck_Pos_Y}");


                foreach (var item in list_next_day_positions.Items)
                {
                    writer.WriteLine(item.ToString());
                }

            }

            MessageBox.Show("Конфиг сохранён!");
        }

        private void btn_load_config_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt",
                Title = "Выберите конфиг"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                list_next_day_positions.Items.Clear();

                foreach (string line in lines)
                {
                    if (line.StartsWith("City_Pos_X=")) City_Pos_X = int.Parse(line.Split('=')[1]);
                    else if (line.StartsWith("City_Pos_Y=")) City_Pos_Y = int.Parse(line.Split('=')[1]);
                    else if (line.StartsWith("Ticket_Pos_X=")) Ticket_Pos_X = int.Parse(line.Split('=')[1]);
                    else if (line.StartsWith("Ticket_Pos_Y=")) Ticket_Pos_Y = int.Parse(line.Split('=')[1]);
                    else if (line.StartsWith("Confirm_Pos_X=")) Confirm_Pos_X = int.Parse(line.Split('=')[1]);
                    else if (line.StartsWith("Confirm_Pos_Y=")) Confirm_Pos_Y = int.Parse(line.Split('=')[1]);
                    else if (line.StartsWith("Refresh_Pos_X=")) Refresh_Pos_X = int.Parse(line.Split('=')[1]);
                    else if (line.StartsWith("Refresh_Pos_Y=")) Refresh_Pos_Y = int.Parse(line.Split('=')[1]);
                    else if (line.StartsWith("AdditionalCheck_Pos_X=")) AdditionalCheck_Pos_X = int.Parse(line.Split('=')[1]);
                    else if (line.StartsWith("AdditionalCheck_Pos_Y=")) AdditionalCheck_Pos_Y = int.Parse(line.Split('=')[1]);

                    else if (line.Contains(","))
                    {
                        list_next_day_positions.Items.Add(line);
                    }
                }


                label_city_position.Text = $"{City_Pos_X}, {City_Pos_Y}";
                label_ticket_button_position.Text = $"{Ticket_Pos_X}, {Ticket_Pos_Y}";
                label_confirm_button_position.Text = $"{Confirm_Pos_X}, {Confirm_Pos_Y}";
                label_reload_page_position.Text = $"{Refresh_Pos_X}, {Refresh_Pos_Y}";
                label_additional_check_position.Text = $"{AdditionalCheck_Pos_X}, {AdditionalCheck_Pos_Y}";

                MessageBox.Show("Конфиг загружен!");
            }
        }

        private void MoveMouseLoop()
        {
            while (isRunning && keyString != "S")
            {
                foreach (var item in list_next_day_positions.Items)
                {
                    if (!isRunning || keyString == "S") break;

                    string[] parts = item.ToString().Split(',');
                    if (parts.Length == 2 &&
                        int.TryParse(parts[0].Trim(), out int x) &&
                        int.TryParse(parts[1].Trim(), out int y))
                    {
                        System.Threading.Thread.Sleep(50); 
                        bool firstCheck = false;
                        bool SeconCheck = false;
                        firstCheck = ComparePixelColor(City_Pos_X, City_Pos_Y, target);
                        SeconCheck = ComparePixelColor(AdditionalCheck_Pos_X, AdditionalCheck_Pos_Y, target);
                        if (firstCheck && SeconCheck == false)
                        {
                            isRunning = false;
                            getTalon();
                            break;
                        }

                        Mouse.Move(x, y);
                        System.Threading.Thread.Sleep(delayTime/7); 
                        Mouse.PressButton(Mouse.MouseKeys.Left);
                        System.Threading.Thread.Sleep(delayTime); 

                    }
                }
                if (!isRunning || keyString == "S") break;
                System.Threading.Thread.Sleep(200); 
                Mouse.Move(Refresh_Pos_X, Refresh_Pos_Y);
                Mouse.PressButton(Mouse.MouseKeys.Left);
                System.Threading.Thread.Sleep(330); 
            }
        }

        
        public void getTalon()
        {
            Mouse.Move(City_Pos_X, City_Pos_Y);
            System.Threading.Thread.Sleep(50); 
            Mouse.PressButton(Mouse.MouseKeys.Left);
            System.Threading.Thread.Sleep(300); 
            Mouse.Move(Ticket_Pos_X, Ticket_Pos_Y);
            System.Threading.Thread.Sleep(210); 
            Mouse.PressButton(Mouse.MouseKeys.Left);
            System.Threading.Thread.Sleep(2000); 
            Mouse.Move(Confirm_Pos_X, Confirm_Pos_Y); 
            Mouse.PressButton(Mouse.MouseKeys.Left);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (mouseThread == null || !mouseThread.IsAlive)
            {
                keyString = " ";
                isRunning = true;
                mouseThread = new Thread(MoveMouseLoop);
                mouseThread.IsBackground = true;
                mouseThread.Start();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (list_next_day_positions.SelectedItem != null)
            {
                list_next_day_positions.Items.Remove(list_next_day_positions.SelectedItem);
            }
        }

    }

}