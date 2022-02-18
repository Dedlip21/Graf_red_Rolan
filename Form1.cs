using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Graf_red_Rolan
{
    public partial class Form1 : Form
    {
        MenuStrip MainMenu;
        ToolStripMenuItem fileItem1;
        ToolStripMenuItem fileItem2;
        ToolStripMenuItem newItem1;
        ToolStripMenuItem newItem2;
        ToolStripMenuItem newItem3;

        RichTextBox rtb;

        Panel panel;

        Label lbl_poisk;
        Label lbl_razdel1;
        Label lbl_razdel2;

        ListBox listbox_niz;
        public ListBox listbox_razdel1;
        public ListBox listbox_razdel2;

        RadioButton rb1;
        RadioButton rb2;
        RadioButton rb3;

        CheckBox checkbox1;
        CheckBox checkbox2;

        TextBox txt_box;

        ComboBox combo1;
        ComboBox combo2;


        GroupBox gb1;
        GroupBox gb2;

        Button btn_start;
        Button btn_poisk;
        Button btn_vihod;
        Button btn_sbros;
        Button btn_ochistit_levo;
        Button btn_udalit;
        Button btn_ochistit_pravo;
        Button btn_sortirovat_levo;
        Button btn_dobavit;
        Button btn_sortirovat_pravo;
        Button btn_left;
        Button btn_right;
        Button btn_double_left;
        Button btn_double_right;

        public Form1()
        {
            this.Size = new Size(900, 600);

            //--------------MenuStrip Creation---------------//

            // MenuStrip
            MainMenu = new MenuStrip();

            MainMenu.BackColor = Color.OrangeRed;
            MainMenu.ForeColor = Color.Black;
            MainMenu.Text = "File Menu";
            MainMenu.Font = new Font("Comic Sans MS", 10);

            this.MainMenuStrip = MainMenu;
            Controls.Add(MainMenu);

            MainMenu.Name = "MainMenu";

            //-----------MenuItems--------------------//
            fileItem1 = new ToolStripMenuItem("Файлf");
            fileItem2 = new ToolStripMenuItem("?");

            newItem1 = new ToolStripMenuItem("Открыть");
            newItem1.ShortcutKeys = Keys.Control | Keys.O;
            fileItem1.DropDownItems.Add(newItem1);

            newItem2 = new ToolStripMenuItem("Сохранить");
            newItem2.ShortcutKeys = Keys.Control | Keys.S;
            fileItem1.DropDownItems.Add(newItem2);

            newItem3 = new ToolStripMenuItem("Выход");
            newItem3.ShortcutKeys = Keys.Control | Keys.X;
            fileItem1.DropDownItems.Add(newItem3);

            MainMenu.Items.Add(fileItem1);
            MainMenu.Items.Add(fileItem2);

            newItem1.Click += NewItem1_Click;
            newItem2.Click += NewItem2_Click;
            newItem3.Click += NewItem3_Click;

            //---------------------------------------------------*/


            //----------------RadioButton--------------//
            rb1 = new RadioButton
            {
                Text = "Все",
                Location = new Point(570, 475),
                Size = new Size(130, 25),
                BackColor = Color.Aqua
            };

            rb2 = new RadioButton
            {
                Text = "Содержащие цифры",
                Location = new Point(570, 495),
                Size = new Size(130, 25),
                BackColor = Color.Aqua
            };

            rb3 = new RadioButton
            {
                Text = "Содержащие 'e-mail'",
                Location = new Point(570, 515),
                Size = new Size(130, 25),
                BackColor = Color.Aqua
            };
            this.Controls.Add(rb1);
            this.Controls.Add(rb2);
            this.Controls.Add(rb3);


            //---------CheckBox------------//
            checkbox1 = new CheckBox
            {
                Text = "Раздел 1",
                Location = new Point(270, 400),
                Size = new Size(80, 25),
                BackColor = Color.LightBlue
            };

            checkbox2 = new CheckBox
            {
                Text = "Раздел 2",
                Location = new Point(270, 430),
                Size = new Size(80, 25),
                BackColor = Color.LightBlue
            };
            this.Controls.Add(checkbox1);
            this.Controls.Add(checkbox2);


            //--------ComboBox----------//
            combo1 = new ComboBox
            {
                Text = "Сортировка по ..",
                Location = new Point(50, 60),
                Size = new Size(160, 25),
                Sorted = true,
            };

            combo2 = new ComboBox
            {
                Text = "Сортировка по ..",
                Location = new Point(350, 60),
                Size = new Size(160, 25),
                Sorted = true
            };
            this.Controls.Add(combo1);
            this.Controls.Add(combo2);

            combo1.Items.Add("Алфавиту (по возрастанию)");
            combo1.Items.Add("Алфавиту (по убыванию)");
            combo1.Items.Add("Длинне слова (по возрастанию)");
            combo1.Items.Add("Длинне слова (по убыванию)");

            combo2.Items.Add("Алфавиту (по возрастанию)");
            combo2.Items.Add("Алфавиту (по убыванию)");
            combo2.Items.Add("Длинне слова (по возрастанию)");
            combo2.Items.Add("Длинне слова (по убыванию)");

            //-------Labels------------//
            lbl_poisk = new Label
            {
                Text = "Введите искаемое слово",
                Location = new Point(50, 360),
                Size = new Size(160, 25),
                BackColor = Color.LightBlue
            };

            lbl_razdel1 = new Label
            {
                Text = "Раздел 1",
                Location = new Point(50, 40),
                Size = new Size(160, 25),
                //BackColor = Color.LightBlue
            };

            lbl_razdel2 = new Label
            {
                Text = "Раздел 2",
                Location = new Point(350, 40),
                Size = new Size(160, 25),
                //BackColor = Color.LightBlue
            };
            this.Controls.Add(lbl_poisk);
            this.Controls.Add(lbl_razdel1);
            this.Controls.Add(lbl_razdel2);


            //--------Button---------//
            btn_start = new Button
            {
                Text = "Начать",
                Location = new Point(730, 480),
                Size = new Size(100, 50),
            };
            btn_start.Click += Btn_start_Click;

            btn_poisk = new Button
            {
                Text = "Поиск",
                Location = new Point(270, 470),
                Size = new Size(100, 60),
            };
            btn_poisk.Click += Btn_poisk_Click;

            btn_vihod = new Button
            {
                Text = "Выход",
                Location = new Point(400, 480),
                Size = new Size(130, 60),
            };
            btn_vihod.Click += Btn_vihod_Click;

            btn_sbros = new Button
            {
                Text = "Сброс",
                Location = new Point(400, 410),
                Size = new Size(130, 60),
            };
            btn_sbros.Click += Btn_sbros_Click;

            btn_ochistit_levo = new Button
            {
                Text = "Очистить",
                Location = new Point(40, 300),
                Size = new Size(130, 30),
            };
            btn_ochistit_levo.Click += Btn_ochistit_levo_Click;

            btn_udalit = new Button
            {
                Text = "Удалить",
                Location = new Point(200, 300),
                Size = new Size(130, 30),
            };

            btn_ochistit_pravo = new Button
            {
                Text = "Очистить",
                Location = new Point(360, 300),
                Size = new Size(130, 30),
            };
            btn_ochistit_pravo.Click += Btn_ochistit_pravo_Click;

            btn_sortirovat_levo = new Button
            {
                Text = "Сортировать",
                Location = new Point(40, 260),
                Size = new Size(130, 30),
            };

            btn_dobavit = new Button
            {
                Text = "Добавить",
                Location = new Point(200, 260),
                Size = new Size(130, 30),
            };

            btn_sortirovat_pravo = new Button
            {
                Text = "Сортировать",
                Location = new Point(360, 260),
                Size = new Size(130, 30),
            };

            btn_left = new Button
            {
                Text = "<",
                Location = new Point(220, 90),
                Size = new Size(100, 30),
            };

            btn_right = new Button
            {
                Text = ">",
                Location = new Point(220, 130),
                Size = new Size(100, 30),
            };

            btn_double_left = new Button
            {
                Text = "<<",
                Location = new Point(220, 170),
                Size = new Size(100, 30),
            };

            btn_double_right = new Button
            {
                Text = ">>",
                Location = new Point(220, 210),
                Size = new Size(100, 30),
            };
            this.Controls.Add(btn_start);
            this.Controls.Add(btn_poisk);

            this.Controls.Add(btn_vihod);
            this.Controls.Add(btn_sbros);

            this.Controls.Add(btn_ochistit_levo);
            this.Controls.Add(btn_udalit);
            this.Controls.Add(btn_ochistit_pravo);

            this.Controls.Add(btn_sortirovat_levo);
            this.Controls.Add(btn_dobavit);
            this.Controls.Add(btn_sortirovat_pravo);

            this.Controls.Add(btn_left);
            this.Controls.Add(btn_right);
            this.Controls.Add(btn_double_left);
            this.Controls.Add(btn_double_right);

            //-----------TekstBox----------------//
            txt_box = new TextBox
            {
                Location = new Point(50, 385),
                Size = new Size(160, 25),
            };
            this.Controls.Add(txt_box);

            //----------Richtextbox------------//
            rtb = new RichTextBox
            {
                Location = new Point(560, 30),
                Size = new Size(300, 400)
            };

            this.Controls.Add(rtb);


            //----------ListBox---------------------//
            listbox_niz = new ListBox()
            {
                Location = new Point(50, 410),
                Size = new Size(200, 130),
                SelectionMode = SelectionMode.MultiExtended
            };

            listbox_razdel1 = new ListBox()
            {
                Location = new Point(40, 90),
                Size = new Size(150, 170),
                SelectionMode = SelectionMode.MultiExtended
            };

            listbox_razdel2 = new ListBox()
            {
                Location = new Point(350, 90),
                Size = new Size(150, 170),
                SelectionMode = SelectionMode.MultiExtended
            };
            this.Controls.Add(listbox_niz);
            this.Controls.Add(listbox_razdel1);
            this.Controls.Add(listbox_razdel2);

            //--------GroupBox-------------------//
            gb1 = new GroupBox();
            gb1.Location = new Point(40, 340);
            gb1.Size = new Size(350, 200);
            gb1.BackColor = Color.LightBlue;
            gb1.Text = "Поиск";

            /*GroupBox gb2 = new GroupBox();
            gb2.Location = new Point(20, 30);
            gb2.Size = new Size(520, 520);
            gb2.BackColor = Color.LightCoral;
            gb2.Text = "Что-то тут будет";*/

            gb2 = new GroupBox();
            gb2.Location = new Point(560, 450);
            gb2.Size = new Size(300, 100);
            gb2.BackColor = Color.Aqua;
            gb2.Text = "Выбор слов";

            this.Controls.Add(gb1);
            this.Controls.Add(gb2);

            //------Panel--------//
            panel = new Panel();
            {
                panel.Location = new Point(20, 30);
                panel.Size = new Size(520, 520);
                panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            this.Controls.Add(panel);


        }

        private void Btn_poisk_Click(object sender, EventArgs e)
        {
            listbox_niz.Items.Clear();

            string Find = txt_box.Text;

            if (checkbox1.Checked)
            {
                foreach (string String in listbox_razdel1)
                {
                    if (String.Contains(Find)) listbox_niz.Items.Add(String);
                }
            }

            if (checkbox2.Checked)
            {
                foreach (string String in listbox_razdel2)
                {
                    if (String.Contains(Find)) listbox_niz.Items.Add(String);
                }
            }
        }

        private void Btn_ochistit_pravo_Click(object sender, EventArgs e)
        {
            listbox_razdel2.Items.Clear();
        }

        private void Btn_ochistit_levo_Click(object sender, EventArgs e)
        {
            listbox_razdel1.Items.Clear();
        }

        private void Btn_sbros_Click(object sender, EventArgs e)
        {
            listbox_razdel1.Items.Clear();
            listbox_razdel2.Items.Clear();

            rtb.Clear();
            /*rtb.Update();
            rtb.Clear();*/

            txt_box.Clear();

            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;

            checkbox1.Checked = false;
            checkbox2.Checked = false;
        }

        private void Btn_vihod_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            listbox_razdel1.Items.Clear();
            listbox_razdel2.Items.Clear();

            listbox_razdel1.BeginUpdate();

            string[] Strings = rtb.Text.Split(new char[] { '\n', '\t', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in Strings)
            {
                string Str = s.Trim();

                if (Str == String.Empty) continue;
                if (rb1.Checked) listbox_razdel1.Items.Add(Str);

                if (rb2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) listbox_razdel1.Items.Add(Str);
                }

                if (rb3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listbox_razdel1.Items.Add(Str);
                }
            }
            listbox_razdel1.EndUpdate();
        }

        private void NewItem1_Click(object sender, EventArgs e)
        {

            OpenFileDialog OpenDlg = new OpenFileDialog();

            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                rtb.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }

        private void NewItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog SaveDlg = new OpenFileDialog();

            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);

                for (int i = 0; i < listbox_razdel2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listbox_razdel2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }

        private void NewItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
