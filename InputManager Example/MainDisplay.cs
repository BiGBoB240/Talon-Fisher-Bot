using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using InputManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InputManager_Example
{
    public partial class MainDisplay : Form
    {

        private volatile bool isRunning = false;
        private Thread mouseThread;
        private string keyString = "";

        Color target = Color.FromArgb(55, 174, 108);
        int city_Pos_X, city_Pos_Y;
        int get_Pos_X, get_Pos_Y;
        int confirm_Pos_X, confirm_Pos_Y;
        int reload_Pos_X, reload_Pos_Y;
        int background_Pos_X, background_Pos_Y;

        int pos_X = 0, pos_Y = 0;
        string Chooser = " ";

        int delayTime = 0;
        public MainDisplay()
        {
            InitializeComponent();

        }

        private void MainDisplay_Load(object sender, EventArgs e)
        {
            delayTime = Convert.ToInt16(textBox1.Text);
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

        public static bool IsColorMatch(int x, int y, Color targetColor)
        {
                IntPtr hdc = GetDC(IntPtr.Zero); // Получаем доступ к экрану
                int pixel = GetPixel(hdc, x, y); // Считываем цвет пикселя
                ReleaseDC(IntPtr.Zero, hdc); // Освобождаем дескриптор

                // Разбираем цвет
                int r = (pixel & 0x000000FF);
                int g = (pixel & 0x0000FF00) >> 8;
                int b = (pixel & 0x00FF0000) >> 16;

                Color pixelColor = Color.FromArgb(r, g, b);

            return pixelColor == targetColor;
        }

        void KeyboardHook_KeyUp(int vkCode)
        {
            //Everytime the users releases a certain key up,
            //your application will go to this line
            //Use the vKCode argument to determine which key has been released
        }

        void KeyboardHook_KeyDown(int vkCode)
        {
            //Everytime the users holds a certain key down,
            //your application will go to this line
            //Use the vKCode argument to determine which key is held down
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
                switch (Chooser)
                {
                    case "city":
                        city_Pos_X = pos_X;
                        city_Pos_Y = pos_Y;

                    label1.Text = city_Pos_X + ", " + city_Pos_Y;

                        break;

                    case "get":
                        get_Pos_X = pos_X;
                        get_Pos_Y = pos_Y;
                        
                    label2.Text = get_Pos_X + ", " + get_Pos_Y;

                        break;
                    case "confirm":
                        confirm_Pos_X = pos_X;
                        confirm_Pos_Y = pos_Y;

                    label3.Text = confirm_Pos_X + ", " + confirm_Pos_Y;

                        break;
                    case "reload":
                        reload_Pos_X = pos_X;
                        reload_Pos_Y = pos_Y;

                        label4.Text = reload_Pos_X + ", " + reload_Pos_Y;

                        break;
                    case "background":
                        background_Pos_X = pos_X;
                        background_Pos_Y = pos_Y;

                        label5.Text = background_Pos_X + ", " + background_Pos_Y;

                        break;
                    case "days":
                        listBox2.Items.Add(pos_X + ", " + pos_Y);
                        break;
                }

                Chooser = " ";


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
            MouseHook.MouseEvent -= new MouseHook.MouseEventEventHandler(MouseHook_MouseEvent);
            MouseHook.MouseMove -= new MouseHook.MouseMoveEventHandler(MouseHook_MouseMove);
            MouseHook.UninstallHook();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hook_Start();
            Chooser = "days";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hook_Start();
            Chooser = "city";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hook_Start();
            Chooser = "get";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hook_Start();
            Chooser = "confirm";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hook_Start();
            Chooser = "reload";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            delayTime = Convert.ToInt16(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hook_Start();
            Chooser = "background";
        }

        private void MoveMouseLoop()
        {
            while (isRunning && keyString != "S")
            {
                foreach (var item in listBox2.Items)
                {
                    if (!isRunning || keyString == "S") break;

                    string[] parts = item.ToString().Split(',');
                    if (parts.Length == 2 &&
                        int.TryParse(parts[0].Trim(), out int x) &&
                        int.TryParse(parts[1].Trim(), out int y))
                    {
                        System.Threading.Thread.Sleep(50); // Пауза для наглядності
                        bool firstCheck = false;
                        bool SeconCheck = false;
                        firstCheck = IsColorMatch(city_Pos_X, city_Pos_Y, target);
                        SeconCheck = IsColorMatch(background_Pos_X, background_Pos_Y, target);
                        if (firstCheck && SeconCheck == false)
                        {
                            isRunning = false;
                            getTalon();
                            break;
                        }

                        Mouse.Move(x, y);
                        System.Threading.Thread.Sleep(delayTime/7); // Пауза для наглядності
                        Mouse.PressButton(Mouse.MouseKeys.Left);
                        System.Threading.Thread.Sleep(delayTime); // Пауза для наглядності

                    }
                }
                if (!isRunning || keyString == "S") break;
                System.Threading.Thread.Sleep(200); // Пауза для наглядності
                Mouse.Move(reload_Pos_X, reload_Pos_Y);
                Mouse.PressButton(Mouse.MouseKeys.Left);
                System.Threading.Thread.Sleep(330); // Пауза для наглядності
            }
        }

        
        public void getTalon()
        {
            Mouse.Move(city_Pos_X, city_Pos_Y);
            System.Threading.Thread.Sleep(50); // Пауза для наглядності
            Mouse.PressButton(Mouse.MouseKeys.Left);
            System.Threading.Thread.Sleep(300); // Пауза для наглядності
            Mouse.Move(get_Pos_X, get_Pos_Y);
            System.Threading.Thread.Sleep(210); // Пауза для наглядності
            Mouse.PressButton(Mouse.MouseKeys.Left);
            System.Threading.Thread.Sleep(2000); // Пауза для наглядності
            Mouse.Move(confirm_Pos_X, confirm_Pos_Y); 
            Mouse.PressButton(Mouse.MouseKeys.Left);
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

    }

}